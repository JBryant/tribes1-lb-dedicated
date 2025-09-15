//This file is part of Tribes RPG.
//Tribes RPG server side scripts
//Written by Jason "phantom" Daley,  Matthiew "JeremyIrons" Bouchard, and more (yet undetermined)

//	Copyright (C) 2014  Jason Daley

//	This program is free software: you can redistribute it and/or modifycanisursa2019
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


//######################################################################################
// Skills
//######################################################################################

$SkillSwords = 1;
$SkillAxes = 2;               
$SkillHammers = 3;
$SkillKatanas = 4;
$SkillBows = 5;
$SkillSpears = 6;
$SkillWhiteMagick = 7;
$SkillBlackMagick = 8;
$SkillTimeMagick = 9;
$SkillSummonMagick = 10;
$SkillHealing = 11;         
$SkillEndurance = 12;
$SkillAlchemy = 13;
$SkillMagicka = 14;
$SkillWeightCapacity = 15;
$SkillHiding = 16;
$SkillStealing = 17;
$SkillBackstabbing = 18;
$SkillMining = 19;
$SkillHaggling = 20;
$SkillWoodCutting = 21;
$SkillFarming = 22;

// Min Data
$MinLevel = "L";
$MinGroup = "G";
$MinClass = "C";
$MinRemort = "R";
$MinAdmin = "A";
$MinHouse = "H";

$SkillDesc[$SkillSwords] = "Swords";
$SkillDesc[$SkillAxes] = "Axes";
$SkillDesc[$SkillHammers] = "Hammers";
$SkillDesc[$SkillKatanas] = "Katanas";
$SkillDesc[$SkillBows] = "Bows";
$SkillDesc[$SkillSpears] = "Spears";
$SkillDesc[$SkillWhiteMagick] = "White Magick";
$SkillDesc[$SkillBlackMagick] = "Black Magick";
$SkillDesc[$SkillTimeMagick] = "Time Magick";
$SkillDesc[$SkillSummonMagick] = "Summon Magick";
$SkillDesc[$SkillHealing] = "Healing";
$SkillDesc[$SkillEndurance] = "Endurance";
$SkillDesc[$SkillAlchemy] = "Alchemy";
$SkillDesc[$SkillMagicka] = "Magicka";
$SkillDesc[$SkillWeightCapacity] = "Weight Capacity";
$SkillDesc[$SkillHiding] = "Hiding";
$SkillDesc[$SkillStealing] = "Stealing";
$SkillDesc[$SkillBackstabbing] = "Backstabbing";
$SkillDesc[$SkillMining] = "Mining";
$SkillDesc[$SkillHaggling] = "Haggling";
$SkillDesc[$SkillWoodCutting] = "Wood Cutting";
$SkillDesc[$SkillFarming] = "Farming";
$SkillDesc[L] = "Level";
$SkillDesc[G] = "Group";
$SkillDesc[C] = "Class";
$SkillDesc[R] = "Remort";
$SkillDesc[A] = "Admin Level";
$SkillDesc[H] = "House";

//--------------
// Enemy - Used for AI so that they can use all weapons / skills if needed
//--------------

$SkillMultiplier[Enemy, $SkillSwords] = 1.0;
$SkillMultiplier[Enemy, $SkillAxes] = 1.0;
$SkillMultiplier[Enemy, $SkillHammers] = 1.0;
$SkillMultiplier[Enemy, $SkillKatanas] = 1.0;
$SkillMultiplier[Enemy, $SkillBows] = 1.0;
$SkillMultiplier[Enemy, $SkillSpears] = 1.0;
$SkillMultiplier[Enemy, $SkillBlackMagick] = 1.0;
$SkillMultiplier[Enemy, $SkillWhiteMagick] = 1.0;
$SkillMultiplier[Enemy, $SkillTimeMagick] = 1.0;
$SkillMultiplier[Enemy, $SkillSummonMagick] = 1.0;
$SkillMultiplier[Enemy, $SkillHealing] = 0.1;
$SkillMultiplier[Enemy, $SkillEndurance] = 1.0;
$SkillMultiplier[Enemy, $SkillAlchemy] = 1.0;
$SkillMultiplier[Enemy, $SkillMagicka] = 1.0;
$SkillMultiplier[Enemy, $SkillWeightCapacity] = 1.0;
$SkillMultiplier[Enemy, $SkillStealing] = 1.0;
$SkillMultiplier[Enemy, $SkillHiding] = 1.0;
$SkillMultiplier[Enemy, $SkillBackstabbing] = 1.0;
$SkillMultiplier[Enemy, $SkillMining] = 1.0;
$SkillMultiplier[Enemy, $SkillHaggling] = 1.0;
$SkillMultiplier[Enemy, $SkillWoodCutting] = 1.0;
$SkillMultiplier[Enemy, $SkillFarming] = 1.0;

//--------------
// Squire
//--------------

$SkillMultiplier[Squire, $SkillSwords] = 1.0;
$SkillMultiplier[Squire, $SkillAxes] = 0.8;
$SkillMultiplier[Squire, $SkillHammers] = 1.0;
$SkillMultiplier[Squire, $SkillKatanas] = 0.2;
$SkillMultiplier[Squire, $SkillBows] = 0.8;
$SkillMultiplier[Squire, $SkillSpears] = 1.0;
$SkillMultiplier[Squire, $SkillBlackMagick] = 0.4;
$SkillMultiplier[Squire, $SkillWhiteMagick] = 0.4;
$SkillMultiplier[Squire, $SkillTimeMagick] = 0.2;
$SkillMultiplier[Squire, $SkillSummonMagick] = 0.2;
$SkillMultiplier[Squire, $SkillHealing] = 1.0;
$SkillMultiplier[Squire, $SkillEndurance] = 1.0;
$SkillMultiplier[Squire, $SkillAlchemy] = 0.2;
$SkillMultiplier[Squire, $SkillMagicka] = 0.2;
$SkillMultiplier[Squire, $SkillWeightCapacity] = 1.0;
$SkillMultiplier[Squire, $SkillStealing] = 0.2;
$SkillMultiplier[Squire, $SkillHiding] = 0.2;
$SkillMultiplier[Squire, $SkillBackstabbing] = 0.2;
$SkillMultiplier[Squire, $SkillMining] = 1.0;
$SkillMultiplier[Squire, $SkillHaggling] = 1.0;
$SkillMultiplier[Squire, $SkillWoodCutting] = 1.0;
$SkillMultiplier[Squire, $SkillFarming] = 1.0;
$EXPmultiplier[Squire] = 2;
$AllowedSkills[Squire] = ""
@ $SkillDesc[$SkillSwords] @ " "
@ $SkillDesc[$SkillAxes] @ " "
@ $SkillDesc[$SkillHammers] @ " "
@ $SkillDesc[$SkillHealing] @ " "
@ $SkillDesc[$SkillEndurance] @ " "
@ $SkillDesc[$SkillWeightCapacity] @ " "
@ $SkillDesc[$SkillMining] @ " "
@ $SkillDesc[$SkillWoodCutting] @ " "
@ $SkillDesc[$SkillHaggling] @ " ";

//--------------
// Chemist
//--------------

$SkillMultiplier[Chemist, $SkillSwords] = 0.5;
$SkillMultiplier[Chemist, $SkillAxes] = 0.5;
$SkillMultiplier[Chemist, $SkillHammers] = 1.0;
$SkillMultiplier[Chemist, $SkillKatanas] = 0.1;
$SkillMultiplier[Chemist, $SkillBows] = 0.8;
$SkillMultiplier[Chemist, $SkillSpears] = 0.9;
$SkillMultiplier[Chemist, $SkillBlackMagick] = 1.0;
$SkillMultiplier[Chemist, $SkillWhiteMagick] = 1.0;
$SkillMultiplier[Chemist, $SkillTimeMagick] = 0.6;
$SkillMultiplier[Chemist, $SkillSummonMagick] = 0.6;
$SkillMultiplier[Chemist, $SkillHealing] = 1.1;
$SkillMultiplier[Chemist, $SkillEndurance] = 1.0;
$SkillMultiplier[Chemist, $SkillAlchemy] = 1.0;
$SkillMultiplier[Chemist, $SkillMagicka] = 1.0;
$SkillMultiplier[Chemist, $SkillWeightCapacity] = 1.0;
$SkillMultiplier[Chemist, $SkillStealing] = 0.2;
$SkillMultiplier[Chemist, $SkillHiding] = 0.2;
$SkillMultiplier[Chemist, $SkillBackstabbing] = 0.2;
$SkillMultiplier[Chemist, $SkillMining] = 1.0;
$SkillMultiplier[Chemist, $SkillHaggling] = 1.0;
$SkillMultiplier[Chemist, $SkillWoodCutting] = 1.0;
$SkillMultiplier[Chemist, $SkillFarming] = 1.0;
$EXPmultiplier[Chemist] = 2;
$AllowedSkills[Chemist] = ""
@ $SkillDesc[$SkillHammers] @ " "
@ $SkillDesc[$SkillSpears] @ " "
@ $SkillDesc[$SkillWeightCapacity] @ " "
@ $SkillDesc[$SkillHealing] @ " "
@ $SkillDesc[$SkillEndurance] @ " "
@ $SkillDesc[$SkillAlchemy] @ " "
@ $SkillDesc[$SkillFarming] @ " "
@ $SkillDesc[$SkillWoodCutting] @ " ";

//--------------
// Knight
//--------------
//

$SkillMultiplier[Knight, $SkillSwords] = 1.5;
$SkillMultiplier[Knight, $SkillAxes] = 1.2;
$SkillMultiplier[Knight, $SkillHammers] = 1.5;
$SkillMultiplier[Knight, $SkillKatanas] = 0.5;
$SkillMultiplier[Knight, $SkillWeightCapacity] = 1.5;
$SkillMultiplier[Knight, $SkillSpears] = 1.0;
$SkillMultiplier[Knight, $SkillStealing] = 0.2;
$SkillMultiplier[Knight, $SkillHiding] = 0.2;
$SkillMultiplier[Knight, $SkillBackstabbing] = 0.2;
$SkillMultiplier[Knight, $SkillBlackMagick] = 0.2;
$SkillMultiplier[Knight, $SkillWhiteMagick] = 0.8;
$SkillMultiplier[Knight, $SkillSummonMagick] = 0.2;
$SkillMultiplier[Knight, $SkillTimeMagick] = 0.2;
$SkillMultiplier[Knight, $SkillHealing] = 1.0;
$SkillMultiplier[Knight, $SkillBows] = 1.0;
$SkillMultiplier[Knight, $SkillEndurance] = 1.5;
$SkillMultiplier[Knight, $SkillMining] = 1.0;
$SkillMultiplier[Knight, $SkillMagicka] = 1.0;
$SkillMultiplier[Knight, $SkillAlchemy] = 0.5;
$SkillMultiplier[Knight, $SkillHaggling] = 1.5;
$SkillMultiplier[Knight, $SkillWoodCutting] = 1.0;
$SkillMultiplier[Knight, $SkillFarming] = 1.0;
$EXPmultiplier[Knight] = 1.5;
$AllowedSkills[Knight] = ""
@ $SkillDesc[$SkillSwords] @ " "
@ $SkillDesc[$SkillAxes] @ " "
@ $SkillDesc[$SkillHammers] @ " "
@ $SkillDesc[$SkillSpears] @ " "
@ $SkillDesc[$SkillHealing] @ " "
@ $SkillDesc[$SkillEndurance] @ " "
@ $SkillDesc[$SkillWeightCapacity] @ " "
@ $SkillDesc[$SkillMining] @ " "
@ $SkillDesc[$SkillHaggling] @ " ";

//--------------
// Archer
//--------------

$SkillMultiplier[Archer, $SkillSwords] = 1.0;
$SkillMultiplier[Archer, $SkillAxes] = 0.8;
$SkillMultiplier[Archer, $SkillHammers] = 1.0;
$SkillMultiplier[Archer, $SkillKatanas] = 0.5;
$SkillMultiplier[Archer, $SkillWeightCapacity] = 1.2;
$SkillMultiplier[Archer, $SkillSpears] = 1.5;
$SkillMultiplier[Archer, $SkillStealing] = 1.0;
$SkillMultiplier[Archer, $SkillHiding] = 0.8;
$SkillMultiplier[Archer, $SkillBackstabbing] = 1.2;
$SkillMultiplier[Archer, $SkillBlackMagick] = 0.3;
$SkillMultiplier[Archer, $SkillWhiteMagick] = 1.0;
$SkillMultiplier[Archer, $SkillSummonMagick] = 0.5;
$SkillMultiplier[Archer, $SkillTimeMagick] = 0.5;
$SkillMultiplier[Archer, $SkillHealing] = 1.4;
$SkillMultiplier[Archer, $SkillBows] = 2.0;
$SkillMultiplier[Archer, $SkillEndurance] = 1.25;
$SkillMultiplier[Archer, $SkillMining] = 0.8;
$SkillMultiplier[Archer, $SkillMagicka] = 1.0;
$SkillMultiplier[Archer, $SkillAlchemy] = 1.0;
$SkillMultiplier[Archer, $SkillHaggling] = 1.2;
$SkillMultiplier[Archer, $SkillWoodCutting] = 1.0;
$SkillMultiplier[Archer, $SkillFarming] = 1.0;
$EXPmultiplier[Archer] = 1.5;
$AllowedSkills[Archer] = ""
@ $SkillDesc[$SkillSwords] @ " "
@ $SkillDesc[$SkillAxes] @ " "
@ $SkillDesc[$SkillHammers] @ " "
@ $SkillDesc[$SkillSpears] @ " "
@ $SkillDesc[$SkillBows] @ " "
@ $SkillDesc[$SkillHealing] @ " "
@ $SkillDesc[$SkillEndurance] @ " "
@ $SkillDesc[$SkillWeightCapacity] @ " "
@ $SkillDesc[$SkillWoodCutting] @ " "
@ $SkillDesc[$SkillFarming] @ " ";

