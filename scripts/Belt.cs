//This file is part of Tribes RPG.
//Tribes RPG server side scripts
//Belt system written by Jason "phantom" Daley, and Carling

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



// ---------------------------------------
// Tribes RPG Belt!!!
//
// Originally created by Carling
// 07/02/04
//
// Updated and ported by phantom
// 09-05-2010 - 04-05-2014
//
// Refactors and changes by LongBow
// 07-01-2025
// ---------------------------------------
// Adds a Belt option to tab menu designed to reduce number of itemdatas in server.
//
// This script requires many hookups into other files and will not run correctly without them.
//
// It was originally written for Salmons MoS.
// It has been recoded to be compatible TvT.
// And now, for Tribes RPG v6.0, by phantom.


// TODO:
// 1. Add Shorty quest line
// 2. 
// 3. And as a black mage now, at level 1, my white magic is starting at 25 and my black magic at 10
// 

// ------------------- //
// Menu Functions      //
// ------------------- //

$equippedString = "(+)";

function getDisp(%type) {
	%disp["AmmoItems"] = "Ammunition";
	%disp["GemItems"] = "Gems";
	%disp["PotionItems"] = "Potions";
	%disp["WeaponItems"] = "Weapons";
	%disp["ArmorItems"] = "Armors";
	%disp["MateriaItems"] = "Materia";
	%disp["QuestItems"] = "Quest Items";
	%disp["AccessoryItems"] = "Accessories";
	%disp["MiscItems"] = "Miscellaneous";

	return %disp[%type];
}

$belttypelist = "AmmoItems GemItems PotionItems WeaponItems ArmorItems MateriaItems QuestItems AccessoryItems MiscItems";

function belt::checkmenus(%clientId)
{
	%x = 0;
	for(%i = 0; getWord($belttypelist, %i) != "" && getWord($belttypelist, %i) != -1; %i++)
	{
		%type = getword($belttypelist,%i);
		%num = getword(Belt::GetNS(%clientid,%type),0);
		if(%num > 0){
			%x++;
			%nf = %nf @ " " @ getWord($belttypelist, %i);
		}
	}
	%nf = %x @ %nf;
	return %nf;
}


function MenuViewBelt(%clientId, %page, %victim)
{
	%victim = confirmVictim(%clientId, %victim);
	if(%victim == -1)
		return;

	$yourstats[%clientId] = True;
	%title = "Belt:";

	if(%victim != %clientId){
		%victimName = rpg::getname(%victim);
		%title = %victimName@"'s " @ %title;
	}

	Client::buildMenu(%clientId, %title, "ViewBelt", true);
	%cnt = -1;

	if(%victim == %clientId.currentInvSteal) {
		//%coins = fetchData(%victim, "COINS");
		//Client::addMenuItem(%clientId, string::getsubstr($menuChars,%cnt++,1) @ "Steal Coins (has "@%coins@")", "stealcoins "@%victim);
		if(!SkillCanUse(%clientId, "#pickpocket")){
			Client::sendMessage(%TrueClientId, 0, "Note: Require 270 Stealing to steal items.");
			return;
		}
	}

	%optionsPerPage = 7;
	if(%clientId.repack >= 18)
		%optionsPerPage = 32;

	// %nx = 16;
	%nf = belt::checkmenus(%victim);
	%ns = GetWord(%nf,0);
	%np = floor(%ns / %optionsPerPage);
	%lb = (%page * %optionsPerPage) - (%optionsPerPage-1);
	%ub = %lb + (%optionsPerPage-1);

	if(%ub > %ns)
		%ub = %ns;

	%x = %lb - 1;

	for(%i = %lb; %i <= %ub; %i++)
	{
		%x++;
		%type = getword(%nf,%x);

		if(%type == -1)
			break;

		%num = getword(Belt::GetNS(%victim, %type), 0);
		%beltTypeWeight = Belt::GetWeightByType(%clientid, %type);

		Client::addMenuItem(%clientId, string::getsubstr($menuChars,%cnt++,1) @ getDisp(%type) @ " ("@%num@" types, "@%beltTypeWeight@" wt)", %type@" "@%victim);
	}

	if(%page == 1) {
		if(%ns > %optionsPerPage) Client::addMenuItem(%clientId, "]Next >>", "page " @ %page+1);
	}
	else if(%page == 2) {
		Client::addMenuItem(%clientId, "[<< Prev", "page " @ %page-1);
	}
}

function processMenuViewBelt(%clientId, %opt)
{
	%o = GetWord(%opt, 0);
	%p = GetWord(%opt, 1);

	if(%o == "page")	
	{
		MenuViewBelt(%clientId, %p);
		return;
	}

	%victim = %p;
	if($count[%o] > 0)
	{
		MenuBeltGear(%clientid, %o, 1, %victim);
		return;
	}
	//if(%o == "stealcoins"){
	//	if(%victim == %clientId.currentInvSteal){
	//		newStealCoins(%clientId, %victim);
	//		return;
	//	}
	//}

	if(%o != "done")
		MenuViewBelt(%clientId, 1, %victim);

	return;
}

function MenuBeltGear(%clientid, %type, %page, %victim)
{
	%victim = confirmVictim(%clientId, %victim);
	if(%victim == -1)
		return;

	if(%victim != %clientId)
		%victimName = rpg::getname(%victim);

	%title = getDisp(%type);
	if(%victimName != "")
		%title = %victimName@"'s " @ %title;

	Client::buildMenu(%clientId, %title@":", "BeltGear", true);
	%clientId.bulkNum = "";

	%optionsPerPage = 6;
	if(%clientId.repack >= 18)
		%optionsPerPage = 30;

	// %nx = $count[%type];
	%nf = Belt::GetNS(%victim, %type);
	%ns = GetWord(%nf, 0);
	%np = floor(%ns / %optionsPerPage);
	%lb = (%page * %optionsPerPage) - (%optionsPerPage-1);
	%ub = %lb + (%optionsPerPage-1);

	if(%ub > %ns)
		%ub = %ns;

	%x = %lb - 1;
	%cnt = -1;
	for(%i = %lb; %i <= %ub; %i++) {
		%x++;
		%item = getword(%nf, %x);
		%amnt = Belt::HasThisStuff(%victim, %item);
		Client::addMenuItem(%clientId, string::getsubstr($menuChars,%cnt++,1) @%amnt@" "@ $beltitem[%item, "Name"], %item @ " " @ %page @" "@%type@" "@%victim);
	}

	if(%page == 1) {
		if(%ns > %optionsPerPage) Client::addMenuItem(%victim, "]Next >>", "page " @ %page+1 @" "@%type@" "@%victim);
		Client::addMenuItem(%clientId, "z<< Back", "back");
	}
	else if(%page == %np+1) {
		Client::addMenuItem(%clientId, "[<< Prev", "page " @ %page-1 @" "@%type@" "@%victim);
	}
	else {
		Client::addMenuItem(%clientId, "]Next >>", "page " @ %page+1 @" "@%type@" "@%victim);
		Client::addMenuItem(%clientId, "[<< Prev", "page " @ %page-1 @" "@%type@" "@%victim);
	}

	if (fetchData(%clientId, "MyHouse") != "")
		%house = fetchData(%clientId, "MyHouse");
	else
		%house = "No House";

	remoteEval(%clientId, "setInfoLine", 1, Client::getName(%clientId) @ ":");
	remoteEval(%clientId, "setInfoLine", 2, "HP: " @ fetchData(%clientId, "HP") @ "/" @ fetchData(%clientId, "MaxHP") @ " | MANA: " @ fetchData(%clientId, "MANA") @ "/" @ fetchData(%clientId, "MaxMANA") @ ":");
	remoteEval(%clientId, "setInfoLine", 3, "ATK: " @ fetchData(%clientId, "ATK") @ " | DEF: " @ fetchData(%clientId, "DEF") @ " | MDEF: " @ fetchData(%clientId, "MDEF") @ ":");
	remoteEval(%clientId, "setInfoLine", 4, "LCK: " @ fetchData(%clientId, "LCK") @ " | " @ %house @ " | RP: " @ fetchData(%clientId, "RankPoints") @ ":");
	remoteEval(%clientId, "setInfoLine", 5, "COINS: " @ fetchData(%clientId, "COINS") @ " | BANK: " @ fetchData(%clientId, "BANK") @ ":");
	remoteEval(%clientId, "setInfoLine", 6, "RL: " @ fetchData(%clientId, "RemortStep") @ ":");

	return;
}

function processMenuBeltGear(%clientid, %opt)
{
	%o = GetWord(%opt, 0);
	if(%o == "done")
		return;
	if(%o == "back"){
		MenuViewBelt(%clientId, 1, GetWord(%opt, 1));
		return;
	}
	%p = GetWord(%opt, 1);
	%t = GetWord(%opt, 2);
	%victim = GetWord(%opt, 3);

	if(%o != "page")
	{
		if(%clientId.bulkNum < 1)
			%clientId.bulkNum = 1;
		if(%clientId.bulkNum > 500)
			%clientId.bulkNum = 500;
	
		MenuBeltDrop(%clientid, %o, %t, %victim);
		return;
	}
	
	MenuBeltGear(%clientid, %t, %p, %victim);

	return;
}

function MenuBeltMateria(%clientid, %weaponItem, %page)
{
	%type = "MateriaItems";
	Client::buildMenu(%clientId, "Materia:", "BeltMateria", true);
	%clientId.bulkNum = "";

	%optionsPerPage = 6;
	if(%clientId.repack >= 18)
		%optionsPerPage = 30;

	// %nx = $count[%type];
	%nf = Belt::GetNS(%clientid, %type);
	%ns = GetWord(%nf,0);
	%np = floor(%ns / %optionsPerPage);
	%lb = (%page * %optionsPerPage) - (%optionsPerPage-1);
	%ub = %lb + (%optionsPerPage-1);

	if(%ub > %ns)
		%ub = %ns;

	%x = %lb - 1;
	%cnt = -1;
	for(%i = %lb; %i <= %ub; %i++) {
		%x++;
		%item = getword(%nf,%x);
		%amnt = Belt::HasThisStuff(%clientId, %item);
		Client::addMenuItem(%clientId, string::getsubstr($menuChars, %cnt++,1) @ %amnt @ " " @ $beltitem[%item, "Name"], %weaponItem @ " " @ %item @ " " @ %page);
	}

	if(%page == 1) {
		if(%ns > %optionsPerPage) Client::addMenuItem(%clientId, "]Next >>", "page " @ %page+1);
		Client::addMenuItem(%clientId, "z<< Back", "back");
	}
	else if(%page == %np+1) {
		Client::addMenuItem(%clientId, "[<< Prev", "page " @ %page-1);
	}
	else {
		Client::addMenuItem(%clientId, "]Next >>", "page " @ %page+1);
		Client::addMenuItem(%clientId, "[<< Prev", "page " @ %page-1);
	}

	return;
}

function processMenuBeltMateria(%clientId, %opt) {
	%o = GetWord(%opt, 0);

	if(%o == "done") return;

	if(%o == "back") {
		MenuViewBelt(%clientId, 1, GetWord(%opt, 1));
		return;
	}

	%materia = GetWord(%opt, 1);
	%page = GetWord(%opt, 2);

	if(%o != "page")
	{
		%enchant = String::replace(%materia, "Materia", "");
		%enchantedWeapon = %o @ %enchant;

		if ($beltitem[%o, "Enchantment"] != "") {
			Client::sendMessage(%clientId, $MsgWhite, "Enchanted weapons cannot be slotted with Materia.");
			return;
		}

		if (BeltItem::IsEquipped(%clientId, %o)) {
			Client::sendMessage(%clientId, $MsgWhite, "You cannot slot materia into your wepaon while it is eqipped.");
			return;
		}

        if ($beltitem[%enchantedWeapon, "Name"] != "") {
			Belt::TakeThisStuff(%clientid, %o, 1);
			Belt::TakeThisStuff(%clientid, %materia, 1);
			Belt::GiveThisStuff(%clientid, %enchantedWeapon, 1);
		
			Client::sendMessage(%clientId, $MsgWhite, "The " @ $beltitem[%materia, "Name"] @ " has been slotted into your " @ $beltitem[%o, "Name"] @ ".");
			// check if weapon is equipped or not, if it is unequip (and unmount)
			// then remove weapon + materia and add the combo result
		} else {
			Client::sendMessage(%clientId, $MsgWhite, "This weapon cannot be slotted with this Materia.");
		}
	
		return;
	}

	MenuBeltMateria(%clientid, %p);

	return;
}

function MenuBeltDrop(%clientid, %item, %type, %victim)
{
	%victim = confirmVictim(%clientId, %victim);
	if(%victim == -1)
		return;
	%cmnt = Belt::HasThisStuff(%victim, %item);
	%name = $beltitem[%item, "Name"];

	if(%victim != %clientId){
		%victimName = rpg::getname(%victim);
		if(%cmnt < 1){
			Client::sendMessage(%clientId, $MsgWhite, %victimName@" doesn't have any "@%name);
			return;
		}
	}
	// if(%cmnt < 1){
	// 	Client::sendMessage(%clientId, $MsgWhite, "you don't have any "@%name);
	// 	return;
	// }


	if(%clientId.bulkNum == "")
		%clientId.bulkNum = 1;
	%amnt = %clientId.bulkNum;
	%amnt = floor(%amnt);
	if(%amnt > %cmnt)
		%amnt = %cmnt;

	Client::buildMenu(%clientId, %name@" ("@%cmnt@")", "BeltDrop", true);

	if(%victimName != ""){
		if(%victim == %clientId.currentInvSteal){
			%disp = getDisp(%type);
			if(%type == "WeaponItems" || %type == "ClothingItems")
				Client::addMenuItem(%clientId, %cnt++ @ "(can't steal "@%disp@")", %type@" examine "@%item@" "@ %amnt @" "@%victim);
			else
				Client::addMenuItem(%clientId, %cnt++ @ "Steal 1 "@%item, %type@" steal "@%item@" 1 "@%victim);
		}
		Client::addMenuItem(%clientId, %cnt++ @ "Examine", %type@" examine "@%item@" "@ %amnt @" "@%victim);
		Client::addMenuItem(%clientId, "z<< Back", %type@" back "@%victim);
		return;
	}

	if(%type == "AmmoItems"){
		%curweap = GetEquippedWeapon(%clientId);
		%baseWeapon = $beltitem[%curweap, "BaseWeapon"];
		if(String::findSubStr($ProjRestrictions[%item], "," @ %curweap @ ",") != -1 || String::findSubStr($ProjRestrictions[%item], "," @ %baseWeapon @ ",") != -1){
			Client::addMenuItem(%clientId, %cnt++ @ "Equip to "@%curweap, %type@" arm "@%item);
		}
	}
	else if(%type == "PotionItems" || %type == "MiscItems") {
		Client::addMenuItem(%clientId, %cnt++ @ "Use", %type@" use "@%item);
	}
	else if(%type == "WeaponItems") {
		// check myhere if it is equipped or not
		if (BeltItem::isEquipped(%clientId, %item)) {
			Client::addMenuItem(%clientId, %cnt++ @ "Unequip", %type@" equip "@%item);
		} else {
			Client::addMenuItem(%clientId, %cnt++ @ "Equip", %type@" equip "@%item);
		}

		if ($beltitem[%item, "Enchantment"] == "") {
			Client::addMenuItem(%clientId, %cnt++ @ "Slot", %type @ " slot " @ %item);
		}
	}
	else if(%type == "ArmorItems") {
		if (BeltItem::isEquipped(%clientId, %item)) {
			Client::addMenuItem(%clientId, %cnt++ @ "Unequip", %type@" equip "@%item);
		} else {
			Client::addMenuItem(%clientId, %cnt++ @ "Equip", %type@" equip "@%item);
		}
	}
	else if(%type == "AccessoryItems") {
		if (BeltItem::isEquipped(%clientId, %item)) {
			Client::addMenuItem(%clientId, %cnt++ @ "Unequip", %type@" equip "@%item);
		} else {
			Client::addMenuItem(%clientId, %cnt++ @ "Equip", %type@" equip "@%item);
		}
	}

	if(!$playerNoDrop[%item]){
		Client::addMenuItem(%clientId, %cnt++ @ "Drop "@%amnt, %type@" drop "@%item@" "@%amnt);

		if(%cmnt > 50 && %cmnt != %amnt)
			Client::addMenuItem(%clientId, %cnt++ @ "Drop 50", %type@" dropb "@%item@" 50");
		if(%cmnt <= 100 && %cmnt != %amnt)
			Client::addMenuItem(%clientId, %cnt++ @ "Drop "@%cmnt, %type@" dropb "@%item@" "@%cmnt);
		else if(%cmnt > 100 && %cmnt != %amnt){
			Client::addMenuItem(%clientId, %cnt++ @ "Drop 100", %type@" dropb "@%item@" 100");
			Client::addMenuItem(%clientId, %cnt++ @ "Drop "@%cmnt, %type@" dropb "@%item@" "@%cmnt);
		}
	}

	Client::addMenuItem(%clientId, %cnt++ @ "Examine", %type@" examine "@%item);
	Client::addMenuItem(%clientId, "z<< Back", %type@" back");


	// %msg = "";
	// %msg = %msg @ "<f1>" @ %desc @ %loc @ "\n";
	// %msg = %msg @ "\nBonuses: " @ WhatSpecialVars(%item);
	// if(%s != "")
	// 	%msg = %msg @ "\nSkill Type: " @ %s;
	// %msg = %msg @ "\nRestrictions: " @ WhatSkills(%item);
	// if(%belt)
	// 	%msg = %msg @ "\nCategory: Belt: " @ getDisp($beltitem[%item, "Type"]);
	// if(%w != "")
	// 	%msg = %msg @ "\nWeight: " @ %w;
	// if(%c != "")
	// 	%msg = %msg @ "\nPrice: $" @ %c;
	// if(%sd != "")
	// 	%msg = %msg @ "\nDelay: " @ %sd @ " sec";
	// if(%sr != "")
	// 	%msg = %msg @ "\nRecovery: " @ %sr @ " sec";
	// if(%sm != "")
	// 	%msg = %msg @ "\nMana: " @ %sm;

	// %msg = %msg @ "\n\n<f0>" @ %nfo;

	// %t = GetAccessoryVar(%item, $AccessoryType);
	%w = GetAccessoryVar(%item, $Weight);
	%c = GetItemCost(%item);
	%s = $SkillDesc[$SkillType[%item]];

	remoteEval(%clientId, "setInfoLine", 1, %name @ ":");
	remoteEval(%clientId, "setInfoLine", 2, "Bonuses: " @ WhatSpecialVars(%item));
	remoteEval(%clientId, "setInfoLine", 3, "Required Skills: " @ WhatSkills(%item));
	remoteEval(%clientId, "setInfoLine", 4, "Weight: " @ %w);
	remoteEval(%clientId, "setInfoLine", 5, "Cost: " @ %c);
	remoteEval(%clientId, "setInfoLine", 6, $AccessoryVar[%item, $MiscInfo]);

	return;
}

function processMenuBeltDrop(%clientId, %opt, %keybind)
{
	%type = GetWord(%opt, 0);
	%option = GetWord(%opt, 1);
	%item = GetWord(%opt, 2);
	%amnt = GetWord(%opt, 3);
	%amnt = floor(%amnt);

	if(%amnt <= 0) %amnt = 1;

	%victim = GetWord(%opt, 4);

	if(isDead(%clientId))
		return;
	if(IsJailed(%clientId)) {
		Client::sendMessage(%clientId, $MsgWhite, "You can't do that in jail.");
		return;
	}
	%clientId.tabMenuSpam++;
	if(%clientId.tabMenuSpam > 20) {
		exploitBan(%clientId, "Item spam", 5);
		return;
	}
	if(%option == "back") {
		MenuBeltGear(%clientId, %type, 1, %item);
		return;
	}
	else if(%option == "examine") {
		WhatIs(%clientId, %item);
		MenuBeltDrop(%clientid, %item, %type, %victim);
		return;
	}
	else if(%option == "equip") {
		Belt::EquipItem(%clientid, %item);
		// MenuBeltDrop(%clientid, %item, %type, %victim);
		MenuBeltGear(%clientId, %type, 1, %item);
		return;
	}
	else if(%option == "slot") {
		MenuBeltMateria(%clientId, %item, 1);
		return;
	}

	if(%option == "dropb")
		%clientId.bulkNum = %amnt;
	if(%option == "breakb")
		%clientId.bulkNum = %amnt;
	
	if(%amnt != %clientId.bulkNum)
	{
		if(%clientId.bulkNum < 1)	%clientId.bulkNum = 1;


		if(%clientId.bulkNum > 500)	%clientId.bulkNum = 500;
		MenuBeltDrop(%clientid, %item, %type);
		return;
	}

	else if(%option == "steal")
	{
		startSteal(%clientId, %item);
	}
	else if(%option == "drop")
	{
		%cmnt = belt::hasthisstuff(%clientId, %item);

		if(%amnt > %cmnt)
			return;

		if($playerNoDrop[%item]) {
			Client::sendMessage(%clientId, $MsgWhite, "Sorry. Can't drop that. Reasons.");
			return;
		}

		// TODO: check if armor is equipped
		if (%type == "WeaponItems" && BeltItem::isEquipped(%clientId, %item)) {
			Client::sendMessage(%clientId, $MsgWhite, "You cannot drop equipped weapon.");
			return;
		}
		
		if (%type == "ArmorItems" && BeltItem::isEquipped(%clientId, %item)) {
			Client::sendMessage(%clientId, $MsgWhite, "You cannot drop equipped armor.");
			return;
		}

		if (%type == "AccessoryItems" && BeltItem::isEquipped(%clientId, %item)) {
			Client::sendMessage(%clientId, $MsgWhite, "You cannot drop equipped accessories.");
			return;
		}

		Belt::DropItem(%clientid,%item,%amnt,%type);

		if(belt::hasthisstuff(%clientId, %item) > 0)
			MenuBeltDrop(%clientid, %item, %type);

		// check if the dropped item was equipped
		if (%type == "WeaponItems") {
			if (%item == Player::getMountedItem(%clientid, $WeaponSlot)) {
				if (belt::hasthisstuff(%clientId, %item) < 1) {
					Player::unMountItem(%clientId, $WeaponSlot);
				}
			}
		}
	}
	else if(%option == "dropb")
	{
			%cmnt = belt::hasthisstuff(%clientId,%item);
			if(%amnt > %cmnt)
				return;

			Belt::DropItem(%clientid,%item,%amnt,%type);
			if(belt::hasthisstuff(%clientId, %item) > 0){
				%clientId.bulkNum = 1;
				MenuBeltDrop(%clientid, %item, %type);
			}
	}
	else if(%option == "arm")
	{
		if(%type == "AmmoItems"){
			%curweap = GetEquippedWeapon(%clientId);
			%baseWeapon = $beltitem[%curweap, "BaseWeapon"];
			if(String::findSubStr($ProjRestrictions[%item], "," @ %curweap @ ",") != -1 || String::findSubStr($ProjRestrictions[%item], "," @ %baseWeapon @ ",") != -1){
				storeData(%clientId, "LoadedProjectile " @ %curweap, %item);
				Client::sendMessage(%clientId, $MsgBeige, rpg::EnglishItem(%item) @ " loaded as projectile for "@ %curweap @".");
				playSound(SoundPickupItem, GameBase::getPosition(%clientId));
			}
			else
				Client::sendMessage(%clientId, $MsgRed, "This projectile cannot be loaded into the weapon you have equipped.");
		}
	}
	else if(%option == "use")
	{
		%itemUsed = False;
		%has = belt::hasthisstuff(%clientId, %item);

		if(%has < 1)
			return;

		// check if health item
		if ($restoreValue[%item, HP] > 0) {
			refreshHP(%clientId, $restoreValue[%item, HP] * -0.01);
			%itemUsed = True;
		}
		
		// check if mana item
		if ($restoreValue[%item, MP] > 0) {
			refreshMANA(%clientId, $restoreValue[%item, MP] * -1);
			%itemUsed = True;
		}

		if ($restoreValue[%item, EXP] > 0) {
			addEXP(%clientId, $restoreValue[%item, EXP]);
			%itemUsed = True;
		}

		// check if location change item
		if ($beltitem[%item, "targetPosition"]) {
			schedule("gamebase::setPosition(" @ %clientId @ ", \"" @ $beltitem[%item, "targetPosition"] @ "\");", 1);

			if ($beltitem[%item, "targetRotationZ"]) {
				schedule("gamebase::setRotation(" @ %clientId @ ", \"0 0 " @ $beltitem[%item, "targetRotationZ"] @ "\");", 1);
			}
			%itemUsed = True;
		}

		if ($beltitem[%item, "reusable"]) {
			// If the item is reusable, we can use it without consuming it
			Client::sendMessage(%clientId, $MsgWhite, "You used " @ $beltitem[%item, "Name"] @ ".");
			%itemUsed = True;
		} else {
			belt::takethisstuff(%clientId, %item, 1);
			%has--;
			Client::sendMessage(%clientId, $MsgWhite, "You used " @ $beltitem[%item, "Name"] @ ". [have " @ %has @ "]");
			refreshAll(%clientId);
			%itemUsed = True;
		}

		if (%itemUsed) {
			// play sound if it exists
			if ($beltitem[%item, "useSound"] != "")
				playSound($beltitem[%item, "useSound"], GameBase::getPosition(%clientId));
		} else {
			Client::sendMessage(%clientId, $MsgWhite, "You cannot use " @ $beltitem[%item, "Name"] @ ".");
		}
					
		if (!%keybind) {
			if (%has > 0)
				MenuBeltDrop(%clientid, %item, %type);
		}
	}
	
	%clientId.bulkNum = 1;
	return;
}


