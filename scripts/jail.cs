//This file is part of Tribes RPG.
//Tribes RPG server side scripts

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


function GetRandomJailNumber()
{
	dbecho($dbechoMode, "GetRandomJailNumber()");

	%group = nameToID("MissionGroup\\Jail");

	if(%group != -1)
	{
		%cnt = Group::objectCount(%group);
		%n = floor(getRandom() * %cnt) + 1;

		return %n;
	}
	return -1;
}

function GetPositionForJailNumber(%jn)
{
	dbecho($dbechoMode, "GetPositionForJailNumber(" @ %jn @ ")");

	%group = nameToID("MissionGroup\\Jail");

	if(%group != -1)
	{
		%set = nameToId("MissionGroup\\Jail\\" @ %jn);
		if(%set != -1)
			return GameBase::getPosition(%set);
	}
	return -1;
}

function Jail(%clientId, %time, %jn)
{
	dbecho($dbechoMode, "Jail(" @ %clientId @ ", " @ %time @ ", " @ %jn @ ")");

	%pos = GetPositionForJailNumber(%jn);

	UpdateBonusState(%clientId, "Jail 1", floor(%time / 2));

	Item::setVelocity(%clientId, "0 0 0");
	GameBase::setPosition(%clientId, %pos);
	schedule("FellOffMap(" @ %clientId @ ");", %time, %clientId);

	Client::sendMessage(%clientId, $MsgRed, "You have been jailed for " @ %time @ " seconds.");
}

function IsJailed(%clientId)
{
	dbecho($dbechoMode, "IsJailed(" @ %clientId @ ")");

	%b = AddBonusStatePoints(%clientId, "Jail");

	if(%b >= 1)
		return True;
	else
		return False;
}