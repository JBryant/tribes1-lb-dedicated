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


//######################################################################################
// Skills
//######################################################################################

$SkillSlashing = 1;           // SkillSwords
$SkillPiercing = 2;           //
$SkillBludgeoning = 3;
$SkillDodging = 4;
$SkillWeightCapacity = 5;
$SkillBashing = 6;
$SkillStealing = 7;
$SkillHiding = 8;              // get rid of this?
$SkillBackstabbing = 9;        // get rid of this?
$SkillOffensiveCasting = 10;   // black magic
$SkillDefensiveCasting = 11;   // white magic
$SkillSpellResistance = 12;    // get rid of this?
$SkillHealing = 13;            // get rid of this?
$SkillArchery = 14;            
$SkillEndurance = 15;          // keep this?
$SkillMining = 17;             // keep this
$SkillSpeech = 18;             // get rid  of this
$SkillSenseHeading = 19;       // get rid of this
$SkillEnergy = 20;             
$SkillHaggling = 21;           // keep this?
$SkillNeutralCasting = 22;     // time magic
// New Skills

// Min Data
$MinLevel = "L";
$MinGroup = "G";
$MinClass = "C";
$MinRemort = "R";
$MinAdmin = "A";
$MinHouse = "H";

$SkillDesc[1] = "Slashing";
$SkillDesc[2] = "Piercing";
$SkillDesc[3] = "Bludgeoning";
$SkillDesc[4] = "Dodging";
$SkillDesc[5] = "Weight Capacity";
$SkillDesc[6] = "Bashing";
$SkillDesc[7] = "Stealing";
$SkillDesc[8] = "Hiding";
$SkillDesc[9] = "Backstabbing";
$SkillDesc[10] = "Offensive Casting";
$SkillDesc[11] = "Defensive Casting";
$SkillDesc[12] = "Spell Resistance";
$SkillDesc[13] = "Healing";
$SkillDesc[14] = "Archery";
$SkillDesc[15] = "Endurance";
$SkillDesc[16] = "(no longer used)";
$SkillDesc[17] = "Mining";
$SkillDesc[18] = "Speech";
$SkillDesc[19] = "Sense Heading";
$SkillDesc[20] = "Energy";
$SkillDesc[21] = "Haggling";
$SkillDesc[22] = "Neutral Casting";
$SkillDesc[L] = "Level";
$SkillDesc[G] = "Group";
$SkillDesc[C] = "Class";
$SkillDesc[R] = "Remort";
$SkillDesc[A] = "Admin Level";
$SkillDesc[H] = "House";

// Squire
//--------------
// 

$SkillMultiplier[Squire, $SkillSlashing] = 0.6;
$SkillMultiplier[Squire, $SkillPiercing] = 0.7;
$SkillMultiplier[Squire, $SkillBludgeoning] = 1.5;
$SkillMultiplier[Squire, $SkillDodging] = 0.7;
$SkillMultiplier[Squire, $SkillWeightCapacity] = 1.0;
$SkillMultiplier[Squire, $SkillBashing] = 0.5;
$SkillMultiplier[Squire, $SkillStealing] = 0.2;
$SkillMultiplier[Squire, $SkillHiding] = 0.2;
$SkillMultiplier[Squire, $SkillBackstabbing] = 0.2;
$SkillMultiplier[Squire, $SkillOffensiveCasting] = 0.9;
$SkillMultiplier[Squire, $SkillDefensiveCasting] = 2.0;
$SkillMultiplier[Squire, $SkillNeutralCasting] = 1.2;
$SkillMultiplier[Squire, $SkillSpellResistance] = 1.5;
$SkillMultiplier[Squire, $SkillHealing] = 2.0;
$SkillMultiplier[Squire, $SkillArchery] = 0.5;
$SkillMultiplier[Squire, $SkillEndurance] = 1.1;
$SkillMultiplier[Squire, $SkillMining] = 1.0;
$SkillMultiplier[Squire, $SkillSpeech] = 1.0;
$SkillMultiplier[Squire, $SkillSenseHeading] = 1.0;
$SkillMultiplier[Squire, $SkillEnergy] = 1.5;
$SkillMultiplier[Squire, $SkillHaggling] = 1.0;
$EXPmultiplier[Squire] = 1.5;

//--------------
// Chemist
//--------------
// Starter caster

$SkillMultiplier[Chemist, $SkillSlashing] = 1.5;
$SkillMultiplier[Chemist, $SkillPiercing] = 0.7;
$SkillMultiplier[Chemist, $SkillBludgeoning] = 0.6;
$SkillMultiplier[Chemist, $SkillDodging] = 2.0;
$SkillMultiplier[Chemist, $SkillWeightCapacity] = 2.0;
$SkillMultiplier[Chemist, $SkillBashing] = 0.5;
$SkillMultiplier[Chemist, $SkillStealing] = 0.2;
$SkillMultiplier[Chemist, $SkillHiding] = 2.0;
$SkillMultiplier[Chemist, $SkillBackstabbing] = 0.5;
$SkillMultiplier[Chemist, $SkillOffensiveCasting] = 0.7;
$SkillMultiplier[Chemist, $SkillDefensiveCasting] = 0.7;
$SkillMultiplier[Chemist, $SkillNeutralCasting] = 2.0;
$SkillMultiplier[Chemist, $SkillSpellResistance] = 1.0;
$SkillMultiplier[Chemist, $SkillHealing] = 1.3;
$SkillMultiplier[Chemist, $SkillArchery] = 0.7;
$SkillMultiplier[Chemist, $SkillEndurance] = 0.8;
$SkillMultiplier[Chemist, $SkillMining] = 2.0;
$SkillMultiplier[Chemist, $SkillSpeech] = 1.0;
$SkillMultiplier[Chemist, $SkillSenseHeading] = 1.7;
$SkillMultiplier[Chemist, $SkillEnergy] = 1.2;
$SkillMultiplier[Chemist, $SkillHaggling] = 1.3;
$EXPmultiplier[Chemist] = 1.5;

//--------------
// Knight
//--------------
//

$SkillMultiplier[Knight, $SkillSlashing] = 0.6;
$SkillMultiplier[Knight, $SkillPiercing] = 1.8;
$SkillMultiplier[Knight, $SkillBludgeoning] = 0.5;
$SkillMultiplier[Knight, $SkillDodging] = 1.1;
$SkillMultiplier[Knight, $SkillWeightCapacity] = 0.7;
$SkillMultiplier[Knight, $SkillBashing] = 0.2;
$SkillMultiplier[Knight, $SkillStealing] = 2.0;
$SkillMultiplier[Knight, $SkillHiding] = 2.0;
$SkillMultiplier[Knight, $SkillBackstabbing] = 2.0;
$SkillMultiplier[Knight, $SkillOffensiveCasting] = 0.2;
$SkillMultiplier[Knight, $SkillDefensiveCasting] = 0.2;
$SkillMultiplier[Knight, $SkillNeutralCasting] = 0.2;
$SkillMultiplier[Knight, $SkillSpellResistance] = 0.3;
$SkillMultiplier[Knight, $SkillHealing] = 0.5;
$SkillMultiplier[Knight, $SkillArchery] = 1.6;
$SkillMultiplier[Knight, $SkillEndurance] = 1.0;
$SkillMultiplier[Knight, $SkillMining] = 1.0;
$SkillMultiplier[Knight, $SkillSpeech] = 1.0;
$SkillMultiplier[Knight, $SkillSenseHeading] = 1.0;
$SkillMultiplier[Knight, $SkillEnergy] = 0.5;
$SkillMultiplier[Knight, $SkillHaggling] = 1.5;
$EXPmultiplier[Knight] = 1.25;

