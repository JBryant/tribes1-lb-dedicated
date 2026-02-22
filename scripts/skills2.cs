// -------------- New Skill Systems
$Skill::keyword[1] = "mend";
$Skill::index[mend] = 1;
$Skill::name[1] = "Mend Self or Other";
$Skill::description[1] = "Mends the user or someone in the LOS, slightly restoring some health.";
$Skill::actionMessage[1] = "You begin mending wounds.";
$Skill::delay[1] = 3;
$Skill::recoveryTime[1] = 10;
$Skill::damageValue[1] = -10;
$Skill::LOSrange[1] = 80;
$Skill::startSound[1] = AmbientScurry;
$Skill::endSound[1] = MedicSpell;
$Skill::groupListCheck[1] = False;
$Skill::refVal[1] = -10;
$Skill::graceDistance[1] = 2;
$Skill::requireOneOfItems[1] = "HealingKitI HealingKitII HealingKitIII HealingKitIV HealingKitV";
$Skill::removeRequiredItem[1] = True;

$Skill::keyword[2] = "cleave";
$Skill::index[cleave] = 2;
$Skill::name[2] = "Cleave";
$Skill::description[2] = "A mighty swing that deals damage to up to two targets around you.";
$Skill::actionMessage[2] = "You swing a mighty cleave.";
$Skill::delay[2] = 0.1;
$Skill::recoveryTime[2] = 5;
$Skill::weaponSpeedBasedRecoveryTime[2] = True;
// $Skill::damageValue[2] = 10;
$Skill::radius[2] = 10;
$Skill::LOSrange[2] = 0;
$Skill::startSound[2] = AmrbroseSwordA;
// $Skill::endSound[2] = AmrbroseSwordA;
$Skill::groupListCheck[2] = False;
$Skill::refVal[2] = -10;
$Skill::graceDistance[2] = 2;
$SkillRestriction[$Skill::keyword[2]] = "L 20 C Squire C Knight C Monk C Geomancer C Samurai C HolyKnight C DarkKnight C Spellblade";

$Skill::keyword[3] = "harvest";
$Skill::index[harvest] = 3;
$Skill::name[3] = "Harvest";
$Skill::description[3] = "Attempts to gather resources from the environment.";
$Skill::actionMessage[3] = "You begin harvesting.";
$Skill::delay[3] = 3;
$Skill::recoveryTime[3] = 1;
$Skill::startSound[3] = AmbientScurry;
$Skill::groupListCheck[3] = False;
$Skill::refVal[3] = -10;
$Skill::graceDistance[3] = 0.5;

$Skill::keyword[4] = "alchemy";
$Skill::index[alchemy] = 4;
$Skill::name[4] = "Alchemy";
$Skill::description[4] = "Alchemy allows you to attempt to create potions from gathered resources.";
$Skill::actionMessage[4] = "You begin brewing.";
$Skill::delay[4] = 4;
$Skill::recoveryTime[4] = 2;
$Skill::startSound[4] = FishWalk;
$Skill::groupListCheck[4] = False;
$Skill::refVal[4] = -10;
$Skill::graceDistance[4] = 0.5;
$Skill::requireOneOfItems[4] = "CrudeClayAlembic WornCopperAlembic ReinforcedIronAlembic ArcaneGlassAlembic CelestialMythrilAlembic";
$SkillRestriction[$Skill::keyword[4]] = "C Chemist C BlackMage C WhiteMage C Mystic C Summoner C TimeMage C WhiteMage C Mystic C Orator C HolyKnight";

$Skill::keyword[5] = "throw";
$Skill::index[$Skill::keyword[5]] = 5;
$Skill::name[5] = "Throw";
$Skill::description[5] = "Allows you to throw an item at a target.";
$Skill::delay[5] = 0.1;
$Skill::recoveryTime[5] = 2;
$Skill::startSound[5] = FishWalk;
$Skill::groupListCheck[5] = False;
$Skill::refVal[5] = -10;
$Skill::graceDistance[5] = 10;
$SkillRestriction[$Skill::keyword[5]] = "C Chemist C BlackMage C WhiteMage C Mystic C TimeMage C WhiteMage C Mystic C Summoner C Orator C HolyKnight";

$Skill::keyword[6] = "quickshot";
$Skill::index[$Skill::keyword[6]] = 6;
$Skill::name[6] = "Quick Shot";
$Skill::description[6] = "A fast shot that shoots multiple arrows.";
$Skill::delay[6] = 0.1;
$Skill::recoveryTime[6] = 5;
$Skill::startSound[6] = Reflected;
$Skill::groupListCheck[6] = False;
$Skill::refVal[6] = -10;
$Skill::graceDistance[6] = 10;
$SkillRestriction[$Skill::keyword[6]] = "L 40 C Archer C Hunter C Sniper";

$Skill::keyword[7] = "explosiveshot";
$Skill::index[$Skill::keyword[7]] = 7;
$Skill::name[7] = "Explosive Shot";
$Skill::description[7] = "A shot that explodes on impact.";
$Skill::delay[7] = 0.1;
$Skill::recoveryTime[7] = 5;
$Skill::startSound[7] = ActivateAB;
$Skill::groupListCheck[7] = False;
$Skill::refVal[7] = -10;
$Skill::graceDistance[7] = 10;
$SkillRestriction[$Skill::keyword[7]] = "L 20 C Archer C Hunter C Sniper";

$Skill::keyword[8] = "greatcleave";
$Skill::index[greatcleave] = 8;
$Skill::name[8] = "Great Cleave";
$Skill::description[8] = "A powerful swing that explodes on impact, dealing damage to all targets around you.";
$Skill::actionMessage[8] = "You swing a great cleave.";
$Skill::delay[8] = 0.1;
$Skill::recoveryTime[8] = 8; // 5 original
$Skill::weaponSpeedBasedRecoveryTime[8] = True;
// $Skill::damageValue[8] = 10;
$Skill::radius[8] = 12;
$Skill::LOSrange[8] = 0;
$Skill::startSound[8] = AmrbroseSwordA;
// $Skill::endSound[8] = AmrbroseSwordA;
$Skill::groupListCheck[8] = False;
$Skill::refVal[8] = -10;
$Skill::graceDistance[8] = 2;
$SkillRestriction[$Skill::keyword[8]] = "L 40 C Knight C Monk C Geomancer C Samurai C HolyKnight C Spellblade";

