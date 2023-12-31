//This file is part of Tribes RPG.
//Tribes RPG server side scripts
//Written by Jason "phantom" Daley,  Matthiew "JeremyIrons" Bouchard, and more (yet undetermined)

//	Copyright (C) 2014  Jason Daley

//	This program is free software: you can redistribute it and/or modify
//	it under the terms of the GNU General Public License as published by
//	the Free Software Foundation, either version 3 of the License, or
//	(at your option) any later version.

//	This program is distributed in the hope that it will be useful,
//	but WITHOUT ANY WARRANTY; without even the implied warranty of
//	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//	GNU General Public License for more details.

//	You should have received a copy of the GNU General Public License
//	along with this program.  If not, see <http://www.gnu.org/licenses/>.

//You may contact the author at beatme101@gmail.com or www.tribesrpg.org/contact.php

//This GPL does not apply to Starsiege: Tribes or any non-RPG related files included.
//Starsiege: Tribes, including the engine, retains a proprietary license forbidding resale.


function GetWeight(%clientId)
{
	dbecho($dbechoMode, "GetWeight(" @ %clientId @ ")");

	if(IsDead(%clientId) || !fetchData(%clientId, "HasLoadedAndSpawned") || %clientId.IsInvalid)
		return 0;

	//== HELPS REDUCE LAG WHEN THERE ARE SIMULTANEOUS CALLS ======
	%time = getIntegerTime(true);
	if(%time - %clientId.lastGetWeight <= 1 && fetchData(%clientId, "tmpWeight") != "")
		return fetchData(%clientId, "tmpWeight");
	%clientId.lastGetWeight = %time;
	//============================================================

	$GetWeight::ArmorMod = "";
	%total = 0;

	// old add up items - much slower
	// %max = getNumItems();
	// for(%i = 0; %i < %max; %i++)
	// {
	// 	%checkItem = getItemData(%i);
	// 	%itemcount = Player::getItemCount(%clientId, %checkItem);

	// 	if(%itemcount)
	// 	{
	// 		%weight = GetAccessoryVar(%checkItem, $Weight);
	// 		if(%weight != "" && %weight != False)
	// 			%total += %weight * %itemcount;

	// 		//Replaces the laggy AddPoints(%clientId, 8) in RefreshWeight (the real lag comes from GetAccessoryList however)
	// 		%specialvar = GetAccessoryVar(%checkItem, $SpecialVar);
	// 		if(GetWord(%specialvar, 0) == 8 && %checkItem.className == Equipped)
	// 			$GetWeight::ArmorMod = GetWord(%specialvar, 1);
	// 	}
	// }

	// loop through equipped accessory items to modify their special vars
	%totalItems = GetEquippedAccessoriesCountByBeltType(%clientid, "AccessoryItems");
	%itemList = GetEquippedAccessoriesByBeltType(%clientid, "AccessoryItems");

	for(%i = 0; %i <= %totalItems; %i++) {
		%checkItem = getword(%itemList, %i);
		%specialvar = GetAccessoryVar(%checkItem, $SpecialVar);

		if(GetWord(%specialvar, 0) == 8) {
			$GetWeight::ArmorMod = GetWord(%specialvar, 1);
		}
	}

	//add belt items
	%total += Belt::GetWeight(%clientid);

	//add up coins
	// %total += fetchData(%clientId, "COINS") * $coinweight;

	storeData(%clientId, "tmpWeight", %total);
	return %total;
}

function RefreshWeight(%clientId)
{
	dbecho($dbechoMode2, "RefreshWeight(" @ %clientId @ ")");

	%player = Client::getOwnedObject(%clientId);

	if(!fetchData(%clientId, "SlowdownHitFlag"))
	{
		%weight = fetchData(%clientId, "Weight");
		
		%changeweightstep = 5;

		//determine the new armor to use
		// figure out if robed or not
		%race = fetchData(%clientId, "RACE");
		%currentArmor = Player::getArmor(%clientId);
		%isRobed = String::findSubStr(%currentArmor, "Robed") != -1;
		%isFemale = String::findSubStr(%currentArmor, "FemaleHuman") != -1;

		if (%isRobed) {
			if (%isFemale)
				%race = "FemaleHumanRobed";
			else
				%race = "MaleHumanRobed";
		}

		%newarmor = $ArmorForSpeed[%race, 0];
		%spill = %weight - fetchData(%clientId, "MaxWeight");

		%num = floor(%spill / %changeweightstep);

		if(%num > 0)
		{
			//overweight, select appropriate armor
			for(%i = -1; %i >= -%num; %i--)
			{
				if($ArmorForSpeed[%race, %i] != "") {
					%newarmor = $ArmorForSpeed[%race, %i];
				}
				else
					break;
			}
		}
		else
		{
			//when not overweight, the special armor-modifying items come in
			%x = $GetWeight::ArmorMod;
			if(%x > 0) {
				%newarmor = $ArmorForSpeed[%race, %x];
			}
		}
	}
	else {
		%newarmor = $ArmorForSpeed[%race, -5];
	}

	%a = Player::getArmor(%clientId);
	%ae = GameBase::getEnergy(%player);

	if(%a != %newarmor && %newarmor != "") {
		//set the new armor
		Player::setArmor(%clientId, %newarmor);
		GameBase::setEnergy(%player, %ae);
		//UseSkill(%clientId, $SkillWeightCapacity, True, True, 25);
	}

	//save the %num in a global variable for use on stats (in order to give penalties to other stats for being overweight)
	storeData(%clientId, "OverweightStep", %num);
}
