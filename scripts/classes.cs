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


//There are FOUR hard-coded groups:
//-Priest
//-Rogue
//-Warrior
//-Wizard

//Each of these has classes.  They are specified in here.
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

// can we make FF tactics like levelling system?
// meaning everytime you remort, yopu get to pick a new class?
// certain special classes require a minimum of other class levels
// Class Requirements:

// (RL 0)
// Squire: ""
// Chemist: ""
// (RL 2)
// Knight:    "Squire 2"
// Archer:    "Squire 2"
// WhiteMage: "Chemist 2"
// BlackMage: "Chemist 2"
// (RL 5)
// Monk:      "Knight 3"
// Thief:     "Archer 3"
// Mystic:    "WhiteMage 3"
// TimeMage:  "BlackMage 3"
// (RL 10)
// Geomancer: "Monk 5"
// Dragoon:   "Thief 5"
// Orator:    "Mystic 5"
// Summoner:  "TimeMage 5"
// (RL 25)
// Samurai:   "Geomancer 5 Orator 1"
// Ninja:     "Dragoon 5 Summoner 1"
// Dancer:    "Orator 5 Dragoon 1"
// Arithmetician:  "Summoner 5 Geomancer 1"
// (end game)
// DarkKnight: "BlackMage 8 TimeMage 8 Geomancer 8 Dragoon 8 Ninja 8"
// HolyKnight: "WhiteMage 8 Mystic 8 Geomancer 8 Dragoon 8 Samurai 8"
// Ancient: "WhiteMage 8 Summoner 8 Orator 8 Arithmetician 8 Dancer 8"
// HighSummoner: "BlackMage 8 Summoner 8 Orator 8 Arithmetician 8 Dancer 8"

// OnionKnight: "DarkKnight 1 HighSummoner 1"


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
$ClassName[8] = "Thief";
$ClassRequirements[8] = "Archer 3";
$ClassName[9] = "Mystic";
$ClassRequirements[9] = "WhiteMage 3";
$ClassName[10] = "TimeMage";
$ClassRequirements[10] = "BlackMage 3";
// (RL 10)
$ClassName[11] = "Geomancer";
$ClassRequirements[11] = "Monk 5";
$ClassName[12] = "Dragoon";
$ClassRequirements[12] = "Thief 5";
$ClassName[13] = "Orator";
$ClassRequirements[13] = "Mystic 5";
$ClassName[14] = "Summoner";
$ClassRequirements[14] = "TimeMage 5";
// (RL 25)
$ClassName[15] = "Samurai";
$ClassRequirements[15] = "Geomancer 5 Orator 1";
$ClassName[16] = "Ninja";
$ClassRequirements[16] = "Dragoon 5 Summoner 1";
$ClassName[17] = "Dancer";
$ClassRequirements[17] = "Orator 5 Dragoon 1";
$ClassName[18] = "Arithmetician";
$ClassRequirements[18] = "Summoner 5 Geomancer 1";
// (RL 50+ end game)
$ClassName[19] = "HolyKnight";
$ClassRequirements[19] = "Mystic 8 Geomancer 8 Orator 8 Samurai 8";
$ClassName[20] = "DarkKnight";
$ClassRequirements[20] = "TimeMage 8 Dragoon 8 Summoner 8 Ninja 8";
$ClassName[21] = "Ancient";
$ClassRequirements[21] = "Monk 8 Orator 8 Dragoon 8 Dancer 8";
$ClassName[22] = "HighSummoner";
$ClassRequirements[22] = "Thief 8 Summoner 8 Geomancer 8 Arithmetician 8";
// epic tier classes
$ClassName[23] = "OnionKnight";
$ClassRequirements[23] = "Squire 100";
$ClassName[24] = "Kefka";
$ClassRequirements[24] = "Chemist 100";
// god tier class
$ClassName[25] = "Soldier";
$ClassRequirements[25] = "HolyKnight 1 DarkKnight 1 Ancient 1 HighSummoner 1";
// // cloud tier class
$ClassName[26] = "ExSoldier";
$ClassRequirements[26] = "Soldier 1 OnionKnight 1 Kefka 1";


function getFinalCLASS(%clientId)
{
	dbecho($dbechoMode, "getFinalCLASS(" @ %clientId @ ")");

	for(%i = 1; $ClassName[%i] != ""; %i++)
	{
		if(String::ICompare($ClassName[%i], fetchData(%clientId, "CLASS")) == 0)
			return $ClassName[%i]; //fetchData(%clientId, "RemortStep")];
	}
	
	return -1;
}

function IsAClass(%class)
{
	dbecho($dbechoMode, "IsAClass(" @ %class @ ")");

	for(%i = 1; $ClassName[%i] != ""; %i++)
	{
		if(String::ICompare(%class, $ClassName[%i]) == 0)
			return True;
	}

	return False;
}