$Skill::keyword[9] = "parry";
$Skill::index[parry] = 9;
$Skill::name[9] = "Parry";
$Skill::description[9] = "A defensive maneuver that reduces damage from incoming attacks.";
$Skill::actionMessage[9] = "You prepare to parry.";
$Skill::delay[9] = 0.1;
$Skill::recoveryTime[9] = 10; // 5 original
$Skill::duration[9] = 6;
$Skill::LOSrange[9] = 0;
$Skill::startSound[9] = AmrbroseSwordA;
// $Skill::endSound[9] = AmrbroseSwordA;
$Skill::groupListCheck[9] = False;
$Skill::refVal[9] = -10;
$Skill::graceDistance[9] = 2;
$SkillRestriction[$Skill::keyword[9]] = "C Knight C Monk C Geomancer C Samurai C HolyKnight C DarkKnight C Spellblade";

$Skill::keyword[10] = "infusepotions";
$Skill::index[infusepotions] = 10;
$Skill::name[10] = "Infuse Potions";
$Skill::description[10] = "Infuse your potions with additional effects.";
$Skill::actionMessage[10] = "You begin to infuse your potions.";
$Skill::delay[10] = 2;
$Skill::recoveryTime[10] = 2;
$Skill::duration[10] = 30;
$Skill::LOSrange[10] = 0;
$Skill::startSound[10] = ActivateTR;
$Skill::groupListCheck[10] = False;
$Skill::refVal[10] = -10;
$Skill::graceDistance[10] = 1;
$SkillRestriction[$Skill::keyword[10]] = "C Chemist";

$Skill::keyword[11] = "whirlwind";
$Skill::index[whirlwind] = 11;
$Skill::name[11] = "Whirlwind";
$Skill::description[11] = "A spinning attack that hits all nearby enemies multiple times.";
$Skill::actionMessage[11] = "You spin around in a whirlwind of attacks.";
$Skill::delay[11] = 0.1;
$Skill::recoveryTime[11] = 15;
$Skill::radius[11] = 12;
$Skill::LOSrange[11] = 0;
$Skill::startSound[11] = AmrbroseSwordA;
$Skill::groupListCheck[11] = False;
$Skill::refVal[11] = -10;
$Skill::graceDistance[11] = 2;
$SkillRestriction[$Skill::keyword[11]] = "L 60 C Monk C Geomancer C Samurai C HolyKnight C Spellblade";

$Skill::keyword[12] = "earthquake";
$Skill::index[earthquake] = 12;
$Skill::name[12] = "Earthquake";
$Skill::description[12] = "A powerful attack that shakes the ground, dealing damage to all enemies in the area.";
$Skill::actionMessage[12] = "You unleash a devastating earthquake.";
$Skill::delay[12] = 0.1;
$Skill::recoveryTime[12] = 15;
$Skill::radius[12] = 12;
$Skill::LOSrange[12] = 0;
$Skill::startSound[12] = AmrbroseSwordA;
$Skill::groupListCheck[12] = False;
$Skill::refVal[12] = -10;
$Skill::graceDistance[12] = 2;
$SkillRestriction[$Skill::keyword[12]] = "L 80 C Geomancer C Samurai C HolyKnight C Spellblade";

$Skill::keyword[13] = "volley";
$Skill::index[volley] = 13;
$Skill::name[13] = "Volley";
$Skill::description[13] = "A rapid-fire attack that launches a hail of arrows at once from the sky.";
$Skill::actionMessage[13] = "You unleash a volley of arrows.";
$Skill::delay[13] = 1;
$Skill::recoveryTime[13] = 8; // 15;
$Skill::radius[13] = 20;
$Skill::LOSrange[13] = 100;
$Skill::startSound[13] = ImpactTR;
$Skill::groupListCheck[13] = False;
$Skill::refVal[13] = -10;
$Skill::graceDistance[13] = 2;
$SkillRestriction[$Skill::keyword[13]] = "L 80 C Archer C Hunter C Sniper";

$Skill::keyword[14] = "innerfire";
$Skill::index[innerfire] = 14;
$Skill::name[14] = "Inner Fire";
$Skill::description[14] = "Ignite your inner power, increasing spell damage.";
$Skill::actionMessage[14] = "You channel your inner fire.";
$Skill::delay[14] = 2;
$Skill::recoveryTime[14] = 2;
$Skill::duration[14] = 30;
$Skill::LOSrange[14] = 0;
$Skill::startSound[14] = ActivateTR;
$Skill::endSound[14] = PlaceSeal;
$Skill::groupListCheck[14] = False;
$Skill::refVal[14] = -10;
$Skill::graceDistance[14] = 1;
$SkillRestriction[$Skill::keyword[14]] = "C WhiteMage C Mystic C Orator C HolyKnight";

$Skill::keyword[15] = "arrowburst";
$Skill::index[$Skill::keyword[15]] = 15;
$Skill::name[15] = "Arrow Burst";
$Skill::description[15] = "A powerful shot that releases a burst of arrows.";
$Skill::delay[15] = 0.1;
$Skill::recoveryTime[15] = 5;
$Skill::startSound[15] = Reflected;
$Skill::groupListCheck[15] = False;
$Skill::refVal[15] = -10;
$Skill::graceDistance[15] = 10;
$SkillRestriction[$Skill::keyword[15]] = "L 40 C Hunter C Sniper";

$Skill::keyword[16] = "doubleshot";
$Skill::index[$Skill::keyword[16]] = 16;
$Skill::name[16] = "Double Shot";
$Skill::description[16] = "Fire two arrows at once for a short durtation.";
$Skill::delay[16] = 0.1;
$Skill::recoveryTime[16] = 2;
$Skill::duration[16] = 30;
$Skill::startSound[16] = Reflected;
$Skill::groupListCheck[16] = False;
$Skill::refVal[16] = -10;
$Skill::graceDistance[16] = 10;
$SkillRestriction[$Skill::keyword[16]] = "L 60 C Archer C Hunter C Sniper";

