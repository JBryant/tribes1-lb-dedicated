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



function setMANA(%clientId, %val)
{
	dbecho($dbechoMode, "setMANA(" @ %clientId @ ", " @ %val @ ")");

	%armor = Player::getArmor(%clientId);

	if(%val == "")
		%val = fetchData(%clientId, "MaxMANA");

	%a = %val * %armor.maxEnergy;
	%b = %a / fetchData(%clientId, "MaxMANA");

	if(%b < 0)
		%b = 0;
	else if(%b > %armor.maxEnergy)
		%b = %armor.maxEnergy;

	GameBase::setEnergy(Client::getOwnedObject(%clientId), %b);
}
function refreshMANA(%clientId, %value)
{
	dbecho($dbechoMode, "refreshMANA(" @ %clientId @ ", " @ %value @ ")");

	setMANA(%clientId, (fetchData(%clientId, "MANA") - %value));
}


// mana at magicka 30: 21
// mana at magicka 100: 42
// mana at magicka 500: 175
// mana at magicka 1000: 341
// mana at magicka 5000: 1675
// mana at magicka 10000: 3341
// 30: 21, 100: 42, 500: 175, 1000: 341, 5000: 1675, 10000: 3341
// change mana regen

$magickaSkillRegenModifier = 0.01;

function refreshMANAREGEN(%clientId)
{
	dbecho($dbechoMode, "refreshMANAREGEN(" @ %clientId @ ")");

	%magickaPerSecond = ($PlayerSkill[%clientId, $SkillMagicka] * $magickaSkillRegenModifier);

	if(%clientId.sleepMode == 1)
		%b = 1.0;
	else if(%clientId.sleepMode == 2)
		%b = 2.25;
	else
		%b = 0;

	// get mana regen (now regen per second)
	%manaPerSecond = AddPoints(%clientId, 11);
	%playerMaxMana = fetchData(%clientId, "MaxMANA");

	// recharge rate are is in percent of max energy per second
	// use players max mana to calculate the recharge rate to match the mana per second
	%c = ((%magickaPerSecond + %manaPerSecond) / %playerMaxMana) * 100;

	%r = %b + %c;

	GameBase::setRechargeRate(Client::getOwnedObject(%clientId), %r);
}

function getManaRegenPerSecond(%clientId) {
	dbecho($dbechoMode, "getManaRegenPerSecond(" @ %clientId @ ")");

	%magickaPerSecond = ($PlayerSkill[%clientId, $SkillMagicka] * $magickaSkillRegenModifier);
	%manaPerSecond = AddPoints(%clientId, 11);

	return round(%magickaPerSecond + %manaPerSecond);
}
// old function
// function refreshMANAREGEN(%clientId)
// {
// 	dbecho($dbechoMode, "refreshMANAREGEN(" @ %clientId @ ")");

// 	%a = ($PlayerSkill[%clientId, $SkillMagicka] / 3250);

// 	if(%clientId.sleepMode == 1)
// 		%b = 1.0 + %a;
// 	else if(%clientId.sleepMode == 2)
// 		%b = 2.25 + %a;
// 	else
// 		%b = %a;

// 	%c = AddPoints(%clientId, 11) / 800;

// 	%r = %b + %c;

// 	GameBase::setRechargeRate(Client::getOwnedObject(%clientId), %r);
// }
