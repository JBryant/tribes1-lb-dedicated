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



//Data for spells are defined in the SPELL DEFINITIONS section.  Unfortunately, not everything can be designed there
//(ie, special effects etc) so for the great majority, the spells are coded in the DoCastSpell function.  This method
//isn't the ideal one... maybe one day i'll fix that if the need comes along.

//-- SPELL TYPES (not in use due to hardcoding of spells...) -----------------------------------------------------

// $SelfType = 1;				//casts only to self
// $LOSType = 2;				//casts only at LOS

// $SelfRadiusType = 3;			//casts to self and around self
// $LOSRadiusType = 4;			//casts at LOS and around LOS

// $SelfRadiusLOSType = 5;			//casts to self and around self and at LOS
// $LOSRadiusSelfType = 6;			//casts at LOS and around LOS and to self

// $SelfRadiusLOSRadiusType = 7;		//casts to self and around self and to LOS and around LOS

// // ---- Elemental Type -----
// $ElementalFire = 1;
// $ElementalLightning = 2;
// $ElementalIce = 3;
// $ElementalEarth = 4;
// $ElementalPoison = 5;
// $ElementalHoly = 6;
// $ElementalDark = 7;

$MYmaxclients = 32; //BOTmax plus PLAYERmax

$spellgoing=0;
for(%i = 1; %i <= $MYmaxclients; %i++) {
	$ttlholdid[%i] = 0;
	$ttlholdpos[%i] = 0;
	$ttlhold[%i] = 0;
	$ttltype[%i] = 0;
	$fwallttl[%i] = 0;
	$fwallid[%i] = 0;
}

function CastingSpell() {
	$spellgoing=0;
	for(%mynum=1;%mynum<$MYmaxclients;%mynum++) {
		if($fwallttl[%mynum]>0) {
			$fwallttl[%mynum]-=1;
			$spellgoing=1;
		}
		if($fwallttl[%mynum]<=0&&isObject($fwallid[%mynum])) {
			//Item::Pop("@$fwallid[%mynum]@");
			//deleteObject("@$fwallid[%mynum]@");
			$fwallid[%mynum]=0;
			$fwallttl[%mynum]=0;
		}
	}
	for(%mynum=1;%mynum<$MYmaxclients;%mynum++) {
//if($ttlholdid[%mynum] > 0) echo("CastingSpell: "@$ttlholdid[%mynum]@" | "@$ttlholdpos[%mynum]@" | "@$ttlhold[%mynum]@" | "@$ttltype[%mynum]);
		if($ttlhold[%mynum]>0) {
			$ttlhold[%mynum]-=1;
			$spellgoing=1;
			if($ttltype[%mynum]==12) {
				set_position($ttlholdid[%mynum],$ttlholdpos[%mynum]);
			}
		}

		if(isdead($ttlholdid[%mynum])||$ttlhold[%mynum]<=0) {
			if($ttltype[%mynum]==8) {
				//Client::sendMessage(%Client, $MsgBeige, "Confusion of "@Client::getName(%id)@"wears off");
				//if(%Client != %id)
				Client::sendMessage($ttlholdid[%mynum], $MsgBeige, "You are no longer confused");
				GameBase::setTeam($ttlholdid[%mynum],$ttlholdpos[%mynum]);
				Game::refreshClientScore($ttlholdid[%mynum]);
				UpdateSkin($ttlholdid[%mynum]);
			}
			if($ttltype[%mynum]==10) {
				Client::sendMessage($ttlholdpos[%mynum], $MsgBeige, "Manipulated by "@Client::getName(%id)@"wears off");
				if($ttlholdpos[%mynum] != $ttlholdid[%mynum])
					Client::sendMessage($ttlholdid[%mynum], $MsgGreen, "You are no longer Manipulated");
				//if(!Player::isAiControlled($ttlholdpos[%mynum]))
				//{
					//revert
					Client::setControlObject($ttlholdid[%mynum], $ttlholdid[%mynum]);
					Client::setControlObject($ttlholdpos[%mynum], $ttlholdpos[%mynum]);
					$dumbAIflag[$ttlholdpos[%mynum].possessId] = "";
				//}
				//else
				//{
				//	Client::setControlObject($ttlholdid[%mynum],$ttlholdid[%mynum]);
				//}
			}
			$ttlhold[%mynum]=0;
			$ttltype[%mynum]=0;
			$ttlholdid[%mynum]=0;
			$ttlholdpos[%mynum]=0;
		}
	}
	if($spellgoing==1)
		schedule("CastingSpell();", 1);
}

$MagicType[0] = "Fire";
$MagicType[1] = "Ice";
$MagicType[2] = "Lightning";
$MagicType[3] = "Water";
$MagicType[4] = "Earth";
$MagicType[5] = "Wind";
$MagicType[6] = "Black";
$MagicType[7] = "Status";

$MagicType[Fire] = 0;
$MagicType[Ice] = 1;
$MagicType[Lightning] = 2;
$MagicType[Water] = 3;
$MagicType[Earth] = 4;
$MagicType[Wind] = 5;
$MagicType[Black] = 6;
$MagicType[Status] = 7;
$MagicType[White] = 8;

//Data for spells are defined in the SPELL DEFINITIONS section.
//Unfortunately, not everything can be designed there (ie, special effects etc)


$SpellMovementGraceDistance = 4; // 2

//-- SPELL DEFINITIONS -------------------------------------------------------------------------------------------

$AllMageClasses = "BlackMage TimeMage Summoner Spellbow Spellblade DarkKnight ArcaneArcher Arcanist HexBlade";
$WhiteMagicClasses = "WhiteMage Mystic Orator Samurai Dancer HolyKnight Valkyrie Seraphim Ancient";

//-----------transportation spells-------------
$Spell::keyword[1] = "teleport";
$Spell::index[teleport] = 1;
$Spell::name[1] = "Teleport close to nearest zone";
$Spell::description[1] = "Teleports you near a zone";
$Spell::delay[1] = 3.5;
$Spell::recoveryTime[1] = 25;
$Spell::manaCost[1] = 100;
$Spell::startSound[1] = cheespellsound;
$Spell::endSound[1] = ActivateCH;
$Spell::classRestrictions[1] = "";
$Spell::minLevel[1] = 5;
$Spell::groupListCheck[1] = False;
$SkillType[teleport] = $SkillTimeMagick;

$Spell::keyword[2] = "transport";
$Spell::index[transport] = 2;
$Spell::name[2] = "Transport";
$Spell::description[2] = "Teleports to Zone";
$Spell::delay[2] = 4.0;
$Spell::recoveryTime[2] = 23;
$Spell::manaCost[2] = 24;
$Spell::startSound[2] = cheespellsound;
$Spell::endSound[2] = ActivateCH;
$Spell::classRestrictions[2] = "";
$Spell::minLevel[2] = 30;
$Spell::groupListCheck[2] = False;
$SkillType[barqprz] = $SkillTimeMagick;

$Spell::keyword[3] = "advtransportd";
$Spell::index[advtransport] = 3;
$Spell::name[3] = "Advanced Transport to zone";
$Spell::description[3] = "Transports self OR person in line-of-sight to a specific zone";
$Spell::delay[3] = 4.0;
$Spell::recoveryTime[3] = 40;
$Spell::LOSrange[3] = 500;
$Spell::manaCost[3] = 800;
$Spell::startSound[3] = cheespellsound;
$Spell::endSound[3] = ActivateCH;
$Spell::classRestrictions[3] = "";
$Spell::minLevel[3] = 50;
$Spell::groupListCheck[3] = True;
$SkillType[advtransport] = $SkillTimeMagick;

$Spell::keyword[4] = "Medic";
$Spell::index[medic] = 4;
$Spell::name[4] = "Healing Magic";
$Spell::description[4] = "Cure self.";
$Spell::delay[4] = 1.5;
$Spell::recoveryTime[4] = 2;
$Spell::damageValue[4] = -80;
$Spell::manaCost[4] = 10;
$Spell::startSound[4] = DeActivateWA;
$Spell::endSound[4] = lilheal; // lilheal
$Spell::classRestrictions[4] = $WhiteMagicClasses;
$Spell::minLevel[4] = 1;
$Spell::groupListCheck[4] = False;
$Spell::Type[4] = $MagicType[White];
$SkillType[medic] = $SkillWhiteMagick;

$Spell::keyword[5] = "Medic2";
$Spell::index[medic2] = 5;
$Spell::name[5] = "Healing Magic";
$Spell::description[5] = "Medic 2";
$Spell::delay[5] = 1.5;
$Spell::recoveryTime[5] =  20;
$Spell::damageValue[5] = -200;
$Spell::LOSrange[5] = 500;
$Spell::manaCost[5] = 40;
$Spell::startSound[5] = DeActivateWA;
$Spell::endSound[5] = lilheal;
$Spell::classRestrictions[5] = $WhiteMagicClasses;
$Spell::minLevel[5] = 15;
$Spell::groupListCheck[5] = False;
$Spell::Type[5] = $MagicType[White];
$SkillType[medic2] = $SkillWhiteMagick;

$Spell::keyword[6] = "Medic3";
$Spell::index[medic3] = 6;
$Spell::name[6] = "Healing Magic";
$Spell::description[6] = "Medic 3";
$Spell::delay[6] = 1.5;
$Spell::recoveryTime[6] = 30;
$Spell::damageValue[6] = -1000;
$Spell::LOSrange[6] = 500;
$Spell::manaCost[6] = 80;
$Spell::startSound[6] = DeActivateWA;
$Spell::endSound[6] = lilheal; // lilheal
$Spell::classRestrictions[6] = $WhiteMagicClasses;
$Spell::minLevel[6] = 40;
$Spell::groupListCheck[6] = False;
$Spell::Type[6] = $MagicType[White];
$SkillType[medic3] = $SkillWhiteMagick;

$Spell::keyword[7] = "Medic4";
$Spell::index[medic4] = 7;
$Spell::name[7] = "Healing Magic";
$Spell::description[7] = "Medic 4";
$Spell::delay[7] = 1.5;
$Spell::recoveryTime[7] = 30;
$Spell::damageValue[7] = -5000;
$Spell::LOSrange[7] = 500;
$Spell::manaCost[7] = 120;
$Spell::startSound[7] = DeActivateWA;
$Spell::endSound[7] = lilheal;
$Spell::classRestrictions[7] = $WhiteMagicClasses;
$Spell::minLevel[7] = 75;
$Spell::groupListCheck[7] = False;
$Spell::Type[7] = $MagicType[White];
$SkillType[medic4] = $SkillWhiteMagick;

$Spell::keyword[8] = "Confusion";
$Spell::index[confusion] = 8;
$Spell::name[8] = "Status Magic";
$Spell::description[8] = "Confuses foe.";
$Spell::delay[8] = 4;
$Spell::recoveryTime[8] = 30;
$Spell::damageValue[8] = 0;
$Spell::LOSrange[8] = 100;
$Spell::manaCost[8] = 100;
$Spell::startSound[8] = spellstart;
$Spell::endSound[8] = ActivateAR;
$Spell::classRestrictions[8] = "Mage";
$Spell::minLevel[8] = 20;
$Spell::groupListCheck[8] = False;
$Spell::Type[8] = $MagicType[Status];
$SkillType[confusion] = $SkillTimeMagick;

$Spell::keyword[9] = "Remove";
$Spell::index[remove] = 9;
$Spell::name[9] = "Status Magic";
$Spell::description[9] = "Removes a person from battle. Distance counts on LVL.";
$Spell::delay[9] = 1.5;
$Spell::recoveryTime[9] = 15;
$Spell::damageValue[9] = 0;
$Spell::LOSrange[9] = 100;
$Spell::manaCost[9] = 20;
$Spell::startSound[9] = spellstart;
$Spell::endSound[9] = ActivateAR;
$Spell::classRestrictions[9] = "Mage Druid";
$Spell::minLevel[9] = 5;
$Spell::groupListCheck[9] = False;
$Spell::Type[9] = $MagicType[Status];
$SkillType[remove] = $SkillTimeMagick;

$Spell::keyword[10] = "MindControl";
$Spell::index[mindcontrol] = 10;
$Spell::name[10] = "Status Magic";
$Spell::description[10] = "manipulates a person.";
$Spell::delay[10] = 5;
$Spell::recoveryTime[10] = 40;
$Spell::damageValue[10] = 0;
$Spell::LOSrange[10] = 100;
$Spell::manaCost[10] = 300;
$Spell::startSound[10] = spellstart;
$Spell::endSound[10] = ActivateAR;
$Spell::classRestrictions[10] = "Mage";
$Spell::minLevel[10] = 150;
$Spell::groupListCheck[10] = False;
$Spell::Type[10] = $MagicType[Status];
$SkillType[mindcontrol] = $SkillTimeMagick;

$Spell::keyword[11] = "Fire";
$Spell::index[fire] = 11;
$Spell::name[11] = "Fire Magic";
$Spell::description[11] = "Level 1 fire magic.";
$Spell::delay[11] = 2;
$Spell::recoveryTime[11] = 5;
$Spell::damageValue[11] = 6;
$Spell::LOSrange[11] = 100;
$Spell::manaCost[11] = 4;
$Spell::startSound[11] = spellstart;
$Spell::endSound[11] = ActivateAR;
$Spell::classRestrictions[11] = $AllMageClasses;
$Spell::minLevel[11] = 1;
$Spell::groupListCheck[11] = False;
$Spell::Type[11] = $MagicType[Fire];
$SkillType[fire] = $SkillBlackMagick;

$Spell::keyword[12] = "Fira";
$Spell::index[fira] = 12;
$Spell::name[12] = "Fire Magic";
$Spell::description[12] = "level 2 fire magic.";
$Spell::delay[12] = 1.5;
$Spell::recoveryTime[12] = 8;
$Spell::radius[12] = 10;
$Spell::damageValue[12] = 25;
$Spell::LOSrange[12] = 500;
$Spell::manaCost[12] = 40;
$Spell::startSound[12] = spellstart;
$Spell::endSound[12] = ActivateAR;
$Spell::classRestrictions[12] = $AllMageClasses;
$Spell::minLevel[12] = 25;
$Spell::groupListCheck[12] = False;
$Spell::Type[12] = $MagicType[Fire];
$SkillType[fira] = $SkillBlackMagick;

$Spell::keyword[13] = "Firaga";
$Spell::index[firaga] = 13;
$Spell::name[13] = "Fire Magic";
$Spell::description[13] = "Level 3 fire magic.";
$Spell::delay[13] = 2;
$Spell::recoveryTime[13] = 9;
$Spell::damageValue[13] = 7; // 100 / 14
$Spell::LOSrange[13] = 100;
$Spell::manaCost[13] = 100;
$Spell::startSound[13] = spellstart;
$Spell::endSound[13] = ActivateAR;
$Spell::classRestrictions[13] = $AllMageClasses;
$Spell::minLevel[13] = 100;
$Spell::groupListCheck[13] = False;
$Spell::Type[13] = $MagicType[Fire];
$SkillType[firaga] = $SkillBlackMagick;

$Spell::keyword[14] = "Flare";
$Spell::index[flare] = 14;
$Spell::name[14] = "Fire Magic";
$Spell::description[14] = "Extreme Fire Magic.";
$Spell::delay[14] = 2;
$Spell::recoveryTime[14] = 10;
$Spell::damageValue[14] = 20; // 200 / 10
$Spell::LOSrange[14] = 300;
$Spell::manaCost[14] = 200;
$Spell::startSound[14] = spellstart;
$Spell::endSound[14] = bigfire;
$Spell::classRestrictions[14] = $AllMageClasses;
$Spell::minLevel[14] = 200;
$Spell::groupListCheck[14] = False;
$Spell::Type[14] = $MagicType[Fire];
$SkillType[flare] = $SkillBlackMagick;

$Spell::keyword[15] = "RedRedWine";
$Spell::index[redredwine] = 15;
$Spell::name[15] = "Ice Magic";
$Spell::description[15] = "Level 3 magic.";
$Spell::delay[15] = 2;
$Spell::recoveryTime[15] = 8;
$Spell::damageValue[15] = 5; // 50 / 10
$Spell::LOSrange[15] = 100;
$Spell::manaCost[15] = 150;
$Spell::startSound[15] = spellstart;
$Spell::endSound[15] = ActivateAR;
$Spell::classRestrictions[15] = $AllMageClasses;
$Spell::minLevel[15] = 50;
$Spell::groupListCheck[15] = False;
$Spell::Type[15] = $MagicType[Ice];
$SkillType[redredwine] = $SkillBlackMagick;

$Spell::keyword[16] = "Blizzard";
$Spell::index[blizzard] = 16;
$Spell::name[16] = "Ice Magic";
$Spell::description[16] = "Level 1 Ice magic.";
$Spell::delay[16] = 2;
$Spell::recoveryTime[16] = 5;
$Spell::damageValue[16] = 8;
$Spell::LOSrange[16] = 100;
$Spell::manaCost[16] = 8;
$Spell::startSound[16] = spellstart;
$Spell::endSound[16] = ActivateAR;
$Spell::classRestrictions[16] = $AllMageClasses;
$Spell::minLevel[16] = 3;
$Spell::groupListCheck[16] = False;
$Spell::Type[16] = $MagicType[Ice];
$SkillType[blizzard] = $SkillBlackMagick;

$Spell::keyword[17] = "Blizzara";
$Spell::index[blizzara] = 17;
$Spell::name[17] = "Ice Magic";
$Spell::description[17] = "Level 2 Ice Elem.";
$Spell::delay[17] = 2;
$Spell::recoveryTime[17] = 6;
$Spell::damageValue[17] = 14; // 40 / 3
$Spell::LOSrange[17] = 100;
$Spell::manaCost[17] = 100;
$Spell::startSound[17] = spellstart;
$Spell::endSound[17] = ActivateAR;
$Spell::classRestrictions[17] = $AllMageClasses;
$Spell::minLevel[17] = 40;
$Spell::groupListCheck[17] = False;
$Spell::Type[17] = $MagicType[Ice];
$SkillType[blizzara] = $SkillBlackMagick;

$Spell::keyword[18] = "Blizzaga";
$Spell::index[blizzaga] = 18;
$Spell::name[18] = "Ice Magic";
$Spell::description[18] = "Level 3 Ice Elem.";
$Spell::delay[18] = 1;
$Spell::recoveryTime[18] = 8;
$Spell::damageValue[18] = 8; // 130 / 16
$Spell::LOSrange[18] = 300;
$Spell::manaCost[18] = 160;
$Spell::startSound[18] = spellstart;
$Spell::endSound[18] = ActivateAR;
$Spell::classRestrictions[18] = $AllMageClasses;
$Spell::minLevel[18] = 130;
$Spell::groupListCheck[18] = False;
$Spell::Type[18] = $MagicType[Ice];
$SkillType[blizzaga] = $SkillBlackMagick;

$Spell::keyword[19] = "Avalanche";
$Spell::index[avalanche] = 19;
$Spell::name[19] = "Ice Magic";
$Spell::description[19] = "ice magic.";
$Spell::delay[19] = 1.0;
$Spell::recoveryTime[19] = 10;
$Spell::damageValue[19] = 33; // 200 / 6
$Spell::LOSrange[19] = 100;
$Spell::manaCost[19] = 200;
$Spell::startSound[19] = ActivateAR;
$Spell::endSound[19] = portal1;
$Spell::classRestrictions[19] = $AllMageClasses;
$Spell::minLevel[19] = 200;
$Spell::groupListCheck[19] = False;
$Spell::Type[19] = $MagicType[Ice];
$SkillType[avalanche] = $SkillBlackMagick;

$Spell::keyword[20] = "Aqua";
$Spell::index[aqua] = 20;
$Spell::name[20] = "Water Magic";
$Spell::description[20] = "Shoots a powerful beam of water.";
$Spell::delay[20] = 1;
$Spell::recoveryTime[20] = 4;
$Spell::damageValue[20] = 30;
$Spell::LOSrange[20] = 500;
$Spell::manaCost[20] = 100;
$Spell::startSound[20] = watershotstart;
$Spell::endSound[20] = watersplash;
$Spell::classRestrictions[20] = $AllMageClasses;
$Spell::minLevel[20] = 30;
$Spell::groupListCheck[20] = False;
$Spell::Type[20] = $MagicType[Water];
$SkillType[aqua] = $SkillBlackMagick;

$Spell::keyword[21] = "Aquara";
$Spell::index[aquara] = 21;
$Spell::name[21] = "Water Magic";
$Spell::description[21] = "Fires water at foe to shoot them away.";
$Spell::delay[21] = 1.5;
$Spell::recoveryTime[21] = 6;
$Spell::damageValue[21] = 50;
$Spell::LOSrange[21] = 500;
$Spell::manaCost[21] = 160;
$Spell::startSound[21] = watershotstart;
$Spell::endSound[21] = watersplash;
$Spell::classRestrictions[21] = $AllMageClasses;
$Spell::minLevel[21] = 50;
$Spell::groupListCheck[21] = False;
$Spell::Type[21] = $MagicType[Water];
$SkillType[aquara] = $SkillBlackMagick;

$Spell::keyword[22] = "Aquaga";
$Spell::index[aquaga] = 22;
$Spell::name[22] = "Water Magic";
$Spell::description[22] = "Water Level 3 Magic.";
$Spell::delay[22] = 0;
$Spell::recoveryTime[22] = 3;
$Spell::damageValue[22] = 100;
$Spell::radius[22] = "20";
$Spell::LOSrange[22] = 800;
$Spell::manaCost[22] = 240;
$Spell::startSound[22] = watershotstart;
$Spell::endSound[22] = watersplash;
$Spell::classRestrictions[22] = $AllMageClasses;
$Spell::minLevel[22] = 100;
$Spell::groupListCheck[22] = False;
$Spell::Type[22] = $MagicType[Water];
$SkillType[aquaga] = $SkillBlackMagick;

$Spell::keyword[23] = "Tsunami";
$Spell::index[tsunami] = 23;
$Spell::name[23] = "Water Magic";
$Spell::description[23] = "Water Level 4 Magic.";
$Spell::delay[23] = 1.5;
$Spell::recoveryTime[23] = 6;
$Spell::damageValue[23] = 66; // 200 / 3
$Spell::manaCost[23] = 400;
$Spell::startSound[23] = watershotstart;
$Spell::endSound[23] = watersplash;
$Spell::classRestrictions[23] = $AllMageClasses;
$Spell::groupListCheck[23] = False;
$Spell::minLevel[23] = 200;
$Spell::Type[23] = $MagicType[Water];
$SkillType[tsunami] = $SkillBlackMagick;