$Skill::keyword[17] = "zangetsu";
$Skill::index[$Skill::keyword[17]] = 17;
$Skill::name[17] = "Zangetsu";
$Skill::description[17] = "A powerful technique that allows you to strike with the force of the moon.";
$Skill::delay[17] = 0.1;
$Skill::recoveryTime[17] = 10;
$Skill::duration[17] = 30;
$Skill::startSound[17] = AmrbroseSwordA;
$Skill::groupListCheck[17] = False;
$Skill::refVal[17] = -10;
$Skill::graceDistance[17] = 10;
$SkillRestriction[$Skill::keyword[17]] = "L 100 C Samurai C HolyKnight C Spellblade";

$Skill::keyword[18] = "doublecast";
$Skill::index[$Skill::keyword[18]] = 18;
$Skill::name[18] = "Double Cast";
$Skill::description[18] = "A powerful incantation that doubles the damage of your spells at the cost of twice the mana.";
$Skill::delay[18] = 2.0;
$Skill::recoveryTime[18] = 10;
$Skill::duration[18] = 60;
$Skill::startSound[18] = Reflected;
$Skill::groupListCheck[18] = False;
$Skill::refVal[18] = -10;
$Skill::graceDistance[18] = 1;
$SkillRestriction[$Skill::keyword[18]] = "C BlackMage C TimeMage C Summoner C Spellbow C Spellblade C DarkKnight C ArcaneArcher C Arcanist C Hexblade";

$Skill::keyword[19] = "sneak";
$Skill::index[$Skill::keyword[19]] = 19;
$Skill::name[19] = "Sneak";
$Skill::description[19] = "A stealthy maneuver that allows you to move undetected.";
$Skill::delay[19] = 1.0;
$Skill::recoveryTime[19] = 10;
$Skill::duration[19] = 20;
$Skill::startSound[19] = Portal6;
$Skill::groupListCheck[19] = False;
$Skill::refVal[19] = -10;
$Skill::graceDistance[19] = 1;
$SkillRestriction[$Skill::keyword[19]] = "C Thief";

$Skill::keyword[20] = "rage";
$Skill::index[$Skill::keyword[20]] = 20;
$Skill::name[20] = "Rage";
$Skill::description[20] = "Enter a fury that doubles your damage but makes you take 25% more damage.";
$Skill::delay[20] = 1.0;
$Skill::recoveryTime[20] = 10;
$Skill::duration[20] = 30;
$Skill::startSound[20] = Reflected;
$Skill::groupListCheck[20] = False;
$Skill::refVal[20] = -10;
$Skill::graceDistance[20] = 1;
$SkillRestriction[$Skill::keyword[20]] = "L 50 C Knight C Monk C Geomancer C Samurai C HolyKnight C DarkKnight C Spellblade";

$Skill::keyword[21] = "berserk";
$Skill::index[$Skill::keyword[21]] = 21;
$Skill::name[21] = "Berserk";
$Skill::description[21] = "Unleash a berserker's wrath to deal triple damage but take 35% more damage.";
$Skill::delay[21] = 1.0;
$Skill::recoveryTime[21] = 10;
$Skill::duration[21] = 30;
$Skill::startSound[21] = Reflected;
$Skill::groupListCheck[21] = False;
$Skill::refVal[21] = -10;
$Skill::graceDistance[21] = 1;
$SkillRestriction[$Skill::keyword[21]] = "L 100 C Knight C Monk C Geomancer C Samurai C HolyKnight C DarkKnight C Spellblade";

$Skill::keyword[22] = "nirvana";
$Skill::index[$Skill::keyword[22]] = 22;
$Skill::name[22] = "Nirvana";
$Skill::description[22] = "Enter a transcendent state to deal quadruple damage but take 45% more damage.";
$Skill::delay[22] = 1.0;
$Skill::recoveryTime[22] = 10;
$Skill::duration[22] = 30;
$Skill::startSound[22] = Reflected;
$Skill::groupListCheck[22] = False;
$Skill::refVal[22] = -10;
$Skill::graceDistance[22] = 1;
$SkillRestriction[$Skill::keyword[22]] = "L 250 C Knight C Monk C Geomancer C Samurai C HolyKnight C DarkKnight C Spellblade";