function belt::buildMainMenu(%clientId, %page) {
	%l = 6;
	if(%clientId.repack >= 18)
		%l = 31;

	// %nx = 15;
	%nf = belt::checkmenus(%clientId);
	%ns = GetWord(%nf,0);

	%np = floor(%ns / %l);
	%lb = (%page * %l) - (%l-1);
	%ub = %lb + (%l-1);

	if(%ub > %ns)
		%ub = %ns;

	%x = %lb - 1;
	%curItem = -1;

	for(%i = %lb; %i <= %ub; %i++) {
		%x++;
		%type = getword(%nf,%x);
		if(%type == -1)
			break;
		%num = getword(Belt::GetNS(%clientid,%type),0);
		Client::addMenuItem(%clientId, string::getsubstr($menuChars,%curItem++,1) @ getDisp(%type) @ " ("@%num@" kinds)", %type);
	}

	if(%page == 1) {
		if(%ns > %l) Client::addMenuItem(%clientId, "]Next >>", "page " @ %page+1);
	}
	else if(%page == 2) {
		Client::addMenuItem(%clientId, "[<< Prev", "page " @ %page-1);
	}
}

function MenuSellBelt(%clientId, %page) {
	Client::buildMenu(%clientId, "Sell:", "SellBelt", true);

	if(%page == "")
		%page = 1;

	belt::buildMainMenu(%clientId, %page);
	Client::addMenuItem(%clientId, "bBuy", "buy");
	Client::addMenuItem(%clientId, "xDone", "done");

	return;
}

function processMenuSellBelt(%clientId, %opt) {
	%o = GetWord(%opt, 0);
	%p = GetWord(%opt, 1);

	if (%o == "done") {
		ClearCurrentShopVars(%clientId);
	}

	if(%o == "page") {
		MenuSellBelt(%clientId, %p);
		return;
	}

	if($count[%opt] > 0) {
		MenuSellBeltItem(%clientid, %opt, 1);
		return;
	}

	if(%opt == "buy") {
		MenuBuyBeltItem(%clientid, 1);
		return;
	}
	else if(%opt != "done")
		MenuSellBelt(%clientId);

	return;
}


function MenuSellBeltItem(%clientid, %type, %page) {
	%disp = getDisp(%type);

	Client::buildMenu(%clientId, %disp@" sell:", "SellBeltItem", true);
	%clientId.bulkNum = "";

	%l = 6;
	// %nx = $count[%type];
	%nf = Belt::GetNS(%clientid, %type);
	%ns = GetWord(%nf,0);
	%np = floor(%ns / %l);
	%lb = (%page * %l) - (%l-1);
	%ub = %lb + (%l-1);

	if(%ub > %ns)
		%ub = %ns;

	%x = %lb - 1;
	for(%i = %lb; %i <= %ub; %i++) {
		%x++;
		%item = getword(%nf, %x);
		%amnt = Belt::HasThisStuff(%clientid, %item);
		Client::addMenuItem(%clientId, %cnt++ @%amnt@" "@ $beltitem[%item, "Name"], %item @ " " @ %page @" "@%type);
	}

	if(%page == 1) {
		if(%ns > 6) Client::addMenuItem(%clientId, "]Next >>", "page " @ %page+1 @" "@%type);
		Client::addMenuItem(%clientId, "bBack", "back");
		Client::addMenuItem(%clientId, "xDone", "done");
	}
	else if(%page == %np+1) {
		Client::addMenuItem(%clientId, "[<< Prev", "page " @ %page-1 @" "@%type);
		Client::addMenuItem(%clientId, "bBack", "back");
		Client::addMenuItem(%clientId, "xDone", "done");
	}
	else {
		Client::addMenuItem(%clientId, "]Next >>", "page " @ %page+1 @" "@%type);
		Client::addMenuItem(%clientId, "[<< Prev", "page " @ %page-1 @" "@%type);
	}

	return;
}


function MenuBuyBeltItem(%clientid, %page)
{
	Client::buildMenu(%clientId, "Buy:", "BuyBeltItem", true);

	%clientId.bulkNum = "";
	%id = %clientId.beltShop;
	%botname = %id.name;

	%l = 5;
	if(%clientId.repack >= 18)
		%l = 31;

	%shopList = $BotInfo[%botname, BELTSHOP];

	if(%shopList != "") {
		for(%i = 0; GetWord(%shopList, %i) != -1; %i++) {
			%shopIndex = GetWord(%shopList, %i);
			
			// Old way, loop through ALL items to find the item with matching shop index
			// %max = $numBeltItems;
			// for(%z = 0; %z < %max; %z++) {
			// 	%item = $beltItemData[%z];
			// 	if($AccessoryVar[%item, $ShopIndex] == %a) {
			// 		%nf = %nf @ " " @ %item;
			// 	}
			// }

			// New way, store reference to item by shop index (more memory, less CPU - which do we need more?)
			%item = $beltItemShopIndexToItem[%shopIndex];

			if (%item != "") {
				%itemList = %itemList @ " " @ %item;
			}
		}

		%itemList = %i @ " " @ %itemList;
	}
	else
		%itemList = 0;

	%ns = %i; // NUMBER OF ITEMS SOLD AT SHOP
	%lb = (%page * %l) - (%l-1);
	%np = floor(%ns / %l);
	%ub = %lb + (%l-1);

	if(%ub > %ns) {
		%ub = %ns;
	}

	%x = %lb - 1;
	%cnt = -1;

	for(%i = %lb; %i <= %ub; %i++) {
		%x++;
		%item = getword(%itemList, %x);
		Client::addMenuItem(%clientId, string::getsubstr($menuChars, %cnt++,1) @ $beltitem[%item, "Name"], %item @ " " @ %page);
	}

	if(%page == 1) {
		if(%ns > %l) Client::addMenuItem(%clientId, "]Next >>", "page " @ %page + 1);
		Client::addMenuItem(%clientId, "sSell", "sell");
	}
	else if(%page == %np + 1) {
		Client::addMenuItem(%clientId, "[<< Prev", "page " @ %page - 1);
	}
	else {
		Client::addMenuItem(%clientId, "]Next >>", "page " @ %page + 1);
		Client::addMenuItem(%clientId, "[<< Prev", "page " @ %page - 1);
	}

	Client::addMenuItem(%clientId, "xDone", "done");

	return;
}

function processMenuSellBeltItem(%clientid, %opt) {
	%o = GetWord(%opt, 0);
	%p = GetWord(%opt, 1);
	%t = GetWord(%opt, 2);

	if (%o == "done") {
		ClearCurrentShopVars(%clientId);
		return;
	}

	if (%o == "back") {
		MenuSellBelt(%clientId);
		return;
	}

	if(%o != "page" && %o != "done") {
		if(%clientId.bulkNum < 1)	%clientId.bulkNum = 1;
		if(%clientId.bulkNum > 500)	%clientId.bulkNum = 500;
		MenuSellBeltItemFinal(%clientid, %o, %t);
		return;
	}

	if(%o != "done")
		MenuSellBeltItem(%clientid, %t, %p);

	return;
}

function processMenuBuyBeltItem(%clientid, %opt) {
	%o = GetWord(%opt, 0);
	%p = GetWord(%opt, 1);

	if (%o == "done") {
		ClearCurrentShopVars(%clientId);
	}

	if(%o == "sell") {
		Belt::Sell(%clientId, %clientId.beltShop, 1);
		return;
	}
	if(%o != "page" && %o != "done") {
		if(%clientId.bulkNum < 1)	%clientId.bulkNum = 1;
		if(%clientId.bulkNum > 500)	%clientId.bulkNum = 500;
		MenuBuyBeltItemFinal(%clientid, %o);
		return;
	}

	if(%o != "done")
		MenuBuyBeltItem(%clientid, %p);

	return;
}

function MenuSellBeltItemFinal(%clientid, %item, %type) {
	%name = $beltitem[%item, "Name"];
	%amnt = %clientId.bulkNum;
	%cmnt = Belt::HasThisStuff(%clientid,%item);

	if(%amnt > %cmnt)
		%amnt = %cmnt;

	Client::buildMenu(%clientId, %name@" ("@%cmnt@")", "SellBeltItemFinal", true);
	%cost = Belt::GetSellCost(%clientid,%item);
	Client::addMenuItem(%clientId, %cnt++ @ "Sell "@%amnt@" for "@Number::Beautify(%cost * %amnt)@" coins.", %type@" sell "@%item@" "@%amnt);

	if(%cmnt != %amnt)
		Client::addMenuItem(%clientId, %cnt++ @ "Sell "@%cmnt@" (all) for "@Number::Beautify(%cost * %cmnt)@" coins.", %type@" sellall "@%item@" "@%cmnt);

	Client::addMenuItem(%clientId, "zBack", %type@" back");
	return;
}


function MenuBuyBeltItemFinal(%clientid, %item) {
	if($AccessoryVar[%item,$ShopIndex] == "")
		return;

	%id = %clientId.beltShop;
	%botname = %id.name;
	if(String::findSubStr($BotInfo[%botname, BELTSHOP],$AccessoryVar[%item,$ShopIndex]) == -1)
		return;


	%name = $beltitem[%item, "Name"];
	%amnt = %clientId.bulkNum;
	%cmnt = 100;

	if(%amnt > %cmnt)
		%amnt = %cmnt;

	Client::buildMenu(%clientId, %name, "BuyBeltItemFinal", true);
	%cost = getBuyCost(%clientId, %item);

	Client::addMenuItem(%clientId, %cnt++ @ "Buy "@%amnt@" for "@Number::Beautify(%cost * %amnt)@" coins.", "buy "@%item@" "@%amnt);
	%cmnt = 10;
	if(%cmnt != %amnt)
		Client::addMenuItem(%clientId, %cnt++ @ "Buy "@%cmnt@" for "@Number::Beautify(%cost * %cmnt)@" coins.", "buy "@%item@" "@%cmnt);
	%cmnt = 25;
	if(%cmnt != %amnt)
		Client::addMenuItem(%clientId, %cnt++ @ "Buy "@%cmnt@" for "@Number::Beautify(%cost * %cmnt)@" coins.", "buy "@%item@" "@%cmnt);
	%cmnt = 50;
	if(%cmnt != %amnt)
		Client::addMenuItem(%clientId, %cnt++ @ "Buy "@%cmnt@" for "@Number::Beautify(%cost * %cmnt)@" coins.", "buy "@%item@" "@%cmnt);
	%cmnt = 100;
	if(%cmnt != %amnt)
		Client::addMenuItem(%clientId, %cnt++ @ "Buy "@%cmnt@" for "@Number::Beautify(%cost * %cmnt)@" coins.", "buy "@%item@" "@%cmnt);

	Client::addMenuItem(%clientId, "eExamine", "examine "@%item);
	Client::addMenuItem(%clientId, "xCancel", "done");
	Client::addMenuItem(%clientId, "bBack", "back");

	remoteEval(%clientId, "setInfoLine", 1, %name@":");

	%s = $SkillDesc[$SkillType[%item]];
	if(%s != "")
		remoteEval(%clientId, "setInfoLine", 2, "Skill: "@%s);

	remoteEval(%clientId, "setInfoLine", 3, WhatSpecialVars(%item));

	remoteEval(%clientId, "setInfoLine", 4, "Restrictions: "@WhatSkills(%item));

	%w = GetAccessoryVar(%item, $Weight);
	if(%w == "")
		%w = 0;

	remoteEval(%clientId, "setInfoLine", 5, "Weight: " @ fixDecimals(%w));
	remoteEval(%clientId, "setInfoLine", 6, $AccessoryVar[%item, $MiscInfo]);

	return;
}

function processMenuBuyBeltItemFinal(%clientId, %opt) {
	%option = GetWord(%opt, 0);
	%item = GetWord(%opt, 1);
	%amnt = GetWord(%opt, 2);
	%amnt = floor(%amnt);

	if(%option == "done") {
		ClearCurrentShopVars(%clientId);
	}
	else if(%option == "back") {
		MenuBuyBeltItem(%clientid, 1);
		return;
	}
	else if(%option == "examine") {
		WhatIs(%clientId, %item);
		MenuBuyBeltItemFinal(%clientid, %item);
		return;
	}
	else if(%option == "buy") {
		if(%clientId.beltShop != "") {
			%clientPos = GameBase::getPosition(%clientId);
			%botPos = GameBase::getPosition(%clientid.beltShop);
			%dist = Vector::getDistance(%clientPos, %botPos);

			if(%dist > 20) {
				ClearCurrentShopVars(%clientId);
				return;
			}

			if($AccessoryVar[%item,$ShopIndex] == "")
				return;

			%id = %clientId.beltShop;
			%botname = %id.name;

			if(String::findSubStr($BotInfo[%botname, BELTSHOP],$AccessoryVar[%item,$ShopIndex]) == -1)
				return;

			%cost = getBuyCost(%clientid,%item) * %amnt;
			%player = Client::getOwnedObject(%clientId);

			if(checkResources(%player, %item, %cost, %clientId.bulkNum) && !IsDead(%clientId)) {
				%name = $beltitem[%item, "Name"];
				UseSkill(%clientId, $SkillHaggling, True, True);
				storeData(%clientId, "COINS", %cost, "dec");
				Belt::GiveThisStuff(%clientid,%item,%amnt);
				Client::SendMessage(%clientId, $MsgWhite, "You purchased "@%amnt@" "@%name@" for "@%cost@" coins.~wbuysellsound.wav");
				RefreshAll(%clientId);
				%clientId.bulkNum = 1;

				MenuBuyBeltItem(%clientid, 1);
				return;
			}
		}
	}

	%clientId.beltShop = "";
	return;
}

function processMenuSellBeltItemFinal(%clientId, %opt)
{
	%type = GetWord(%opt, 0);
	%option = GetWord(%opt, 1);
	%item = GetWord(%opt, 2);
	%amnt = GetWord(%opt, 3);
	%amnt = floor(%amnt);

	if(%option == "done") {
		ClearCurrentShopVars(%clientId);
	}
	else if(%option == "back") {
		MenuSellBeltItem(%clientid, %type, 1);
		return;
	}
	else if(%option == "sellall") {
		%clientPos = GameBase::getPosition(%clientId);
		%botPos = GameBase::getPosition(%clientId.beltShop);
		%dist = Vector::getDistance(%clientPos, %botPos);

		if(%dist > 20) {
			ClearCurrentShopVars(%clientId);
			return;
		}

		%itemCnt = belt::hasthisstuff(%clientId, %item);

		if(%itemCnt != %amnt)
			return;

		if(BeltItem::IsEquipped(%clientId, %item)) {
			Client::sendMessage(%clientId, $MsgRed, "You cannot sell equipped items.");
			return;
		}

		%cost = Belt::GetSellCost(%clientid,%item) * %amnt;
		UseSkill(%clientId, $SkillHaggling, True, True);
		storeData(%clientId, "COINS", %cost, "inc");
		Belt::TakeThisStuff(%clientid,%item,%amnt);
		Client::SendMessage(%clientId, $MsgWhite, "You received "@ Number::Beautify(%cost)@" coins.~wbuysellsound.wav");
		RefreshAll(%clientId);
		%clientId.bulkNum = 1;

		MenuSellBeltItem(%clientid, %type, 1);
		return;
	}
	else if(%clientId.bulkNum != %amnt) {
		if(%clientId.bulkNum < 1)	%clientId.bulkNum = 1;
		if(%clientId.bulkNum > 500)	%clientId.bulkNum = 500;
		MenuSellBeltItemFinal(%clientid, %item, %type);
	}
	else if(%option == "sell") {
		if(BeltItem::IsEquipped(%clientId, %item)) {
			Client::sendMessage(%clientId, $MsgRed, "You cannot sell equipped items.");
			return;
		}

		%cmnt = Belt::HasThisStuff(%clientid, %item);

		if(%cmnt >= %amnt) {
			%clientPos = GameBase::getPosition(%clientId);
			%botPos = GameBase::getPosition(%clientId.beltShop);
			%dist = Vector::getDistance(%clientPos, %botPos);

			if(%dist > 20) {
				ClearCurrentShopVars(%clientId);
				return;
			}

			%cost = Belt::GetSellCost(%clientid,%item) * %amnt;
			UseSkill(%clientId, $SkillHaggling, True, True);
			storeData(%clientId, "COINS", %cost, "inc");
			Belt::TakeThisStuff(%clientid,%item,%amnt);
			Client::SendMessage(%clientId, $MsgWhite, "You received "@ Number::Beautify(%cost) @" coins.~wbuysellsound.wav");
			RefreshAll(%clientId);
			%clientId.bulkNum = 1;

			MenuSellBeltItem(%clientid, %type, 1);
			return;
		}
	}

	return;
}


//-----------------------------------------------------------------
function MenuStoreBelt(%clientId, %page) {
	Client::buildMenu(%clientId, "Belt store:", "StoreBelt", true);

	if(%page == "")
		%page = 1;

	belt::buildMainMenu(%clientId, %page);

	Client::addMenuItem(%clientid, "wWithdraw","withdraw");
	Client::addMenuItem(%clientid, "xDone", "done");
}

