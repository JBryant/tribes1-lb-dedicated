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
$SkillEnergy = 13;
$SkillMagicka = 14;
$SkillWeightCapacity = 15;
$SkillHiding = 16;
$SkillStealing = 17;
$SkillBackstabbing = 18;
$SkillMining = 19;
$SkillHaggling = 20;

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
$SkillDesc[$SkillEnergy] = "Energy";
$SkillDesc[$SkillMagicka] = "Magicka";
$SkillDesc[$SkillWeightCapacity] = "Weight Capacity";
$SkillDesc[$SkillHiding] = "Hiding";
$SkillDesc[$SkillStealing] = "Stealing";
$SkillDesc[$SkillBackstabbing] = "Backstabbing";
$SkillDesc[$SkillMining] = "Mining";
$SkillDesc[$SkillHaggling] = "Haggling";
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
$SkillMultiplier[Enemy, $SkillEnergy] = 1.0;
$SkillMultiplier[Enemy, $SkillMagicka] = 1.0;
$SkillMultiplier[Enemy, $SkillWeightCapacity] = 1.0;
$SkillMultiplier[Enemy, $SkillStealing] = 1.0;
$SkillMultiplier[Enemy, $SkillHiding] = 1.0;
$SkillMultiplier[Enemy, $SkillBackstabbing] = 1.0;
$SkillMultiplier[Enemy, $SkillMining] = 1.0;
$SkillMultiplier[Enemy, $SkillHaggling] = 1.0;

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
$SkillMultiplier[Squire, $SkillEnergy] = 0.2;
$SkillMultiplier[Squire, $SkillMagicka] = 0.2;
$SkillMultiplier[Squire, $SkillWeightCapacity] = 1.0;
$SkillMultiplier[Squire, $SkillStealing] = 0.2;
$SkillMultiplier[Squire, $SkillHiding] = 0.2;
$SkillMultiplier[Squire, $SkillBackstabbing] = 0.2;
$SkillMultiplier[Squire, $SkillMining] = 1.0;
$SkillMultiplier[Squire, $SkillHaggling] = 1.0;
$EXPmultiplier[Squire] = 1.5;
$AllowedSkills[Squire] = $SkillSwords@ " " @$SkillAxes@ " " @$SkillHammers@ " " @$SkillHealing@ " " @$SkillEndurance@ " " @$SkillWeightCapacity@ " " @$SkillMining@ " " @$SkillHaggling;

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
$SkillMultiplier[Chemist, $SkillEnergy] = 1.0;
$SkillMultiplier[Chemist, $SkillMagicka] = 1.0;
$SkillMultiplier[Chemist, $SkillWeightCapacity] = 1.0;
$SkillMultiplier[Chemist, $SkillStealing] = 0.2;
$SkillMultiplier[Chemist, $SkillHiding] = 0.2;
$SkillMultiplier[Chemist, $SkillBackstabbing] = 0.2;
$SkillMultiplier[Chemist, $SkillMining] = 1.0;
$SkillMultiplier[Chemist, $SkillHaggling] = 1.0;
$EXPmultiplier[Chemist] = 1.5;

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
$SkillMultiplier[Knight, $SkillEnergy] = 0.5;
$SkillMultiplier[Knight, $SkillHaggling] = 1.5;
$EXPmultiplier[Knight] = 1.25;

//--------------
// Archer
//--------------

