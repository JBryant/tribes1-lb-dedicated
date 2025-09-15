
function cast_summonswordone(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,41);
	Projectile::spawnProjectile("battleswordone", %trans, %player, %vel);
}
function cast_summonswordtwo(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,41);
	Projectile::spawnProjectile("battleswordtwo",%trans,%player,%vel);
}
function cast_summonswordthree(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,41);
	Projectile::spawnProjectile("battleswordthree",%trans,%player,%vel);
}
function cast_summonswordfour(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,41);
	Projectile::spawnProjectile("battleswordfour",%trans,%player,%vel);
}
function cast_blizzardblizzardboltreal(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,41);
	Projectile::spawnProjectile("blizzardsummonbolt",%trans,%player,%vel);
}
function cast_blizzardblizzardboltfake(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,41);
	Projectile::spawnProjectile("blizzardsummonboltfake",%trans,%player,%vel);
}
function cast_truelight(%Client)
{
	lbecho("spawn light rocket");
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	// Player::setAnimation(%Client,41);
	Projectile::spawnProjectile("lightrocket",%trans,%player,%vel);
}
function cast_rocksummon(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,41);
	Projectile::spawnProjectile("rocksummonbolt",%trans,%player,%vel);
}
function cast_surge(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,41);
	Projectile::spawnProjectile("ssurge",%trans,%player,%vel);
}
function cast_waverly(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,41);
	Projectile::spawnProjectile("wave",%trans,%player,%vel);
}

function cast_cheemeyes(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,41);
	Projectile::spawnProjectile("cheeball",%trans,%player,%vel);
}
function cast_bioone(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,41);
	Projectile::spawnProjectile("bioone",%trans,%player,%vel);
}
function cast_abeam(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,41);
	Projectile::spawnProjectile("cheebeam",%trans,%player,%vel);
}
function cast_waterwaterwater(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,41);
	Projectile::spawnProjectile("waterfinal",%trans,%player,%vel);
}
function cast_waterwater(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,41);

	Projectile::spawnProjectile("ThrowingStar", %trans, %player, %vel); // watershottwo
}

function cast_rangerwind(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,41);
	Projectile::spawnProjectile("rangerwind",%trans,%player,%vel);
}

function cast_rangerfire(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,41);
	Projectile::spawnProjectile("rangerfire",%trans,%player,%vel);
}

function cast_rangerice(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,41);
	Projectile::spawnProjectile("rangerice",%trans,%player,%vel);
}

function cast_blastmeta(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,37);
	Projectile::spawnProjectile("drown",%trans,%player,%vel);
}

function cast_aqua(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,39);
	Projectile::spawnProjectile("drown",%trans,%player,%vel);
}

function cast_fc(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,39);
	Projectile::spawnProjectile("healer",%trans,%player,%vel);
}


function cast_flare(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,40);
	Projectile::spawnProjectile("flare", %trans,%player,%vel);
}

function cast_death(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,39);
	Projectile::spawnProjectile("painbolt",%trans,%player,%vel);
}

function cast_bliz(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,39);
	Projectile::spawnProjectile("blizzagashot",%trans,%player,%vel);
}

function cast_gravity(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,40);
	Projectile::spawnProjectile("Gravityshot",%trans,%player,%vel);
}

function cast_show(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,40);
	Projectile::spawnProjectile("showshockwave",%trans,%player,%vel);
}

function cast_shocklvone(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,40);
	Projectile::spawnProjectile("shocklvone",%trans,%player,%vel);
}

function cast_shocklvtwo(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,40);
	Projectile::spawnProjectile("shocklvtwo",%trans,%player,%vel);
}

function cast_shocklvthree(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,40);
	Projectile::spawnProjectile("shocklvthree",%trans,%player,%vel);
}


function cast_painbolt(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,39);
	Projectile::spawnProjectile("deathdealer",%trans,%player,%vel);
}

function cast_tech(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,42);
	Projectile::spawnProjectile("adminspell",%trans,%player,%vel);
}

function cast_tfist(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,38);
	Projectile::spawnProjectile("roguefist", %trans, %player, %vel);
}