//--------------
// White Mage
//--------------

$SkillMultiplier[WhiteMage, $SkillSwords] = 0.8;
$SkillMultiplier[WhiteMage, $SkillAxes] = 0.5;
$SkillMultiplier[WhiteMage, $SkillHammers] = 1.2;
$SkillMultiplier[WhiteMage, $SkillKatanas] = 0.5;
$SkillMultiplier[WhiteMage, $SkillWeightCapacity] = 1.2;
$SkillMultiplier[WhiteMage, $SkillSpears] = 1.6;
$SkillMultiplier[WhiteMage, $SkillStealing] = 0.2;
$SkillMultiplier[WhiteMage, $SkillHiding] = 0.2;
$SkillMultiplier[WhiteMage, $SkillBackstabbing] = 0.2;
$SkillMultiplier[WhiteMage, $SkillBlackMagick] = 0.5;
$SkillMultiplier[WhiteMage, $SkillWhiteMagick] = 2.0;
$SkillMultiplier[WhiteMage, $SkillSummonMagick] = 0.1;
$SkillMultiplier[WhiteMage, $SkillTimeMagick] = 0.8;
$SkillMultiplier[WhiteMage, $SkillHealing] = 1.8;
$SkillMultiplier[WhiteMage, $SkillBows] = 0.8;
$SkillMultiplier[WhiteMage, $SkillEndurance] = 1.4;
$SkillMultiplier[WhiteMage, $SkillMining] = 1.0;
$SkillMultiplier[WhiteMage, $SkillMagicka] = 1.8;
$SkillMultiplier[WhiteMage, $SkillAlchemy] = 1.8;
$SkillMultiplier[WhiteMage, $SkillHaggling] = 1.0;
$SkillMultiplier[WhiteMage, $SkillWoodCutting] = 1.0;
$SkillMultiplier[WhiteMage, $SkillFarming] = 1.0;
$EXPmultiplier[WhiteMage] = 1.5;
$AllowedSkills[WhiteMage] = $SkillDesc[$SkillHammers] @ " "
@ $SkillDesc[$SkillSpears] @ " "
@ $SkillDesc[$SkillWeightCapacity] @ " "
@ $SkillDesc[$SkillWhiteMagick] @ " "
@ $SkillDesc[$SkillHealing] @ " "
@ $SkillDesc[$SkillEndurance] @ " "
@ $SkillDesc[$SkillMagicka] @ " "
@ $SkillDesc[$SkillAlchemy] @ " "
@ $SkillDesc[$SkillFarming] @ " "
@ $SkillDesc[$SkillWoodCutting] @ " ";

//--------------
// Black Mage
//--------------

$SkillMultiplier[BlackMage, $SkillSwords] = 0.8;
$SkillMultiplier[BlackMage, $SkillAxes] = 0.8;
$SkillMultiplier[BlackMage, $SkillHammers] = 0.5;
$SkillMultiplier[BlackMage, $SkillKatanas] = 0.2;
$SkillMultiplier[BlackMage, $SkillWeightCapacity] = 1.2;
$SkillMultiplier[BlackMage, $SkillSpears] = 1.5;
$SkillMultiplier[BlackMage, $SkillStealing] = 0.3;
$SkillMultiplier[BlackMage, $SkillHiding] = 0.3;
$SkillMultiplier[BlackMage, $SkillBackstabbing] = 0.3;
$SkillMultiplier[BlackMage, $SkillBlackMagick] = 1.8;
$SkillMultiplier[BlackMage, $SkillWhiteMagick] = 0.5;
$SkillMultiplier[BlackMage, $SkillSummonMagick] = 0.3;
$SkillMultiplier[BlackMage, $SkillTimeMagick] = 0.8;
$SkillMultiplier[BlackMage, $SkillHealing] = 0.5;
$SkillMultiplier[BlackMage, $SkillBows] = 0.8;
$SkillMultiplier[BlackMage, $SkillEndurance] = 0.8;
$SkillMultiplier[BlackMage, $SkillMining] = 0.4;
$SkillMultiplier[BlackMage, $SkillMagicka] = 1.8;
$SkillMultiplier[BlackMage, $SkillAlchemy] = 1.8;
$SkillMultiplier[BlackMage, $SkillHaggling] = 1.3;
$SkillMultiplier[BlackMage, $SkillWoodCutting] = 1.0;
$SkillMultiplier[BlackMage, $SkillFarming] = 1.0;
$EXPmultiplier[BlackMage] = 1.5;
$AllowedSkills[BlackMage] = ""
@ $SkillDesc[$SkillHammers] @ " "
@ $SkillDesc[$SkillSpears] @ " "
@ $SkillDesc[$SkillWeightCapacity] @ " "
@ $SkillDesc[$SkillBlackMagick] @ " "
@ $SkillDesc[$SkillHealing] @ " "
@ $SkillDesc[$SkillEndurance] @ " "
@ $SkillDesc[$SkillMagicka] @ " "
@ $SkillDesc[$SkillAlchemy] @ " "
@ $SkillDesc[$SkillFarming] @ " "
@ $SkillDesc[$SkillWoodCutting] @ " ";

//--------------
// Monk
//--------------

$SkillMultiplier[Monk, $SkillSwords] = 1.2;
$SkillMultiplier[Monk, $SkillAxes] = 1.1;
$SkillMultiplier[Monk, $SkillHammers] = 1.2;
$SkillMultiplier[Monk, $SkillKatanas] = 1.8;
$SkillMultiplier[Monk, $SkillWeightCapacity] = 2.0;
$SkillMultiplier[Monk, $SkillSpears] = 2.0;
$SkillMultiplier[Monk, $SkillStealing] = 0.5;
$SkillMultiplier[Monk, $SkillHiding] = 1.0;
$SkillMultiplier[Monk, $SkillBackstabbing] = 0.4;
$SkillMultiplier[Monk, $SkillBlackMagick] = 0.2;
$SkillMultiplier[Monk, $SkillWhiteMagick] = 0.4;
$SkillMultiplier[Monk, $SkillSummonMagick] = 0.3;
$SkillMultiplier[Monk, $SkillTimeMagick] = 0.2;
$SkillMultiplier[Monk, $SkillHealing] = 0.8;
$SkillMultiplier[Monk, $SkillBows] = 2.0;
$SkillMultiplier[Monk, $SkillEndurance] = 1.2;
$SkillMultiplier[Monk, $SkillMining] = 1.0;
$SkillMultiplier[Monk, $SkillMagicka] = 1.0;
$SkillMultiplier[Monk, $SkillAlchemy] = 0.7;
$SkillMultiplier[Monk, $SkillHaggling] = 0.7;
$SkillMultiplier[Monk, $SkillWoodCutting] = 1.0;
$SkillMultiplier[Monk, $SkillFarming] = 1.0;
$EXPmultiplier[Monk] = 1.1;
$AllowedSkills[Monk] = ""
@ $SkillDesc[$SkillSwords] @ " "
@ $SkillDesc[$SkillAxes] @ " "
@ $SkillDesc[$SkillHammers] @ " "
@ $SkillDesc[$SkillSpears] @ " "
@ $SkillDesc[$SkillHealing] @ " "
@ $SkillDesc[$SkillEndurance] @ " "
@ $SkillDesc[$SkillWeightCapacity] @ " "
@ $SkillDesc[$SkillMining] @ " "
@ $SkillDesc[$SkillHaggling] @ " ";

//--------------
// Hunter
//--------------

$SkillMultiplier[Hunter, $SkillSwords] = 1.2;
$SkillMultiplier[Hunter, $SkillAxes] = 1.0;
$SkillMultiplier[Hunter, $SkillHammers] = 1.0;
$SkillMultiplier[Hunter, $SkillKatanas] = 0.8;
$SkillMultiplier[Hunter, $SkillWeightCapacity] = 1.4;
$SkillMultiplier[Hunter, $SkillSpears] = 1.7;
$SkillMultiplier[Hunter, $SkillStealing] = 1.3;
$SkillMultiplier[Hunter, $SkillHiding] = 1.0;
$SkillMultiplier[Hunter, $SkillBackstabbing] = 1.2;
$SkillMultiplier[Hunter, $SkillBlackMagick] = 0.5;
$SkillMultiplier[Hunter, $SkillWhiteMagick] = 1.0;
$SkillMultiplier[Hunter, $SkillSummonMagick] = 0.5;
$SkillMultiplier[Hunter, $SkillTimeMagick] = 0.5;
$SkillMultiplier[Hunter, $SkillHealing] = 1.5;
$SkillMultiplier[Hunter, $SkillBows] = 2.0;
$SkillMultiplier[Hunter, $SkillEndurance] = 1.5;
$SkillMultiplier[Hunter, $SkillMining] = 0.8;
$SkillMultiplier[Hunter, $SkillMagicka] = 1.0;
$SkillMultiplier[Hunter, $SkillAlchemy] = 1.0;
$SkillMultiplier[Hunter, $SkillHaggling] = 1.2;
$SkillMultiplier[Hunter, $SkillWoodCutting] = 1.5;
$SkillMultiplier[Hunter, $SkillFarming] = 1.5;
$EXPmultiplier[Hunter] = 1.25;
$AllowedSkills[Hunter] = ""
@ $SkillDesc[$SkillSwords] @ " "
@ $SkillDesc[$SkillAxes] @ " "
@ $SkillDesc[$SkillHammers] @ " "
@ $SkillDesc[$SkillSpears] @ " "
@ $SkillDesc[$SkillBows] @ " "
@ $SkillDesc[$SkillHealing] @ " "
@ $SkillDesc[$SkillEndurance] @ " "
@ $SkillDesc[$SkillWeightCapacity] @ " "
@ $SkillDesc[$SkillWoodCutting] @ " "
@ $SkillDesc[$SkillFarming] @ " ";

//--------------
// Mystic
//--------------

$SkillMultiplier[Mystic, $SkillSwords] = 0.3;
$SkillMultiplier[Mystic, $SkillAxes] = 0.8;
$SkillMultiplier[Mystic, $SkillHammers] = 0.3;
$SkillMultiplier[Mystic, $SkillKatanas] = 1.2;
$SkillMultiplier[Mystic, $SkillWeightCapacity] = 0.6;
$SkillMultiplier[Mystic, $SkillSpears] = 0.2;
$SkillMultiplier[Mystic, $SkillStealing] = 0.2;
$SkillMultiplier[Mystic, $SkillHiding] = 0.2;
$SkillMultiplier[Mystic, $SkillBackstabbing] = 0.2;
$SkillMultiplier[Mystic, $SkillBlackMagick] = 2.0;
$SkillMultiplier[Mystic, $SkillWhiteMagick] = 1.0;
$SkillMultiplier[Mystic, $SkillSummonMagick] = 1.8;
$SkillMultiplier[Mystic, $SkillTimeMagick] = 1.5;
$SkillMultiplier[Mystic, $SkillHealing] = 0.7;
$SkillMultiplier[Mystic, $SkillBows] = 0.8;
$SkillMultiplier[Mystic, $SkillEndurance] = 0.4;
$SkillMultiplier[Mystic, $SkillMining] = 1.0;
$SkillMultiplier[Mystic, $SkillMagicka] = 1.2;
$SkillMultiplier[Mystic, $SkillAlchemy] = 2.0;
$SkillMultiplier[Mystic, $SkillHaggling] = 1.0;
$SkillMultiplier[Mystic, $SkillWoodCutting] = 1.0;
$SkillMultiplier[Mystic, $SkillFarming] = 1.0;
$EXPmultiplier[Mystic] = 1.1;
$AllowedSkills[Mystic] = ""
@ $SkillDesc[$SkillHammers] @ " "
@ $SkillDesc[$SkillSpears] @ " "
@ $SkillDesc[$SkillWeightCapacity] @ " "
@ $SkillDesc[$SkillWhiteMagick] @ " "
@ $SkillDesc[$SkillTimeMagick] @ " "
@ $SkillDesc[$SkillHealing] @ " "
@ $SkillDesc[$SkillEndurance] @ " "
@ $SkillDesc[$SkillMagicka] @ " "
@ $SkillDesc[$SkillAlchemy] @ " "
@ $SkillDesc[$SkillFarming] @ " "
@ $SkillDesc[$SkillWoodCutting] @ " ";