$SkillMultiplier[Archer, $SkillSwords] = 1.0;
$SkillMultiplier[Archer, $SkillAxes] = 0.8;
$SkillMultiplier[Archer, $SkillHammers] = 1.0;
$SkillMultiplier[Archer, $SkillKatanas] = 0.5;
$SkillMultiplier[Archer, $SkillWeightCapacity] = 1.2;
$SkillMultiplier[Archer, $SkillSpears] = 1.5;
$SkillMultiplier[Archer, $SkillStealing] = 2.0;
$SkillMultiplier[Archer, $SkillHiding] = 1.8;
$SkillMultiplier[Archer, $SkillBackstabbing] = 1.2;
$SkillMultiplier[Archer, $SkillBlackMagick] = 0.3;
$SkillMultiplier[Archer, $SkillWhiteMagick] = 1.0;
$SkillMultiplier[Archer, $SkillSummonMagick] = 0.5;
$SkillMultiplier[Archer, $SkillTimeMagick] = 0.5;
$SkillMultiplier[Archer, $SkillHealing] = 1.4;
$SkillMultiplier[Archer, $SkillBows] = 2.0;
$SkillMultiplier[Archer, $SkillEndurance] = 2.0;
$SkillMultiplier[Archer, $SkillMining] = 0.8;
$SkillMultiplier[Archer, $SkillMagicka] = 1.0;
$SkillMultiplier[Archer, $SkillEnergy] = 1.0;
$SkillMultiplier[Archer, $SkillHaggling] = 1.2;
$EXPmultiplier[Archer] = 1.25;

//--------------
// White Mage
//--------------

$SkillMultiplier[WhiteMage, $SkillSwords] = 0.8;
$SkillMultiplier[WhiteMage, $SkillAxes] = 0.5;
$SkillMultiplier[WhiteMage, $SkillHammers] = 1.2;
$SkillMultiplier[WhiteMage, $SkillKatanas] = 0.5;
$SkillMultiplier[WhiteMage, $SkillWeightCapacity] = 1.0;
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
$SkillMultiplier[WhiteMage, $SkillEnergy] = 1.8;
$SkillMultiplier[WhiteMage, $SkillHaggling] = 1.0;
$EXPmultiplier[WhiteMage] = 1.25;

//--------------
// Black Mage
//--------------

$SkillMultiplier[BlackMage, $SkillSwords] = 0.8;
$SkillMultiplier[BlackMage, $SkillAxes] = 0.8;
$SkillMultiplier[BlackMage, $SkillHammers] = 0.5;
$SkillMultiplier[BlackMage, $SkillKatanas] = 0.2;
$SkillMultiplier[BlackMage, $SkillWeightCapacity] = 1.5;
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
$SkillMultiplier[BlackMage, $SkillEnergy] = 1.8;
$SkillMultiplier[BlackMage, $SkillHaggling] = 1.3;
$EXPmultiplier[BlackMage] = 1.25;

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
$SkillMultiplier[Monk, $SkillEnergy] = 0.7;
$SkillMultiplier[Monk, $SkillHaggling] = 0.7;
$EXPmultiplier[Monk] = 1.1;

//--------------
// Thief
//--------------

$SkillMultiplier[Thief, $SkillSwords] = 0.3;
$SkillMultiplier[Thief, $SkillAxes] = 0.8;
$SkillMultiplier[Thief, $SkillHammers] = 0.3;
$SkillMultiplier[Thief, $SkillKatanas] = 1.2;
$SkillMultiplier[Thief, $SkillWeightCapacity] = 0.6;
$SkillMultiplier[Thief, $SkillSpears] = 0.2;
$SkillMultiplier[Thief, $SkillStealing] = 2.0;
$SkillMultiplier[Thief, $SkillHiding] = 1.5;
$SkillMultiplier[Thief, $SkillBackstabbing] = 0.2;
$SkillMultiplier[Thief, $SkillBlackMagick] = 2.0;
$SkillMultiplier[Thief, $SkillWhiteMagick] = 1.0;
$SkillMultiplier[Thief, $SkillSummonMagick] = 1.8;
$SkillMultiplier[Thief, $SkillTimeMagick] = 1.5;
$SkillMultiplier[Thief, $SkillHealing] = 0.7;
$SkillMultiplier[Thief, $SkillBows] = 0.8;
$SkillMultiplier[Thief, $SkillEndurance] = 0.4;
$SkillMultiplier[Thief, $SkillMining] = 1.0;
$SkillMultiplier[Thief, $SkillMagicka] = 1.2;
$SkillMultiplier[Thief, $SkillEnergy] = 2.0;
$SkillMultiplier[Thief, $SkillHaggling] = 1.0;
$EXPmultiplier[Thief] = 1.1;

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
$SkillMultiplier[Mystic, $SkillEnergy] = 2.0;
$SkillMultiplier[Mystic, $SkillHaggling] = 1.0;
$EXPmultiplier[Mystic] = 1.1;

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
$SkillMultiplier[TimeMage, $SkillEnergy] = 2.0;
$SkillMultiplier[TimeMage, $SkillHaggling] = 1.0;
$EXPmultiplier[TimeMage] = 1.1;

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
$SkillMultiplier[Geomancer, $SkillEnergy] = 2.0;
$SkillMultiplier[Geomancer, $SkillHaggling] = 1.0;
$EXPmultiplier[Geomancer] = 1.0;