//--------------
// Archer
//--------------

$SkillMultiplier[Archer, $SkillSlashing] = 1.3;
$SkillMultiplier[Archer, $SkillPiercing] = 1.5;
$SkillMultiplier[Archer, $SkillBludgeoning] = 1.3;
$SkillMultiplier[Archer, $SkillDodging] = 2.0;
$SkillMultiplier[Archer, $SkillWeightCapacity] = 0.8;
$SkillMultiplier[Archer, $SkillBashing] = 0.2;
$SkillMultiplier[Archer, $SkillStealing] = 2.0;
$SkillMultiplier[Archer, $SkillHiding] = 1.8;
$SkillMultiplier[Archer, $SkillBackstabbing] = 1.8;
$SkillMultiplier[Archer, $SkillOffensiveCasting] = 0.3;
$SkillMultiplier[Archer, $SkillDefensiveCasting] = 0.3;
$SkillMultiplier[Archer, $SkillNeutralCasting] = 0.5;
$SkillMultiplier[Archer, $SkillSpellResistance] = 0.5;
$SkillMultiplier[Archer, $SkillHealing] = 2.0;
$SkillMultiplier[Archer, $SkillArchery] = 1.4;
$SkillMultiplier[Archer, $SkillEndurance] = 2.0;
$SkillMultiplier[Archer, $SkillMining] = 2.0;
$SkillMultiplier[Archer, $SkillSpeech] = 1.0;
$SkillMultiplier[Archer, $SkillSenseHeading] = 1.5;
$SkillMultiplier[Archer, $SkillEnergy] = 0.6;
$SkillMultiplier[Archer, $SkillHaggling] = 2.0;
$EXPmultiplier[Archer] = 1.25;

//--------------
// White Mage
//--------------

$SkillMultiplier[WhiteMage, $SkillSlashing] = 2.0;
$SkillMultiplier[WhiteMage, $SkillPiercing] = 2.0;
$SkillMultiplier[WhiteMage, $SkillBludgeoning] = 2.0;
$SkillMultiplier[WhiteMage, $SkillDodging] = 1.5;
$SkillMultiplier[WhiteMage, $SkillWeightCapacity] = 1.5;
$SkillMultiplier[WhiteMage, $SkillBashing] = 1.6;
$SkillMultiplier[WhiteMage, $SkillStealing] = 0.2;
$SkillMultiplier[WhiteMage, $SkillHiding] = 0.2;
$SkillMultiplier[WhiteMage, $SkillBackstabbing] = 0.2;
$SkillMultiplier[WhiteMage, $SkillOffensiveCasting] = 0.1;
$SkillMultiplier[WhiteMage, $SkillDefensiveCasting] = 0.1;
$SkillMultiplier[WhiteMage, $SkillNeutralCasting] = 0.1;
$SkillMultiplier[WhiteMage, $SkillSpellResistance] = 0.2;
$SkillMultiplier[WhiteMage, $SkillHealing] = 1.2;
$SkillMultiplier[WhiteMage, $SkillArchery] = 1.6;
$SkillMultiplier[WhiteMage, $SkillEndurance] = 1.6;
$SkillMultiplier[WhiteMage, $SkillMining] = 1.0;
$SkillMultiplier[WhiteMage, $SkillSpeech] = 0.8;
$SkillMultiplier[WhiteMage, $SkillSenseHeading] = 0.4;
$SkillMultiplier[WhiteMage, $SkillEnergy] = 0.2;
$SkillMultiplier[WhiteMage, $SkillHaggling] = 1.0;
$EXPmultiplier[WhiteMage] = 1.25;

//--------------
// Black Mage
//--------------

$SkillMultiplier[BlackMage, $SkillPiercing] = 1.5;
$SkillMultiplier[BlackMage, $SkillSlashing] = 1.5;
$SkillMultiplier[BlackMage, $SkillBludgeoning] = 1.2;
$SkillMultiplier[BlackMage, $SkillDodging] = 1.5;
$SkillMultiplier[BlackMage, $SkillWeightCapacity] = 1.5;
$SkillMultiplier[BlackMage, $SkillBashing] = 1.5;
$SkillMultiplier[BlackMage, $SkillStealing] = 0.3;
$SkillMultiplier[BlackMage, $SkillHiding] = 0.3;
$SkillMultiplier[BlackMage, $SkillBackstabbing] = 0.3;
$SkillMultiplier[BlackMage, $SkillOffensiveCasting] = 0.2;
$SkillMultiplier[BlackMage, $SkillDefensiveCasting] = 1.2;
$SkillMultiplier[BlackMage, $SkillNeutralCasting] = 0.3;
$SkillMultiplier[BlackMage, $SkillSpellResistance] = 0.9;
$SkillMultiplier[BlackMage, $SkillHealing] = 1.3;
$SkillMultiplier[BlackMage, $SkillArchery] = 1.2;
$SkillMultiplier[BlackMage, $SkillEndurance] = 1.5;
$SkillMultiplier[BlackMage, $SkillMining] = 1.0;
$SkillMultiplier[BlackMage, $SkillSpeech] = 0.8;
$SkillMultiplier[BlackMage, $SkillSenseHeading] = 0.5;
$SkillMultiplier[BlackMage, $SkillEnergy] = 0.9;
$SkillMultiplier[BlackMage, $SkillHaggling] = 1.3;
$EXPmultiplier[BlackMage] = 1.25;

//--------------
// Monk
//--------------

$SkillMultiplier[Monk, $SkillSlashing] = 1.2;
$SkillMultiplier[Monk, $SkillPiercing] = 1.1;
$SkillMultiplier[Monk, $SkillBludgeoning] = 1.2;
$SkillMultiplier[Monk, $SkillDodging] = 1.8;
$SkillMultiplier[Monk, $SkillWeightCapacity] = 1.0;
$SkillMultiplier[Monk, $SkillBashing] = 0.9;
$SkillMultiplier[Monk, $SkillStealing] = 0.5;
$SkillMultiplier[Monk, $SkillHiding] = 1.0;
$SkillMultiplier[Monk, $SkillBackstabbing] = 0.4;
$SkillMultiplier[Monk, $SkillOffensiveCasting] = 0.2;
$SkillMultiplier[Monk, $SkillDefensiveCasting] = 0.4;
$SkillMultiplier[Monk, $SkillNeutralCasting] = 0.3;
$SkillMultiplier[Monk, $SkillSpellResistance] = 0.2;
$SkillMultiplier[Monk, $SkillHealing] = 0.8;
$SkillMultiplier[Monk, $SkillArchery] = 2.0;
$SkillMultiplier[Monk, $SkillEndurance] = 1.2;
$SkillMultiplier[Monk, $SkillMining] = 1.0;
$SkillMultiplier[Monk, $SkillSpeech] = 1.0;
$SkillMultiplier[Monk, $SkillSenseHeading] = 2.0;
$SkillMultiplier[Monk, $SkillEnergy] = 0.7;
$SkillMultiplier[Monk, $SkillHaggling] = 0.7;
$EXPmultiplier[Monk] = 1.1;