$Spell::keyword[24] = "Tremor";
$Spell::index[tremor] = 24;
$Spell::name[24] = "Earth Magic";
$Spell::description[24] = "Level 1 Earth magic.";
$Spell::delay[24] = 2;
$Spell::recoveryTime[24] = 5;
$Spell::damageValue[24] = 30;
$Spell::LOSrange[24] = 500;
$Spell::manaCost[24] = 50;
$Spell::startSound[24] = spellstart;
$Spell::endSound[24] = shockExplosion;
$Spell::classRestrictions[24] = $AllMageClasses;
$Spell::minLevel[24] = 30;
$Spell::groupListCheck[24] = False;
$Spell::Type[24] = $MagicType[Earth];
$SkillType[tremor] = $SkillBlackMagick;

$Spell::keyword[25] = "Quake";
$Spell::index[quake] = 25;
$Spell::name[25] = "Earth Magic";
$Spell::description[25] = "Level 2 Earth magic.";
$Spell::delay[25] = 3;
$Spell::recoveryTime[25] = 6;
$Spell::damageValue[25] = 30; // 60 / 2
$Spell::LOSrange[25] = 500;
$Spell::manaCost[25] = 100;
$Spell::startSound[25] = spellstart;
$Spell::endSound[25] = shockExplosion;
$Spell::classRestrictions[25] = $AllMageClasses;
$Spell::minLevel[25] = 60;
$Spell::groupListCheck[25] = False;
$Spell::Type[25] = $MagicType[Earth];
$SkillType[quake] = $SkillBlackMagick;

$Spell::keyword[26] = "Earthshake";
$Spell::index[earthshake] = 26;
$Spell::name[26] = "Earth Magic";
$Spell::description[26] = "Level 3 Earth magic.";
$Spell::delay[26] = 4;
$Spell::recoveryTime[26] = 8;
$Spell::damageValue[26] = 40; // 120 / 3
$Spell::radius[26] = "30";
$Spell::LOSrange[26] = 500;
$Spell::manaCost[26] = 200;
$Spell::startSound[26] = spellstart;
$Spell::endSound[26] = shockExplosion;
$Spell::classRestrictions[26] = $AllMageClasses;
$Spell::minLevel[26] = 120;
$Spell::groupListCheck[26] = False;
$Spell::Type[26] = $MagicType[Earth];
$SkillType[earthshake] = $SkillBlackMagick;
// 

$Spell::keyword[27] = "Cataclysm";
$Spell::index[cataclysm] = 27;
$Spell::name[27] = "Earth Magic";
$Spell::description[27] = "Level 4 Earth magic.";
$Spell::delay[27] = 6;
$Spell::recoveryTime[27] = 10;
$Spell::damageValue[27] = 19; // 230 / 12
$Spell::LOSrange[27] = 500;
$Spell::manaCost[27] = 400;
$Spell::startSound[27] = spellstart;
$Spell::endSound[27] = shockExplosion;
$Spell::classRestrictions[27] = $AllMageClasses;
$Spell::minLevel[27] = 230;
$Spell::groupListCheck[27] = False;
$Spell::Type[27] = $MagicType[Earth];
$SkillType[cataclysm] = $SkillBlackMagick;

$Spell::keyword[28] = "Spike";
$Spell::index[spike] = 28;
$Spell::name[28] = "Light Magic";
$Spell::description[28] = "Level 1 Light Magic.";
$Spell::delay[28] = 1;
$Spell::recoveryTime[28] = 5;
$Spell::damageValue[28] = 5;
$Spell::LOSrange[28] = 100;
$Spell::manaCost[28] = 4;
$Spell::startSound[28] = spellstart;
$Spell::endSound[28] = mmsound;
$Spell::classRestrictions[28] = $WhiteMagicClasses;
$Spell::minLevel[28] = 1;
$Spell::groupListCheck[28] = False;
$Spell::Type[28] = $MagicType[White];
$SkillType[spike] = $SkillWhiteMagick;

$Spell::keyword[29] = "Wound";
$Spell::index[wound] = 29;
$Spell::name[29] = "Light Magic";
$Spell::description[29] = "Level 2 Light Magic.";
$Spell::delay[29] = 1;
$Spell::recoveryTime[29] = 6;
$Spell::damageValue[29] = 20;
$Spell::LOSrange[29] = 200;
$Spell::manaCost[29] = 15;
$Spell::startSound[29] = spellstart;
$Spell::endSound[29] = ActivateAR;
$Spell::classRestrictions[29] = $WhiteMagicClasses;
$Spell::minLevel[29] = 10;
$Spell::groupListCheck[29] = False;
$Spell::Type[29] = $MagicType[White];
$SkillType[wound] = $SkillWhiteMagick;

$Spell::keyword[30] = "Fist";
$Spell::index[fist] = 30;
$Spell::name[30] = "Light Magic";
$Spell::description[30] = "Level 3 Light Magic.";
$Spell::delay[30] = 1;
$Spell::recoveryTime[30] = 10;
$Spell::damageValue[30] = 55;
$Spell::LOSrange[30] = 100;
$Spell::manaCost[30] = 55;
$Spell::startSound[30] = spellstart;
$Spell::endSound[30] = ActivateAR;
$Spell::classRestrictions[30] = $WhiteMagicClasses;
$Spell::minLevel[30] = 30;
$Spell::groupListCheck[30] = False;
$Spell::Type[30] = $MagicType[White];
$SkillType[Fist] = $SkillWhiteMagick;

$Spell::keyword[31] = "Missile";
$Spell::index[Missile] = 31;
$Spell::name[31] = "Light Magic";
$Spell::description[31] = "Level 4 Light Magic.";
$Spell::delay[31] = 3;
$Spell::recoveryTime[31] = 9;
$Spell::damageValue[31] = 120;	
$Spell::LOSrange[31] = 100;
$Spell::manaCost[31] = 90;
$Spell::startSound[31] = thunderlight;
$Spell::endSound[31] = shockExplosion;
$Spell::classRestrictions[31] = $WhiteMagicClasses;
$Spell::minLevel[31] = 60;
$Spell::groupListCheck[31] = False;
$Spell::Type[31] = $MagicType[White];
$SkillType[Missile] = $SkillWhiteMagick;

$Spell::keyword[32] = "Cannon";
$Spell::index[Cannon] = 32;
$Spell::name[32] = "Light Magic";
$Spell::description[32] = "Level 5 Light Magic.";
$Spell::delay[32] = 6;
$Spell::recoveryTime[32] = 9;
$Spell::damageValue[32] = 100; // 150 / 2
$Spell::LOSrange[32] = 100;
$Spell::manaCost[32] = 180;
$Spell::startSound[32] = thunderlight;
$Spell::endSound[32] = shockExplosion;
$Spell::classRestrictions[32] = $WhiteMagicClasses;
$Spell::minLevel[32] = 90;
$Spell::groupListCheck[32] = False;
$Spell::Type[32] = $MagicType[White];
$SkillType[Cannon] = $SkillWhiteMagick;

$Spell::keyword[33] = "Bomb";
$Spell::index[bomb] = 33;
$Spell::name[33] = "Light Magic";
$Spell::description[33] = "Level 6 Light Magic.";
$Spell::delay[33] = 6;
$Spell::recoveryTime[33] = 10;
$Spell::damageValue[33] = 80; // 200 / 3
$Spell::LOSrange[33] = 200;
$Spell::manaCost[33] = 240;
$Spell::startSound[33] = spellstart;
$Spell::endSound[33] = ActivateAR;
$Spell::classRestrictions[33] = $WhiteMagicClasses;
$Spell::minLevel[33] = 120;
$Spell::groupListCheck[33] = False;
$Spell::Type[33] = $MagicType[White];
$SkillType[bomb] = $SkillWhiteMagick;

$Spell::keyword[34] = "Star";
$Spell::index[star] = 34;
$Spell::name[34] = "Light Magic";
$Spell::description[34] = "Level 7 Light Magic.";
$Spell::delay[34] = 2;
$Spell::recoveryTime[34] = 5;
$Spell::damageValue[34] = 50; // 235 / 5
$Spell::LOSrange[34] = 800;
$Spell::manaCost[34] = 360;
$Spell::startSound[34] = ultimathunder;
$Spell::endSound[34] = spooky;
$Spell::classRestrictions[34] = $WhiteMagicClasses;
$Spell::minLevel[34] = 150;
$Spell::groupListCheck[34] = False;
$Spell::Type[34] = $MagicType[White];
$SkillType[Star] = $SkillWhiteMagick;

$Spell::keyword[35] = "DarkSpike";
$Spell::index[darkspike] = 35;
$Spell::name[35] = "Dark Magic";
$Spell::description[35] = "Level 1 Dark Magic.";
$Spell::delay[35] = 2;
$Spell::recoveryTime[35] = 5;
$Spell::damageValue[35] = 20;
$Spell::LOSrange[35] = 300;
$Spell::manaCost[35] = 20;
$Spell::startSound[35] = spellstart;
$Spell::endSound[35] = ActivateAR;
$Spell::classRestrictions[35] = $AllMageClasses;
$Spell::minLevel[35] = 20;
$Spell::groupListCheck[35] = False;
$Spell::Type[35] = $MagicType[Black];
$SkillType[darkspike] = $SkillBlackMagick;

$Spell::keyword[36] = "DarkShot";
$Spell::index[darkshot] = 36;
$Spell::name[36] = "Dark Magic";
$Spell::description[36] = "Level 2 Dark Magic.";
$Spell::delay[36] = 1;
$Spell::recoveryTime[36] = 5;
$Spell::damageValue[36] = 50;
$Spell::LOSrange[36] = 100;
$Spell::manaCost[36] = 100;
$Spell::startSound[36] = ActivateAR;
$Spell::endSound[36] = watersplash;
$Spell::classRestrictions[36] = $AllMageClasses;
$Spell::minLevel[36] = 50;
$Spell::groupListCheck[36] = False;
$Spell::Type[36] = $MagicType[Black];
$SkillType[darkshot] = $SkillBlackMagick;

$Spell::keyword[37] = "Surge";
$Spell::index[Surge] = 37;
$Spell::name[37] = "Dark Magic";
$Spell::description[37] = "Level 3 Dark Magic.";
$Spell::delay[37] = 8;
$Spell::recoveryTime[37] = 30;
$Spell::damageValue[37] = 7; // 200 / 30
$Spell::LOSrange[37] = 300;
$Spell::manaCost[37] = 1000;
$Spell::startSound[37] = ultimathunder;
$Spell::endSound[37] = spooky;
$Spell::classRestrictions[37] = $AllMageClasses;
$Spell::minLevel[37] = 200;
$Spell::groupListCheck[37] = False;
$Spell::Type[37] = $MagicType[Black];
$SkillType[Surge] = $SkillBlackMagick;

$Spell::keyword[38] = "Thunder";
$Spell::index[thunder] = 38;
$Spell::name[38] = "Lightning Magic";
$Spell::description[38] = "Lightning Level 1 Magic.";
$Spell::delay[38] = 2;
$Spell::recoveryTime[38] = 6;
$Spell::damageValue[38] = 30;
$Spell::LOSrange[38] = 500;
$Spell::manaCost[38] = 80;
$Spell::startSound[38] = spellstart;
$Spell::endSound[38] = thunderlight;
$Spell::classRestrictions[38] = $AllMageClasses;
$Spell::minLevel[38] = 30;
$Spell::groupListCheck[38] = False;
$Spell::Type[38] = $MagicType[Lightning];
$SkillType[thunder] = $SkillBlackMagick;

$Spell::keyword[39] = "Thundara";
$Spell::index[thundara] = 39;
$Spell::name[39] = "Lightning Magic";
$Spell::description[39] = "Lightning Level 2 Magic.";
$Spell::delay[39] = 2;
$Spell::recoveryTime[39] = 8;
$Spell::damageValue[39] = 50;
$Spell::LOSrange[39] = 500;
$Spell::manaCost[39] = 120;
$Spell::startSound[39] = spellstart;
$Spell::endSound[39] = thunderlight;
$Spell::classRestrictions[39] = $AllMageClasses;
$Spell::minLevel[39] = 50;
$Spell::groupListCheck[39] = False;
$Spell::Type[39] = $MagicType[Lightning];
$SkillType[thundara] = $SkillBlackMagick;

$Spell::keyword[40] = "Thundaga";
$Spell::index[thundaga] = 40;
$Spell::name[40] = "Lightning Magic";
$Spell::description[40] = "Lightning Level 3 Magic.";
$Spell::delay[40] = 2;
$Spell::recoveryTime[40] = 9;
$Spell::damageValue[40] = 70;
$Spell::LOSrange[40] = 500;
$Spell::manaCost[40] = 160;
$Spell::startSound[40] = spellstart;
$Spell::endSound[40] = thunderlight;
$Spell::classRestrictions[40] = $AllMageClasses;
$Spell::minLevel[40] = 70;
$Spell::groupListCheck[40] = False;
$Spell::Type[40] = $MagicType[Lightning];
$SkillType[thundaga] = $SkillBlackMagick;

$Spell::keyword[41] = "ThunderStorm";
$Spell::index[thunderstorm] = 41;
$Spell::name[41] = "Lightning Magic";
$Spell::description[41] = "Lightning Level 4 Magic.";
$Spell::delay[41] = 4;
$Spell::recoveryTime[41] = 30;
$Spell::damageValue[41] = 17; // 150 / 9
$Spell::LOSrange[41] = 500;
$Spell::manaCost[41] = 300;
$Spell::startSound[41] = spellstart;
$Spell::endSound[41] = thunderlight;
$Spell::radius[41] = "20";
$Spell::classRestrictions[41] = $AllMageClasses;
$Spell::minLevel[41] = 150;
$Spell::groupListCheck[41] = False;
$Spell::Type[41] = $MagicType[Lightning];
$SkillType[thunderstorm] = $SkillBlackMagick;

$Spell::keyword[42] = "Aero";
$Spell::index[aero] = 42;
$Spell::name[42] = "Wind Magic";
$Spell::description[42] = "Wind Level 1 Magic.";
$Spell::delay[42] = 2;
$Spell::recoveryTime[42] = 6;
$Spell::damageValue[42] = 15; // 30
$Spell::LOSrange[42] = 500;
$Spell::manaCost[42] = 40;
$Spell::startSound[42] = spellstart;
$Spell::endSound[42] = thunderlight;
$Spell::radius[42] = "10";
$Spell::classRestrictions[42] = $AllMageClasses;
$Spell::minLevel[42] = 15;
$Spell::groupListCheck[42] = False;
$Spell::Type[42] = $MagicType[Wind];
$SkillType[aero] = $SkillBlackMagick;

$Spell::keyword[43] = "Aerora";
$Spell::index[aerora] = 43;
$Spell::name[43] = "Wind Magic";
$Spell::description[43] = "Wind Level 2 Magic.";
$Spell::delay[43] = 2;
$Spell::recoveryTime[43] = 6;
$Spell::damageValue[43] = 35;
$Spell::LOSrange[43] = 500;
$Spell::manaCost[43] = 100;
$Spell::startSound[43] = spellstart;
$Spell::endSound[43] = thunderlight;
$Spell::radius[43] = "10";
$Spell::classRestrictions[43] = $AllMageClasses;
$Spell::minLevel[43] = 35;
$Spell::groupListCheck[43] = False;
$Spell::Type[43] = $MagicType[Wind];
$SkillType[aerora] = $SkillBlackMagick;

$Spell::keyword[44] = "Aeroga";
$Spell::index[aeroga] = 44;
$Spell::name[44] = "Wind Magic";
$Spell::description[44] = "Wind Level 3 Magic.";
$Spell::delay[44] = 3;
$Spell::recoveryTime[44] = 7;
$Spell::damageValue[44] = 50;
$Spell::LOSrange[44] = 500;
$Spell::manaCost[44] = 320;
$Spell::startSound[44] = spellstart;
$Spell::endSound[44] = thunderlight;
$Spell::radius[44] = "15";
$Spell::classRestrictions[44] = $AllMageClasses;
$Spell::minLevel[44] = 50;
$Spell::groupListCheck[44] = False;
$Spell::Type[44] = $MagicType[Wind];
$SkillType[aeroga] = $SkillBlackMagick;

$Spell::keyword[45] = "Tornado";
$Spell::index[Tornado] = 45;
$Spell::name[45] = "Wind Magic";
$Spell::description[45] = "Wind Level 4 Magic.";
$Spell::delay[45] = 4;
$Spell::recoveryTime[45] = 10;
$Spell::damageValue[45] = 5; // 150 / 30
$Spell::LOSrange[45] = 500;
$Spell::manaCost[45] = 640;
$Spell::startSound[45] = spellstart;
$Spell::endSound[45] = thunderlight;
$Spell::radius[45] = "20";
$Spell::classRestrictions[45] = $AllMageClasses;
$Spell::minLevel[45] = 150;
$Spell::groupListCheck[45] = False;
$Spell::Type[45] = $MagicType[Wind];
$SkillType[Tornado] = $SkillBlackMagick;

$Spell::keyword[46] = "WindArrow";
$Spell::index[windarrow] = 46;
$Spell::name[46] = "Magic Arrow Ranger Mag.";
$Spell::description[46] = "Fire a magical arrow : elemental Wind.";
$Spell::delay[46] = 0;
$Spell::recoveryTime[46] = 5;
$Spell::damageValue[46] = 15;
$Spell::LOSrange[46] = 800;
$Spell::manaCost[46] = 40;
$Spell::startSound[46] = activateAR;
$Spell::endSound[46] = portal1;
$Spell::classRestrictions[46] = "Archer";
$Spell::minLevel[46] = 10;
$Spell::groupListCheck[46] = False;
$Spell::Type[46] = $MagicType[Wind];
$SkillType[windarrow] = $SkillBows;

$Spell::keyword[47] = "FireArrow";
$Spell::index[firearrow] = 47;
$Spell::name[47] = "Magic Arrow Ranger Mag.";
$Spell::description[47] = "Fire a magical arrow : elemental Fire.";
$Spell::delay[47] = 0;
$Spell::recoveryTime[47] = 10;
$Spell::damageValue[47] = 25;
$Spell::LOSrange[47] = 800;
$Spell::manaCost[47] = 100;
$Spell::startSound[47] = activateAR;
$Spell::endSound[47] = portal1;
$Spell::classRestrictions[47] = "Archer";
$Spell::minLevel[47] = 20;
$Spell::groupListCheck[47] = False;
$Spell::Type[47] = $MagicType[Fire];
$SkillType[firearrow] = $SkillBows;

$Spell::keyword[48] = "IceArrow";
$Spell::index[icearrow] = 48;
$Spell::name[48] = "Magic Arrow Ranger Mag.";
$Spell::description[48] = "Fire a magical arrow : elemental Ice.";
$Spell::delay[48] = 0;
$Spell::recoveryTime[48] = 15;
$Spell::damageValue[48] = 35;
$Spell::LOSrange[48] = 800;
$Spell::manaCost[48] = 160;
$Spell::startSound[48] = activateAR;
$Spell::endSound[48] = portal1;
$Spell::classRestrictions[48] = "Archer";
$Spell::minLevel[48] = 30;
$Spell::groupListCheck[48] = False;
$Spell::Type[42] = $MagicType[Ice];
$SkillType[icearrow] = $SkillBows;

$Spell::keyword[49] = "blockfront";
$Spell::index[blockfront] = 49;
$Spell::name[49] = "Utility Magic";
$Spell::description[49] = "Barrier Magic.";
$Spell::delay[49] = 2;
$Spell::recoveryTime[49] = 5;
$Spell::damageValue[49] = 0;
$Spell::LOSrange[49] = 200;
$Spell::manaCost[49] = 40;
$Spell::startSound[49] = spellstart;
$Spell::endSound[49] = ActivateAR;
$Spell::classRestrictions[49] = "WhiteMage";
$Spell::minLevel[49] = 10;
$Spell::groupListCheck[49] = False;
$SkillType[blockfront] = $SkillSummonMagick;

$Spell::keyword[50] = "blockback";
$Spell::index[blockback] = 50;
$Spell::name[50] = "Utility Magic";
$Spell::description[50] = "Barrier Magic.";
$Spell::delay[50] = 1;
$Spell::recoveryTime[50] = 4;
$Spell::damageValue[50] = 0;
$Spell::LOSrange[50] = 200;
$Spell::manaCost[50] = 40;
$Spell::startSound[50] = spellstart;
$Spell::endSound[50] = ActivateAR;
$Spell::classRestrictions[50] = "WhiteMage";
$Spell::minLevel[50] = 10;
$Spell::groupListCheck[50] = False;
$SkillType[blockback] = $SkillSummonMagick;

$Spell::keyword[51] = "light";
$Spell::index[light] = 51;
$Spell::name[51] = "Utility Magic";
$Spell::description[51] = "Beam Magic.";
$Spell::delay[51] = 0;
$Spell::recoveryTime[51] = 20;
$Spell::damageValue[51] = null;
$Spell::LOSrange[51] = 200;
$Spell::manaCost[51] = 30;
$Spell::startSound[51] = spellstart;
$Spell::endSound[51] = ActivateAR;
$Spell::classRestrictions[51] = $AllMageClasses;
$Spell::minLevel[51] = 10;
$Spell::groupListCheck[51] = False;
$SkillType[light] = $SkillSummonMagick;

// $Spell::keyword[52] = "goods";
// $Spell::index[goods] = 52;
// $Spell::name[52] = "Utility Magic";
// $Spell::description[52] = "Converts MP to STA.";
// $Spell::delay[52] = 1.5;
// $Spell::recoveryTime[52] = 4.5;
// $Spell::damageValue[52] = -100;
// $Spell::manaCost[52] = 50;
// $Spell::startSound[52] = DeActivateWA;
// $Spell::endSound[52] = ActivateAR;
// $Spell::classRestrictions[52] = "WhiteMage";
// $Spell::minLevel[52] = 20;
// $Spell::groupListCheck[52] = False;

