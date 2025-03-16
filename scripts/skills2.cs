// -------------- New Skill Systems
$Skill::keyword[1] = "mend";
$Skill::index[mend] = 1;
$Skill::name[1] = "Mend Self or Other";
$Skill::description[1] = "Mends the user or someone in the LOS, slightly restoring some health.";
$Skill::actionMessage[1] = "You begin mending the wounds.";
$Skill::delay[1] = 3;
$Skill::recoveryTime[1] = 10;
$Skill::damageValue[1] = -10;
$Skill::LOSrange[1] = 80;
$Skill::startSound[1] = AmbientScurry;
$Skill::endSound[1] = MedicSpell;
$Skill::groupListCheck[1] = False;
$Skill::refVal[1] = -10;
$Skill::graceDistance[1] = 2;
$Skill::requiredItems[1] = "HealingKit";
$Skill::removesRequiredItems[1] = True;

$Skill::keyword[2] = "cleave";
$Skill::index[cleave] = 2;
$Skill::name[2] = "Cleave";
$Skill::description[2] = "A mighty swing that deals damage to up to two targets around you.";
$Skill::actionMessage[2] = "You swing a mighty cleave.";
$Skill::delay[2] = 0.1;
$Skill::recoveryTime[2] = 5;
// $Skill::damageValue[2] = 10;
$Skill::radius[2] = 10;
$Skill::LOSrange[2] = 0;
$Skill::startSound[2] = AmrbroseSwordA;
$Skill::endSound[2] = ActivateAR;
$Skill::groupListCheck[2] = False;
$Skill::refVal[2] = -10;
$Skill::graceDistance[2] = 2;
$SkillRestriction[$Skill::keyword[2]] = "C Squire C Knight";

$Skill::keyword[3] = "harvest";
$Skill::index[harvest] = 3;
$Skill::name[3] = "Harvest";
$Skill::description[3] = "Attempts to gather resources from the environment.";
$Skill::actionMessage[3] = "You begin harvesting.";
$Skill::delay[3] = 1; // 3
$Skill::recoveryTime[3] = 1; // 3
$Skill::LOSrange[3] = 1;
$Skill::startSound[3] = AmbientScurry;
// $Skill::endSound[1] = MedicSpell;
$Skill::groupListCheck[3] = False;
$Skill::refVal[3] = -10;
$Skill::graceDistance[3] = 0.5;
// $Skill::requiredItems[3] = "HealingKit";
// $Skill::removesRequiredItems[3] = True;


function BeginUseSkill(%clientId, %keyword) {
	dbecho($dbechoMode, "BeginUseSkill(" @ %clientId @ ", " @ %keyword @ ")");

	%skillName = GetWord(%keyword, 0);
	%rest = String::getSubStr(%keyword, String::len(%w1)+1, 99999);
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

	// check if the skill requires any special items
	if ($Skill::requiredItems[%skillIndex] != "" && belt::hasthisstuff(%clientId, $Skill::requiredItems[%skillIndex]) < 1) {
		Client::sendMessage(%clientId, $MsgRed, "You do not have the required items to use "@%keyword@".");
		return False;
	}

	
    // Client::sendMessage(%clientId, $MsgBeige, "Casting " @ $Spell::name[%i] @ ".");

    %player = Client::getOwnedObject(%clientId);

    if(GameBase::getLOSinfo(%player, $Skill::LOSrange[%skillIndex])) {
        //%lospos = $los::position;
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

    %rt = $Skill::recoveryTime[%skillIndex];
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
        eval("useskill::"@$Skill::keyword[%skillIndex]@"(" @ %clientId @ ", " @ %skillIndex @ ", \"" @ GameBase::getPosition(%clientId) @ "\", \"" @ %losobj @ "\", \"" @ %w2 @ "\");");
    } else if($Skill::delay[%skillIndex] > 0) {
        if($Skill::Indicator[%skillIndex]) {
            spellIndicatorLoop(%clientId, $Skill::LOSrange[%skillIndex]);
        }

        Schedule::Add("DoUseSkill(" @ %clientId @ ", " @ %skillIndex @ ", \"" @ GameBase::getPosition(%clientId) @ "\", \"" @ %losobj @ "\", \"" @ %w2 @ "\");", $Skill::delay[%skillIndex], "spell"@%clientId);
    } else {
        DoUseSkill(%clientId, %skillIndex, GameBase::getPosition(%clientId), %losobj, %w2);
    }

    //schedule("DoCastSpell(" @ %clientId @ ", " @ %i @ ", \"" @ GameBase::getPosition(%clientId) @ "\", \"" @ %lospos @ "\", \"" @ %losobj @ "\", \"" @ %w2 @ "\");", $Spell::delay[%i]);
    //schedule("%retval=DoCastSpell(" @ %clientId @ ", " @ %i @ ", \"" @ GameBase::getPosition(%clientId) @ "\", \"" @ %lospos @ "\", \"" @ %losobj @ "\", \"" @ %w2 @ "\"); if(%retval){refreshMANA(" @ %clientId @ ", " @ %tempManaCost @ ");}", $Spell::delay[%i]);

    return True;
}

function DoUseSkill(%clientId, %index, %oldpos, %castObj, %w2) {
	dbecho($dbechoMode, "DoUseSkill(" @ %clientId @ ", " @ %index @ ", " @ %oldpos @ ", " @ %castPos @ ", " @ %castObj @ ", " @ %w2 @ ")");

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

	// check to remove any required items (only works with 1 item and 1 count for now, could enhance later)
	if ($Skill::removesRequiredItems[%index] == True) {
		%has = belt::hasthisstuff(%clientId, $Skill::requiredItems[%index]);
		belt::takethisstuff(%clientId,  $Skill::requiredItems[%index], 1);
		%has--;
		Client::sendMessage(%clientId, $MsgWhite, "You used a Healing Kit. [have "@%has@"]");
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

		Group::iterateRecursive(%set, DoSkillBoxFunction, %clientId, %index, %w2);
		deleteObject(%set);

		%overrideEndSound = True;
		%returnFlag = True;
    }

	 if ($Skill::keyword[%index] == "harvest") {
		// lbecho("---------");
		// %player = Client::getOwnedObject(%clientId);
		// GameBase::getLOSinfo(%clientId, 1000);
		// lbecho($los::object);
		// %type = getObjectType($los::object);
		// lbecho("Type: " @ %type);

		// if(getObjectType($los::object) == "Player" && !Player::isAiControlled(%id)) {
		// 	%TrueClientId.stealType = 1;
		// 	SetupInvSteal(%TrueClientId, %id);
		// }

		%set = newObject("set", SimSet);
	    %num = containerBoxFillSet(%set, $StaticObjectType, GameBase::getPosition(%clientId), 4, 4, 4, 0);

		Group::iterateRecursive(%set, findHarvestableObjects, %clientId, %index, %w2);
		deleteObject(%set);

		%overrideEndSound = True;
		%returnFlag = True;
	 }

    // return EndSkill
    return EndSkill(%clientid, %overrideEndSound, %extradelay, %index, %castpos, %returnflag);
}

function findHarvestableObjects(%object, %clientId, %index, %extra) {
	if(Object::getName(%object) == "PlantTwo1") {
		// get low level resources
		Client::sendMessage(%clientId, $MsgWhite, "You harvested!");
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