//--------------
// Dragoon
//--------------

$SkillMultiplier[Dragoon, $SkillSwords] = 0.3;
$SkillMultiplier[Dragoon, $SkillAxes] = 0.8;
$SkillMultiplier[Dragoon, $SkillHammers] = 0.3;
$SkillMultiplier[Dragoon, $SkillKatanas] = 1.2;
$SkillMultiplier[Dragoon, $SkillWeightCapacity] = 0.6;
$SkillMultiplier[Dragoon, $SkillSpears] = 0.2;
$SkillMultiplier[Dragoon, $SkillStealing] = 0.2;
$SkillMultiplier[Dragoon, $SkillHiding] = 0.2;
$SkillMultiplier[Dragoon, $SkillBackstabbing] = 0.2;
$SkillMultiplier[Dragoon, $SkillBlackMagick] = 2.0;
$SkillMultiplier[Dragoon, $SkillWhiteMagick] = 1.0;
$SkillMultiplier[Dragoon, $SkillSummonMagick] = 1.8;
$SkillMultiplier[Dragoon, $SkillTimeMagick] = 1.5;
$SkillMultiplier[Dragoon, $SkillHealing] = 0.7;
$SkillMultiplier[Dragoon, $SkillBows] = 0.8;
$SkillMultiplier[Dragoon, $SkillEndurance] = 0.4;
$SkillMultiplier[Dragoon, $SkillMining] = 1.0;
$SkillMultiplier[Dragoon, $SkillMagicka] = 1.2;
$SkillMultiplier[Dragoon, $SkillEnergy] = 2.0;
$SkillMultiplier[Dragoon, $SkillHaggling] = 1.0;
$EXPmultiplier[Dragoon] = 1.0;

//--------------
// Orator
//--------------

$SkillMultiplier[Orator, $SkillSwords] = 0.3;
$SkillMultiplier[Orator, $SkillAxes] = 0.8;
$SkillMultiplier[Orator, $SkillHammers] = 0.3;
$SkillMultiplier[Orator, $SkillKatanas] = 1.2;
$SkillMultiplier[Orator, $SkillWeightCapacity] = 0.6;
$SkillMultiplier[Orator, $SkillSpears] = 0.2;
$SkillMultiplier[Orator, $SkillStealing] = 0.2;
$SkillMultiplier[Orator, $SkillHiding] = 0.2;
$SkillMultiplier[Orator, $SkillBackstabbing] = 0.2;
$SkillMultiplier[Orator, $SkillBlackMagick] = 2.0;
$SkillMultiplier[Orator, $SkillWhiteMagick] = 1.0;
$SkillMultiplier[Orator, $SkillSummonMagick] = 1.8;
$SkillMultiplier[Orator, $SkillTimeMagick] = 1.5;
$SkillMultiplier[Orator, $SkillHealing] = 0.7;
$SkillMultiplier[Orator, $SkillBows] = 0.8;
$SkillMultiplier[Orator, $SkillEndurance] = 0.4;
$SkillMultiplier[Orator, $SkillMining] = 1.0;
$SkillMultiplier[Orator, $SkillMagicka] = 1.2;
$SkillMultiplier[Orator, $SkillEnergy] = 2.0;
$SkillMultiplier[Orator, $SkillHaggling] = 1.0;
$EXPmultiplier[Orator] = 1.0;

//--------------
// Summoner
//--------------