//--------------
// Thief
//--------------

$SkillMultiplier[Thief, $SkillSlashing] = 0.3;
$SkillMultiplier[Thief, $SkillPiercing] = 0.8;
$SkillMultiplier[Thief, $SkillBludgeoning] = 0.3;
$SkillMultiplier[Thief, $SkillDodging] = 1.2;
$SkillMultiplier[Thief, $SkillWeightCapacity] = 0.6;
$SkillMultiplier[Thief, $SkillBashing] = 0.2;
$SkillMultiplier[Thief, $SkillStealing] = 0.2;
$SkillMultiplier[Thief, $SkillHiding] = 0.2;
$SkillMultiplier[Thief, $SkillBackstabbing] = 0.2;
$SkillMultiplier[Thief, $SkillOffensiveCasting] = 2.0;
$SkillMultiplier[Thief, $SkillDefensiveCasting] = 1.0;
$SkillMultiplier[Thief, $SkillNeutralCasting] = 1.8;
$SkillMultiplier[Thief, $SkillSpellResistance] = 1.5;
$SkillMultiplier[Thief, $SkillHealing] = 0.7;
$SkillMultiplier[Thief, $SkillArchery] = 0.8;
$SkillMultiplier[Thief, $SkillEndurance] = 0.4;
$SkillMultiplier[Thief, $SkillMining] = 1.0;
$SkillMultiplier[Thief, $SkillSpeech] = 1.2;
$SkillMultiplier[Thief, $SkillSenseHeading] = 0.7;
$SkillMultiplier[Thief, $SkillEnergy] = 2.0;
$SkillMultiplier[Thief, $SkillHaggling] = 1.0;
$EXPmultiplier[Thief] = 1.1;

//--------------
// Mystic
//--------------

$SkillMultiplier[Mystic, $SkillSlashing] = 0.3;
$SkillMultiplier[Mystic, $SkillPiercing] = 0.8;
$SkillMultiplier[Mystic, $SkillBludgeoning] = 0.3;
$SkillMultiplier[Mystic, $SkillDodging] = 1.2;
$SkillMultiplier[Mystic, $SkillWeightCapacity] = 0.6;
$SkillMultiplier[Mystic, $SkillBashing] = 0.2;
$SkillMultiplier[Mystic, $SkillStealing] = 0.2;
$SkillMultiplier[Mystic, $SkillHiding] = 0.2;
$SkillMultiplier[Mystic, $SkillBackstabbing] = 0.2;
$SkillMultiplier[Mystic, $SkillOffensiveCasting] = 2.0;
$SkillMultiplier[Mystic, $SkillDefensiveCasting] = 1.0;
$SkillMultiplier[Mystic, $SkillNeutralCasting] = 1.8;
$SkillMultiplier[Mystic, $SkillSpellResistance] = 1.5;
$SkillMultiplier[Mystic, $SkillHealing] = 0.7;
$SkillMultiplier[Mystic, $SkillArchery] = 0.8;
$SkillMultiplier[Mystic, $SkillEndurance] = 0.4;
$SkillMultiplier[Mystic, $SkillMining] = 1.0;
$SkillMultiplier[Mystic, $SkillSpeech] = 1.2;
$SkillMultiplier[Mystic, $SkillSenseHeading] = 0.7;
$SkillMultiplier[Mystic, $SkillEnergy] = 2.0;
$SkillMultiplier[Mystic, $SkillHaggling] = 1.0;
$EXPmultiplier[Mystic] = 1.1;

//--------------
// Mystic
//--------------

$SkillMultiplier[TimeMage, $SkillSlashing] = 0.3;
$SkillMultiplier[TimeMage, $SkillPiercing] = 0.8;
$SkillMultiplier[TimeMage, $SkillBludgeoning] = 0.3;
$SkillMultiplier[TimeMage, $SkillDodging] = 1.2;
$SkillMultiplier[TimeMage, $SkillWeightCapacity] = 0.6;
$SkillMultiplier[TimeMage, $SkillBashing] = 0.2;
$SkillMultiplier[TimeMage, $SkillStealing] = 0.2;
$SkillMultiplier[TimeMage, $SkillHiding] = 0.2;
$SkillMultiplier[TimeMage, $SkillBackstabbing] = 0.2;
$SkillMultiplier[TimeMage, $SkillOffensiveCasting] = 2.0;
$SkillMultiplier[TimeMage, $SkillDefensiveCasting] = 1.0;
$SkillMultiplier[TimeMage, $SkillNeutralCasting] = 1.8;
$SkillMultiplier[TimeMage, $SkillSpellResistance] = 1.5;
$SkillMultiplier[TimeMage, $SkillHealing] = 0.7;
$SkillMultiplier[TimeMage, $SkillArchery] = 0.8;
$SkillMultiplier[TimeMage, $SkillEndurance] = 0.4;
$SkillMultiplier[TimeMage, $SkillMining] = 1.0;
$SkillMultiplier[TimeMage, $SkillSpeech] = 1.2;
$SkillMultiplier[TimeMage, $SkillSenseHeading] = 0.7;
$SkillMultiplier[TimeMage, $SkillEnergy] = 2.0;
$SkillMultiplier[TimeMage, $SkillHaggling] = 1.0;
$EXPmultiplier[TimeMage] = 1.1;

//--------------
// Geomancer
//--------------

$SkillMultiplier[Geomancer, $SkillSlashing] = 0.3;
$SkillMultiplier[Geomancer, $SkillPiercing] = 0.8;
$SkillMultiplier[Geomancer, $SkillBludgeoning] = 0.3;
$SkillMultiplier[Geomancer, $SkillDodging] = 1.2;
$SkillMultiplier[Geomancer, $SkillWeightCapacity] = 0.6;
$SkillMultiplier[Geomancer, $SkillBashing] = 0.2;
$SkillMultiplier[Geomancer, $SkillStealing] = 0.2;
$SkillMultiplier[Geomancer, $SkillHiding] = 0.2;
$SkillMultiplier[Geomancer, $SkillBackstabbing] = 0.2;
$SkillMultiplier[Geomancer, $SkillOffensiveCasting] = 2.0;
$SkillMultiplier[Geomancer, $SkillDefensiveCasting] = 1.0;
$SkillMultiplier[Geomancer, $SkillNeutralCasting] = 1.8;
$SkillMultiplier[Geomancer, $SkillSpellResistance] = 1.5;
$SkillMultiplier[Geomancer, $SkillHealing] = 0.7;
$SkillMultiplier[Geomancer, $SkillArchery] = 0.8;
$SkillMultiplier[Geomancer, $SkillEndurance] = 0.4;
$SkillMultiplier[Geomancer, $SkillMining] = 1.0;
$SkillMultiplier[Geomancer, $SkillSpeech] = 1.2;
$SkillMultiplier[Geomancer, $SkillSenseHeading] = 0.7;
$SkillMultiplier[Geomancer, $SkillEnergy] = 2.0;
$SkillMultiplier[Geomancer, $SkillHaggling] = 1.0;
$EXPmultiplier[Geomancer] = 1.0;