function BeginUseSkill(%clientId, %keyword) {
	dbecho($dbechoMode, "BeginUseSkill(" @ %clientId @ ", " @ %keyword @ ")");

	%skillName = GetWord(%keyword, 0);
	%rest = String::getSubStr(%keyword, String::len(%skillName) + 1, 99999);
	%skillIndex = $Skill::index[%skillName];

	if (%skillIndex == "") {
		Client::sendMessage(%clientId, $MsgRed, "Invalid skill.");
		return False;
	}

    // check if the player can use the skill
    if(SkillCanUse(%clientId, $Skill::keyword[%skillIndex]) == False) {
        Client::sendMessage(%clientId, $MsgRed, "You cannot use that skill.");
        return False;
    }

	// check if the skill requires any special items (In future does this belong to SkillCanUse?)
	%requiredItems = $Skill::requiredItems[%skillIndex];

	if (%requiredItems != "") {
		%missingItems = False;
		for(%idx = 0; GetWord(%requiredItems, %idx) != -1; %idx += 2) {
			%checkItem = GetWord(%requiredItems, %idx);
			%amnt = GetWord(%requiredItems, %idx + 1);
			
			if (Belt::HasThisStuff(%clientId, %checkItem) < %amnt) {
				%missingItems = True;
				break;
			}
		}

		if (%missingItems) {
			Client::sendMessage(%clientId, $MsgRed, "You do not have the required items to use "@ %keyword @".");
			return False;
		}
	}

	// check if you just need one ofany items
	// check if the skill requires any special items (In future does this belong to SkillCanUse?)
	%requireOneOfItems = $Skill::requireOneOfItems[%skillIndex];

	if (%requireOneOfItems != "") {
		%hasItem = False;
		for(%idx = 0; GetWord(%requireOneOfItems, %idx) != -1; %idx += 1) {
			%checkItem = GetWord(%requireOneOfItems, %idx);
			%amnt = Belt::HasThisStuff(%clientId, %checkItem);
			
			if (%amnt > 0) {
				%hasItem = True;
				break;
			}
		}

		if (%hasItem == False) {
			Client::sendMessage(%clientId, $MsgRed, "You do not have the required items to use "@ %keyword @".");
			return False;
		}
	}
	
    %player = Client::getOwnedObject(%clientId);

    if(GameBase::getLOSinfo(%player, $Skill::LOSrange[%skillIndex])) {
        // %lospos = $los::position;
        %losobj = $los::object;
    } else {
        //%lospos = "";
        %losobj = 0;
    }

    storeData(%clientId, "UseSkillStep", 1);

    if($Skill::startSound[%skillIndex] != "")
        playSound($Skill::startSound[%skillIndex], GameBase::getPosition(%clientId));

    // %skt = $SkillType[$Spell::keyword[%i]];
    // %sk1 = $PlayerSkill[%clientId, %skt];
    // %gsa = GetSkillAmount($Spell::keyword[%i], %skt);
    // %sk2 = %sk1 - %gsa;
    // %sk = Cap(%sk2, 0, "inf");

	if ($Skill::weaponSpeedBasedRecoveryTime[%skillIndex] == True) {
		%equippedWeapon = GetEquippedWeapon(%clientId);
		%weaponImage = $beltitem[%equippedWeapon, "Image"];
		
		if (%equippedWeapon) {
			%rt = $Skill::recoveryTime[%skillIndex] * %weaponImage.imageType.fireTime;
		} else {
			%rt = $Skill::recoveryTime[%skillIndex];
		}
	} else {
		%rt = $Skill::recoveryTime[%skillIndex];
	}

    %a = %rt / 2;
    %b = (1000 - %sk) / 1000;
    %c = %b * %a;

    // recovery time is never smaller than half of the original and never bigger than the original.
    %recovTime = Cap(%a + %c, %a, %rt);

	if (HasBonusState(%clientId, "Haste") == True) {
		%recovTime = floor(%recovTime * 0.5);
	}

    storeData(%clientId, "SkillRecovTime", %recovTime);

	// send action message if it exists
	if ($Skill::actionMessage[%skillIndex] != "") {
		Client::sendMessage(%clientId, $MsgBeige, $Skill::actionMessage[%skillIndex]);
	}

    if($Skill::menu[%skillIndex]) {
        eval("useskill::"@$Skill::keyword[%skillIndex]@"(" @ %clientId @ ", " @ %skillIndex @ ", \"" @ GameBase::getPosition(%clientId) @ "\", \"" @ %losobj @ "\", \"" @ %rest @ "\");");
    } else if($Skill::delay[%skillIndex] > 0) {
        if($Skill::Indicator[%skillIndex]) {
            spellIndicatorLoop(%clientId, $Skill::LOSrange[%skillIndex]);
        }

        Schedule::Add("DoUseSkill(" @ %clientId @ ", " @ %skillIndex @ ", \"" @ GameBase::getPosition(%clientId) @ "\", \"" @ %losobj @ "\", \"" @ %rest @ "\");", $Skill::delay[%skillIndex], "skill"@%clientId);
    } else {
        DoUseSkill(%clientId, %skillIndex, GameBase::getPosition(%clientId), %losobj, %rest);
    }
   
    return True;
}

