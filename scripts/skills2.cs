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
$Skill::requiredItems[1] = "HealingKit 1";
$Skill::removeItems[1] = "HealingKit 1";

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
// $Skill::startSound[2] = AmrbroseSwordA;
$Skill::endSound[2] = AmrbroseSwordA;
$Skill::groupListCheck[2] = False;
$Skill::refVal[2] = -10;
$Skill::graceDistance[2] = 2;
// $SkillRestriction[$Skill::keyword[2]] = "C Squire C Knight";

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
// $Skill::requiredItems[4] = "CrudeClayAlembic 1";
$Skill::requireOneOfItems[4] = "CrudeClayAlembic WornCopperAlembic ReinforcedIronAlembic ArcaneGlassAlembic CelestialMythrilAlembic";
$SkillRestriction[$Skill::keyword[4]] = "C Chemist";

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
			
			if (Belt::HasThisStuff(%clientId, %checkItem) > 0) {
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
		return EndSkill(%clientid, %overrideEndSound, %extradelay, %index, %castpos, %returnflag);
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
			return EndSkill(%clientid, %overrideEndSound, %extradelay, %index, %castpos, %returnflag);
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

		%r = $Skill::damageValue[%index] / $TribesDamageToNumericDamage;
		refreshHP(%id, %r);
		%castPos = GameBase::getPosition(%id);
		
		refreshAll(%clientId);

		%returnFlag = True;
    }

    if ($Skill::keyword[%index] == "cleave") {
		%b = $Skill::radius[%index] * 2;
		%set = newObject("set", SimSet);
		%n = containerBoxFillSet(%set, $SimPlayerObjectType, GameBase::getPosition(%clientId), %b, %b, %b, 0);

		Group::iterateRecursive(%set, DoSkillBoxFunction, %clientId, %index, %rest);
		deleteObject(%set);

		%returnFlag = True;
    }

	 if ($Skill::keyword[%index] == "harvest") {
		%set = newObject("set", SimSet);
		%losRange = $Skill::LOSrange[%index] || 4;
	    %num = containerBoxFillSet(%set, $StaticObjectType, GameBase::getPosition(%clientId), 4, 4, 4, 0);

		Group::iterateRecursive(%set, findHarvestableObjects, %clientId, %index, %rest);
		deleteObject(%set);

		%overrideEndSound = True;
		%returnFlag = True;
	}

	if ($Skill::keyword[%index] == "alchemy") {
		%item = %rest;
		%alchemyIngredients = $AccessoryVar[%item, "AlchemyIngredients"];

		if (%alchemyIngredients != "") {
			// check if they have the ingredients to make a potion
			%missingItems = False;
			for(%idx = 0; GetWord(%alchemyIngredients, %idx) != -1; %idx += 2) {
				%checkItem = GetWord(%alchemyIngredients, %idx);
				%amnt = GetWord(%alchemyIngredients, %idx + 1);
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
					%amnt = GetWord(%alchemyIngredients, %idx + 1);
					%has = Belt::HasThisStuff(%clientId, %removeItem);

					Belt::TakeThisStuff(%clientId, %removeItem, %amnt);
					Client::sendMessage(%clientId, $MsgWhite, "You used "@ %amnt @" "@ $beltitem[%removeItem, "Name"] @". [have "@ (%has - %amnt) @"]");
				}

				// give the item
				Belt::GiveThisStuff(%clientId, %item, 1);
				Client::sendMessage(%clientId, $MsgWhite, "You made a " @ $beltitem[%item, "Name"] @ "!");
			}
		} else {
			Client::sendMessage(%clientId, $MsgRed, "There is no alchemical recipe to make " @ %item @ ".");
			%overrideEndSound = True;
			%returnFlag = True;
		}
	}

    return EndSkill(%clientid, %overrideEndSound, %extradelay, %index, %castpos, %returnflag);
}