//--------------
// Dragoon
//--------------

$SkillMultiplier[Dragoon, $SkillSlashing] = 0.3;
$SkillMultiplier[Dragoon, $SkillPiercing] = 0.8;
$SkillMultiplier[Dragoon, $SkillBludgeoning] = 0.3;
$SkillMultiplier[Dragoon, $SkillDodging] = 1.2;
$SkillMultiplier[Dragoon, $SkillWeightCapacity] = 0.6;
$SkillMultiplier[Dragoon, $SkillBashing] = 0.2;
$SkillMultiplier[Dragoon, $SkillStealing] = 0.2;
$SkillMultiplier[Dragoon, $SkillHiding] = 0.2;
$SkillMultiplier[Dragoon, $SkillBackstabbing] = 0.2;
$SkillMultiplier[Dragoon, $SkillOffensiveCasting] = 2.0;
$SkillMultiplier[Dragoon, $SkillDefensiveCasting] = 1.0;
$SkillMultiplier[Dragoon, $SkillNeutralCasting] = 1.8;
$SkillMultiplier[Dragoon, $SkillSpellResistance] = 1.5;
$SkillMultiplier[Dragoon, $SkillHealing] = 0.7;
$SkillMultiplier[Dragoon, $SkillArchery] = 0.8;
$SkillMultiplier[Dragoon, $SkillEndurance] = 0.4;
$SkillMultiplier[Dragoon, $SkillMining] = 1.0;
$SkillMultiplier[Dragoon, $SkillSpeech] = 1.2;
$SkillMultiplier[Dragoon, $SkillSenseHeading] = 0.7;
$SkillMultiplier[Dragoon, $SkillEnergy] = 2.0;
$SkillMultiplier[Dragoon, $SkillHaggling] = 1.0;
$EXPmultiplier[Dragoon] = 1.0;

//--------------
// Orator
//--------------

$SkillMultiplier[Orator, $SkillSlashing] = 0.3;
$SkillMultiplier[Orator, $SkillPiercing] = 0.8;
$SkillMultiplier[Orator, $SkillBludgeoning] = 0.3;
$SkillMultiplier[Orator, $SkillDodging] = 1.2;
$SkillMultiplier[Orator, $SkillWeightCapacity] = 0.6;
$SkillMultiplier[Orator, $SkillBashing] = 0.2;
$SkillMultiplier[Orator, $SkillStealing] = 0.2;
$SkillMultiplier[Orator, $SkillHiding] = 0.2;
$SkillMultiplier[Orator, $SkillBackstabbing] = 0.2;
$SkillMultiplier[Orator, $SkillOffensiveCasting] = 2.0;
$SkillMultiplier[Orator, $SkillDefensiveCasting] = 1.0;
$SkillMultiplier[Orator, $SkillNeutralCasting] = 1.8;
$SkillMultiplier[Orator, $SkillSpellResistance] = 1.5;
$SkillMultiplier[Orator, $SkillHealing] = 0.7;
$SkillMultiplier[Orator, $SkillArchery] = 0.8;
$SkillMultiplier[Orator, $SkillEndurance] = 0.4;
$SkillMultiplier[Orator, $SkillMining] = 1.0;
$SkillMultiplier[Orator, $SkillSpeech] = 1.2;
$SkillMultiplier[Orator, $SkillSenseHeading] = 0.7;
$SkillMultiplier[Orator, $SkillEnergy] = 2.0;
$SkillMultiplier[Orator, $SkillHaggling] = 1.0;
$EXPmultiplier[Orator] = 1.0;

//--------------
// Summoner
//--------------

$SkillMultiplier[Summoner, $SkillSlashing] = 0.3;
$SkillMultiplier[Summoner, $SkillPiercing] = 0.8;
$SkillMultiplier[Summoner, $SkillBludgeoning] = 0.3;
$SkillMultiplier[Summoner, $SkillDodging] = 1.2;
$SkillMultiplier[Summoner, $SkillWeightCapacity] = 0.6;
$SkillMultiplier[Summoner, $SkillBashing] = 0.2;
$SkillMultiplier[Summoner, $SkillStealing] = 0.2;
$SkillMultiplier[Summoner, $SkillHiding] = 0.2;
$SkillMultiplier[Summoner, $SkillBackstabbing] = 0.2;
$SkillMultiplier[Summoner, $SkillOffensiveCasting] = 2.0;
$SkillMultiplier[Summoner, $SkillDefensiveCasting] = 1.0;
$SkillMultiplier[Summoner, $SkillNeutralCasting] = 1.8;
$SkillMultiplier[Summoner, $SkillSpellResistance] = 1.5;
$SkillMultiplier[Summoner, $SkillHealing] = 0.7;
$SkillMultiplier[Summoner, $SkillArchery] = 0.8;
$SkillMultiplier[Summoner, $SkillEndurance] = 0.4;
$SkillMultiplier[Summoner, $SkillMining] = 1.0;
$SkillMultiplier[Summoner, $SkillSpeech] = 1.2;
$SkillMultiplier[Summoner, $SkillSenseHeading] = 0.7;
$SkillMultiplier[Summoner, $SkillEnergy] = 2.0;
$SkillMultiplier[Summoner, $SkillHaggling] = 1.0;
$EXPmultiplier[Summoner] = 1.0;

//--------------
// Samurai
//--------------

$SkillMultiplier[Samurai, $SkillSlashing] = 0.3;
$SkillMultiplier[Samurai, $SkillPiercing] = 0.8;
$SkillMultiplier[Samurai, $SkillBludgeoning] = 0.3;
$SkillMultiplier[Samurai, $SkillDodging] = 1.2;
$SkillMultiplier[Samurai, $SkillWeightCapacity] = 0.6;
$SkillMultiplier[Samurai, $SkillBashing] = 0.2;
$SkillMultiplier[Samurai, $SkillStealing] = 0.2;
$SkillMultiplier[Samurai, $SkillHiding] = 0.2;
$SkillMultiplier[Samurai, $SkillBackstabbing] = 0.2;
$SkillMultiplier[Samurai, $SkillOffensiveCasting] = 2.0;
$SkillMultiplier[Samurai, $SkillDefensiveCasting] = 1.0;
$SkillMultiplier[Samurai, $SkillNeutralCasting] = 1.8;
$SkillMultiplier[Samurai, $SkillSpellResistance] = 1.5;
$SkillMultiplier[Samurai, $SkillHealing] = 0.7;
$SkillMultiplier[Samurai, $SkillArchery] = 0.8;
$SkillMultiplier[Samurai, $SkillEndurance] = 0.4;
$SkillMultiplier[Samurai, $SkillMining] = 1.0;
$SkillMultiplier[Samurai, $SkillSpeech] = 1.2;
$SkillMultiplier[Samurai, $SkillSenseHeading] = 0.7;
$SkillMultiplier[Samurai, $SkillEnergy] = 2.0;
$SkillMultiplier[Samurai, $SkillHaggling] = 1.0;
$EXPmultiplier[Samurai] = 0.9;