function processMenuStoreBelt(%clientId, %opt) {
	%o = GetWord(%opt, 0);
	%p = GetWord(%opt, 1);

	if(%o == "page") {
		MenuStoreBelt(%clientId, %p);
		return;
	}

	if($count[%opt] > 0) {
		MenuStoreBeltItem(%clientid, %opt, 1);
		return;
	}

	if(%opt == "withdraw") {
		MenuWithdrawBelt(%clientId);
		return;
	}

	if (%opt == "done") {
		ClearCurrentShopVars(%clientId);
		return;
	}

	if(%opt != "done")
		MenuStoreBelt(%clientId);

	return;
}
function belt::checkbankmenus(%clientId) {
	%x = 0;

	for(%i = 0; getWord($belttypelist, %i) != "" && getWord($belttypelist, %i) != -1; %i++) {
		%type = getword($belttypelist,%i);
		%num = getword(Belt::BankGetNS(%clientid,%type),0);

		if(%num > 0){
			%x++;
			%nf = %nf @ " " @ getWord($belttypelist, %i);
		}
	}

	%nf = %x @ %nf;
	return %nf;
}
function belt::buildBankMenu(%clientId, %page){
	%l = 6;
	if(%clientId.repack >= 18)
		%l = 31;

	// %nx = 15;
	%nf = belt::checkbankmenus(%clientId);
	%ns = GetWord(%nf, 0);

	%np = floor(%ns / %l);
	%lb = (%page * %l) - (%l-1);
	%ub = %lb + (%l-1);

	if(%ub > %ns)
		%ub = %ns;

	%x = %lb - 1;
	%curItem = -1;

	for(%i = %lb; %i <= %ub; %i++) {
		%x++;
		%type = getword(%nf, %x);

		if(%type == -1)
			break;

		%num = getword(Belt::BankGetNS(%clientid, %type), 0);
		Client::addMenuItem(%clientId, string::getsubstr($menuChars,%curItem++,1) @ getDisp(%type) @ " ("@%num@" kinds)", %type);
	}

	if(%page == 1)
	{
		if(%ns > %l) Client::addMenuItem(%clientId, "]Next >>", "page " @ %page+1);
	}
	else if(%page == 2)
	{
		Client::addMenuItem(%clientId, "[<< Prev", "page " @ %page-1);
	}
}
function MenuWithdrawBelt(%clientId, %page)
{
	Client::buildMenu(%clientId, "Belt Withdraw:", "WithdrawBelt", true);

	if(%page == "")
		%page = 1;

	belt::buildBankMenu(%clientId, %page);

	Client::addMenuItem(%clientid, "sStore", "store");
	Client::addMenuItem(%clientid, "xDone", "done");
}
function processMenuWithdrawBelt(%clientId, %opt)
{
	%o = GetWord(%opt, 0);
	%p = GetWord(%opt, 1);

	if(%o == "page")
	{
		MenuWithdrawBelt(%clientId, %p);
		return;
	}
	if($count[%opt] > 0)
	{
		MenuWithdrawBeltItem(%clientid, %opt, 1);
		return;
	}

	if(%opt == "store")
	{
		MenuStoreBelt(%clientId);
		return;
	}

	if(%opt == "done") {
		ClearCurrentShopVars(%clientId);
		return;
	}

	if(%opt != "done")
		MenuWithdrawBelt(%clientId);

	return;
}
function MenuStoreBeltItem(%clientid, %type, %page)
{
	%disp = getDisp(%type);
	Client::buildMenu(%clientId, %disp@" store:", "StoreBeltItem", true);
	%clientId.bulkNum = "";

	%l = 6;
	if(%clientId.repack >= 18)
		%l = 30;

	// %nx = $count[%type];
	%nf = Belt::GetNS(%clientid,%type);
	%ns = GetWord(%nf,0);
	%np = floor(%ns / %l);
	%lb = (%page * %l) - (%l-1);
	%ub = %lb + (%l-1);
	if(%ub > %ns)
		%ub = %ns;

	%x = %lb - 1;
	%cnt = -1;
	for(%i = %lb; %i <= %ub; %i++)
	{
		%x++;
		%item = getword(%nf,%x);
		%amnt = Belt::HasThisStuff(%clientid,%item);
		Client::addMenuItem(%clientId, string::getsubstr($menuChars,%cnt++,1) @%amnt@" "@ $beltitem[%item, "Name"], %item @ " " @ %page @" "@%type);
	}

	if(%page == 1)
	{
		if(%ns > %l) Client::addMenuItem(%clientId, "]Next >>", "page " @ %page+1 @" "@%type);
		Client::addMenuItem(%clientId, "xDone", "done");
	}
	else if(%page == %np+1)
	{
		Client::addMenuItem(%clientId, "[<< Prev", "page " @ %page-1 @" "@%type);
		Client::addMenuItem(%clientId, "xDone", "done");
	}
	else
	{
		Client::addMenuItem(%clientId, "]Next >>", "page " @ %page+1 @" "@%type);
		Client::addMenuItem(%clientId, "[<< Prev", "page " @ %page-1 @" "@%type);
	}
	Client::addMenuItem(%clientId, "z<< Back", "back");

	return;
}
function processMenuStoreBeltItem(%clientid, %opt)
{
	%o = GetWord(%opt, 0);
	%p = GetWord(%opt, 1);
	%t = GetWord(%opt, 2);

	if(%o == "done") {
		ClearCurrentShopVars(%clientId);
		return;
	}

	if(%o == "back"){
		MenuStoreBelt(%clientId);
		return;
	}

	if(%o != "page")
	{
		if(%clientId.bulkNum < 1)	%clientId.bulkNum = 1;
		if(%clientId.bulkNum > 500)	%clientId.bulkNum = 500;
		MenuStoreBeltItemFinal(%clientid, %o, %t);
		return;
	}
	MenuStoreBeltItem(%clientid, %t, %p);

	return;
}
function MenuStoreBeltItemFinal(%clientid, %item, %type)
{
	%name = $beltitem[%item, "Name"];
	%amnt = %clientId.bulkNum;
	%cmnt = Belt::HasThisStuff(%clientid,%item);

	if(%amnt > %cmnt)
		%amnt = %cmnt;

	Client::buildMenu(%clientId, %name@" ("@%cmnt@")", "StoreBeltItemFinal", true);
	Client::addMenuItem(%clientId, %cnt++ @ "Store "@%amnt, %type@" store "@%item@" "@%amnt);

	if(%cmnt > 10)
		Client::addMenuItem(%clientId, %cnt++ @ "Store 10", %type@" store "@%item@" 10");
	if(%cmnt > 50)
		Client::addMenuItem(%clientId, %cnt++ @ "Store 50", %type@" store "@%item@" 50");
	if(%cmnt > 100)
		Client::addMenuItem(%clientId, %cnt++ @ "Store 100", %type@" store "@%item@" 100");
	if(%cmnt > 200)
		Client::addMenuItem(%clientId, %cnt++ @ "Store 200", %type@" store "@%item@" 200");
	if(%cmnt != %amnt)
		Client::addMenuItem(%clientId, %cnt++ @ "Store "@%cmnt@" (all)", %type@" storeall "@%item@" "@%cmnt);

	Client::addMenuItem(%clientId, "xCancel", %type@" done");
	Client::addMenuItem(%clientId, "z<< Back", %type@" back");
	return;
}


function processMenuStoreBeltItemFinal(%clientId, %opt)
{

	%type = GetWord(%opt, 0);
	%option = GetWord(%opt, 1);
	%item = GetWord(%opt, 2);
	%amnt = GetWord(%opt, 3);

	if(%type == "done") {
		ClearCurrentShopVars(%clientId);
		return;
	}
	else if(%option == "back"){
		MenuStoreBeltItem(%clientId, %type, 1);
		return;
	}
	else if(%option == "storeall")
	{
		%cmnt = Belt::HasThisStuff(%clientid,%item);
		if (BeltItem::isEquipped(%clientId, %item)) {
			Client::sendMessage(%clientId, $MsgRed, "You cannot store equipped items.");
			MenuStoreBeltItem(%clientId, %type, 1);
		}
		else if(%cmnt >= %amnt)
		{
			Client::SendMessage(%clientid, 0, "You store "@%amnt@" "@$beltitem[%item, "Name"]@".");
			Belt::TakeThisStuff(%clientid, %item, %amnt);
			Belt::BankGiveThisSTuff(%clientid, %item, %amnt);
			PlaySound(SoundPickupItem, GameBase::getPosition(%clientid));

			if(Belt::GetNS(%clientid,%type) != "0")
				MenuStoreBeltItem(%clientId, %type, 1);
			else
				MenuStoreBelt(%clientId, 1);
		}
	}
	else if(%option == "store")
	{
		%cmnt = Belt::HasThisStuff(%clientid,%item);

		// check if the item is equipped
		if (BeltItem::isEquipped(%clientId, %item)) {
			Client::sendMessage(%clientId, $MsgRed, "You cannot store equipped items.");
			MenuStoreBeltItem(%clientId, %type, 1);
		}
		else if(%cmnt >= %amnt)
		{
			Client::SendMessage(%clientid, 0, "You store "@%amnt@" "@$beltitem[%item, "Name"]@".");
			Belt::TakeThisStuff(%clientid, %item, %amnt);
			Belt::BankGiveThisSTuff(%clientid, %item, %amnt);
			PlaySound(SoundPickupItem, GameBase::getPosition(%clientid));
			
			if(%amnt < %cmnt)
				MenuStoreBeltItemFinal(%clientid, %item, %type);
			else if(Belt::GetNS(%clientid,%type) != "0")
				MenuStoreBeltItem(%clientId, %type, 1);
			else
				MenuStoreBelt(%clientId, 1);
		}
	}
	refreshWeight(%clientId);
	return;
}

//---------------------------

function MenuWithdrawBeltItem(%clientid, %type, %page)
{
	%disp = getDisp(%type);

	Client::buildMenu(%clientId, %disp@" withdraw:", "WithdrawBeltItem", true);
	%clientId.bulkNum = "";

	%l = 6;
	if(%clientId.repack >= 18)
		%l = 31;

	// %nx = $count[%type];
	%nf = Belt::BankGetNS(%clientid,%type);
	%ns = GetWord(%nf,0);
	%np = floor(%ns / %l);
	%lb = (%page * %l) - (%l-1);
	%ub = %lb + (%l-1);
	if(%ub > %ns)
		%ub = %ns;

	%x = %lb - 1;
	%cnt = -1;
	for(%i = %lb; %i <= %ub; %i++)
	{
		%x++;
		%item = getword(%nf,%x);
		%amnt = Belt::BankHasThisStuff(%clientid,%item);
		Client::addMenuItem(%clientId, string::getsubstr($menuChars,%cnt++,1) @%amnt@" "@ $beltitem[%item, "Name"], %item @ " " @ %page @" "@%type);
	}

	if(%page == 1)
	{
		if(%ns > %l) Client::addMenuItem(%clientId, "]Next >>", "page " @ %page+1 @" "@%type);
		Client::addMenuItem(%clientId, "xDone", "done");
	}
	else if(%page == %np+1)
	{
		Client::addMenuItem(%clientId, "[<< Prev", "page " @ %page-1 @" "@%type);
		Client::addMenuItem(%clientId, "xDone", "done");
	}
	else
	{
		Client::addMenuItem(%clientId, "]Next >>", "page " @ %page+1 @" "@%type);
		Client::addMenuItem(%clientId, "[<< Prev", "page " @ %page-1 @" "@%type);
	}
	Client::addMenuItem(%clientId, "z<< Back", "back");

	return;
}

function processMenuWithdrawBeltItem(%clientid, %opt)
{
	%o = GetWord(%opt, 0);
	%p = GetWord(%opt, 1);
	%t = GetWord(%opt, 2);
	if(%o == "done") {
		ClearCurrentShopVars(%clientId);
		return;
	}
	if(%o == "back"){
		MenuWithdrawBelt(%clientId);
		return;
	}

	if(%o != "page")
	{
		if(%clientId.bulkNum < 1)	%clientId.bulkNum = 1;
		if(%clientId.bulkNum > 500)	%clientId.bulkNum = 500;
		MenuWithdrawBeltItemFinal(%clientid, %o, %t);
	return;
	}
	MenuWithdrawBeltItem(%clientid, %t, %p);

	return;
}

function MenuWithdrawBeltItemFinal(%clientid, %item, %type)
{
	%name = $beltitem[%item, "Name"];
	%amnt = %clientId.bulkNum;
	%cmnt = Belt::BankHasThisStuff(%clientid,%item);

	if(%amnt > %cmnt)
		%amnt = %cmnt;

	Client::buildMenu(%clientId, %name@" ("@%cmnt@")", "WithdrawBeltItemFinal", true);

	Client::addMenuItem(%clientId, %cnt++ @ "Withdraw "@%amnt, %type@" withdraw "@%item@" "@%amnt);
	if(%cmnt >= 10)
		Client::addMenuItem(%clientId, %cnt++ @ "Withdraw 10", %type@" withdraw "@%item@" 10");
	if(%cmnt >= 50)
		Client::addMenuItem(%clientId, %cnt++ @ "Withdraw 50", %type@" withdraw "@%item@" 50");
	if(%cmnt >= 100)
		Client::addMenuItem(%clientId, %cnt++ @ "Withdraw 100", %type@" withdraw "@%item@" 100");
	if(%cmnt >= 200)
		Client::addMenuItem(%clientId, %cnt++ @ "Withdraw 200", %type@" withdraw "@%item@" 200");
	Client::addMenuItem(%clientId, %cnt++ @ "Withdraw all ("@%cmnt@")", %type@" withdrawall "@%item@" "@%amnt);
	Client::addMenuItem(%clientId, "xCancel", "done");
	Client::addMenuItem(%clientId, "z<< Back", %type@" back");
	return;
}

function processMenuWithdrawBeltItemFinal(%clientId, %opt)
{
	%type = GetWord(%opt, 0);
	%option = GetWord(%opt, 1);
	%item = GetWord(%opt, 2);
	%amnt = GetWord(%opt, 3);

	if(%type == "done") {
		ClearCurrentShopVars(%clientId);
		return;
	}
	else if(%option == "back") {
		MenuWithdrawBeltItem(%clientid, %type, 1);
		return;
	}
	else if(%option == "withdrawall")
	{
		%amnt = Belt::BankHasThisStuff(%clientid, %item);
		Client::SendMessage(%clientid, 0, "You withdraw "@%amnt@" "@$beltitem[%item, "Name"]@"." );
		Belt::BankTakeThisSTuff(%clientid, %item, %amnt);
		Belt::GiveThisStuff(%clientid, %item, %amnt);
		MenuWithdrawBeltItem(%clientid, %type, 1);
		PlaySound(SoundPickupItem, GameBase::getPosition(%clientid));
	}
	else if(%option == "withdraw")
	{
		%cmnt = Belt::BankHasThisStuff(%clientid,%item);
		if(%cmnt >= %amnt)
		{
			Client::SendMessage(%clientid, 0, "You withdraw "@%amnt@" "@$beltitem[%item, "Name"]@".");
			Belt::BankTakeThisSTuff(%clientid, %item, %amnt);
			Belt::GiveThisStuff(%clientid, %item, %amnt);
			PlaySound(SoundPickupItem, GameBase::getPosition(%clientid));

			if(%cmnt == %amnt)
				MenuWithdrawBeltItem(%clientid, %type, 1);
			else
				MenuWithdrawBeltItemFinal(%clientid, %item, %type);
		}
	}
	return;
}
// ------------------- //
// Non Menu Functions  //
// ------------------- //

function Belt::GetSellCost(%clientid,%item)
{
	%p = $HardcodedItemCost[%item];
	%cost = round(%p * ($resalePercentage/100));

	%p = round($PlayerSkill[%clientId, $SkillHaggling] / 11) / 100;
	%x = round(%cost * Cap(%p, 0.0, 1.0) );
	%cost += %x;

	return %cost;
}

function Belt::Mug(%clientid,%id)
{
	Client::SendMessage(%clientid,1,"#mugbelt");
}

function Belt::Sell(%clientid, %npc, %silent)
{
	if(!%silent)
		AI::sayLater(%clientid, %npc, "What would you like to sell?", True);
	MenuSellBelt(%clientId);
}

function Belt::Store(%clientid,%npc,%page)
{
	AI::sayLater(%clientid, %npc, "This is the equipment you have stored from your belt.", True);
	MenuStoreBelt(%clientid,%page);
}

function Belt::GetWeight(%clientid) {
	%list[1] = "AmmoItems";
	%list[2] = "GemItems";
	%list[3] = "PotionItems";
	%list[4] = "WeaponItems";
	%list[5] = "ArmorItems";
	%list[6] = "QuestItems";
	%list[7] = "AccessoryItems";
	%list[8] = "MateriaItems";
	%list[9] = "MiscItems";

    // for(%s=1;%list[%s] != "";%s++)
	// {
	// 	%type = %list[%s];
	// 	for(%i=0;%i<=$count[%type];%i++)
	// 	{
	// 		%item = $beltitem[%i, "Num", %type];
	// 		%amnt = Belt::HasThisStuff(%clientid, %item);
	// 		%weig = $AccessoryVar[%item, $Weight];
	// 		%total += %amnt * %weig;
	// 	}
	// }

	%total = 0;
	for(%s=1; %list[%s] != ""; %s++) {
		%type = %list[%s];
		%list = fetchdata(%clientid, %type);

		for(%idx = 0; GetWord(%list, %idx) != -1; %idx += 2) {
			%item = GetWord(%list, %idx);
			%count = GetWord(%list, %idx + 1);
			%weight = $AccessoryVar[%item, $Weight];
			%total += %weight * %count;
		}
	}

	return fixDecimals(%total);
}

function Belt::GetWeightByType(%clientid, %type) {
	// for(%i=0; %i <= $count[%type]; %i++) {
	// 	%item = $beltitem[%i, "Num", %type];
	// 	%amnt = Belt::HasThisStuff(%clientid, %item);
	// 	%weig = $AccessoryVar[%item, $Weight];
	// 	%total += %amnt * %weig;
	// }

	%total = 0;
	%list = fetchdata(%clientid, %type);
	for(%idx = 0; GetWord(%list, %idx) != -1; %idx += 2) {
		%item = GetWord(%list, %idx);
		%count = GetWord(%list, %idx + 1);
		%weight = $AccessoryVar[%item, $Weight];
		%total += %weight * %count;
	}
	
	return fixDecimals(%total);
}

function Belt::DropItem(%clientid,%item,%amnt,%type) {
	%chk = Belt::HasThisStuff(%clientid,%item);
	if(%chk >= %amnt)
	{
		Belt::TakeThisStuff(%clientid, %item, %amnt);
		TossLootbag(%clientId, %item@" "@%amnt, 8, "*", 0, 1);
		refreshWeight(%clientId);
	}
}

function Belt::GetNS(%clientid, %type) {
	%bn = 0;
	// %num = $count[%type];

	// TODO: This is sloooww, fix it
	// for(%i; %i <= %num; %i++) {
	// 	%item = $beltitem[%i, "Num", %type];
	// 	%amnt = Belt::HasThisStuff(%clientid, %item);

	// 	if(%amnt > 0) {
	// 		%list = %list @" "@ %item;
	// 		%bn++;
	// 	}
	// }

    // LongBow: This is much faster... search through their inventory not ALL items that exist to see if they have it
	%list = fetchdata(%clientid, %type);
	// lbecho("%list: " @ %list);
	for(%idx = 0; GetWord(%list, %idx) != -1; %idx += 2) {
		%item = GetWord(%list, %idx);
		%count = GetWord(%list, %idx + 1);
		
		if (%count > 0) {
			%nslist = %nslist @" "@ %item;
			%bn++;
		}
	}

	return %bn @""@ %nslist;
}

function BeltItem::Add(%name, %item, %type, %weight, %cost, %image, %shopIndex) {
	$numBeltItems++;
	%num = $count[%type]++;

	$beltItemData[$numBeltItems] = %item;
	$beltItemNameToItem[%name] = %item;
	$beltitem[%num, "Num", %type] = %item;
	$beltitem[%item, "Item"] = %item;
	$beltitem[%item, "Name"] = %name;
	$beltitem[%item, "Type"] = %type;
	$beltitem[%item, "Image"] = %image;
	$AccessoryVar[%item, $Weight] = %weight;

	if (%shopIndex != "") {
		$AccessoryVar[%item, $ShopIndex] = %shopIndex;
		$beltItemShopIndexToItem[%shopIndex] = %item;
	}

	$HardcodedItemCost[%item] = %cost;
}

function BeltItem::AddItem(%name, %item, %type, %weight, %miscInfo, %shopIndex) {
	$numBeltItems++;
	%num = $count[%type]++;

	$beltItemData[$numBeltItems] = %item;
	$beltItemNameToItem[%name] = %item;
	$beltitem[%num, "Num", %type] = %item;
	$beltitem[%item, "Item"] = %item;
	$beltitem[%item, "Name"] = %name;
	$beltitem[%item, "Type"] = %type;

	$AccessoryVar[%item, $Weight] = %weight;
	$AccessoryVar[%item, $MiscInfo] = %miscInfo;

	if (%shopIndex != "") {
		$AccessoryVar[%item, $ShopIndex] = %shopIndex;
		$beltItemShopIndexToItem[%shopIndex] = %item;
	}

	$HardcodedItemCost[%item] = %cost;
}

// TODO: add skill restrictions, etc
function BeltItem::AddEquippable(%name, %item, %type, %weight, %shopIndex) {
	// add base version
	$numBeltItems++;
	%num = $count[%type]++;

	$beltItemData[$numBeltItems] = %item;
	$beltItemNameToItem[%name] = %item;
	$beltitem[%num, "Num", %type] = %item;
	$beltitem[%item, "Item"] = %item;
	$beltitem[%item, "Name"] = %name;
	$beltitem[%item, "Type"] = %type;
	// $beltitem[%item, "Image"] = %image;
	$AccessoryVar[%item, $Weight] = %weight;
	$HardcodedItemCost[%item] = GenerateItemCost(%item);
	$ItemCost[%item] = %cost;

	if (%shopIndex != "") {
		$AccessoryVar[%item, $ShopIndex] = %shopIndex;
		$beltItemShopIndexToItem[%shopIndex] = %item;
	}

	// now add the equipped version
	%equippedName = %name @ " " @ $equippedString;
	%equippedItem = %item @ "0";

	$numBeltItems++;
	%num = $count[%type]++;

	$beltItemData[$numBeltItems] = %equippedItem;
	$beltItemNameToItem[%equippedName] = %equippedItem;
	$beltitem[%num, "Num", %type] = %equippedItem;
	$beltitem[%equippedItem, "Item"] = %equippedItem;
	$beltitem[%equippedItem, "Name"] = %equippedName;
	$beltitem[%equippedItem, "Type"] = %type;
	// $beltitem[%equippedItem, "Image"] = %image;

	$AccessoryVar[%equippedItem, $Weight] = %weight;
	// $AccessoryVar[%equippedItem, $ShopIndex] = %shopIndex;
	$HardcodedItemCost[%equippedItem] = %cost;
}

function BeltItem::AddAccessory(%name, %item, %accessoryType, %beltType, %special, %weight, %skillRestriction, %miscInfo, %shopIndex) {
	$AccessoryVar[%item, $SpecialVar] = %special;
	$AccessoryVar[%item, $MiscInfo] = %miscInfo;
	$AccessoryVar[%item, $AccessoryType] = %accessoryType;

	if (%skillRestriction != "") {
		$SkillRestriction[%item] = %skillRestriction;
	}

	BeltItem::AddEquippable(%name, %item, %beltType, %weight, %shopIndex);
}

$armorListIndex = 1;
function BeltItem::AddArmor(%name, %item, %skin, %hitSound, %special, %weight, %skillRestriction, %miscInfo, %shopIndex) {
	$ArmorSkin[%item] = %skin;
	$ArmorPlayerModel[%item] = "";
	$ArmorHitSound[%item] = %hitSound;
	$ArmorList[$armorListIndex] = %item;
	$armorListIndex++;

	BeltItem::AddAccessory(%name, %item, $BodyAccessoryType, "ArmorItems", %special, %weight, %skillRestriction, %miscInfo, %shopIndex);
}

function BeltItem::AddRobe(%name, %item, %skin, %special, %weight, %skillRestriction, %miscInfo, %shopIndex) {	
	$ArmorSkin[%item] = %skin;
	$ArmorPlayerModel[%item] = "Robed";
	$ArmorHitSound[%item] = SoundHitFlesh;
	$ArmorList[$armorListIndex] = %item;
	$armorListIndex++;

	BeltItem::AddAccessory(%name, %item, $BodyAccessoryType, "ArmorItems", %special, %weight, %skillRestriction, %miscInfo, %shopIndex);
}

function BeltItem::AddShield(%name, %item, %special, %weight, %skillRestriction, %miscInfo, %shopIndex) {
	BeltItem::AddAccessory(%name, %item, $ShieldAccessoryType, "ArmorItems", %special, %weight, %skillRestriction, %miscInfo, %shopIndex);
}