function DoUseSkill(%clientId, %index, %oldpos, %castObj, %rest) {
	dbecho($dbechoMode, "DoUseSkill(" @ %clientId @ ", " @ %index @ ", " @ %oldpos @ ", " @ %castPos @ ", " @ %castObj @ ", " @ %rest @ ")");

	%player = Client::getOwnedObject(%clientId);

	if($Skill::graceDistance[%index] == "")
		$Skill::graceDistance[%index] = 0.25;

	$los::position = "";

	if(GameBase::getLOSinfo(%player, $Skill::LOSrange[%index])) {
		%castPos = $los::position;

		if(%castObj < 1)
			%castObj = $los::object;
	}

	if(Vector::getDistance(%oldpos, GameBase::getPosition(%clientId)) > $Skill::graceDistance[%index]) {
		Client::sendMessage(%clientId, $MsgBeige, "Your skill was interrupted.");
		//storeData(%clientId, "UseSkillStep", 2);

		%returnflag = False;
		return EndSkill(%clientid, %overrideEndSound, %extradelay, %index, %oldpos, %returnflag);
	}

	// check to see if they still have the items to avoid dropping items while waiting for cast time
	%requiredItems = $Skill::requiredItems[%index];
	if (%requiredItems != "") {
		%missingItems = False;
		for(%idx = 0; GetWord(%requiredItems, %idx) != -1; %idx += 2) {
			%checkItem = GetWord(%requiredItems, %idx);
			%amnt = GetWord(%requiredItems, %idx + 1);
			
			if (Belt::HasThisStuff(%clientId, %checkItem) < %amnt) {
				%missingItems = True;
				break;
			}
		}

		if (%missingItems) {
			Client::sendMessage(%clientId, $MsgRed, "You do not have the required items to use "@%keyword@".");
			%returnFlag = True;
			return EndSkill(%clientid, %overrideEndSound, %extradelay, %index, %oldpos, %returnflag);
		}
	}

	// remove any required items
	%removeItems = $Skill::removeItems[%index];
	if (%removeItems != "") {
		for(%idx = 0; GetWord(%removeItems, %idx) != -1; %idx += 2) {
			%removeItem = GetWord(%removeItems, %idx);
			%amnt = GetWord(%removeItems, %idx + 1);
			%has = Belt::HasThisStuff(%clientId, %removeItem);
			belt::takethisstuff(%clientId, %removeItem, %amnt);
			Client::sendMessage(%clientId, $MsgWhite, "You used "@ %amnt @" "@ $beltitem[%removeItem, "Name"] @". [have "@ (%has - %amnt) @"]");
		}
	}

	%duration = $Skill::duration[%index] / 2;

    // ************************************************************************************
    // Skill Code
    // ************************************************************************************

    // mend
    if ($Skill::keyword[%index] == "mend") {
		if(getObjectType(%castObj) == "Player" && !Player::isAiControlled(%castObj))
			%id = Player::getClient(%castObj);
		else
			%id = %clientId;

		if(%clientId != %id)
			Client::sendMessage(%id, $MsgBeige, Client::getName(%clientId) @ " is mending on you.");

		%requireOneOfItems = $Skill::requireOneOfItems[%index];

		if (%requireOneOfItems != "") {
			%useItem = "";

			for(%idx = 0; GetWord(%requireOneOfItems, %idx) != -1; %idx += 1) {
				%checkItem = GetWord(%requireOneOfItems, %idx);
				%amnt = Belt::HasThisStuff(%clientId, %checkItem);
				
				if (%amnt > 0) {
					%useItem = %checkItem;
				}
			}

			if (%useItem != "") {
				if ($Skill::removeRequiredItem[%index] == True) {
					// remove the item
					belt::takethisstuff(%clientId, %useItem, 1);
					Client::sendMessage(%clientId, $MsgWhite, "You used a "@ $beltitem[%useItem, "Name"] @". [have "@ (Belt::HasThisStuff(%clientId, %useItem) - 1) @"]");

					%restoreValue = 0 - $restoreValue[%useItem, HP];
					%r = %restoreValue / $TribesDamageToNumericDamage;
					refreshHP(%id, %r);
					%castPos = GameBase::getPosition(%id);
					
					refreshAll(%clientId);
				}
			} else {
				Client::sendMessage(%clientId, $MsgRed, "You do not have the required items to use "@ %keyword @".");
				return False;
			}
		}	

		%returnFlag = True;
    }

    if ($Skill::keyword[%index] == "cleave") {
		%multi = 1.0;
		PhysicalRadiusDamage(%clientId, GameBase::getPosition(%clientId), $Skill::radius[%index] * 2, $Skill::name[%index], %multi, %index);
		%returnFlag = True;
    }

	if ($Skill::keyword[%index] == "greatcleave") {
		// do an explosion around the use
		%playerPos = GameBase::getPosition(%clientId);

		CreateAndDetBomb(%clientId, "Bomb5", %playerPos, False);
		playSound(ExplodeLM, %playerPos);
		%multi = 1.5;
		PhysicalRadiusDamage(%clientId, %playerPos, $Skill::radius[%index] * 2, $Skill::name[%index], %multi, %index);
		%returnFlag = True;
    }

	if ($Skill::keyword[%index] == "whirlwind") {
		// do an explosion around the use
		%playerPos = GameBase::getPosition(%clientId);

		CreateAndDetBomb(%clientId, "Bomb5", %playerPos, False);
		playSound(ExplodeLM, %playerPos);
		%multi = 1.5;
		PhysicalRadiusDamage(%clientId, %playerPos, $Skill::radius[%index] * 2, $Skill::name[%index], %multi, %index);

		// schedule("CreateAndDetBomb(" @ %clientId @ ", \"Bomb5\", \"" @ %playerPos @ "\", False);", 0.5);
		// schedule("playSound(ExplodeLM, " @ %playerPos @ ");", 0.5);
		schedule("PhysicalRadiusDamage(" @ %clientId @ ", \"" @ %playerPos @ "\", \"" @ ($Skill::radius[%index] * 2) @ "\", \"" @ $Skill::name[%index] @ "\", 1.5, " @ %index @ ");", 0.75);

		%returnFlag = True;
    }

	if ($Skill::keyword[%index] == "earthquake") {
		// do an explosion around the use
		%playerPos = GameBase::getPosition(%clientId);
		%multi = 1.5;

		CreateAndDetBomb(%clientId, "Bomb5", %playerPos, False);
		playSound(ExplodeLM, %playerPos);
		PhysicalRadiusDamage(%clientId, %playerPos, $Skill::radius[%index] * 2, $Skill::name[%index], %multi, %index);

		schedule("CreateAndDetBomb(\"" @ %clientId @ "\", \"Bomb5\", \"" @ %playerPos @ "\", False);", 0.8);
		schedule("playSound(ExplodeLM, \"" @ %playerPos @ "\");", 0.8);
		schedule("PhysicalRadiusDamage(" @ %clientId @ ", \"" @ %playerPos @ "\", \"" @ ($Skill::radius[%index] * 2) @ "\", \"" @ $Skill::name[%index] @ "\", 1.5, " @ %index @ ");", 0.8);

		schedule("CreateAndDetBomb(\"" @ %clientId @ "\", \"Bomb5\", \"" @ %playerPos @ "\", False);", 1.6);
		schedule("playSound(ExplodeLM, \"" @ %playerPos @ "\");", 1.6);
		schedule("PhysicalRadiusDamage(" @ %clientId @ ", \"" @ %playerPos @ "\", \"" @ ($Skill::radius[%index] * 2) @ "\", \"" @ $Skill::name[%index] @ "\", 1.5, " @ %index @ ");", 1.6);


		%returnFlag = True;
    }

	if ($Skill::keyword[%index] == "harvest") {
		%set = newObject("set", SimSet);
		%losRange = $Skill::LOSrange[%index] || 4;
	    %num = containerBoxFillSet(%set, $StaticObjectType, GameBase::getPosition(%clientId), 4, 4, 4, 0);

		Group::iterateRecursive(%set, FindHarvestableObjects, %clientId, %index, %rest);
		deleteObject(%set);

		%overrideEndSound = True;
		%returnFlag = True;
	}

	if ($Skill::keyword[%index] == "alchemy") {
		%item = GetWord(%rest, 0);

		if (GetWord(%rest, 1) != -1)
			%itemAmnt = GetWord(%rest, 1);
		else
			%itemAmnt = "1";

		%alchemyIngredients = $AccessoryVar[%item, "AlchemyIngredients"];

		if (%alchemyIngredients != "") {
			// check if they have the ingredients to make a potion
			%missingItems = False;
			for(%idx = 0; GetWord(%alchemyIngredients, %idx) != -1; %idx += 2) {
				%checkItem = GetWord(%alchemyIngredients, %idx);
				%amnt = GetWord(%alchemyIngredients, %idx + 1) * %itemAmnt;
				if (Belt::HasThisStuff(%clientId, %checkItem) < %amnt) {
					%missingItems = True;
					break;
				}
			}

			if (%missingItems) {
				// missing some ingredients
				Client::sendMessage(%clientId, $MsgRed, "You do not have the required ingredients to make a "@ %item @".");
				%overrideEndSound = True;
				%returnFlag = True;
			} else {
				// remove used ingredients				
				for(%idx = 0; GetWord(%alchemyIngredients, %idx) != -1; %idx += 2) {
					%removeItem = GetWord(%alchemyIngredients, %idx);
					%amnt = GetWord(%alchemyIngredients, %idx + 1) * %itemAmnt;
					%has = Belt::HasThisStuff(%clientId, %removeItem);

					Belt::TakeThisStuff(%clientId, %removeItem, %amnt);
					Client::sendMessage(%clientId, $MsgWhite, "You used "@ %amnt @" "@ $beltitem[%removeItem, "Name"] @". [have "@ (%has - %amnt) @"]");
				}

				%multi = floor($PlayerSkill[%clientId, $SkillAlchemy] / 100) + 1;
				// lbecho(%itemAmnt);
				// lbecho(%multi);
				%totalAmount = %itemAmnt * %multi;

				// give the item
				Belt::GiveThisStuff(%clientId, %item, %totalAmount);
				Client::sendMessage(%clientId, $MsgWhite, "You made "@ %totalAmount @" " @ $beltitem[%item, "Name"] @ ".");
			}
		} else {
			Client::sendMessage(%clientId, $MsgRed, "There is no alchemical recipe to make " @ %item @ ".");
			%overrideEndSound = True;
			%returnFlag = True;
		}
	}

	if ($Skill::keyword[%index] == "throw") {
		%item = %rest;

		if(%item == "")
			Client::sendMessage(%clientId, $MsgRed, "Please specify an item (ex: Black Statue = BlackStatue).");
		else
			%thrownItem = ThrowItem(%clientId, %item, 25);

		%overrideEndSound = True;
		%returnFlag = True;
	}

	if ($Skill::keyword[%index] == "quickshot") {
		schedule("ProjectileAttack(" @ %clientId @ ", 100, True);", 0.01); // 0.01
		schedule("ProjectileAttack(" @ %clientId @ ", 100, True);", 0.25); // 0.25
		schedule("ProjectileAttack(" @ %clientId @ ", 100, True);", 0.5); // 0.5
    }

	if ($Skill::keyword[%index] == "arrowburst") {
		schedule("ProjectileAttack(" @ %clientId @ ", 100, True);", 0.01);
		schedule("ProjectileAttack(" @ %clientId @ ", 100, True);", 0.25);
		schedule("ProjectileAttack(" @ %clientId @ ", 100, True);", 0.5);
		schedule("ProjectileAttack(" @ %clientId @ ", 100, True);", 0.75);
		schedule("ProjectileAttack(" @ %clientId @ ", 100, True);", 1.0);	
    }

	if ($Skill::keyword[%index] == "explosiveshot") {
		ProjectileAttack(%clientId, 100, True, "43", "BasicArrowRadiusSmall");
    }

	if ($Skill::keyword[%index] == "parry") {
		remoteEval(%clientId, "rpgbarhud", %duration * 2, 3, 2, "||", "", "Parry", "left");
		UpdateBonusState(%clientId, "Parry", %duration, "Parry");
    }

	if ($Skill::keyword[%index] == "infusepotions") {
		remoteEval(%clientId, "rpgbarhud", %duration * 2, 3, 2, "||", "", "Infused Potions", "left");
		UpdateBonusState(%clientId, "InfusedPotions", %duration, "InfusedPotions");
	}

	if ($Skill::keyword[%index] == "innerfire") {
		remoteEval(%clientId, "rpgbarhud", %duration * 2, 3, 2, "||", "", "Inner Fire", "left");
		UpdateBonusState(%clientId, "InnerFire", %duration, "InnerFire");
	}

	if ($Skill::keyword[%index] == "doublecast") {
		remoteEval(%clientId, "rpgbarhud", %duration * 2, 3, 2, "||", "", "Double Cast", "left");
		UpdateBonusState(%clientId, "DoubleCast", %duration, "DoubleCast");
	}

	if ($Skill::keyword[%index] == "rage") {
		remoteEval(%clientId, "rpgbarhud", %duration * 2, 3, 2, "||", "", "Rage", "left");
		UpdateBonusState(%clientId, "Rage", %duration, "Rage");
	}
	if ($Skill::keyword[%index] == "berserk") {
		remoteEval(%clientId, "rpgbarhud", %duration * 2, 3, 2, "||", "", "Berserk", "left");
		UpdateBonusState(%clientId, "Berserk", %duration, "Berserk");
	}
	if ($Skill::keyword[%index] == "nirvana") {
		remoteEval(%clientId, "rpgbarhud", %duration * 2, 3, 2, "||", "", "Nirvana", "left");
		UpdateBonusState(%clientId, "Nirvana", %duration, "Nirvana");
	}


	if ($Skill::keyword[%index] == "volley") {
		%weapon = GetEquippedWeapon(%clientId);
		%loadedProjectile = fetchData(%clientId, "LoadedProjectile " @ %weapon);
		%projectile = BeltItem::GetProjectile(%loadedProjectile);

		%volleyPos = GetWord(%castPos, 0) @ " " @ GetWord(%castPos, 1) @ " " @ GetWord(%castPos, 2) + 6;

		for (%i = 0; %i < 10; %i++) {
			// slightly modify %volleyPos x and y cordinates randomly +/- 2
			%newPos = GetWord(%volleyPos, 0) + (getRandom() * 4 - 2) @ " " @ (GetWord(%volleyPos, 1) + (getRandom() * 4 - 2)) @ " " @ GetWord(%volleyPos, 2);
			schedule("CreateAndDetBomb(\"" @ %clientId @ "\", \"Bomb12\", \"" @ %newPos @ "\", False);", 0.28 * %i);
			schedule("shootAtClosestEnemyFromPosition(" @ %clientId @ ", \"" @ %newPos @ "\", " @ $Skill::radius[$Skill::index[volley]] @ ", \"" @ %projectile @ "\");", 0.3 * %i);
		}
	}

	if ($Skill::keyword[%index] == "doubleshot") {
		remoteEval(%clientId, "rpgbarhud", %duration * 2, 3, 2, "||", "", "Double Shot", "left");
		UpdateBonusState(%clientId, "DoubleShot", %duration, "DoubleShot");
	}

	if ($Skill::keyword[%index] == "zangetsu") {
		if(!Player::isAiControlled(%Client))
		Player::unmountItem(%player, $WeaponSlot);

		schedule("shootProjectile(" @ %clientId @ ", WindCutter);", 0.01);
		schedule("shootProjectile(" @ %clientId @ ", WindCutter);", 0.25);
		schedule("shootProjectile(" @ %clientId @ ", WindCutter);", 0.5);
		schedule("shootProjectile(" @ %clientId @ ", WindCutter);", 0.75);

		%weaponImage = $beltitem[GetEquippedWeapon(%clientId), "Image"];
		schedule("Player::mountItem(" @ %clientId @ ", \"" @ %weaponImage @ "\", 0);", 0.8, %player);
    }

	if ($Skill::keyword[%index] == "sneak") {
		remoteEval(%clientId, "rpgbarhud", %duration * 2, 3, 2, "||", "", "Sneak", "left");
		UpdateBonusState(%clientId, "Sneak", %duration, "Sneak");
		// make invisible
		GameBase::startFadeOut(%clientId);
		storeData(%clientId, "invisible", True);

		Client::sendMessage(%clientId, $MsgBeige, "You successfully slip into the shadows.");
    }

    return EndSkill(%clientId, %overrideEndSound, %extraDelay, %index, %oldpos, %returnFlag);
}