//--------------
// Ninja
//--------------

$SkillMultiplier[Ninja, $SkillSlashing] = 0.3;
$SkillMultiplier[Ninja, $SkillPiercing] = 0.8;
$SkillMultiplier[Ninja, $SkillBludgeoning] = 0.3;
$SkillMultiplier[Ninja, $SkillDodging] = 1.2;
$SkillMultiplier[Ninja, $SkillWeightCapacity] = 0.6;
$SkillMultiplier[Ninja, $SkillBashing] = 0.2;
$SkillMultiplier[Ninja, $SkillStealing] = 0.2;
$SkillMultiplier[Ninja, $SkillHiding] = 0.2;
$SkillMultiplier[Ninja, $SkillBackstabbing] = 0.2;
$SkillMultiplier[Ninja, $SkillOffensiveCasting] = 2.0;
$SkillMultiplier[Ninja, $SkillDefensiveCasting] = 1.0;
$SkillMultiplier[Ninja, $SkillNeutralCasting] = 1.8;
$SkillMultiplier[Ninja, $SkillSpellResistance] = 1.5;
$SkillMultiplier[Ninja, $SkillHealing] = 0.7;
$SkillMultiplier[Ninja, $SkillArchery] = 0.8;
$SkillMultiplier[Ninja, $SkillEndurance] = 0.4;
$SkillMultiplier[Ninja, $SkillMining] = 1.0;
$SkillMultiplier[Ninja, $SkillSpeech] = 1.2;
$SkillMultiplier[Ninja, $SkillSenseHeading] = 0.7;
$SkillMultiplier[Ninja, $SkillEnergy] = 2.0;
$SkillMultiplier[Ninja, $SkillHaggling] = 1.0;
$EXPmultiplier[Ninja] = 0.9;

//--------------
// Dancer
//--------------

$SkillMultiplier[Dancer, $SkillSlashing] = 0.3;
$SkillMultiplier[Dancer, $SkillPiercing] = 0.8;
$SkillMultiplier[Dancer, $SkillBludgeoning] = 0.3;
$SkillMultiplier[Dancer, $SkillDodging] = 1.2;
$SkillMultiplier[Dancer, $SkillWeightCapacity] = 0.6;
$SkillMultiplier[Dancer, $SkillBashing] = 0.2;
$SkillMultiplier[Dancer, $SkillStealing] = 0.2;
$SkillMultiplier[Dancer, $SkillHiding] = 0.2;
$SkillMultiplier[Dancer, $SkillBackstabbing] = 0.2;
$SkillMultiplier[Dancer, $SkillOffensiveCasting] = 2.0;
$SkillMultiplier[Dancer, $SkillDefensiveCasting] = 1.0;
$SkillMultiplier[Dancer, $SkillNeutralCasting] = 1.8;
$SkillMultiplier[Dancer, $SkillSpellResistance] = 1.5;
$SkillMultiplier[Dancer, $SkillHealing] = 0.7;
$SkillMultiplier[Dancer, $SkillArchery] = 0.8;
$SkillMultiplier[Dancer, $SkillEndurance] = 0.4;
$SkillMultiplier[Dancer, $SkillMining] = 1.0;
$SkillMultiplier[Dancer, $SkillSpeech] = 1.2;
$SkillMultiplier[Dancer, $SkillSenseHeading] = 0.7;
$SkillMultiplier[Dancer, $SkillEnergy] = 2.0;
$SkillMultiplier[Dancer, $SkillHaggling] = 1.0;
$EXPmultiplier[Dancer] = 0.9;

//--------------
// RedMage
//--------------

$SkillMultiplier[RedMage, $SkillSlashing] = 0.3;
$SkillMultiplier[RedMage, $SkillPiercing] = 0.8;
$SkillMultiplier[RedMage, $SkillBludgeoning] = 0.3;
$SkillMultiplier[RedMage, $SkillDodging] = 1.2;
$SkillMultiplier[RedMage, $SkillWeightCapacity] = 0.6;
$SkillMultiplier[RedMage, $SkillBashing] = 0.2;
$SkillMultiplier[RedMage, $SkillStealing] = 0.2;
$SkillMultiplier[RedMage, $SkillHiding] = 0.2;
$SkillMultiplier[RedMage, $SkillBackstabbing] = 0.2;
$SkillMultiplier[RedMage, $SkillOffensiveCasting] = 2.0;
$SkillMultiplier[RedMage, $SkillDefensiveCasting] = 1.0;
$SkillMultiplier[RedMage, $SkillNeutralCasting] = 1.8;
$SkillMultiplier[RedMage, $SkillSpellResistance] = 1.5;
$SkillMultiplier[RedMage, $SkillHealing] = 0.7;
$SkillMultiplier[RedMage, $SkillArchery] = 0.8;
$SkillMultiplier[RedMage, $SkillEndurance] = 0.4;
$SkillMultiplier[RedMage, $SkillMining] = 1.0;
$SkillMultiplier[RedMage, $SkillSpeech] = 1.2;
$SkillMultiplier[RedMage, $SkillSenseHeading] = 0.7;
$SkillMultiplier[RedMage, $SkillEnergy] = 2.0;
$SkillMultiplier[RedMage, $SkillHaggling] = 1.0;
$EXPmultiplier[RedMage] = 0.9;

//--------------
// DarkKnight
//--------------

$SkillMultiplier[DarkKnight, $SkillSlashing] = 0.3;
$SkillMultiplier[DarkKnight, $SkillPiercing] = 0.8;
$SkillMultiplier[DarkKnight, $SkillBludgeoning] = 0.3;
$SkillMultiplier[DarkKnight, $SkillDodging] = 1.2;
$SkillMultiplier[DarkKnight, $SkillWeightCapacity] = 0.6;
$SkillMultiplier[DarkKnight, $SkillBashing] = 0.2;
$SkillMultiplier[DarkKnight, $SkillStealing] = 0.2;
$SkillMultiplier[DarkKnight, $SkillHiding] = 0.2;
$SkillMultiplier[DarkKnight, $SkillBackstabbing] = 0.2;
$SkillMultiplier[DarkKnight, $SkillOffensiveCasting] = 2.0;
$SkillMultiplier[DarkKnight, $SkillDefensiveCasting] = 1.0;
$SkillMultiplier[DarkKnight, $SkillNeutralCasting] = 1.8;
$SkillMultiplier[DarkKnight, $SkillSpellResistance] = 1.5;
$SkillMultiplier[DarkKnight, $SkillHealing] = 0.7;
$SkillMultiplier[DarkKnight, $SkillArchery] = 0.8;
$SkillMultiplier[DarkKnight, $SkillEndurance] = 0.4;
$SkillMultiplier[DarkKnight, $SkillMining] = 1.0;
$SkillMultiplier[DarkKnight, $SkillSpeech] = 1.2;
$SkillMultiplier[DarkKnight, $SkillSenseHeading] = 0.7;
$SkillMultiplier[DarkKnight, $SkillEnergy] = 2.0;
$SkillMultiplier[DarkKnight, $SkillHaggling] = 1.0;
$EXPmultiplier[DarkKnight] = 0.8;