function cast_tornado(%Client, %castPos, %index) {
	%player = Client::getOwnedObject(%Client);
	%xPos = GetWord(%castPos, 0);
	%yPos = GetWord(%castPos, 1);
	%zPos = GetWord(%castPos, 2);

	%count = 0;
	for(%i = 1; %i <= 3; %i++) {
		for(%j = 1; %j <= 10; %j++) {
			%count += 1;
			%newPos = %xPos @ " " @ %yPos @ " " @ (%zPos + %j);
			%delay = %count * 0.1;

			schedule("CreateAndDetBomb(\""@%Client@"\", \"Bomb5\", \""@%newPos@"\", True, \""@%index@"\");", %delay , %player);
		}
	}
}


function cast_fireball(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client, 39);

	%projectile = Projectile::spawnProjectile("FireBolt", %trans, %player, %vel);
}

function cast_flame(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,39);
	Projectile::spawnProjectile("FlameBolt", %trans, %player, %vel);
}

function cast_iceball(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,39);
	Projectile::spawnProjectile("IceBallBolt",%trans,%player,%vel);
}

function cast_ice(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,39);
	Projectile::spawnProjectile("IceBolt",%trans,%player,%vel);
}

function cast_missile(%Client)//,%id)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,39);
	Projectile::spawnProjectile("MagicBolt",%trans,%player,%vel);
}

function cast_laser(%Client)//,%id)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,39);
	Projectile::spawnProjectile("beam",%trans,%player,%vel);
}

function cast_zap(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,39);
	Projectile::spawnProjectile("turretCharge",%trans,%player,%vel);
}

function cast_mortar(%Client)
{
	%player = Client::getOwnedObject(%Client);
	%trans = GameBase::getMuzzleTransform(%player);
	%vel = Item::getVelocity(%player);
	Player::setAnimation(%Client,39);
	Projectile::spawnProjectile("MortarTurretShell",%trans,%player,%vel);
}

function cast_blackhole(%Client, %castObj, %castPos, %w2) {
	// %player = Client::getOwnedObject(%Client);
	// %trans = GameBase::getMuzzleTransform(%player);
	// %vel = Item::getVelocity(%player);
	// Player::setAnimation(%Client,39);
	// Projectile::spawnProjectile("BlackHole", %trans, %player, %vel);

	// spawn object at cast pos + some y
	%pos = GetWord(%castPos, 0) @ " " @ GetWord(%castPos, 1) @ " " @ (GetWord(%castPos, 2) + 4);
	// Projectile::spawnProjectile("BlackHole", %newPos, %player, %vel);
	%hole = newObject("Blood", StaticShape, BloodSpot, true);
	addToSet("MissionCleanup", %hole);
  	schedule("Item::Pop(" @ %hole @ ");", 10, %hole);
	gamebase::setposition(%hole, %pos);

	// now find all enemies within the radius and pull them in

	for(%i = 0; %i < 20; %i++) {
		%freeze = "";
		if (%i == 0) {
			%freeze = True;
		} else if (%i == 16) {
			%freeze = False;
		}

		%set = newObject("set", SimSet);
		%n = containerBoxFillSet(%set, $SimPlayerObjectType, %pos, 100, 100, 100, 0);
		schedule("Group::iterateRecursive(" @ %set @ ", PullTowards, \"" @ %pos @ "\", \"" @ %freeze @ "\");", %i / 5);
		schedule("deleteObject(" @ %set @ ");", %i / 5);

		// Bomb24 - Small blue fusions exp
		// Bomb7 - small blue twinkle star

		if (%i == 1 || %i == 5 || %i == 10 || %i == 15 || %i == 19) {
			schedule("CreateAndDetBomb(\"" @ %Client @ "\", \"Bomb303\", \"" @ %pos @ "\", True, 78);", %i / 5);
		}
		if (%i == 2 || %i == 6 || %i == 11 || %i == 16 || %i == 18) {
			schedule("CreateAndDetBomb(\"" @ %Client @ "\", \"Bomb3002\", \"" @ %pos @ "\", False, 78);", %i / 5);
		}
		if (%i == 3 || %i == 7 || %i == 12 || %i == 17) {
			schedule("CreateAndDetBomb(\"" @ %Client @ "\", \"Bomb42\", \"" @ %pos @ "\", False, 78);", %i / 5);
		}

		%randomPos = GetWord(%pos, 0) - (getRandom() * 3) @ " " @ GetWord(%pos, 1) - (getRandom() * 3) @ " " @ (GetWord(%pos, 2) - c);
		schedule("CreateAndDetBomb(\"" @ %Client @ "\", \"Bomb300\", \"" @ %randomPos @ "\", False, 78);", %i / 5);
	}
}