//--------------
// Mystic
//--------------

$SkillMultiplier[TimeMage, $SkillSwords] = 0.3;
$SkillMultiplier[TimeMage, $SkillAxes] = 0.8;
$SkillMultiplier[TimeMage, $SkillHammers] = 0.3;
$SkillMultiplier[TimeMage, $SkillKatanas] = 1.2;
$SkillMultiplier[TimeMage, $SkillWeightCapacity] = 0.6;
$SkillMultiplier[TimeMage, $SkillSpears] = 0.2;
$SkillMultiplier[TimeMage, $SkillStealing] = 0.2;
$SkillMultiplier[TimeMage, $SkillHiding] = 0.2;
$SkillMultiplier[TimeMage, $SkillBackstabbing] = 0.2;
$SkillMultiplier[TimeMage, $SkillBlackMagick] = 2.0;
$SkillMultiplier[TimeMage, $SkillWhiteMagick] = 1.0;
$SkillMultiplier[TimeMage, $SkillSummonMagick] = 1.8;
$SkillMultiplier[TimeMage, $SkillTimeMagick] = 1.5;
$SkillMultiplier[TimeMage, $SkillHealing] = 0.7;
$SkillMultiplier[TimeMage, $SkillBows] = 0.8;
$SkillMultiplier[TimeMage, $SkillEndurance] = 0.4;
$SkillMultiplier[TimeMage, $SkillMining] = 1.0;
$SkillMultiplier[TimeMage, $SkillMagicka] = 1.2;
$SkillMultiplier[TimeMage, $SkillAlchemy] = 2.0;
$SkillMultiplier[TimeMage, $SkillHaggling] = 1.0;
$SkillMultiplier[TimeMage, $SkillWoodCutting] = 1.0;
$SkillMultiplier[TimeMage, $SkillFarming] = 1.0;
$EXPmultiplier[TimeMage] = 1.1;
$AllowedSkills[TimeMage] = ""
@ $SkillDesc[$SkillHammers] @ " "
@ $SkillDesc[$SkillSpears] @ " "
@ $SkillDesc[$SkillWeightCapacity] @ " "
@ $SkillDesc[$SkillBlackMagick] @ " "
@ $SkillDesc[$SkillTimeMagick] @ " "
@ $SkillDesc[$SkillHealing] @ " "
@ $SkillDesc[$SkillEndurance] @ " "
@ $SkillDesc[$SkillMagicka] @ " "
@ $SkillDesc[$SkillAlchemy] @ " "
@ $SkillDesc[$SkillFarming] @ " "
@ $SkillDesc[$SkillWoodCutting] @ " ";

//--------------
// Geomancer
//--------------

$SkillMultiplier[Geomancer, $SkillSwords] = 0.3;
$SkillMultiplier[Geomancer, $SkillAxes] = 0.8;
$SkillMultiplier[Geomancer, $SkillHammers] = 0.3;
$SkillMultiplier[Geomancer, $SkillKatanas] = 1.2;
$SkillMultiplier[Geomancer, $SkillWeightCapacity] = 0.6;
$SkillMultiplier[Geomancer, $SkillSpears] = 0.2;
$SkillMultiplier[Geomancer, $SkillStealing] = 0.2;
$SkillMultiplier[Geomancer, $SkillHiding] = 0.2;
$SkillMultiplier[Geomancer, $SkillBackstabbing] = 0.2;
$SkillMultiplier[Geomancer, $SkillBlackMagick] = 2.0;
$SkillMultiplier[Geomancer, $SkillWhiteMagick] = 1.0;
$SkillMultiplier[Geomancer, $SkillSummonMagick] = 1.8;
$SkillMultiplier[Geomancer, $SkillTimeMagick] = 1.5;
$SkillMultiplier[Geomancer, $SkillHealing] = 0.7;
$SkillMultiplier[Geomancer, $SkillBows] = 0.8;
$SkillMultiplier[Geomancer, $SkillEndurance] = 0.4;
$SkillMultiplier[Geomancer, $SkillMining] = 1.0;
$SkillMultiplier[Geomancer, $SkillMagicka] = 1.2;
$SkillMultiplier[Geomancer, $SkillAlchemy] = 2.0;
$SkillMultiplier[Geomancer, $SkillHaggling] = 1.0;
$SkillMultiplier[Geomancer, $SkillWoodCutting] = 1.0;
$SkillMultiplier[Geomancer, $SkillFarming] = 1.0;
$EXPmultiplier[Geomancer] = 1.0;
$AllowedSkills[Geomancer] = ""
@ $SkillDesc[$SkillSwords] @ " "
@ $SkillDesc[$SkillAxes] @ " "
@ $SkillDesc[$SkillHammers] @ " "
@ $SkillDesc[$SkillSpears] @ " "
@ $SkillDesc[$SkillKatanas] @ " "
@ $SkillDesc[$SkillHealing] @ " "
@ $SkillDesc[$SkillEndurance] @ " "
@ $SkillDesc[$SkillWeightCapacity] @ " "
@ $SkillDesc[$SkillMining] @ " "
@ $SkillDesc[$SkillHaggling] @ " ";

//--------------
// Sniper
//--------------

$SkillMultiplier[Sniper, $SkillSwords] = 1.3;
$SkillMultiplier[Sniper, $SkillAxes] = 1.2;
$SkillMultiplier[Sniper, $SkillHammers] = 1.1;
$SkillMultiplier[Sniper, $SkillKatanas] = 1.0;
$SkillMultiplier[Sniper, $SkillWeightCapacity] = 1.5;
$SkillMultiplier[Sniper, $SkillSpears] = 1.8;
$SkillMultiplier[Sniper, $SkillStealing] = 1.5;
$SkillMultiplier[Sniper, $SkillHiding] = 1.2;
$SkillMultiplier[Sniper, $SkillBackstabbing] = 1.4;
$SkillMultiplier[Sniper, $SkillBlackMagick] = 0.5;
$SkillMultiplier[Sniper, $SkillWhiteMagick] = 1.0;
$SkillMultiplier[Sniper, $SkillSummonMagick] = 0.5;
$SkillMultiplier[Sniper, $SkillTimeMagick] = 0.5;
$SkillMultiplier[Sniper, $SkillHealing] = 1.5;
$SkillMultiplier[Sniper, $SkillBows] = 2.0;
$SkillMultiplier[Sniper, $SkillEndurance] = 1.5;
$SkillMultiplier[Sniper, $SkillMining] = 0.8;
$SkillMultiplier[Sniper, $SkillMagicka] = 1.0;
$SkillMultiplier[Sniper, $SkillAlchemy] = 1.0;
$SkillMultiplier[Sniper, $SkillHaggling] = 1.2;
$SkillMultiplier[Sniper, $SkillWoodCutting] = 1.5;
$SkillMultiplier[Sniper, $SkillFarming] = 1.5;
$EXPmultiplier[Sniper] = 1.1;
$AllowedSkills[Sniper] = ""
@ $SkillDesc[$SkillSwords] @ " "
@ $SkillDesc[$SkillAxes] @ " "
@ $SkillDesc[$SkillHammers] @ " "
@ $SkillDesc[$SkillSpears] @ " "
@ $SkillDesc[$SkillKatanas] @ " "
@ $SkillDesc[$SkillBows] @ " "
@ $SkillDesc[$SkillHealing] @ " "
@ $SkillDesc[$SkillEndurance] @ " "
@ $SkillDesc[$SkillWeightCapacity] @ " "
@ $SkillDesc[$SkillWoodCutting] @ " "
@ $SkillDesc[$SkillFarming] @ " ";

//--------------
// Orator
//--------------

$SkillMultiplier[Orator, $SkillSwords] = 0.3;
$SkillMultiplier[Orator, $SkillAxes] = 0.8;
$SkillMultiplier[Orator, $SkillHammers] = 1.5;
$SkillMultiplier[Orator, $SkillKatanas] = 0.8;
$SkillMultiplier[Orator, $SkillWeightCapacity] = 1.2;
$SkillMultiplier[Orator, $SkillSpears] = 1.8;
$SkillMultiplier[Orator, $SkillStealing] = 0.2;
$SkillMultiplier[Orator, $SkillHiding] = 0.2;
$SkillMultiplier[Orator, $SkillBackstabbing] = 0.2;
$SkillMultiplier[Orator, $SkillBlackMagick] = 1.0;
$SkillMultiplier[Orator, $SkillWhiteMagick] = 1.8;
$SkillMultiplier[Orator, $SkillSummonMagick] = 1.8;
$SkillMultiplier[Orator, $SkillTimeMagick] = 1.5;
$SkillMultiplier[Orator, $SkillHealing] = 0.7;
$SkillMultiplier[Orator, $SkillBows] = 0.8;
$SkillMultiplier[Orator, $SkillEndurance] = 0.4;
$SkillMultiplier[Orator, $SkillMining] = 1.0;
$SkillMultiplier[Orator, $SkillMagicka] = 1.5;
$SkillMultiplier[Orator, $SkillAlchemy] = 2.0;
$SkillMultiplier[Orator, $SkillHaggling] = 1.0;
$SkillMultiplier[Orator, $SkillWoodCutting] = 1.0;
$SkillMultiplier[Orator, $SkillFarming] = 1.0;
$EXPmultiplier[Orator] = 1.0;
$AllowedSkills[Orator] = ""
@ $SkillDesc[$SkillHammers] @ " "
@ $SkillDesc[$SkillSpears] @ " "
@ $SkillDesc[$SkillWeightCapacity] @ " "
@ $SkillDesc[$SkillWhiteMagick] @ " "
@ $SkillDesc[$SkillTimeMagick] @ " "
@ $SkillDesc[$SkillHealing] @ " "
@ $SkillDesc[$SkillEndurance] @ " "
@ $SkillDesc[$SkillMagicka] @ " "
@ $SkillDesc[$SkillAlchemy] @ " "
@ $SkillDesc[$SkillFarming] @ " "
@ $SkillDesc[$SkillWoodCutting] @ " ";

//--------------
// Summoner
//--------------

$SkillMultiplier[Summoner, $SkillSwords] = 0.3;
$SkillMultiplier[Summoner, $SkillAxes] = 0.8;
$SkillMultiplier[Summoner, $SkillHammers] = 0.3;
$SkillMultiplier[Summoner, $SkillKatanas] = 1.2;
$SkillMultiplier[Summoner, $SkillWeightCapacity] = 1.2;
$SkillMultiplier[Summoner, $SkillSpears] = 1.8;
$SkillMultiplier[Summoner, $SkillStealing] = 0.2;
$SkillMultiplier[Summoner, $SkillHiding] = 0.2;
$SkillMultiplier[Summoner, $SkillBackstabbing] = 0.2;
$SkillMultiplier[Summoner, $SkillBlackMagick] = 2.0;
$SkillMultiplier[Summoner, $SkillWhiteMagick] = 1.0;
$SkillMultiplier[Summoner, $SkillSummonMagick] = 1.8;
$SkillMultiplier[Summoner, $SkillTimeMagick] = 1.5;
$SkillMultiplier[Summoner, $SkillHealing] = 0.7;
$SkillMultiplier[Summoner, $SkillBows] = 0.8;
$SkillMultiplier[Summoner, $SkillEndurance] = 0.4;
$SkillMultiplier[Summoner, $SkillMining] = 1.0;
$SkillMultiplier[Summoner, $SkillMagicka] = 1.2;
$SkillMultiplier[Summoner, $SkillAlchemy] = 2.0;
$SkillMultiplier[Summoner, $SkillHaggling] = 1.0;
$SkillMultiplier[Summoner, $SkillWoodCutting] = 1.0;
$SkillMultiplier[Summoner, $SkillFarming] = 1.0;
$EXPmultiplier[Summoner] = 1.0;
$AllowedSkills[Summoner] = ""
@ $SkillDesc[$SkillHammers] @ " "
@ $SkillDesc[$SkillSpears] @ " "
@ $SkillDesc[$SkillWeightCapacity] @ " "
@ $SkillDesc[$SkillBlackMagick] @ " "
@ $SkillDesc[$SkillTimeMagick] @ " "
@ $SkillDesc[$SkillSummonMagick] @ " "
@ $SkillDesc[$SkillHealing] @ " "
@ $SkillDesc[$SkillEndurance] @ " "
@ $SkillDesc[$SkillMagicka] @ " "
@ $SkillDesc[$SkillAlchemy] @ " "
@ $SkillDesc[$SkillFarming] @ " "
@ $SkillDesc[$SkillWoodCutting] @ " ";

//--------------
// Samurai
//--------------