$SkillMultiplier[Summoner, $SkillSwords] = 0.3;
$SkillMultiplier[Summoner, $SkillAxes] = 0.8;
$SkillMultiplier[Summoner, $SkillHammers] = 0.3;
$SkillMultiplier[Summoner, $SkillKatanas] = 1.2;
$SkillMultiplier[Summoner, $SkillWeightCapacity] = 0.6;
$SkillMultiplier[Summoner, $SkillSpears] = 0.2;
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
$SkillMultiplier[Summoner, $SkillEnergy] = 2.0;
$SkillMultiplier[Summoner, $SkillHaggling] = 1.0;
$EXPmultiplier[Summoner] = 1.0;

//--------------
// Samurai
//--------------

$SkillMultiplier[Samurai, $SkillSwords] = 0.3;
$SkillMultiplier[Samurai, $SkillAxes] = 0.8;
$SkillMultiplier[Samurai, $SkillHammers] = 0.3;
$SkillMultiplier[Samurai, $SkillKatanas] = 1.2;
$SkillMultiplier[Samurai, $SkillWeightCapacity] = 0.6;
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
$SkillMultiplier[Samurai, $SkillEnergy] = 2.0;
$SkillMultiplier[Samurai, $SkillHaggling] = 1.0;
$EXPmultiplier[Samurai] = 0.9;

//--------------
// Ninja
//--------------

$SkillMultiplier[Ninja, $SkillSwords] = 0.3;
$SkillMultiplier[Ninja, $SkillAxes] = 0.8;
$SkillMultiplier[Ninja, $SkillHammers] = 0.3;
$SkillMultiplier[Ninja, $SkillKatanas] = 1.2;
$SkillMultiplier[Ninja, $SkillWeightCapacity] = 0.6;
$SkillMultiplier[Ninja, $SkillSpears] = 0.2;
$SkillMultiplier[Ninja, $SkillStealing] = 0.2;
$SkillMultiplier[Ninja, $SkillHiding] = 0.2;
$SkillMultiplier[Ninja, $SkillBackstabbing] = 0.2;
$SkillMultiplier[Ninja, $SkillBlackMagick] = 2.0;
$SkillMultiplier[Ninja, $SkillWhiteMagick] = 1.0;
$SkillMultiplier[Ninja, $SkillSummonMagick] = 1.8;
$SkillMultiplier[Ninja, $SkillTimeMagick] = 1.5;
$SkillMultiplier[Ninja, $SkillHealing] = 0.7;
$SkillMultiplier[Ninja, $SkillBows] = 0.8;
$SkillMultiplier[Ninja, $SkillEndurance] = 0.4;
$SkillMultiplier[Ninja, $SkillMining] = 1.0;
$SkillMultiplier[Ninja, $SkillMagicka] = 1.2;
$SkillMultiplier[Ninja, $SkillEnergy] = 2.0;
$SkillMultiplier[Ninja, $SkillHaggling] = 1.0;
$EXPmultiplier[Ninja] = 0.9;

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
$SkillMultiplier[Dancer, $SkillBlackMagick] = 2.0;
$SkillMultiplier[Dancer, $SkillWhiteMagick] = 1.0;
$SkillMultiplier[Dancer, $SkillSummonMagick] = 1.8;
$SkillMultiplier[Dancer, $SkillTimeMagick] = 1.5;
$SkillMultiplier[Dancer, $SkillHealing] = 0.7;
$SkillMultiplier[Dancer, $SkillBows] = 0.8;
$SkillMultiplier[Dancer, $SkillEndurance] = 0.4;
$SkillMultiplier[Dancer, $SkillMining] = 1.0;
$SkillMultiplier[Dancer, $SkillMagicka] = 1.2;
$SkillMultiplier[Dancer, $SkillEnergy] = 2.0;
$SkillMultiplier[Dancer, $SkillHaggling] = 1.0;
$EXPmultiplier[Dancer] = 0.9;

//--------------
// Arithmetician
//--------------