// $Spell::keyword[53] = "goods2";
// $Spell::index[goods2] = 53;
// $Spell::name[53] = "Utility Magic";
// $Spell::description[53] = "Converts MP to STA.";
// $Spell::delay[53] = 1.5;
// $Spell::recoveryTime[53] = 7;
// $Spell::damageValue[53] = -200;
// $Spell::manaCost[53] = 100;
// $Spell::startSound[53] = DeActivateWA;
// $Spell::endSound[53] = ActivateAR;
// $Spell::classRestrictions[53] = "WhiteMage";
// $Spell::minLevel[53] = 40;
// $Spell::groupListCheck[53] = False;

// $Spell::keyword[54] = "goods3";
// $Spell::index[goods3] = 54;
// $Spell::name[54] = "Utility Magic";
// $Spell::description[54] = "Converts MP to STA.";
// $Spell::delay[54] = 1.5;
// $Spell::recoveryTime[54] = 9;
// $Spell::damageValue[54] = -300;
// $Spell::manaCost[54] = 120;
// $Spell::startSound[54] = DeActivateWA;
// $Spell::endSound[54] = ActivateAR;
// $Spell::classRestrictions[54] = "WhiteMage";
// $Spell::minLevel[54] = 60;
// $Spell::groupListCheck[54] = False;

// $Spell::keyword[55] = "goods4";
// $Spell::index["goods4"] = %index;
// $Spell::name[55] = "Utility Magic";
// $Spell::description[55] = "Converts MP to STA.";
// $Spell::delay[55] = 2.5;
// $Spell::recoveryTime[55] = 14;
// $Spell::damageValue[55] = -999;
// $Spell::manaCost[55] = 275;
// $Spell::startSound[55] = DeActivateWA;
// $Spell::endSound[55] = ActivateAR;
// $Spell::classRestrictions[55] = "WhiteMage";
// $Spell::minLevel[55] = 100;
// $Spell::groupListCheck[55] = False;

%index = 56;
$Spell::keyword[%index] = "death";
$Spell::index[$Spell::keyword[%index]] = %index;
$Spell::name[%index] = "Death Summon";
$Spell::description[%index] = "Level 100 Summon.";
$Spell::delay[%index] = 6;
$Spell::recoveryTime[%index] = 40;
$Spell::damageValue[%index] = 120;
$Spell::LOSrange[%index] = 200;
$Spell::manaCost[%index] = 500;
$Spell::startSound[%index] = summonchant;
$Spell::endSound[%index] = hadesgrr;
$Spell::classRestrictions[%index] = "Summoner";
$Spell::minLevel[%index] = 100;
$Spell::groupListCheck[%index] = False;
$Spell::classRestrictions[51] = "Summoner";
$SkillType[death] = $SkillSummonMagick;

%index = 57;
$Spell::keyword[%index] = "rock";
$Spell::index[$Spell::keyword[%index]] = %index;
$Spell::name[%index] = "Rock Summon";
$Spell::description[%index] = "Level 10 Summon.";
$Spell::delay[%index] = 4;
$Spell::recoveryTime[%index] = 10;
$Spell::damageValue[%index] = 20;
$Spell::LOSrange[%index] = 200;
$Spell::manaCost[%index] = 50;
$Spell::startSound[%index] = summonchant;
$Spell::endSound[%index] = shockExplosion;
$Spell::classRestrictions[%index] = "Summoner";
$Spell::minLevel[%index] = 10;
$Spell::groupListCheck[%index] = False;
$SkillType[rock] = $SkillSummonMagick;

%index = 58;
$Spell::keyword[%index] = "shiva";
$Spell::index[$Spell::keyword[%index]] = %index;
$Spell::name[%index] = "Shiva Summon";
$Spell::description[%index] = "Level 20 Summon.";
$Spell::delay[%index] = 4;
$Spell::recoveryTime[%index] = 14;
$Spell::damageValue[%index] = 40;
$Spell::LOSrange[%index] = 150;
$Spell::manaCost[%index] = 100;
$Spell::startSound[%index] = summonchant;
$Spell::endSound[%index] = shockExplosion;
$Spell::classRestrictions[%index] = "Summoner";
$Spell::minLevel[%index] = 20;
$Spell::groupListCheck[%index] = False;
$SkillType[shiva] = $SkillSummonMagick;

%index = 59;
$Spell::keyword[%index] = "battle";
$Spell::index[$Spell::keyword[%index]] = %index;
$Spell::name[%index] = "Battle Summon";
$Spell::description[%index] = "Level 30 Summon.";
$Spell::delay[%index] = 4;
$Spell::recoveryTime[%index] = 10;
$Spell::damageValue[%index] = 60;
$Spell::LOSrange[%index] = 200;
$Spell::manaCost[%index] = 100;
$Spell::startSound[%index] = summonchant;
$Spell::endSound[%index] = shockExplosion;
$Spell::classRestrictions[%index] = "Summoner";
$Spell::minLevel[%index] = 30;
$Spell::groupListCheck[%index] = False;
$SkillType[battle] = $SkillSummonMagick;

%index = 60;
$Spell::keyword[%index] = "sapper";
$Spell::index[$Spell::keyword[%index]] = %index;
$Spell::name[%index] = "Sapper Summon";
$Spell::description[%index] = "Level 40 Summon.";
$Spell::delay[%index] = 4;
$Spell::recoveryTime[%index] = 12;
$Spell::damageValue[%index] = 65;
$Spell::LOSrange[%index] = 250;
$Spell::manaCost[%index] = 350;
$Spell::startSound[%index] = summonchant;
$Spell::endSound[%index] = shockExplosion;
$Spell::classRestrictions[%index] = "Summoner";
$Spell::minLevel[%index] = 50;
$Spell::groupListCheck[%index] = False;
$SkillType[sapper] = $SkillSummonMagick;

%index = 61;
$Spell::keyword[%index] = "pem315";
$Spell::index[$Spell::keyword[%index]] = %index;
$Spell::name[%index] = "Ashes to ashes";
$Spell::description[%index] = "Ashes to ashes.";
$Spell::delay[%index] = 1.0;
$Spell::recoveryTime[%index] = 2;
$Spell::LOSrange[%index] = 200;
$Spell::damageValue[%index] = 1;
$Spell::manaCost[%index] = 100;
$Spell::startSound[%index] = LoopSP;
$Spell::endSound[%index] = AbsorbABS;
$Spell::classRestrictions[%index] = "Cleric Druid Ranger Paladin Fighter Thief Bard Mage Summoner";
$Spell::minLevel[%index] = 1;
$Spell::groupListCheck[%index] = False;
$SkillType[pem315] = $SkillSummonMagick;

%index = 62;
$Spell::keyword[%index] = "doppelgang";
$Spell::index[$Spell::keyword[%index]] = %index;
$Spell::name[%index] = "Dopplegang";
$Spell::description[%index] = "Copy the form of an enemy.";
$Spell::delay[%index] = 4.0;
$Spell::recoveryTime[%index] = 60;
$Spell::LOSrange[%index] = 80;
$Spell::damageValue[%index] = 0;
$Spell::manaCost[%index] = 200;
$Spell::startSound[%index] = LoopSP;
$Spell::endSound[%index] = AbsorbABS;
$Spell::classRestrictions[%index] = "Summoner";
$Spell::minLevel[%index] = 100;
$Spell::groupListCheck[%index] = False;
$SkillType[doppelgang] = $SkillSummonMagick;


//================= RECALL RUNES
%index = 63;
$Spell::keyword[%index] = "setrecall";
$Spell::index[$Spell::keyword[%index]] = %index;
$Spell::name[%index] = "Set Recall.";
$Spell::description[%index] = "Set recall position. (#cast setrecall [rune color])";
$Spell::delay[%index] = 4.0;
$Spell::recoveryTime[%index] = 6;
$Spell::LOSrange[%index] = 0;
$Spell::damageValue[%index] = 0;
$Spell::manaCost[%index] = 15;
$Spell::startSound[%index] = LoopSP;
$Spell::endSound[%index] = AbsorbABS;
$Spell::classRestrictions[%index] = "Cleric Druid Ranger Paladin Fighter Thief Bard Mage Summoner";
$Spell::minLevel[%index] = 20;
$Spell::groupListCheck[%index] = False;

%index = 64;
$Spell::keyword[%index] = "recall";
$Spell::index[$Spell::keyword[%index]] = %index;
$Spell::name[%index] = "Recall";
$Spell::description[%index] = "Recall to last set position. (#cast recall [rune color])";
$Spell::delay[%index] = 4.0;
$Spell::recoveryTime[%index] = 8;
$Spell::LOSrange[%index] = 0;
$Spell::damageValue[%index] = 0;
$Spell::manaCost[%index] = 15;
$Spell::startSound[%index] = LoopSP;
$Spell::endSound[%index] = AbsorbABS;
$Spell::classRestrictions[%index] = "Cleric Druid Ranger Paladin Fighter Thief Bard Mage Summoner";
$Spell::minLevel[%index] = 20;
$Spell::groupListCheck[%index] = False;


%index = 65;
$Spell::keyword[%index] = "Medic5";
$Spell::index["Medic5"] = %index;
$Spell::name[%index] = "Healing Magic";
$Spell::description[%index] = "Restores caster or LOS.";
$Spell::delay[%index] = 1.5;
$Spell::recoveryTime[%index] = 40;
$Spell::damageValue[%index] = -99999;
$Spell::LOSrange[%index] = 500;
$Spell::manaCost[%index] = 200;
$Spell::startSound[%index] = DeActivateWA;
$Spell::endSound[%index] = bigheal;
$Spell::classRestrictions[%index] = "WhiteMage";
$Spell::minLevel[%index] = 150;
$Spell::Type[%index] = $MagicType[White];
$Spell::groupListCheck[%index] = False;

%index = 66;
$Spell::keyword[%index] = "BlockHigh";
$Spell::index[blockhigh] = %index;
$Spell::name[%index] = "Utility Magic";
$Spell::description[%index] = "Barrier Magic.";
$Spell::delay[%index] = 1;
$Spell::recoveryTime[%index] = 4;
$Spell::damageValue[%index] = 0;
$Spell::LOSrange[%index] = 200;
$Spell::manaCost[%index] = 40;
$Spell::startSound[%index] = spellstart;
$Spell::endSound[%index] = ActivateAR;
$Spell::classRestrictions[%index] = "WhiteMage";
$Spell::minLevel[%index] = 10;
$Spell::groupListCheck[%index] = False;

%index = 67;
$Spell::keyword[%index] = "Cage";
$Spell::index[Cage] = %index;
$Spell::name[%index] = "Utility Magic";
$Spell::description[%index] = "Trap Magic.";
$Spell::delay[%index] = 0.9;
$Spell::recoveryTime[%index] = 20;
$Spell::damageValue[%index] = 0;
$Spell::LOSrange[%index] = 10;
$Spell::manaCost[%index] = 40;
$Spell::startSound[%index] = spellstart;
$Spell::endSound[%index] = ActivateAR;
$Spell::classRestrictions[%index] = "WhiteMage";
$Spell::minLevel[%index] = 5;
$Spell::groupListCheck[%index] = False;

%index = 68;
$Spell::keyword[%index] = "fix";
$Spell::index[$Spell::keyword[%index]] = %index;
$Spell::name[%index] = "fix";
$Spell::description[%index] = "Basic spell that is used to fix dmg bug.";
$Spell::delay[%index] = 20.0;
$Spell::recoveryTime[%index] = 50;
$Spell::LOSrange[%index] = 200;
$Spell::damageValue[%index] = 0;
$Spell::manaCost[%index] = 1;
$Spell::startSound[%index] = LoopSP;
$Spell::endSound[%index] = AbsorbABS;
$Spell::classRestrictions[%index] = "Archer Paladin Fighter Thief Bard Mage Summoner";
$Spell::minLevel[%index] = 1;
$Spell::groupListCheck[%index] = False;

%index = 69;
$Spell::keyword[69] = "remort";
$Spell::index[remort] = 69;
$Spell::name[69] = "Remort";
$Spell::description[69] = "Remorts a level 101 character to level 1, with bonuses.";
$Spell::delay[69] = 3.0;
$Spell::recoveryTime[69] = 1;
$Spell::damageValue[69] = 0;
$Spell::manaCost[69] = 1;
$Spell::startSound[69] = RespawnA;
$Spell::endSound[69] = RespawnC;
$Spell::groupListCheck[69] = False;
$Spell::refVal[69] = 0;
$Spell::graceDistance[69] = 2;
$SkillType[remort] = $SkillTimeMagick;

$Spell::keyword[70] = "shadowblade";
$Spell::index[shadowblade] = 70;
$Spell::name[70] = "Shadow Blade";
$Spell::description[70] = "Casts Shadow Blade.";
$Spell::delay[70] = 3;
$Spell::recoveryTime[70] = 10;
$Spell::radius[70] = 30;
$Spell::damageValue[70] = "320";
$Spell::LOSrange[70] = 999; // 8
$Spell::manaCost[70] = 500;
$Spell::radius[70] = 50;
$Spell::startSound[70] = PlaceSeal;
$Spell::endSound[70] = Explode3FW;
$Spell::groupListCheck[70] = False;
$Spell::refVal[70] = 320;
$Spell::graceDistance[70] = 2;
$Spell::classRestrictions[70] = "DeathKnight";
$Spell::minLevel[70] = 100;
$SkillType[shadowblade] = $SkillBlackMagick;

// // fire flask spell
$Spell::keyword[71] = "fireflaskbomb";
$Spell::index[fireflaskbomb] = 71;
$Spell::name[71] = "Fire Flask Bomb";
$Spell::description[71] = "fire flask bomb explosion.";
$Spell::delay[71] = 3;
$Spell::recoveryTime[71] = 3;
$Spell::radius[71] = 10;
$Spell::damageValue[71] = "20";
$Spell::LOSrange[71] = 999; // 80
$Spell::manaCost[71] = 1;
$Spell::startSound[71] = PlaceSeal;
$Spell::endSound[71] = LaunchFB;
$Spell::groupListCheck[71] = False;
$Spell::refVal[71] = -9998;
$Spell::graceDistance[71] = 10;
$Spell::elementalType[71] = $ElementalFire;
$SkillType[fireflaskbomb] = $SkillAlchemy;

// // ice flask spell
$Spell::keyword[72] = "iceflaskbomb";
$Spell::index[iceflaskbomb] = 72;
$Spell::name[72] = "Ice Flask Bomb";
$Spell::description[72] = "ice flask bomb explosion.";
$Spell::delay[72] = 3;
$Spell::recoveryTime[72] = 3;
$Spell::radius[72] = 10;
$Spell::damageValue[72] = "40";
$Spell::LOSrange[72] = 999; // 80
$Spell::manaCost[72] = 1;
$Spell::startSound[72] = PlaceSeal;
$Spell::endSound[72] = LaunchFB;
$Spell::groupListCheck[72] = False;
$Spell::refVal[72] = -9998;
$Spell::graceDistance[72] = 10;
$Spell::elementalType[72] = $ElementalIce;
$SkillType[iceflaskbomb] = $SkillAlchemy;

// // lightning flask spell
$Spell::keyword[73] = "lightningflaskbomb";
$Spell::index[lightningflaskbomb] = 73;
$Spell::name[73] = "Lightning Flask Bomb";
$Spell::description[73] = "lightning flask bomb explosion.";
$Spell::delay[73] = 3;
$Spell::recoveryTime[73] = 3;
$Spell::radius[73] = 10;
$Spell::damageValue[73] = "60";
$Spell::LOSrange[73] = 999; // 80
$Spell::manaCost[73] = 1;
$Spell::startSound[73] = PlaceSeal;
$Spell::endSound[73] = LaunchFB;
$Spell::groupListCheck[73] = False;
$Spell::refVal[73] = -9998;
$Spell::graceDistance[73] = 10;
$Spell::elementalType[73] = $ElementalLightning;
$SkillType[lightningflaskbomb] = $SkillAlchemy;

// // earth flask spell
$Spell::keyword[74] = "earthflaskbomb";
$Spell::index[earthflaskbomb] = 74;
$Spell::name[74] = "Earth Flask Bomb";
$Spell::description[74] = "earth flask bomb explosion.";
$Spell::delay[74] = 3;
$Spell::recoveryTime[74] = 3;
$Spell::radius[74] = 10;
$Spell::damageValue[74] = "80";
$Spell::LOSrange[74] = 999; // 80
$Spell::manaCost[74] = 1;
$Spell::startSound[74] = PlaceSeal;
$Spell::endSound[74] = LaunchFB;
$Spell::groupListCheck[74] = False;
$Spell::refVal[74] = -9998;
$Spell::graceDistance[74] = 10;
$Spell::elementalType[74] = $ElementalEarth;
$SkillType[earthflaskbomb] = $SkillAlchemy;

// // acid flask spell
$Spell::keyword[75] = "acidflaskbomb";
$Spell::index[acidflaskbomb] = 75;
$Spell::name[75] = "Acid Flask Bomb";
$Spell::description[75] = "acid flask bomb explosion.";
$Spell::delay[75] = 3;
$Spell::recoveryTime[75] = 3;
$Spell::radius[75] = 10;
$Spell::damageValue[75] = "100";
$Spell::LOSrange[75] = 999; // 80
$Spell::manaCost[75] = 1;
$Spell::startSound[75] = PlaceSeal;
$Spell::endSound[75] = LaunchFB;
$Spell::groupListCheck[75] = False;
$Spell::refVal[75] = -9998;
$Spell::graceDistance[75] = 10;
$Spell::elementalType[75] = $ElementalPoison;
$SkillType[acidflaskbomb] = $SkillAlchemy;

// // exposive shot explosion
$Spell::keyword[76] = "explosiveshotexplosion";
$Spell::index[explosiveshotexplosion] = 76;
$Spell::name[76] = "Explosive Shot";
$Spell::description[76] = "The explosion caused by the explosive shot.";
$Spell::delay[76] = 3;
$Spell::recoveryTime[76] = 3;
$Spell::radius[76] = 10;
$Spell::damageValue[76] = "190";
$Spell::LOSrange[76] = 999; // 80
$Spell::manaCost[76] = 1;
// $Spell::startSound[76] = PlaceSeal;
// $Spell::endSound[76] = LaunchFB;
$Spell::groupListCheck[76] = False;
$Spell::refVal[76] = -9998;
$Spell::graceDistance[76] = 10;
$Spell::elementalType[76] = $ElementalFire;
$SkillType[explosiveshotexplosion] = $SkillBows;

// // exposive shot explosion
$Spell::keyword[77] = "haste";
$Spell::index[haste] = 77;
$Spell::name[77] = "Haste";
$Spell::description[77] = "Lowers all cooldowns for skills and spells.";
$Spell::delay[77] = 2.5;
$Spell::recoveryTime[77] = 3.5;
$Spell::duration[77] = 30;
$Spell::damageValue[77] = "0";
$Spell::LOSrange[77] = 0; // 80
$Spell::manaCost[77] = 100;
$Spell::startSound[77] = PlaceSeal;
$Spell::endSound[77] = ActivateCH;
$Spell::groupListCheck[77] = False;
$Spell::refVal[77] = -9998;
$Spell::graceDistance[77] = 1;
$Spell::classRestrictions[77] = "TimeMage Summoner Spellbow Spellblade DarkKnight ArcaneArcher Arcanist Hexblade";
// $Spell::elementalType[77] = $ElementalFire;
$SkillType[haste] = $SkillTimeMagick;

// // exposive shot explosion
$Spell::keyword[78] = "blackhole";
$Spell::index[blackhole] = 78;
$Spell::name[78] = "Black Hole";
$Spell::description[78] = "Creates a black hole that pulls in nearby enemies.";
$Spell::delay[78] = 2;
$Spell::recoveryTime[78] = 8;
$Spell::damageValue[78] = "100";
$Spell::LOSrange[78] = 100; // 80
$Spell::radius[78] = 30; // 100
$Spell::manaCost[78] = 500;
$Spell::startSound[78] = PlaceSeal;
// $Spell::endSound[78] = ActivateCH;
$Spell::groupListCheck[78] = False;
$Spell::refVal[78] = -9998;
$Spell::graceDistance[78] = 1;
$Spell::classRestrictions[78] = "TimeMage Summoner Spellbow Spellblade DarkKnight ArcaneArcher Arcanist Hexblade";
$Spell::minLevel[78] = 50;
// $Spell::elementalType[78] = $ElementalFire;
$SkillType[blackhole] = $SkillTimeMagick;

$Spell::keyword[79] = "regen";
$Spell::index[regen] = 79;
$Spell::name[79] = "Regen";
$Spell::description[79] = "Regenerates a target's health over time.";
$Spell::delay[79] = 2;
$Spell::recoveryTime[79] = 2;
$Spell::damageValue[79] = "10";
$Spell::duration[79] = "30";
$Spell::LOSrange[79] = 10; // 80
$Spell::radius[79] = 40; // 100
$Spell::manaCost[79] = 50;
$Spell::startSound[79] = PlaceSeal;
// $Spell::endSound[79] = ActivateCH;
$Spell::groupListCheck[79] = False;
$Spell::refVal[79] = -9998;
$Spell::graceDistance[79] = 1;
// $Spell::classRestrictions[79] = $WhiteMagicClasses;
$Spell::minLevel[79] = 1;
// $Spell::elementalType[79] = $ElementalFire;
$SkillType[regen] = $SkillTimeMagick;

$Spell::keyword[80] = "regen2";
$Spell::index[regen2] = 80;
$Spell::name[80] = "Regen2";
$Spell::description[80] = "Regenerates a target's health over time.";
$Spell::delay[80] = 2;
$Spell::recoveryTime[80] = 2;
$Spell::damageValue[80] = "20";
$Spell::duration[80] = "30";
$Spell::LOSrange[80] = 10; // 80
$Spell::radius[80] = 40; // 100
$Spell::manaCost[80] = 200;
$Spell::startSound[80] = PlaceSeal;
// $Spell::endSound[80] = ActivateCH;
$Spell::groupListCheck[80] = False;
$Spell::refVal[80] = -9998;
$Spell::graceDistance[80] = 1;
$Spell::classRestrictions[80] = $WhiteMagicClasses;
$Spell::minLevel[80] = 1;
// $Spell::elementalType[80] = $ElementalFire;
$SkillType[regen2] = $SkillTimeMagick;