$SkillMultiplier[Samurai, $SkillSwords] = 0.3;
$SkillMultiplier[Samurai, $SkillAxes] = 0.8;
$SkillMultiplier[Samurai, $SkillHammers] = 0.3;
$SkillMultiplier[Samurai, $SkillKatanas] = 1.2;
$SkillMultiplier[Samurai, $SkillWeightCapacity] = 1.6;
$SkillMultiplier[Samurai, $SkillSpears] = 0.2;
$SkillMultiplier[Samurai, $SkillStealing] = 0.2;
$SkillMultiplier[Samurai, $SkillHiding] = 0.2;
$SkillMultiplier[Samurai, $SkillBackstabbing] = 0.2;
$SkillMultiplier[Samurai, $SkillBlackMagick] = 2.0;
$SkillMultiplier[Samurai, $SkillWhiteMagick] = 1.0;
$SkillMultiplier[Samurai, $SkillSummonMagick] = 1.8;
$SkillMultiplier[Samurai, $SkillTimeMagick] = 1.5;
$SkillMultiplier[Samurai, $SkillHealing] = 0.7;
$SkillMultiplier[Samurai, $SkillBows] = 0.8;
$SkillMultiplier[Samurai, $SkillEndurance] = 0.4;
$SkillMultiplier[Samurai, $SkillMining] = 1.0;
$SkillMultiplier[Samurai, $SkillMagicka] = 1.2;
$SkillMultiplier[Samurai, $SkillAlchemy] = 2.0;
$SkillMultiplier[Samurai, $SkillHaggling] = 1.0;
$SkillMultiplier[Samurai, $SkillWoodCutting] = 1.0;
$SkillMultiplier[Samurai, $SkillFarming] = 1.0;
$EXPmultiplier[Samurai] = 0.9;
$AllowedSkills[Samurai] = ""
@ $SkillDesc[$SkillSwords] @ " "
@ $SkillDesc[$SkillAxes] @ " "
@ $SkillDesc[$SkillHammers] @ " "
@ $SkillDesc[$SkillSpears] @ " "
@ $SkillDesc[$SkillKatanas] @ " "
@ $SkillDesc[$SkillWhiteMagick] @ " "
@ $SkillDesc[$SkillHealing] @ " "
@ $SkillDesc[$SkillEndurance] @ " "
@ $SkillDesc[$SkillMagicka] @ " "
@ $SkillDesc[$SkillWeightCapacity] @ " "
@ $SkillDesc[$SkillMining] @ " "
@ $SkillDesc[$SkillHaggling] @ " ";

//--------------
// SpellBow
//--------------

$SkillMultiplier[SpellBow, $SkillSwords] = 1.4;
$SkillMultiplier[SpellBow, $SkillAxes] = 1.3;
$SkillMultiplier[SpellBow, $SkillHammers] = 1.2;
$SkillMultiplier[SpellBow, $SkillKatanas] = 1.2;
$SkillMultiplier[SpellBow, $SkillWeightCapacity] = 1.6;
$SkillMultiplier[SpellBow, $SkillSpears] = 1.9;
$SkillMultiplier[SpellBow, $SkillStealing] = 1.7;
$SkillMultiplier[SpellBow, $SkillHiding] = 1.4;
$SkillMultiplier[SpellBow, $SkillBackstabbing] = 1.5;
$SkillMultiplier[SpellBow, $SkillBlackMagick] = 1.3;
$SkillMultiplier[SpellBow, $SkillWhiteMagick] = 1.0;
$SkillMultiplier[SpellBow, $SkillSummonMagick] = 0.5;
$SkillMultiplier[SpellBow, $SkillTimeMagick] = 0.5;
$SkillMultiplier[SpellBow, $SkillHealing] = 1.6;
$SkillMultiplier[SpellBow, $SkillBows] = 2.0;
$SkillMultiplier[SpellBow, $SkillEndurance] = 1.7;
$SkillMultiplier[SpellBow, $SkillMining] = 0.8;
$SkillMultiplier[SpellBow, $SkillMagicka] = 1.3;
$SkillMultiplier[SpellBow, $SkillAlchemy] = 1.2;
$SkillMultiplier[SpellBow, $SkillHaggling] = 1.4;
$SkillMultiplier[SpellBow, $SkillWoodCutting] = 1.6;
$SkillMultiplier[SpellBow, $SkillFarming] = 1.6;
$EXPmultiplier[SpellBow] = 0.9;
$AllowedSkills[SpellBow] = ""
@ $SkillDesc[$SkillSwords] @ " "
@ $SkillDesc[$SkillAxes] @ " "
@ $SkillDesc[$SkillHammers] @ " "
@ $SkillDesc[$SkillSpears] @ " "
@ $SkillDesc[$SkillBows] @ " "
@ $SkillDesc[$SkillBlackMagick] @ " "
@ $SkillDesc[$SkillHealing] @ " "
@ $SkillDesc[$SkillEndurance] @ " "
@ $SkillDesc[$SkillMagicka] @ " "
@ $SkillDesc[$SkillWeightCapacity] @ " "
@ $SkillDesc[$SkillWoodCutting] @ " "
@ $SkillDesc[$SkillFarming] @ " ";

//--------------
// Dancer
//--------------

$SkillMultiplier[Dancer, $SkillSwords] = 0.3;
$SkillMultiplier[Dancer, $SkillAxes] = 0.8;
$SkillMultiplier[Dancer, $SkillHammers] = 0.3;
$SkillMultiplier[Dancer, $SkillKatanas] = 1.2;
$SkillMultiplier[Dancer, $SkillWeightCapacity] = 0.6;
$SkillMultiplier[Dancer, $SkillSpears] = 0.2;
$SkillMultiplier[Dancer, $SkillStealing] = 0.2;
$SkillMultiplier[Dancer, $SkillHiding] = 0.2;
$SkillMultiplier[Dancer, $SkillBackstabbing] = 0.2;
$SkillMultiplier[Dancer, $SkillBlackMagick] = 1.0;
$SkillMultiplier[Dancer, $SkillWhiteMagick] = 1.8;
$SkillMultiplier[Dancer, $SkillSummonMagick] = 1.8;
$SkillMultiplier[Dancer, $SkillTimeMagick] = 1.5;
$SkillMultiplier[Dancer, $SkillHealing] = 0.7;
$SkillMultiplier[Dancer, $SkillBows] = 0.8;
$SkillMultiplier[Dancer, $SkillEndurance] = 0.4;
$SkillMultiplier[Dancer, $SkillMining] = 1.0;
$SkillMultiplier[Dancer, $SkillMagicka] = 1.2;
$SkillMultiplier[Dancer, $SkillAlchemy] = 2.0;
$SkillMultiplier[Dancer, $SkillHaggling] = 1.0;
$SkillMultiplier[Dancer, $SkillWoodCutting] = 1.0;
$SkillMultiplier[Dancer, $SkillFarming] = 1.0;
$EXPmultiplier[Dancer] = 0.9;
$AllowedSkills[Dancer] = ""
@ $SkillDesc[$SkillHammers] @ " "
@ $SkillDesc[$SkillSpears] @ " "
@ $SkillDesc[$SkillKatanas] @ " "
@ $SkillDesc[$SkillWeightCapacity] @ " "
@ $SkillDesc[$SkillWhiteMagick] @ " "
@ $SkillDesc[$SkillTimeMagick] @ " "
@ $SkillDesc[$SkillSummonMagick] @ " "
@ $SkillDesc[$SkillHealing] @ " "
@ $SkillDesc[$SkillEndurance] @ " "
@ $SkillDesc[$SkillMagicka] @ " "
@ $SkillDesc[$SkillAlchemy] @ " "
@ $SkillDesc[$SkillFarming] @ " "
@ $SkillDesc[$SkillWoodCutting] @ " ";

//--------------
// SpellBlade
//--------------

$SkillMultiplier[SpellBlade, $SkillSwords] = 1.5;
$SkillMultiplier[SpellBlade, $SkillAxes] = 1.4;
$SkillMultiplier[SpellBlade, $SkillHammers] = 1.0;
$SkillMultiplier[SpellBlade, $SkillKatanas] = 1.4;
$SkillMultiplier[SpellBlade, $SkillWeightCapacity] = 1.2;
$SkillMultiplier[SpellBlade, $SkillSpears] = 1.8;
$SkillMultiplier[SpellBlade, $SkillStealing] = 0.2;
$SkillMultiplier[SpellBlade, $SkillHiding] = 0.2;
$SkillMultiplier[SpellBlade, $SkillBackstabbing] = 0.2;
$SkillMultiplier[SpellBlade, $SkillBlackMagick] = 2.0;
$SkillMultiplier[SpellBlade, $SkillWhiteMagick] = 1.0;
$SkillMultiplier[SpellBlade, $SkillSummonMagick] = 1.8;
$SkillMultiplier[SpellBlade, $SkillTimeMagick] = 1.5;
$SkillMultiplier[SpellBlade, $SkillHealing] = 0.7;
$SkillMultiplier[SpellBlade, $SkillBows] = 0.8;
$SkillMultiplier[SpellBlade, $SkillEndurance] = 1.5;
$SkillMultiplier[SpellBlade, $SkillMining] = 1.0;
$SkillMultiplier[SpellBlade, $SkillMagicka] = 1.8;
$SkillMultiplier[SpellBlade, $SkillAlchemy] = 1.8;
$SkillMultiplier[SpellBlade, $SkillHaggling] = 1.0;
$SkillMultiplier[SpellBlade, $SkillWoodCutting] = 1.0;
$SkillMultiplier[SpellBlade, $SkillFarming] = 1.0;
$EXPmultiplier[SpellBlade] = 0.9;
$AllowedSkills[SpellBlade] = ""
@ $SkillDesc[$SkillSwords] @ " "
@ $SkillDesc[$SkillAxes] @ " "
@ $SkillDesc[$SkillHammers] @ " "
@ $SkillDesc[$SkillKatanas] @ " "
@ $SkillDesc[$SkillSpears] @ " "
@ $SkillDesc[$SkillWeightCapacity] @ " "
@ $SkillDesc[$SkillBlackMagick] @ " "
@ $SkillDesc[$SkillTimeMagick] @ " "
@ $SkillDesc[$SkillSummonMagick] @ " "
@ $SkillDesc[$SkillHealing] @ " "
@ $SkillDesc[$SkillEndurance] @ " "
@ $SkillDesc[$SkillMagicka] @ " "
@ $SkillDesc[$SkillAlchemy] @ " "
@ $SkillDesc[$SkillFarming] @ " "
@ $SkillDesc[$SkillWoodCutting] @ " ";

//--------------
// HolyKnight
//--------------

$SkillMultiplier[HolyKnight, $SkillSwords] = 1.8;
$SkillMultiplier[HolyKnight, $SkillAxes] = 1.5;
$SkillMultiplier[HolyKnight, $SkillHammers] = 1.8;
$SkillMultiplier[HolyKnight, $SkillKatanas] = 1.5;
$SkillMultiplier[HolyKnight, $SkillWeightCapacity] = 2.0;
$SkillMultiplier[HolyKnight, $SkillSpears] = 1.8;
$SkillMultiplier[HolyKnight, $SkillStealing] = 0.2;
$SkillMultiplier[HolyKnight, $SkillHiding] = 0.2;
$SkillMultiplier[HolyKnight, $SkillBackstabbing] = 0.2;
$SkillMultiplier[HolyKnight, $SkillBlackMagick] = 1.0;
$SkillMultiplier[HolyKnight, $SkillWhiteMagick] = 1.8;
$SkillMultiplier[HolyKnight, $SkillSummonMagick] = 1.0;
$SkillMultiplier[HolyKnight, $SkillTimeMagick] = 1.4;
$SkillMultiplier[HolyKnight, $SkillHealing] = 1.8;
$SkillMultiplier[HolyKnight, $SkillBows] = 0.8;
$SkillMultiplier[HolyKnight, $SkillEndurance] = 1.8;
$SkillMultiplier[HolyKnight, $SkillMining] = 1.0;
$SkillMultiplier[HolyKnight, $SkillMagicka] = 1.4;
$SkillMultiplier[HolyKnight, $SkillAlchemy] = 1.0;
$SkillMultiplier[HolyKnight, $SkillHaggling] = 1.0;
$SkillMultiplier[HolyKnight, $SkillWoodCutting] = 1.0;
$SkillMultiplier[HolyKnight, $SkillFarming] = 1.0;
$EXPmultiplier[HolyKnight] = 0.8;
$AllowedSkills[HolyKnight] = ""
@ $SkillDesc[$SkillSwords] @ " "
@ $SkillDesc[$SkillAxes] @ " "
@ $SkillDesc[$SkillHammers] @ " "
@ $SkillDesc[$SkillKatanas] @ " "
@ $SkillDesc[$SkillSpears] @ " "
@ $SkillDesc[$SkillWeightCapacity] @ " "
@ $SkillDesc[$SkillWhiteMagick] @ " "
@ $SkillDesc[$SkillTimeMagick] @ " "
@ $SkillDesc[$SkillHealing] @ " "
@ $SkillDesc[$SkillEndurance] @ " "
@ $SkillDesc[$SkillMagicka] @ " "
@ $SkillDesc[$SkillAlchemy] @ " "
@ $SkillDesc[$SkillFarming] @ " "
@ $SkillDesc[$SkillWoodCutting] @ " ";