function PullTowards(%target, %pos, %freeze) {	
	%targetId = Player::getClient(%target);

	if(Player::isAiControlled(%targetId)) {
		// if (%freeze == True) {
		// 	storeData(%targetId, "frozen", True);
		// 	AI::setVar(fetchData(%targetId, "BotInfoAiName"), SpotDist, 0);
		// 	AI::newDirectiveRemove(fetchData(%targetId, "BotInfoAiName"), 99);
		// }

		%targetPos = GameBase::getPosition(%target);
		%targetPosX = GetWord(%targetPos, 0);
		%targetPosY = GetWord(%targetPos, 1);
		%targetPosZ = GetWord(%targetPos, 2);

		%endPosX = GetWord(%pos, 0);
		%endPosY = GetWord(%pos, 1);
		%endPosZ = GetWord(%pos, 2);

		%dx = ((%endPosX - %targetPosX) * 8);
		%dy = ((%endPosY - %targetPosY) * 8);
		%dz = ((%endPosZ - %targetPosZ) * 15);

		%vector = %dx @ " " @ %dy @ " " @ %dz;

		Player::applyImpulse(%targetId, %vector);

		// if (%freeze == False) {
		// 	storeData(%targetId, "frozen", "");
		// 	AI::SetSpotDist(%targetId);
		// }
	}
}


//==================================================================================================================

function BeginCastSpell(%Client, %keyword) { //--1 is casted--0 is scroll
	%w1 = GetWord(%keyword, 0);
	%w2 = String::getSubStr(%keyword, String::len(%w1)+1, 99999);
	%i = $Spell::index[%w1];

	if(%i == "") {
		Client::sendMessage(%Client, $MsgWhite, "This spell seems unfamiliar to you.");
		return;
	}

	$ClientData[%Client, SpellType] = "";

	if(SkillCanUseSpell(%Client, %i, 1)) {
		Client::sendMessage(%Client, $MsgBeige, "Casting "@$Spell::name[%i]@": " @$Spell::keyword[%i]);
		%player = Client::getOwnedObject(%Client);

		if(GameBase::getLOSinfo(%player, $Spell::LOSrange[%i])) {
			%lospos = $los::position;
			%losobj = $los::object;
		}
		else {
			%lospos = "";
			%losobj = "";
		}

		// $SpellCastStep[%Client] = 1;
		storeData(%Client, "SpellCastStep", 1);
		storeData(%Client, "LastCastSpell", %w1);

		if(%Client.adminLevel < 5) {
			%spellCost = $Spell::manaCost[%i];
			if (HasBonusState(%Client, "DoubleCast"))
				%spellCost = %spellCost * 2;

			%tempManaCost = floor(%spellCost / 2);
			refreshMANA(%Client, %tempManaCost);
		}

		playSound($Spell::startSound[%i], GameBase::getPosition(%Client));

		// shows some casting animation stuff
		ooo(%Client, %i);

		schedule("DoCastSpell("@%Client@", \""@%i@"\", \""@GameBase::getPosition(%Client)@"\", \""@%lospos@"\", \""@%losobj@"\", \""@%w2@"\", \""@%tempManaCost@"\");", $Spell::delay[%i], %player);
		return True;
	}

	return False;
}