function findHarvestableObjects(%object, %clientId, %index, %extra) {
	if(Object::getName(%object) == "PlantTwo1") {
		%roll = floor(getRandom() * 100) + 1;

		%item = "";
		%amnt = 0;
		if (%roll > 80) {
			%item = "MandragoraRoot";
			%amnt = floor(getRandom() * 5) + 1;
		} else if (%roll > 10) {
			%item = "HealingHerb";
			%amnt = floor(getRandom() * 5) + 1;
		}

		if (%item != "") {
			Belt::GiveThisStuff(%clientId, %item, %amnt);
			Client::sendMessage(%clientId, $MsgWhite, "You harvested " @ %amnt @ " " @ $beltitem[%item, "Name"] @ "!");
		} else {
			Client::sendMessage(%clientId, $MsgRed, "You failed to harvest anything.");
		}

		return;
	}
}

function EndSkill(%clientid, %overrideEndSound, %extradelay, %index, %castpos, %returnflag) {
	Player::setAnimation(%clientId, 39);

	if(!%overrideEndSound) {
		if(%extraDelay == "")
			playSound($Skill::endSound[%index], %castPos);
		else
			schedule("playSound(" @ $Skill::endSound[%index] @ ", \"" @ %castPos @ "\");", %extraDelay);
	}
	
	storeData(%clientId, "UseSkillStep", 2);

	//==================================================================
	%recovTime = fetchData(%clientId, "SkillRecovTime");
	%skilltype = $SkillType[$Skill::keyword[%index]];

	if(%returnFlag == True) {
		// if(%skilltype == $SkillTimeMagick || %skilltype == $SkillWhiteMagick)
		// 	UseSkill(%clientId, %skilltype, True, True);

		// UseSkill(%clientId, $SkillEnergy, True, True);
		// %tempManaCost2 = $Spell::manaCost[%index] / 2;
		// %tempManaCost = floor($Spell::manaCost[%index] / 2);
        
		//pecho(%tempManaCost2 @ " " @%tempManaCost);
		// if(%tempManaCost2 != %tempManaCost)
		// 	%tempManaCost += 1;

		// refreshMANA(%clientId, %tempManaCost);
	}
	else if(%returnFlag == False) {
		// UseSkill(%clientId, %skilltype, False, True);
		// UseSkill(%clientId, $SkillEnergy, False, True);
		%recovTime = %recovTime * 0.5;
	}

	if(%clientId.repack > 32){
		remoteEval(%clientId, "rpgbarhud", %recovTime, 4, 2, "||");
		schedule("storeData(" @ %clientId @ ", \"UseSkillStep\", \"\");", %recovTime, %clientId);
	}
	else
		schedule("storeData(" @ %clientId @ ", \"UseSkillStep\", \"\");sendDoneRecovMsg(" @ %clientId @ ");", %recovTime);

	return %returnFlag;
}

function DoSkillBoxFunction(%object, %clientId, %index, %extra)
{
	dbecho($dbechoMode, "DoSkillBoxFunction(" @ %object @ ", " @ %clientId @ ", " @ %index @ ", " @ %extra @ ")");

	%id = Player::getClient(%object);

	if($Skill::keyword[%index] == "cleave") {
        if(GameBase::getTeam(%clientId) != GameBase::getTeam(%id)) {
			Client::sendMessage(%clientId, $MsgBeige, "Cleaving " @ Client::getName(%id));

			if(%clientId != %id)
				Client::sendMessage(%id, $MsgBeige, "You have been cleaved by " @ Client::getName(%clientId));

            %weapon = GetEquippedWeapon(%clientId);
            GameBase::virtual(%object, "onDamage", "", 1.0, "0 0 0", "0 0 0", "0 0 0", "torso", "front_right", %clientId, %weapon);
            // MeleeAttack(%player);
			// %r = $Skill::damageValue[%index] / $TribesDamageToNumericDamage;
			// refreshHP(%id, %r);
			// %castPos = GameBase::getPosition(%id);

			// CreateAndDetBomb(%clientId, "Bomb10", %castPos, False, %index);
			//playSound($Skill::endSound[%index], %castPos);
		}
    }
}