//--------------
// DarkKnight
//--------------

$SkillMultiplier[DarkKnight, $SkillSwords] = 1.5;
$SkillMultiplier[DarkKnight, $SkillAxes] = 1.9;
$SkillMultiplier[DarkKnight, $SkillHammers] = 1.5;
$SkillMultiplier[DarkKnight, $SkillKatanas] = 1.8;
$SkillMultiplier[DarkKnight, $SkillWeightCapacity] = 2.0;
$SkillMultiplier[DarkKnight, $SkillSpears] = 1.5;
$SkillMultiplier[DarkKnight, $SkillStealing] = 1.2;
$SkillMultiplier[DarkKnight, $SkillHiding] = 1.2;
$SkillMultiplier[DarkKnight, $SkillBackstabbing] = 1.2;
$SkillMultiplier[DarkKnight, $SkillBlackMagick] = 1.8;
$SkillMultiplier[DarkKnight, $SkillWhiteMagick] = 1.0;
$SkillMultiplier[DarkKnight, $SkillSummonMagick] = 1.4;
$SkillMultiplier[DarkKnight, $SkillTimeMagick] = 1.0;
$SkillMultiplier[DarkKnight, $SkillHealing] = 1.4;
$SkillMultiplier[DarkKnight, $SkillBows] = 0.8;
$SkillMultiplier[DarkKnight, $SkillEndurance] = 1.8;
$SkillMultiplier[DarkKnight, $SkillMining] = 1.0;
$SkillMultiplier[DarkKnight, $SkillMagicka] = 1.4;
$SkillMultiplier[DarkKnight, $SkillAlchemy] = 1.0;
$SkillMultiplier[DarkKnight, $SkillHaggling] = 1.0;
$SkillMultiplier[DarkKnight, $SkillWoodCutting] = 1.0;
$SkillMultiplier[DarkKnight, $SkillFarming] = 1.0;
$EXPmultiplier[DarkKnight] = 0.8;
$AllowedSkills[DarkKnight] = ""
@ $SkillDesc[$SkillSwords] @ " "
@ $SkillDesc[$SkillAxes] @ " "
@ $SkillDesc[$SkillHammers] @ " "
@ $SkillDesc[$SkillKatanas] @ " "
@ $SkillDesc[$SkillSpears] @ " "
@ $SkillDesc[$SkillWeightCapacity] @ " "
@ $SkillDesc[$SkillBlackMagick] @ " "
@ $SkillDesc[$SkillSummonMagick] @ " "
@ $SkillDesc[$SkillHealing] @ " "
@ $SkillDesc[$SkillEndurance] @ " "
@ $SkillDesc[$SkillMagicka] @ " "
@ $SkillDesc[$SkillAlchemy] @ " "
@ $SkillDesc[$SkillFarming] @ " "
@ $SkillDesc[$SkillWoodCutting] @ " ";

//--------------
// Valkyrie
//--------------

$SkillMultiplier[Valkyrie, $SkillSwords] = 1.3;
$SkillMultiplier[Valkyrie, $SkillAxes] = 1.1;
$SkillMultiplier[Valkyrie, $SkillHammers] = 1.2;
$SkillMultiplier[Valkyrie, $SkillKatanas] = 1.2;
$SkillMultiplier[Valkyrie, $SkillWeightCapacity] = 1.8;
$SkillMultiplier[Valkyrie, $SkillSpears] = 2.0;
$SkillMultiplier[Valkyrie, $SkillStealing] = 1.2;
$SkillMultiplier[Valkyrie, $SkillHiding] = 0.8;
$SkillMultiplier[Valkyrie, $SkillBackstabbing] = 0.8;
$SkillMultiplier[Valkyrie, $SkillBlackMagick] = 1.2;
$SkillMultiplier[Valkyrie, $SkillWhiteMagick] = 1.5;
$SkillMultiplier[Valkyrie, $SkillSummonMagick] = 0.5;
$SkillMultiplier[Valkyrie, $SkillTimeMagick] = 0.5;
$SkillMultiplier[Valkyrie, $SkillHealing] = 1.8;
$SkillMultiplier[Valkyrie, $SkillBows] = 2.0;
$SkillMultiplier[Valkyrie, $SkillEndurance] = 1.8;
$SkillMultiplier[Valkyrie, $SkillMining] = 0.8;
$SkillMultiplier[Valkyrie, $SkillMagicka] = 1.5;
$SkillMultiplier[Valkyrie, $SkillAlchemy] = 1.3;
$SkillMultiplier[Valkyrie, $SkillHaggling] = 1.4;
$SkillMultiplier[Valkyrie, $SkillWoodCutting] = 1.2;
$SkillMultiplier[Valkyrie, $SkillFarming] = 1.2;
$EXPmultiplier[Valkyrie] = 0.8;
$AllowedSkills[Valkyrie] = ""
@ $SkillDesc[$SkillSwords] @ " "
@ $SkillDesc[$SkillAxes] @ " "
@ $SkillDesc[$SkillHammers] @ " "
@ $SkillDesc[$SkillSpears] @ " "
@ $SkillDesc[$SkillKatanas] @ " "
@ $SkillDesc[$SkillBows] @ " "
@ $SkillDesc[$SkillWhiteMagick] @ " "
@ $SkillDesc[$SkillSummonMagick] @ " "
@ $SkillDesc[$SkillHealing] @ " "
@ $SkillDesc[$SkillEndurance] @ " "
@ $SkillDesc[$SkillMagicka] @ " "
@ $SkillDesc[$SkillWeightCapacity] @ " "
@ $SkillDesc[$SkillWoodCutting] @ " "
@ $SkillDesc[$SkillFarming] @ " ";

//--------------
// ArcaneArcher
//--------------

$SkillMultiplier[ArcaneArcher, $SkillSwords] = 1.3;
$SkillMultiplier[ArcaneArcher, $SkillAxes] = 1.1;
$SkillMultiplier[ArcaneArcher, $SkillHammers] = 1.2;
$SkillMultiplier[ArcaneArcher, $SkillKatanas] = 1.2;
$SkillMultiplier[ArcaneArcher, $SkillWeightCapacity] = 1.8;
$SkillMultiplier[ArcaneArcher, $SkillSpears] = 2.0;
$SkillMultiplier[ArcaneArcher, $SkillStealing] = 1.2;
$SkillMultiplier[ArcaneArcher, $SkillHiding] = 0.8;
$SkillMultiplier[ArcaneArcher, $SkillBackstabbing] = 0.8;
$SkillMultiplier[ArcaneArcher, $SkillBlackMagick] = 1.8;
$SkillMultiplier[ArcaneArcher, $SkillWhiteMagick] = 1.1;
$SkillMultiplier[ArcaneArcher, $SkillSummonMagick] = 0.5;
$SkillMultiplier[ArcaneArcher, $SkillTimeMagick] = 0.5;
$SkillMultiplier[ArcaneArcher, $SkillHealing] = 1.8;
$SkillMultiplier[ArcaneArcher, $SkillBows] = 2.0;
$SkillMultiplier[ArcaneArcher, $SkillEndurance] = 1.8;
$SkillMultiplier[ArcaneArcher, $SkillMining] = 0.8;
$SkillMultiplier[ArcaneArcher, $SkillMagicka] = 1.5;
$SkillMultiplier[ArcaneArcher, $SkillAlchemy] = 1.3;
$SkillMultiplier[ArcaneArcher, $SkillHaggling] = 1.4;
$SkillMultiplier[ArcaneArcher, $SkillWoodCutting] = 1.2;
$SkillMultiplier[ArcaneArcher, $SkillFarming] = 1.2;
$EXPmultiplier[ArcaneArcher] = 0.8;
$AllowedSkills[ArcaneArcher] = ""
@ $SkillDesc[$SkillSwords] @ " "
@ $SkillDesc[$SkillAxes] @ " "
@ $SkillDesc[$SkillHammers] @ " "
@ $SkillDesc[$SkillSpears] @ " "
@ $SkillDesc[$SkillKatanas] @ " "
@ $SkillDesc[$SkillBows] @ " "
@ $SkillDesc[$SkillBlackMagick] @ " "
@ $SkillDesc[$SkillTimeMagick] @ " "
@ $SkillDesc[$SkillHealing] @ " "
@ $SkillDesc[$SkillEndurance] @ " "
@ $SkillDesc[$SkillMagicka] @ " "
@ $SkillDesc[$SkillWeightCapacity] @ " "
@ $SkillDesc[$SkillWoodCutting] @ " "
@ $SkillDesc[$SkillFarming] @ " ";

//--------------
// Seraphim
//--------------

$SkillMultiplier[Seraphim, $SkillSwords] = 0.3;
$SkillMultiplier[Seraphim, $SkillAxes] = 0.8;
$SkillMultiplier[Seraphim, $SkillHammers] = 0.3;
$SkillMultiplier[Seraphim, $SkillKatanas] = 1.2;
$SkillMultiplier[Seraphim, $SkillWeightCapacity] = 0.6;
$SkillMultiplier[Seraphim, $SkillSpears] = 1.8;
$SkillMultiplier[Seraphim, $SkillStealing] = 0.2;
$SkillMultiplier[Seraphim, $SkillHiding] = 0.2;
$SkillMultiplier[Seraphim, $SkillBackstabbing] = 0.2;
$SkillMultiplier[Seraphim, $SkillBlackMagick] = 1.0;
$SkillMultiplier[Seraphim, $SkillWhiteMagick] = 1.8;
$SkillMultiplier[Seraphim, $SkillSummonMagick] = 1.8;
$SkillMultiplier[Seraphim, $SkillTimeMagick] = 1.5;
$SkillMultiplier[Seraphim, $SkillHealing] = 1.7;
$SkillMultiplier[Seraphim, $SkillBows] = 1.4;
$SkillMultiplier[Seraphim, $SkillEndurance] = 1.4;
$SkillMultiplier[Seraphim, $SkillMining] = 1.0;
$SkillMultiplier[Seraphim, $SkillMagicka] = 1.2;
$SkillMultiplier[Seraphim, $SkillAlchemy] = 2.0;
$SkillMultiplier[Seraphim, $SkillHaggling] = 1.0;
$SkillMultiplier[Seraphim, $SkillWoodCutting] = 1.0;
$SkillMultiplier[Seraphim, $SkillFarming] = 1.0;
$EXPmultiplier[Seraphim] = 0.9;
$AllowedSkills[Seraphim] = ""
@ $SkillDesc[$SkillSwords] @ " "
@ $SkillDesc[$SkillAxes] @ " "
@ $SkillDesc[$SkillHammers] @ " "
@ $SkillDesc[$SkillSpears] @ " "
@ $SkillDesc[$SkillKatanas] @ " "
@ $SkillDesc[$SkillBows] @ " "
@ $SkillDesc[$SkillWhiteMagick] @ " "
@ $SkillDesc[$SkillTimeMagick] @ " "
@ $SkillDesc[$SkillHealing] @ " "
@ $SkillDesc[$SkillEndurance] @ " "
@ $SkillDesc[$SkillMagicka] @ " "
@ $SkillDesc[$SkillWeightCapacity] @ " "
@ $SkillDesc[$SkillWoodCutting] @ " "
@ $SkillDesc[$SkillFarming] @ " ";

//--------------
// Ancient
//--------------

$SkillMultiplier[Ancient, $SkillSwords] = 0.3;
$SkillMultiplier[Ancient, $SkillAxes] = 0.8;
$SkillMultiplier[Ancient, $SkillHammers] = 0.3;
$SkillMultiplier[Ancient, $SkillKatanas] = 1.2;
$SkillMultiplier[Ancient, $SkillWeightCapacity] = 0.6;
$SkillMultiplier[Ancient, $SkillSpears] = 0.2;
$SkillMultiplier[Ancient, $SkillStealing] = 0.2;
$SkillMultiplier[Ancient, $SkillHiding] = 0.2;
$SkillMultiplier[Ancient, $SkillBackstabbing] = 0.2;
$SkillMultiplier[Ancient, $SkillBlackMagick] = 2.0;
$SkillMultiplier[Ancient, $SkillWhiteMagick] = 1.0;
$SkillMultiplier[Ancient, $SkillSummonMagick] = 1.8;
$SkillMultiplier[Ancient, $SkillTimeMagick] = 1.5;
$SkillMultiplier[Ancient, $SkillHealing] = 0.7;
$SkillMultiplier[Ancient, $SkillBows] = 0.8;
$SkillMultiplier[Ancient, $SkillEndurance] = 0.4;
$SkillMultiplier[Ancient, $SkillMining] = 1.0;
$SkillMultiplier[Ancient, $SkillMagicka] = 1.2;
$SkillMultiplier[Ancient, $SkillAlchemy] = 2.0;
$SkillMultiplier[Ancient, $SkillHaggling] = 1.0;
$SkillMultiplier[Ancient, $SkillWoodCutting] = 1.0;
$SkillMultiplier[Ancient, $SkillFarming] = 1.0;
$EXPmultiplier[Ancient] = 0.9;
$AllowedSkills[Ancient] = ""
@ $SkillDesc[$SkillSwords] @ " "
@ $SkillDesc[$SkillAxes] @ " "
@ $SkillDesc[$SkillHammers] @ " "
@ $SkillDesc[$SkillKatanas] @ " "
@ $SkillDesc[$SkillSpears] @ " "
@ $SkillDesc[$SkillWhiteMagick] @ " "
@ $SkillDesc[$SkillSummonMagick] @ " "
@ $SkillDesc[$SkillHealing] @ " "
@ $SkillDesc[$SkillEndurance] @ " "
@ $SkillDesc[$SkillMagicka] @ " "
@ $SkillDesc[$SkillAlchemy] @ " "
@ $SkillDesc[$SkillFarming] @ " "
@ $SkillDesc[$SkillWoodCutting] @ " ";