$Spell::keyword[81] = "regen3";
$Spell::index[regen3] = 81;
$Spell::name[81] = "Regen3";
$Spell::description[81] = "Regenerates a target's health over time.";
$Spell::delay[81] = 2;
$Spell::recoveryTime[81] = 2;
$Spell::damageValue[81] = "30";
$Spell::duration[81] = "30";
$Spell::LOSrange[81] = 10; // 80
$Spell::radius[81] = 40; // 100
$Spell::manaCost[81] = 450;
$Spell::startSound[81] = PlaceSeal;
// $Spell::endSound[81] = ActivateCH;
$Spell::groupListCheck[81] = False;
$Spell::refVal[81] = -9998;
$Spell::graceDistance[81] = 1;
$Spell::classRestrictions[81] = $WhiteMagicClasses;
$Spell::minLevel[81] = 1;
// $Spell::elementalType[81] = $ElementalFire;
$SkillType[regen3] = $SkillTimeMagick;

$Spell::keyword[82] = "regen4";
$Spell::index[regen4] = 82;
$Spell::name[82] = "Regen4";
$Spell::description[82] = "Regenerates a target's health over time.";
$Spell::delay[82] = 2;
$Spell::recoveryTime[82] = 2;
$Spell::damageValue[82] = "40";
$Spell::duration[82] = "30";
$Spell::LOSrange[82] = 10; // 80
$Spell::radius[82] = 40; // 100
$Spell::manaCost[82] = 600;
$Spell::startSound[82] = PlaceSeal;
// $Spell::endSound[82] = ActivateCH;
$Spell::groupListCheck[82] = False;
$Spell::refVal[82] = -9998;
$Spell::graceDistance[82] = 1;
$Spell::classRestrictions[82] = $WhiteMagicClasses;
$Spell::minLevel[82] = 1;
// $Spell::elementalType[82] = $ElementalFire;
$SkillType[regen4] = $SkillTimeMagick;

$Spell::keyword[83] = "hex";
$Spell::index[hex] = 83;
$Spell::name[83] = "Hex";
$Spell::description[83] = "Curses a target, causing damage over time.";
$Spell::delay[83] = 2;
$Spell::recoveryTime[83] = 2;
$Spell::damageValue[83] = "-5";
$Spell::duration[83] = "30";
$Spell::LOSrange[83] = 10; // 80
$Spell::radius[83] = 40; // 100
$Spell::manaCost[83] = 100;
$Spell::startSound[83] = Portal11;
// $Spell::endSound[83] = ActivateCH;
$Spell::groupListCheck[83] = False;
$Spell::refVal[83] = -9998;
$Spell::graceDistance[83] = 1;
$Spell::classRestrictions[83] = ""; // $WhiteMagicClasses;
$Spell::minLevel[83] = 10;
// $Spell::elementalType[83] = $ElementalFire;
$SkillType[hex] = $WhiteMagicClasses;

$Spell::keyword[84] = "vex";
$Spell::index[vex] = 84;
$Spell::name[84] = "Vex";
$Spell::description[84] = "Curses a target, causing damage over time.";
$Spell::delay[84] = 2;
$Spell::recoveryTime[84] = 2;
$Spell::damageValue[84] = "-10";
$Spell::duration[84] = "30";
$Spell::LOSrange[84] = 10; // 80
$Spell::radius[84] = 40; // 100
$Spell::manaCost[84] = 200;
$Spell::startSound[84] = Portal11;
// $Spell::endSound[84] = ActivateCH;
$Spell::groupListCheck[84] = False;
$Spell::refVal[84] = -9998;
$Spell::graceDistance[84] = 1;
$Spell::classRestrictions[84] = $WhiteMagicClasses;
$Spell::minLevel[84] = 25;
// $Spell::elementalType[84] = $ElementalFire;
$SkillType[vex] = $WhiteMagicClasses;

$Spell::keyword[85] = "curse";
$Spell::index[curse] = 85;
$Spell::name[85] = "Curse";
$Spell::description[85] = "Curses a target, causing damage over time.";
$Spell::delay[85] = 2;
$Spell::recoveryTime[85] = 2;
$Spell::damageValue[85] = "-25";
$Spell::duration[85] = "30";
$Spell::LOSrange[85] = 10; // 80
$Spell::radius[85] = 40; // 100
$Spell::manaCost[85] = 300;
$Spell::startSound[85] = Portal11;
// $Spell::endSound[85] = ActivateCH;
$Spell::groupListCheck[85] = False;
$Spell::refVal[85] = -9998;
$Spell::graceDistance[85] = 1;
$Spell::classRestrictions[85] = $WhiteMagicClasses;
$Spell::minLevel[85] = 50;
// $Spell::elementalType[85] = $ElementalFire;
$SkillType[curse] = $WhiteMagicClasses;

$Spell::keyword[86] = "plague";
$Spell::index[plague] = 86;
$Spell::name[86] = "Plague";
$Spell::description[86] = "Curses a target, causing damage over time.";
$Spell::delay[86] = 2;
$Spell::recoveryTime[86] = 2;
$Spell::damageValue[86] = "-50";
$Spell::duration[86] = "30";
$Spell::LOSrange[86] = 10; // 80
$Spell::radius[86] = 40; // 100
$Spell::manaCost[86] = 400;
$Spell::startSound[86] = Portal11;
// $Spell::endSound[86] = ActivateCH;
$Spell::groupListCheck[86] = False;
$Spell::refVal[86] = -9998;
$Spell::graceDistance[86] = 1;
$Spell::classRestrictions[86] = $WhiteMagicClasses;
$Spell::minLevel[86] = 75;
// $Spell::elementalType[86] = $ElementalFire;
$SkillType[plague] = $WhiteMagicClasses;

$Spell::keyword[87] = "blackdeath";
$Spell::index[blackdeath] = 87;
$Spell::name[87] = "Black Death";
$Spell::description[87] = "Curses a target, causing damage over time.";
$Spell::delay[87] = 2;
$Spell::recoveryTime[87] = 2;
$Spell::damageValue[87] = "-100";
$Spell::duration[87] = "30";
$Spell::LOSrange[87] = 10; // 80
$Spell::radius[87] = 40; // 100
$Spell::manaCost[87] = 500;
$Spell::startSound[87] = Portal11;
// $Spell::endSound[87] = ActivateCH;
$Spell::groupListCheck[87] = False;
$Spell::refVal[87] = -9998;
$Spell::graceDistance[87] = 1;
$Spell::classRestrictions[87] = $WhiteMagicClasses;
$Spell::minLevel[87] = 100;
// $Spell::elementalType[87] = $ElementalFire;
$SkillType[blackdeath] = $WhiteMagicClasses;

// 70 
$Spell::keyword[88] = "holyblade";
$Spell::index[holyblade] = 88;
$Spell::name[88] = "Holy Blade";
$Spell::description[88] = "Casts Holy Blade.";
$Spell::delay[88] = 3;
$Spell::recoveryTime[88] = 10;
$Spell::radius[88] = 30;
$Spell::damageValue[88] = "320";
$Spell::LOSrange[88] = 999; // 8
$Spell::manaCost[88] = 500;
$Spell::radius[88] = 50;
$Spell::startSound[88] = PlaceSeal;
$Spell::endSound[88] = Explode3FW;
$Spell::groupListCheck[88] = False;
$Spell::refVal[88] = 320;
$Spell::graceDistance[88] = 2;
$Spell::classRestrictions[88] = "HolyKnight";
$Spell::minLevel[88] = 100;
$SkillType[holyblade] = $SkillWhiteMagick;

//====================================================================================================================
//====================================================================================================================
//====================================================================================================================
%index="";

function dot_op_genSpellSkill(%index) {

	%tmp = "";

	%INTSkill += (20 / $Spell::recoveryTime[%index]);
	%INTSkill += (80 / $Spell::delay[%index]);

	if($Spell::damageValue[%index] > 0)
		%WISSkill += floor(pow($Spell::damageValue[%index], 1.15));
	else
		%WISSkill += floor(-$Spell::damageValue[%index]*0.02);

	if(%INTSkill > %WISSkill)
		%INTSkill = %INTSkill-30;

	%INTSkill = Cap(floor(%INTSkill), -$MaxAPStats, $MaxAPStats);
	%WISSkill = Cap(floor(%WISSkill), -$MaxAPStats, $MaxAPStats);

	if(%INTSkill > 0)
		%tmp = %tmp@"INT "@%INTSkill@" ";
	if(%WISSkill > 0)
		%tmp = %tmp@"WIS "@%WISSkill@" ";

	if($Spell::minLevel[%index] != "")
		%tmp = %tmp@"LVL "@$Spell::minLevel[%index]@" ";
	if($Spell::classRestrictions[%index] != "")
		%tmp = %tmp@"CLASS "@$Spell::classRestrictions[%index]@" ";

	return %tmp;
}

//deleteVariables("Spell::classRestriction*");
//deleteVariables("Spell::minLevel*");

function IntSpellSkills() {

	$Spell::List = " ";
	for(%i = 1; %i <= 1000; %i++) {

		$Spell::List = $Spell::List@$Spell::keyword[%i]@" ";
		$Spell::ToUseSkill[%i] = %i.genSpellSkill();

		if($Spell::keyword[%i] == "" && %ii++ > 3)
			return;
	}
}

//----------------------------------------------------------------------------------------------------------------


function SpellNum1(%Client, %castObj, %castPos, %w2) {

	%zoneId = GetNearestZone(%Client, %w2, 3);

	if(%zoneId != False) {
		Client::sendMessage(%Client, $MsgBeige, "Teleporting near "@Zone::getDesc(%zoneId));

		%system = Object::getName(%zoneId);
		%type = GetWord(%system, 0);
		%desc = String::getSubStr(%system, String::len(%type)+1, 9999);

		//get the two markers
		%tmpgroup = nameToId("MissionGroup\\Zones\\"@%system);

		%m1pos = GameBase::getPosition(Group::getObject(%tmpgroup, 0));
		%m2pos = GameBase::getPosition(Group::getObject(%tmpgroup, 1));

		%x1 = GetWord(%m2pos, 0);
		%y1 = GetWord(%m2pos, 1);
		%x2 = GetWord(%m1pos, 0);
		%y2 = GetWord(%m1pos, 1);

		%newx = (getRandom() * (%x2-%x1)) + %x1;
		%newy = (getRandom() * (%y2-%y1)) + %y1;
		%newz = GetWord(%m1pos, 2);

		%newpos = %newx@" "@%newy@" "@%newz;

		GameBase::startFadeIn(%Client);
		GameBase::setPosition(%Client, %newpos);

		Player::setDamageFlash(%Client, 0.7);
		%extraDelay = 0.22;	//sometimes the endSound doesn't get played unless there is sufficient delay

		%castPos = SetOnGround(%Client, 500);
		return "returnFlag 1"; //return "returnFlag 1";
	}
	else {
		Client::sendMessage(%Client, $MsgBeige, "Teleportation failed.");
		return "returnFlag 0"; //return "returnFlag 0";
	}
}

function SpellNum2(%Client, %castObj, %castPos, %w2) {

	//Transport zone spell
	%zoneId = GetZoneByKeywords(%Client, %w2, 3);

	if(%zoneId != False) {
		Client::sendMessage(%Client, $MsgBeige, "Transporting to "@Zone::getDesc(%zoneId));

		%system = Object::getName(%zoneId);
		%type = GetWord(%system, 0);
		%desc = String::getSubStr(%system, String::len(%type)+1, 9999);

		%castPos = TeleportToMarker(%Client, "Zones\\"@%system@"\\DropPoints", False, True);

		GameBase::startFadeIn(%Client);

		Player::setDamageFlash(%Client, 0.7);
		%extraDelay = 0.22;	//sometimes the endSound doesn't get played unless there is sufficient delay

		return "returnFlag 1";
	}
	else {
		Client::sendMessage(%Client, $MsgBeige, "Transportation failed.");
		return "returnFlag 0";
	}
}
function SpellNum3(%Client, %castObj, %castPos, %w2) {
	//Advanced Transport zone spell
	%zoneId = GetZoneByKeywords(%Client, %w2, 3);

		if(%zoneId != False) {
			if(getObjectType(%castObj) == "Player")
				%id = Player::getClient(%castObj);
			else
				%id = %Client;

			Client::sendMessage(%Client, $MsgBeige, "Transporting to "@Zone::getDesc(%zoneId));
			if(%Client != %id)
				Client::sendMessage(%id, $MsgBeige, "You are being transported to "@Zone::getDesc(%zoneId));

			%system = Object::getName(%zoneId);
			%type = GetWord(%system, 0);
			%desc = String::getSubStr(%system, String::len(%type)+1, 9999);

			%castPos = TeleportToMarker(%id, "Zones\\"@%system@"\\DropPoints", False, True);

			GameBase::startFadeIn(%id);

		Player::setDamageFlash(%id, 0.7);
		%extraDelay = 0.22;	//sometimes the endSound doesn't get played unless there is sufficient delay

		return "returnFlag 1";
	}
	else {
		Client::sendMessage(%Client, $MsgBeige, "Transportation failed.");
		return "returnFlag 0";
	}
}
function SpellNum4(%Client, %castObj, %castPos) {
	//Medic
	Client::sendMessage(%Client, $MsgGreen, "Healing self");
	%HealId = %Client;
	%r = $Spell::damageValue[4] / $TribesDamageToNumericDamage;
	refreshHP(%Client, %r);

//	%castPos = GameBase::getPosition(%Client);

	return "returnFlag 1"; //return "returnFlag 1";
}
function SpellNum5(%Client, %castObj, %castPos) {
	//Medic 2
	if(getObjectType(%castObj) == "Player")
		%HealId = Player::getClient(%castObj);
	else
		%HealId = %Client;

	Client::sendMessage(%Client, $MsgGreen, "Healing "@Client::getName(%HealId));
	if(%Client != %Healid)
		Client::sendMessage(%HealId, $MsgGreen, "You are being healed by "@Client::getName(%Client));

	%r = $Spell::damageValue[5] / $TribesDamageToNumericDamage;

	refreshHP(%HealId, %r);

//	%castPos = GameBase::getPosition(%HealId);

	return "returnFlag 1 HealId "@%HealId; //return "returnFlag 1";
}
function SpellNum6(%Client, %castObj, %castPos) {
	//Medic 3
	if(getObjectType(%castObj) == "Player")
		%HealId = Player::getClient(%castObj);
	else
		%HealId = %Client;

	Client::sendMessage(%Client, $MsgGreen, "Healing "@Client::getName(%HealId));
	if(%Client != %Healid)
		Client::sendMessage(%HealId, $MsgGreen, "You are being healed by "@Client::getName(%Client));

	%r = $Spell::damageValue[6] / $TribesDamageToNumericDamage;

	refreshHP(%HealId, %r);

//	%castPos = GameBase::getPosition(%HealId);

	return "returnFlag 1 HealId "@%HealId;
}
function SpellNum7(%Client, %castObj, %castPos) {
	//Medic 4
	if(getObjectType(%castObj) == "Player")
		%HealId = Player::getClient(%castObj);
	else
		%HealId = %Client;

	Client::sendMessage(%Client, $MsgGreen, "Restoring "@Client::getName(%HealId));
	if(%Client != %Healid)
		Client::sendMessage(%HealId, $MsgGreen, "You are being healed cured by "@Client::getName(%Client));

	%r = $Spell::damageValue[7] / $TribesDamageToNumericDamage;

	refreshHP(%HealId, %r);

//	%castPos = GameBase::getPosition(%HealId);

	return "returnFlag 1 HealId "@%HealId;
}

function SpellNum8(%Client, %castObj, %castPos) {
	//Confusion
	%index = 8;
	%id = Player::getClient(%castObj);
	if(%Client.adminlevel>=2||Player::isAiControlled(%id)) {
		if(Client::getName(%id)!="") {
			%castlvl=(getFinalLVL(%Client)-floor(getRandom()*getFinalLVL(%id)));
			if(%castlvl<0) {
				%reflection=1;
				%castlvl*=-1;
				%temp_id=%id;
				%id=%Client;
				%Client=%temp_id;
				Client::sendMessage(%Client, $MsgBeige, "Confusing "@Client::getName(%id));
				if(%Client != %id)
					Client::sendMessage(%id, $MsgBeige, "REFLECT! You have been confused by "@Client::getName(%Client));
			}
			else {
				Client::sendMessage(%Client, $MsgBeige, "Confusing "@Client::getName(%id));
				if(%Client != %id)
					Client::sendMessage(%id, $MsgBeige, "You have been confused by "@Client::getName(%Client));
			}
			Player::setAnimation(%Client,40);

			%castPos = GameBase::getPosition(%id);
			%temp_loc=0;
			for(%mynum=1;%mynum<$MYmaxclients;%mynum++) {
				if(($ttlholdid[%mynum]==%id&&$ttltype[%mynum]==%index)||isdead(%id)) {
					%temp_loc=1;
					break;
				}
			}
			if(%temp_loc==0) {
				for(%mynum=1;%mynum<$MYmaxclients;%mynum++) {
					if($ttlholdid[%mynum]==0) {
						$ttlholdid[%mynum]=%id;
						$ttlholdpos[%mynum]=GameBase::getTeam(%id);
						$ttlhold[%mynum]=10*%castlvl;
						$ttltype[%mynum]=%index;

						if($ttlholdpos[%mynum]==0) {
							GameBase::setTeam($ttlholdid[%mynum],2);
						}
						else {
							GameBase::setTeam($ttlholdid[%mynum],0);
						}
						Game::refreshClientScore($ttlholdid[%mynum]);
						UpdateSkin($ttlholdid[%mynum]);
						break;
					}
				}
			}
			if($spellgoing==0) {
				$spellgoing=1;
				schedule("CastingSpell();", 1);
			}
		}
	}
	else {
		Client::sendMessage(%Client, $MsgBeige, "Cant confuse player "@Client::getName(%id));
	}
	return "returnFlag 1";
}
function SpellNum9(%Client, %castObj, %castPos) {
	//Remove Spell
	%id = Player::getClient(%castObj);
	if(%Client.adminlevel>=2||Player::isAiControlled(%id)) {
		if(Client::getName(%id)!="") {
			%castlvl=(getFinalLVL(%Client)-floor(getRandom()*getFinalLVL(%id)));
			if(%castlvl<0) {
				%reflection=1;
				%castlvl*=-1;
				%temp_id=%id;
				%id=%Client;
				%Client=%temp_id;
				Client::sendMessage(%Client, $MsgBeige, "Removing "@Client::getName(%id));
				if(%Client != %id)
					Client::sendMessage(%id, $MsgBeige, "REFLECT! You were removed by "@Client::getName(%Client));
				}
				else {
					Client::sendMessage(%Client, $MsgBeige, "Removing "@Client::getName(%id));
					if(%Client != %id)
						Client::sendMessage(%id, $MsgBeige, "You were removed by "@Client::getName(%Client));
				}
				%castPos = GameBase::getPosition(%id);
				Item::setVelocity(%id,GetWord(Item::getVelocity(%id),0)@" "@GetWord(Item::getVelocity(%id),1)@" "@GetWord(Item::getVelocity(%id),2)+(3*%castlvl));
			}
		}
		else {
			Client::sendMessage(%Client, $MsgBeige, "Cant jump player "@Client::getName(%id));
		}
		return "returnFlag 1";
	}
