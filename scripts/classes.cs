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

//Anything that does NOT have to do with visuals when it comes to classes should ALWAYS use the 0 offset in $ClassName.

$initcoins[Priest] = "3d6x10";
$initcoins[Rogue] = "2d6x10";
$initcoins[Warrior] = "5d4x10";
$initcoins[Wizard] = "1d4+1x10";

$MinHP[MaleHuman] = 12;
$MinHP[FemaleHuman] = 12;
$MinHP[Traveller] = 12;
$MinHP[Goblin] = 0;
$MinHP[Orc] = 7;
$MinHP[Ogre] = 10;
$MinHP[Gnoll] = 3;
$MinHP[Undead] = 11;
$MinHP[Elf] = 10;
$MinHP[Minotaur] = 15;
$MinHP[Uber] = 25;
$MinHP[Cultist] = 35;
$MinHP[DeathKnight] = 5000;
$MinHP[DeathKnight] = 12;

// (RL 0)
$ClassName[1] = "Squire";
$ClassRequirements[1] = "";

$ClassName[2] = "Chemist";
$ClassRequirements[2] = "";

// (RL 2)
$ClassName[3] = "Knight";
$ClassRequirements[3] = "Squire 2";

$ClassName[4] = "Archer";
$ClassRequirements[4] = "Squire 2";

$ClassName[5] = "WhiteMage";
$ClassRequirements[5] = "Chemist 2";

$ClassName[6] = "BlackMage";
$ClassRequirements[6] = "Chemist 2";

// (RL 5)
$ClassName[7] = "Monk";
$ClassRequirements[7] = "Knight 3";

$ClassName[8] = "Hunter";
$ClassRequirements[8] = "Archer 3";

$ClassName[9] = "Mystic";
$ClassRequirements[9] = "WhiteMage 3";

$ClassName[10] = "TimeMage";
$ClassRequirements[10] = "BlackMage 3";

// (RL 10)
$ClassName[11] = "Geomancer";
$ClassRequirements[11] = "Monk 5";

$ClassName[12] = "Sniper";
$ClassRequirements[12] = "Hunter 5";

$ClassName[13] = "Orator";
$ClassRequirements[13] = "Mystic 5";

$ClassName[14] = "Summoner";
$ClassRequirements[14] = "TimeMage 5";

// (RL 25)
$ClassName[15] = "Samurai";
$ClassRequirements[15] = "Geomancer 5 Orator 1";

$ClassName[16] = "SpellBow";
$ClassRequirements[16] = "Sniper 5 Summoner 1";

$ClassName[17] = "Dancer";
$ClassRequirements[17] = "Orator 5 Sniper 1";

$ClassName[18] = "SpellBlade";
$ClassRequirements[18] = "Summoner 5 Geomancer 1";

// (RL 50+ end game)
$ClassName[19] = "HolyKnight";
$ClassRequirements[19] = "Samurai 10 Orator 10";

$ClassName[20] = "DarkKnight";
$ClassRequirements[20] = "Samurai 10 Summoner 10";

$ClassName[21] = "Valkyrie"; 
$ClassRequirements[21] = "SpellBow 10 Orator 10";

$ClassName[22] = "ArcaneArcher";
$ClassRequirements[22] = "SpellBow 10 Summoner 10";

$ClassName[23] = "Seraphim";
$ClassRequirements[23] = "Dancer 10 Sniper 10";

$ClassName[24] = "Ancient";
$ClassRequirements[24] = "Dancer 10 Geomancer 10";

$ClassName[25] = "Arcanist";
$ClassRequirements[25] = "SpellBlade 10 Sniper 10";

$ClassName[26] = "Hexblade";
$ClassRequirements[26] = "SpellBlade 10 Geomancer 10";

// ======== one off classes

$ClassName[27] = "HighSummoner";
$ClassRequirements[27] = "Dancer 10 Orator 10 SpellBlade 10 Summoner 10"; // Arith (25)  , 5 kn, 3 mk, 3 su, 8 ari - 25 + 19 = RL 44 min

// ========================

// epic tier classes
$ClassName[28] = "OnionKnight";
$ClassRequirements[28] = "Squire 100";

$ClassName[29] = "Kefka";
$ClassRequirements[29] = "Chemist 100";

// god tier class
$ClassName[30] = "Soldier";
$ClassRequirements[30] = "HolyKnight 1 DarkKnight 1 Valkyrie 1 ArcaneArcher 1 Seraphim 1 Ancient 1 Arcanist 1 Hexblade 1";

// // cloud tier class
$ClassName[31] = "ExSoldier";
$ClassRequirements[31] = "Soldier 1 OnionKnight 1 Kefka 1";

// $ClassName[32] = "Enemy";
$ClassRequirements[32] = "ExSoldier";


function getFinalCLASS(%clientId) {
	dbecho($dbechoMode, "getFinalCLASS(" @ %clientId @ ")");

	return fetchData(%clientId, "CLASS");

	// just return current class
	for(%i = 1; $ClassName[%i] != ""; %i++) {
		if(String::ICompare($ClassName[%i], fetchData(%clientId, "CLASS")) == 0)
			return $ClassName[%i]; // fetchData(%clientId, "RemortStep")];
	}
	
	return -1;
}

function IsAClass(%class) {
	dbecho($dbechoMode, "IsAClass(" @ %class @ ")");

	for(%i = 1; $ClassName[%i] != ""; %i++) {
		if(String::ICompare(%class, $ClassName[%i]) == 0)
			return True;
	}

	return False;
}