//--------------
// Arcanist
//--------------
$SkillMultiplier[Arcanist, $SkillSwords] = 1.5;
$SkillMultiplier[Arcanist, $SkillAxes] = 1.4;
$SkillMultiplier[Arcanist, $SkillHammers] = 1.0;
$SkillMultiplier[Arcanist, $SkillKatanas] = 1.4;
$SkillMultiplier[Arcanist, $SkillWeightCapacity] = 1.2;
$SkillMultiplier[Arcanist, $SkillSpears] = 1.8;
$SkillMultiplier[Arcanist, $SkillStealing] = 0.2;
$SkillMultiplier[Arcanist, $SkillHiding] = 0.2;
$SkillMultiplier[Arcanist, $SkillBackstabbing] = 0.2;
$SkillMultiplier[Arcanist, $SkillBlackMagick] = 2.0;
$SkillMultiplier[Arcanist, $SkillWhiteMagick] = 1.0;
$SkillMultiplier[Arcanist, $SkillSummonMagick] = 1.8;
$SkillMultiplier[Arcanist, $SkillTimeMagick] = 1.5;
$SkillMultiplier[Arcanist, $SkillHealing] = 0.7;
$SkillMultiplier[Arcanist, $SkillBows] = 0.8;
$SkillMultiplier[Arcanist, $SkillEndurance] = 1.5;
$SkillMultiplier[Arcanist, $SkillMining] = 1.0;
$SkillMultiplier[Arcanist, $SkillMagicka] = 1.8;
$SkillMultiplier[Arcanist, $SkillAlchemy] = 1.8;
$SkillMultiplier[Arcanist, $SkillHaggling] = 1.0;
$SkillMultiplier[Arcanist, $SkillWoodCutting] = 1.0;
$SkillMultiplier[Arcanist, $SkillFarming] = 1.0;
$EXPmultiplier[Arcanist] = 0.9;
$AllowedSkills[Arcanist] = ""
@ $SkillDesc[$SkillSwords] @ " "
@ $SkillDesc[$SkillAxes] @ " "
@ $SkillDesc[$SkillHammers] @ " "
@ $SkillDesc[$SkillSpears] @ " "
@ $SkillDesc[$SkillBows] @ " "
@ $SkillDesc[$SkillBlackMagick] @ " "
@ $SkillDesc[$SkillTimeMagick] @ " "
@ $SkillDesc[$SkillHealing] @ " "
@ $SkillDesc[$SkillEndurance] @ " "
@ $SkillDesc[$SkillMagicka] @ " "
@ $SkillDesc[$SkillWeightCapacity] @ " "
@ $SkillDesc[$SkillWoodCutting] @ " "
@ $SkillDesc[$SkillFarming] @ " ";

//--------------
// Hexblade
//--------------
$SkillMultiplier[Hexblade, $SkillSwords] = 1.5;
$SkillMultiplier[Hexblade, $SkillAxes] = 1.4;
$SkillMultiplier[Hexblade, $SkillHammers] = 1.0;
$SkillMultiplier[Hexblade, $SkillKatanas] = 1.4;
$SkillMultiplier[Hexblade, $SkillWeightCapacity] = 1.2;
$SkillMultiplier[Hexblade, $SkillSpears] = 1.8;
$SkillMultiplier[Hexblade, $SkillStealing] = 0.2;
$SkillMultiplier[Hexblade, $SkillHiding] = 0.2;
$SkillMultiplier[Hexblade, $SkillBackstabbing] = 0.2;
$SkillMultiplier[Hexblade, $SkillBlackMagick] = 2.0;
$SkillMultiplier[Hexblade, $SkillWhiteMagick] = 1.0;
$SkillMultiplier[Hexblade, $SkillSummonMagick] = 1.8;
$SkillMultiplier[Hexblade, $SkillTimeMagick] = 1.5;
$SkillMultiplier[Hexblade, $SkillHealing] = 0.7;
$SkillMultiplier[Hexblade, $SkillBows] = 0.8;
$SkillMultiplier[Hexblade, $SkillEndurance] = 1.5;
$SkillMultiplier[Hexblade, $SkillMining] = 1.0;
$SkillMultiplier[Hexblade, $SkillMagicka] = 1.8;
$SkillMultiplier[Hexblade, $SkillAlchemy] = 1.8;
$SkillMultiplier[Hexblade, $SkillHaggling] = 1.0;
$SkillMultiplier[Hexblade, $SkillWoodCutting] = 1.0;
$SkillMultiplier[Hexblade, $SkillFarming] = 1.0;
$EXPmultiplier[Hexblade] = 0.9;
$AllowedSkills[Hexblade] = ""
@ $SkillDesc[$SkillSwords] @ " "
@ $SkillDesc[$SkillAxes] @ " "
@ $SkillDesc[$SkillHammers] @ " "
@ $SkillDesc[$SkillSpears] @ " "
@ $SkillDesc[$SkillKatanas] @ " "
@ $SkillDesc[$SkillBlackMagick] @ " "
@ $SkillDesc[$SkillTimeMagick] @ " "
@ $SkillDesc[$SkillSummonMagick] @ " "
@ $SkillDesc[$SkillHealing] @ " "
@ $SkillDesc[$SkillEndurance] @ " "
@ $SkillDesc[$SkillMagicka] @ " "
@ $SkillDesc[$SkillWeightCapacity] @ " "
@ $SkillDesc[$SkillWoodCutting] @ " "
@ $SkillDesc[$SkillFarming] @ " ";

//--------------
// HighSummoner
//--------------

$SkillMultiplier[HighSummoner, $SkillSwords] = 0.3;
$SkillMultiplier[HighSummoner, $SkillAxes] = 0.8;
$SkillMultiplier[HighSummoner, $SkillHammers] = 0.3;
$SkillMultiplier[HighSummoner, $SkillKatanas] = 1.2;
$SkillMultiplier[HighSummoner, $SkillWeightCapacity] = 0.6;
$SkillMultiplier[HighSummoner, $SkillSpears] = 0.2;
$SkillMultiplier[HighSummoner, $SkillStealing] = 0.2;
$SkillMultiplier[HighSummoner, $SkillHiding] = 0.2;
$SkillMultiplier[HighSummoner, $SkillBackstabbing] = 0.2;
$SkillMultiplier[HighSummoner, $SkillBlackMagick] = 2.0;
$SkillMultiplier[HighSummoner, $SkillWhiteMagick] = 1.0;
$SkillMultiplier[HighSummoner, $SkillSummonMagick] = 1.8;
$SkillMultiplier[HighSummoner, $SkillTimeMagick] = 1.5;
$SkillMultiplier[HighSummoner, $SkillHealing] = 0.7;
$SkillMultiplier[HighSummoner, $SkillBows] = 0.8;
$SkillMultiplier[HighSummoner, $SkillEndurance] = 0.4;
$SkillMultiplier[HighSummoner, $SkillMining] = 1.0;
$SkillMultiplier[HighSummoner, $SkillMagicka] = 1.2;
$SkillMultiplier[HighSummoner, $SkillAlchemy] = 2.0;
$SkillMultiplier[HighSummoner, $SkillHaggling] = 1.0;
$SkillMultiplier[HighSummoner, $SkillWoodCutting] = 1.0;
$SkillMultiplier[HighSummoner, $SkillFarming] = 1.0;
$EXPmultiplier[HighSummoner] = 0.8;
$AllowedSkills[Hexblade] = ""
@ $SkillDesc[$SkillHammers] @ " "
@ $SkillDesc[$SkillSpears] @ " "
@ $SkillDesc[$SkillWhiteMagick] @ " "
@ $SkillDesc[$SkillBlackMagick] @ " "
@ $SkillDesc[$SkillTimeMagick] @ " "
@ $SkillDesc[$SkillSummonMagick] @ " "
@ $SkillDesc[$SkillHealing] @ " "
@ $SkillDesc[$SkillEndurance] @ " "
@ $SkillDesc[$SkillMagicka] @ " "
@ $SkillDesc[$SkillWeightCapacity] @ " "
@ $SkillDesc[$SkillWoodCutting] @ " "
@ $SkillDesc[$SkillFarming] @ " ";

//--------------
// OnionKnight
//--------------

$SkillMultiplier[OnionKnight, $SkillSwords] = 2.0;
$SkillMultiplier[OnionKnight, $SkillAxes] = 2.0;
$SkillMultiplier[OnionKnight, $SkillHammers] = 2.0;
$SkillMultiplier[OnionKnight, $SkillKatanas] = 2.0;
$SkillMultiplier[OnionKnight, $SkillWeightCapacity] = 2.0;
$SkillMultiplier[OnionKnight, $SkillSpears] = 2.0;
$SkillMultiplier[OnionKnight, $SkillStealing] = 2.0;
$SkillMultiplier[OnionKnight, $SkillHiding] = 2.0;
$SkillMultiplier[OnionKnight, $SkillBackstabbing] = 2.0;
$SkillMultiplier[OnionKnight, $SkillBlackMagick] = 2.0;
$SkillMultiplier[OnionKnight, $SkillWhiteMagick] = 2.0;
$SkillMultiplier[OnionKnight, $SkillSummonMagick] = 2.0;
$SkillMultiplier[OnionKnight, $SkillTimeMagick] = 2.0;
$SkillMultiplier[OnionKnight, $SkillHealing] = 2.0;
$SkillMultiplier[OnionKnight, $SkillBows] = 2.0;
$SkillMultiplier[OnionKnight, $SkillEndurance] = 2.0;
$SkillMultiplier[OnionKnight, $SkillMining] = 2.0;
$SkillMultiplier[OnionKnight, $SkillMagicka] = 2.0;
$SkillMultiplier[OnionKnight, $SkillAlchemy] = 2.0;
$SkillMultiplier[OnionKnight, $SkillHaggling] = 2.0;
$SkillMultiplier[OnionKnight, $SkillWoodCutting] = 2.0;
$SkillMultiplier[OnionKnight, $SkillFarming] = 2.0;
$EXPmultiplier[OnionKnight] = 0.8;

//--------------
// Kefka
//--------------

$SkillMultiplier[Kefka, $SkillSwords] = 2.0;
$SkillMultiplier[Kefka, $SkillAxes] = 2.0;
$SkillMultiplier[Kefka, $SkillHammers] = 2.0;
$SkillMultiplier[Kefka, $SkillKatanas] = 2.0;
$SkillMultiplier[Kefka, $SkillWeightCapacity] = 2.0;
$SkillMultiplier[Kefka, $SkillSpears] = 2.0;
$SkillMultiplier[Kefka, $SkillStealing] = 2.0;
$SkillMultiplier[Kefka, $SkillHiding] = 2.0;
$SkillMultiplier[Kefka, $SkillBackstabbing] = 2.0;
$SkillMultiplier[Kefka, $SkillBlackMagick] = 2.0;
$SkillMultiplier[Kefka, $SkillWhiteMagick] = 2.0;
$SkillMultiplier[Kefka, $SkillSummonMagick] = 2.0;
$SkillMultiplier[Kefka, $SkillTimeMagick] = 2.0;
$SkillMultiplier[Kefka, $SkillHealing] = 2.0;
$SkillMultiplier[Kefka, $SkillBows] = 2.0;
$SkillMultiplier[Kefka, $SkillEndurance] = 2.0;
$SkillMultiplier[Kefka, $SkillMining] = 2.0;
$SkillMultiplier[Kefka, $SkillMagicka] = 2.0;
$SkillMultiplier[Kefka, $SkillAlchemy] = 2.0;
$SkillMultiplier[Kefka, $SkillHaggling] = 2.0;
$SkillMultiplier[Kefka, $SkillWoodCutting] = 2.0;
$SkillMultiplier[Kefka, $SkillFarming] = 2.0;
$EXPmultiplier[Kefka] = 0.8;