function BeltItem::AddWeaponData(%name, %item, %image, %accessoryType, %miscInfo, %weaponSkill, %skillRestriction, %dps, %enchant, %shopIndex, %baseWeapon) {
	// copied from GetDelay() if you change that formula update it here
	%type = "WeaponItems";
	%a = 3.0;
	%weaponDelay = %image.imageType.fireTime;
	%suggestedWeight = FixDecimals(Cap(%weaponDelay * %a, 1.0, "inf"));

	// generate belt information
	$numBeltItems++;
	%num = $count[%type]++;

	$beltItemData[$numBeltItems] = %item;
	$beltItemNameToItem[%name] = %item;
	$beltitem[%num, "Num", %type] = %item;
	$beltitem[%item, "Item"] = %item;
	$beltitem[%item, "Name"] = %name;
	$beltitem[%item, "Type"] = %type;
	$beltitem[%item, "Image"] = %image;

	if (%baseWeapon != "") {
		$beltitem[%item, "BaseWeapon"] = %baseWeapon;
	}

	// calculate special var - ATK = (DPS * Delay)
	%delay = %image.imageType.fireTime;
	%atk = round(%dps * %weaponDelay);

	// generate weapon information
	$AccessoryVar[%item, $Weight] = %suggestedWeight;
	$AccessoryVar[%item, $AccessoryType] = %accessoryType;
	$AccessoryVar[%item, $SpecialVar] = "6 " @ %atk;
	$AccessoryVar[%item, $MiscInfo] = %miscInfo;

	if (%shopIndex != "") {
		$AccessoryVar[%item, $ShopIndex] = %shopIndex;
		$beltItemShopIndexToItem[%shopIndex] = %item;
	}

	$SkillType[%item] = %weaponSkill;
	$SkillRestriction[%item] = %skillRestriction;

	// generate cost
	%cost = GenerateItemCost(%item);
	$HardcodedItemCost[%item] = %cost;
	$ItemCost[%item] = %cost;

	if (%enchant != "") {
		$beltitem[%item, "Enchantment"] = %enchant;
	}
}

function BeltItem::AddProjectile(%name, %item, %type, %weight, %cost, %projectile, %weaponSkill, %skillRestriction, %special, %shopIndex) {
	$numBeltItems++;
	%num = $count[%type]++;

	$beltItemData[$numBeltItems] = %item;
	$beltItemNameToItem[%name] = %item;
	$beltitem[%num, "Num", %type] = %item;
	$beltitem[%item, "Item"] = %item;
	$beltitem[%item, "Name"] = %name;
	$beltitem[%item, "Type"] = %type;
	$beltitem[%item, "Projectile"] = %projectile;
	$AccessoryVar[%item, $Weight] = %weight;
	$AccessoryVar[%item, $SpecialVar] = %special;

	if (%shopIndex != "") {
		$AccessoryVar[%item, $ShopIndex] = %shopIndex;
		$beltItemShopIndexToItem[%shopIndex] = %item;
	}

	$SkillType[%item] = %weaponSkill;
	$SkillRestriction[%item] = %skillRestriction;
	$HardcodedItemCost[%item] = %cost;
}

function BeltItem::AddSeed(%name, %item, %type, %weight, %cost, %image, %shopIndex, %miscInfo, %fruit, %fruitType) {
	BeltItem::Add(%name, %item, %type, %weight, %cost, %image, %shopIndex);

	$AccessoryVar[%item, $MiscInfo] = %miscInfo;
	$beltitem[%item, "isThrowable"] = True;
	$beltitem[%item, "isPlantable"] = True;
	$beltitem[%item, %fruitType] = %fruit;
}

// ==============================
// ========== SMITHING ==========
// ==============================

$smithingNum = 0;
// Smith::addItem("RHatchet","RHatchet 1","Hatchet 1", $smithingNum++);
// Smith::addItem("RBroadSword","RBroadSword 1","BroadSword 1", $smithingNum++);
// Smith::addItem("RLongSword","RLongSword 1","LongSword 1", $smithingNum++);
// Smith::addItem("RClub","RClub 1","Club 1", $smithingNum++);
// Smith::addItem("RSpikedClub","RSpikedClub 1","SpikedClub 1", $smithingNum++);
// Smith::addItem("RKnife","RKnife 1","BroadSword 1", $smithingNum++);
// Smith::addItem("RDagger","RDagger 1","Dagger 1", $smithingNum++);
// Smith::addItem("RShortSword","RShortSword 1","ShortSword 1", $smithingNum++);
// Smith::addItem("RPickAxe","RPickAxe 1","PickAxe 1", $smithingNum++);
// Smith::addItem("RShortBow","RShortBow 1","ShortBow 1", $smithingNum++);
// Smith::addItem("RLightCrossbow","RLightCrossbow 1","LightCrossbow 1", $smithingNum++);
// Smith::addItem("RWarAxe","RWarAxe 1","WarAxe 1", $smithingNum++);

// Smith::addItem("KeldriniteLS","Keldrinite 1 LongSword 1","KeldriniteLS 1", $smithingNum++);
// Smith::addItem("AeolusWing","ElvenBow 1 CompositeBow 1 Quartz 3","AeolusWing 1", $smithingNum++);
// Smith::addItem("StoneFeather","SmallRock 1 Quartz 1","StoneFeather 1", $smithingNum++);
// Smith::addItem("MetalFeather","Knife 1 Quartz 1","MetalFeather 1", $smithingNum++);
// Smith::addItem("Talon","Dagger 1 Quartz 1 Granite 2","Talon 1", $smithingNum++);
// Smith::addItem("CeraphumsFeather","Dagger 2 Jade 2 Quartz 4","CeraphumsFeather 1", $smithingNum++);
// Smith::addItem("BoneClub","Club 1 SkeletonBone 1 Granite 3","BoneClub 1", $smithingNum++);
// Smith::addItem("SpikedBoneClub","SpikedClub 1 SkeletonBone 2 Granite 5","SpikedBoneClub 1", $smithingNum++);
// Smith::addItem("FineRobe","LightRobe 1 ApprenticeRobe 1 EnchantedStone 5","FineRobe 1", $smithingNum++);
// Smith::addItem("KeldrinArmor","Keldrinite 2 FullPlateArmor 1 Gold 5 Emerald 5 Diamond 5 EnchantedStone 5","KeldrinArmor 1", $smithingNum++);
// Smith::addItem("DragonMail","DragonScale 5 Diamond 5 Ruby 3","DragonMail 1", $smithingNum++);
// Smith::addItem("DragonShield","DragonScale 3 Ruby 2","DragonShield 1", $smithingNum++);
// Smith::addItem("ElvenRobe","AdvisorRobe 1 Topaz 2 EnchantedStone 4","ElvenRobe 1", $smithingNum++);
// Smith::addItem("JusticeStaff","LongStaff 1 Granite 4 Turquoise 2","JusticeStaff 1", $smithingNum++);
// Smith::addItem("JusticeStaff","LongStaff 1 Granite 4 Turquoise 2","JusticeStaff 1", $smithingNum++);

// ==============================
// ======== ENCHANTMENTS ========
// ==============================

$WeaponEnchantments = "";
$baseEnchants = "Fire Lightning Ice Earth Poison Holy Dark";

$enchantDamageVerb["Fire"] = "burned";
$enchantDamageVerb["Lightning"] = "shocked";
$enchantDamageVerb["Ice"] = "froze";
$enchantDamageVerb["Earth"] = "smashed";
$enchantDamageVerb["Poison"] = "poisoned";
$enchantDamageVerb["Holy"] = "smited";
$enchantDamageVerb["Dark"] = "obliterated";

$materiaMiscInfo["Fire"] = "A small red glowing orb that gives off a warm aura. This materia is embued with the element of Fire.";
$materiaMiscInfo["Lightning"] = "A small yellow glowing orb that crackles with energy. This materia is embued with the element of Lightning.";
$materiaMiscInfo["Ice"] = "A small blue glowing orb that softly swirls a cold breeze around it. This materia is embued with the element of Ice.";
$materiaMiscInfo["Earth"] = "A small brown glowing orb that feels rock hard. This materia is embued with the element of Earth.";
$materiaMiscInfo["Poison"] = "A small green glowing orb that emanates a sickly smell and green tint. This materia is embued with the element of Poison.";
$materiaMiscInfo["Holy"] = "A small white glowing orb that emanates a holy aura of peace and justice. This materia is embued with the element of Holy.";
$materiaMiscInfo["Dark"] = "A dark glowing orb that emanates an aura of death and destruction. This materia is embued with the element of Darkness.";

$materiaElementalType["Fire"] = $ElementalFire;
$materiaElementalType["Lightning"] = $ElementalLightning;
$materiaElementalType["Ice"] = $ElementalIce;
$materiaElementalType["Earth"] = $ElementalEarth;
$materiaElementalType["Poison"] = $ElementalPoison;
$materiaElementalType["Holy"] = $ElementalHoly;
$materiaElementalType["Dark"] = $ElementalDark;

$enchantLevels[1] = "I";
$enchantLevels[2] = "II";
$enchantLevels[3] = "III";
$enchantLevels[4] = "IV";
$enchantLevels[5] = "V";
$enchantLevels[6] = "VI";
$enchantLevels[7] = "VII";
$enchantLevels[8] = "VIII";
$enchantLevels[9] = "IX";
$enchantLevels[10] = "X";

function generateEnchantsAndMateria() {
	// base enchant damage
	for(%i = 0; getWord($baseEnchants, %i) != "" && getWord($baseEnchants, %i) != -1; %i++) {
		%baseEnchant = getWord($baseEnchants, %i);

		for(%x = 1; %x <= 10; %x++) {
			%enchantLevel = $enchantLevels[%x];
			%enchant = %baseEnchant@%enchantLevel;
			// forumala for damage scaling eg: lvl 1 = 4 additional dmg, lvl 10 = 40 additional damage
			%damagePercent = %x * 10; // 10 -> 100

			$WeaponEnchantment[%enchant, "name"] = %baseEnchant @ " " @ %enchantLevel;
			$WeaponEnchantment[%enchant, "mod"] = "2 " @ %damagePercent;
			$WeaponEnchantment[%enchant, "action"] = $enchantDamageVerb[%baseEnchant];
			$WeaponEnchantment[%enchant, "materia"] = %baseEnchant @ "Materia" @ %enchantLevel;
			$WeaponEnchantment[%enchant, "elementalType"] = $materiaElementalType[%baseEnchant];

			$WeaponEnchantments = $WeaponEnchantments @ " " @ %enchant;
			// add materia to belt
			%item = %baseEnchant @ "Materia" @ %enchantLevel;
			BeltItem::AddItem(%baseEnchant @ " Materia " @ %enchantLevel, %item, "MateriaItems", 1, $materiaMiscInfo[%baseEnchant]);

			// create the smithing recipes
			if (%x > 1) {
				%prevMateria = %baseEnchant @ "Materia" @ $enchantLevels[%x-1];
				Smith::addItem(%item, %prevMateria @ " 5", %item @ " 1", $smithingNum++);
			}
		}
	}
}

function BeltItem::AddWeapon(%name, %item, %image, %accessoryType, %miscInfo, %weaponSkill, %skillRestriction, %dps, %shopIndex) {
	// add base weapon
	BeltItem::AddWeaponData(%name, %item, %image, %accessoryType, %miscInfo, %weaponSkill, %skillRestriction, %dps, "", %shopIndex);

	// add equipped version
	%equippedName = %name @ " " @ $equippedString;
	%equippedItem = %item @ "0";
	BeltItem::AddWeaponData(%equippedName, %equippedItem, %image, %accessoryType, %miscInfo, %weaponSkill, %skillRestriction, %dps);

	// create enchanted versions
	for(%i = 0; getWord($WeaponEnchantments, %i) != "" && getWord($WeaponEnchantments, %i) != -1; %i++) {
		%enchant = getWord($WeaponEnchantments, %i);
		%enchantName = $WeaponEnchantment[%enchant, "name"];
		%enchantMateria = $WeaponEnchantment[%enchant, "materia"];

		%enchantedWeaponName = %name @ " of " @ %enchantName;
		%enchantedWeaponItem = %item @ %enchant;
		BeltItem::AddWeaponData(%enchantedWeaponName, %enchantedWeaponItem, %image, %accessoryType, %miscInfo, %weaponSkill, %skillRestriction, %dps, %enchant, 0, %item);

		%equippedEnchantedName = %enchantedWeaponName @ " " @ $equippedString;
		%equippedEnchantedItem = %enchantedWeaponItem @ "0";
		BeltItem::AddWeaponData(%equippedEnchantedName, %equippedEnchantedItem, %image, %accessoryType, %miscInfo, %weaponSkill, %skillRestriction, %dps, %enchant, 0, %item);

		// add the smithing recipe for the enchant
		// Smith::addItem(%enchantedWeaponItem, %item @ " 1 " @ %enchantMateria @ " 1", %enchantedWeaponItem @ " 1", $smithingNum++);
	}
}

function BeltItem::GetType(%item) {
	return $beltitem[%item, "Type"];
}

function BeltItem::GetName(%item) {
	return $beltitem[%item, "Name"];
}

function BeltItem::GetImage(%item) {
	return $beltitem[%item, "Image"];
}

function BeltItem::GetProjectile(%item) {
	return $beltitem[%item, "Projectile"];
}

function BeltItem::GetEnchant(%item) {
	return $beltitem[%item, "Enchantment"];
}

function BeltItem::IsEquipped(%clientId, %item) {
	%amnt = Belt::HasThisStuff(%clientid, %item);
	%itemIsWorn = String::findSubStr(BeltItem::GetName(%item), $equippedString) != -1;

	if (%amnt > 0 && %itemIsWorn)
		return true;

	return false;
}

function Belt::HasThisStuff(%clientid, %item) {
	%item = $beltitem[%item, "Item"];
	%type = $beltitem[%item, "Type"];
	%list = fetchdata(%clientid, %type);
	%amnt = Belt::ItemCount(%item, %list);

	return %amnt;
}

function Belt::GiveThisStuff(%clientid, %item, %amnt, %echo) {
	%amnt = floor(%amnt);

	if(%amnt > 0) {
		%item = $beltitem[%item, "Item"];
		%type = $beltitem[%item, "Type"];
		%list = fetchdata(%clientid,%type);
		%count = Belt::ItemCount(%item,%list);


		if(%echo)
			Client::sendMessage(%clientId, 0, "You received " @ Number::Beautify(%amnt) @ " " @ $beltitem[%item, "Name"] @". " @ "["@getDisp($beltitem[%item, "Type"])@", have "@(%count+%amnt)@"]");

		if(%count > 0) {
			%list = Belt::RemoveFromList(%list, %item@" "@%count);
			%amnt = %amnt + %count;
		}

		%list = Belt::AddToList(%list, %item@" "@%amnt);

		Storedata(%clientid, %type, %list);
		refreshWeight(%clientId);
	}
}

function Belt::TakeThisStuff(%clientid, %item, %amnt) {
	%amnt = floor(%amnt);

	if(%amnt > 0) {
		%item = $beltitem[%item, "Item"];
		%type = $beltitem[%item, "Type"];
		%list = fetchdata(%clientid, %type);
		%count = Belt::ItemCount(%item,%list);
		%amnt = %count - %amnt;
		%list = Belt::RemoveFromList(%list, %item@" "@%count);

		if(%amnt > 0)	%list = Belt::AddToList(%list, %item@" "@%amnt);

		Storedata(%clientid,%type,%list);
	}
}

function isBeltItem(%item) {
	%flag = false;

	if((String::ICompare($beltitem[%item, "Item"], %item) == 0))
		%flag = True;
 
	return %flag;
}

function Belt::ItemCount(%item, %list) {
	%count = 0;

	for(%i = 0; (%w = getword(%list, %i)) != -1; %i += 2) {
		if(%w == %item) {
			%count = getword(%list, %i+1);
			break;
		}
	}

	return %count;
}

function Belt::HasItemNamed(%client, %itemName) {
	%count = 0;

	for(%ii=0;(%type = getword($belttypelist, %ii)) != -1;%ii++) {
		%list = fetchData(%client,%type);

		for(%i=0;(%w = getword(%list,%i)) != -1;%i+=2) {
			if(string::icompare(%itemName, $beltitem[%w, "Name"]) == 0) {
				%count = getword(%list,%i+1);
				return %w@" "@%count;
			}
		}
	}

	return false;
}

function Belt::HasItemOfType(%client, %itemName, %type) {
	%count = 0;
	%list = fetchData(%client, %type);

	for(%i = 0; (%item = getword(%list, %i)) != -1; %i += 2) {
		if(string::icompare(%itemName, %item) == 0) {
			%count = getword(%list, %i + 1);
			return %item@" "@%count;
		}
	}

	return False;
}

function Belt::AddToList(%list, %item) {
	%list = %list @ %item @ " ";
	return %list;
}

function Belt::RemoveFromList(%list, %item) {
	%a = " " @ %list;
	%a = String::replace(%a, " " @ %item @ " ", " ");
	%list = String::NEWgetSubStr(%a, 1, 99999);
	return %list;
}

function Belt::IsInList(%list, %item) {
	%a = " " @ %list;
	if(String::findSubStr(%a, " " @ %item @ " ") != -1)
		return True;
	else
		return False;
}

function Belt::BankStorageConversion(%clientid) {
	%bank =  fetchData(%clientId, "BankStorage");
	for(%i=0;getword(%bank,%i)!=-1;%i++) {
		%a = getword(%bank,%i);
		%b = getword(%bank,%i++);

		if(IsBeltItem(%a))
			Belt::BankGiveThisStuff(%clientid, %a, %b);
		else
			%banklist = %banklist@%a@" "@%b@" ";
	}
	storeData(%clientId, "BankStorage", " "@%banklist);
}

function Belt::BankGiveThisStuff(%clientid, %item, %amnt) {
	if(%amnt > 0) {
		%item = $beltitem[%item, "Item"];
		%type = $beltitem[%item, "Type"];
		%list = fetchdata(%clientid,"Bank"@%type);
		%count = Belt::ItemCount(%item,%list);

		if(%count > 0) {
			%list = Belt::RemoveFromList(%list, %item@" "@%count);
			%amnt = %amnt + %count;
		}

		%list = Belt::AddToList(%list, %item@" "@%amnt);
		Storedata(%clientid,"Bank"@%type,%list);
	}
}

function Belt::BankTakeThisStuff(%clientid,%item,%amnt) {
	if(%amnt > 0) {
		%item = $beltitem[%item, "Item"];
		%type = $beltitem[%item, "Type"];
		%list = fetchdata(%clientid,"Bank"@%type);
		%count = Belt::ItemCount(%item,%list);
		%amnt = %count - %amnt;

		%list = Belt::RemoveFromList(%list, %item@" "@%count);
		if(%amnt > 0)	%list = Belt::AddToList(%list, %item@" "@%amnt);

		Storedata(%clientid,"Bank"@%type,%list);
	}
}

function Belt::BankHasThisStuff(%clientid,%item) {
	%item = $beltitem[%item, "Item"];
	%type = $beltitem[%item, "Type"];
	%list = fetchdata(%clientid,"Bank"@%type);
	%amnt = Belt::ItemCount(%item,%list);
	return %amnt;
}

function Belt::BankGetNS(%clientid, %type) {
	%bn = 0;
	// %num = $count[%type];
	// TODO: This is sloooww, fix it
	// for(%i; %i <= %num;%i++) {
	// 	%item = $beltitem[%i, "Num", %type];
	// 	%amnt = Belt::BankHasThisStuff(%clientid,%item);
	// 	if(%amnt > 0) {
	// 		%list = %list @" "@%item;
	// 		%bn++;
	// 	}
	// }

	%list = fetchdata(%clientid, "Bank"@ %type);
	for(%idx = 0; GetWord(%list, %idx) != -1; %idx += 2) {
		%item = GetWord(%list, %idx);
		%count = GetWord(%list, %idx + 1);
		
		if (%count > 0) {
			%nslist = %nslist @" "@ %item;
			%bn++;
		}
	}

	return %bn @""@ %nslist; // %bn@%list;
}

function Belt::packgen(%clientId, %tmploot) {
	if(Player::isAiControlled(%clientId))
		TossLootbag(%clientId, %tmploot, 1, "*", 300);
	else {
		%namelist = rpg::getname(%clientId) @ ",";

		if(fetchData(%clientId, "LCK") >= 0)
			%tehLootBag = TossLootbag(%clientId, %tmploot, 5, %namelist, 0);//Cap(fetchData(%clientId, "LVL") * 300, 300, 0) //, 3600));
		else
			%tehLootBag = TossLootbag(%clientId, %tmploot, 5, %namelist, Cap(fetchData(%clientId, "LVL") * 0.2, 5, "inf"));

		pecho("Packgen num: "@%tehLootBag);
		pecho("Items: "@String::getSubStr(%tmploot, 0, 245));

		for(%i=0;getword(%tmploot,%i)!=-1;%i++) {
			%a = getword(%tmploot,%i);
			%b = getword(%tmploot,%i++);

			if($StealProtectedItem[%a] || $playerNoDrop[%a]) {
				%ba = Belt::RemoveFromList(%tmploot, %a@" "@%b);
				%tmploot = %ba;
				%i-=2;
			}
			else
				Belt::TakeThisStuff(%clientid, %a, %b);
		}
	}
}