function DoCastSpell(%Client, %index, %oldpos, %castPos, %castObj, %w2, %tempManaCost) {

	//echo("cl:"@%Client@" index:"@%index@" oldpos:"@%oldpos@" pos:"@%castPos@" Obj:"@%castObj@" w2:"@%w2@" ManaC:"@%tempManaCost);

	if(IsDead(%Client)) {
		// $SpellCastStep[%Client] = "";
		storeData(%Client, "SpellCastStep", "");
		return False;
	}

	%player = Client::getOwnedObject(%Client);

	if(Vector::getDistance(%oldpos, GameBase::getPosition(%Client)) > $SpellMovementGraceDistance) {
		Client::sendMessage(%Client, $MsgBeige, "You failed to cast the spell.");
		//$SpellCastStep[%Client] = "";
		storeData(%Client, "SpellCastStep", "");

		return False;
	}

	//group-list check
	if($Spell::groupListCheck[%index]) {
		%cl = Player::getClient(%castObj);
		if( !(IsInGroupList(%Client, %cl) && IsInGroupList(%cl, %Client)) ) {
			Client::sendMessage(%Client, $MsgBeige, "You are not part of the target's group.");
			//$SpellCastStep[%Client] = "";
			storeData(%Client, "SpellCastStep", "");

			return False;
		}
	}

	refreshMANA(%Client, %tempManaCost);
	$CanDoSpellDmg[%Client] = True;
	Schedule("$CanDoSpellDmg["@%Client@"] = \"\";", 3.1);
	$ClientData[%Client, SpellType] = $Spell::Type[%index];
	$ClientData[%Client, SpellDmg] = $Spell::damageValue[%index];
	if (HasBonusState(%Client, "DoubleCast"))
		$ClientData[%Client, SpellDmg] = $Spell::damageValue[%index] * 2;

	%info = eval("SpellNum"@%index@"("@%Client@", \""@%castObj@"\", \""@%castPos@"\", \""@%w2@"\");");

	if(String::findSubStr(%info, "reflection 1") != -1)
	{
		%temp_id = %id;
		%id = %Client;
		%Client = %temp_id;
	}


	if ($Spell::endSound[%index] != "") {
		if (%castPos != "") {
			playSound($Spell::endSound[%index], %castPos);
		} else {
			playSound($Spell::endSound[%index], GameBase::getPosition(%Client));
		}
	}

	// if((%HealId = String::getSubStr(%info, String::findSubStr(%info, "HealId"), 4)) != "")
	// 	remoteEval(%HealId, "RefreshHPset", Fix(getHP(%HealId), %HealId, HP)); // fetchData(%id, "HP")

	%recovTime = $Spell::recoveryTime[%index];

	if (HasBonusState(%clientId, "Haste") == True) {
		%recovTime = floor(%recovTime * 0.5);
	}

	if(%Client.repack > 32) {
		remoteEval(%Client, "rpgbarhud", %recovTime, 4, 2, "||", "", "Spell Cooldown", "center");
	}

	//if(String::findSubStr(%info, "returnFlag 1") != -1) {
		//$SpellCastStep[%Client] = 2;
		if ($Spell::recoveryTime[%index] != "") {
			storeData(%Client, "SpellCastStep", 2);
			schedule("SayReadyToCast("@%Client@");", %recovTime);
			return True;
		} else {
			SayReadyToCast(%Client);
			return True;
		}
	//}
	//else {
	//	SayReadyToCast(%Client);
	//	return False;
	//}
}

function SayReadyToCast(%Client) {
	Client::sendMessage(%Client, 0, "You are ready to cast.");
	//$SpellCastStep[%Client] = "";
	storeData(%Client, "SpellCastStep", "");
	storeData(%Client, "LastCastSpell", "");
}