$SkillMultiplier[Arithmetician, $SkillSwords] = 0.3;
$SkillMultiplier[Arithmetician, $SkillAxes] = 0.8;
$SkillMultiplier[Arithmetician, $SkillHammers] = 0.3;
$SkillMultiplier[Arithmetician, $SkillKatanas] = 1.2;
$SkillMultiplier[Arithmetician, $SkillWeightCapacity] = 0.6;
$SkillMultiplier[Arithmetician, $SkillSpears] = 0.2;
$SkillMultiplier[Arithmetician, $SkillStealing] = 0.2;
$SkillMultiplier[Arithmetician, $SkillHiding] = 0.2;
$SkillMultiplier[Arithmetician, $SkillBackstabbing] = 0.2;
$SkillMultiplier[Arithmetician, $SkillBlackMagick] = 2.0;
$SkillMultiplier[Arithmetician, $SkillWhiteMagick] = 1.0;
$SkillMultiplier[Arithmetician, $SkillSummonMagick] = 1.8;
$SkillMultiplier[Arithmetician, $SkillTimeMagick] = 1.5;
$SkillMultiplier[Arithmetician, $SkillHealing] = 0.7;
$SkillMultiplier[Arithmetician, $SkillBows] = 0.8;
$SkillMultiplier[Arithmetician, $SkillEndurance] = 0.4;
$SkillMultiplier[Arithmetician, $SkillMining] = 1.0;
$SkillMultiplier[Arithmetician, $SkillMagicka] = 1.2;
$SkillMultiplier[Arithmetician, $SkillEnergy] = 2.0;
$SkillMultiplier[Arithmetician, $SkillHaggling] = 1.0;
$EXPmultiplier[Arithmetician] = 0.9;

//--------------
// HolyKnight
//--------------

$SkillMultiplier[HolyKnight, $SkillSwords] = 0.3;
$SkillMultiplier[HolyKnight, $SkillAxes] = 0.8;
$SkillMultiplier[HolyKnight, $SkillHammers] = 0.3;
$SkillMultiplier[HolyKnight, $SkillKatanas] = 1.2;
$SkillMultiplier[HolyKnight, $SkillWeightCapacity] = 0.6;
$SkillMultiplier[HolyKnight, $SkillSpears] = 0.2;
$SkillMultiplier[HolyKnight, $SkillStealing] = 0.2;
$SkillMultiplier[HolyKnight, $SkillHiding] = 0.2;
$SkillMultiplier[HolyKnight, $SkillBackstabbing] = 0.2;
$SkillMultiplier[HolyKnight, $SkillBlackMagick] = 2.0;
$SkillMultiplier[HolyKnight, $SkillWhiteMagick] = 1.0;
$SkillMultiplier[HolyKnight, $SkillSummonMagick] = 1.8;
$SkillMultiplier[HolyKnight, $SkillTimeMagick] = 1.5;
$SkillMultiplier[HolyKnight, $SkillHealing] = 0.7;
$SkillMultiplier[HolyKnight, $SkillBows] = 0.8;
$SkillMultiplier[HolyKnight, $SkillEndurance] = 0.4;
$SkillMultiplier[HolyKnight, $SkillMining] = 1.0;
$SkillMultiplier[HolyKnight, $SkillMagicka] = 1.2;
$SkillMultiplier[HolyKnight, $SkillEnergy] = 2.0;
$SkillMultiplier[HolyKnight, $SkillHaggling] = 1.0;
$EXPmultiplier[HolyKnight] = 0.8;

//--------------
// DarkKnight
//--------------