//--------------
// Soldier
//--------------

$SkillMultiplier[Soldier, $SkillSwords] = 2.0;
$SkillMultiplier[Soldier, $SkillAxes] = 2.0;
$SkillMultiplier[Soldier, $SkillHammers] = 2.0;
$SkillMultiplier[Soldier, $SkillKatanas] = 2.0;
$SkillMultiplier[Soldier, $SkillWeightCapacity] = 2.0;
$SkillMultiplier[Soldier, $SkillSpears] = 2.0;
$SkillMultiplier[Soldier, $SkillStealing] = 2.0;
$SkillMultiplier[Soldier, $SkillHiding] = 2.0;
$SkillMultiplier[Soldier, $SkillBackstabbing] = 2.0;
$SkillMultiplier[Soldier, $SkillBlackMagick] = 2.0;
$SkillMultiplier[Soldier, $SkillWhiteMagick] = 2.0;
$SkillMultiplier[Soldier, $SkillSummonMagick] = 2.0;
$SkillMultiplier[Soldier, $SkillTimeMagick] = 2.0;
$SkillMultiplier[Soldier, $SkillHealing] = 2.0;
$SkillMultiplier[Soldier, $SkillBows] = 2.0;
$SkillMultiplier[Soldier, $SkillEndurance] = 2.0;
$SkillMultiplier[Soldier, $SkillMining] = 2.0;
$SkillMultiplier[Soldier, $SkillMagicka] = 2.0;
$SkillMultiplier[Soldier, $SkillAlchemy] = 2.0;
$SkillMultiplier[Soldier, $SkillHaggling] = 2.0;
$SkillMultiplier[Soldier, $SkillWoodCutting] = 2.0;
$SkillMultiplier[Soldier, $SkillFarming] = 2.0;
$EXPmultiplier[Soldier] = 0.8;

//--------------
// ExSoldier
//--------------

$SkillMultiplier[ExSoldier, $SkillSwords] = 2.0;
$SkillMultiplier[ExSoldier, $SkillAxes] = 2.0;
$SkillMultiplier[ExSoldier, $SkillHammers] = 2.0;
$SkillMultiplier[ExSoldier, $SkillKatanas] = 2.0;
$SkillMultiplier[ExSoldier, $SkillWeightCapacity] = 2.0;
$SkillMultiplier[ExSoldier, $SkillSpears] = 2.0;
$SkillMultiplier[ExSoldier, $SkillStealing] = 2.0;
$SkillMultiplier[ExSoldier, $SkillHiding] = 2.0;
$SkillMultiplier[ExSoldier, $SkillBackstabbing] = 2.0;
$SkillMultiplier[ExSoldier, $SkillBlackMagick] = 2.0;
$SkillMultiplier[ExSoldier, $SkillWhiteMagick] = 2.0;
$SkillMultiplier[ExSoldier, $SkillSummonMagick] = 2.0;
$SkillMultiplier[ExSoldier, $SkillTimeMagick] = 2.0;
$SkillMultiplier[ExSoldier, $SkillHealing] = 2.0;
$SkillMultiplier[ExSoldier, $SkillBows] = 2.0;
$SkillMultiplier[ExSoldier, $SkillEndurance] = 2.0;
$SkillMultiplier[ExSoldier, $SkillMining] = 2.0;
$SkillMultiplier[ExSoldier, $SkillMagicka] = 2.0;	
$SkillMultiplier[ExSoldier, $SkillAlchemy] = 2.0;
$SkillMultiplier[ExSoldier, $SkillHaggling] = 2.0;
$SkillMultiplier[ExSoldier, $SkillWoodCutting] = 2.0;
$SkillMultiplier[ExSoldier, $SkillFarming] = 2.0;
$EXPmultiplier[ExSoldier] = 0.8;

//######################################################################################
// Skill Restriction tables
//######################################################################################

//To determine skill restrictions, do the following:
//
//-Determine the following variables first:
//	(weapon):
//	a = ATK * 1.1 (archery is 0.75)
//	b = Delay = Cap((Weight / 3), 1, "inf")
//
//	(armor):
//	a = (DEF + MDEF) / 6
//	b = 1.0
//
//-To find out what the skill restriction number is, follow this formula, where s is the final skill restriction:
//	s = Cap((a / b) - 20), 0, "inf") * 10.0;
//

// $SkillRestriction[BluePotion] = $SkillHealing @ " 0";
// $SkillRestriction[CrystalBluePotion] = $SkillHealing @ " 0";
// $SkillRestriction[ApprenticeRobe] = $SkillEndurance @ " 0 " @ $SkillMagicka @ " 8";
// $SkillRestriction[LightRobe] = $SkillEndurance @ " 3 " @ $SkillMagicka @ " 80";
// $SkillRestriction[FineRobe] = $SkillEndurance @ " 9 " @ $SkillMagicka @ " 175";
// $SkillRestriction[BloodRobe] = $SkillEndurance @ " 8 " @ $SkillMagicka @ " 300";
// $SkillRestriction[AdvisorRobe] = $SkillEndurance @ " 10 " @ $SkillMagicka @ " 450";
// $SkillRestriction[ElvenRobe] = $SkillEndurance @ " 12 " @ $SkillMagicka @ " 620";
// $SkillRestriction[RobeOfVenjance] = $SkillEndurance @ " 18 " @ $SkillMagicka @ " 800";
// $SkillRestriction[PhensRobe] = $SkillEndurance @ " 20 " @ $SkillMagicka @ " 980";
// $SkillRestriction[QuestMasterRobe] = $MinAdmin @ " 3";

// $SkillRestriction[PaddedArmor] = $SkillEndurance @ " 5";
// $SkillRestriction[LeatherArmor] = $SkillEndurance @ " 40";
// $SkillRestriction[StuddedLeather] = $SkillEndurance @ " 95";
// $SkillRestriction[SpikedLeather] = $SkillEndurance @ " 135";
// $SkillRestriction[HideArmor] = $SkillEndurance @ " 180";
// $SkillRestriction[ScaleMail] = $SkillEndurance @ " 240";
// $SkillRestriction[BrigandineArmor] = $SkillEndurance @ " 300";
// $SkillRestriction[ChainMail] = $SkillEndurance @ " 350";
// $SkillRestriction[RingMail] = $SkillEndurance @ " 410";
// $SkillRestriction[BandedMail] = $SkillEndurance @ " 490";
// $SkillRestriction[SplintMail] = $SkillEndurance @ " 580";
// $SkillRestriction[BronzePlateMail] = $SkillEndurance @ " 660";
// $SkillRestriction[PlateMail] = $SkillEndurance @ " 775";
// $SkillRestriction[FieldPlateArmor] = $SkillEndurance @ " 840";
// $SkillRestriction[DragonMail] = $SkillEndurance @ " 950";
// $SkillRestriction[FullPlateArmor] = $SkillEndurance @ " 1065";
// $SkillRestriction[CheetaursPaws] = $MinLevel @ " 8";
// $SkillRestriction[BootsOfGliding] = $MinLevel @ " 25";
// $SkillRestriction[WindWalkers] = $MinLevel @ " 60";
// $SkillRestriction[KeldrinArmor] = $SkillEndurance @ " 1305";

$SkillRestriction[KnightShield] = $SkillEndurance @ " 140";
$SkillRestriction[HeavenlyShield] = $SkillEndurance @ " 540 " @ $SkillMagicka @ " 850";
$SkillRestriction[DragonShield] = $SkillEndurance @ " 715";

//.................................................................................
$SkillRestriction[Club] = $SkillHammers @ " 0";
$SkillRestriction[QuarterStaff] = $SkillHammers @ " 20";
$SkillRestriction[BoneClub] = $SkillHammers @ " 45";
$SkillRestriction[SpikedClub] = $SkillHammers @ " 60";
$SkillRestriction[Mace] = $SkillHammers @ " 140";
$SkillRestriction[HammerPick] = $SkillHammers @ " 300";
$SkillRestriction[SpikedBoneClub] = $SkillHammers @ " 450";
$SkillRestriction[LongStaff] = $SkillHammers @ " 620";
$SkillRestriction[WarHammer] = $SkillHammers @ " 768";
$SkillRestriction[JusticeStaff] = $SkillHammers @ " 834";
$SkillRestriction[WarMaul] = $SkillHammers @ " 900";
//.................................................................................
$SkillRestriction[TesterBow] = $SkillBows @ " 0";
$SkillRestriction[Sling] = $SkillBows @ " 0";
$SkillRestriction[ShortBow] = $SkillBows @ " 25";
$SkillRestriction[LightCrossbow] = $SkillBows @ " 160";
$SkillRestriction[LongBow] = $SkillBows @ " 318";
$SkillRestriction[CompositeBow] = $SkillBows @ " 438";
$SkillRestriction[RepeatingCrossbow] = $SkillBows @ " 550";
$SkillRestriction[ElvenBow] = $SkillBows @ " 685";
$SkillRestriction[AeolusWing] = $SkillBows @ " 805";
$SkillRestriction[HeavyCrossbow] = $SkillBows @ " 925";
//.................................................................................
$SkillRestriction[SmallRock] = $SkillBows @ " 0";
$SkillRestriction[BasicArrow] = $SkillBows @ " 0";
$SkillRestriction[ShortQuarrel] = $SkillBows @ " 0";
$SkillRestriction[LightQuarrel] = $SkillBows @ " 0";
$SkillRestriction[SheafArrow] = $SkillBows @ " 0";
$SkillRestriction[StoneFeather] = $SkillBows @ " 0";
$SkillRestriction[BladedArrow] = $SkillBows @ " 0";
$SkillRestriction[HeavyQuarrel] = $SkillBows @ " 0";
$SkillRestriction[MetalFeather] = $SkillBows @ " 0";
$SkillRestriction[Talon] = $SkillBows @ " 0";
$SkillRestriction[CeraphumsFeather] = $SkillBows @ " 0";

// Chat functions
$SkillRestriction["#say"] = $SkillEndurance @ " 0";
$SkillRestriction["#shout"] = $SkillEndurance @ " 0";
$SkillRestriction["#whisper"] = $SkillEndurance @ " 0";
$SkillRestriction["#tell"] = $SkillEndurance @ " 0";
$SkillRestriction["#global"] = $SkillEndurance @ " 0";
$SkillRestriction["#zone"] = $SkillEndurance @ " 0";
$SkillRestriction["#group"] = $SkillEndurance @ " 0";
$SkillRestriction["#party"] = $SkillEndurance @ " 0";
$SkillRestriction["#steal"] = $SkillStealing @ " 15";
$SkillRestriction["#pickpocket"] = $SkillStealing @ " 270";
$SkillRestriction["#mug"] = $SkillStealing @ " 620";
$SkillRestriction["#compass"] = $SkillEndurance @ " 0";
$SkillRestriction["#track"] = $SkillEndurance @ " 0";
$SkillRestriction["#trackpack"] = $SkillEndurance @ " 0";
$SkillRestriction["#hide"] = $SkillHiding @ " 15";
$SkillRestriction["#bash"] = $SkillEndurance @ " 15";
$SkillRestriction["#shove"] = $SkillEndurance @ " 5";
$SkillRestriction["#zonelist"] = $SkillEndurance @ " 0";
$SkillRestriction["#advcompass"] = $SkillEndurance @ " 0";

// Spells
$SkillRestriction[thorn] = $SkillBlackMagick @ " 15";
$SkillRestriction[fireball] = $SkillBlackMagick @ " 20";
$SkillRestriction[firebomb] = $SkillBlackMagick @ " 35";
$SkillRestriction[icespike] = $SkillBlackMagick @ " 45";
$SkillRestriction[icestorm] = $SkillBlackMagick @ " 85";
$SkillRestriction[ironfist] = $SkillBlackMagick @ " 110";
$SkillRestriction[cloud] = $SkillBlackMagick @ " 145";
$SkillRestriction[melt] = $SkillBlackMagick @ " 220";
$SkillRestriction[powercloud] = $SkillBlackMagick @ " 340";
$SkillRestriction[hellstorm] = $SkillBlackMagick @ " 420";
$SkillRestriction[beam] = $SkillBlackMagick @ " 520";
$SkillRestriction[dimensionrift] = $SkillBlackMagick @ " 750";

$SkillRestriction[teleport] = $SkillTimeMagick @ " 60";
$SkillRestriction[transport] = $SkillTimeMagick @ " 200";
$SkillRestriction[advtransport] = $SkillTimeMagick @ " 350";
$SkillRestriction[remort] = $SkillTimeMagick @ " 0"; // @ $MinLevel @ " 101";
$SkillRestriction[mimic] = $SkillTimeMagick @ " 145 " @ $MinRemort @ " 2";
$SkillRestriction[masstransport] = $SkillTimeMagick @ " 650 " @ $MinRemort @ " 1";