function shootProjectile(%Client, %projectile) {
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Projectile::spawnProjectile(%projectile, %trans, %player, %vel);
}

function shootAtRandomEnemyFromPosition(%clientId, %pos, %radius, %projectile) {
	%player = Client::getOwnedObject(%clientId);
	%randomEnemy = GetRandomEnemyFromPos(%clientId, %pos, %radius);

	if (%randomEnemy != "") {
		%transform = MakeTransformFromAtoB(%pos, GameBase::getPosition(%randomEnemy));
		Projectile::spawnProjectile(%projectile, %transform, %player, Item::getVelocity(%player));
	}
}

function shootAtClosestEnemyFromPosition(%clientId, %pos, %radius, %projectile) {
	%player = Client::getOwnedObject(%clientId);
	%randomEnemy = GetClosestEnemyFromPos(%clientId, %pos, %radius);

	if (%randomEnemy != "") {
		%transform = MakeTransformFromAtoB(%pos, GameBase::getPosition(%randomEnemy));
		Projectile::spawnProjectile(%projectile, %transform, %player, Item::getVelocity(%player));
	}
}

function SpawnBombAtClosestEnemyFromPosition(%clientId, %pos, %radius, %bomb, %doDamage, %spellIndex) {
	%player = Client::getOwnedObject(%clientId);
	%randomEnemy = GetClosestEnemyFromPos(%clientId, %pos, %radius);

	if (%doDamage != False)
		%doDamage = True;

	if (%randomEnemy != "") {
		CreateAndDetBomb(%clientId, %bomb, GameBase::getPosition(%randomEnemy), %doDamage, %spellIndex);
	}
}