//--------------
// HighSummoner
//--------------

$SkillMultiplier[HighSummoner, $SkillSlashing] = 0.3;
$SkillMultiplier[HighSummoner, $SkillPiercing] = 0.8;
$SkillMultiplier[HighSummoner, $SkillBludgeoning] = 0.3;
$SkillMultiplier[HighSummoner, $SkillDodging] = 1.2;
$SkillMultiplier[HighSummoner, $SkillWeightCapacity] = 0.6;
$SkillMultiplier[HighSummoner, $SkillBashing] = 0.2;
$SkillMultiplier[HighSummoner, $SkillStealing] = 0.2;
$SkillMultiplier[HighSummoner, $SkillHiding] = 0.2;
$SkillMultiplier[HighSummoner, $SkillBackstabbing] = 0.2;
$SkillMultiplier[HighSummoner, $SkillOffensiveCasting] = 2.0;
$SkillMultiplier[HighSummoner, $SkillDefensiveCasting] = 1.0;
$SkillMultiplier[HighSummoner, $SkillNeutralCasting] = 1.8;
$SkillMultiplier[HighSummoner, $SkillSpellResistance] = 1.5;
$SkillMultiplier[HighSummoner, $SkillHealing] = 0.7;
$SkillMultiplier[HighSummoner, $SkillArchery] = 0.8;
$SkillMultiplier[HighSummoner, $SkillEndurance] = 0.4;
$SkillMultiplier[HighSummoner, $SkillMining] = 1.0;
$SkillMultiplier[HighSummoner, $SkillSpeech] = 1.2;
$SkillMultiplier[HighSummoner, $SkillSenseHeading] = 0.7;
$SkillMultiplier[HighSummoner, $SkillEnergy] = 2.0;
$SkillMultiplier[HighSummoner, $SkillHaggling] = 1.0;
$EXPmultiplier[HighSummoner] = 0.8;

//--------------
// OnionKnight
//--------------

$SkillMultiplier[OnionKnight, $SkillSlashing] = 2.0;
$SkillMultiplier[OnionKnight, $SkillPiercing] = 2.0;
$SkillMultiplier[OnionKnight, $SkillBludgeoning] = 2.0;
$SkillMultiplier[OnionKnight, $SkillDodging] = 2.0;
$SkillMultiplier[OnionKnight, $SkillWeightCapacity] = 2.0;
$SkillMultiplier[OnionKnight, $SkillBashing] = 2.0;
$SkillMultiplier[OnionKnight, $SkillStealing] = 2.0;
$SkillMultiplier[OnionKnight, $SkillHiding] = 2.0;
$SkillMultiplier[OnionKnight, $SkillBackstabbing] = 2.0;
$SkillMultiplier[OnionKnight, $SkillOffensiveCasting] = 2.0;
$SkillMultiplier[OnionKnight, $SkillDefensiveCasting] = 2.0;
$SkillMultiplier[OnionKnight, $SkillNeutralCasting] = 2.0;
$SkillMultiplier[OnionKnight, $SkillSpellResistance] = 2.0;
$SkillMultiplier[OnionKnight, $SkillHealing] = 2.0;
$SkillMultiplier[OnionKnight, $SkillArchery] = 2.0;
$SkillMultiplier[OnionKnight, $SkillEndurance] = 2.0;
$SkillMultiplier[OnionKnight, $SkillMining] = 2.0;
$SkillMultiplier[OnionKnight, $SkillSpeech] = 2.0;
$SkillMultiplier[OnionKnight, $SkillSenseHeading] = 2.0;
$SkillMultiplier[OnionKnight, $SkillEnergy] = 2.0;
$SkillMultiplier[OnionKnight, $SkillHaggling] = 2.0;
$EXPmultiplier[OnionKnight] = 0.8;

//--------------
// Kefka
//--------------

$SkillMultiplier[Kefka, $SkillSlashing] = 2.0;
$SkillMultiplier[Kefka, $SkillPiercing] = 2.0;
$SkillMultiplier[Kefka, $SkillBludgeoning] = 2.0;
$SkillMultiplier[Kefka, $SkillDodging] = 2.0;
$SkillMultiplier[Kefka, $SkillWeightCapacity] = 2.0;
$SkillMultiplier[Kefka, $SkillBashing] = 2.0;
$SkillMultiplier[Kefka, $SkillStealing] = 2.0;
$SkillMultiplier[Kefka, $SkillHiding] = 2.0;
$SkillMultiplier[Kefka, $SkillBackstabbing] = 2.0;
$SkillMultiplier[Kefka, $SkillOffensiveCasting] = 2.0;
$SkillMultiplier[Kefka, $SkillDefensiveCasting] = 2.0;
$SkillMultiplier[Kefka, $SkillNeutralCasting] = 2.0;
$SkillMultiplier[Kefka, $SkillSpellResistance] = 2.0;
$SkillMultiplier[Kefka, $SkillHealing] = 2.0;
$SkillMultiplier[Kefka, $SkillArchery] = 2.0;
$SkillMultiplier[Kefka, $SkillEndurance] = 2.0;
$SkillMultiplier[Kefka, $SkillMining] = 2.0;
$SkillMultiplier[Kefka, $SkillSpeech] = 2.0;
$SkillMultiplier[Kefka, $SkillSenseHeading] = 2.0;
$SkillMultiplier[Kefka, $SkillEnergy] = 2.0;
$SkillMultiplier[Kefka, $SkillHaggling] = 2.0;
$EXPmultiplier[Kefka] = 0.8;

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

$SkillRestriction[BluePotion] = $SkillHealing @ " 0";
$SkillRestriction[CrystalBluePotion] = $SkillHealing @ " 0";
$SkillRestriction[ApprenticeRobe] = $SkillEndurance @ " 0 " @ $SkillEnergy @ " 8";
$SkillRestriction[LightRobe] = $SkillEndurance @ " 3 " @ $SkillEnergy @ " 80";
$SkillRestriction[FineRobe] = $SkillEndurance @ " 9 " @ $SkillEnergy @ " 175";
$SkillRestriction[BloodRobe] = $SkillEndurance @ " 8 " @ $SkillEnergy @ " 300";
$SkillRestriction[AdvisorRobe] = $SkillEndurance @ " 10 " @ $SkillEnergy @ " 450";
$SkillRestriction[ElvenRobe] = $SkillEndurance @ " 12 " @ $SkillEnergy @ " 620";
$SkillRestriction[RobeOfVenjance] = $SkillEndurance @ " 18 " @ $SkillEnergy @ " 800";
$SkillRestriction[PhensRobe] = $SkillEndurance @ " 20 " @ $SkillEnergy @ " 980";
$SkillRestriction[QuestMasterRobe] = $MinAdmin @ " 3";