$SkillMultiplier[DarkKnight, $SkillSwords] = 0.3;
$SkillMultiplier[DarkKnight, $SkillAxes] = 0.8;
$SkillMultiplier[DarkKnight, $SkillHammers] = 0.3;
$SkillMultiplier[DarkKnight, $SkillKatanas] = 1.2;
$SkillMultiplier[DarkKnight, $SkillWeightCapacity] = 0.6;
$SkillMultiplier[DarkKnight, $SkillSpears] = 0.2;
$SkillMultiplier[DarkKnight, $SkillStealing] = 0.2;
$SkillMultiplier[DarkKnight, $SkillHiding] = 0.2;
$SkillMultiplier[DarkKnight, $SkillBackstabbing] = 0.2;
$SkillMultiplier[DarkKnight, $SkillBlackMagick] = 2.0;
$SkillMultiplier[DarkKnight, $SkillWhiteMagick] = 1.0;
$SkillMultiplier[DarkKnight, $SkillSummonMagick] = 1.8;
$SkillMultiplier[DarkKnight, $SkillTimeMagick] = 1.5;
$SkillMultiplier[DarkKnight, $SkillHealing] = 0.7;
$SkillMultiplier[DarkKnight, $SkillBows] = 0.8;
$SkillMultiplier[DarkKnight, $SkillEndurance] = 0.4;
$SkillMultiplier[DarkKnight, $SkillMining] = 1.0;
$SkillMultiplier[DarkKnight, $SkillMagicka] = 1.2;
$SkillMultiplier[DarkKnight, $SkillEnergy] = 2.0;
$SkillMultiplier[DarkKnight, $SkillHaggling] = 1.0;
$EXPmultiplier[DarkKnight] = 0.8;

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
$SkillMultiplier[Ancient, $SkillEnergy] = 2.0;
$SkillMultiplier[Ancient, $SkillHaggling] = 1.0;
$EXPmultiplier[Ancient] = 0.8;

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
$SkillMultiplier[HighSummoner, $SkillEnergy] = 2.0;
$SkillMultiplier[HighSummoner, $SkillHaggling] = 1.0;
$EXPmultiplier[HighSummoner] = 0.8;

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
$SkillMultiplier[OnionKnight, $SkillEnergy] = 2.0;
$SkillMultiplier[OnionKnight, $SkillHaggling] = 2.0;
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
$SkillMultiplier[Kefka, $SkillEnergy] = 2.0;
$SkillMultiplier[Kefka, $SkillHaggling] = 2.0;
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
$SkillMultiplier[Soldier, $SkillEnergy] = 2.0;
$SkillMultiplier[Soldier, $SkillHaggling] = 2.0;
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
$SkillMultiplier[ExSoldier, $SkillEnergy] = 2.0;
$SkillMultiplier[ExSoldier, $SkillHaggling] = 2.0;
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
// $SkillRestriction[ApprenticeRobe] = $SkillEndurance @ " 0 " @ $SkillEnergy @ " 8";
// $SkillRestriction[LightRobe] = $SkillEndurance @ " 3 " @ $SkillEnergy @ " 80";
// $SkillRestriction[FineRobe] = $SkillEndurance @ " 9 " @ $SkillEnergy @ " 175";
// $SkillRestriction[BloodRobe] = $SkillEndurance @ " 8 " @ $SkillEnergy @ " 300";
// $SkillRestriction[AdvisorRobe] = $SkillEndurance @ " 10 " @ $SkillEnergy @ " 450";
// $SkillRestriction[ElvenRobe] = $SkillEndurance @ " 12 " @ $SkillEnergy @ " 620";
// $SkillRestriction[RobeOfVenjance] = $SkillEndurance @ " 18 " @ $SkillEnergy @ " 800";
// $SkillRestriction[PhensRobe] = $SkillEndurance @ " 20 " @ $SkillEnergy @ " 980";
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
$SkillRestriction[HeavenlyShield] = $SkillEndurance @ " 540 " @ $SkillEnergy @ " 850";
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
$SkillRestriction[remort] = $SkillTimeMagick @ " 0 " @ $MinLevel @ " 101";
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
$SkillRestriction[shadowblade] = "C DarkKnight L 50";

//######################################################################################
// Skill functions
//######################################################################################

function GetNumSkills()
{
	dbecho($dbechoMode, "GetNumSkills()");

	for(%i = 1; $SkillDesc[%i] != ""; %i++){}
	return %i-1;
}

function AddSkillPoint(%clientId, %skill, %delta)
{
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
				%flag = 1;
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
			if(String::ICompare(fetchData(%clientId, "CLASS"), %n) == 0)
				%gc = 1;
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