function FindHarvestableObjects(%object, %clientId, %index, %extra) {
	%alchemySkill = $PlayerSkill[%clientId, $SkillAlchemy];

	if(Object::getName(%object) == "PlantTwo1") {
		%roll = floor(getRandom() * 100) + floor(%alchemySkill / 100) + 1;

		%item = "";
		%amnt = 0;
		%special = "";
		%specialAmnt = 0;

		// rolle for standard herb items
		if (%roll > 10) {
			%item = "HealingHerb";
			%amnt = floor(getRandom() * 5) + floor(getRandom() * floor(%alchemySkill / 100)) + 1;
		}

		// roll again for special herb items
		if (%roll > 50) {
			%special = "MandragoraRoot";
			%specialAmnt = floor(getRandom() * 5) + floor(getRandom() * floor(%alchemySkill / 100)) + 1;
		}

		if (%item != "") {
			Belt::GiveThisStuff(%clientId, %item, %amnt);
			Client::sendMessage(%clientId, $MsgWhite, "You harvested " @ %amnt @ " " @ $beltitem[%item, "Name"] @ ".");
		}

		if (%special != "") {
			Belt::GiveThisStuff(%clientId, %special, %specialAmnt);
			Client::sendMessage(%clientId, $MsgWhite, "You harvested " @ %specialAmnt @ " " @ $beltitem[%special, "Name"] @ ".");
		}

		if (%item == "" && %special == "") {
			Client::sendMessage(%clientId, $MsgRed, "You failed to harvest anything.");
		}

		return;
	}
}