$SkillRestriction[PaddedArmor] = $SkillEndurance @ " 5";
$SkillRestriction[LeatherArmor] = $SkillEndurance @ " 40";
$SkillRestriction[StuddedLeather] = $SkillEndurance @ " 95";
$SkillRestriction[SpikedLeather] = $SkillEndurance @ " 135";
$SkillRestriction[HideArmor] = $SkillEndurance @ " 180";
$SkillRestriction[ScaleMail] = $SkillEndurance @ " 240";
$SkillRestriction[BrigandineArmor] = $SkillEndurance @ " 300";
$SkillRestriction[ChainMail] = $SkillEndurance @ " 350";
$SkillRestriction[RingMail] = $SkillEndurance @ " 410";
$SkillRestriction[BandedMail] = $SkillEndurance @ " 490";
$SkillRestriction[SplintMail] = $SkillEndurance @ " 580";
$SkillRestriction[BronzePlateMail] = $SkillEndurance @ " 660";
$SkillRestriction[PlateMail] = $SkillEndurance @ " 775";
$SkillRestriction[FieldPlateArmor] = $SkillEndurance @ " 840";
$SkillRestriction[DragonMail] = $SkillEndurance @ " 950";
$SkillRestriction[FullPlateArmor] = $SkillEndurance @ " 1065";
$SkillRestriction[CheetaursPaws] = $MinLevel @ " 8";
$SkillRestriction[BootsOfGliding] = $MinLevel @ " 25";
$SkillRestriction[WindWalkers] = $MinLevel @ " 60";
$SkillRestriction[KeldrinArmor] = $SkillEndurance @ " 1305";

$SkillRestriction[KnightShield] = $SkillEndurance @ " 140";
$SkillRestriction[HeavenlyShield] = $SkillEndurance @ " 540 " @ $SkillEnergy @ " 850";
$SkillRestriction[DragonShield] = $SkillEndurance @ " 715";

$SkillRestriction[Tester] = $SkillSlashing @ " 0";
$SkillRestriction[Hatchet] = $SkillSlashing @ " 0";
$SkillRestriction[BroadSword] = $SkillSlashing @ " 20";
$SkillRestriction[WarAxe] = $SkillSlashing @ " 60";
$SkillRestriction[LongSword] = $SkillSlashing @ " 140";
$SkillRestriction[BattleAxe] = $SkillSlashing @ " 300";
$SkillRestriction[BastardSword] = $SkillSlashing @ " 620";
$SkillRestriction[Halberd] = $SkillSlashing @ " 768";
$SkillRestriction[Claymore] = $SkillSlashing @ " 900";
$SkillRestriction[KeldriniteLS] = $SkillSlashing @ " 1120 " @ $MinRemort @ " 1";
//.................................................................................
$SkillRestriction[Club] = $SkillBludgeoning @ " 0";
$SkillRestriction[QuarterStaff] = $SkillBludgeoning @ " 20";
$SkillRestriction[BoneClub] = $SkillBludgeoning @ " 45";
$SkillRestriction[SpikedClub] = $SkillBludgeoning @ " 60";
$SkillRestriction[Mace] = $SkillBludgeoning @ " 140";
$SkillRestriction[HammerPick] = $SkillBludgeoning @ " 300";
$SkillRestriction[SpikedBoneClub] = $SkillBludgeoning @ " 450";
$SkillRestriction[LongStaff] = $SkillBludgeoning @ " 620";
$SkillRestriction[WarHammer] = $SkillBludgeoning @ " 768";
$SkillRestriction[JusticeStaff] = $SkillBludgeoning @ " 834";
$SkillRestriction[WarMaul] = $SkillBludgeoning @ " 900";
//.................................................................................
$SkillRestriction[PickAxe] = $SkillPiercing @ " 0";
$SkillRestriction[Knife] = $SkillPiercing @ " 0";
$SkillRestriction[Dagger] = $SkillPiercing @ " 60";
$SkillRestriction[ShortSword] = $SkillPiercing @ " 140";
$SkillRestriction[Spear] = $SkillPiercing @ " 280";
$SkillRestriction[Gladius] = $SkillPiercing @ " 450";
$SkillRestriction[Trident] = $SkillPiercing @ " 620";
$SkillRestriction[Rapier] = $SkillPiercing @ " 768";
$SkillRestriction[AwlPike] = $SkillPiercing @ " 900";
//.................................................................................
$SkillRestriction[TesterBow] = $SkillArchery @ " 0";
$SkillRestriction[Sling] = $SkillArchery @ " 0";
$SkillRestriction[ShortBow] = $SkillArchery @ " 25";
$SkillRestriction[LightCrossbow] = $SkillArchery @ " 160";
$SkillRestriction[LongBow] = $SkillArchery @ " 318";
$SkillRestriction[CompositeBow] = $SkillArchery @ " 438";
$SkillRestriction[RepeatingCrossbow] = $SkillArchery @ " 550";
$SkillRestriction[ElvenBow] = $SkillArchery @ " 685";
$SkillRestriction[AeolusWing] = $SkillArchery @ " 805";
$SkillRestriction[HeavyCrossbow] = $SkillArchery @ " 925";
//.................................................................................
$SkillRestriction[SmallRock] = $SkillArchery @ " 0";
$SkillRestriction[BasicArrow] = $SkillArchery @ " 0";
$SkillRestriction[ShortQuarrel] = $SkillArchery @ " 0";
$SkillRestriction[LightQuarrel] = $SkillArchery @ " 0";
$SkillRestriction[SheafArrow] = $SkillArchery @ " 0";
$SkillRestriction[StoneFeather] = $SkillArchery @ " 0";
$SkillRestriction[BladedArrow] = $SkillArchery @ " 0";
$SkillRestriction[HeavyQuarrel] = $SkillArchery @ " 0";
$SkillRestriction[MetalFeather] = $SkillArchery @ " 0";
$SkillRestriction[Talon] = $SkillArchery @ " 0";
$SkillRestriction[CeraphumsFeather] = $SkillArchery @ " 0";


$SkillRestriction[RHatchet] = $SkillRestriction[Hatchet];
$SkillRestriction[RBroadSword] = $SkillRestriction[BroadSword];
$SkillRestriction[RWarAxe] = $SkillRestriction[WarAxe];
$SkillRestriction[RLongSword] = $SkillRestriction[LongSword];
$SkillRestriction[RClub] = $SkillRestriction[Club];
$SkillRestriction[RSpikedClub] = $SkillRestriction[SpikedClub];
$SkillRestriction[RPickAxe] = $SkillRestriction[PickAxe];
$SkillRestriction[RKnife] = $SkillRestriction[Knife];
$SkillRestriction[RDagger] = $SkillRestriction[Dagger];
$SkillRestriction[RShortSword] = $SkillRestriction[ShortSword];
$SkillRestriction[RShortBow] = $SkillRestriction[ShortBow];
$SkillRestriction[RLightCrossbow] = $SkillRestriction[LightCrossbow];