function Belt::GetDeathItems(%clientid, %killerId) {
	%tmploot = "";

	if(fetchData(%clientId, "LCK") < 0) {
		%WeaponItems = fetchdata(%clientid, "WeaponItems");
		%unequippedWeaponItems = "";

		for(%i=0; (%w = getword(%WeaponItems, %i)) != -1; %i+=2) {
			%count = getword(%WeaponItems, %i + 1);
			%weaponName = getCroppedItem(%w);

			// if ($neverdropitem[%weaponName] || $playerNoDrop[%weaponName])
			// 	continue;

            if (%i == 0) {
				%unequippedWeaponItems = %weaponName @ " " @ %count @ " ";
			} else {
				%unequippedWeaponItems = %unequippedWeaponItems @ " " @ %weaponName @ " " @ %count @ " ";
			}
		}

		if((String::len(%tmploot) + String::len(%unequippedWeaponItems)) > 200) {
			Belt::packgen(%clientId, %tmploot);
			%tmploot = "";
		}
		
		// need to remove all equipped weapons trailing 0 getCroppedItem()
		%tmploot = %tmploot @ %unequippedWeaponItems;

		%AmmoItems = fetchdata(%clientid,"AmmoItems");
		if((String::len(%tmploot) + String::len(%AmmoItems)) > 200) {
			Belt::packgen(%clientId, %tmploot);
			%tmploot = "";
		}
		%tmploot = %tmploot @ %AmmoItems;

		%PotionItems = fetchdata(%clientid,"PotionItems");
		if((String::len(%tmploot) + String::len(%PotionItems)) > 200) {
			Belt::packgen(%clientId, %tmploot);
			%tmploot = "";
		}
		%tmploot = %tmploot @ %PotionItems;

		%GemItems = fetchdata(%clientid,"GemItems");
		if((String::len(%tmploot) + String::len(%GemItems)) > 200) {
			Belt::packgen(%clientId, %tmploot);
			%tmploot = "";
		}
		%tmploot = %tmploot @ %GemItems;

		%QuestItems = fetchdata(%clientid,"QuestItems");
		if((String::len(%tmploot) + String::len(%QuestItems)) > 200) {
			Belt::packgen(%clientId, %tmploot);
			%tmploot = "";
		}
		%tmploot = %tmploot @ %QuestItems;

        // drop misc items
		%miscItems = fetchdata(%clientid, "MiscItems");
		if((String::len(%tmploot) + String::len(%miscItems)) > 200) {
			Belt::packgen(%clientId, %tmploot);
			%tmploot = "";
		}
		%tmploot = %tmploot @ %miscItems;

		// should materia be droppable?
		%MateriaItems = fetchdata(%clientid, "MateriaItems");
		if((String::len(%tmploot) + String::len(%MateriaItems)) > 200) {
			Belt::packgen(%clientId, %tmploot);
			%tmploot = "";
		}
		%tmploot = %tmploot @ %MateriaItems;
	} //LCK < 0 happens when the player ran out, 0 is after the last one is used to protect this pack
	else {
		%tmpItems = fetchdata(%clientid, "QuestItems");
		for(%i = 0; GetWord(%tmpItems, %i) != -1; %i+=2) {
			%a = GetWord(%tmpItems, %i);
			if($loreitem[%a]) {
				%b = GetWord(%tmpItems, %i+1);
				%tmploot = %tmploot @ %a @ " " @ %b @ " ";
			}
		}
	}

	if(%tmploot != "") {
		for(%i=0; getword(%tmploot, %i) !=- 1; %i++) {
			%a = getword(%tmploot,%i);
			%b = getword(%tmploot,%i++);

			if($StealProtectedItem[%a] || $playerNoDrop[%a]) {
				%ba = Belt::RemoveFromList(%tmploot, %a@" "@%b);
				%tmploot = %ba;
				%i-=2;
			}
			else
				Belt::TakeThisStuff(%clientid, %a, %b);
		}
	}

	if(%tmploot == "")
		%tmploot = " ";

	return %tmploot;
}

// handle equiping belt items
function Belt::EquipItem(%clientid, %item) {
	%count = belt::hasthisstuff(%clientId, %item);
	
	if (%count <= 0) {
		Client::sendMessage(%clientId, $MsgRed, "You do not have a " @ BeltItem::GetName(%item) @ ".~wbutton3.wav");
		return;
	}

	%beltItemType = BeltItem::GetType(%item);

	if (%beltItemType == "WeaponItems") {
		if (BeltItem::isEquipped(%clientId, %item)) {
			Belt::UnequipWeapon(%clientid, %item);
		} else {
			RPGmountItem(%clientid, %item, $WeaponSlot);
		}
	}
	else if (%beltItemType == "ArmorItems" || %beltItemType == "AccessoryItems") {
		Item::onUse(%clientId, %item);
	}
}

function Belt::EquipWeapon(%clientid, %item) {
	Client::sendMessage(%clientId, $MsgBeige, "You equipped " @ BeltItem::GetName(%item) @ ".~wCrossbow_Switch1.wav");
	Belt::TakeThisStuff(%clientId, %item, 1);
	Belt::GiveThisStuff(%clientid, %item @ "0", 1);
}

function Belt::UnequipWeapon(%clientid, %item) {
	%baseItem = String::getSubStr(%item, 0, String::len(%item)-1);	//remove the 0
	Client::sendMessage(%clientId, $MsgBeige, "You unequipped " @ BeltItem::GetName(%baseItem) @ ".~wCrossbow_Switch1.wav");
	Belt::TakeThisStuff(%clientId, %item, 1);
	Belt::GiveThisStuff(%clientid, %baseItem, 1);
	// need to unmount weapon somehow
	Player::unMountItem(%clientid, $WeaponSlot);
}

function Belt::EquipAccessory(%clientid, %item) {
	%totalItems = GetEquippedAccessoriesCountByBeltType(%clientid, "AccessoryItems");
	%itemList = GetEquippedAccessoriesByBeltType(%clientid, "AccessoryItems");
	%cnt = 0;

	for(%i = 0; %i <= %totalItems; %i++) {
		%checkItem = getword(%itemList, %i);
		%baseItem = String::getSubStr(%checkItem, 0, String::len(%checkItem)-1);

		if($AccessoryVar[%baseItem, $AccessoryType] == $AccessoryVar[%item, $AccessoryType]) {
			%cnt += 1;
		}
	}

	if (%cnt >= $maxAccessory[$AccessoryVar[%item, $AccessoryType]]) {
		Client::sendMessage(%clientId, $MsgRed, "You have too many of these accessory types already equipped.");
		return;
	}

	Client::sendMessage(%clientId, $MsgBeige, "You equipped " @ BeltItem::GetName(%item) @ ".~wCrossbow_Switch1.wav");
	Belt::TakeThisStuff(%clientId, %item, 1);
	Belt::GiveThisStuff(%clientid, %item @ "0", 1);
}

function Belt::UnequipAccessory(%clientid, %item) {
	%baseItem = String::getSubStr(%item, 0, String::len(%item)-1);
	Client::sendMessage(%clientId, $MsgBeige, "You unequipped " @ BeltItem::GetName(%baseItem) @ ".");
	Belt::TakeThisStuff(%clientId, %item, 1);
	Belt::GiveThisStuff(%clientid, %baseItem, 1);
}

$count["AmmoItems"] = 0;
$count["GemItems"] = 0;
$count["PotionItems"] = 0;
$count["WeaponItems"] = 0;
$count["ArmorItems"] = 0;
$count["QuestItems"] = 0;
$count["AccessoryItems"] = 0;
$count["MateriaItems"] = 0;
$count["MiscItems"] = 0;
$numBeltItems = 0;

generateEnchantsAndMateria();

//Ammunition
// function BeltItem::AddProjectile(%name, %item, %type, %weight, %cost, %image, %weaponSkill, %skillRestriction, %special, %shopIndex)
BeltItem::AddProjectile("Test Arrow", "TestArrow", "AmmoItems", 0.01, 1, "TestArrow", $SkillBows, $SkillBows @ " 1", "6 100");

BeltItem::AddProjectile("Small Rock", "SmallRock", "AmmoItems", 0.02, 13, "BasicRockImpact", $SkillBows, $SkillBows @ " 1", "6 5", 1);
BeltItem::AddProjectile("Basic Arrow", "BasicArrow", "AmmoItems", 0.01, 5, "BasicArrowImpact", $SkillBows, $SkillBows @ " 1", "6 10", 2);
BeltItem::AddProjectile("Sheaf Arrow", "SheafArrow", "AmmoItems", 0.01, 25, "BasicArrowImpact", $SkillBows, $SkillBows @ " 1", "6 20", 3);
BeltItem::AddProjectile("Bladed Arrow","BladedArrow","AmmoItems",0.01, 50, "BasicArrowImpact", $SkillBows, $SkillBows @ " 1", "6 40", 4);
BeltItem::AddProjectile("Stone Feather","StoneFeather","AmmoItems",0.01, 400, "BasicArrowImpact", $SkillBows, $SkillBows @ " 1", "6 60", 8);
BeltItem::AddProjectile("Metal Feather","MetalFeather","AmmoItems",0.01, 500, "BasicArrowImpact", $SkillBows, $SkillBows @ " 1", "6 80", 9);
BeltItem::AddProjectile("Talon", "Talon", "AmmoItems", 0.01, 800, "BasicArrowImpact", $SkillBows, $SkillBows @ " 1", "6 100", 10);
BeltItem::AddProjectile("Ceraphum's Feather","CeraphumsFeather","AmmoItems",0.01, 1000, "BasicArrowRadiusSmall", $SkillBows, $SkillBows @ " 1", "6 120", 11);
BeltItem::AddProjectile("Poison Arrow", "PoisonArrow", "AmmoItems", 0.01, 1000, "BasicArrowImpact", $SkillBows, $SkillBows @ " 1", "6 140", 12);
BeltItem::AddProjectile("Fire Arrow", "FireArrow", "AmmoItems", 0.01, 800, "FireArrowRadiusSmall", $SkillBows, $SkillBows @ " 1", "6 120", 13);

BeltItem::AddProjectile("Light Quarrel","LightQuarrel","AmmoItems",0.01 ,100, "BasicQuarrelImpact", $SkillBows, $SkillBows @ " 1", "6 10", 5);
BeltItem::AddProjectile("Heavy Quarrel","HeavyQuarrel","AmmoItems",0.01, 200, "BasicQuarrelImpact", $SkillBows, $SkillBows @ " 1", "6 20", 6);
BeltItem::AddProjectile("Short Quarrel","ShortQuarrel","AmmoItems",0.01, 300, "BasicQuarrelImpact", $SkillBows, $SkillBows @ " 1", "6 40", 7);
BeltItem::AddProjectile("Explosive Quarrel","ExplosiveQuarrel","AmmoItems" ,0.01, 500, "BasicQuarrelRadiusSmall", $SkillBows, $SkillBows @ " 1", "6 50", 14);

BeltItem::AddProjectile("Hex Arrow", "HexArrow", "AmmoItems", 0.01, 250, "PoisonArrowImpact", $SkillBows, $SkillBows @ " 200", "6 20", 15);
$beltitem[HexArrow, "SpellEffect"] = "hex";
BeltItem::AddProjectile("Vex Arrow", "VexArrow", "AmmoItems", 0.01, 500, "PoisonArrowImpact", $SkillBows, $SkillBows @ " 400", "6 40", 16);
$beltitem[VexArrow, "SpellEffect"] = "vex";
BeltItem::AddProjectile("Curse Arrow", "CurseArrow", "AmmoItems", 0.01, 1000, "PoisonArrowImpact", $SkillBows, $SkillBows @ " 600", "6 60", 1017);
$beltitem[CurseArrow, "SpellEffect"] = "curse";
BeltItem::AddProjectile("Plague Arrow", "PlagueArrow", "AmmoItems", 0.01, 1500, "PoisonArrowImpact", $SkillBows, $SkillBows @ " 800", "6 80", 1018);
$beltitem[PlagueArrow, "SpellEffect"] = "plague";
BeltItem::AddProjectile("Black Arrow", "BlackArrow", "AmmoItems", 0.01, 2000, "PoisonArrowImpact", $SkillBows, $SkillBows @ " 1000", "6 100", 1019);
$beltitem[BlackArrow, "SpellEffect"] = "blackdeath";

// enemy projectiles
BeltItem::AddWeapon("DragonBreath", "DragonBreath", "EnemyThrowingProjectile", $RangedAccessoryType, $description, $SkillBows, $SkillBows @ " 1000", "350");
BeltItem::AddProjectile("DragonBreathShot", "DragonBreathShot", "AmmoItems", 0.01, 1, "DragonFire", $SkillBows, $SkillBows @ " 1", "6 1");

// ninja stars
BeltItem::AddWeapon("Practice Bow", "PracticeBow", "LongBow", $RangedAccessoryType, $description, $SkillBows, $SkillBows @ " 1", "80", 174);
BeltItem::AddWeapon("Quickshot Bow", "QuickshotBow", "CompositeBowFast", $RangedAccessoryType, $description, $SkillBows, $SkillBows @ " 150", "105", 176);
BeltItem::AddWeapon("Hunting Bow", "HuntingBow", "CompositeBow", $RangedAccessoryType, $description, $SkillBows, $SkillBows @ " 300", "120", 177);
BeltItem::AddWeapon("Reinforced Longbow", "ReinforcedLongbow", "LongBow", $RangedAccessoryType, $description, $SkillBows, $SkillBows @ " 450", "150", 178);
BeltItem::AddWeapon("Repeater Crossbow", "RepeaterCrossbow", "RepeatingCrossbow", $RangedAccessoryType, $description, $SkillBows, $SkillBows @ " 600", "170", 179);
BeltItem::AddWeapon("Warbow", "Warbow", "LongBow", $RangedAccessoryType, $description, $SkillBows, $SkillBows @ " 750", "195", 180);
BeltItem::AddWeapon("Sharpshooter Bow", "SharpshooterBow", "CompositeBow", $RangedAccessoryType, $description, $SkillBows, $SkillBows @ " 900", "215", 181);
BeltItem::AddWeapon("Siege Crossbow", "SiegeCrossbow", "Crossbow", $RangedAccessoryType, $description, $SkillBows, $SkillBows @ " 1050", "235", 182);
BeltItem::AddWeapon("Gale Bow", "GaleBow", "CompositeBowFast", $RangedAccessoryType, $description, $SkillBows, $SkillBows @ " 1200", "255", 183);
BeltItem::AddWeapon("Elven Longbow", "ElvenLongbow", "LongBow", $RangedAccessoryType, $description, $SkillBows, $SkillBows @ " 1350", "280", 184);
BeltItem::AddWeapon("Storm Repeater", "StormRepeater", "RepeatingCrossbow", $RangedAccessoryType, $description, $SkillBows, $SkillBows @ " 1500", "305", 185);
BeltItem::AddWeapon("Arcane Bow", "ArcaneBow", "CompositeBow", $RangedAccessoryType, $description, $SkillBows, $SkillBows @ " 1650", "330", 186);
BeltItem::AddWeapon("Hawk's Talon", "HawksTalon", "LongBow", $RangedAccessoryType, $description, $SkillBows, $SkillBows @ " 1800", "360", 187);
BeltItem::AddWeapon("Dragonbone Crossbow", "DragonboneCrossbow", "Crossbow", $RangedAccessoryType, $description, $SkillBows, $SkillBows @ " 2000", "400", 188);

BeltItem::AddProjectile("Throwing Star", "ThrowingStar", "AmmoItems", 0.01, 10, "ThrowingStarImpact", $SkillBows, $SkillBows @ " 1", "6 240", 1050);
BeltItem::AddProjectile("Ninja Star", "NinjaStar", "AmmoItems", 0.01, 50, "ThrowingStarImpact", $SkillBows, $SkillBows @ " 150", "6 320", 1051);
BeltItem::AddProjectile("Shuriken", "Shuriken", "AmmoItems", 0.01, 200, "ThrowingStarImpact", $SkillBows, $SkillBows @ " 300", "6 440", 1052);
BeltItem::AddProjectile("War Star", "WarStar", "AmmoItems", 0.01, 500, "ThrowingStarImpact", $SkillBows, $SkillBows @ " 450", "6 520", 1053);
BeltItem::AddProjectile("Giant Shuriken", "GiantShuriken", "AmmoItems", 0.01, 1000, "ThrowingStarImpact", $SkillBows, $SkillBows @ " 600", "6 600", 1054);
BeltItem::AddProjectile("Meteor Star", "MeteorStar", "AmmoItems", 0.01, 2000, "ThrowingStarImpact", $SkillBows, $SkillBows @ " 750", "6 700", 1055);
BeltItem::AddProjectile("Shadow Star", "ShadowStar", "AmmoItems", 0.01, 3000, "ThrowingStarImpact", $SkillBows, $SkillBows @ " 900", "6 780", 1056);
BeltItem::AddProjectile("Sky Star", "SkyStar", "AmmoItems", 0.01, 4000, "ThrowingStarImpact", $SkillBows, $SkillBows @ " 1050", "6 860", 1057);
BeltItem::AddProjectile("Heaven Star", "HeavenStar", "AmmoItems", 0.01, 5000, "ThrowingStarImpact", $SkillBows, $SkillBows @ " 1200", "6 940", 1058);
BeltItem::AddProjectile("Celestial Star", "CelestialStar", "AmmoItems", 0.01, 6000, "ThrowingStarImpact", $SkillBows, $SkillBows @ " 1350", "6 1000", 1059);

//Gems
BeltItem::Add("Quartz", "Quartz", "GemItems", 0.2, 100);
BeltItem::Add("Granite", "Granite", "GemItems", 0.2, 180);
BeltItem::Add("Opal", "Opal", "GemItems", 0.2, 300);
BeltItem::Add("Jade", "Jade", "GemItems", 0.25, 550);
BeltItem::Add("Turquoise", "Turquoise", "GemItems", 0.3, 850);
BeltItem::Add("Ruby", "Ruby", "GemItems", 0.3, 1200);
BeltItem::Add("Topaz", "Topaz", "GemItems", 0.3, 1604);
BeltItem::Add("Sapphire","Sapphire","GemItems",0.3,2930);
BeltItem::Add("Gold","Gold","GemItems",0.35,4680);
BeltItem::Add("Emerald","Emerald","GemItems",0.2,9702);
BeltItem::Add("Diamond","Diamond","GemItems",0.1,16575);
BeltItem::Add("Keldrinite","Keldrinite","GemItems",5.0,125200);

// $AccessoryVar[Hatchet, $SpecialVar] = "6 20";                  //12 (5)
// $AccessoryVar[BroadSword, $SpecialVar] = "6 35";               //21 (5)
// $AccessoryVar[WarAxe, $SpecialVar] = "6 70";                   //30 (7)
// $AccessoryVar[LongSword, $SpecialVar] = "6 65";                //39 (5)
// $AccessoryVar[BattleAxe, $SpecialVar] = "6 144";               //48 (9)
// $AccessoryVar[BastardSword, $SpecialVar] = "6 133";            //57 (7)
// $AccessoryVar[Halberd, $SpecialVar] = "6 176";                 //66 (8)
// $AccessoryVar[Claymore, $SpecialVar] = "6 188";                //75.2 (7.5)
// $AccessoryVar[KeldriniteLS, $SpecialVar] = "6 90";

// ============== WEAPONS=============================================
// IMPORTANT: The weight of the weapon needs to match up with the Image Being used otherwise they will not be in sync.
// To help with this, try to set the weight of all weapons that use the same image to be the same.
// If you specifically WANT to create a faster or slower verison if something you will need
// to make a new ItemImage for that speed. Name it as such and use it as much as you want.
// -------------------------------------------------------------------
// AddWeapon(%name, %item, %image, %accessoryType, %miscInfo, %weaponSkill, %skillRestriction, %dps, %shopIndex)

// Item Guide
// starter - 1 / 20
// basic - 100 / 30
// Iron - 200 / 40
// Mythril - 300 / 50
// Coral - 400 / 60
// Blood - 500 / 70
// Ancient - 600 / 80
// Special - 700 / 90
// Diamond - 800 / 100
// Materia - 900 / 110
// Platinum - 1000 / 120
// Rune - 1200 / 140
// Moon - 1500 / 180
// Onion - 2000 / 240

// ------ sword images ------
// Sword - The classic old looking broadsword image (claymore / anchetsword)
// BroadSword - Newer lonmg sword with yellow hilt, white cross and sideways swing (looks like crusaders sword)
// Longsword - The classic smooth longsword with curled hilt and red gem
// ElfinBlade - Classic elfin  blade, has runes on it and swings fast (and spins)
// Shortsword - Classic side ways short sword smooth
// Katana - Classic katana with red hilt and black blade
// Gladius - Short nubby blade with a pierceing animation
// GoliathSword - Large and slow greatsword with a big swing
// GreenSword - A strange green katana looking sword with a somewhat broken animation
// GemSword - A nice gemmed sword with a standard swing action
// BoneSword - A bone... arm? That you swing like a golf club? Maybe a better funny hammer
// PhensSword - A very cool blue sword that looks magical. Very niiicceeeee.
// Slasher - Cool sideways slasher with grooves in it for catching blades