function SpellNum10(%Client, %castObj, %castPos) {

	//Mind Control
	%id = Player::getClient(%castObj);
	%index = 10;
	if(%Client.adminlevel>=2||Player::isAiControlled(%id)) {
		if(Client::getName(%id)!="") {
				%castlvl=(getFinalLVL(%Client)-floor(getRandom()*getFinalLVL(%id)));
				if(%castlvl<0) {
					%reflection=1;
					%castlvl*=-1;
					%temp_id=%id;
					%id=%Client;
					%Client=%temp_id;
					Client::sendMessage(%Client, $MsgBeige, "Manipulating "@Client::getName(%id));
					if(%Client != %id)
						Client::sendMessage(%id, $MsgBeige, "REFLECT! -- Your mind has been controlled by "@Client::getName(%Client));
				}
				else {
					Client::sendMessage(%Client, $MsgBeige, "Attempting to manupulate "@Client::getName(%id));
					if(%Client != %id)
						Client::sendMessage(%id, $MsgBeige, "You have been manipulated by "@Client::getName(%Client));
				}
				%castPos = GameBase::getPosition(%id);
				%temp_loc=0;
				for(%mynum=1;%mynum<$MYmaxclients;%mynum++) {
					if(($ttlholdid[%mynum]==%id&&$ttltype[%mynum]==%index)||isdead(%id)) {
						%temp_loc=1;
						break;
					}
				}
				if(%temp_loc==0) {
					for(%mynum=1;%mynum<$MYmaxclients;%mynum++) {
						if($ttlholdid[%mynum]==0) {
							$ttlholdid[%mynum]=%id;
							$ttlholdpos[%mynum]=%Client;
							$ttlhold[%mynum]=2*%castlvl;
							$ttltype[%mynum]=%index;
							Client::setControlObject($ttlholdpos[%mynum].possessId, $ttlholdpos[%mynum].possessId);
							Client::setControlObject($ttlholdpos[%mynum], $ttlholdpos[%mynum]);
							$dumbAIflag[$ttlholdpos[%mynum].possessId] = "";

								if(Player::isAiControlled($ttlholdid[%mynum])) {
									$dumbAIflag[$ttlholdpos[%mynum]] = True;
									AI::setVar($BotInfoAiName[$ttlholdpos[%mynum]], SpotDist, 0);
									AI::newDirectiveRemove($BotInfoAiName[$ttlholdpos[%mynum]], 99);
									AI::newDirectiveRemove($BotInfoAiName[$ttlholdpos[%mynum]], 127);
								}
								$ttlholdpos[%mynum].possessId = $ttlholdid[%mynum];
								Client::setControlObject($ttlholdid[%mynum], -1);
								Client::setControlObject($ttlholdpos[%mynum], $ttlholdid[%mynum]);
							break;
						}
					}
				}
				if($spellgoing==0) {
					$spellgoing=1;
					schedule("CastingSpell();", 1);
				}
			}
		}
		else {
			Client::sendMessage(%Client, $MsgBeige, "Cant control player "@Client::getName(%id));
		}

	return "returnFlag 1";
}
function SpellNum11(%Client, %castObj, %castPos) {

	//Fire 1 Spell
	schedule("cast_fireball("@%Client@");",0.1);
	return "returnFlag 1";
}
function SpellNum12(%Client, %castObj, %castPos) {

	//Fire 2 Spell
	if(%castPos != "") {
		%index = 12;
		CreateAndDetBomb(%Client, "Bomb3", %castPos, %index);

		%overrideEndSound = True;
		return "returnFlag 1";
	}
	else {
		Client::sendMessage(%Client, $MsgRed, "Cannot Cast that far with this spell.");
		return "returnFlag 0";
	}
}
function SpellNum13(%Client, %castObj, %castPos) {
	//fire 3 Spell

	schedule("cast_flame("@%Client@");",0.1);
	schedule("cast_flame("@%Client@");",0.2);
	schedule("cast_flame("@%Client@");",0.3);
	schedule("cast_flame("@%Client@");",0.4);
	schedule("cast_flame("@%Client@");",0.5);
	schedule("cast_flame("@%Client@");",0.6);
	schedule("cast_flame("@%Client@");",0.7);
	schedule("cast_flame("@%Client@");",0.8);
	schedule("cast_flame("@%Client@");",0.9);
	schedule("cast_flame("@%Client@");",1.0);
	schedule("cast_flame("@%Client@");",1.1);
	schedule("cast_flame("@%Client@");",1.2);
	schedule("cast_flame("@%Client@");",1.3);
	schedule("cast_flame("@%Client@");",1.4);

	return "returnFlag 1";
}
function SpellNum14(%Client, %castObj, %castPos) {
	//Fire 4 Spell - Flare
	schedule("cast_flare("@%Client@");",0.1);
	schedule("cast_flare("@%Client@");",0.2);
	schedule("cast_flare("@%Client@");",0.3);
	schedule("cast_flare("@%Client@");",0.4);
	schedule("cast_flare("@%Client@");",0.5);
	schedule("cast_flare("@%Client@");",0.6);
	schedule("cast_flare("@%Client@");",0.7);
	schedule("cast_flare("@%Client@");",0.8);
	schedule("cast_flare("@%Client@");",0.9);
	schedule("cast_flare("@%Client@");",1.0);


//	schedule("ClearSpellDmg("@%Client@");", 1.5);

	return "returnFlag 1";
}
function SpellNum15(%Client, %castObj, %castPos) {
	//Fire 4 Spell - Flare

	//echo("test");
	//client::sendmessage(%client,1,"Disabled till futher notice.");
	//return false;

	schedule("cast_flare("@%Client@");",0.1);
	schedule("cast_flare("@%Client@");",0.2);
	schedule("cast_flare("@%Client@");",0.3);
	schedule("cast_flare("@%Client@");",0.4);
	schedule("cast_flare("@%Client@");",0.5);
	schedule("cast_flare("@%Client@");",0.6);
	schedule("cast_flare("@%Client@");",0.7);
	schedule("cast_flare("@%Client@");",0.8);
	schedule("cast_flare("@%Client@");",0.9);
	schedule("cast_flare("@%Client@");",1.0);

	return "returnFlag 1";
}
function SpellNum16(%Client, %castObj, %castPos) {
	//Ice Spell
	schedule("cast_iceball("@%Client@");",0.1);
	return "returnFlag 1";
}
function SpellNum17(%Client, %castObj, %castPos) {
	//Fixed Ice2 Spell - using create and det bomb instead of spawn projectile
	if(%castPos != "") {
		%index = 17;
		CreateAndDetBomb(%Client, "Bomb201", %castPos, %index);
		CreateAndDetBomb(%Client, "Bomb201", %castPos, %index);
		CreateAndDetBomb(%Client, "Bomb202", %castPos, %index);

		return "returnFlag 1 overrideEndSound 1";
	}
	else {
		Client::sendMessage(%Client, $MsgRed, "You cannot cast that far with this spell.");
		return "returnFlag 0";
	}
}
function SpellNum18(%Client, %castObj, %castPos) {
	//Ice 3
	schedule("cast_bliz("@%Client@");",0.1);
	schedule("cast_bliz("@%Client@");",0.2);
	schedule("cast_bliz("@%Client@");",0.3);
	schedule("cast_bliz("@%Client@");",0.4);
	schedule("cast_bliz("@%Client@");",0.5);
	schedule("cast_bliz("@%Client@");",0.6);
	schedule("cast_bliz("@%Client@");",0.7);
	schedule("cast_bliz("@%Client@");",0.8);
	schedule("cast_bliz("@%Client@");",0.9);
	schedule("cast_bliz("@%Client@");",1.0);
	schedule("cast_bliz("@%Client@");",1.1);
	schedule("cast_bliz("@%Client@");",1.2);
	schedule("cast_bliz("@%Client@");",1.3);
	schedule("cast_bliz("@%Client@");",1.4);
	schedule("cast_bliz("@%Client@");",1.5);
	schedule("cast_bliz("@%Client@");",1.6);

	return "returnFlag 1";
}
function SpellNum19(%Client, %castObj, %castPos) {
	//Ice 4 Spell - Freeze
	if(%castPos != "") {
		%index = 19;
		CreateAndDetBomb(%Client, "Bomb42", %castPos, %index);
		CreateAndDetBomb(%Client, "Bomb43", %castPos, %index);
		CreateAndDetBomb(%Client, "Bomb44", %castPos, %index);
		CreateAndDetBomb(%Client, "Bomb42", %castPos, %index);
		CreateAndDetBomb(%Client, "Bomb43", %castPos, %index);
		CreateAndDetBomb(%Client, "Bomb44", %castPos, %index);

		%overrideEndSound = True;
		return "returnFlag 1";
	}
	else {
		Client::sendMessage(%Client, $MsgRed, "You cannot cast that far with this spell.");
		return "returnFlag 0";
	}
}
function SpellNum20(%Client, %castObj, %castPos) {
	//Aqua1 Spell
	schedule("cast_waterwater("@%Client@");",0.1);
	return "returnFlag 1";
}
function SpellNum21(%Client, %castObj, %castPos) {
	//Aqua2 Spell
	schedule("cast_waterwaterwater("@%Client@");",0.1);
	return "returnFlag 1";
}
function SpellNum22(%Client, %castObj, %castPos) {
	// Aqua3 Spell
	if(%castPos != "") {
		%player = Client::getOwnedObject(%Client);
		%index = 22;

		%minrad = 0;
		%maxrad = 5;
		for(%i = 0; %i <= 24; %i++) {
			%tempPos = RandomPositionXY(%minrad, %maxrad);
			%xPos = GetWord(%tempPos, 0) + GetWord(%castPos, 0);
			%yPos = GetWord(%tempPos, 1) + GetWord(%castPos, 1);
			%zPos = GetWord(%castPos, 2) + 72 - (%i * 3);

			%newPos = %xPos@" "@%yPos@" "@%zPos;

			schedule("CreateAndDetBomb(\""@%Client@"\", \"Bomb300\", \""@%newPos@"\", False, \""@%index@"\");", %i / 16, %player);
		}

		schedule("CreateAndDetBomb(\""@%Client@"\", \"Bomb301\", \""@%castPos@"\", True, \""@%index@"\");", 2, %player); // 1.6

		%overrideEndSound = True;
		return "returnFlag 1";
	}
	else {
		Client::sendMessage(%Client, $MsgBeige, "Could not find a target.");
		return "returnFlag 0";
	}
}
function SpellNum23(%Client, %castObj, %castPos) {
	//Aqua4 Spell
	schedule("cast_waverly("@%Client@");",0.1);
	schedule("cast_waverly("@%Client@");",0.2);
	schedule("cast_waverly("@%Client@");",0.3);

	return "returnFlag 1";
}
function SpellNum24(%Client, %castObj, %castPos) {

	//Quake 1 Spell
	if(%castPos != "") {
		%index = 24;
		CreateAndDetBomb(%Client, "Bomb107", %castPos, %index);

		%overrideEndSound = True;
		return "returnFlag 1";
	}
	else {
		Client::sendMessage(%Client, $MsgRed, "You cannot cast that far with this spell.");
		return "returnFlag 0";
	}
}
function SpellNum25(%Client, %castObj, %castPos) {

	//Quake 2 Spell
	if(%castPos != "") {
		%index = 25;
		CreateAndDetBomb(%Client, "Bomb107", %castPos, %index);
		CreateAndDetBomb(%Client, "Bomb107", %castPos, %index);

		%overrideEndSound = True;
		return "returnFlag 1";
	}
	else {
		Client::sendMessage(%Client, $MsgRed, "You cannot cast that far with this spell.");
		return "returnFlag 0";
	}
}
function SpellNum26(%Client, %castObj, %castPos) {

	//Quake 3 Spell
	if(%castPos != "") {
		%index = 26;
		CreateAndDetBomb(%Client, "Bomb107", %castPos, %index);
		CreateAndDetBomb(%Client, "Bomb107", %castPos, %index);
		CreateAndDetBomb(%Client, "Bomb107", %castPos, %index);

		%overrideEndSound = True;
		return "returnFlag 1";
	}
	else {
		Client::sendMessage(%Client, $MsgRed, "You cannot cast that far with this spell.");
		return "returnFlag 0";
	}
}
function SpellNum27(%Client, %castObj, %castPos) {

	//Quake 4 Spell - Break
	if(%castPos != "") {
		%index = 27;
		CreateAndDetBomb(%Client, "Bomb107", %castPos, %index);
		CreateAndDetBomb(%Client, "Bomb107", %castPos, %index);
		CreateAndDetBomb(%Client, "Bomb107", %castPos, %index);
		CreateAndDetBomb(%Client, "Bomb107", %castPos, %index);
		CreateAndDetBomb(%Client, "Bomb107", %castPos, %index);
		CreateAndDetBomb(%Client, "Bomb107", %castPos, %index);
		CreateAndDetBomb(%Client, "Bomb107", %castPos, %index);
		CreateAndDetBomb(%Client, "Bomb107", %castPos, %index);
		CreateAndDetBomb(%Client, "Bomb107", %castPos, %index);
		CreateAndDetBomb(%Client, "Bomb108", %castPos, %index);
		CreateAndDetBomb(%Client, "Bomb108", %castPos, %index);
		CreateAndDetBomb(%Client, "Bomb108", %castPos, %index);

		%overrideEndSound = True;
		return "returnFlag 1";
	}
	else {
		Client::sendMessage(%Client, $MsgRed, "You cannot cast that far with this spell.");
		return "returnFlag 0";
	}
}
function SpellNum28(%Client, %castObj, %castPos) {

	//Spike
	schedule("cast_missile("@%Client@");",0.1);
	return "returnFlag 1";
}
function SpellNum29(%Client, %castObj, %castPos) {

	//Wound
	if(%castPos != "") {
		%index = 29;
		CreateAndDetBomb(%Client, "bomb950", %castPos, %index);

		%overrideEndSound = True;
		return "returnFlag 1";
	}
	else {
		Client::sendMessage(%Client, $MsgGreen, "Cannot Cast that far with this spell.");
		return "returnFlag 0";
	}
}
function SpellNum30(%Client, %castObj, %castPos) {

		//Fist
		schedule("cast_tfist("@%Client@");", 0.1);
		schedule("cast_tfist("@%Client@");", 0.2);

		return "returnFlag 1";
	}
function SpellNum31(%Client, %castObj, %castPos) {

	//Missile
	schedule("cast_shocklvtwo("@%Client@");", 0.1);
	schedule("cast_shocklvtwo("@%Client@");", 0.2);

	return "returnFlag 1";
}
function SpellNum32(%Client, %castObj, %castPos) {

	//Cannon
	schedule("cast_shocklvone("@%Client@");", 0.1);
	schedule("cast_shocklvone("@%Client@");", 0.2);
	return "returnFlag 1";
}
function SpellNum33(%Client, %castObj, %castPos) {

	//Bomb
	schedule("cast_surge("@%Client@");", 0.1);
	schedule("cast_surge("@%Client@");", 0.2);
	schedule("cast_surge("@%Client@");", 0.3);
	return "returnFlag 1";
}
function SpellNum34(%Client, %castObj, %castPos) {

	// Star
	%player = Client::getOwnedObject(%Client);
	if(%castPos != "") {
		%index = 34;
		%minrad = 0;
		%maxrad = 4;
		for(%i = 0; %i <= 10; %i++) {
			%tempPos = RandomPositionXY(%minrad, %maxrad);
			%xPos = GetWord(%tempPos, 0) + GetWord(%castPos, 0);
			%yPos = GetWord(%tempPos, 1) + GetWord(%castPos, 1);
			%zPos = GetWord(%castPos, 2) + (%i / 4);
			%newPos = %xPos@" "@%yPos@" "@%zPos;

			schedule("CreateAndDetBomb("@%Client@", \"Bomb108\", \""@%newPos@"\", False, "@%index@");", %i / 20, %player);
		}
		for(%i = 0; %i <= 10; %i++) {
			%tempPos = RandomPositionXY(%minrad, %maxrad);

			%xPos = GetWord(%tempPos, 0) + GetWord(%castPos, 0);
			%yPos = GetWord(%tempPos, 1) + GetWord(%castPos, 1);
			%zPos = GetWord(%castPos, 2) + (%i / 4);

			%newPos = %xPos@" "@%yPos@" "@%zPos;

			schedule("CreateAndDetBomb("@%Client@", \"Bomb8\", \""@%newPos@"\", False, "@%index@");", %i / 20, %player);
		}
		schedule("CreateAndDetBomb("@%Client@", \"Bomb200\", \""@%castPos@"\", True, "@%index@");", 1.0, %player);
		schedule("CreateAndDetBomb("@%Client@", \"Bomb200\", \""@%castPos@"\", True, "@%index@");", 1.05, %player);
		schedule("CreateAndDetBomb("@%Client@", \"Bomb107\", \""@%castPos@"\", True, "@%index@");", 1.1, %player);

		%overrideEndSound = True;
		return "returnFlag 1";
	}
	else {
		Client::sendMessage(%Client, $MsgBeige, "Could not find a target.");
		return "returnFlag 0";
	}
}
function SpellNum35(%Client, %castObj, %castPos) {

	//Dark Spike
	schedule("cast_gravity("@%Client@");",0.1);
	return "returnFlag 1";
}
function SpellNum36(%Client, %castObj, %castPos) {

	//Dark Shot
	schedule("cast_bioone("@%Client@");",0.1);
	return "returnFlag 1";
}
function SpellNum37(%Client, %castObj, %castPos) {

	//Surge
	schedule("cast_show("@%Client@");",0.1);
	schedule("cast_show("@%Client@");",0.2);
	schedule("cast_show("@%Client@");",0.3);
	schedule("cast_ice("@%Client@");",0.4);
	schedule("cast_ice("@%Client@");",0.5);
	schedule("cast_flame("@%Client@");",0.6);
	schedule("cast_flame("@%Client@");",0.7);
	schedule("cast_ice("@%Client@");",0.8);
	schedule("cast_ice("@%Client@");",0.9);
	schedule("cast_show("@%Client@");",1.0);
	schedule("cast_show("@%Client@");",1.1);
	schedule("cast_tfist("@%Client@");",1.2);
	schedule("cast_tfist("@%Client@");",1.3);
	schedule("cast_flare("@%Client@");",1.4);
	schedule("cast_show("@%Client@");",1.5);
	schedule("cast_show("@%Client@");",1.6);
	schedule("cast_ice("@%Client@");",1.7);
	schedule("cast_ice("@%Client@");",1.8);
	schedule("cast_ice("@%Client@");",1.9);
	schedule("cast_ice("@%Client@");",2.0);
	schedule("cast_gravity("@%Client@");",2.1);
	schedule("cast_gravity("@%Client@");",2.2);
	schedule("cast_shocklvone("@%Client@");",2.3);
	schedule("cast_shocklvtwo("@%Client@");",2.4);
	schedule("cast_shocklvthree("@%Client@");",2.5);
	schedule("cast_flare("@%Client@");",2.6);
	schedule("cast_show("@%Client@");",2.7);
	schedule("cast_show("@%Client@");",2.8);
	return "returnFlag 1";
}
function SpellNum38(%Client, %castObj, %castPos) {

	// Storm
	%player = Client::getOwnedObject(%Client);
	if(%castPos != "") {
		%index = 38;

		%minrad = 0;
		%maxrad = 5;
		for(%i = 0; %i <= 24; %i++) {
			%tempPos = RandomPositionXY(%minrad, %maxrad);
			%xPos = GetWord(%tempPos, 0) + GetWord(%castPos, 0);
			%yPos = GetWord(%tempPos, 1) + GetWord(%castPos, 1);
			%zPos = GetWord(%castPos, 2) + 72 - (%i * 3);
			%newPos = %xPos@" "@%yPos@" "@%zPos;

			schedule("CreateAndDetBomb("@%Client@", \"Bomb305\", \""@%newPos@"\", False, "@%index@");", %i / 16, %player);
		}
		schedule("CreateAndDetBomb("@%Client@", \"Bomb302\", \""@%castPos@"\", True, "@%index@");", %i / 16, %player);

		%overrideEndSound = True;
		return "returnFlag 1";
	}
	else {
		Client::sendMessage(%Client, $MsgBeige, "Cannot Cast that far with this spell.");
		return "returnFlag 0";
	}
}
function SpellNum39(%Client, %castObj, %castPos) {

	// Storm 2
	%player = Client::getOwnedObject(%Client);
	if(%castPos != "") {
		%index = 39;
		%minrad = 0;
		%maxrad = 5;
		for(%i = 0; %i <= 24; %i++) {
			%tempPos = RandomPositionXY(%minrad, %maxrad);
			%xPos = GetWord(%tempPos, 0) + GetWord(%castPos, 0);
			%yPos = GetWord(%tempPos, 1) + GetWord(%castPos, 1);
			%zPos = GetWord(%castPos, 2) + 72 - (%i * 3);

			%newPos = %xPos@" "@%yPos@" "@%zPos;

			schedule("CreateAndDetBomb("@%Client@", \"Bomb306\", \""@%newPos@"\", False, "@%index@");", %i / 16, %player);
		}
		schedule("CreateAndDetBomb("@%Client@", \"Bomb303\", \""@%castPos@"\", True, "@%index@");", %i / 16, %player);

		%overrideEndSound = True;
		return "returnFlag 1";
	}
	else {
		Client::sendMessage(%Client, $MsgBeige, "Cannot Cast that far with this spell.");
		return "returnFlag 0";
	}
}
function SpellNum40(%Client, %castObj, %castPos) {

	// Storm 3
	%player = Client::getOwnedObject(%Client);
	if(%castPos != "") {
		%index = 40;
		%minrad = 0;
		%maxrad = 5;
		for(%i = 0; %i <= 24; %i++) {
			%tempPos = RandomPositionXY(%minrad, %maxrad);

			%xPos = GetWord(%tempPos, 0) + GetWord(%castPos, 0);
			%yPos = GetWord(%tempPos, 1) + GetWord(%castPos, 1);
			%zPos = GetWord(%castPos, 2) + 72 - (%i * 3);

			%newPos = %xPos@" "@%yPos@" "@%zPos;

			schedule("CreateAndDetBomb("@%Client@", \"Bomb307\", \""@%newPos@"\", False, "@%index@");", %i / 16, %player);
		}
		schedule("CreateAndDetBomb("@%Client@", \"Bomb304\", \""@%castPos@"\", True, "@%index@");", %i / 16, %player);

		%overrideEndSound = True;
		return "returnFlag 1";
	}
	else {
		Client::sendMessage(%Client, $MsgBeige, "Cannot Cast that far with this spell.");
		return "returnFlag 0";
	}
}
function SpellNum41(%Client, %castObj, %castPos) {

	//Storm 4
	%player = Client::getOwnedObject(%Client);
	if(%castPos != "") {
		%index = 41;
		%minrad = 0;
		%maxrad = $Spell::radius[%index] / 2;

		for(%i = 0; %i <= 8; %i++) {
			%tempPos = RandomPositionXY(%minrad, %maxrad);
			%xPos = GetWord(%tempPos, 0) + GetWord(%castPos, 0);
			%yPos = GetWord(%tempPos, 1) + GetWord(%castPos, 1);
			%zPos = GetWord(%castPos, 2);

			%newPos = %xPos@" "@%yPos@" "@%zPos;

			schedule("CreateAndDetBomb("@ %Client @", \"Bomb444\", \""@ %newPos @"\", True, "@%index@");", %i / 7, %player);
		}

		CreateAndDetBomb(%Client, "Bomb444", %castPos, True, %index);

		%overrideEndSound = True;
		return "returnFlag 1";
	}
	else {
		Client::sendMessage(%Client, $MsgBeige, "Cannot cast that far with this spell.");
		return "returnFlag 0";
	}
}
function SpellNum42(%Client, %castObj, %castPos) {

	//Gale
	if(%castPos != "") {
		%index = 42;
		CreateAndDetBomb(%Client, "Bomb6661", %castPos, True, %index);

		%overrideEndSound = True;
		return "returnFlag 1";
	}
	else {
		Client::sendMessage(%Client, $MsgBeige, "Could not find a target.");
		return "returnFlag 0";
	}
}
function SpellNum43(%Client, %castObj, %castPos) {

	//Gale2
	if(%castPos != "") {
		%index = 43;
		CreateAndDetBomb(%Client, "Bomb6662", %castPos, True, %index);

		%overrideEndSound = True;
		return "returnFlag 1";
	}
	else {
		Client::sendMessage(%Client, $MsgBeige, "Could not find a target.");
		return "returnFlag 0";
	}
}
function SpellNum44(%Client, %castObj, %castPos) {

	//Gale3
	if(%castPos != "") {
		%index = 44;
		CreateAndDetBomb(%Client, "Bomb6663", %castPos, True, %index);

		return "returnFlag 1 overrideEndSound 1";
	}
	else {
		Client::sendMessage(%Client, $MsgBeige, "Could not find a target.");
		return "returnFlag 0";
	}
}
function SpellNum45(%Client, %castObj, %castPos) {

	//Gale 4
	if(%castPos != "") {
		%index = 45;
		// CreateAndDetBomb(%Client, "Bomb6664", %castPos, True, %index);
		schedule("cast_tornado("@%Client@", \"" @ %castPos@ "\", "@%index@");",0.1);

		return "returnFlag 1 overrideEndSound 1";
	}
	else {
		Client::sendMessage(%Client, $MsgBeige, "Could not find a target.");
		return "returnFlag 0";
	}
}
function SpellNum46(%Client, %castObj, %castPos) {

	//ranger wind spell
	schedule("cast_rangerwind("@%Client@");",0.1);
	return "returnFlag 1";
}
function SpellNum47(%Client, %castObj, %castPos) {

	//ranger fire spell
	schedule("cast_rangerfire("@%Client@");",0.1);
	return "returnFlag 1";
}