$SkillRestriction[mend] = $SkillWhiteMagick @ " 0.2";
$SkillRestriction[heal] = $SkillWhiteMagick @ " 10";
$SkillRestriction[advheal1] = $SkillWhiteMagick @ " 80";
$SkillRestriction[advheal2] = $SkillWhiteMagick @ " 110";
$SkillRestriction[advheal3] = $SkillWhiteMagick @ " 200";
$SkillRestriction[advheal4] = $SkillWhiteMagick @ " 320";
$SkillRestriction[advheal5] = $SkillWhiteMagick @ " 400";
$SkillRestriction[advheal6] = $SkillWhiteMagick @ " 500";
$SkillRestriction[godlyheal] = $SkillWhiteMagick @ " 600";
$SkillRestriction[fullheal] = $SkillWhiteMagick @ " 750";
$SkillRestriction[massheal] = $SkillWhiteMagick @ " 850 " @ $MinRemort @ " 2";
$SkillRestriction[massfullheal] = $SkillWhiteMagick @ " 950 " @ $MinRemort @ " 3";
$SkillRestriction[shield] = $SkillWhiteMagick @ " 20";
$SkillRestriction[advshield1] = $SkillWhiteMagick @ " 60";
$SkillRestriction[advshield2] = $SkillWhiteMagick @ " 140";
$SkillRestriction[advshield3] = $SkillWhiteMagick @ " 290";
$SkillRestriction[advshield4] = $SkillWhiteMagick @ " 420";
$SkillRestriction[advshield5] = $SkillWhiteMagick @ " 635";
$SkillRestriction[massshield] = $SkillWhiteMagick @ " 680";

// new spells
// $SkillRestriction[shadowblade] = "C DarkKnight L 50";

//######################################################################################
// Skill functions
//######################################################################################

function GetNumSkills()
{
	dbecho($dbechoMode, "GetNumSkills()");

	for(%i = 1; $SkillDesc[%i] != ""; %i++){}
	return %i-1;
}

function GetNumClassSkills(%clientId) {
	dbecho($dbechoMode, "GetNumClassSkills()");

	%currentClass = fetchData(%clientId, "CLASS");
	%allowedSkills = $AllowedSkills[%currentClass];

	%count = 0;
	for(%i = 1; $SkillDesc[%i] != ""; %i++) {
		if(string::findSubStr(%allowedSkills, $SkillDesc[%i]) != -1) {
			%count++;
		}
	}

	return %count;
}

function GetClassSkillIndexes(%clientId) {
	dbecho($dbechoMode, "GetClassSkillIndexes()");

	%currentClass = fetchData(%clientId, "CLASS");
	%allowedSkills = $AllowedSkills[%currentClass];

	%skillIndexList = "";
	for(%i = 1; $SkillDesc[%i] != ""; %i++) {
		if(string::findSubStr(%allowedSkills, $SkillDesc[%i]) != -1) {
			%skillIndexList = %skillIndexList @ %i @ " ";
		}
	}

	return ltrim(%skillIndexList);
}

function AddSkillPoint(%clientId, %skill, %delta) {
	dbecho($dbechoMode, "AddSkillPoint(" @ %clientId @ ", " @ %skill @ ", " @ %delta @ ")");

	if(%delta == "")
		%delta = 1;

	//==== CAPS ================
	//if($PlayerSkill[%clientId, %skill] >= $SkillCap)
	//	return False;

	%ub = ($skillRangePerLevel * fetchData(%clientId, "LVL")) + 20 + fetchData(%clientId, "RemortStep");
	if($PlayerSkill[%clientId, %skill] >= %ub)
		return False;
	//==========================

	%a = GetSkillMultiplier(%clientId, %skill) * %delta;
	%b = $PlayerSkill[%clientId, %skill];
	%c = %a + %b;
	%d = round(%c * 10);
	%e = (%d / 10) * 1.000001;

	$PlayerSkill[%clientId, %skill] = FixDecimals(%e);

	return True;
}

function GetPlayerSkill(%clientId, %skill)
{
	return $PlayerSkill[%clientId, %skill];
}
function GetSkillMultiplier(%clientId, %skill)
{
	dbecho($dbechoMode, "GetSkillMultiplier(" @ %clientId @ ", " @ %skill @ ")");

	%a = $SkillMultiplier[fetchData(%clientId, "CLASS"), %skill];
	%b = fetchData(%clientId, "RemortStep") * 0.1;

	%c = Cap(%a + %b, "inf", 30.0);

	return FixDecimals(%c);
}
function GetEXPmultiplier(%clientId)
{
	dbecho($dbechoMode, "GetEXPmultiplier(" @ %clientId @ ")");

	%a = $EXPmultiplier[fetchData(%clientId, "CLASS")];
	%b = fetchData(%clientId, "RemortStep") * 0.5;

	%c = %a + %b;

	return FixDecimals(%c);
}

function SetAllSkills(%clientId, %n)
{
	dbecho($dbechoMode, "SetAllSkills(" @ %clientId @ ", " @ %n @ ")");

	for(%i = 1; $SkillDesc[%i] != ""; %i++)
		$PlayerSkill[%clientId, %i] = %n;
}

function SkillCanUse(%clientId, %thing) {
	dbecho($dbechoMode, "SkillCanUse(" @ %clientId @ ", " @ %thing @ ")");

	if(%clientId.adminLevel >= 5)
		return True;

	%flag = 0;
	%gc = 0;
	%gcflag = 0;

	for(%i = 0; GetWord($SkillRestriction[%thing], %i) != -1; %i+=2) {
		%s = GetWord($SkillRestriction[%thing], %i);
		%n = GetWord($SkillRestriction[%thing], %i+1);

		if(%s == "L") {
			if(fetchData(%clientId, "LVL") < %n)
				return False;
		}
		else if(%s == "R") {
			if(fetchData(%clientId, "RemortStep") < %n)
				%flag = 1;
		}
		else if(%s == "A") {
			if(%clientId.adminLevel < %n)
				%flag = 1;
		}
		else if(%s == "G") {
			%gcflag++;
			if(String::ICompare(fetchData(%clientId, "GROUP"), %n) == 0)
				%gc = 1;
		}
		else if(%s == "C") {
			%gcflag++;
			if(String::ICompare(fetchData(%clientId, "CLASS"), %n) == 0) {
				%gc = 1;
			}
		}
		else if(%s == "H") {
			%hflag++;
			if(String::ICompare(fetchData(%clientId, "MyHouse"), %n) == 0)
				%hh = 1;
		}
		else {
			if($PlayerSkill[%clientId, %s] < %n)
				%flag = 1;
		}
	}

	//First, if there are any class/group restrictions, house restrictions, check these first.
	if(%gcflag > 0) {
		if(%gc == 0)
			%flag = 1;
	}
	if(%hflag > 0) {
		if(%hh == 0)
			%flag = 1;
	}

	// add custom restrictions here
	// if (%thing == "cleave") {
	// 	%weapon = GetEquippedWeapon(%clientId);
	// 	%accessoryType =$AccessoryVar[%weapon, $AccessoryType];

	// 	if(%accessoryType != $SwordAccessoryType || %accessoryType != $AxeAccessoryType || %accessoryType != $BludgeonAccessoryType) {
	// 		%flag = 1;
	// 	}
	// }

	
	if(%flag != 1)
		return True;
	else
		return False;
}

function SkillCanUseSpell(%clientId, %index, %echo) {
	if(%clientId.adminLevel >= 5 || Player::isAiControlled(%clientId)) {
		return True;
	}

	// check if double casting
	%spellCost = $Spell::manaCost[%index];
	if (HasBonusState(%clientId, "DoubleCast"))
		%spellCost = %spellCost * 2;


	if(getMANA(%clientId) < %spellCost) {
		if(%echo) Client::sendMessage(%clientId, $MsgBeige, "Insufficient mana to cast this spell.");
		return False;
	}

	%class = fetchData(%clientId, "CLASS");
	%minLevel = $Spell::minLevel[%index];
	// lbecho("Min Level: " @ %minLevel);
	// lbecho("Current Level: " @ getFinalLVL(%clientId));

	if($Spell::classRestrictions[%index] != "" && String::findSubStr($Spell::classRestrictions[%index], %class) == -1) {
		if(%echo) Client::sendMessage(%clientId, 1, "You can't cast this spell because of your class.~wC_BuySell.wav");
		return False;
	}

	if(%minLevel != "" && getFinalLVL(%clientId) < %minLevel) {
		if(%echo) Client::sendMessage(%clientId, 1, "Your level is to low to cast this spell.~wC_BuySell.wav");
		return False;
	}

	for(%i = 0; (%s = GetWord($Spell::ToUseSkill[%index], %i)) != -1; %i++) { %i++;
		%n = GetWord($Spell::ToUseSkill[%index], %i);

		if(%s == "LVL") {
			if(getFinalLVL(%clientId) < %n) {
				if(%echo) Client::sendMessage(%clientId, 1, "Your level is to low to cast this spell.~wC_BuySell.wav");
				return False;
			}
		}
		else if(%s == "A") {
			if(%Client.adminLevel < %n) {
				if(%echo) Client::sendMessage(%clientId, 1, "Only admins may cast this spell.~wC_BuySell.wav");
				return False;
			}
		}
		else if(%s == "CLASS") {
			if(String::findSubStr(%n, ","@ %class @",") == -1) {
				if(%echo) Client::sendMessage(%clientId, 1, "You can't cast this spell because of your class.~wC_BuySell.wav");
				return False;
			}
		}
		else if(%s == "GROUP") {
			if(String::findSubStr(%n, ","@$GROUP[%clientId]@",") == -1) {
				if(%echo) Client::sendMessage(%clientId, 1, "You can't cast this spell because of your class.~wC_BuySell.wav");
				return False;
			}
		}
		else {
			%ap = Eval("getFinal"@%s@"(%clientId);");
			if(%ap < %n) {
				if(%echo) Client::sendMessage(%clientId, 1, "You need more "@%s@" to cast this spell.~wC_BuySell.wav");
				return False;
			}
		}
	}
	return True;
}

function UseSkill(%clientId, %skilltype, %successful, %showmsg, %base, %refreshall) {
	dbecho($dbechoMode, "UseSkill(" @ %clientId @ ", " @ %skilltype @ ", " @ %successful @ ", " @ %showmsg @ ", " @ %base @ ", " @ %refreshall @ ")");

	if(%base == "") %base = 35;

	%ub = ($skillRangePerLevel * fetchData(%clientId, "LVL")) + 20 + fetchData(%clientId, "RemortStep");
	if($PlayerSkill[%clientId, %skilltype] < %ub)
	{
		if(%successful)
			$SkillCounter[%clientId, %skilltype] += 1;
		else
			$SkillCounter[%clientId, %skilltype] += 0.05;

		%p = 1 - ($PlayerSkill[%clientId, %skilltype] / 1150);
		%e = round( (%base / GetSkillMultiplier(%clientId, %skilltype)) * %p );

		if($SkillCounter[%clientId, %skilltype] >= %e)
		{
			$SkillCounter[%clientId, %skilltype] = 0;
			%retval = AddSkillPoint(%clientId, %skilltype, 1);

			if(%retval)
			{
				if(%showmsg)
					Client::sendMessage(%clientId, $MsgBeige, "You have increased your skill in " @ $SkillDesc[%skilltype] @ " (" @ $PlayerSkill[%clientId, %skilltype] @ ")");
				if(%refreshall)
					RefreshAll(%clientId);
			}
		}
	}
}

function WhatSkills(%thing)
{
	dbecho($dbechoMode, "WhatSkills(" @ %thing @ ")");

	%t = "";
	for(%i = 0; GetWord($SkillRestriction[%thing], %i) != -1; %i+=2)
	{
		%s = GetWord($SkillRestriction[%thing], %i);
		%n = GetWord($SkillRestriction[%thing], %i+1);
		%t = %t @ $SkillDesc[%s] @ ": " @ %n @ ", ";
	}

	if ($Spell::index[%thing] != "") {
		// show spell class restrictions and level restrictions
		%spellIndex = $Spell::index[%thing];
		if ($Spell::classRestrictions[%spellIndex] != "") {
			%t = %t @ "CLASSES: " @ $Spell::classRestrictions[%spellIndex] @ " ";
		}

		if ($Spell::minLevel[%spellIndex] != "") {
			%t = %t @ "MIN LEVEL: " @ $Spell::minLevel[%spellIndex] @ ", ";
		}
	}

	if(%t == "")
		%t = "None";
	else
		%t = String::getSubStr(%t, 0, String::len(%t)-2);
	
	return %t;
}

function GetSkillAmount(%thing, %skill)
{
	dbecho($dbechoMode, "GetSkillAmount(" @ %thing @ ", " @ %skill @ ")");

	for(%i = 0; GetWord($SkillRestriction[%thing], %i) != -1; %i+=2)
	{
		%s = GetWord($SkillRestriction[%thing], %i);

		if(%s == %skill)
			return GetWord($SkillRestriction[%thing], %i+1);
	}
	return 0;
}

function GetMANA(%clientId) {
	return fetchData(%clientId, "MANA");
}