// Chat functions
$SkillRestriction["#say"] = $SkillSpeech @ " 0";
$SkillRestriction["#shout"] = $SkillSpeech @ " 3";
$SkillRestriction["#whisper"] = $SkillSpeech @ " 0";
$SkillRestriction["#tell"] = $SkillSpeech @ " 0";
$SkillRestriction["#global"] = $SkillSpeech @ " 5";
$SkillRestriction["#zone"] = $SkillSpeech @ " 0";
$SkillRestriction["#group"] = $SkillSpeech @ " 6";
$SkillRestriction["#party"] = $SkillSpeech @ " 0";
$SkillRestriction["#steal"] = $SkillStealing @ " 15";
$SkillRestriction["#pickpocket"] = $SkillStealing @ " 270";
$SkillRestriction["#mug"] = $SkillStealing @ " 620";
$SkillRestriction["#compass"] = $SkillSenseHeading @ " 3";
$SkillRestriction["#track"] = $SkillSenseHeading @ " 15";
$SkillRestriction["#trackpack"] = $SkillSenseHeading @ " 85";
$SkillRestriction["#hide"] = $SkillHiding @ " 15";
$SkillRestriction["#bash"] = $SkillBashing @ " 15";
$SkillRestriction["#shove"] = $SkillBashing @ " 5";
$SkillRestriction["#zonelist"] = $SkillSenseHeading @ " 45";
$SkillRestriction["#advcompass"] = $SkillSenseHeading @ " 20";

// Spells
$SkillRestriction[thorn] = $SkillOffensiveCasting @ " 15";
$SkillRestriction[fireball] = $SkillOffensiveCasting @ " 20";
$SkillRestriction[firebomb] = $SkillOffensiveCasting @ " 35";
$SkillRestriction[icespike] = $SkillOffensiveCasting @ " 45";
$SkillRestriction[icestorm] = $SkillOffensiveCasting @ " 85";
$SkillRestriction[ironfist] = $SkillOffensiveCasting @ " 110";
$SkillRestriction[cloud] = $SkillOffensiveCasting @ " 145";
$SkillRestriction[melt] = $SkillOffensiveCasting @ " 220";
$SkillRestriction[powercloud] = $SkillOffensiveCasting @ " 340";
$SkillRestriction[hellstorm] = $SkillOffensiveCasting @ " 420";
$SkillRestriction[beam] = $SkillOffensiveCasting @ " 520";
$SkillRestriction[dimensionrift] = $SkillOffensiveCasting @ " 750";

$SkillRestriction[teleport] = $SkillNeutralCasting @ " 60";
$SkillRestriction[transport] = $SkillNeutralCasting @ " 200";
$SkillRestriction[advtransport] = $SkillNeutralCasting @ " 350";
$SkillRestriction[remort] = $SkillNeutralCasting @ " 0 " @ $MinLevel @ " 101";
$SkillRestriction[mimic] = $SkillNeutralCasting @ " 145 " @ $MinRemort @ " 2";
$SkillRestriction[masstransport] = $SkillNeutralCasting @ " 650 " @ $MinRemort @ " 1";

$SkillRestriction[heal] = $SkillDefensiveCasting @ " 10";
$SkillRestriction[advheal1] = $SkillDefensiveCasting @ " 80";
$SkillRestriction[advheal2] = $SkillDefensiveCasting @ " 110";
$SkillRestriction[advheal3] = $SkillDefensiveCasting @ " 200";
$SkillRestriction[advheal4] = $SkillDefensiveCasting @ " 320";
$SkillRestriction[advheal5] = $SkillDefensiveCasting @ " 400";
$SkillRestriction[advheal6] = $SkillDefensiveCasting @ " 500";
$SkillRestriction[godlyheal] = $SkillDefensiveCasting @ " 600";
$SkillRestriction[fullheal] = $SkillDefensiveCasting @ " 750";
$SkillRestriction[massheal] = $SkillDefensiveCasting @ " 850 " @ $MinRemort @ " 2";
$SkillRestriction[massfullheal] = $SkillDefensiveCasting @ " 950 " @ $MinRemort @ " 3";
$SkillRestriction[shield] = $SkillDefensiveCasting @ " 20";
$SkillRestriction[advshield1] = $SkillDefensiveCasting @ " 60";
$SkillRestriction[advshield2] = $SkillDefensiveCasting @ " 140";
$SkillRestriction[advshield3] = $SkillDefensiveCasting @ " 290";
$SkillRestriction[advshield4] = $SkillDefensiveCasting @ " 420";
$SkillRestriction[advshield5] = $SkillDefensiveCasting @ " 635";
$SkillRestriction[massshield] = $SkillDefensiveCasting @ " 680";

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

	////////temporary/////////////////////////
	if(%skill == 16)	//weapon handling
		return False;
	//////////////////////////////////////////

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

function SkillCanUse(%clientId, %thing)
{
	dbecho($dbechoMode, "SkillCanUse(" @ %clientId @ ", " @ %thing @ ")");

	if(%clientId.adminLevel >= 5)
		return True;

	%flag = 0;
	%gc = 0;
	%gcflag = 0;
	for(%i = 0; GetWord($SkillRestriction[%thing], %i) != -1; %i+=2)
	{
		%s = GetWord($SkillRestriction[%thing], %i);
		%n = GetWord($SkillRestriction[%thing], %i+1);

		if(%s == "L")
		{
			if(fetchData(%clientId, "LVL") < %n)
				%flag = 1;
		}
		else if(%s == "R")
		{
			if(fetchData(%clientId, "RemortStep") < %n)
				%flag = 1;
		}
		else if(%s == "A")
		{
			if(%clientId.adminLevel < %n)
				%flag = 1;
		}
		else if(%s == "G")
		{
			%gcflag++;
			if(String::ICompare(fetchData(%clientId, "GROUP"), %n) == 0)
				%gc = 1;
		}
		else if(%s == "C")
		{
			%gcflag++;
			if(String::ICompare(fetchData(%clientId, "CLASS"), %n) == 0)
				%gc = 1;
		}
		else if(%s == "H")
		{
			%hflag++;
			if(String::ICompare(fetchData(%clientId, "MyHouse"), %n) == 0)
				%hh = 1;
		}
		else
		{
			if($PlayerSkill[%clientId, %s] < %n)
				%flag = 1;
		}
	}

	//First, if there are any class/group restrictions, house restrictions, check these first.
	if(%gcflag > 0)
	{
		if(%gc == 0)
			%flag = 1;
	}
	if(%hflag > 0)
	{
		if(%hh == 0)
			%flag = 1;
	}

	
	if(%flag != 1)
		return True;
	else
		return False;
}

function UseSkill(%clientId, %skilltype, %successful, %showmsg, %base, %refreshall)
{
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