function SpellNum48(%Client, %castObj, %castPos) {

	//ranger ice spell
	schedule("cast_rangerice("@%Client@");",0.1);
	return "returnFlag 1";
}

function SpellNum49(%Client, %castObj, %castPos) {

	//Block Front Utility
	// %passed = checkArea(%Client, 1);
	// if(!%passed) {
	// 	Client::sendMessage(%Client, $MsgBeige, "You are to close to an object. (wall or tree, etc)");
	// }
	// else {
		%wall = newObject("MagicWall", "StaticShape", bluebluegreen, true);//,false); // bluebluegreen

		if(%wall != 0) {
			addToSet("MissionCleanup", %wall);
			%time = floor(getFinalLVL(%Client)*4.5);
			schedule("Item::Pop("@%wall@");", %time, %wall);
			%pos = GameBase::getPosition(%Client);
			%wall.hp = floor(getFinalLVL(%client)*0.8);
			%wall.owner = client::getname(%client);
			GameBase::setPosition(%wall, GetWord(%pos,0)@" "@GetWord(%pos,1)@" "@GetWord(%pos,2)+1.5);
			GameBase::setRotation(%wall, GetWord(GameBase::getRotation(%Client),0)+1.6@" "@GetWord(GameBase::getRotation(%Client),1)@" "@GetWord(GameBase::getRotation(%Client),2));
			Client::sendmessage(%client,0,"You create a magic wall with "@%time@" seconds of life and "@%wall.hp@" hp!");
		}

		return "returnFlag 1";
	//}
}

function SpellNum50(%Client, %castObj, %castPos) {

	//Block Back Utility
	// %passed = checkArea(%Client, 5);
	// if(!%passed) {
	// 	Client::sendMessage(%Client, $MsgBeige, "You are to close to an object. (wall or tree, etc)");
	// }
	// else {
		%wall = newObject("MagicWall", "StaticShape", hvshield2, true);//,false);  //  hvshield2 (hvdomefiled)
		if(%wall != 0) {
			addToSet("MissionCleanup", %wall);
			%time = floor(getFinalLVL(%Client) * 7.2);
			schedule("Item::Pop("@%wall@");", %time, %wall);
			%pos = GameBase::getPosition(%Client);
			%wall.hp = floor(getFinalLVL(%client) * 0.9);
			%wall.owner = client::getname(%client);
			GameBase::setPosition(%wall, GetWord(%pos, 0) @" "@ GetWord(%pos, 1) @" "@ GetWord(%pos, 2) + 1.5);
			GameBase::setRotation(%wall, GetWord(GameBase::getRotation(%Client), 0) + 1.6 @" "@ GetWord(GameBase::getRotation(%Client), 1)@" "@GetWord(GameBase::getRotation(%Client), 2));
			Client::sendmessage(%client, 0, "You create a magic wall with "@%time@" seconds of life and "@%wall.hp@" hp!");
		}

		return "returnFlag 1";
	//}
}

function SpellNum51(%Client, %castObj, %castPos) {

	//Light Utility
	// Client::sendmessage(%client,1,"Disabled till futher notice.");
	// return false;
	schedule("cast_truelight("@%Client@");",0.1);

	return "returnFlag 1";
}
function SpellNum52(%Client, %castObj, %castPos) {

	//Goods
	if(getObjectType(%castObj) == "Player")
		%id = Player::getClient(%castObj);
	else
		%id = %Client;

	Client::sendMessage(%Client, $MsgGreen, "Casting Goods for "@Client::getName(%id));
	if(%Client != %id)
		Client::sendMessage(%id, $MsgGreen, "Goods has been cast for you by "@Client::getName(%Client));

	refreshSTAMINA(%Client, -50);

	%castPos = GameBase::getPosition(%id);

	return "returnFlag 1";
}
function SpellNum53(%Client, %castObj, %castPos) {

	//Goods 2
	if(getObjectType(%castObj) == "Player")
		%id = Player::getClient(%castObj);
	else
		%id = %Client;

	Client::sendMessage(%Client, $MsgGreen, "Casting Goods for "@Client::getName(%id));
	if(%Client != %id)
		Client::sendMessage(%id, $MsgGreen, "Goods has been cast for you by "@Client::getName(%Client));

	refreshSTAMINA(%Client, -200);

	%castPos = GameBase::getPosition(%id);

	return "returnFlag 1";
}
function SpellNum54(%Client, %castObj, %castPos) {

	//Goods 3
	if(getObjectType(%castObj) == "Player")
		%id = Player::getClient(%castObj);
	else
		%id = %Client;

	Client::sendMessage(%Client, $MsgGreen, "Casting Goods for "@Client::getName(%id));
	if(%Client != %id)
		Client::sendMessage(%id, $MsgGreen, "Goods has been cast for you by "@Client::getName(%Client));

	refreshSTAMINA(%Client, -400);

	%castPos = GameBase::getPosition(%id);

	return "returnFlag 1";
}
function SpellNum55(%Client, %castObj, %castPos) {

	//Goods 4
	if(getObjectType(%castObj) == "Player")
		%id = Player::getClient(%castObj);
	else
		%id = %Client;

	Client::sendMessage(%Client, $MsgGreen, "Casting Goods for "@Client::getName(%id));
	if(%Client != %id)
		Client::sendMessage(%id, $MsgGreen, "Goods has been cast for you by "@Client::getName(%Client));

	refreshSTAMINA(%Client, -999);

	%castPos = GameBase::getPosition(%id);

	return "returnFlag 1";
}

function SpellNum56(%Client, %castObj, %castPos) {
//echo("DEATH SPELL -- CPos: -"@%castPos@"- "); looks ok..
	//death
	%player = Client::getOwnedObject(%Client);
	if(%castPos != "") {
		%index = 56;
		%minrad = 0;
		%maxrad = 30;
		for(%i = 0; %i <= 150; %i++) {
			%tempPos = RandomPositionXY(%minrad, %maxrad);

			%xPos = GetWord(%tempPos, 0) + GetWord(%castPos, 0) + 450 -(%i * 3);
			%yPos = GetWord(%tempPos, 1) + GetWord(%castPos, 1) + 450 -(%i * 3);
			%zPos = GetWord(%castPos, 2) + 450 - (%i * 3);

			%newPos = %xPos@" "@%yPos@" "@%zPos;

			schedule("CreateAndDetBomb(\""@%Client@"\", \"Bomb611\", \""@%newPos@"\", False, \""@%index@"\");", %i / 50, %player);
		}
		%minrad = 0;
		%maxrad = 50;
		for(%i = 0; %i <= 100; %i++) {
			%tempPos = RandomPositionXY(%minrad, %maxrad);

			%xPos = GetWord(%tempPos, 0) + GetWord(%castPos, 0);
			%yPos = GetWord(%tempPos, 1) + GetWord(%castPos, 1);
			%zPos = GetWord(%castPos, 2);

			%newPos = %xPos@" "@%yPos@" "@%zPos;

			schedule("CreateAndDetBomb(\""@%Client@"\", \"Bomb612\", \""@%newPos@"\", true, \""@%index@"\");", %i  / 20 + 4, %player);
		}
		%minrad = 50;
		%maxrad = 70;
		for(%i = 0; %i <= 60; %i++) {
			%tempPos = RandomPositionXY(%minrad, %maxrad);

			%xPos = GetWord(%tempPos, 0) + GetWord(%castPos, 0);
			%yPos = GetWord(%tempPos, 1) + GetWord(%castPos, 1);
			%zPos = GetWord(%castPos, 2) + 0.5;

			%newPos = %xPos@" "@%yPos@" "@%zPos;

			schedule("CreateAndDetBomb(\""@%Client@"\", \"Bomb612\", \""@%newPos@"\", true, \""@%index@"\");", %i  / 15 + 5, %player);
		}
		%minrad = 70;
		%maxrad = 90;
		for(%i = 0; %i <= 60; %i++) {
			%tempPos = RandomPositionXY(%minrad, %maxrad);

			%xPos = GetWord(%tempPos, 0) + GetWord(%castPos, 0);
			%yPos = GetWord(%tempPos, 1) + GetWord(%castPos, 1);
			%zPos = GetWord(%castPos, 2) + 1;

			%newPos = %xPos@" "@%yPos@" "@%zPos;

			schedule("CreateAndDetBomb(\""@%Client@"\", \"Bomb611\", \""@%newPos@"\", true, \""@%index@"\");", %i  / 15 + 6, %player);
		}
		%minrad = 90;
		%maxrad = 100;
		for(%i = 0; %i <= 30; %i++) {
			%tempPos = RandomPositionXY(%minrad, %maxrad);

			%xPos = GetWord(%tempPos, 0) + GetWord(%castPos, 0);
			%yPos = GetWord(%tempPos, 1) + GetWord(%castPos, 1);
			%zPos = GetWord(%castPos, 2) + 1.5;

			%newPos = %xPos@" "@%yPos@" "@%zPos;

			schedule("CreateAndDetBomb(\""@%Client@"\", \"Bomb611\", \""@%newPos@"\", true, \""@%index@"\");", %i  / 7 + 7, %player);
		}

		return "returnFlag 1 overrideEndSound 1";
	}
	else {
		Client::sendMessage(%Client, $MsgBeige, "Could not find a target.");
		return "returnFlag 0";
	}
}
function SpellNum57(%Client, %castObj, %castPos) {

	//ROCK SUMMON Spell
	schedule("cast_rocksummon("@%Client@");",0.1);
	return "returnFlag 1";
}
function SpellNum58(%Client, %castObj, %castPos) {

	//BLIZZARD SUMMON Spell
	schedule("cast_blizzardblizzardboltfake("@%Client@");",0.1);
	schedule("cast_blizzardblizzardboltfake("@%Client@");",0.2);
	schedule("cast_blizzardblizzardboltfake("@%Client@");",0.3);
	schedule("cast_blizzardblizzardboltfake("@%Client@");",0.4);
	schedule("cast_blizzardblizzardboltfake("@%Client@");",0.5);
	schedule("cast_blizzardblizzardboltfake("@%Client@");",0.6);
	schedule("cast_blizzardblizzardboltfake("@%Client@");",0.7);
	schedule("cast_blizzardblizzardboltreal("@%Client@");",0.8);
	schedule("cast_blizzardblizzardboltreal("@%Client@");",0.9);

	return "returnFlag 1";
}
function SpellNum59(%Client, %castObj, %castPos) {

	//BATTLE SUMMON Spell

	schedule("cast_summonswordone("@%Client@");",0.1);
	schedule("cast_summonswordtwo("@%Client@");",0.2);
	schedule("cast_summonswordthree("@%Client@");",0.3);
	schedule("cast_summonswordfour("@%Client@");",0.4);

	return "returnFlag 1";
}
function SpellNum60(%Client, %castObj, %castPos) {

	//SAPPERS SUMMON Spell

	if(%castPos != "") {
		%index = 60;
		CreateAndDetBomb(%Client, "bomb88888", %castPos, %index);

		%overrideEndSound = True;
		return "returnFlag 1";
	}
	else {
		Client::sendMessage(%Client, $MsgGreen, "Cannot Cast that far with this spell.");

		return "returnFlag 0";
	}
}
function SpellNum61(%Client, %castObj, %castPos) {
	%player = Client::getOwnedObject(%Client);
	if(%castPos != "")
	{
		%minrad = 0;
		%maxrad = $Spell::radius[%index] / 2;
		for(%i = 0; %i <= 8; %i++)
		{
			%tempPos = RandomPositionXY(%minrad, %maxrad);

			%xPos = GetWord(%tempPos, 0) + GetWord(%castPos, 0);
			%yPos = GetWord(%tempPos, 1) + GetWord(%castPos, 1);
			%zPos = GetWord(%castPos, 2);

			%newPos = %xPos@" "@%yPos@" "@%zPos;

			schedule("CreateAndDetBomb("@%clientId@", \"Supercheebomb1\", \""@%newPos@"\", False, "@%index@");", %i / 7, %player);
		}
		CreateAndDetBomb(%clientId, "Supercheebomb1", %castPos, True, %index);

		%overrideEndSound = True;
		%returnFlag = True;
	}
	else
	{
		Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");
		%returnFlag = False;
	}
}
function SpellNum62(%Client, %castObj, %castPos) { //mimic spell

	%index = 62;
	if(Zone::getType($zone[%Client]) == "PROTECTED") {
		Client::sendMessage(%Client, $MsgRed, "You can't cast mimic in protected territory.");
		return "returnFlag 0 overrideEndSound 1";
	}
	else if($isZombie[%Client]) {
		Client::sendMessage(%Client, $MsgRed, "You can't cast mimic while a Zombie Beast.");
		return "returnFlag 0 overrideEndSound 1";
	}
	else {
		%id = Player::getClient(%castObj);
		if(getObjectType(%castObj) == "Player") {

			%troll = getFinalLVL(%id) + floor(getRandom() * (getFinalINT(%id) + (getFinalMDEF(%id) * (1/2)) ));
			%yroll = getFinalLVL(%Client) + floor(getRandom() * getFinalWIS(%Client));

			if(%yroll > %troll) {
			//	$RACE[%Client] = $RACE[%id];
				$ClientData[%Client, "isMimic"] = True;
				ChangeRace(%Client, $RACE[%id]);

				UpdateTeam(%Client);
				RefreshAll(%Client);

				playSound(AbsorbABS, GameBase::getPosition(%Client));

				return "returnFlag 1";
			}
			else {
				Client::sendMessage(%Client, $MsgBeige, "Mimic failed.");
				return "returnFlag 0 overrideEndSound 1";

			}
		}
		else {
			Client::sendMessage(%Client, $MsgBeige, "Could not find a target.");
			return "returnFlag 0 overrideEndSound 1";
		}
	}
}

function SpellNum63(%Client, %castObj, %castPos, %color) { // setrecall

	%rune = $ItemData["Rune_"@%color, FixCaps];
	if(%rune == "") {
		Client::sendMessage(%Client, 0, "Invalid use. #cast setrecall [color]");
		return;
	}
	if($ClientData[%Client, "Rune", "State", %color] <= 0) {
		if(Client::HasItem(%Client, %rune)) { // do we have this Rune color?

			%wis = getFinalWIS(%Client)*getRandom();

			$ClientData[%Client, "Rune", "POS", %color] = "";
			$ClientData[%Client, "Rune", "State", %color] = "";

			if(%wis <= 10) {
				Client::addItemCount(%Client, %rune, -1);
				Client::sendMessage(%Client, 0, "Failed to setrecall on Rune "@%color@". Rune "@%color@" broke!"); // haha.
			}
			else if((getRandom()*100) == 0) {
				Client::addItemCount(%Client, %rune, -1);
				Client::sendMessage(%Client, 0, "Failed to setrecall on Rune "@%color@". Rune "@%color@" broke!"); // haha.
			}
			else if(%wis >= 11 && %wis <= 99) {
				$ClientData[%Client, "Rune", "POS", %color] = GameBase::GetPosition(%Client);
				$ClientData[%Client, "Rune", "State", %color] = Cap(floor(getRandom()*5), 2, 4); //2-4 time use
				Client::sendMessage(%Client, 0, "Rune "@%color@" is really weakened. (Charges "@$ClientData[%Client, "Rune", "State", %color]@")");
			}
			else if(%wis >= 100 && %wis <= 150) {
				$ClientData[%Client, "Rune", "POS", %color] = GameBase::GetPosition(%Client);
				$ClientData[%Client, "Rune", "State", %color] = Cap(floor(getRandom()*10), 4, 8);
				Client::sendMessage(%Client, 0, "Rune "@%color@" is a little weakened. (Charges "@$ClientData[%Client, "Rune", "State", %color]@")");
			}
			else if(%wis > 150 && %wis <= 250) {
				$ClientData[%Client, "Rune", "POS", %color] = GameBase::GetPosition(%Client);
				$ClientData[%Client, "Rune", "State", %color] = Cap(floor(getRandom()*15), 8, 12);
				Client::sendMessage(%Client, 0, "Rune "@%color@" is ok. (Charges "@$ClientData[%Client, "Rune", "State", %color]@")");
			}
			else if(%wis > 250 && %wis <= 350) {
				$ClientData[%Client, "Rune", "POS", %color] = GameBase::GetPosition(%Client);
				$ClientData[%Client, "Rune", "State", %color] = Cap(floor(getRandom()*22), 12, 16);
				Client::sendMessage(%Client, 0, "Rune "@%color@" is good. (Charges "@$ClientData[%Client, "Rune", "State", %color]@")");
			}
			else if(%wis > 350 && %wis <= 600) {
				$ClientData[%Client, "Rune", "POS", %color] = GameBase::GetPosition(%Client);
				$ClientData[%Client, "Rune", "State", %color] = Cap(floor(getRandom()*30), 16, 24);
				Client::sendMessage(%Client, 0, "Rune "@%color@" is fine. (Charges "@$ClientData[%Client, "Rune", "State", %color]@")");
			}
			else if(%wis > 600 && %wis <= 900) {
				$ClientData[%Client, "Rune", "POS", %color] = GameBase::GetPosition(%Client);
				$ClientData[%Client, "Rune", "State", %color] = Cap(floor(getRandom()*40), 24, 30);
				Client::sendMessage(%Client, 0, "Rune "@%color@" is strong. (Charges "@$ClientData[%Client, "Rune", "State", %color]@")");
			}
			else if(%wis > 900 && %wis <= 1500) {
				$ClientData[%Client, "Rune", "POS", %color] = GameBase::GetPosition(%Client);
				$ClientData[%Client, "Rune", "State", %color] = Cap(floor(getRandom()*50), 30, 36);
				Client::sendMessage(%Client, 0, "Rune "@%color@" is very strong. (Charges "@$ClientData[%Client, "Rune", "State", %color]@")");
			}
			else if(%wis > 1500 && %wis < 2000) {
				$ClientData[%Client, "Rune", "POS", %color] = GameBase::GetPosition(%Client);
				$ClientData[%Client, "Rune", "State", %color] = Cap(floor(getRandom()*65), 36, 50);
				Client::sendMessage(%Client, 0, "Rune "@%color@" is excellent. (Charges "@$ClientData[%Client, "Rune", "State", %color]@")");
			}
			else if(%wis >= 2000) {
				$ClientData[%Client, "Rune", "POS", %color] = GameBase::GetPosition(%Client);
				$ClientData[%Client, "Rune", "State", %color] = Cap(floor(getRandom()*100), 50, 100);
				Client::sendMessage(%Client, 0, "Rune "@%color@" is superior. (Charges "@$ClientData[%Client, "Rune", "State", %color]@")");
			}
		}
		else
			Client::sendMessage(%Client, 0, "SetRecall failed. You do not have the rune color "@%color@".");
	}
	else
		Client::sendMessage(%Client, 0, "Rune "@%color@" is already charged. (Charges "@$ClientData[%Client, "Rune", "State", %color]@")");
}

function SpellNum64(%Client, %castObj, %castPos, %color) { // recall

	%rune = $ItemData["Rune_"@%color, FixCaps];
	if(%rune == "") {
		Client::sendMessage(%Client, 0, "Invalid use. #cast recall [color]");
		return;
	}
	if(Client::HasItem(%Client, %rune)) { // do we have this Rune color?
		if($ClientData[%Client, "Rune", "State", %color] > 0) { // did we charge it?

			$ClientData[%Client, "Rune", "State", %color]--;
			GameBase::SetPosition(%Client, $ClientData[%Client, "Rune", "POS", %color]);

			Client::sendMessage(%Client, 0, "Recalled! Nearest zone is "@_GetNearestZone(%Client)@".");

			if($ClientData[%Client, "Rune", "State", %color] <= 0) {
				Client::sendMessage(%Client, 0, "Rune "@%color@" broke.");
				Client::addItemCount(%Client, %rune, -1);
			}
			else if($ClientData[%Client, "Rune", "State", %color] == 1) {
				Client::sendMessage(%Client, 0, "Rune "@%color@" has one charge left.");
			}

		}
		else
			Client::sendMessage(%Client, 0, "Rune "@%color@" not charge!  #cast setrecall "@%color@" ");
	}
	else
		Client::sendMessage(%Client, 0, "SetRecall failed. You do not have the rune color "@%color@".");
}

function SpellNum65(%Client, %castObj, %castPos) {
	//Medic 5
	if(getObjectType(%castObj) == "Player")
		%HealId = Player::getClient(%castObj);
	else
		%HealId = %Client;

	Client::sendMessage(%Client, $MsgGreen, "Restoring "@Client::getName(%HealId));
	if(%Client != %Healid)
		Client::sendMessage(%HealId, $MsgGreen, "You are being fully cured by "@Client::getName(%Client));

	%r = $Spell::damageValue[7] / $TribesDamageToNumericDamage;

	refreshHP(%HealId, %r);

//	%castPos = GameBase::getPosition(%HealId);

	return "returnFlag 1 HealId "@%HealId;
}

function SpellNum66(%Client, %castObj, %castPos) {
	// %passed = checkArea(%Client, 5);
	// if(!%passed) {
	// 	Client::sendMessage(%Client, $MsgBeige, "You are to close to an object. (wall or tree, etc)");
	// }
	// else {
		%wall = newObject("MagicWall", "StaticShape", hvshield2, true);//,false);
		if(%wall != 0) {
			addToSet("MissionCleanup", %wall);
			%time = floor(getFinalLVL(%Client)*7.2);
			schedule("Item::Pop("@%wall@");", %time, %wall);
			%pos = GameBase::getPosition(%Client);
			%wall.hp = floor(getFinalLVL(%client)*0.9);
			%wall.owner = client::getname(%client);
			GameBase::setPosition(%wall, GetWord(%pos,0)@" "@GetWord(%pos,1)@" "@GetWord(%pos,2)+3.5);
			//GameBase::setRotation(%wall, GetWord(GameBase::getRotation(%Client),0)+1.6@" "@GetWord(GameBase::getRotation(%Client),1)@" "@(GetWord(GameBase::getRotation(%Client),2)+1.6));
			GameBase::setRotation(%wall, "0 0 1.6");
			Client::sendmessage(%client,0,"You create a magic wall with "@%time@" seconds of life and "@%wall.hp@" hp!");
		}
		return "returnFlag 1";
	//}
}