// looks like some fancy looking spells
function ooo(%Client, %i) {
	%ccpos = GameBase::getPosition(%Client);
	%player = Client::getOwnedObject(%Client);
	%minrad = 0;
	%maxrad = 4;

	for(%s = 0; %s <= $Spell::delay[%i]; %s++)
	{
		%tempPos = RandomPositionXY(%minrad, %maxrad);

		%xPos = GetWord(%tempPos, 0) + GetWord(%ccpos, 0);
		%yPos = GetWord(%tempPos, 1) + GetWord(%ccpos, 1);
		%zPos = GetWord(%ccpos, 2) + (%s * 2);

		%newPos = %xPos@" "@%yPos@" "@%zPos;	//Bomb9
       	schedule("CreateAndDetBomb(\""@%Client@"\", \"Bomb3000\", \""@%newPos@"\", \"False\", \""@%i@"\", \"1\", \"True\");", %s / 20);

		// %tempPos = RandomPositionXY(%minrad, %maxrad);

		// %xPos = GetWord(%tempPos, 0) + GetWord(%ccpos, 0);
		// %yPos = GetWord(%tempPos, 1) + GetWord(%ccpos, 1);
		// %zPos = GetWord(%ccpos, 2) + (%s * 2);

		// %newPos = %xPos@" "@%yPos@" "@%zPos;

		// schedule("CreateAndDetBomb(\""@%Client@"\", \"Bomb3002\", \""@%newPos@"\", \"False\", \""@%i@"\", \"1\");", %s / 15);

		// %tempPos = RandomPositionXY(%minrad, %maxrad);

		// %xPos = GetWord(%tempPos, 0) + GetWord(%ccpos, 0);
		// %yPos = GetWord(%tempPos, 1) + GetWord(%ccpos, 1);
		// %zPos = GetWord(%ccpos, 2) + (%s * 2);

		// %newPos = %xPos@" "@%yPos@" "@%zPos;

		// schedule("CreateAndDetBomb(\""@%Client@"\", \"Bomb3003\", \""@%newPos@"\", \"False\", \""@%i@"\", \"1\");", %s / 10);
	}
}

function CreateAndDetBomb(%clientId, %b, %castPos, %doDamage, %index, %multiplier, %skipSound) {
	// lbecho("CreateAndDetBomb(" @ %clientId @ ", " @ %b @ ", " @ %castPos @ ", " @ %doDamage @ ", " @ %index @ ", " @ %multiplier @ ");");
	%player = Client::getOwnedObject(%clientId);
	%bomb = newObject("", "Mine", %b);

	addToSet("MissionCleanup", %bomb);
	GameBase::Throw(%bomb, %player, 0, false);
	GameBase::setPosition(%bomb, %castPos);

	if (%doDamage != False) {
		if ($SkillType[$Spell::keyword[%index]] == $SkillBows) {
			%multi = 1.0;
			if (%multiplier != "") {
				%multi = %multiplier;
			}
			PhysicalRadiusDamage(%clientId, %castPos, $Spell::radius[%index] * 2, $Spell::name[%index], %multi);
		} else {
			SpellRadiusDamage(%clientId, %castPos, %index);
		}
	}

	if ($Spell::endSound[%index] != "" && !%skipSound)
		playSound($Spell::endSound[%index], %castPos);
}

function SpellDamage(%Client, %targetId, %index) {
	%spellDamage = $Spell::damageValue[%index];
	if (HasBonusState(%Client, "DoubleCast"))
		%spellDamage = %spellDamage * 2;

	GameBase::virtual(%targetId, "onDamage", $SpellDamageType, %spellDamage, "0 0 0", "0 0 0", "0 0 0", "torso", "front_right", %Client, $Spell::keyword[%index]);
}

function SpellRadiusDamage(%Client, %pos, %index) {
	%percMin = 5;
	%percMax = 100;

	%list = GetEveryoneIdList();

	for(%i = 0; GetWord(%list, %i) != -1; %i++) {
		%id = GetWord(%list, %i);

		%dist = Vector::getDistance(%pos, GameBase::getPosition(%id));

		if(%dist <= $Spell::radius[%index]) {
			%spellDamage = $Spell::damageValue[%index];
			if (HasBonusState(%Client, "DoubleCast"))
				%spellDamage = %spellDamage * 2;

			%newDamage = SpellCalcRadiusDamage(%dist, $Spell::radius[%index], %spellDamage, %percMin, %percMax);
			GameBase::virtual(%id, "onDamage", $SpellDamageType, %newDamage, "0 0 0", "0 0 0", "0 0 0", "torso", "front_right", %Client, $Spell::keyword[%index]);
		}
	}
}