function EndSkill(%clientid, %overrideEndSound, %extradelay, %index, %soundPos, %returnflag) {
	Player::setAnimation(%clientId, 39);

	if(!%overrideEndSound) {
		if(%extraDelay == "")
			playSound($Skill::endSound[%index], %soundPos);
		else
			schedule("playSound(" @ $Skill::endSound[%index] @ ", \"" @ %soundPos @ "\");", %extraDelay);
	}
	
	storeData(%clientId, "UseSkillStep", 2);

	//==================================================================
	%recovTime = fetchData(%clientId, "SkillRecovTime");
	%skilltype = $SkillType[$Skill::keyword[%index]];

	if(%returnFlag == True) {
		// if(%skilltype == $SkillTimeMagick || %skilltype == $SkillWhiteMagick)
		// 	UseSkill(%clientId, %skilltype, True, True);

		// UseSkill(%clientId, $SkillMagicka, True, True);
		// %tempManaCost2 = $Spell::manaCost[%index] / 2;
		// %tempManaCost = floor($Spell::manaCost[%index] / 2);
        
		//pecho(%tempManaCost2 @ " " @%tempManaCost);
		// if(%tempManaCost2 != %tempManaCost)
		// 	%tempManaCost += 1;

		// refreshMANA(%clientId, %tempManaCost);
	}
	else if(%returnFlag == False) {
		// UseSkill(%clientId, %skilltype, False, True);
		// UseSkill(%clientId, $SkillMagicka, False, True);
		%recovTime = %recovTime * 0.5;
	}

	if(%clientId.repack > 32) {
		remoteEval(%clientId, "rpgbarhud", %recovTime, 0, 2, "||", "", "Skill Cooldown", "center");
		schedule("storeData(" @ %clientId @ ", \"UseSkillStep\", \"\");", %recovTime, %clientId);
	}
	else
		schedule("storeData(" @ %clientId @ ", \"UseSkillStep\", \"\");sendDoneRecovMsg(" @ %clientId @ ");", %recovTime);

	return %returnFlag;
}

// no longer using for cleave, maybe useful for other skills
function DoSkillBoxFunction(%target, %clientId, %index, %extra)
{
	dbecho($dbechoMode, "DoSkillBoxFunction(" @ %target @ ", " @ %clientId @ ", " @ %index @ ", " @ %extra @ ")");

	%id = Player::getClient(%target);

	if($Skill::keyword[%index] == "cleave") {
        if(GameBase::getTeam(%clientId) != GameBase::getTeam(%id)) {
			Client::sendMessage(%clientId, $MsgBeige, "Cleaving " @ Client::getName(%id));

			if(%clientId != %id)
				Client::sendMessage(%id, $MsgBeige, "You have been cleaved by " @ Client::getName(%clientId));

            %weapon = GetEquippedWeapon(%clientId);
            GameBase::virtual(%target, "onDamage", "", 1.0, "0 0 0", "0 0 0", "0 0 0", "torso", "front_right", %clientId, %weapon);
            // MeleeAttack(%player);
			// %r = $Skill::damageValue[%index] / $TribesDamageToNumericDamage;
			// refreshHP(%id, %r);
			// %castPos = GameBase::getPosition(%id);

			// CreateAndDetBomb(%clientId, "Bomb10", %castPos, False, %index);
			//playSound($Skill::endSound[%index], %castPos);
		}
    }
}

function DoPhysicalDamage(%target, %clientId, %actionName, %multi, %skillIndex) {
	%targetId = Player::getClient(%target);

	if(GameBase::getTeam(%clientId) != GameBase::getTeam(%targetId)) {
		if (%actionName != "" && %clientId != %targetId)
			Client::sendMessage(%targetId, $MsgBeige, Client::getName(%clientId) @ " hit you with " @ %actionName);

		%weapon = GetEquippedWeapon(%clientId);
		GameBase::virtual(%target, "onDamage", "", %multi, "0 0 0", "0 0 0", "0 0 0", "torso", "front_right", %clientId, %weapon, "", %skillIndex);
	}
}

function PhysicalRadiusDamage(%clientId, %pos, %radius, %actionName, %multiplier, %skillIndex) {
	%multi = 1.0;
	if (%multiplier != "") {
		%multi = %multiplier;
	}
	%set = newObject("set", SimSet);
	%n = containerBoxFillSet(%set, $SimPlayerObjectType, %pos, %radius, %radius, %radius, 0);
	Group::iterateRecursive(%set, DoPhysicalDamage, %clientId, %actionName, %multi, %skillIndex);
	deleteObject(%set);
}

function GetClosestEnemy(%clientId, %radius) {
	%closest = 500000;
	%closestId = "";
	%b = %radius * 2;
	%set = newObject("set", SimSet);
	%n = containerBoxFillSet(%set, $SimPlayerObjectType, GameBase::getPosition(%clientId), %b, %b, %b, 0);

	for(%i = 0; %i < Group::objectCount(%set); %i++) {
		%id = Player::getClient(Group::getObject(%set, %i));

		if(GameBase::getTeam(%id) != GameBase::getTeam(%clientId) && !fetchData(%id, "invisible") && %id != %clientId) {
			%dist = Vector::getDistance($los::position, GameBase::getPosition(%id));

			if(%dist < %closest) {
				%closest = %dist;
				%closestId = %id;
			}
		}
	}
	deleteObject(%set);

	return %closestId;
}

function GetRandomEnemyFromPos(%clientId, %pos, %radius) {
	%enemyCount = 0;
	%enemyIds = "";
	%closestId = "";
	%b = %radius * 2;
	%set = newObject("set", SimSet);
	%n = containerBoxFillSet(%set, $SimPlayerObjectType, %pos, %b, %b, %b, 0);

	for(%i = 0; %i < Group::objectCount(%set); %i++) {
		%id = Player::getClient(Group::getObject(%set, %i));

		if(GameBase::getTeam(%id) != GameBase::getTeam(%clientId) && !fetchData(%id, "invisible") && %id != %clientId) {
			%enemyCount++;
			%enemyIds = %enemyIds @ " " @ %id;
		}
	}
	deleteObject(%set);

	%randomEnemyId = floor(getRandom() * %enemyCount);

	return GetWord(%enemyIds, %randomEnemyId);
}

function GetClosestEnemyFromPos(%clientId, %pos, %radius) {
	%closest = 500000;
	%b = %radius * 2;
	%set = newObject("set", SimSet);
	%n = containerBoxFillSet(%set, $SimPlayerObjectType, %pos, %b, %b, %b, 0);

	for(%i = 0; %i < Group::objectCount(%set); %i++) {
		%id = Player::getClient(Group::getObject(%set, %i));

		if(GameBase::getTeam(%id) != GameBase::getTeam(%clientId) && !fetchData(%id, "invisible") && %id != %clientId) {
			%dist = Vector::getDistance(%pos, GameBase::getPosition(%id));

			if(%dist < %closest) {
				%closest = %dist;
				%closestId = %id;
			}
		}
	}

	deleteObject(%set);

	return %closestId;
}