function SpellNum67(%Client, %castObj, %castPos) {
	if(getObjectType(%castObj) == "Player")
		%id = Player::getClient(%castObj);
	else
		%id = %Client;

	%time = $AP[%Client, 1] - ($AP[%id, 1] /2);
	if(%time > 120)	%time = 120;

	if(%time <= 0)
	{
		%id = %client;
		remoteEval(%client,"ATKText", "<JC>REFLECT!", true);
		%time = 60;
	}

	cage(%id,%time,1);
	remoteEval(%client,"ATKText", "<JC>You caged "@client::getname(%id)@" for "@%time@" seconds.", true);
	if(%client != %id)
		remoteEval(%id,"ATKText", "<JC>You were caged by "@client::getname(%client)@" for "@%time@" seconds.", false);

	return "returnFlag 1";
}

function SpellNum68(%Client, %castObj, %castPos) {
	%player = Client::getOwnedObject(%Client);
	if(%castPos != "")
	{
		%minrad = 0;
		%maxrad = $Spell::radius[%index] / 2;
		for(%i = 0; %i <= 8; %i++)
		{
			%tempPos = RandomPositionXY(%minrad, %maxrad);

			%xPos = GetWord(%tempPos, 0) + GetWord(%castPos, 0);
			%yPos = GetWord(%tempPos, 1) + GetWord(%castPos, 1);
			%zPos = GetWord(%castPos, 2);

			%newPos = %xPos@" "@%yPos@" "@%zPos;

			schedule("CreateAndDetBomb("@%clientId@", \"Supercheebomb1\", \""@%newPos@"\", False, "@%index@");", %i / 7, %player);
		}
		CreateAndDetBomb(%clientId, "Supercheebomb1", %castPos, True, %index);

		%overrideEndSound = True;
		%returnFlag = True;
	}
	else
	{
		Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");
		%returnFlag = False;
	}
}

function SpellNum69(%clientId, %castObj, %castPos) {
	// if their level is 100 + remort levels then they can remort
	%requiredLevel = 100 + (fetchData(%clientId, "RemortStep") * 5);

	if (fetchData(%clientId, "LVL") < %requiredLevel) {
		Client::sendMessage(%clientId, $MsgRed, "You need to be level " @ %requiredLevel @ " to remort.");
		%returnFlag = False;
	} else {
		if(!fetchData(%clientId, "currentlyRemorting")) {
			%castPos = DoRemort(%clientId);		

			%extraDelay = 0.22;
			%returnFlag = True;
		}
		else
			%returnFlag = False;
	}
}

function SpellNum70(%clientId, %castObj, %castPos) {
	%player = Client::getOwnedObject(%clientId);

	// shadow blade
	if(%castPos != "")	{
		%index = 70;
		%xPos = getWord(%castPos, 0);
		%yPos = getWord(%castPos, 1);
		%zPos = getWord(%castPos, 2) + 350;

		%newPos = %xPos @ " " @ %yPos @ " " @ %zPos;

		// %sword = newObject("", "StaticShape", Masamune, true);
		// addToSet("MissionCleanup", %sword);
		// GameBase::setPosition(%sword, %castPos);
		// GameBase::setRotation(%sword, );

		%sword = newObject("", InteriorShape, "masamunefinal.dis");
		gamebase::setPosition(%sword, %newPos);
		// gamebase::setRotation(%sword, vector::getrotation($los::normal));
		addToSet("MissionCleanup", %sword);
		schedule("Item::Pop(" @ %sword @ ");", 10, %sword);

		%minrad = 0;
		%maxrad = 4;

		// blue lights
		// for(%i = 0; %i <= 10; %i++)
		// {
		// 	%tempPos = RandomPositionXY(%minrad, %maxrad);

		// 	%xPos = GetWord(%tempPos, 0) + GetWord(%castPos, 0);
		// 	%yPos = GetWord(%tempPos, 1) + GetWord(%castPos, 1);
		// 	%zPos = GetWord(%castPos, 2) + (%i / 4);
	
		// 	%newPos = %xPos @ " " @ %yPos @ " " @ %zPos;

		// 	schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb7\", \"" @ %newPos @ "\", False, " @ %index @ ");", %i / 20, %player);
		// }

		// scatter red lights
		for(%i = 0; %i <= 40; %i++)
		{
			%tempPos = RandomPositionXY(%minrad, %maxrad);

			%xPos = GetWord(%tempPos, 0) + GetWord(%castPos, 0);
			%yPos = GetWord(%tempPos, 1) + GetWord(%castPos, 1);
			%zPos = GetWord(%castPos, 2) + %i;
	
			%newPos = %xPos @ " " @ %yPos @ " " @ %zPos;

			// lbecho("add light");
			// schedule("CreateAndDetBomb(\"" @ %clientId @ "\", \"Bomb300\", \"" @ %newPos @ "\", False, \"" @ %index @ "\");", %i / 16, %player);
			schedule("CreateAndDetBomb(\"" @ %clientId @ "\", \"Bomb8\", \"" @ %newPos @ "\", False, \"" @ %index @ "\");", %i / 20, %player);
		}


		%xPos = getWord(%castPos, 0);
		%yPos = getWord(%castPos, 1);
		%zPos = getWord(%castPos, 2) + 350;

		for(%i = 1; %i <= 30; %i++) {
			%t = %i * 10;
			%newPos = %xPos @ " " @ %yPos @ " " @ %zPos - %t;
			schedule("gamebase::setPosition(" @ %sword @ ", \"" @ %newPos @ "\");", ((%i / 100) + 2), %player);
		}

		schedule("CreateAndDetBomb(\"" @ %clientId @ "\", \"Bomb6\", \"" @ %castPos @ "\", True, \"" @ %index @ "\");", 2.3, %player);
		schedule("CreateAndDetBomb(\"" @ %clientId @ "\", \"Bomb14\", \"" @ %castPos @ "\", True, \"" @ %index @ "\");", 2.35, %player);
		schedule("CreateAndDetBomb(\"" @ %clientId @ "\", \"Bomb5\", \"" @ %castPos @ "\", True, \"" @ %index @ "\");", 2.4, %player);
		schedule("CreateAndDetBomb(\"" @ %clientId @ "\", \"Bomb5\", \"" @ %castPos @ "\", True, \"" @ %index @ "\");", 2.5, %player);
		schedule("CreateAndDetBomb(\"" @ %clientId @ "\", \"Bomb5\", \"" @ %castPos @ "\", True, \"" @ %index @ "\");", 2.6, %player);

		%overrideEndSound = True;
		%returnFlag = True;
	}
	else
	{
		Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");
		%returnFlag = False;
	}
}

function SpellNum77(%clientId) {
	%duration = $Spell::duration[77];
	remoteEval(%clientId, "rpgbarhud", %duration * 2, 3, 2, "||", "", "Haste", "left");
	UpdateBonusState(%clientId, "Haste", %duration, "Haste");
}

// black hole
function SpellNum78(%clientId, %castObj, %castPos, %w2) {
	cast_blackhole(%clientId, %castObj, %castPos, %w2);
}

function ApplyBonusStateSpell(%targetId, %giver, %spellIndex, %type, %value) {
	if (%value == "")
		%value = $Spell::damageValue[%spellIndex];

	remoteEval(%targetId, "rpgbarhud", ($Spell::duration[%spellIndex] * 2), 3, 2, "||", "", $Spell::name[%spellIndex], "left");

	// lbecho("Applying bonus state: " @ $Spell::name[%spellIndex]);
	// lbecho("To " @ %targetId);
	// lbecho("With value: " @ %value);

	UpdateBonusState(%targetId, $Spell::keyword[%spellIndex], $Spell::duration[%spellIndex], $Spell::keyword[%spellIndex], %giver, "HP", %value, True);
}

// regen
function SpellNum79(%clientId, %castObj, %castPos, %w2) {
	ApplyBonusStateSpell(%clientId, %clientId, 79, "HP");
}

// regen2
function SpellNum80(%clientId, %castObj, %castPos, %w2) {
	ApplyBonusStateSpell(%clientId, %clientId, 80, "HP");
}

// regen3
function SpellNum81(%clientId, %castObj, %castPos, %w2) {
	ApplyBonusStateSpell(%clientId, %clientId, 81, "HP");
}

// regen4
function SpellNum82(%clientId, %castObj, %castPos, %w2) {
	ApplyBonusStateSpell(%clientId, %clientId, 82, "HP");
}

// hex
function SpellNum83(%clientId, %castObj, %castPos, %w2) {
	if(Player::isAiControlled(%castObj)) {
		ApplyBonusStateSpell(Player::getClient(%castObj), %clientId, 83, "HP");
	}
}

// vex
function SpellNum84(%clientId, %castObj, %castPos, %w2) {
	if(Player::isAiControlled(%castObj)) {
		ApplyBonusStateSpell(Player::getClient(%castObj), %clientId, 84, "HP");
	}
}

// curse
function SpellNum85(%clientId, %castObj, %castPos, %w2) {
	if(Player::isAiControlled(%castObj)) {
		ApplyBonusStateSpell(Player::getClient(%castObj), %clientId, 85, "HP");
	}
}

// plague
function SpellNum86(%clientId, %castObj, %castPos, %w2) {
	if(Player::isAiControlled(%castObj)) {
		ApplyBonusStateSpell(Player::getClient(%castObj), %clientId, 86, "HP");
	}
}

// blackdeath
function SpellNum87(%clientId, %castObj, %castPos, %w2) {
	if(Player::isAiControlled(%castObj)) {
		ApplyBonusStateSpell(Player::getClient(%castObj), %clientId, 87, "HP");
	}
}

function SpellNum88(%clientId, %castObj, %castPos) {
	%index = 88;
	%player = Client::getOwnedObject(%clientId);

	// shadow blade
	if(%castPos != "")	{
		%xPos = getWord(%castPos, 0);
		%yPos = getWord(%castPos, 1);
		%zPos = getWord(%castPos, 2) + 350;

		%newPos = %xPos @ " " @ %yPos @ " " @ %zPos;

		// %sword = newObject("", "StaticShape", Masamune, true);
		// addToSet("MissionCleanup", %sword);
		// GameBase::setPosition(%sword, %castPos);
		// GameBase::setRotation(%sword, );

		%sword = newObject("", InteriorShape, "masamunefinal.dis");
		gamebase::setPosition(%sword, %newPos);
		// gamebase::setRotation(%sword, vector::getrotation($los::normal));
		addToSet("MissionCleanup", %sword);
		schedule("Item::Pop(" @ %sword @ ");", 10, %sword);

		%minrad = 0;
		%maxrad = 4;

		// blue lights
		// for(%i = 0; %i <= 10; %i++)
		// {
		// 	%tempPos = RandomPositionXY(%minrad, %maxrad);

		// 	%xPos = GetWord(%tempPos, 0) + GetWord(%castPos, 0);
		// 	%yPos = GetWord(%tempPos, 1) + GetWord(%castPos, 1);
		// 	%zPos = GetWord(%castPos, 2) + (%i / 4);
	
		// 	%newPos = %xPos @ " " @ %yPos @ " " @ %zPos;

		// 	schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb7\", \"" @ %newPos @ "\", False, " @ %index @ ");", %i / 20, %player);
		// }

		// scatter red lights
		for(%i = 0; %i <= 40; %i++)
		{
			%tempPos = RandomPositionXY(%minrad, %maxrad);

			%xPos = GetWord(%tempPos, 0) + GetWord(%castPos, 0);
			%yPos = GetWord(%tempPos, 1) + GetWord(%castPos, 1);
			%zPos = GetWord(%castPos, 2) + %i;
	
			%newPos = %xPos @ " " @ %yPos @ " " @ %zPos;

			// lbecho("add light");
			// schedule("CreateAndDetBomb(\"" @ %clientId @ "\", \"Bomb300\", \"" @ %newPos @ "\", False, \"" @ %index @ "\");", %i / 16, %player);
			schedule("CreateAndDetBomb(\"" @ %clientId @ "\", \"Bomb305\", \"" @ %newPos @ "\", False, \"" @ %index @ "\");", %i / 20, %player);
		}


		%xPos = getWord(%castPos, 0);
		%yPos = getWord(%castPos, 1);
		%zPos = getWord(%castPos, 2) + 350;

		for(%i = 1; %i <= 30; %i++) {
			%t = %i * 10;
			%newPos = %xPos @ " " @ %yPos @ " " @ %zPos - %t;
			schedule("gamebase::setPosition(" @ %sword @ ", \"" @ %newPos @ "\");", ((%i / 100) + 2), %player);
		}

		schedule("CreateAndDetBomb(\"" @ %clientId @ "\", \"Bomb6\", \"" @ %castPos @ "\", True, \"" @ %index @ "\");", 2.3, %player);
		schedule("CreateAndDetBomb(\"" @ %clientId @ "\", \"Bomb14\", \"" @ %castPos @ "\", True, \"" @ %index @ "\");", 2.35, %player);
		schedule("CreateAndDetBomb(\"" @ %clientId @ "\", \"Bomb5\", \"" @ %castPos @ "\", True, \"" @ %index @ "\");", 2.4, %player);
		schedule("CreateAndDetBomb(\"" @ %clientId @ "\", \"Bomb5\", \"" @ %castPos @ "\", True, \"" @ %index @ "\");", 2.5, %player);
		schedule("CreateAndDetBomb(\"" @ %clientId @ "\", \"Bomb5\", \"" @ %castPos @ "\", True, \"" @ %index @ "\");", 2.6, %player);

		%overrideEndSound = True;
		%returnFlag = True;
	}
	else
	{
		Client::sendMessage(%clientId, $MsgBeige, "Could not find a target.");
		%returnFlag = False;
	}
}
// //-- SPELL DEFINITIONS -------------------------------------------------------------------------------------------

// $Spell::keyword[1] = "firebomb";
// $Spell::index[firebomb] = 1;
// $Spell::name[1] = "Fire Bomb From Hell";
// $Spell::description[1] = "Casts an explosive.";
// $Spell::delay[1] = 1.5;
// $Spell::recoveryTime[1] = 2.625;
// $Spell::radius[1] = 10;
// $Spell::damageValue[1] = "55";
// $Spell::LOSrange[1] = 80;
// $Spell::manaCost[1] = 5;
// $Spell::startSound[1] = ActivateBF;
// $Spell::endSound[1] = ExplodeLM;
// $Spell::groupListCheck[1] = False;
// $Spell::refVal[1] = 55;
// $Spell::graceDistance[1] = 2;
// $SkillType[firebomb] = $SkillBlackMagick;

// $Spell::keyword[2] = "teleport";
// $Spell::index[teleport] = 2;
// $Spell::name[2] = "Teleport close to nearest zone";
// $Spell::description[2] = "Teleports you near a zone";
// $Spell::delay[2] = 3.5;
// $Spell::recoveryTime[2] = 16.5;
// $Spell::manaCost[2] = 8;
// $Spell::startSound[2] = Portal11;
// $Spell::endSound[2] = ActivateCH;
// $Spell::groupListCheck[2] = False;
// $Spell::refVal[2] = 0;
// $Spell::graceDistance[2] = 2;
// $SkillType[teleport] = $SkillTimeMagick;
// $spell::menu[2] = True;

// $Spell::keyword[3] = "transport";
// $Spell::index[transport] = 3;
// $Spell::name[3] = "Transport to zone";
// $Spell::description[3] = "Transports to a specific zone";
// $Spell::delay[3] = 4.0;
// $Spell::recoveryTime[3] = 23;
// $Spell::manaCost[3] = 12;
// $Spell::startSound[3] = RespawnB;
// $Spell::endSound[3] = ActivateCH;
// $Spell::groupListCheck[3] = False;
// $Spell::refVal[3] = 0;
// $Spell::graceDistance[3] = 2;
// $SkillType[transport] = $SkillTimeMagick;

// $Spell::keyword[4] = "advtransport";
// $Spell::index[advtransport] = 4;
// $Spell::name[4] = "Advanced Transport to zone";
// $Spell::description[4] = "Transports self OR person in line-of-sight to a specific zone";
// $Spell::delay[4] = 4.0;
// $Spell::recoveryTime[4] = 27;
// $Spell::LOSrange[4] = 500;
// $Spell::manaCost[4] = 16;
// $Spell::startSound[4] = RespawnB;
// $Spell::endSound[4] = ActivateCH;
// $Spell::groupListCheck[4] = True;
// $Spell::refVal[4] = 0;
// $Spell::graceDistance[4] = 2;
// $SkillType[advtransport] = $SkillTimeMagick;

// $Spell::keyword[5] = "cloud";
// $Spell::index[cloud] = 5;
// $Spell::name[5] = "Cloud Attack";
// $Spell::description[5] = "Casts an explosive.";
// $Spell::delay[5] = 1.5;
// $Spell::recoveryTime[5] = 2.625;
// $Spell::radius[5] = 10;
// $Spell::damageValue[5] = "85";
// $Spell::LOSrange[5] = 80;
// $Spell::manaCost[5] = 10;
// $Spell::startSound[5] = ActivateBF;
// $Spell::endSound[5] = ExplodeLM;
// $Spell::groupListCheck[5] = False;
// $Spell::refVal[5] = 85;
// $Spell::graceDistance[5] = 2;
// $SkillType[cloud] = $SkillBlackMagick;

// $Spell::keyword[6] = "melt";
// $Spell::index[melt] = 6;
// $Spell::name[6] = "Melt Bomb Attack";
// $Spell::description[6] = "Casts an explosive.";
// $Spell::delay[6] = 1.5;
// $Spell::recoveryTime[6] = 2.625;
// $Spell::radius[6] = 10;
// $Spell::damageValue[6] = "140";
// $Spell::LOSrange[6] = 80;
// $Spell::manaCost[6] = 15;
// $Spell::startSound[6] = ActivateBF;
// $Spell::endSound[6] = ExplodeLM;
// $Spell::groupListCheck[6] = False;
// $Spell::refVal[6] = 140;
// $Spell::graceDistance[6] = 2;
// $SkillType[melt] = $SkillBlackMagick;

// $Spell::keyword[7] = "powercloud";
// $Spell::index[powercloud] = 7;
// $Spell::name[7] = "Power Cloud Attack";
// $Spell::description[7] = "Casts three explosives.";
// $Spell::delay[7] = 1.5;
// $Spell::recoveryTime[7] = 7.5;
// $Spell::radius[7] = 10;
// $Spell::damageValue[7] = "70";
// $Spell::LOSrange[7] = 80;
// $Spell::manaCost[7] = 20;
// $Spell::startSound[7] = ActivateBF;
// $Spell::endSound[7] = ExplodeLM;
// $Spell::groupListCheck[7] = False;
// $Spell::refVal[7] = 210;
// $Spell::graceDistance[7] = 2;
// $SkillType[powercloud] = $SkillBlackMagick;

// $Spell::keyword[8] = "heal";
// $Spell::index[heal] = 8;
// $Spell::name[8] = "Heal Self";
// $Spell::description[8] = "Heals the caster.";
// $Spell::delay[8] = 1.5;
// $Spell::recoveryTime[8] = 2.25;
// $Spell::damageValue[8] = -12;
// $Spell::manaCost[8] = 2;
// $Spell::startSound[8] = DeActivateWA;
// $Spell::endSound[8] = ActivateAR;
// $Spell::groupListCheck[8] = False;
// $Spell::refVal[8] = -6;
// $Spell::graceDistance[8] = 2;
// $SkillType[heal] = $SkillWhiteMagick;

// $Spell::keyword[9] = "advheal1";
// $Spell::index[advheal1] = 9;
// $Spell::name[9] = "Heal Self or Other (1st)";
// $Spell::description[9] = "Heals the caster or someone in the LOS.";
// $Spell::delay[9] = 1.5;
// $Spell::recoveryTime[9] = 3.25;
// $Spell::damageValue[9] = -20;
// $Spell::LOSrange[9] = 80;
// $Spell::manaCost[9] = 3;
// $Spell::startSound[9] = DeActivateWA;
// $Spell::endSound[9] = ActivateAR;
// $Spell::groupListCheck[9] = False;
// $Spell::refVal[9] = -10;
// $Spell::graceDistance[9] = 2;
// $SkillType[advheal1] = $SkillWhiteMagick;

// $Spell::keyword[10] = "advheal2";
// $Spell::index[advheal2] = 10;
// $Spell::name[10] = "Heal Self Or Other (2nd)";
// $Spell::description[10] = "Heals the caster or someone in the LOS.";
// $Spell::delay[10] = 1.5;
// $Spell::recoveryTime[10] = 4.0;
// $Spell::damageValue[10] = -30;
// $Spell::LOSrange[10] = 80;
// $Spell::manaCost[10] = 4;
// $Spell::startSound[10] = DeActivateWA;
// $Spell::endSound[10] = ActivateAR;
// $Spell::groupListCheck[10] = False;
// $Spell::refVal[10] = -15;
// $Spell::graceDistance[10] = 2;
// $SkillType[advheal2] = $SkillWhiteMagick;

// $Spell::keyword[11] = "godlyheal";
// $Spell::index[godlyheal] = 11;
// $Spell::name[11] = "Godly Heal Self Or Other";
// $Spell::description[11] = "Heals the caster or someone in the LOS.";
// $Spell::delay[11] = 1.5;
// $Spell::recoveryTime[11] = 6;
// $Spell::damageValue[11] = -160;
// $Spell::LOSrange[11] = 80;
// $Spell::manaCost[11] = 15;
// $Spell::startSound[11] = DeActivateWA;
// $Spell::endSound[11] = ActivateAR;
// $Spell::groupListCheck[11] = False;
// $Spell::refVal[11] = -80;
// $Spell::graceDistance[11] = 2;
// $SkillType[godlyheal] = $SkillWhiteMagick;

// $Spell::keyword[12] = "beam";
// $Spell::index[beam] = 12;
// $Spell::name[12] = "Beam";
// $Spell::description[12] = "Light gathers into a concentrated beam and causes intense damage to the target.";
// $Spell::delay[12] = 0.0;
// $Spell::recoveryTime[12] = 1;
// $Spell::damageValue[12] = "180";
// $Spell::LOSrange[12] = 1000;
// $Spell::manaCost[12] = 30;
// $Spell::startSound[12] = HitLevelDT;
// $Spell::endSound[12] = HitBF;
// $Spell::groupListCheck[12] = False;
// $Spell::refVal[12] = 180;
// $Spell::graceDistance[12] = 5;
// $SkillType[beam] = $SkillBlackMagick;