function SpellCalcRadiusDamage(%dist, %radius, %dmg, %percMin, %percMax) {
	if(%radius == "")
		%radius = 10;

	%newdmg = %dmg - (%dist * (%dmg / %radius));
	%p = (%newdmg * 100) / %dmg;

	if(%p < %percMin)
		%p = %percMin;
	else if(%p > %percMax)
		%p = %percMax;

	%newdmg = (%p * %dmg) / 100;

	return %newdmg;
}

function StaticDoorForceField::onCollision(%this, %object) { //for FWALL
	%Client = Player::getClient(%object);

	if(GameBase::getTeam(%Client) == GameBase::getTeam(%this))
		GameBase::setPosition(%Client,GameBase::getPosition(%this));
	else {
		for(%mynum=1;%mynum<$MYmaxclients;%mynum++) {
			if($fwallid[%mynum]==%this) {
				Item::setVelocity(%Client,GetWord(Item::getVelocity(%Client),0)@" "@GetWord(Item::getVelocity(%Client),1)@" "@-($fwallttl[%mynum]));
				break;
			}
		}
	}
}

function GetBestSpell(%Client, %type, %semiRandomSpell) {
	%bestSpell = 26;

	if(%type==-1)
	{//9,10
		%bestSpell=9;
		if(getMANA(%Client) >= $Spell::manaCost[10])
		{
			if(getRandom()*100>50)
			{
				%bestSpell=10;
			}
		}
	}
	else
	{//1,5,6,7,16,17,18,19,20,21,8
		%bestSpell=26;
		%r=floor(getRandom()*12)+1;
		if(%r==14)
			%r=20;
		if(%r==29)
			%r=14;
		else if(%r==20)
			%r=29;
		else if(%r==39)
			%r=45;
		else if(%r==41)
			%r=41;
		else if(%r==45)
			%r=30;
		else if(%r==26)
			%r=22;     //you were using %r=4 for a test BestChiefSpell
		else if(%r==16)  //that is how you set the var
			%r=30;     //so this func didnt work for shit before!!
		else if(%r==26)
			%r=22;
		else if(%r==16)
			%r=39;
		else if(%r==46)
			%r=46;
		else
			%r=5;
		if(getMANA(%Client) >= $Spell::manaCost[%r])
		{
			%bestSpell=%r;
		}
	}
	return %bestSpell;
}
function BestChiefSpell(%Client, %type, %semiRandomSpell)
{
	%bestSpell = 4;

	if(%type==-1)
	{//9,10
		%bestSpell=4;
		if(getMANA(%Client) >= $Spell::manaCost[10])
		{
			if(getRandom()*100>50)
			{
				%bestSpell=28;
			}
		}
	}
	else
	{//1,5,6,7,16,17,18,19,20,21,8
		%bestSpell=26;
		%r=floor(getRandom()*12)+1;
		if(%r==4)
			%r=28;
		if(%r==4)
			%r=28;
		else if(%r==28)
			%r=4;
		else if(%r==4)
			%r=28;
		else if(%r==4)
			%r=4;
		else if(%r==28)
			%r=28;
		else if(%r==28)
			%r=28;     //you were using %r=4 for a test BestChiefSpell
		else if(%r==28)  //that is how you set the var
			%r=4;     //so this func didnt work for shit before!!
		else if(%r==28)
			%r=28;
		else if(%r==28)
			%r=4;
		else if(%r==48)
			%r=28;
		else
			%r=4;
		if(getMANA(%Client) >= $Spell::manaCost[%r])
		{
			%bestSpell=%r;
		}
	}
	return %bestSpell;
}
// function GetBestSpell(%Client, %type, %semiRandomSpell)
// {

// 	%wdelay = 10;	//weights
// 	%wrecov = 0.5;

// 	%bestSpell = -1;
// 	%backupSpell = "";
// 	%highest = 0.1;