// Swords (17 - 49)
$description = "This broad-bladed sword is suited for large slashing strokes. It is inexpensive, but not particularly powerful.";
BeltItem::AddWeapon("Broadsword", "Broadsword", "Sword", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 1", "30", 17);
$description = "This straight and sharp double-edged blade can be used for either stabbing or slashing.";
BeltItem::AddWeapon("Longsword", "Longsword", "Longsword", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 120", "42", 18);
$description = "This sword has a broad and sturdy blade, but its iron construction makes it very heavy.";
BeltItem::AddWeapon("Iron Sword", "IronSword", "BroadSword", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 250", "55", 19);
$description = "A sword forged from the metal known as mythril. Its brilliantly shining blade is incredibly lightweight.";
BeltItem::AddWeapon("Mythril Sword", "MythrilSword", "Shortsword", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 380", "68", 20);
$description = "The handle of this single-edged sword has been decorated with intricate coral piecework.";
BeltItem::AddWeapon("Coral Sword", "CoralSword", "GemSword", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 520", "80", 21);
$description = "The blade of this sword is a deep crimson, as if it were drenched in blood. It is cruelly sharp.";
BeltItem::AddWeapon("Blood Sword", "BloodSword", "Katana", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 680", "92", 22);
$description = "A sword constructed using ancient techniques that have long since perished from the world.";
BeltItem::AddWeapon("Ancient Sword", "AncientSword", "GoliathSword", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 850", "105", 23);
$description = "A sleek blade with a yellow gem of Sleep Materia attached to it.";
BeltItem::AddWeapon("Sleep Blade", "SleepBlade", "BroadSword", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 1020", "118", 24);
$description = "The countless tiny diamonds embedded into this sword's blade saw into its victims, causing great damage.";
BeltItem::AddWeapon("Diamond Sword", "DiamondSword", "ElfinBlade", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 1210", "130", 25);
$description = "A sword of extraplanar origin.";
BeltItem::AddWeapon("Materia Blade", "MateriaBlade", "GreenSword", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 1410", "145", 26);
$description = "A shining sword made of a lustrous white alloy of mythril and platinum. Its broad blade is wickedly sharp.";
BeltItem::AddWeapon("Platinum Sword", "PlatinumSword", "GemSword", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 1640", "162", 27);
$description = "A sword inscribed with ancient runes.";
BeltItem::AddWeapon("Rune Blade", "RuneBlade", "PhensSword", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 1900", "185", 28);
$description = "A sword that glitters cruelly like a crescent moon.";
BeltItem::AddWeapon("Moon Blade", "MoonBlade", "Slasher", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 2150", "210", 29);
$description = "A blade forged for swordsmen who have mastered every technique and achieved knighthood's most exalted rank.";
BeltItem::AddWeapon("Onion Sword", "OnionSword", "Sword", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 2000", "255", 30);

// Axes (50 - 99)
$description = "An inexpensive axe that is easy to wield. It is easy for new axe users, but not particularly powerful.";
BeltItem::AddWeapon("Hand Axe", "HandAxe", "Hatchet", $AxeAccessoryType, $description, $SkillAxes, $SkillAxes @ " 1", "35", 51); // shop item 47
$description = "A medium sized axe that is relatively common. It is most often used by woodsmen, but is heavy enough to deal considerable damage.";
BeltItem::AddWeapon("Axe", "Axe", "Axe", $AxeAccessoryType, $description, $SkillAxes, $SkillAxes @ " 120", "50", 52);
$description = "A battle axe with a long handle. Designed for two-handed use, it can easily chop off an enemy's limbs.";
BeltItem::AddWeapon("Battle Axe", "BattleAxe", "BattleAxe", $AxeAccessoryType, $description, $SkillAxes, $SkillAxes @ " 250", "65", 53);
$description = "A mythril axe that is light and easy to wield. It is sharp enough to cut through even the toughest armor.";
BeltItem::AddWeapon("Mythril Axe", "MythrilAxe", "BattleAxeNew", $AxeAccessoryType, $description, $SkillAxes, $SkillAxes @ " 380", "80", 54);
$description = "An axe with a large head. Much bigger than the traditional woodman's axe, hence its name.";
BeltItem::AddWeapon("Giant Axe", "GiantAxe", "BattleAxe", $AxeAccessoryType, $description, $SkillAxes, $SkillAxes @ " 500", "95", 55);
$description = "The blade of this axe is a deep crimson, as if it were drenched in blood. It is cruelly sharp.";
BeltItem::AddWeapon("Blood Axe", "BloodAxe", "Hatchet", $AxeAccessoryType, $description, $SkillAxes, $SkillAxes @ " 650", "110", 56);
$description = "A battle axe constructed using ancient techniques that have long since perished from the world.";
BeltItem::AddWeapon("Ancient Axe", "AncientAxe", "Axe", $AxeAccessoryType, $description, $SkillAxes, $SkillAxes @ " 800", "125", 57);
$description = "This axe not only has impressive destructive power, but can also slow the actions of its target.";
BeltItem::AddWeapon("Slasher", "Slasher", "Hatchet", $AxeAccessoryType, $description, $SkillAxes, $SkillAxes @ " 950", "140", 58);
$description = "The countless tiny diamonds embedded into this axe's blade saw into its victims, causing great damage.";
BeltItem::AddWeapon("Diamond Axe", "DiamondAxe", "BattleAxeNew", $AxeAccessoryType, $description, $SkillAxes, $SkillAxes @ " 1100", "160", 59);
$description = "An axe of extraplanar origin.";
BeltItem::AddWeapon("Materia Axe", "MateriaAxe", "BattleAxe", $AxeAccessoryType, $description, $SkillAxes, $SkillAxes @ " 1250", "180", 60);
$description = "This axe's small size belies its incredible destructive power.";
BeltItem::AddWeapon("Francisca", "Francisca", "Hatchet", $AxeAccessoryType, $description, $SkillAxes, $SkillAxes @ " 1400", "200", 61);
$description = "An axe inscribed with ancient runes.";
BeltItem::AddWeapon("Rune Axe", "RuneAxe", "Axe", $AxeAccessoryType, $description, $SkillAxes, $SkillAxes @ " 1600", "225", 62);
$description = "An axe that glitters cruelly like a crescent moon.";
BeltItem::AddWeapon("Moon Axe", "MoonAxe", "BattleAxe", $AxeAccessoryType, $description, $SkillAxes, $SkillAxes @ " 1850", "265", 63);
$description = "An axe forged for axe users who have mastered every technique and achieved knighthood's most exalted rank.";
BeltItem::AddWeapon("Onion Axe", "OnionAxe", "BattleAxeNew", $AxeAccessoryType, $description, $SkillAxes, $SkillAxes @ " 2000", "320", 64);
 
// Special Axes
$description = "I'm a lumberjack and I'm okay. This axe is perfect for chopping wood and also for chopping heads.";
BeltItem::AddWeapon("Leif's Lumberjack Axe", "LeifsAxe", "WoodAxeFast", $AxeAccessoryType, $description, $SkillAxes, $SkillAxes @ " 1950", "300");

// Hammers: (100 - 124)
// Club, Mace, SpikedClub, SpikedMace
$description = "A simple wooden club, easy to wield but not particularly strong.";
BeltItem::AddWeapon("Club", "Club", "Club", $BludgeonAccessoryType, $description, $SkillHammers, $SkillHammers @ " 1", "27", 100);
$description = "A sturdy spiked club reinforced with iron. The spikes help it deal extra damage.";
BeltItem::AddWeapon("Spiked Club", "SpikedClub", "SpikedClub", $BludgeonAccessoryType, $description, $SkillHammers, $SkillHammers @ " 110", "40", 101);
$description = "A simple mace made from sturdy material. It is easy to wield and can deal heavy blows.";
BeltItem::AddWeapon("Mace", "Mace", "Mace", $BludgeonAccessoryType, $description, $SkillHammers, $SkillHammers @ " 240", "55", 102);
$description = "A heavy iron hammer that can easily crush armor and bones.";
BeltItem::AddWeapon("Iron Hammer", "IronHammer", "Hammer", $BludgeonAccessoryType, $description, $SkillHammers, $SkillHammers @ " 360", "70", 103);
$description = "A mace with a spiked head, designed for smashing through enemy defenses.";
BeltItem::AddWeapon("Spiked Mace", "SpikedMace", "SpikedMace", $BludgeonAccessoryType, $description, $SkillHammers, $SkillHammers @ " 480", "85", 104);
$description = "A hammer made of mythril, light yet capable of dealing heavy blows.";
BeltItem::AddWeapon("Mythril Hammer", "MythrilHammer", "Hammer", $BludgeonAccessoryType, $description, $SkillHammers, $SkillHammers @ " 630", "100", 105);
$description = "A large hammer reinforced with steel, capable of shattering shields with ease.";
BeltItem::AddWeapon("War Hammer", "WarHammer", "Hammer", $BludgeonAccessoryType, $description, $SkillHammers, $SkillHammers @ " 780", "120", 106);
$description = "A club made from dragon bone, incredibly tough and powerful.";
BeltItem::AddWeapon("Dragon Bone Club", "DragonBoneClub", "Mace", $BludgeonAccessoryType, $description, $SkillHammers, $SkillHammers @ " 920", "135", 107);
$description = "A sacred hammer said to hold divine power, used by holy knights.";
BeltItem::AddWeapon("Holy Hammer", "HolyHammer", "Hammer", $BludgeonAccessoryType, $description, $SkillHammers, $SkillHammers @ " 1050", "150", 108);
$description = "A battle hammer used by giants. Though slow, its strikes are devastating.";
BeltItem::AddWeapon("Giant's Hammer", "GiantsHammer", "Hammer", $BludgeonAccessoryType, $description, $SkillHammers, $SkillHammers @ " 1220", "165", 109);
$description = "A hammer infused with volcanic energy. Each swing leaves a burning impact.";
BeltItem::AddWeapon("Magma Hammer", "MagmaHammer", "SpikedMace", $BludgeonAccessoryType, $description, $SkillHammers, $SkillHammers @ " 1370", "180", 110);
$description = "An ancient war club used in forgotten battles. Its power has endured through time.";
BeltItem::AddWeapon("Ancient War Club", "AncientWarClub", "Club", $BludgeonAccessoryType, $description, $SkillHammers, $SkillHammers @ " 1570", "200", 111);
$description = "A hammer covered in mystical runes, amplifying its destructive force.";
BeltItem::AddWeapon("Rune Hammer", "RuneHammer", "Hammer", $BludgeonAccessoryType, $description, $SkillHammers, $SkillHammers @ " 1820", "220", 112);
$description = "The legendary hammer said to call down the wrath of the heavens upon its foes.";
BeltItem::AddWeapon("Mjolnir", "Mjolnir", "SpikedMace", $BludgeonAccessoryType, $description, $SkillHammers, $SkillHammers @ " 1950", "250", 113);


// Katanas (125 - 149)
$description = "A short and slightly curved blade used by Ninjas and Samurais. It is easy to wield and can be used for quick, precise strikes.";
BeltItem::AddWeapon("Tanto", "Tanto", "Dagger", $SwordAccessoryType, $description, $SkillKatanas, $SkillKatanas @ " 1", "40", 125);
$description = "A lightweight sword favored by rogue warriors for its balance of speed and cutting power.";
BeltItem::AddWeapon("Shinobi Blade", "ShinobiBlade", "Shortsword", $SwordAccessoryType, $description, $SkillKatanas, $SkillKatanas @ " 150", "65", 126);
$description = "A dagger-like blade used for swift and deadly precision attacks.";
BeltItem::AddWeapon("Kunai", "Kunai", "Dagger", $SwordAccessoryType, $description, $SkillKatanas, $SkillKatanas @ " 280", "90", 127);
$description = "A finely crafted shortsword with a slight curve, made for lightning-fast slashes.";
BeltItem::AddWeapon("Kodachi", "Kodachi", "Shortsword", $SwordAccessoryType, $description, $SkillKatanas, $SkillKatanas @ " 400", "110", 128);
$description = "A straight-bladed katana designed for piercing as well as slashing.";
BeltItem::AddWeapon("Chokuto", "Chokuto", "Shortsword", $SwordAccessoryType, $description, $SkillKatanas, $SkillKatanas @ " 530", "130", 129);
$description = "A classic katana with an elegant curve, designed for fluid, precise strikes.";
BeltItem::AddWeapon("Katana", "Katana", "Katana", $SwordAccessoryType, $description, $SkillKatanas, $SkillKatanas @ " 680", "155", 130);
$description = "A slightly longer katana made for warriors who prefer reach over speed.";
BeltItem::AddWeapon("Uchigatana", "Uchigatana", "Katana", $SwordAccessoryType, $description, $SkillKatanas, $SkillKatanas @ " 830", "175", 131);
$description = "A masterfully forged katana that can cut through armor with ease.";
BeltItem::AddWeapon("Onimusha", "Onimusha", "Katana", $SwordAccessoryType, $description, $SkillKatanas, $SkillKatanas @ " 950", "195", 132);
$description = "A blade said to have been forged in a dragon's flame, making it incredibly sharp and resilient.";
BeltItem::AddWeapon("Ryujin", "Ryujin", "Katana", $SwordAccessoryType, $description, $SkillKatanas, $SkillKatanas @ " 1100", "215", 133);
$description = "A legendary cursed blade that thirsts for blood.";
BeltItem::AddWeapon("Muramasa", "Muramasa", "Katana", $SwordAccessoryType, $description, $SkillKatanas, $SkillKatanas @ " 1250", "240", 134);
$description = "A katana infused with ancient magic, increasing its wielder's speed and precision.";
BeltItem::AddWeapon("Hoshikiri", "Hoshikiri", "Katana", $SwordAccessoryType, $description, $SkillKatanas, $SkillKatanas @ " 1400", "265", 135);
$description = "A blade so sharp it is said to slice through the wind itself.";
BeltItem::AddWeapon("Kamaitachi", "Kamaitachi", "Dagger", $SwordAccessoryType, $description, $SkillKatanas, $SkillKatanas @ " 1600", "290", 136);
$description = "A katana that radiates divine energy, only wielded by the most skilled samurai.";
BeltItem::AddWeapon("Tengoku", "Tengoku", "Katana", $SwordAccessoryType, $description, $SkillKatanas, $SkillKatanas @ " 1850", "320", 137);
$description = "The ultimate katana, forged by the gods and capable of cutting through reality itself.";
BeltItem::AddWeapon("Masamune", "Masamune", "Katana", $SwordAccessoryType, $description, $SkillKatanas, $SkillKatanas @ " 2000", "350", 138);


// Staves and Spears (150 - 174)
// QuarterStaff, LongStaff, Spear, Trident, Javelin
// min skill 1
// min attack 20
// Max skill 2000
// Max attack 200
// shop index starts at 150
$description = "A simple wooden staff not meant for more than just walking. However, you do sense some small amount of magicka within it.";
BeltItem::AddWeapon("Walking Staff", "WalkingStaff", "QuarterStaff", $BludgeonAccessoryType, $description, $SkillSpears, $SkillSpears @ " 1", "20", 150);
$description = "A long wooden staff reinforced with iron tips, making it slightly more durable.";
BeltItem::AddWeapon("Ironwood Staff", "IronwoodStaff", "LongStaff", $BludgeonAccessoryType, $description, $SkillSpears, $SkillSpears @ " 150", "30", 151);
$description = "A simple spear used by hunters and foot soldiers alike.";
BeltItem::AddWeapon("Hunting Spear", "HuntingSpear", "Spear", $BludgeonAccessoryType, $description, $SkillSpears, $SkillSpears @ " 300", "40", 152);
$description = "A well-crafted wooden staff with a silver core, amplifying magical energy.";
BeltItem::AddWeapon("Silver Staff", "SilverStaff", "LongStaff", $BludgeonAccessoryType, $description, $SkillSpears, $SkillSpears @ " 450", "50", 153);
$description = "A trident with jagged edges, designed to inflict deep wounds.";
BeltItem::AddWeapon("Barbed Trident", "BarbedTrident", "Trident", $BludgeonAccessoryType, $description, $SkillSpears, $SkillSpears @ " 600", "60", 154);
$description = "A long and heavy battle staff infused with protective enchantments.";
BeltItem::AddWeapon("Runed Staff", "RunedStaff", "QuarterStaff", $BludgeonAccessoryType, $description, $SkillSpears, $SkillSpears @ " 750", "70", 155);
$description = "A steel-tipped javelin that is both lightweight and deadly accurate.";
BeltItem::AddWeapon("Steel Javelin", "SteelJavelin", "Javelin", $BludgeonAccessoryType, $description, $SkillSpears, $SkillSpears @ " 900", "80", 156);
$description = "A golden staff once wielded by legendary mages. It hums with latent power.";
BeltItem::AddWeapon("Sage's Staff", "SagesStaff", "LongStaff", $BludgeonAccessoryType, $description, $SkillSpears, $SkillSpears @ " 1050", "95", 157);
$description = "A spear said to be blessed by the gods, striking true even in the hands of the unskilled.";
BeltItem::AddWeapon("Divine Spear", "DivineSpear", "Spear", $BludgeonAccessoryType, $description, $SkillSpears, $SkillSpears @ " 1200", "110", 158);
$description = "A long staff imbued with raw elemental energy, crackling at its ends.";
BeltItem::AddWeapon("Elemental Rod", "ElementalRod", "QuarterStaff", $BludgeonAccessoryType, $description, $SkillSpears, $SkillSpears @ " 1350", "125", 159);
$description = "A wicked trident said to channel the wrath of the ocean itself.";
BeltItem::AddWeapon("Leviathan's Trident", "LeviathansTrident", "Trident", $BludgeonAccessoryType, $description, $SkillSpears, $SkillSpears @ " 1500", "140", 160);
$description = "A masterfully crafted javelin that pierces through armor effortlessly.";
BeltItem::AddWeapon("Phantom Javelin", "PhantomJavelin", "Javelin", $BludgeonAccessoryType, $description, $SkillSpears, $SkillSpears @ " 1650", "160", 161);
$description = "A legendary spear said to have slain dragons in ages past.";
BeltItem::AddWeapon("Dragon Slayer", "DragonSlayer", "Spear", $BludgeonAccessoryType, $description, $SkillSpears, $SkillSpears @ " 1800", "180", 162);
$description = "An ancient and mysterious staff of unparalleled magical power.";
BeltItem::AddWeapon("Celestial Staff", "CelestialStaff", "LongStaff", $BludgeonAccessoryType, $description, $SkillSpears, $SkillSpears @ " 1950", "190", 163);
$description = "The ultimate spear, said to pierce even the heavens.";
BeltItem::AddWeapon("Gungnir", "Gungnir", "Spear", $BludgeonAccessoryType, $description, $SkillSpears, $SkillSpears @ " 2000", "200", 164);

// Bows (175 - 199)
// Images: Crossbow, RepeatingCrossbow, LongBow, CompositeBow, CompositeBowFast, Sling
$description = "A small bow mostly used for practice.";
BeltItem::AddWeapon("Practice Bow", "PracticeBow", "LongBow", $RangedAccessoryType, $description, $SkillBows, $SkillBows @ " 1", "60", 174);
$description = "A simple sling used for hunting small game.";
BeltItem::AddWeapon("Sling", "Sling", "Sling", $RangedAccessoryType, $description, $SkillBows, $SkillBows @ " 1", "60", 175);
$description = "A lightweight bow made for rapid firing.";
BeltItem::AddWeapon("Quickshot Bow", "QuickshotBow", "CompositeBowFast", $RangedAccessoryType, $description, $SkillBows, $SkillBows @ " 150", "85", 176);
$description = "A handcrafted wooden bow designed for basic archery.";
BeltItem::AddWeapon("Hunting Bow", "HuntingBow", "CompositeBow", $RangedAccessoryType, $description, $SkillBows, $SkillBows @ " 300", "110", 177);
$description = "A well-balanced longbow with reinforced limbs for extra power.";
BeltItem::AddWeapon("Reinforced Longbow", "ReinforcedLongbow", "LongBow", $RangedAccessoryType, $description, $SkillBows, $SkillBows @ " 450", "130", 178);
$description = "A repeating crossbow capable of firing multiple bolts in quick succession.";
BeltItem::AddWeapon("Repeater Crossbow", "RepeaterCrossbow", "RepeatingCrossbow", $RangedAccessoryType, $description, $SkillBows, $SkillBows @ " 600", "150", 179);
$description = "A sturdy war bow favored by veteran archers.";
BeltItem::AddWeapon("Warbow", "Warbow", "LongBow", $RangedAccessoryType, $description, $SkillBows, $SkillBows @ " 750", "175", 180);
$description = "A precision-crafted composite bow known for its deadly accuracy.";
BeltItem::AddWeapon("Sharpshooter Bow", "SharpshooterBow", "CompositeBow", $RangedAccessoryType, $description, $SkillBows, $SkillBows @ " 900", "195", 181);
$description = "A heavy crossbow capable of piercing through armor.";
BeltItem::AddWeapon("Siege Crossbow", "SiegeCrossbow", "Crossbow", $RangedAccessoryType, $description, $SkillBows, $SkillBows @ " 1050", "215", 182);
$description = "An enchanted bow said to be blessed by the spirits of the wind.";
BeltItem::AddWeapon("Gale Bow", "GaleBow", "CompositeBowFast", $RangedAccessoryType, $description, $SkillBows, $SkillBows @ " 1200", "235", 183);
$description = "A lightweight but durable longbow used by elven rangers.";
BeltItem::AddWeapon("Elven Longbow", "ElvenLongbow", "LongBow", $RangedAccessoryType, $description, $SkillBows, $SkillBows @ " 1350", "260", 184);
$description = "A repeating crossbow enhanced with mechanisms for rapid-fire accuracy.";
BeltItem::AddWeapon("Storm Repeater", "StormRepeater", "RepeatingCrossbow", $RangedAccessoryType, $description, $SkillBows, $SkillBows @ " 1500", "285", 185);
$description = "A mystical bow infused with elemental energy, increasing its power.";
BeltItem::AddWeapon("Arcane Bow", "ArcaneBow", "CompositeBow", $RangedAccessoryType, $description, $SkillBows, $SkillBows @ " 1650", "310", 186);
$description = "A legendary bow capable of firing arrows that never miss their mark.";
BeltItem::AddWeapon("Hawk's Talon", "HawksTalon", "LongBow", $RangedAccessoryType, $description, $SkillBows, $SkillBows @ " 1800", "340", 187);
$description = "The ultimate crossbow, forged from ancient dragonbone and enhanced by magic.";
BeltItem::AddWeapon("Dragonbone Crossbow", "DragonboneCrossbow", "Crossbow", $RangedAccessoryType, $description, $SkillBows, $SkillBows @ " 2000", "370", 188);
$description = "A worn but sturdy bow. It feels light in the hands and radiates a warm energy. Where did you find this?";
BeltItem::AddWeapon("Longbow's Bow", "LongbowsBow", "CompositeBowFast", $RangedAccessoryType, $description, $SkillBows, $SkillBows @ " 5000", "1000", 189);

// Armors and Shields (200 - 299)
// BeltItem::AddArmor(%name, %item, %armorSkin, %hitSound, %special, %weight, %skillRestriction, %miscInfo, %shopIndex)

$description = "Made for use in battle, this is sturdier than normal clothing.";
BeltItem::AddArmor("Leather Clothing", "LeatherClothing", "rpgpadded", SoundHitFlesh, "7 30 3 15", "10", $SkillEndurance @ " 5", $description, 200);
$description = "Armor made from layers of tanned leather.";
BeltItem::AddArmor("Leather Armor", "LeatherArmor", "rpgleather", SoundHitLeather, "7 60 3 30", "10", $SkillEndurance @ " 75", $description, 201);
$description = "Linen armor with a bronze breastplate.";
BeltItem::AddArmor("Linen Cuirass", "LinenCuirass", "rpgstudleather", SoundHitLeather, "7 90 3 45", "10", $SkillEndurance @ " 125", $description, 202);
$description = "Simply fashioned bronze armor.";
BeltItem::AddArmor("Bronze Armor", "BronzeArmor", "rpgspiked", SoundHitLeather, "7 120 3 60", "10", $SkillEndurance @ " 180", $description, 203);
$description = "Armor fashioned from countless interlocking metal rings.";
BeltItem::AddArmor("Chain Mail", "ChainMail", "rpgchainmail", SoundHitLeather, "7 160 3 80", "10", $SkillEndurance @ " 230", $description, 204);
$description = "Armor made from the valuable metal known as mythril. It is surprisingly light and sturdy.";
BeltItem::AddArmor("Mythril Armor", "MythrilArmor", "rpgscalemail", SoundHitChain, "7 210 3 105", "10", $SkillEndurance @ " 300", $description, 205);
$description = "The unique design of this armor greatly increases its protective qualities.";
BeltItem::AddArmor("Brigandine Armor", "PlateMail", "rpgbrigandine", SoundHitChain, "7 260 3 130", "10", $SkillEndurance @ " 450", $description, 206);
$description = "Improved plate mail that has been decorated with gold.";
BeltItem::AddArmor("Golden Armor", "GoldenArmor", "rpgchainmail", SoundHitChain, "7 320 3 160", "10", $SkillEndurance @ " 600", $description, 207);
$description = "Armor that has been reinforced with incredibly hard gemstones.";
BeltItem::AddArmor("Diamond Armor", "DiamondArmor", "rpgringmail", SoundHitChain, "7 380 3 190", "10", $SkillEndurance @ " 750", $description, 208);
$description = "Brilliantly shining armor made of a lustrous white alloy of mythril and platinum.";
BeltItem::AddArmor("Platinum Armor", "PlatinumArmor", "rpgbandedmail", SoundHitChain, "7 440 3 220", "10", $SkillEndurance @ " 900", $description, 209);
$description = "Thick mythril armor designed to withstand even the most intense shocks.";
BeltItem::AddArmor("Carabineer Mail", "CarabineerMail", "rpgsplintmail", SoundHitChain, "7 500 3 250", "10", $SkillEndurance @ " 1050", $description, 210);
$description = "Armor with the power to reflect magick used on the wearer.";
BeltItem::AddArmor("Mirror Mail", "MirrorMail", "rpgbronzeplate", SoundHitPlate, "7 580 3 290", "10", $SkillEndurance @ " 1200", $description, 211);
$description = "Platinum armor reinforced in places with crystalline gemstones found deep within the earth.";
BeltItem::AddArmor("Crystal Armor", "CrystalArmor", "rpgplatemail", SoundHitPlate, "7 650 3 325", "10", $SkillEndurance @ " 1350", $description, 212);
$description = "Legendary armor given by the gods to a knight in honor of his service. Confers divine protection to the wearer.";
BeltItem::AddArmor("Genji Armor", "GenjiArmor", "rpgfieldplate", SoundHitPlate, "7 750 3 375", "10", $SkillEndurance @ " 1500", $description, 213);
$description = "Top-grade armor made with advanced techniques. The materials and design make it exceedingly strong.";
BeltItem::AddArmor("Maximillian", "Maximillian", "rpgfullplate", SoundHitPlate, "7 850 3 425", "10", $SkillEndurance @ " 1650", $description, 214);
$description = "A dark mail covered in scales of fallen Dragons.";
BeltItem::AddArmor("Dragon Mail", "DragonMail", "rpghuman6", SoundHitPlate, "7 1000 3 500", "10", $SkillEndurance @ " 1800", $description, 215);
$description = "Armor forged for swordsmen who have mastered every technique and achieved knighthood's most exalted rank.";
BeltItem::AddArmor("Onion Armor", "OnionArmor", "rpgfullplate",  SoundHitPlate,"7 1200 3 600", "10", $SkillEndurance @ " 2000", $description, 216);

$description = "A simple weave favored by new adventurers; light and supple, it barely whispers when you move.";
BeltItem::AddRobe("Novice Acolyte Robe", "NoviceAcolyteRobe", "robepink", "3 30 7 15 11 1", "1", $SkillMagicka @ " 5", $description, 250);
$description = "Traditional garb of healing orders; threads are blessed to soothe the wearer in battle.";
BeltItem::AddRobe("White Mage Vestment", "WhiteMageVestment", "robepurple", "3 108 7 54 11 2", "1", $SkillMagicka @ " 138", $description, 251);
$description = "Robe patterned after a notorious magus; its lining hums with unstable aether.";
BeltItem::AddRobe("Black Waltz Robe", "BlackWaltzRobe", "robered", "3 186 7 93 11 3", "1", $SkillMagicka @ " 271", $description, 252);
$description = "A mantle stitched with runes that bend seconds into strands—perfect for time magicks.";
BeltItem::AddRobe("Timeweaver Mantle", "TimeweaverMantle", "robeblue", "3 264 7 132 11 4", "1", $SkillMagicka @ " 404", $description, 253);
$description = "Earth-touched kesa worn by geomancers; soil never stains it, stones seem to soften underfoot.";
BeltItem::AddRobe("Geomancer's Kesa", "GeomancersKesa", "robeblack", "3 342 7 171 11 5", "1", $SkillMagicka @ " 537", $description, 254);
$description = "A sea-blessed wrap that carries the hush of tides; water spells flow like currents.";
BeltItem::AddRobe("Oracle of Tides Robe", "OracleOfTidesRobe", "robewhite", "3 420 7 210 11 6", "1", $SkillMagicka @ " 670", $description, 255);
$description = "A celebrant's stole from draconic rites; scales sewn within lend surprising resilience.";
BeltItem::AddRobe("Dragonsong Stole", "DragonsongStole", "robeorange", "3 498 7 249 11 7", "1", $SkillMagicka @ " 803", $description, 256);
$description = "Shadow-steeped shroud that veils the wearer like moonless fog; eyes slip past you.";
BeltItem::AddRobe("Voidwitch Shroud", "VoidwitchShroud", "robebrown", "3 576 7 288 11 8", "1", $SkillMagicka @ " 936", $description, 257);
$description = "Star-mapped weave used by astrologians; constellations flare when fate is read.";
BeltItem::AddRobe("Astrologian Starweave", "AstrologianStarweave", "robegreen", "3 654 7 327 11 9", "1", $SkillMagicka @ " 1069", $description, 258);
$description = "Ceremonial garb wreathed in ember-charms; warmth radiates without burning.";
BeltItem::AddRobe("Ifritfire Ceremonial Robe", "IfritfireCeremonialRobe", "robeblack", "3 732 7 366 11 10", "1", $SkillMagicka @ " 1202", $description, 259);
$description = "Frost-kissed robe that never thaws; chilling calm sharpens the mind's focus.";
BeltItem::AddRobe("Shiva Frostweave", "ShivaFrostweave", "robewhite", "3 810 7 405 11 11", "1", $SkillMagicka @ " 1335", $description, 260);
$description = "Thunder-sigiled cloak; each step crackles faintly as air gathers to your call.";
BeltItem::AddRobe("Ramuh Levincloak", "RamuhLevincloak", "robered", "3 888 7 444 11 12", "1", $SkillMagicka @ " 1468", $description, 261);
$description = "Stone-anchored vestment; grounding cords steady stance and will alike.";
BeltItem::AddRobe("Titan Earthward Robe", "TitanEarthwardRobe", "robegreen", "3 966 7 483 11 13", "1", $SkillMagicka @ " 1601", $description, 262);
$description = "A torrent-warded wrap; hems ripple as if in unseen tides, quickening spellcraft.";
BeltItem::AddRobe("Leviathan Stormwrap", "LeviathanStormwrap", "robepurple", "3 1044 7 522 11 14", "1", $SkillMagicka @ " 1734", $description, 263);
$description = "An umbral vestment for archmagi; the void at the hem drinks stray mana.";
BeltItem::AddRobe("Umbral Archmage Robe", "UmbralArchmageRobe", "robebrown", "3 1122 7 561 11 15", "1", $SkillMagicka @ " 1867", $description, 264);
$description = "A grand robe bound with zodiac plats; its pages and pleats record destinies.";
BeltItem::AddRobe("Zodiac Grand Grimoire", "ZodiacGrandGrimoire", "robeblue", "3 1200 7 600 11 16", "1", $SkillMagicka @ " 2000", $description, 265);

// Test Robe
$description = "Longbow's Robe";
BeltItem::AddRobe("Longbow's Robe", "LongbowsRobe", "robeorange", "3 9999 7 9999 11 1", "1", $SkillMagicka @ " 1", $description);


$description = "Gloves specially made for throwing small objects with great accuracy.";
BeltItem::AddWeapon("Throwing Gloves", "ThrowingGloves", "ThrowingGloves", $RangedAccessoryType, $description, $SkillBows, "C Hunter C Sniper", "10", 298);
$description = "Pugilist's Gloves";
BeltItem::AddWeapon("Pugilist's Gloves", "PugilistsGlove", "Unarmed", $SwordAccessoryType, $description, $SkillSwords, "C Monk", "1", 299);

// $description = "A fine robe made from the finest elven silk.";
// BeltItem::AddRobe("Fine Robe", "FineRobe", "rpgpadded", "7 30 4 5", "10", $SkillMagicka @ " 8", $description);
// $description = "A robe that was tailor made for mages who graduated from the academy.";
// BeltItem::AddRobe("Advisor Robe", "AdvisorRobe", "rpgpadded", "7 30 4 5", "10", $SkillMagicka @ " 8", $description);
// $description = "And elvish robe that is infused with magical runes.";
// BeltItem::AddRobe("Elven Robe", "ElvenRobe", "rpgpadded", "7 30 4 5", "10", $SkillMagicka @ " 8", $description);
// $description = "A robe that was created with the power of the vengeance in mind.";
// BeltItem::AddRobe("Robe Of Venjance", "RobeOfVenjance", "rpgpadded", "7 30 4 5", "10", $SkillMagicka @ " 8", $description);
// $description = "A bloody and tattered robe that radiates with magical energy.";
// BeltItem::AddRobe("Blood Robe", "BloodRobe","rpgpadded", "7 30 4 5", "10", $SkillMagicka @ " 8", $description);
// $description = "A robe said to have been worn by the legendary mage, Phens.";
// BeltItem::AddRobe("Phens Robe", "PhensRobe", "rpgpadded", "7 30 4 5", "10", $SkillMagicka @ " 8", $description);
// $description = "A robe given to only the most dedicated and powerful mages in the land.";
// BeltItem::AddRobe("Quest Master Robe", "QuestMasterRobe", "rpgpadded", "7 30 4 5", "10", $SkillMagicka @ " 8", $description);

// Shields
// BeltItem::AddShield(%name, %item, %special, %weight, %skillRestriction, %miscInfo, %shopIndex)
$description = "A knightly shield made of wood and iron.";
BeltItem::AddShield("Knight Shield", "KnightShield", "7 250", $AccessoryVar[KnightShield, $Weight]);
$description = "A heavenly shield that radiates with divine energy.";
BeltItem::AddShield("Heavenly Shield", "HeavenlyShield", "7 315 3 635", $AccessoryVar[HeavenlyShield, $Weight]);
$description = "A shimmering shield covered in scales of fallen Dragons.";
BeltItem::AddShield("Dragon Shield", "DragonShield", "7 540 4 210", $AccessoryVar[DragonShield, $Weight]);

// Accessory Items (300 - 499)
// TODO: Write the tent update code
// BeltItem::Add("Tent", "Tent", "AccessoryItems", $AccessoryVar[Tent, $Weight], GenerateItemCost(Tent));

// function BeltItem::AddAccessory(%name, %item, %accessoryType, %beltType, %special, %weight, %skillRestriction, %miscInfo, %shopIndex)
$description = "A small belt pouch that slightly increases carrying capacity.";
BeltItem::AddAccessory("Small Belt Pouch", "SmallBeltPouch", $TalismanAccessoryType, "AccessoryItems", "12 50", 0.1, "", $description, 300);
$description = "A large belt pouch that increases carrying capacity.";
BeltItem::AddAccessory("Medium Belt Pouch", "MediumBeltPouch", $TalismanAccessoryType, "AccessoryItems", "12 100", 0.1, "", $description, 301);
$description = "A large belt pouch that greatly increases carrying capacity.";
BeltItem::AddAccessory("Large Belt Pouch", "LargeBeltPouch", $TalismanAccessoryType, "AccessoryItems", "12 150", 0.1, "", $description, 302);

$description = "Cheetaur's Paws increase speed and jump power!";
BeltItem::AddAccessory("Cheetaurs Paws", "CheetaursPaws", $BootsAccessoryType, "AccessoryItems", "8 1", 3, "", $description, 303);
$description = "Boots Of Gliding let you glide!";
BeltItem::AddAccessory("Boots Of Gliding", "BootsOfGliding", $BootsAccessoryType, "AccessoryItems", "8 2", 3, "", $description, 304);
$description = "Wind Walkers let you fly!";
BeltItem::AddAccessory("Wind Walkers", "WindWalkers", $BootsAccessoryType, "AccessoryItems", "8 3", 3, "", $description, 305);

$description = "An ornate golden ring with the word LongBow written on the inside of the ring.";
BeltItem::AddAccessory("LongBows Ring", "LongbowsRing", $RingAccessoryType, "AccessoryItems", "7 500 3 500", 0.1, "", $description, 306);
// update the descriptons of Ring of Magical Defense 1 - 5 such that each level gets nicer descriptions, ex: ring 1 might just be a simple band
$description = "A simple iron band that offers basic magical protection.";
BeltItem::AddAccessory("Ring of Magical Defense +1", "RingOfMagicalDefense1", $RingAccessoryType, "AccessoryItems", "3 100", 0.1, "", $description, 307);
$description = "A delicate silver ring that offers moderate magical protection.";
BeltItem::AddAccessory("Ring of Magical Defense +2", "RingOfMagicalDefense2", $RingAccessoryType, "AccessoryItems", "3 200", 0.1, "", $description, 308);
$description = "A beautifully crafted ring that offers strong magical protection.";
BeltItem::AddAccessory("Ring of Magical Defense +3", "RingOfMagicalDefense3", $RingAccessoryType, "AccessoryItems", "3 300", 0.1, "", $description, 309);
$description = "A radiant golden ring that offers exceptional magical protection.";
BeltItem::AddAccessory("Ring of Magical Defense +4", "RingOfMagicalDefense4", $RingAccessoryType, "AccessoryItems", "3 400", 0.1, "", $description, 310);
$description = "An ornate platinum ring that offers unparalleled magical protection.";
BeltItem::AddAccessory("Ring of Magical Defense +5", "RingOfMagicalDefense5", $RingAccessoryType, "AccessoryItems", "3 500", 0.1, "", $description, 311);

$description = "A simple iron band that offers basic physical protection.";
BeltItem::AddAccessory("Ring of Defense +1", "RingOfDefense1", $RingAccessoryType, "AccessoryItems", "7 100", 0.1, "", $description, 312);
$description = "A delicate silver ring that offers moderate physical protection.";
BeltItem::AddAccessory("Ring of Defense +2", "RingOfDefense2", $RingAccessoryType, "AccessoryItems", "7 200", 0.1, "", $description, 313);
$description = "A beautifully crafted ring that offers strong physical protection.";
BeltItem::AddAccessory("Ring of Defense +3", "RingOfDefense3", $RingAccessoryType, "AccessoryItems", "7 300", 0.1, "", $description, 314);
$description = "A radiant golden ring that offers exceptional physical protection.";
BeltItem::AddAccessory("Ring of Defense +4", "RingOfDefense4", $RingAccessoryType, "AccessoryItems", "7 400", 0.1, "", $description, 315);
$description = "An ornate platinum ring that offers unparalleled physical protection.";
BeltItem::AddAccessory("Ring of Defense +5", "RingOfDefense5", $RingAccessoryType, "AccessoryItems", "7 500", 0.1, "", $description, 316);

// Other Items (500+)

//Potions
// function BeltItem::Add(%name, %item, %type, %weight, %cost, %image, %shopIndex) {
BeltItem::Add("Potion","Potion", "PotionItems", 0.5, 10, "", 501);
$AccessoryVar[Potion, $MiscInfo] = "A potion of Healing that heals 25 HP";
$restoreValue[Potion, HP] = 25;
$AccessoryVar[Potion, "AlchemyIngredients"] = "CrackedFlask 1 VialOfWater 1 HealingHerb 5";

BeltItem::Add("Hi-Potion", "HiPotion", "PotionItems", 0.5, 100, "", 502);
$AccessoryVar[HiPotion, $MiscInfo] = "A potion of Healing that heals 100 HP";
$restoreValue[HiPotion, HP] = 100;
$AccessoryVar[HiPotion, "AlchemyIngredients"] = "WornGlassVial 1 VialOfWater 1 HealingHerb 10 MandragoraRoot 2";

BeltItem::Add("X-Potion", "XPotion", "PotionItems", 0.5, 1000, "", 503);
$AccessoryVar[XPotion, $MiscInfo] = "A potion of Healing that heals 250 HP";
$restoreValue[XPotion, HP] = 250;
$AccessoryVar[XPotion, "AlchemyIngredients"] = "ReinforcedAlchemistsBottle 1 VialOfWater 1 MandragoraRoot 10 MaidensTear 2";

BeltItem::Add("Mega Potion", "MegaPotion", "PotionItems", 0.5, 2500, "", 504);
$AccessoryVar[MegaPotion, $MiscInfo] = "A potion of Healing that heals 500 HP";
$restoreValue[MegaPotion, HP] = 500;
$AccessoryVar[MegaPotion, "AlchemyIngredients"] = "ArcaneCrystalPhial 1 VialOfWater 1 MaidensTear 10 Sylphroot 2";

BeltItem::Add("Elixir", "Elixir", "PotionItems", 0.5, 5000, "", 505);
$AccessoryVar[Elixir, $MiscInfo] = "A rare elixir that restore HP and MP";
$restoreValue[Elixir, HP] = 1000;
$restoreValue[Elixir, MP] = 500;
$AccessoryVar[Elixir, "AlchemyIngredients"] = "EtherealStasisFlask 1 VialOfWater 1 Sylphroot 10 ChocoboFeather 2";

// maybe make mega elixir later?

BeltItem::Add("Ether", "Ether", "PotionItems", 0.5, 100, "", 506);
$AccessoryVar[Ether, $MiscInfo] = "A potion that restores 25 MP";
$restoreValue[Ether, MP] = 25;
$AccessoryVar[Ether, "AlchemyIngredients"] = "CrackedFlask 1 VialOfWater 1 HealingHerb 5 MandragoraRoot 2";

BeltItem::Add("Turbo Ether","TurboEther","PotionItems", 1, 1000, "", 507);
$AccessoryVar[TurboEther, $MiscInfo] = "An potion that restores 100 MP";
$restoreValue[TurboEther, MP] = 100;
$AccessoryVar[TurboEther, "AlchemyIngredients"] = "WornGlassVial 1 VialOfWater 1 MandragoraRoot 5 TonberryOil 2";

BeltItem::Add("X-Ether","XEther","PotionItems", 1, 1000, "");
$AccessoryVar[XEther, $MiscInfo] = "An potion that restores 250 MP";
$restoreValue[XEther, MP] = 250;
$AccessoryVar[XEther, "AlchemyIngredients"] = "ReinforcedAlchemistsBottle 1 VialOfWater 1 HealingHerb 5 BehemothHornFragment 2";

BeltItem::Add("Mega Ether","MegaEther","PotionItems", 1, 1000, "");
$AccessoryVar[MegaEther, $MiscInfo] = "An potion that restores 500 MP";
$restoreValue[MegaEther, MP] = 500;
$AccessoryVar[MegaEther, "AlchemyIngredients"] = "ArcaneCrystalPhial 1 VialOfWater 1 HealingHerb 5 MalboroSporeSac 2";

BeltItem::Add("Healing Kit I", "HealingKitI", "MiscItems", 0.1, 10, "", 508);
$AccessoryVar[HealingKitI, $MiscInfo] = "A medical kit that that let's you mend wounds. (10 HP)";
$restoreValue[HealingKitI, HP] = 10;
BeltItem::Add("Healing Kit II", "HealingKitII", "MiscItems", 0.1, 50, "", 509);
$AccessoryVar[HealingKitII, $MiscInfo] = "A medical kit that that let's you mend wounds. (50 HP)";
$restoreValue[HealingKitII, HP] = 50;
BeltItem::Add("Healing Kit III", "HealingKitIII", "MiscItems", 0.1, 100, "", 510);
$AccessoryVar[HealingKitIII, $MiscInfo] = "A medical kit that that let's you mend wounds. (100 HP)";
$restoreValue[HealingKitIII, HP] = 100;
BeltItem::Add("Healing Kit IV", "HealingKitIV", "MiscItems", 0.1, 150, "", 511);
$AccessoryVar[HealingKitIV, $MiscInfo] = "A medical kit that that let's you mend wounds. (150 HP)";
$restoreValue[HealingKitIV, HP] = 150;
BeltItem::Add("Healing Kit V", "HealingKitV", "MiscItems", 0.1, 200, "", 512);
$AccessoryVar[HealingKitV, $MiscInfo] = "A medical kit that that let's you mend wounds. (200 HP)";
$restoreValue[HealingKitV, HP] = 200;
BeltItem::Add("Healing Kit VI", "HealingKitVI", "MiscItems", 0.1, 200, "", 513);
$AccessoryVar[HealingKitVI, $MiscInfo] = "A medical kit that that let's you mend wounds. (250 HP)";
$restoreValue[HealingKitVI, HP] = 250;
BeltItem::Add("Healing Kit VII", "HealingKitVII", "MiscItems", 0.1, 200, "", 514);
$AccessoryVar[HealingKitVII, $MiscInfo] = "A medical kit that that let's you mend wounds. (300 HP)";
$restoreValue[HealingKitVII, HP] = 300;
BeltItem::Add("Healing Kit VIII", "HealingKitVIII", "MiscItems", 0.1, 200, "", 515);
$AccessoryVar[HealingKitVIII, $MiscInfo] = "A medical kit that that let's you mend wounds. (350 HP)";
$restoreValue[HealingKitVIII, HP] = 350;
BeltItem::Add("Healing Kit IX", "HealingKitIX", "MiscItems", 0.1, 200, "", 516);
$AccessoryVar[HealingKitIX, $MiscInfo] = "A medical kit that that let's you mend wounds. (400 HP)";
$restoreValue[HealingKitIX, HP] = 400;
BeltItem::Add("Healing Kit X", "HealingKitX", "MiscItems", 0.1, 200, "", 517);
$AccessoryVar[HealingKitX, $MiscInfo] = "A medical kit that that let's you mend wounds. (500 HP)";
$restoreValue[HealingKitX, HP] = 500;

BeltItem::Add("Potion of XP", "PotionOfXP", "PotionItems", 0.5, 5000, "");
$AccessoryVar[PotionOfXP, $MiscInfo] = "A golden potion that swirls with vivid colors. Grants a large amount of experience when consumed.";
$restoreValue[PotionOfXP, EXP] = 1000;

// poisons / elemental flasks
BeltItem::Add("Fire Flask","FireFlask", "PotionItems", 0.1, 100, "SmallPotion", 550);
$AccessoryVar[FireFlask, $MiscInfo] = "A flask that radiates with fire energy. It can be thrown to create a small fire explosion.";
$AccessoryVar[FireFlask, "AlchemyIngredients"] = "CrackedFlask 1 VialOfWater 1 BombCore 1";
$beltitem[FireFlask, "isThrowable"] = True;
$beltitem[FireFlask, "isDetonatable"] = True;
$beltitem[FireFlask, "spellIndex"] = 71;
$beltitem[FireFlask, "explosion"] = "Bomb9";

BeltItem::Add("Ice Flask","IceFlask", "PotionItems", 0.1, 200, "SmallPotion", 551);
$AccessoryVar[IceFlask, $MiscInfo] = "A flask that radiates with ice energy. It can be thrown to create a small ice explosion.";
$AccessoryVar[IceFlask, "AlchemyIngredients"] = "WornGlassVial 1 VialOfWater 1 MaidensTear 1";
$beltitem[IceFlask, "isThrowable"] = True;
$beltitem[IceFlask, "isDetonatable"] = True;
$beltitem[IceFlask, "spellIndex"] = 72;
$beltitem[IceFlask, "explosion"] = "Bomb2";

BeltItem::Add("Lightning Flask","LightningFlask", "PotionItems", 0.1, 300, "SmallPotion", 552);
$AccessoryVar[LightningFlask, $MiscInfo] = "A flask that radiates with lightning energy. It can be thrown to create a small lightning explosion.";
$AccessoryVar[LightningFlask, "AlchemyIngredients"] = "WornGlassVial 1 VialOfWater 1 TonberryOil 1";
$beltitem[LightningFlask, "isThrowable"] = True;
$beltitem[LightningFlask, "isDetonatable"] = True;
$beltitem[LightningFlask, "spellIndex"] = 73;
$beltitem[LightningFlask, "explosion"] = "Bomb10";

BeltItem::Add("Earth Flask","EarthFlask", "PotionItems", 0.1, 400, "SmallPotion", 553);
$AccessoryVar[EarthFlask, $MiscInfo] = "A flask that radiates with earth energy. It can be thrown to create a small earth explosion.";
$AccessoryVar[EarthFlask, "AlchemyIngredients"] = "ReinforcedAlchemistsBottle 1 VialOfWater 1 BehemothHornFragment 1";
$beltitem[EarthFlask, "isThrowable"] = True;
$beltitem[EarthFlask, "isDetonatable"] = True;
$beltitem[EarthFlask, "spellIndex"] = 74;
$beltitem[EarthFlask, "explosion"] = "Bomb1";

BeltItem::Add("Acid Flask","AcidFlask", "PotionItems", 0.1, 500, "SmallPotion", 554);
$AccessoryVar[AcidFlask, $MiscInfo] = "A flask that radiates with acid energy. It can be thrown to create a small acid explosion.";
$AccessoryVar[AcidFlask, "AlchemyIngredients"] = "ArcaneCrystalPhial 1 VialOfWater 1 MalboroSporeSac 1";
$beltitem[AcidFlask, "isThrowable"] = True;
$beltitem[AcidFlask, "isDetonatable"] = True;
$beltitem[AcidFlask, "spellIndex"] = 75;
$beltitem[AcidFlask, "explosion"] = "Bomb6";

BeltItem::Add("Holy Flask","HolyFlask", "PotionItems", 0.1, 1000, "SmallPotion", 554);
$AccessoryVar[HolyFlask, $MiscInfo] = "A flask that radiates with holy energy. It can be thrown to create a small holy explosion.";
$AccessoryVar[HolyFlask, "AlchemyIngredients"] = "EtherealStasisFlask 1 VialOfWater 1 MalboroSporeSac 1";
$beltitem[HolyFlask, "isThrowable"] = True;
$beltitem[HolyFlask, "isDetonatable"] = True;
$beltitem[HolyFlask, "spellIndex"] = 42;
$beltitem[HolyFlask, "explosion"] = "Bomb5";

BeltItem::Add("Unholy Flask","UnholyFlask", "PotionItems", 0.1, 1000, "SmallPotion", 554);
$AccessoryVar[UnholyFlask, $MiscInfo] = "A flask that radiates with unholy energy. It can be thrown to create a small unholy explosion.";
$AccessoryVar[UnholyFlask, "AlchemyIngredients"] = "EtherealStasisFlask 1 VialOfWater 1 MalboroSporeSac 1";
$beltitem[UnholyFlask, "isThrowable"] = True;
$beltitem[UnholyFlask, "isDetonatable"] = True;
$beltitem[UnholyFlask, "spellIndex"] = 42;
$beltitem[UnholyFlask, "explosion"] = "Bomb14";

// Alchemy Items (no shoping except for maybe Potion Bottles?)
BeltItem::Add("Cracked Flask", "CrackedFlask", "MiscItems", 0.01, 1, "", 606);
$AccessoryVar[CrackedFlask, $MiscInfo] = "A crude, handmade clay bottle with visible cracks. Prone to leaking and breaking easily. Used by commoners for basic tonics and weak potions.";
BeltItem::Add("Worn Glass Vial", "WornGlassVial", "MiscItems", 0.01, 10, "", 607);
$AccessoryVar[WornGlassVial, $MiscInfo] = "A reused glass container with scratches and imperfections. It is still usable, but the glass is thin and fragile. Used by novice alchemists and street apothecaries.";
BeltItem::Add("Reinforced Alchemist's Bottle", "ReinforcedAlchemistsBottle", "MiscItems", 0.01, 100, "", 608);
$AccessoryVar[ReinforcedAlchemistsBottle, $MiscInfo] = "A sturdy glass bottle with a reinforced metal frame. It is designed to withstand high pressure and heat, making it ideal for brewing volatile potions and elixirs.";
BeltItem::Add("Arcane Crystal Phial", "ArcaneCrystalPhial", "MiscItems", 0.01, 1000, "", 609);
$AccessoryVar[ArcaneCrystalPhial, $MiscInfo] = "A rare and expensive crystal vial that is said to enhance the magical properties of any liquid stored within it. It is used by master alchemists and potion makers.";
BeltItem::Add("Ethereal Stasis Flask", "EtherealStasisFlask", "MiscItems", 0.01, 10000, "", 610);
$AccessoryVar[EtherealStasisFlask, $MiscInfo] = "A mysterious flask made of an otherworldly material that seems to defy the laws of physics. It is said to preserve the contents within it indefinitely, keeping them fresh and potent.";

BeltItem::Add("Crude Clay Alembic", "CrudeClayAlembic", "MiscItems", 0.01, 500, "", 611);
$AccessoryVar[CrudeClayAlembic, $MiscInfo] = "A basic distillation vessel made from brittle, unglazed clay. Inefficient, with high heat loss and impure extractions. Commonly used by novice potion-makers in back-alley workshops.";
BeltItem::Add("Worn Copper Alembic", "WornCopperAlembic", "MiscItems", 0.01, 5000, "", 612);
$AccessoryVar[WornCopperAlembic, $MiscInfo] = "A simple copper distiller with dents and discoloration. Provides decent extraction but leaves impurities in the mixture. Used by traveling merchants and budget alchemists.";
BeltItem::Add("Reinforced Iron Alembic", "ReinforcedIronAlembic", "MiscItems", 0.01, 50000, "", 613);
$AccessoryVar[ReinforcedIronAlembic, $MiscInfo] = "A sturdy iron apparatus with pressure control valves. Produces reliable, pure extractions, making it a staple for guild alchemists. Can handle stronger reagents without corrosion.";
BeltItem::Add("Arcane Glass Alembic", "ArcaneGlassAlembic", "MiscItems", 0.01, 500000, "", 614);
$AccessoryVar[ArcaneGlassAlembic, $MiscInfo] = "Crafted from mage-blown glass, reinforced with runic etchings. Allows precise temperature control for rare elemental extractions. Used by royal alchemists and high-tier potion makers.";
BeltItem::Add("Celestial Mythril Alembic", "CelestialMythrilAlembic", "MiscItems", 0.01, 5000000, "", 615);
$AccessoryVar[CelestialMythrilAlembic, $MiscInfo] = "A legendary alembic made from enchanted mythril, absorbing mana flow. Can distill even volatile aetheric essences without loss of potency. Used for philosopher's stones, divine elixirs, and god-tier alchemy.";

// Igredients
BeltItem::Add("Vial of Water", "VialOfWater", "MiscItems", 0.01, 1, "", 616);
$AccessoryVar[VialOfWater, $MiscInfo] = "A vial of clean, fresh water. It is used as a base for many potions and alchemical concoctions.";
$restoreValue[VialOfWater, MP] = 1;

BeltItem::Add("Healing Herb", "HealingHerb", "MiscItems", 0.01, 10, "", 617);
$AccessoryVar[HealingHerb, $MiscInfo] = "A medicinal herb known for its healing properties. It is used in many healing potions and remedies.";
$restoreValue[HealingHerb, MP] = 2;
BeltItem::Add("Mandragora Root", "MandragoraRoot", "MiscItems", 0.01, 100, "", 618);
$AccessoryVar[MandragoraRoot, $MiscInfo] = "A screaming plant known for its hallucinogenic and harmful properties.";
BeltItem::Add("Sylphroot", "Sylphroot", "MiscItems", 0.01, 1, "", 619);
$AccessoryVar[Sylphroot, $MiscInfo] = "A pale-green root infused with wind magic, often found in enchanted forests.";
BeltItem::Add("Maidens Tear", "MaidensTear", "MiscItems", 0.01, 1000, "", 620);
$AccessoryVar[MaidensTear, $MiscInfo] = "A delicate, crystal-clear flower that grows near pure mountain springs.";
BeltItem::Add("Chocobo Feather", "ChocoboFeather", "MiscItems", 0.01, 10000, "", 621);
$AccessoryVar[ChocoboFeather, $MiscInfo] = "A feathery yellow-green plant that resembles a chocobo's plume.";

BeltItem::Add("Bomb Core", "BombCore", "MiscItems", 0.01, 100, "", 622);
$AccessoryVar[BombCore, $MiscInfo] = "A core component used in bomb crafting. It contains volatile materials and is highly sought after by engineers.";
BeltItem::Add("Malboro Spore Sac", "MalboroSporeSac", "MiscItems", 0.01, 100, "", 623);
$AccessoryVar[MalboroSporeSac, $MiscInfo] = "A spore sac from the Malboro plant. It is known for its toxic properties and is often used in bomb crafting.";
BeltItem::Add("Cockatrice Gizzard Stone", "CockatriceGizzardStone", "MiscItems", 0.01, 100, "", 624);
$AccessoryVar[CockatriceGizzardStone, $MiscInfo] = "A gizzard stone from the Cockatrice. It is known for its hardiness and is often used in bomb crafting.";
BeltItem::Add("Behemoth Horn Fragment", "BehemothHornFragment", "MiscItems", 0.01, 100, "", 625);
$AccessoryVar[BehemothHornFragment, $MiscInfo] = "A fragment of a horn from the Behemoth. It is known for its toughness and is often used in bomb crafting.";
BeltItem::Add("Chimera Flame Gland", "ChimeraFlameGland", "MiscItems", 0.01, 100, "", 626);
$AccessoryVar[ChimeraFlameGland, $MiscInfo] = "A gland from the Chimera that produces a fiery substance. It is often used in bomb crafting.";
BeltItem::Add("Tonberry Oil", "TonberryOil", "MiscItems", 0.01, 100, "", 627);
$AccessoryVar[TonberryOil, $MiscInfo] = "An oil extracted from the Tonberry. It is known for its stealth-enhancing properties.";
BeltItem::Add("Flan Residue", "FlanResidue", "MiscItems", 0.01, 100, "", 628);
$AccessoryVar[FlanResidue, $MiscInfo] = "A viscous residue left behind by Flans. It is often used in bomb crafting.";
BeltItem::Add("Skeleton Bone Powder", "SkeletonBonePowder", "MiscItems", 0.01, 100, "", 629);
$AccessoryVar[SkeletonBonePowder, $MiscInfo] = "A fine powder made from ground skeleton bones. It is often used in bomb crafting.";
BeltItem::Add("Ahriman Eye Lens", "AhrimanEyeLens", "MiscItems", 0.01, 100, "", 630);
$AccessoryVar[AhrimanEyeLens, $MiscInfo] = "A lens made from the eye of an Ahriman. It is known for its ability to enhance magical properties.";
BeltItem::Add("Spider Fang", "SpiderFang", "MiscItems", 0.01, 100, "", 631);
$AccessoryVar[SpiderFang, $MiscInfo] = "A sharp fang from a spider. It is often used in alchemy and crafting.";
BeltItem::Add("Spider Venom", "SpiderVenom", "MiscItems", 0.01, 100, "", 632);
$AccessoryVar[SpiderVenom, $MiscInfo] = "A potent venom extracted from a spider. It is often used in alchemy and crafting.";
BeltItem::Add("Mako Vial", "MakoVial", "MiscItems", 0.01, 100, "", 633);
$AccessoryVar[MakoVial, $MiscInfo] = "A vial containing concentrated Mako energy. Often carried by Shinra guards for research purposes.";
BeltItem::Add("Zombie Viscera", "ZombieViscera", "MiscItems", 0.01, 100, "", 634);
$AccessoryVar[ZombieViscera, $MiscInfo] = "Preserved viscera from a zombie. Unpleasant but valuable for research into undead biology.";


// hearth stones
BeltItem::Add("Gooba Hearthstone", "GoobaHearthstone", "MiscItems", 0.01, 1000, "Ruby", 700);
$AccessoryVar[GoobaHearthstone, $MiscInfo] = "A magical hearthstone that teleports the user back to Upper Gooba.";
$beltitem[GoobaHearthstone, "targetPosition"] = "259.767 -469.158 -2963.51";
$beltitem[GoobaHearthstone, "targetRotationZ"] = "2.84465";
$beltitem[GoobaHearthstone, "useSound"] = "AbsorbABS";
BeltItem::Add("Kalm Hearthstone", "KalmHearthstone", "MiscItems", 0.01, 500, "Ruby", 701);
$AccessoryVar[KalmHearthstone, $MiscInfo] = "A magical hearthstone that teleports the user back to Kalm.";
$beltitem[KalmHearthstone, "targetPosition"] = "2004.24 496.11 2405.5";
$beltitem[KalmHearthstone, "targetRotationZ"] = "0.715683";
$beltitem[KalmHearthstone, "useSound"] = "AbsorbABS";
BeltItem::Add("7th Heaven Hearthstone", "HeavenHearthstone", "MiscItems", 0.01, 5000, "Ruby", 702);
$AccessoryVar[HeavenHearthstone, $MiscInfo] = "A magical hearthstone that teleports the user back to 7th Heaven.";
$beltitem[HeavenHearthstone, "targetPosition"] = "1402.24 -462.11 -808.04";
$beltitem[HeavenHearthstone, "targetRotationZ"] = "-0.158";
$beltitem[HeavenHearthstone, "useSound"] = "AbsorbABS";
BeltItem::Add("Wall Market Hearthstone", "WallMarketHearthstone", "MiscItems", 0.01, 10000, "Ruby", 703);
$AccessoryVar[WallMarketHearthstone, $MiscInfo] = "A magical hearthstone that teleports the user back to Wall Market.";
$beltitem[WallMarketHearthstone, "targetPosition"] = "-2470.01 -2285.44 7554.59";
$beltitem[WallMarketHearthstone, "targetRotationZ"] = "-2.44212";
$beltitem[WallMarketHearthstone, "useSound"] = "AbsorbABS";

// Quest Items
BeltItem::Add("Black Statue", "BlackStatue", "QuestItems", $AccessoryVar[BlackStatue, $Weight], GenerateItemCost(BlackStatue));
BeltItem::Add("Skeleton Bone", "SkeletonBone", "QuestItems", $AccessoryVar[SkeletonBone, $Weight], GenerateItemCost(SkeletonBone));
BeltItem::Add("Enchanted Stone", "EnchantedStone", "QuestItems", $AccessoryVar[EnchantedStone, $Weight], GenerateItemCost(EnchantedStone));
BeltItem::Add("Dragon Scale", "DragonScale", "QuestItems", $AccessoryVar[DragonScale, $Weight], GenerateItemCost(DragonScale));
BeltItem::Add("Parchment", "Parchment", "QuestItems", $AccessoryVar[Parchment, $Weight], GenerateItemCost(Parchment));
BeltItem::Add("Magic Dust", "MagicDust", "QuestItems", $AccessoryVar[MagicDust, $Weight], GenerateItemCost(MagicDust));

// Enemy Weapons
$description = "A casting blade.";
BeltItem::AddWeapon("Casting Blade", "CastingBlade", "CastingBlade", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 1", "20");
$description = "A chipped dagger that looks dirty and worn.";
BeltItem::AddWeapon("Chipped Dagger", "ChippedDagger", "Dagger", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 1", "10");
$description = "This warped club is filled with cracks and warped in strange ways. It looks like it could fall apart at any moment.";
BeltItem::AddWeapon("Warped Club", "WarpedClub", "Club", $BludgeonAccessoryType, $description, $SkillHammers, $SkillHammers @ " 1", "10");

$description = "A staff that looks like it has seen better days.";
BeltItem::AddWeapon("Broken Staff", "BrokenStaff", "QuarterStaff", $BludgeonAccessoryType, $description, $SkillSpears, $SkillSpears @ " 1", "10");
$description = "An old dagger that is covered in rust.";
BeltItem::AddWeapon("Rusty Shank", "RustyShank", "Dagger", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 1", "20");
$description = "A club filled with broken bone bits. It looks like it could fall apart at any moment.";
BeltItem::AddWeapon("Shattered Bone Club", "ShatteredBoneClub", "SpikedClub", $BludgeonAccessoryType, $description, $SkillHammers, $SkillHammers @ " 1", "20");

// Enemy Weapons (beast claw I - X)
$description = "Beast Claw I";
BeltItem::AddWeapon("Beast Claw I", "BeastClawI", "Unarmed", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 1", "10");
$description = "Beast Claw II";
BeltItem::AddWeapon("Beast Claw II", "BeastClawII", "Unarmed", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 100", "100");
$description = "Beast Claw III";
BeltItem::AddWeapon("Beast Claw III", "BeastClawIII", "Unarmed", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 200", "200");
$description = "Beast Claw IV";
BeltItem::AddWeapon("Beast Claw IV", "BeastClawIV", "Unarmed", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 300", "300");
$description = "Beast Claw V";
BeltItem::AddWeapon("Beast Claw V", "BeastClawV", "Unarmed", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 400", "400");
$description = "Beast Claw VI";
BeltItem::AddWeapon("Beast Claw VI", "BeastClawVI", "Unarmed", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 500", "500");
$description = "Beast Claw VII";
BeltItem::AddWeapon("Beast Claw VII", "BeastClawVII", "Unarmed", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 600", "600");
$description = "Beast Claw VIII";
BeltItem::AddWeapon("Beast Claw VIII", "BeastClawVIII", "Unarmed", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 700", "700");
$description = "Beast Claw IX";
BeltItem::AddWeapon("Beast Claw IX", "BeastClawIX", "Unarmed", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 800", "800");
$description = "Beast Claw X";
BeltItem::AddWeapon("Beast Claw X", "BeastClawX", "Unarmed", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 900", "900");


// Harvesting Items
$description = "An axe used for chopping wood.";
// TODO: Change to woodcutting / lumberjack skill
BeltItem::AddWeapon("Wood Axe", "WoodAxe", "WoodAxe", $AxeAccessoryType, $description, $SkillAxes, $SkillAxes @ " 1", "35", 51); // shop item 47

// Seed / Food Items
// function BeltItem::AddSeed(%name, %item, %type, %weight, %cost, %image, %shopIndex, %miscInfo, %fruit, %fruitType)
BeltItem::Add("Kalm Pale Ale", "KalmPaleAle", "MiscItems", 0.5, 50, "", 801);
$AccessoryVar[KalmPaleAle, $MiscInfo] = "A refreshing Pale Ale that was brewed in Kalm.";
$restoreValue[KalmPaleAle, MP] = 5;

BeltItem::Add("Apple", "Apple", "MiscItems", 0.01, 10, "Ruby", 850);
$AccessoryVar[Apple, $MiscInfo] = "A delicious red apple. It can be eaten to restore health.";
$restoreValue[Apple, HP] = 5;
$description = "A small seed that will grow into an Apple Tree if planted in the right conditions.";
BeltItem::AddSeed("Apple Seed", "AppleSeed", "MiscItems", 0.01, 50, "Granite", 851, $description, "Apple", "TreeFruit");

BeltItem::Add("Avocado", "Avocado", "MiscItems", 0.01, 20, "Jade", 852);
$AccessoryVar[Avocado, $MiscInfo] = "A perfectly ripe avocado. It can be eaten to restore health.";
$restoreValue[Avocado, HP] = 10;
$description = "A large seed that will grow into an Avocado Tree if planted in the right conditions.";
BeltItem::AddSeed("Avocado Seed", "AvocadoSeed", "MiscItems", 0.01, 100, "Granite", 853, $description, "Avocado", "TreeFruit");

BeltItem::Add("Pomegranate", "Pomegranate", "MiscItems", 0.01, 15, "Jade", 854);
$AccessoryVar[Pomegranate, $MiscInfo] = "A juicy pomegranate. It can be eaten to restore mana.";
$restoreValue[Pomegranate, MP] = 5;
$description = "A large seed that will grow into a Pomegranate Tree if planted in the right conditions.";
BeltItem::AddSeed("Pomegranate Seed", "PomegranateSeed", "MiscItems", 0.01, 100, "Granite", 855, $description, "Pomegranate", "TreeFruit");

BeltItem::Add("7th Heaven IPA", "HeavenIPA", "MiscItems", 0.5, 500, "", 856);
$AccessoryVar[HeavenIPA, $MiscInfo] = "A strong IPA that was brewed and served at Tifa's bar 7th Heaven.";
$restoreValue[HeavenIPA, MP] = 25;

BeltItem::Add("Tifa's Old Fashion", "TifasOldFashioned", "MiscItems", 0.5, 1000, "", 857);
$AccessoryVar[TifasOldFashioned, $MiscInfo] = "A classic cocktail made by Tifa at 7th Heaven.";
$restoreValue[TifasOldFashioned, MP] = 50;

BeltItem::Add("Wheat Seed", "WheatSeed", "MiscItems", 0.01, 10, "Bullet");
$AccessoryVar[WheatSeed, $MiscInfo] = "A small wheat seed. It can be used to grow wheat.";
$beltitem[WheatSeed, "isThrowable"] = True;
$beltitem[WheatSeed, "isPlantable"] = True;
$beltitem[WheatSeed, "BushFruit"] = "Wheat";
BeltItem::Add("Wheat", "Wheat", "MiscItems", 0.01, 10, "Tracer");
$AccessoryVar[Wheat, $MiscInfo] = "Wheat is a common grain used in many recipes. It can be used to make bread and other baked goods.";
// $beltitem[Grain, "isThrowable"] = True;

// Special Player Items