// $Spell::keyword[13] = "thorn";
// $Spell::index[thorn] = 13;
// $Spell::name[13] = "Thorn";
// $Spell::description[13] = "Casts thorn.";
// $Spell::delay[13] = 0.1;
// $Spell::recoveryTime[13] = 1.5;
// $Spell::radius[13] = 6;
// $Spell::damageValue[13] = "20";
// $Spell::LOSrange[13] = 80;
// $Spell::manaCost[13] = 1;
// $Spell::startSound[13] = ActivateFK;
// $Spell::endSound[13] = DeflectAS;
// $Spell::groupListCheck[13] = False;
// $Spell::refVal[13] = 20;
// $Spell::graceDistance[13] = 5;
// $SkillType[thorn] = $SkillBlackMagick;

// $Spell::keyword[14] = "fire";
// $Spell::index[fire] = 14;
// $Spell::name[14] = "Fire";
// $Spell::description[14] = "Casts a fire spell.";
// $Spell::delay[14] = 1;
// $Spell::recoveryTime[14] = 1.5;
// $Spell::radius[14] = 8;
// $Spell::damageValue[14] = "35";
// $Spell::LOSrange[14] = 80;
// $Spell::manaCost[14] = 3;
// $Spell::startSound[14] = ActivateAB;
// $Spell::endSound[14] = LaunchFB;
// $Spell::groupListCheck[14] = False;
// $Spell::refVal[14] = 35;
// $Spell::graceDistance[14] = 2;
// $SkillType[fire] = $SkillBlackMagick;

// $Spell::keyword[15] = "icespike";
// $Spell::index[icespike] = 15;
// $Spell::name[15] = "Icespike";
// $Spell::description[15] = "Casts icespike.";
// $Spell::delay[15] = 0.1;
// $Spell::recoveryTime[15] = 1.5;
// $Spell::radius[15] = 6;
// $Spell::damageValue[15] = "28";
// $Spell::LOSrange[15] = 80;
// $Spell::manaCost[15] = 3;
// $Spell::startSound[15] = ActivateFK;
// $Spell::endSound[15] = HitPawnDT;
// $Spell::groupListCheck[15] = False;
// $Spell::refVal[15] = 28;
// $Spell::graceDistance[15] = 5;
// $SkillType[icespike] = $SkillBlackMagick;

// $Spell::keyword[16] = "icestorm";
// $Spell::index[icestorm] = 16;
// $Spell::name[16] = "Icestorm";
// $Spell::description[16] = "Casts icestorm.";
// $Spell::delay[16] = 1;
// $Spell::recoveryTime[16] = 2.25;
// $Spell::radius[16] = 11;
// $Spell::damageValue[16] = "45";
// $Spell::LOSrange[16] = 80;
// $Spell::manaCost[16] = 4;
// $Spell::startSound[16] = ImpactTR;
// $Spell::endSound[16] = Reflected;
// $Spell::groupListCheck[16] = False;
// $Spell::refVal[16] = 45;
// $Spell::graceDistance[16] = 2;
// $SkillType[icestorm] = $SkillBlackMagick;

// $Spell::keyword[17] = "ironfist";
// $Spell::index[ironfist] = 17;
// $Spell::name[17] = "Ironfist";
// $Spell::description[17] = "Casts ironfist.";
// $Spell::delay[17] = 0.1;
// $Spell::recoveryTime[17] = 13.5;
// $Spell::radius[17] = 7;
// $Spell::damageValue[17] = "128";
// $Spell::LOSrange[17] = 80;
// $Spell::manaCost[17] = 12;
// $Spell::startSound[17] = UnravelAM;
// $Spell::endSound[17] = NoSound;
// $Spell::groupListCheck[17] = False;
// $Spell::refVal[17] = 128;
// $Spell::graceDistance[17] = 3;
// $SkillType[ironfist] = $SkillBlackMagick;

// $Spell::keyword[18] = "hellstorm";
// $Spell::index[hellstorm] = 18;
// $Spell::name[18] = "Hellstorm";
// $Spell::description[18] = "Casts hellstorm.";
// $Spell::delay[18] = 6;
// $Spell::recoveryTime[18] = 10.5;
// $Spell::radius[18] = 20;
// $Spell::damageValue[18] = "265";
// $Spell::LOSrange[18] = 80;
// $Spell::manaCost[18] = 20;
// $Spell::startSound[18] = LoopLS;
// $Spell::endSound[18] = LaunchET;
// $Spell::groupListCheck[18] = False;
// $Spell::refVal[18] = 265;
// $Spell::graceDistance[18] = 2;
// $SkillType[hellstorm] = $SkillBlackMagick;

// $Spell::keyword[19] = "dimensionrift";
// $Spell::index[dimensionrift] = 19;
// $Spell::name[19] = "Dimension Rift";
// $Spell::description[19] = "Casts Dimension Rift.";
// $Spell::delay[19] = 9.5;
// $Spell::recoveryTime[19] = 11.25;
// $Spell::radius[19] = 30;
// $Spell::damageValue[19] = "320";
// $Spell::LOSrange[19] = 80;
// $Spell::manaCost[19] = 40;
// $Spell::startSound[19] = LaunchLS;
// $Spell::endSound[19] = Explode3FW;
// $Spell::groupListCheck[19] = False;
// $Spell::refVal[19] = 320;
// $Spell::graceDistance[19] = 2;
// $SkillType[dimensionrift] = $SkillBlackMagick;

// $Spell::keyword[20] = "advheal3";
// $Spell::index[advheal3] = 20;
// $Spell::name[20] = "Heal Self Or Other (3rd)";
// $Spell::description[20] = "Heals the caster or someone in the LOS.";
// $Spell::delay[20] = 1.5;
// $Spell::recoveryTime[20] = 4.75;
// $Spell::damageValue[20] = -50;
// $Spell::LOSrange[20] = 80;
// $Spell::manaCost[20] = 5;
// $Spell::startSound[20] = DeActivateWA;
// $Spell::endSound[20] = ActivateAR;
// $Spell::groupListCheck[20] = False;
// $Spell::refVal[20] = -25;
// $Spell::graceDistance[20] = 2;
// $SkillType[advheal3] = $SkillWhiteMagick;

// $Spell::keyword[21] = "remort";
// $Spell::index[remort] = 21;
// $Spell::name[21] = "Remort";
// $Spell::description[21] = "Remorts a high level character to level 1, and allows them to choose another class.";
// $Spell::delay[21] = 3.0;
// $Spell::recoveryTime[21] = 1;
// $Spell::damageValue[21] = 0;
// $Spell::manaCost[21] = 1;
// $Spell::startSound[21] = RespawnA;
// $Spell::endSound[21] = RespawnC;
// $Spell::groupListCheck[21] = False;
// $Spell::refVal[21] = 0;
// $Spell::graceDistance[21] = 2;
// $SkillType[remort] = $SkillTimeMagick;

// $Spell::keyword[22] = "fullheal";
// $Spell::index[fullheal] = 22;
// $Spell::name[22] = "Full Heal Self";
// $Spell::description[22] = "Fully heals the caster.";
// $Spell::delay[22] = 1.5;
// $Spell::recoveryTime[22] = 60;
// $Spell::damageValue[22] = 0;
// $Spell::manaCost[22] = 2;
// $Spell::startSound[22] = DeActivateWA;
// $Spell::endSound[22] = PlaceSeal;
// $Spell::groupListCheck[22] = False;
// $Spell::refVal[22] = -9998;
// $Spell::graceDistance[22] = 2;
// $SkillType[fullheal] = $SkillWhiteMagick;

// $Spell::keyword[23] = "massheal";
// $Spell::index[massheal] = 23;
// $Spell::name[23] = "Mass Heal";
// $Spell::description[23] = "Heals caster and friendlies 10 meters around.";
// $Spell::delay[23] = 1.5;
// $Spell::recoveryTime[23] = 10;
// $Spell::radius[23] = 10;
// $Spell::damageValue[23] = -30;
// $Spell::manaCost[23] = 12;
// $Spell::startSound[23] = DeActivateWA;
// $Spell::endSound[23] = ActivateAR;
// $Spell::groupListCheck[23] = False;
// $Spell::refVal[23] = -30;
// $Spell::graceDistance[23] = 2;
// $SkillType[massheal] = $SkillWhiteMagick;

// $Spell::keyword[24] = "massfullheal";
// $Spell::index[massfullheal] = 24;
// $Spell::name[24] = "Mass Full Heal";
// $Spell::description[24] = "Fully Heals caster and friendlies 12 meters around.";
// $Spell::delay[24] = 1.5;
// $Spell::recoveryTime[24] = 300;
// $Spell::radius[24] = 12;
// $Spell::damageValue[24] = 0;
// $Spell::manaCost[24] = 200;
// $Spell::startSound[24] = DeActivateWA;
// $Spell::endSound[24] = PlaceSeal;
// $Spell::groupListCheck[24] = False;
// $Spell::refVal[24] = -9999;
// $Spell::graceDistance[24] = 2;
// $SkillType[massfullheal] = $SkillWhiteMagick;

// $Spell::keyword[25] = "shield";
// $Spell::index[shield] = 25;
// $Spell::name[25] = "Shield Self";
// $Spell::description[25] = "A magical shield adds 50 DEF to the caster.";
// $Spell::delay[25] = 2.0;
// $Spell::recoveryTime[25] = 8;
// $Spell::damageValue[25] = "DEF 50";
// $Spell::ticks[25] = 150;	//5 minutes
// $Spell::manaCost[25] = 5;
// $Spell::startSound[25] = ActivateTR;
// $Spell::endSound[25] = ActivateTD;
// $Spell::groupListCheck[25] = False;
// $Spell::refVal[25] = -10;
// $Spell::graceDistance[25] = 2;
// $SkillType[shield] = $SkillWhiteMagick;

// $Spell::keyword[26] = "advshield1";
// $Spell::index[advshield1] = 26;
// $Spell::name[26] = "Shield I";
// $Spell::description[26] = "A magical shield that adds 80 DEF to the caster or target in LOS.";
// $Spell::delay[26] = 2.0;
// $Spell::recoveryTime[26] = 10;
// $Spell::damageValue[26] = "DEF 80";
// $Spell::ticks[26] = 165;	//5:30 minutes
// $Spell::LOSrange[26] = 80;
// $Spell::manaCost[26] = 8;
// $Spell::startSound[26] = ActivateTR;
// $Spell::endSound[26] = ActivateTD;
// $Spell::groupListCheck[26] = False;
// $Spell::refVal[26] = -11;
// $Spell::graceDistance[26] = 2;
// $SkillType[advshield1] = $SkillWhiteMagick;

// $Spell::keyword[27] = "advshield2";
// $Spell::index[advshield2] = 27;
// $Spell::name[27] = "Shield II";
// $Spell::description[27] = "A magical shield that adds 70 DEF and 50 MDEF to the caster or target in LOS.";
// $Spell::delay[27] = 2.0;
// $Spell::recoveryTime[27] = 12;
// $Spell::damageValue[27] = "DEF 70 MDEF 50";
// $Spell::ticks[27] = 190;	//6:20 minutes
// $Spell::LOSrange[27] = 80;
// $Spell::manaCost[27] = 15;
// $Spell::startSound[27] = ActivateTR;
// $Spell::endSound[27] = ActivateTD;
// $Spell::groupListCheck[27] = False;
// $Spell::refVal[27] = -12;
// $Spell::graceDistance[27] = 2;
// $SkillType[advshield2] = $SkillWhiteMagick;

// $Spell::keyword[28] = "advshield3";
// $Spell::index[advshield3] = 28;
// $Spell::name[28] = "Shield III";
// $Spell::description[28] = "A magical shield that adds 120 DEF and 80 MDEF to the caster or target in LOS.";
// $Spell::delay[28] = 2.0;
// $Spell::recoveryTime[28] = 14;
// $Spell::damageValue[28] = "DEF 120 MDEF 80";
// $Spell::ticks[28] = 218;	//7:16 minutes
// $Spell::LOSrange[28] = 80;
// $Spell::manaCost[28] = 18;
// $Spell::startSound[28] = ActivateTR;
// $Spell::endSound[28] = ActivateTD;
// $Spell::groupListCheck[28] = False;
// $Spell::refVal[28] = -13;
// $Spell::graceDistance[28] = 2;
// $SkillType[advshield3] = $SkillWhiteMagick;

// $Spell::keyword[29] = "advshield4";
// $Spell::index[advshield4] = 29;
// $Spell::name[29] = "Shield IV";
// $Spell::description[29] = "A magical shield that adds 170 MDEF to the caster or target in LOS.";
// $Spell::delay[29] = 2.0;
// $Spell::recoveryTime[29] = 16;
// $Spell::damageValue[29] = "MDEF 170";
// $Spell::ticks[29] = 255;	//8:30 minutes
// $Spell::LOSrange[29] = 80;
// $Spell::manaCost[29] = 22;
// $Spell::startSound[29] = ActivateTR;
// $Spell::endSound[29] = ActivateTD;
// $Spell::groupListCheck[29] = False;
// $Spell::refVal[29] = -14;
// $Spell::graceDistance[29] = 2;
// $SkillType[advshield4] = $SkillWhiteMagick;

// $Spell::keyword[30] = "advshield5";
// $Spell::index[advshield5] = 30;
// $Spell::name[30] = "Shield V";
// $Spell::description[30] = "A magical shield that adds 150 DEF and 210 MDEF to the caster or target in LOS.";
// $Spell::delay[30] = 2.0;
// $Spell::recoveryTime[30] = 20;
// $Spell::damageValue[30] = "DEF 150 MDEF 210";
// $Spell::ticks[30] = 300;	//10 minutes
// $Spell::LOSrange[30] = 80;
// $Spell::manaCost[30] = 25;
// $Spell::startSound[30] = ActivateTR;
// $Spell::endSound[30] = ActivateTD;
// $Spell::groupListCheck[30] = False;
// $Spell::refVal[30] = -15;
// $Spell::graceDistance[30] = 2;
// $SkillType[advshield5] = $SkillWhiteMagick;

// $Spell::keyword[31] = "massshield";
// $Spell::index[massshield] = 31;
// $Spell::name[31] = "Mass Shield";
// $Spell::description[31] = "A magical shield that adds 115 DEF and 105 MDEF to all friendlies within a 10 meter radius.";
// $Spell::delay[31] = 2.0;
// $Spell::recoveryTime[31] = 30;
// $Spell::radius[31] = 10;
// $Spell::damageValue[31] = "DEF 115 MDEF 105";
// $Spell::ticks[31] = 270;	//9 minutes
// $Spell::manaCost[31] = 20;
// $Spell::startSound[31] = ActivateTR;
// $Spell::endSound[31] = ActivateTD;
// $Spell::groupListCheck[31] = False;
// $Spell::refVal[31] = -16;
// $Spell::graceDistance[31] = 2;
// $SkillType[massshield] = $SkillWhiteMagick;

// $Spell::keyword[32] = "mimic";
// $Spell::index[mimic] = 32;
// $Spell::name[32] = "Mimic";
// $Spell::description[32] = "A very dangerous spell that transforms the caster into the creature in his/her LOS.";
// $Spell::delay[32] = 4.0;
// $Spell::recoveryTime[32] = 60;
// $Spell::LOSrange[32] = 80;
// $Spell::damageValue[32] = 0;
// $Spell::manaCost[32] = 80;
// $Spell::startSound[32] = LoopSP;
// $Spell::endSound[32] = AbsorbABS;
// $Spell::groupListCheck[32] = False;
// $Spell::refVal[32] = 1;
// $Spell::graceDistance[32] = 2;
// $SkillType[mimic] = $SkillTimeMagick;

// $Spell::keyword[33] = "masstransport";
// $Spell::index[masstransport] = 33;
// $Spell::name[33] = "Mass Transport";
// $Spell::description[33] = "Transports self and all friendlies within a 6 meter radius to a specific zone.";
// $Spell::delay[33] = 4.0;
// $Spell::recoveryTime[33] = 45;
// $Spell::radius[33] = 6;
// $Spell::manaCost[33] = 50;
// $Spell::startSound[33] = RespawnB;
// $Spell::endSound[33] = ActivateCH;
// $Spell::groupListCheck[33] = False;
// $Spell::refVal[33] = 0;
// $Spell::graceDistance[33] = 2;
// $SkillType[masstransport] = $SkillTimeMagick;

// $Spell::keyword[34] = "advheal4";
// $Spell::index[advheal4] = 34;
// $Spell::name[34] = "Heal Self Or Other (4th)";
// $Spell::description[34] = "Heals the caster or someone in the LOS.";
// $Spell::delay[34] = 1.5;
// $Spell::recoveryTime[34] = 5.0;
// $Spell::damageValue[34] = -70;
// $Spell::LOSrange[34] = 80;
// $Spell::manaCost[34] = 6;
// $Spell::startSound[34] = DeActivateWA;
// $Spell::endSound[34] = ActivateAR;
// $Spell::groupListCheck[34] = False;
// $Spell::refVal[34] = -35;
// $Spell::graceDistance[34] = 2;
// $SkillType[advheal4] = $SkillWhiteMagick;

// $Spell::keyword[35] = "advheal5";
// $Spell::index[advheal5] = 35;
// $Spell::name[35] = "Heal Self Or Other (5th)";
// $Spell::description[35] = "Heals the caster or someone in the LOS.";
// $Spell::delay[35] = 1.5;
// $Spell::recoveryTime[35] = 5.5;
// $Spell::damageValue[35] = -100;
// $Spell::LOSrange[35] = 80;
// $Spell::manaCost[35] = 7;
// $Spell::startSound[35] = DeActivateWA;
// $Spell::endSound[35] = ActivateAR;
// $Spell::groupListCheck[35] = False;
// $Spell::refVal[35] = -50;
// $Spell::graceDistance[35] = 2;
// $SkillType[advheal5] = $SkillWhiteMagick;

// $Spell::keyword[36] = "advheal6";
// $Spell::index[advheal6] = 36;
// $Spell::name[36] = "Heal Self Or Other (6th)";
// $Spell::description[36] = "Heals the caster or someone in the LOS.";
// $Spell::delay[36] = 1.5;
// $Spell::recoveryTime[36] = 6.0;
// $Spell::damageValue[36] = -120;
// $Spell::LOSrange[36] = 80;
// $Spell::manaCost[36] = 8;
// $Spell::startSound[36] = DeActivateWA;
// $Spell::endSound[36] = ActivateAR;
// $Spell::groupListCheck[36] = False;
// $Spell::refVal[36] = -60;
// $Spell::graceDistance[36] = 2;
// $SkillType[advheal6] = $SkillWhiteMagick;

//----------------------------------------------------------------------------------------------------------------

function sendDoneRecovMsg(%clientId) {
	//this function is here just to make the schedule command where this is called easier to read
	Client::sendMessage(%clientId, $MsgBeige, "You are ready to cast.");
}

function SpellCanCast(%clientId, %keyword)
{
	dbecho($dbechoMode, "SpellCanCast(" @ %clientId @ ", " @ %keyword @ ")");

	for(%i = 1; $Spell::keyword[%i] != ""; %i++)
	{
		if(String::ICompare($Spell::keyword[%i], %keyword) == 0)
		{
			if(SkillCanUse(%clientId, $Spell::keyword[%i]))
			{
				%spellCost = $Spell::manaCost[%i];
				if (HasBonusState(%clientId, "DoubleCast"))
					%spellCost = %spellCost * 2;

					if(fetchData(%clientId, "MaxMANA") >= %spellCost)
					return True;
			}
		}
	}
	return False;
}
function SpellCanCastNow(%clientId, %keyword)
{
	dbecho($dbechoMode, "SpellCanCastNow(" @ %clientId @ ", " @ %keyword @ ")");

	for(%i = 1; $Spell::keyword[%i] != ""; %i++)
	{
		if(String::ICompare($Spell::keyword[%i], %keyword) == 0)
		{
			if(SkillCanUse(%clientId, $Spell::keyword[%i]))
			{
				%spellCost = $Spell::manaCost[%i];
				if (HasBonusState(%clientId, "DoubleCast"))
					%spellCost = %spellCost * 2;

				if(fetchData(%clientId, "MANA") >= %spellCost)
					return True;
			}
		}
	}
	return False;
}

function casting::teleport(%clientId, %index, %oldpos, %castObj, %w2)
{
	%zoneId = GetNearestZone(%clientId, %w2, 3);
	if(%zoneId != False)
	{
		Schedule::Add("DoCastSpell(" @ %clientId @ ", " @ %index @ ", \"" @ %oldpos @ "\", \"" @ %castObj @ "\", \"" @ %w2 @ "\");", $Spell::delay[%index], "spell"@%clientId);
	}
	else
	{
		disableOverrides(%clientId);
		%clientId.overrideKeybinds = 2;
		%clientId.keyOverride = "casting::teleportmenu_input";
		%clientId.tpmenutype = "";
		%clientId.castingmenuindex = %index;
		casting::teleportmenu(%clientid);
	}
}

function casting::teleportmenu(%clientId){
	%msg = "<jc>Teleport to nearest:";
	%msg = %msg @ "\n\n<f2>1:<f0> Town\n<f2>2:<f0> Dungeon";
	%msg = %msg @ "\n\n<f1>0:<f0> Cancel";
	rpg::longPrint(%clientId,%msg,1,0.6);
	schedule::add("casting::teleportmenu("@%clientId@");",0.3,"transportmenu"@%clientId, %clientId);//should override other transport menu so you don't get both
}

function casting::teleportmenu_input(%clientId, %key){
	%index = floor(%clientId.castingmenuindex);
	if(%key == 0){
		disableOverrides(%clientId);
		return;
	}
	else{
		if(%key == 1){
			%clientId.tpmenutype = "town";
			%chosen = True;
		}
		else if(%key == 2){
			%clientId.tpmenutype = "dungeon";
			%chosen = True;
		}
		if(%chosen){
			Schedule::Add("DoCastSpell(" @ %clientId @ ", " @ %index @ ", \"" @ GameBase::getPosition(%clientId) @ "\", 0, \"" @ %clientId.tpmenutype @ "\");", $Spell::delay[%index], "spell"@%clientId);
			%clientId.overrideKeybinds = 1;
			disableOverrides(%clientId);
			%chosen = True;
		}
	}
	if(!%chosen)
		client::sendmessage(%clientId, $msgRed,"That isn't on the menu.");
}