// 	for(%i = 1; $Spell::keyword[%i] != ""; %i++)
// 	{
// 		if(getFinalLVL(%Client) >= $Spell::minLevel[%i])
// 		{
// 			if($MANA[%Client] >= $Spell::manaCost[%i])
// 			{
// 				%d = ( ($Spell::delay[%i] / %wdelay) + ($Spell::recoveryTime[%i] / %wrecov) );
// 				%x = (100 / %d) * $Spell::refVal[%i];
// 				%v =  %x * %type;

// 				if(%semiRandomSpell)
// 				{
// 					%r = getRandom() * 100;
// 					%rr = getRandom() * 100;
// 				}
// 				else
// 				{
// 					%r = 1;
// 					%rr = 0;
// 				}

// 				if(%v > %highest)
// 				{
// 					if(%r > %rr)
// 					{
// 						%bestSpell = %i;
// 						%highest = %v;
// 					}
// 					else
// 						%backupSpell = %i;
// 				}
// 			}
// 		}
// 	}
// 	if(%bestSpell == -1 && %backupSpell != "")
// 		%bestSpell = %backupSpell;

// 	return %bestSpell;
// }

// this function is to let objects us do cool spell stuff on an object and then delete it
// good for explosives, flasks, flame arrows etc
function TriggerSpellEffectOnObject(%object, %spellIndex) {
	if(%spellIndex == "43") {
		DetonateItem(%object, "Bomb6", %spellIndex);
	}
}

function GetBestSpellNew(%clientId) {
	%currentLevel = getFinalLVL(%clientId);

	if (%currentLevel < 3) {
		return $Spell::index["fire"];
	} else if (%currentLevel < 15) {
		%spells = "fire blizzard";
		return $Spell::index[GetWord(%spells, floor(getRandom() * 2))];
	} else if (%currentLevel < 25) {
		%spells = "fire blizzard aero";
		return $Spell::index[GetWord(%spells, floor(getRandom() * 3))];
	} else if (%currentLevel < 30) {
		%spells = "blizzard aero fira";
		return $Spell::index[GetWord(%spells, floor(getRandom() * 3))];
	} else if (%currentLevel < 40) {
		%spells = "thunder tremor fira";
		return $Spell::index[GetWord(%spells, floor(getRandom() * 3))];
	} else if (%currentLevel < 50) {
		%spells = "thunder tremor blizzara";
		return $Spell::index[GetWord(%spells, floor(getRandom() * 3))];
	} else if (%currentLevel < 60) {
		%spells = "aquara aeroga blizzara";
		return $Spell::index[GetWord(%spells, floor(getRandom() * 3))];
	} else if (%currentLevel < 70) {
		%spells = "quake aeroga aquara";
		return $Spell::index[GetWord(%spells, floor(getRandom() * 3))];
	} else if (%currentLevel < 100) {
		%spells = "quake thundaga aeroga aquara";
		return $Spell::index[GetWord(%spells, floor(getRandom() * 4))];
	} else if (%currentLevel < 150) {
		%spells = "aquaga firaga thundaga";
		return $Spell::index[GetWord(%spells, floor(getRandom() * 3))];
	} else if (%currentLevel < 200) {
		%spells = "tornado thunderstorm aquaga firaga";
		return $Spell::index[GetWord(%spells, floor(getRandom() * 4))];
	} else if (%currentLevel < 230) {
		%spells = "tsunami avalanche flare tornado thunderstorm";
		return $Spell::index[GetWord(%spells, floor(getRandom() * 5))];
	} else {
		%spells = "tsunami avalanche flare tornado thunderstorm cataclysm";
		return $Spell::index[GetWord(%spells, floor(getRandom() * 6))];
	}

	return "11";
}

function GetRandomSpell(%clientId) {
	%randomSpell = "";
	%cap = 0;

	while (%randomSpell == "") {
		if (%cap > 100)
			return "11";

		%cap += 1;
		%randomSpellIndex = floor(getRandom() * 69) + 1;

		if (SkillCanUseSpell(%clientId, %randomSpellIndex, 0)) {
			%randomSpell = %randomSpellIndex;
		}
	}


	return %randomSpell;
}
