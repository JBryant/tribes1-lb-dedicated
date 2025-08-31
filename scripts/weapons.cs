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


$fireTimeDelay = 0.1;

$RustyDamageAmp = 0.7;
$RustyWeightAmp = 1.5;
$RustyCostAmp = 0.3;

$RangeTable[$AxeAccessoryType] = 3;
$RangeTable[$SwordAccessoryType] = 3;
$RangeTable[$PolearmAccessoryType] = 4;
$RangeTable[$BludgeonAccessoryType] = 3;

$DelayFactorTable[$RingAccessoryType] = "0.0";
$DelayFactorTable[$BodyAccessoryType] = "0.0";
$DelayFactorTable[$BootsAccessoryType] = "0.0";
$DelayFactorTable[$BackAccessoryType] = "0.0";
$DelayFactorTable[$ShieldAccessoryType] = "0.0";
$DelayFactorTable[$TalismanAccessoryType] = "0.0";
$DelayFactorTable[$AxeAccessoryType] = "1.0";
$DelayFactorTable[$SwordAccessoryType] = "1.0";
$DelayFactorTable[$PolearmAccessoryType] = "1.0";
$DelayFactorTable[$BludgeonAccessoryType] = "1.0";
$DelayFactorTable[$RangedAccessoryType] = "1.0";
$DelayFactorTable[$ProjectileAccessoryType] = "1.0";

$CostFactorTable[$RingAccessoryType] = "1.0";
$CostFactorTable[$BodyAccessoryType] = "1.0";
$CostFactorTable[$BootsAccessoryType] = "1.0";
$CostFactorTable[$BackAccessoryType] = "1.0";
$CostFactorTable[$ShieldAccessoryType] = "1.0";
$CostFactorTable[$TalismanAccessoryType] = "1.0";
$CostFactorTable[$SwordAccessoryType] = "1.0";
$CostFactorTable[$AxeAccessoryType] = "1.0";
$CostFactorTable[$PolearmAccessoryType] = "1.0";
$CostFactorTable[$BludgeonAccessoryType] = "1.0";
$CostFactorTable[$RangedAccessoryType] = "1.0";
$CostFactorTable[$ProjectileAccessoryType] = "0.01";

//****************************************************************************************************

$WeaponRange[Sling] = 35;
$WeaponRange[ShortBow] = 120;
$WeaponRange[LongBow] = 200;
$WeaponRange[ElvenBow] = 260;
$WeaponRange[CompositeBow] = 360;
$WeaponRange[LightCrossbow] = 300;
$WeaponRange[AeolusWing] = 400;
$WeaponRange[HeavyCrossbow] = 500;
$WeaponRange[RepeatingCrossbow] = 280;
$WeaponRange[CastingBlade] = 1000;	//will swing from anywhere...BUT will be able to snipe with beam
$WeaponRange[Wand] = 1000;
$WeaponRange[TesterBow] = 400;

// We have a choice... either we let weapon delay be decided by weight
// Or we hard code it for every weapon.
// $WeaponDelay[Sling] = 1;
// $WeaponDelay[ShortBow] = 1;
// $WeaponDelay[LongBow] = 1.5;
// $WeaponDelay[ElvenBow] = 1;
// $WeaponDelay[CompositeBow] = 2;
// $WeaponDelay[LightCrossbow] = 1;
// $WeaponDelay[AeolusWing] = 1;
// $WeaponDelay[HeavyCrossbow] = 3;
// $WeaponDelay[RepeatingCrossbow] = 0.5;
// $WeaponDelay[TesterBow] = 1;

$ProjRestrictions[SmallRock] = ",Sling,";
$ProjRestrictions[BasicArrow] = ",PracticeBow,QuickshotBow,HuntingBow,ReinforcedLongbow,Warbow,SharpshooterBow,GaleBow,ElvenLongbow,ArcaneBow,HawksTalon,LongbowsBow,";
$ProjRestrictions[SheafArrow] = ",PracticeBow,QuickshotBow,HuntingBow,ReinforcedLongbow,Warbow,SharpshooterBow,GaleBow,ElvenLongbow,ArcaneBow,HawksTalon,LongbowsBow,";
$ProjRestrictions[BladedArrow] = ",HuntingBow,ReinforcedLongbow,Warbow,SharpshooterBow,GaleBow,ElvenLongbow,ArcaneBow,HawksTalon,LongbowsBow,";
$ProjRestrictions[LightQuarrel] = "RepeaterCrossbow,SiegeCrossbow,StormRepeater,DragonboneCrossbow,";
$ProjRestrictions[HeavyQuarrel] = "RepeaterCrossbow,SiegeCrossbow,StormRepeater,DragonboneCrossbow,";
$ProjRestrictions[ShortQuarrel] = "RepeaterCrossbow,SiegeCrossbow,StormRepeater,DragonboneCrossbow,";
$ProjRestrictions[ExplosiveQuarrel] = "RepeaterCrossbow,SiegeCrossbow,StormRepeater,DragonboneCrossbow,";
$ProjRestrictions[StoneFeather] = ",SharpshooterBow,GaleBow,ElvenLongbow,ArcaneBow,HawksTalon,LongbowsBow,";
$ProjRestrictions[MetalFeather] = ",SharpshooterBow,GaleBow,ElvenLongbow,ArcaneBow,HawksTalon,LongbowsBow,";
$ProjRestrictions[Talon] = ",ElvenLongbow,ArcaneBow,HawksTalon,LongbowsBow,";
$ProjRestrictions[CeraphumsFeather] = ",ElvenLongbow,ArcaneBow,HawksTalon,LongbowsBow,";
$ProjRestrictions[PoisonArrow] = ",QuickshotBow,HuntingBow,ReinforcedLongbow,Warbow,SharpshooterBow,GaleBow,ArcaneBow,HawksTalon,";

function GenerateAllWeaponCosts()
{
	dbecho($dbechoMode, "GenerateAllWeaponCosts()");

	//All item costs that need to be Generated must be in a function, later called after all files have been exec'd.
	//This function, among other similar ones, is run once only in server.cs.
}

//****************************************************************************************************

function MeleeAttack(%player)
{
	dbecho($dbechoMode, "MeleeAttack(" @ %player @ ", " @ %length @ ")");

	%clientId = Player::getClient(%player);
	// attempt to get current weapon

	// get equipped weapon
	%weapon = GetEquippedWeapon(%clientId);

	if (%weapon == "")
		return;

	%length = GetRange(%weapon);
	
	if(%clientId == "")
		%clientId = 0;

	if(%clientId.sleepMode > 0)
		return;

	//==== ANTI-SPAM CHECK, CAUSE FOR SPAM UNKNOWN ==========
	//%time = getIntegerTime(true) >> 5;
	//if(%time - %clientId.lastFireTime <= $fireTimeDelay)
	//	return;
	//%clientId.lastFireTime = %time;
	//=======================================================
	// I have found that calling Player::setArmor() seems to cause the spam swing

	if($WeaponDelay[%weapon] != "") {
		if($justmeleed[%clientId])
			return;
	}
	else
		$WeaponDelay[%weapon] = GetDelay(%weapon);

	$justmeleed[%clientId] = True;
	schedule("$justmeleed["@%clientId@"]=\"\";",$WeaponDelay[%weapon]-0.11);

	$los::object = "";
	if(GameBase::getLOSinfo(%player, %length))
	{
		%target = $los::object;
		%obj = getObjectType(%target);

		if(%obj == "Player") {
			%targetClient = Player::getClient(%target);
			if (HasBonusState(%targetClient, "Parry")) {
				Client::sendMessage(%targetClient, $MsgBeige, "You parried the attack!");
				Client::sendMessage(%clientId, $MsgBeige, "You attacked " @ %targetClient @ " but they parried!");
			} else {
				GameBase::virtual($los::object, "onDamage", "", 1.0, "0 0 0", "0 0 0", "0 0 0", "torso", "front_right", %clientId, %weapon);
			}
		}
		else if(%target.isIce){
			ice::hit(%clientId,%target);
		}
	}

	PostAttack(%clientId, %weapon);
}

function ProjectileAttack(%clientId, %vel, %skipDelay, %spellIndex)
{
	dbecho($dbechoMode, "ProjectileAttack(" @ %clientId @ ", " @ %weapon @ ", " @ %vel @ ")");

	%player = Client::getOwnedObject(%clientId);
	%weapon = GetEquippedWeapon(%clientId);

	if (%weapon == "")
		return;

	//==== ANTI-SPAM CHECK, CAUSE FOR SPAM UNKNOWN ==========
	//%time = getIntegerTime(true) >> 5;
	//if(%time - %clientId.lastFireTime <= $fireTimeDelay)
	//	return;
	//%clientId.lastFireTime = %time;
	//=======================================================
	if(%clientId.sleepMode > 0)
		return;

	if (%skipDelay == True) {
		// do nothing is skip?
	} else {
		if($WeaponDelay[%weapon] != "") {
			if($justRanged[%clientId])
				return;
		}
		else
			$WeaponDelay[%weapon] = GetDelay(%weapon);

		$justRanged[%clientId] = True;
		schedule("$justRanged["@%clientId@"]=\"\";",$WeaponDelay[%weapon]-0.11);
	}

	%loadedProjectile = fetchData(%clientId, "LoadedProjectile " @ %weapon);

	if(%loadedProjectile == "") {
		if(!Player::isAiControlled(%clientId)) {
			processMenuselectrweapon(%clientId, %weapon);
		}
		return;
	}
	if(belt::hasthisstuff(%clientId, %loadedProjectile) <= 0)
		return;

	// Old "Throwing" style of projectiles
	// %zoffset = 0.44; // 0.44

	// // check if item has an image associated with it
	// %image = BeltItem::GetImage(%loadedProjectile);
	// %arrow = newObject("", "Item", %image, 1, false);
	// %arrow.owner = %clientId;
	// %arrow.delta = 1;
	// %arrow.weapon = %weapon;
	// %arrow.projectile = %loadedProjectile;
	// %arrow.spellIndex = %spellIndex;

	// if (%spellIndex != "") {
	// 	schedule("TriggerSpellEffectOnObject(" @ %arrow @ ", \"" @ %spellIndex @ "\");", 0.8, %arrow);
	// }

	// addToSet("MissionCleanup", %arrow);
  	// schedule("Item::Pop(" @ %arrow @ ");", 30, %arrow);	

	// //double-check stuff
	// $ProjectileDoubleCheck[%arrow] = True;
	// schedule("$ProjectileDoubleCheck[" @ %arrow @ "] = \"\";", 1.5, %arrow);

	// %rot = GameBase::getRotation(%clientId);
	// %newrot = (GetWord(%rot, 0) - %zoffset) @ " " @ GetWord(%rot, 1) @ " " @ GetWord(%rot, 2);

	// GameBase::setRotation(%clientId, %newrot);
	// GameBase::throw(%arrow, Client::getOwnedObject(%clientId), %vel, false);
	// GameBase::setRotation(%arrow, %rot);
	// GameBase::setRotation(%clientId, %rot);

	// BasicArrowImpact
	// new simpler and more efficient way to spawn projectiles (also gives more control on direction, rotation and how the projectile looks and acts)
	%projectile = BeltItem::GetProjectile(%loadedProjectile);
	Projectile::spawnProjectile(%projectile, GameBase::getMuzzleTransform(%player), %player, Item::getVelocity(%player));

	belt::takethisstuff(%clientId, %loadedProjectile, 1);

	// check the acount of loaded projectile, if it is less than 1 remove the LoadedProjectile
	if(belt::hasthisstuff(%clientId, %loadedProjectile) < 1)
		storeData(%clientId, "LoadedProjectile " @ %weapon, "");

	PostAttack(%clientId, %weapon);
}

function WoodAxeSwing(%player, %weapon) {
	dbecho($dbechoMode, "PickAxeSwing(" @ %player @ ", " @ %length @ ")");
	lbecho("woodaxe swing");

	%clientId = Player::getClient(%player);

	if(%clientId == "")
		%clientId = 0;

	if (%clientid.sleepMode == 1)
		return;
	else if (%clientid.sleepMode == 2)
		return;
	else if (Client::getGuiMode(%clientId) == $GuiModeInventory)
		return;

	//==== ANTI-SPAM CHECK, CAUSE FOR SPAM UNKNOWN ==========
	%time = getIntegerTime(true) >> 5;
	if(%time - %clientId.lastfiretime <= $WeaponDelay[%weapon]-0.2) {
		if(%time - %clientId.lastfiretime <= $WeaponDelay[%weapon]-0.8)
			return;
	}

	if(%time - %clientId.lastFireTime <= $fireTimeDelay)
		return;

	%clientId.lastFireTime = %time;
	//=======================================================
	// TODO: Look if we want to add WeaponEndurance here
	// WeaponEndurance(%clientId, %player, %weapon);
	$los::object = "";

	%length = GetRange(%weapon);
	if(GameBase::getLOSinfo(%player, %length)) {
		%target = $los::object;
		%obj = getObjectType(%target);
		%type = GameBase::getDataName(%target);

        if(%type == "TreeShape") {
			PlaySound(SoundHitLeather, GameBase::getPosition(%clientId));
			if(%clientid.monster) return;
			%score = tree::chop(%clientId, %player, %target);

			if(%score != "") {
				// RPG::incItemCount(%clientId, %score, 1);
				RefreshAll(%clientId);
				Client::sendMessage(%clientId, 0, "You found " @ %score.description @ ".");

				// %newflag = useskill(%clientId, $SkillWoodCutting, True, True);
			}
			// else
				// %newflag = useskill(%clientId, $SkillWoodCutting, False, True);	
		}
		else if(%type == "EvilTree" || %type == "EvilTreeBig") {
			PlaySound(SoundHitLeather, GameBase::getPosition(%clientId));
			if(%clientid.monster) return;
			%score = EvilTree::chop(%clientId, %player, %target);

			if(%score != "") {
				RPG::incItemCount(%clientId, %score, 1);
				RefreshAll(%clientId);
				Client::sendMessage(%clientId, 0, "You found " @ %score.description @ ".");

				// %newflag = useskill(%clientId, $SkillWoodCutting, True, True);
			}
			// else
				// %newflag = useskill(%clientId, $SkillWoodCutting, False, True);	
		}
		else if(%type == "Questtree") {
			PlaySound(SoundHitLeather, GameBase::getPosition(%clientId));
			if(%clientid.monster) return;
			%score = tree::questchop(%clientId, %player, %target);

			if(%score != "") {
				// RPG::incItemCount(%clientId, %score, 1);
				RefreshAll(%clientId);
				Client::sendMessage(%clientId, 0, "You cut out a " @ %score.description @ " from the overgrown tree.");
				%newflag = useskill(%clientId, $SkillWoodCutting, True, True);
			}
		}
		else if(%type == "PlantTwo") {
			bush::hit(%target);
		}
		else if($buildinglist[%target, "HP"] > 0 && $buildinglist[%target, "team"] != client::getfteam(%clientid)) {
			building::hit(%target);
		}
		else if($buildinglist[%target, "HP"] > 0 && $buildinglist[%target, "team"] == client::getfteam(%clientid)) {
			building::teamhit(%target, %clientId, "hatchet");
		}

		if(%obj == "Player")
			GameBase::virtual(%target, "onDamage", "", 1.0, "0 0 0", "0 0 0", "0 0 0", "torso", "front_right", %clientId, %weapon);
	}

	PostAttack(%clientId, %weapon);
}

function ThrowItem(%clientId, %item, %vel) {
	dbecho($dbechoMode, "ThrowItem(" @ %clientId @ ", " @ %item @ ", " @ %vel @ ")");

	if($beltitem[%item, "isThrowable"] != True) {
		Client::sendMessage(%clientId, $MsgRed, "You cannot throw that item.");
		return;
	}

	if(%clientId.sleepMode > 0) {
		Client::sendMessage(%clientId, $MsgRed, "You cannot throw items while sleeping.");
		return;
	}

	if(belt::hasthisstuff(%clientId, %item) <= 0) {
		Client::sendMessage(%clientId, $MsgRed, "You do not have any " @ $beltItem[%item, "Name"] @ " in your belt.");
		return;
	}

	%zoffset = 0.44; // 0.44
	%image = BeltItem::GetImage(%item);
	%thrownObject = newObject("", "Item", %image, 1, false);
	%thrownObject.owner = %clientId;
	%thrownObject.name = %item;

	addToSet("MissionCleanup", %thrownObject);

	if ($beltitem[%item, "isDetonatable"] == True) {
		%explosion = $beltitem[%thrownObject.name, "explosion"];
		%spellIndex = $beltitem[%thrownObject.name, "spellIndex"];
		schedule("DetonateItem(" @ %thrownObject @ ", " @ %explosion @ ", " @ %spellIndex @ ");", 3, %thrownObject);
	}

	%rot = GameBase::getRotation(%clientId);
	%newrot = (GetWord(%rot, 0) - %zoffset) @ " " @ GetWord(%rot, 1) @ " " @ GetWord(%rot, 2);

	GameBase::setRotation(%clientId, %newrot);
	GameBase::throw(%thrownObject, Client::getOwnedObject(%clientId), %vel, false);
	GameBase::setRotation(%thrownObject, %rot);
	GameBase::setRotation(%clientId, %rot);

	belt::takethisstuff(%clientId, %item, 1);

	Client::sendMessage(%clientId, $MsgWhite, "You throw a " @ $beltItem[%item, "Name"] @ ". [have " @ belt::hasthisstuff(%clientId, %item) @ "]");

	return %thrownObject;
}

function PickAxeSwing(%player, %length, %weapon)
{
	dbecho($dbechoMode, "PickAxeSwing(" @ %player @ ", " @ %length @ ")");

	%clientId = Player::getClient(%player);
	if(%clientId == "")
		%clientId = 0;

	//==== ANTI-SPAM CHECK, CAUSE FOR SPAM UNKNOWN ==========
	//%time = getIntegerTime(true) >> 5;
	//if(%time - %clientId.lastFireTime <= $fireTimeDelay)
	//	return;
	//%clientId.lastFireTime = %time;
	//=======================================================
	if($WeaponDelay[%weapon] != ""){
		if($justmeleed[%clientId])
			return;
	}
	else
		$WeaponDelay[%weapon] = GetDelay(%weapon);
	$justmeleed[%clientId] = True;
	schedule("$justmeleed["@%clientId@"]=\"\";",$WeaponDelay[%weapon]-0.11);

	$los::object = "";
	if(GameBase::getLOSinfo(%player, %length))
	{
		%target = $los::object;
		%obj = getObjectType(%target);
		%type = GameBase::getDataName(%target);

		if(%type == "Crystal")
		{
			%brflag = String::findSubStr(fetchData(%clientId, "RACE"), "Human");	//must be human to mine
			if(Vector::getDistance(%clientId.lastMinePos, GameBase::getPosition(%clientId)) > 1.0 && %brflag != -1)
			{
				playSound(SoundHitore, GameBase::getPosition(%target));	//vectrex, modified by JI

				%score = DoRandomMining(%clientId, %target);
				if(%score != "")
				{
					givethisstuff(%clientId, %score@" 1");
					RefreshAll(%clientId);
					%desc = %score.description;
					if(%desc == False){
						%desc = $beltitem[%score, "Name"];
						%beltTag = " ["@getDisp($beltitem[%score, "Type"])@", have "@belt::hasthisstuff(%clientId, %score)@"]";
					}
					Client::sendMessage(%clientId, 0, "You found " @ %desc @ "." @ %beltTag);

					if( floor(getRandom() * 10) == 5)
						%clientId.lastMinePos = GameBase::getPosition(%clientId);
				}
				UseSkill(%clientId, $SkillMining, True, True);
			}
			else
				playSound(SoundHitore2, GameBase::getPosition(%target));
		}
		else if(%target.isIce){
			ice::hit(%clientId,%target);
		}
		else if(%obj == "Player")
			GameBase::virtual(%target, "onDamage", "", 1.0, "0 0 0", "0 0 0", "0 0 0", "torso", "front_right", %clientId, %weapon);
	}

	PostAttack(%clientId, %weapon);
}
function ice::hit(%client, %target){
	if(%target < 1)
		return;
	deleteobject(%target);
}

function PostAttack(%clientId, %weapon)
{
	dbecho($dbechoMode, "PostAttack(" @ %clientId @ ", " @ %weapon @ ")");

	if($postAttackGraphBar)
	{
		%t = GetDelay(%weapon);
		%ticks = 30;
		%chunks = 10;

		%chunklen = floor(%ticks / %chunks);
		%d = %t / %chunks;

		for(%i = 0; %i <= %chunks; %i++)
			schedule("bottomprint(" @ %clientId @ ", \" \" @ String::create(\"*\", " @ %ticks @ " - (" @ %chunklen @ " * " @ %i @ ")) @ \"\", " @ %d @ " + 0.25);", %d * %i);
	}

	if(%weapon == CastingBlade)
	{
		%x = floor(%clientId.castingBladeBeat);
		if(%x != 0)
		{
			if(%x == 1)
				playSound(MClip5, GameBase::getPosition(%clientId));
			else if(%x == 2)
				playSound(MClip6, GameBase::getPosition(%clientId));
		}

		%x++;
		if(%x > 2) %x = 1;

		%clientId.castingBladeBeat = %x;
	}
}

function DoRandomMining(%clientId, %crystal)
{
	dbecho($dbechoMode, "DoRandomMining(" @ %clientId @ ", " @ %crystal @ ")");

	%lastscore = "";
	for(%i = 1; $ItemList[Mining, %i] != ""; %i++)
	{
		%w1 = GetWord($ItemList[Mining, %i], 1) - %crystal.bonus[%i];
		%n = Cap( (%w1 * getRandom()) + (%w1 / 2), 0, %w1);
		%r = 1 + ($PlayerSkill[%clientId, $SkillMining] * (1/10)) * getRandom();

		if(%n > %r)
			return %lastscore;

		%lastscore = GetWord($ItemList[Mining, %i], 0);
	}
	return %lastscore;
}

function GetRange(%weapon)
{
	dbecho($dbechoMode, "GetRange(" @ %weapon @ ")");

	%minRange = 2.0;
	if($WeaponRange[%weapon] != "")
		return %minRange + $WeaponRange[%weapon];
	else
		return %minRange + $RangeTable[$AccessoryVar[%weapon, $AccessoryType]];
}

function GetDelay(%weapon)
{
	dbecho($dbechoMode, "GetDelay(" @ %weapon @ ")");

	if($WeaponDelay[%weapon] != "")
		return $WeaponDelay[%weapon];
	else
	{
		%a = 3.0;
		%b = Cap($AccessoryVar[%weapon, $Weight] / %a, 1.0, "inf");
		%c = %b * $DelayFactorTable[$AccessoryVar[%weapon, $AccessoryType]];
		return %c;
	}
}

function GenerateItemCost(%item)
{
	dbecho($dbechoMode, "GenerateItemCost(" @ %item @ ")");

	if($HardcodedItemCost[%item] != "")
		return $HardcodedItemCost[%item];

	%cft = $CostFactorTable[$AccessoryVar[%item, $AccessoryType]];
	%a = GetDelay(%item);

	if(floor(%a) == 0)
		%a = 1.0;

	%b6 = AddItemSpecificPoints(%item, "6") * 1.2;	//ATK
	%b7 = AddItemSpecificPoints(%item, "7") / 3;	//DEF / 6
	%b3 = AddItemSpecificPoints(%item, "3") / 3;	//MDEF / 6

	// %extracost = 0;
	// for(%i = 1; $SmithCombo[%i] != ""; %i++) {
	// 	for(%j = 0; (%w = GetWord($SmithComboResult[%i], %j)) != -1; %j+=2) {
	// 		if(String::ICompare(%item, %w) == 0) {
	// 			%n = GetWord($SmithComboResult[%i], %j+1);
	// 			for(%k = 0; (%w2 = GetWord($SmithCombo[%i], %k)) != -1; %k+=2) {
	// 				%n2 = GetWord($SmithCombo[%i], %k+1);
	// 				%extracost += (GenerateItemCost(%w2) * %n2);
	// 			}
	// 			%extracost *= %n;
	// 			break;
	// 		}
	// 	}
	// 	if(%extracost > 0)
	// 		break;
	// }
	// %extracost = %extracost * ($ResalePercentage / 100);
	
	%c = (%b6 + %b7 + %b3) / %a;
	%d = Cap(0.01 * pow(%c, 3.7), 0, "inf");
	%e = Cap(%d * %cft, 1, "inf");
	//%f = floor(%e + %extracost);
	%f = floor(%e / 10) + 1; // divided by 10 here (LongBow)

	return %f;
}


// WeaponDelays
// swords historyically weighed about 3 - 5 lbs
// the largest two handed weapons rarely weighed more than 10 lbs, so..
// sword: firetime of 1.5, will weigh 4.5 lbs
// two handed swords / axes: firetime of 3, weighs about 9 lbs
$WeaponDelay[Dagger] = 1.0;
$WeaponDelay[Katana] = 1.25;
$WeaponDelay[Sword] = 1.50;
$WeaponDelay[HandAxe] = 1.75;
$WeaponDelay[Mace] = 2;
$WeaponDelay[Polearm] = 2.25;
$WeaponDelay[Axe] = 2.5;
$WeaponDelay[Hammer] = 2.75;
$WeaponDelay[GreatSword] = 3.0;
$WeaponDelay[GreatHammer] = 3.25;
$WeaponDelay[GreatAxe] = 3.5;

$WeaponDelay[CrossBow] = 3;
$WeaponDelay[RepeatingCrossbow] = 0.5;
$WeaponDelay[ShortBow] = 1;
$WeaponDelay[LongBow] = 2;

//****************************************************************************************************
//   CASTING BLADE
//****************************************************************************************************

ItemImageData CastingBladeImage
{
	shapeFile  = "smallObject"; // quarterstaff / smallObject
	mountPoint = 0;

	weaponType = 0;
	reloadTime = 0;	
	fireTime = $WeaponDelay[GreatSword];
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = NoSound;
	sfxActivate = NoSound;
};
ItemData CastingBlade
{
	heading = "bWeapons";
	description = "Casting Blade";
	className = "Weapon";
	shapeFile  = "smallObject";
	hudIcon = "dagger";
	shadowDetailMask = 4;
	imageType = CastingBladeImage;
	price = 0;
	showWeaponBar = true;
};
function CastingBladeImage::onFire(%player, %slot)
{
	%clientId = Player::getClient(%player);
	if(%clientId == "")
		%clientId = 0;

//	if(Player::isAIcontrolled(%clientId))
//	{
//		if(fetchData(%clientId, "HP") <= (fetchData(%clientId, "MaxHP")/3))
//		{
//			if( floor(getRandom() * 10) > 7 )
//				%doHealSpell = True;
//		}
//	}
//	if(%doHealSpell)
//		%index = GetBestSpell(%clientId, -1, True);
//	else

	// %index = GetBestSpell(%clientId, 1, True);
	%index = GetBestSpellNew(%clientId);
	//lbecho("Best spell: " @ $Spell::keyword[%index]);

	// lbecho("Spell Index found " @ %index);

	%length = $Spell::LOSrange[%index] - 1;

	$los::object = "";
	if(GameBase::getLOSinfo(%player, %length) && %index != -1 && fetchData(%clientId, "SpellCastStep") == "") {
		%closest = 500000;
		%b = $AImaxRange * 2;
		%set = newObject("set", SimSet);
		%n = containerBoxFillSet(%set, $SimPlayerObjectType, $los::position, %b, %b, %b, 0);

		for(%i = 0; %i < Group::objectCount(%set); %i++) {
			%id = Player::getClient(Group::getObject(%set, %i));

			if(GameBase::getTeam(%id) != %aiTeam && !fetchData(%id, "invisible") && %id != %clientId) {
				%dist = Vector::getDistance($los::position, GameBase::getPosition(%id));

				if(%dist < %closest) {
					%closest = %dist;
					%closestId = %id;
				}
			}
		}

		deleteObject(%set);

		// lbecho("found target");
		//%obj = getObjectType($los::object);
		//lbecho("Object type found " @ %obj);
		//lbecho($los::position);
		//if(%obj == "Player")
		//{
			if(Player::isAiControlled(%clientId)) {
				// lbecho("New AI directive added");
				AI::newDirectiveRemove(fetchData(%clientId, "BotInfoAiName"), 99);
			}
			// lbecho("Casting spell " @ $Spell::keyword[%index]);
			// lbecho("AI is casting " @ $Spell::keyword[%index]);
			//Client::sendMessage(%closestId, $MsgRed, "AI is casting " @ $Spell::keyword[%index] @ " on you.");
			internalSay(%clientId, 0, "#cast " @ $Spell::keyword[%index]);
			// lbecho("set bot shooting at " @ %closestId @ " to " @ %clientId);
			$BotShootingAt_WithId[%closestId] = %clientId;
			%hasCast = True;
		//}
	}

	if(!%hasCast)
	{
		if(OddsAre(3))
			MeleeAttack(%player, 1, CastingBlade);	//mimic the hatchet range
	}
	%hasCast = "";
}

//****************************************************************************************************
//   WAND
//****************************************************************************************************

ItemImageData WandImage
{
	shapeFile  = "force"; // dagger
	mountPoint = 0;

	weaponType = 0;
	reloadTime = 0;
	fireTime = $WeaponDelay[Dagger];
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = NoSound;
	sfxActivate = NoSound;
};

ItemData Wand
{
	heading = "bWeapons";
	description = "Wand";
	className = "Weapon";
	shapeFile  = "force";
	hudIcon = "dagger";
	shadowDetailMask = 4;
	imageType = WandImage;
	price = 0;
	showWeaponBar = true;
};

function WandImage::onFire(%player, %slot)
{
	%clientId = Player::getClient(%player);
	if(%clientId == "")
		%clientId = 0;

	internalSay(%clientId, 0, "#cast fireball");

	// %index = GetBestSpell(%clientId, 1, True);

	// %length = $Spell::LOSrange[%index]-1;
		
	// $los::object = "";
	// if(GameBase::getLOSinfo(%player, %length) && %index != -1)
	// {
	// 	%obj = getObjectType($los::object);
	// 	if(%obj == "Player")
	// 	{
	// 		if(Player::isAiControlled(%clientId))
	// 		{
	// 			AI::newDirectiveRemove(fetchData(%clientId, "BotInfoAiName"), 99);
	// 		}
	// 		internalSay(%clientId, 0, "#cast " @ $Spell::keyword[%index]);
	// 		%hasCast = True;
	// 	}
	// }
	// if(!%hasCast)
	// {
	// 	if(OddsAre(3))
	// 		MeleeAttack(%player, GetRange(Hatchet), CastingBlade);	//mimic the hatchet range
	// }
	// %hasCast = "";
}

//====== "Projectiles" ======================================================

ItemData SmallRock
{
	description = "Small Rock";
	className = "Projectile";
	shapeFile = "little_rock";
	heading = "xAmmunition";
	shadowDetailMask = 4;
	price = 0;
};

ItemData Arrow
{
	description = "Arrow";
	className = "Projectile";
	shapeFile = "tracer";
	heading = "xAmmunition";
	shadowDetailMask = 4;
	price = 0;
};

ItemData Quarrel
{
	description = "Quarrel";
	className = "Projectile";
	shapeFile = "bullet";
	heading = "xAmmunition";
	shadowDetailMask = 4;
	price = 0;
};

//===========================================================================================
//=================================                    ======================================
//=================================   SHARED WEAPONS   ======================================
//=================================                    ======================================
//===========================================================================================
// Rather than having an Item defined for each Weapon, we can simple re-use the same Item/Image data for all weapons
// Many weapons share the same model, so we only need to define one shared weapons data for each indiviual model

// ===============================
// OLD WEAPON IMAGES
// ===============================

// SWORD - Broad Sword image
ItemImageData SwordImage
{
	shapeFile  = "sword";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = $WeaponDelay[Sword];
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing5;
	sfxActivate = AxeSlash2;
};
ItemData Sword
{
	heading = "bWeapons";
	description = "Sword";
	className = "Weapon";
	shapeFile  = "sword";
	hudIcon = "blaster";
	shadowDetailMask = 4;
	imageType = SwordImage;
	price = 0;
	showWeaponBar = true;
};
function SwordImage::onFire(%player, %slot) {
	MeleeAttack(%player);
}

// HATCHET - Hatchet Image (hand axe)
ItemImageData HatchetImage
{
	shapeFile  = "hatchet";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = $WeaponDelay[HandAxe];
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing1;
	sfxActivate = AxeSlash2;
};
ItemData Hatchet
{
	heading = "bWeapons";
	description = "Hatchet";
	className = "Weapon";
	shapeFile  = "hatchet";
	hudIcon = "axe";
	shadowDetailMask = 4;
	imageType = HatchetImage;
	price = 0;
	showWeaponBar = true;
};
function HatchetImage::onFire(%player, %slot) {
	MeleeAttack(%player);
}

// WOOD AXE - Hatchet Image (hand axe)
ItemImageData WoodAxeImage
{
	shapeFile  = "hatchet";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = $WeaponDelay[HandAxe];
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing1;
	sfxActivate = AxeSlash2;
};
ItemData WoodAxe
{
	heading = "bWeapons";
	description = "Wood Axe";
	className = "Weapon";
	shapeFile  = "hatchet";
	hudIcon = "axe";
	shadowDetailMask = 4;
	imageType = WoodAxeImage;
	price = 0;
	showWeaponBar = true;
};

function WoodAxeImage::onFire(%player, %slot)
{
	// %clientId = Player::getClient(%player);
	// if(%clientId == -1)
	// 	item::pop(%player);
	WoodAxeSwing(%player, WoodAxe);
}

// AXE (War Axe Image)
ItemImageData AxeImage
{
	shapeFile  = "axe";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = $WeaponDelay[Axe];
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing3;
	sfxActivate = AxeSlash2;
};
ItemData Axe
{
	heading = "bWeapons";
	description = "War Axe";
	className = "Weapon";
	shapeFile  = "axe";
	hudIcon = "axe";
	shadowDetailMask = 4;
	imageType = AxeImage;
	price = 0;
	showWeaponBar = true;
};
function AxeImage::onFire(%player, %slot) {
	MeleeAttack(%player);
}

// LONG SWORD
ItemImageData LongswordImage
{
	shapeFile  = "long_sword";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = $WeaponDelay[Sword];
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing6;
	sfxActivate = AxeSlash2;
};
ItemData Longsword
{
	heading = "bWeapons";
	description = "Long Sword";
	className = "Weapon";
	shapeFile  = "long_sword";
	hudIcon = "blaster";
	shadowDetailMask = 4;
	imageType = LongswordImage;
	price = 0;
	showWeaponBar = true;
};
function LongswordImage::onFire(%player, %slot) {
	MeleeAttack(%player);
}

// BATTLE AXE
ItemImageData BattleAxeImage
{
	shapeFile  = "BattleAxe";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = $WeaponDelay[GreatAxe];
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing7;
	sfxActivate = AxeSlash2;
};
ItemData BattleAxe
{
	heading = "bWeapons";
	description = "Battle Axe";
	className = "Weapon";
	shapeFile  = "BattleAxe";
	hudIcon = "axe";
	shadowDetailMask = 4;
	imageType = BattleAxeImage;
	price = 0;
	showWeaponBar = true;
};
function BattleAxeImage::onFire(%player, %slot) {
	MeleeAttack(%player);
}

// ELFIN BLADE - KeldriniteLS
ItemImageData ElfinBladeImage
{
	shapeFile  = "elfinblade";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = $WeaponDelay[Katana];
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing2;
	sfxActivate = ActivateAS;
};
ItemData ElfinBlade
{
	heading = "bWeapons";
	description = "Elfin Blade";
	className = "Weapon";
	shapeFile  = "elfinblade";
	hudIcon = "blaster";
	shadowDetailMask = 4;
	imageType = ElfinBladeImage;
	price = 0;
	showWeaponBar = true;
};
function ElfinBladeImage::onFire(%player, %slot) {
	MeleeAttack(%player);
}

// MACE - Club 
ItemImageData MaceImage
{
	shapeFile  = "mace";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = $WeaponDelay[Mace];
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing5;
	sfxActivate = AxeSlash2;
};
ItemData Mace
{
	heading = "bWeapons";
	description = "Mace";
	className = "Weapon";
	shapeFile  = "mace";
	hudIcon = "club";
	shadowDetailMask = 4;
	imageType = MaceImage;
	price = 0;
	showWeaponBar = true;
};
function MaceImage::onFire(%player, %slot) {
	MeleeAttack(%player);
}

// QUARTER STAFF
ItemImageData QuarterStaffImage
{
	shapeFile  = "quarterstaff";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = $WeaponDelay[Polearm];
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing3;
	sfxActivate = AxeSlash2;
};
ItemData QuarterStaff
{
	heading = "bWeapons";
	description = "Quarter Staff";
	className = "Weapon";
	shapeFile  = "quarterstaff";
	hudIcon = "spear";
	shadowDetailMask = 4;
	imageType = QuarterStaffImage;
	price = 0;
	showWeaponBar = true;
};
function QuarterStaffImage::onFire(%player, %slot) {
	MeleeAttack(%player);
}

// PICK
ItemImageData PickImage
{
	shapeFile = "Pick";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 2;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing1;
	sfxActivate = CrossbowSwitch1;
};
ItemData Pick
{
	heading = "bWeapons";
	description = "Pick";
	className = "Weapon";
	shapeFile = "Pick";
	hudIcon = "pick";
	shadowDetailMask = 4;
	imageType = PickImage;
	price = 0;
	showWeaponBar = true;
};
function PickImage::onFire(%player, %slot) {
	PickAxeSwing(%player);
}

// LONG STAFF
ItemImageData LongStaffImage
{
	shapeFile  = "longstaff";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = $WeaponDelay[Polearm];
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing3;
	sfxActivate = AxeSlash2;
};
ItemData LongStaff
{
	heading = "bWeapons";
	description = "Long Staff";
	className = "Weapon";
	shapeFile  = "longstaff";
	hudIcon = "spear";
	shadowDetailMask = 4;
	imageType = LongStaffImage;
	price = 0;
	showWeaponBar = true;
};
function LongStaffImage::onFire(%player, %slot) {
	MeleeAttack(%player);
}

// HAMMER - War Hammer image
ItemImageData HammerImage
{
	shapeFile  = "hammer";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = $WeaponDelay[GreatHammer];
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing6;
	sfxActivate = AxeSlash2;
};
ItemData Hammer
{
	heading = "bWeapons";
	description = "Hammer";
	className = "Weapon";
	shapeFile  = "hammer";
	hudIcon = "hammer";
	shadowDetailMask = 4;
	imageType = HammerImage;
	price = 0;
	showWeaponBar = true;
};
function HammerImage::onFire(%player, %slot) {
	MeleeAttack(%player);
}

// DAGGER
ItemImageData DaggerImage
{
	shapeFile  = "dagger";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = $WeaponDelay[Dagger];
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing1;
	sfxActivate = AxeSlash2;
};
ItemData Dagger
{
	heading = "bWeapons";
	description = "Dagger";
	className = "Weapon";
	shapeFile  = "dagger";
	hudIcon = "dagger";
	shadowDetailMask = 4;
	imageType = DaggerImage;
	price = 0;
	showWeaponBar = true;
};
function DaggerImage::onFire(%player, %slot) {
	MeleeAttack(%player);
}

// SHORT SWORD
ItemImageData ShortswordImage
{
	shapeFile  = "short_sword";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = $WeaponDelay[Katana];
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing2;
	sfxActivate = AxeSlash2;
};
ItemData Shortsword
{
	heading = "bWeapons";
	description = "Short Sword";
	className = "Weapon";
	shapeFile  = "short_sword";
	hudIcon = "blaster";
	shadowDetailMask = 4;
	imageType = ShortswordImage;
	price = 0;
	showWeaponBar = true;
};
function ShortswordImage::onFire(%player, %slot) {
	MeleeAttack(%player);
}

// SPEAR
ItemImageData SpearImage
{
	shapeFile  = "spear";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = $WeaponDelay[Polearm];
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing3;
	sfxActivate = AxeSlash2;
};
ItemData Spear
{
	heading = "bWeapons";
	description = "Spear";
	className = "Weapon";
	shapeFile  = "spear";
	hudIcon = "spear";
	shadowDetailMask = 4;
	imageType = SpearImage;
	price = 0;
	showWeaponBar = true;
};
function SpearImage::onFire(%player, %slot) {
	MeleeAttack(%player);
}

// TRIDENT
ItemImageData TridentImage
{
	shapeFile  = "trident";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = $WeaponDelay[Polearm];
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing3;
	sfxActivate = AxeSlash2;
};
ItemData Trident
{
	heading = "bWeapons";
	description = "Trident";
	className = "Weapon";
	shapeFile  = "trident";
	hudIcon = "trident";
	shadowDetailMask = 4;
	imageType = TridentImage;
	price = 0;
	showWeaponBar = true;
};
function TridentImage::onFire(%player, %slot)
{
	MeleeAttack(%player);
}

// KATANA
ItemImageData KatanaImage
{
	shapeFile  = "katana";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = $WeaponDelay[Katana];
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing3;
	sfxActivate = AxeSlash2;
};
ItemData Katana
{
	heading = "bWeapons";
	description = "Rapier";
	className = "Weapon";
	shapeFile  = "katana";
	hudIcon = "katana";
	shadowDetailMask = 4;
	imageType = KatanaImage;
	price = 0;
	showWeaponBar = true;
};
function KatanaImage::onFire(%player, %slot) {
	MeleeAttack(%player);
}

// CROSSBOW
ItemImageData CrossbowImage
{
	shapeFile = "crossbow";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	ammoType = "";
	//projectileType = NoProjectile;
	accuFire = false;
	reloadTime = 0;
	fireTime = $WeaponDelay[CrossBow];

	lightType = 3;  // Weapon Fire
	lightRadius = 3;
	lightTime = 1;
	lightColor = { 0.6, 1, 1.0 };

	sfxFire = CrossbowShoot1;
	sfxActivate = CrossbowSwitch1;
	sfxReload = NoSound;
};
ItemData Crossbow
{
	description = "Crossbow";
	className = "Weapon";
	shapeFile = "crossbow";
	hudIcon = "grenade";
	heading = "bWeapons";
	shadowDetailMask = 4;
	imageType = CrossbowImage;
	price = 0;
	showWeaponBar = true;
};
function CrossbowImage::onFire(%player, %slot) {
	%clientId = Player::getClient(%player);
	%vel = 100;

	ProjectileAttack(%clientId, %vel);
}

// REPEATING CROSSBOW
ItemImageData RepeatingCrossbowImage
{
	shapeFile = "crossbow";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	ammoType = "";
	//projectileType = NoProjectile;
	accuFire = false;
	reloadTime = 0;
	fireTime = $WeaponDelay[RepeatingCrossbow];

	lightType = 3;  // Weapon Fire
	lightRadius = 3;
	lightTime = 1;
	lightColor = { 0.6, 1, 1.0 };

	sfxFire = CrossbowShoot1;
	sfxActivate = CrossbowSwitch1;
	sfxReload = NoSound;
};
ItemData RepeatingCrossbow
{
	description = "Crossbow";
	className = "Weapon";
	shapeFile = "crossbow";
	hudIcon = "grenade";
	heading = "bWeapons";
	shadowDetailMask = 4;
	imageType = RepeatingCrossbowImage;
	price = 0;
	showWeaponBar = true;
};
function RepeatingCrossbowImage::onFire(%player, %slot) {
	%clientId = Player::getClient(%player);
	%vel = 100;

	ProjectileAttack(%clientId, %vel);
}

// LONGBOW
ItemImageData LongBowImage
{
	shapeFile = "longbow";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	ammoType = "";
	//projectileType = NoProjectile;
	accuFire = false;
	reloadTime = 0;
	fireTime = $WeaponDelay[LongBow];

	lightType = 3;  // Weapon Fire
	lightRadius = 3;
	lightTime = 1;
	lightColor = { 0.6, 1, 1.0 };

	sfxFire = SoundSwing4;
	sfxActivate = CrossbowSwitch1;
	sfxReload = NoSound;
};
ItemData LongBow
{
	description = "Long Bow";
	className = "Weapon";
	shapeFile = "longbow";
	hudIcon = "bow";
	heading = "bWeapons";
	shadowDetailMask = 4;
	imageType = LongBowImage;
	price = 0;
	showWeaponBar = true;
};
function LongBowImage::onFire(%player, %slot) {
	%clientId = Player::getClient(%player);
	%vel = 100;
	ProjectileAttack(%clientId, %vel);
}

// COMPOSITE BOW
ItemImageData CompositeBowImage
{
	shapeFile = "comp_bow";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	ammoType = "";
	//projectileType = NoProjectile;
	accuFire = false;
	reloadTime = 0;
	fireTime = $WeaponDelay[LongBow];

	lightType = 3;  // Weapon Fire
	lightRadius = 3;
	lightTime = 1;
	lightColor = { 0.6, 1, 1.0 };

	sfxFire = SoundSwing4;
	sfxActivate = CrossbowSwitch1;
	sfxReload = NoSound;
};

ItemData CompositeBow
{
	description = "Composite Bow";
	className = "Weapon";
	shapeFile = "comp_bow";
	hudIcon = "bow";
	heading = "bWeapons";
	shadowDetailMask = 4;
	imageType = CompositeBowImage;
	price = 0;
	showWeaponBar = true;
};
function CompositeBowImage::onFire(%player, %slot) {
	%clientId = Player::getClient(%player);
	%vel = 100;

	ProjectileAttack(%clientId, %vel);
}

// COMPOSITE BOW FAST
ItemImageData CompositeBowFastImage
{
	shapeFile = "comp_bow";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	ammoType = "";
	//projectileType = NoProjectile;
	accuFire = false;
	reloadTime = 0;
	fireTime = $WeaponDelay[ShortBow];

	lightType = 3;  // Weapon Fire
	lightRadius = 3;
	lightTime = 1;
	lightColor = { 0.6, 1, 1.0 };

	sfxFire = CrossbowShoot1;
	sfxActivate = CrossbowSwitch1;
	sfxReload = NoSound;
};

ItemData CompositeBowFast
{
	description = "Composite Bow";
	className = "Weapon";
	shapeFile = "comp_bow";
	hudIcon = "bow";
	heading = "bWeapons";
	shadowDetailMask = 4;
	imageType = CompositeBowFastImage;
	price = 0;
	showWeaponBar = true;
};
function CompositeBowFastImage::onFire(%player, %slot) {
	%clientId = Player::getClient(%player);
	%vel = 100;

	ProjectileAttack(%clientId, %vel);
}

// ================================
// NEW WEAPON IMAGES
// ================================

// BROAD SWORD - New sword image
ItemImageData BroadSwordImage
{
	shapeFile  = "broadsword";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = $WeaponDelay[Sword];
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing5;
	sfxActivate = AxeSlash2;
};
ItemData BroadSword
{
	heading = "bWeapons";
	description = "Sword";
	className = "Weapon";
	shapeFile  = "sword";
	hudIcon = "blaster";
	shadowDetailMask = 4;
	imageType = BroadSwordImage;
	price = 0;
	showWeaponBar = true;
};
function BroadSwordImage::onFire(%player, %slot) {
	MeleeAttack(%player);
}

// GLADIUS - Short, fat stubby blade, with a stabby action. Honestly looks kinda weird?
ItemImageData GladiusImage
{
	shapeFile  = "gladius";
	mountPoint = 0;

	weaponType = 0;
	reloadTime = 0;
	fireTime = $WeaponDelay[Sword];
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing5;
	sfxActivate = AxeSlash2;
};
ItemData Gladius
{
	heading = "bWeapons";
	description = "Gladius";
	className = "Weapon";
	shapeFile  = "gladius";
	hudIcon = "blaster";
	shadowDetailMask = 4;
	imageType = GladiusImage;
	price = 0;
	showWeaponBar = true;
};
function GladiusImage::onFire(%player, %slot) {
	MeleeAttack(%player);
}

// CRIM AXE - Savage looking large hand axe or small baxe
ItemImageData BattleAxeNewImage
{
	shapeFile  = "CRIMAXE2";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = $WeaponDelay[GreatAxe];
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing7;
	sfxActivate = AxeSlash2;

	mountOffset = {0, 0, -0.5};
};
ItemData BattleAxeNew
{
	heading = "bWeapons";
	description = "Battle Axe new";
	className = "Weapon";
	shapeFile  = "CRIMAXE2";
	hudIcon = "axe";
	shadowDetailMask = 4;
	imageType = BattleAxeNewImage;
	price = 0;
	showWeaponBar = true;
};
function BattleAxeNewImage::onFire(%player, %slot) {
	MeleeAttack(%player);
}

// GOLIATH SWORD
ItemImageData GoliathSwordImage
{
	shapeFile  = "goliathsword";
	mountPoint = 0;

	weaponType = 0;
	reloadTime = 0;
	fireTime = $WeaponDelay[GreatSword];
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing5;
	sfxActivate = AxeSlash2;
};
ItemData GoliathSword
{
	heading = "bWeapons";
	description = "GoliathSword";
	className = "Weapon";
	shapeFile  = "goliathsword";
	hudIcon = "blaster";
	shadowDetailMask = 4;
	imageType = GoliathSwordImage;
	price = 0;
	showWeaponBar = true;
};
function GoliathSwordImage::onFire(%player, %slot) {
	MeleeAttack(%player);
}

// GREEN SWORD
ItemImageData GreenSwordImage
{
	shapeFile  = "greensword";
	mountPoint = 0;

	weaponType = 0;
	reloadTime = 0;
	fireTime = $WeaponDelay[Sword];
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing5;
	sfxActivate = AxeSlash2;
};
ItemData GreenSword
{
	heading = "bWeapons";
	description = "GreenSword";
	className = "Weapon";
	shapeFile  = "greensword";
	hudIcon = "blaster";
	shadowDetailMask = 4;
	imageType = GreenSwordImage;
	price = 0;
	showWeaponBar = true;
};
function GreenSwordImage::onFire(%player, %slot) {
	MeleeAttack(%player);
}

// GEM SWORD
ItemImageData GemSwordImage
{
	shapeFile  = "long_sword2";
	mountPoint = 0;

	weaponType = 0;
	reloadTime = 0;
	fireTime = $WeaponDelay[Sword];
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing5;
	sfxActivate = AxeSlash2;

	lightType = 2; // 2
	lightRadius = 5;
	lightTime = 1; // 1
	lightColor = { 0.1, 1, 0.1 }; // { 1, 0.35, 0.21 }; // { r, g, b }, and it kicks in and out unless you use liogh
};
ItemData GemSword
{
	heading = "bWeapons";
	description = "GemSword";
	className = "Weapon";
	shapeFile  = "long_sword2";
	hudIcon = "blaster";
	shadowDetailMask = 4;
	imageType = GemSwordImage;
	price = 0;
	showWeaponBar = true;
};
function GemSwordImage::onFire(%player, %slot) {
	MeleeAttack(%player);
}


// ItemImageData GemSwordFireImage
// {
// 	shapeFile  = "long_sword2";
// 	mountPoint = 0;

// 	weaponType = 0;
// 	reloadTime = 0;
// 	fireTime = GetDelay(Broadsword);
// 	minEnergy = 0;
// 	maxEnergy = 0;

// 	accuFire = true;

// 	sfxFire = SoundSwing5;
// 	sfxActivate = AxeSlash2;

// 	// lightType = 2; // 2
// 	// lightRadius = 5;
// 	// lightTime = 1; // 1
// 	// lightColor = { 0.1, 1, 0.1 }; // { 1, 0.35, 0.21 }; // { r, g, b }, and it kicks in and out unless you use liogh
// };
// ItemData GemSwordFire
// {
// 	heading = "bWeapons";
// 	description = "GemSwordFire";
// 	className = "Weapon";
// 	shapeFile  = "long_sword2";
// 	hudIcon = "blaster";
// 	shadowDetailMask = 4;
// 	imageType = GemSwordFireImage;
// 	price = 0;
// 	showWeaponBar = true;
// };
// function GemSwordFireImage::onFire(%player, %slot) {
// 	MeleeAttack(%player);
// }

// SPIKED MACE
ItemImageData SpikedMaceImage
{
	shapeFile  = "mace2";
	mountPoint = 0;

	weaponType = 0;
	reloadTime = 0;
	fireTime = $WeaponDelay[Mace];
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing5;
	sfxActivate = AxeSlash2;
};
ItemData SpikedMace
{
	heading = "bWeapons";
	description = "SpikedMace";
	className = "Weapon";
	shapeFile  = "mace2";
	hudIcon = "blaster";
	shadowDetailMask = 4;
	imageType = SpikedMaceImage;
	price = 0;
	showWeaponBar = true;
};
function SpikedMaceImage::onFire(%player, %slot) {
	MeleeAttack(%player);
}

// BONE SWORD
ItemImageData BoneSwordImage
{
	shapeFile  = "PBONESWORD";
	mountPoint = 0;

	weaponType = 0;
	reloadTime = 0;
	fireTime = $WeaponDelay[Sword];
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing5;
	sfxActivate = AxeSlash2;
};
ItemData BoneSword
{
	heading = "bWeapons";
	description = "BoneSword";
	className = "Weapon";
	shapeFile  = "PBONESWORD";
	hudIcon = "blaster";
	shadowDetailMask = 4;
	imageType = BoneSwordImage;
	price = 0;
	showWeaponBar = true;
};
function BoneSwordImage::onFire(%player, %slot) {
	MeleeAttack(%player);
}

// PHENS SWORD
ItemImageData PhensSwordImage
{
	shapeFile  = "phenssword";
	mountPoint = 0;

	weaponType = 0;
	reloadTime = 0;
	fireTime = $WeaponDelay[Sword];
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing5;
	sfxActivate = AxeSlash2;
};
ItemData PhensSword
{
	heading = "bWeapons";
	description = "PhensSword";
	className = "Weapon";
	shapeFile  = "phenssword";
	hudIcon = "blaster";
	shadowDetailMask = 4;
	imageType = PhensSwordImage;
	price = 0;
	showWeaponBar = true;
};
function PhensSwordImage::onFire(%player, %slot) {
	MeleeAttack(%player);
}

// SLASHER
ItemImageData SlasherImage
{
	shapeFile  = "slasher";
	mountPoint = 0;

	weaponType = 0;
	reloadTime = 0;
	fireTime = $WeaponDelay[Katana];
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing5;
	sfxActivate = AxeSlash2;
};
ItemData Slasher
{
	heading = "bWeapons";
	description = "Slasher";
	className = "Weapon";
	shapeFile  = "phenssword";
	hudIcon = "blaster";
	shadowDetailMask = 4;
	imageType = SlasherImage;
	price = 0;
	showWeaponBar = true;
};
function SlasherImage::onFire(%player, %slot) {
	MeleeAttack(%player);
}

// JAVELIN
ItemImageData JavelinImage
{
	shapeFile  = "spear2";
	mountPoint = 0;

	weaponType = 0;
	reloadTime = 0;
	fireTime = $WeaponDelay[Polearm];
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing5;
	sfxActivate = AxeSlash2;
};
ItemData Javelin
{
	heading = "bWeapons";
	description = "Javelin";
	className = "Weapon";
	shapeFile  = "spear2";
	hudIcon = "blaster";
	shadowDetailMask = 4;
	imageType = JavelinImage;
	price = 0;
	showWeaponBar = true;
};
function JavelinImage::onFire(%player, %slot) {
	MeleeAttack(%player);
}

// SPIKED CLUB
ItemImageData SpikedClubImage
{
	shapeFile  = "SpikedClub";
	mountPoint = 0;

	weaponType = 0;
	reloadTime = 0;
	fireTime = $WeaponDelay[Mace];
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing5;
	sfxActivate = AxeSlash2;
};
ItemData SpikedClub
{
	heading = "bWeapons";
	description = "SpikedClub";
	className = "Weapon";
	shapeFile  = "SpikedClub";
	hudIcon = "blaster";
	shadowDetailMask = 4;
	imageType = SpikedClubImage;
	price = 0;
	showWeaponBar = true;
};
function SpikedClubImage::onFire(%player, %slot) {
	MeleeAttack(%player);
}

// CLUB
ItemImageData ClubImage
{
	shapeFile  = "club";
	mountPoint = 0;

	weaponType = 0;
	reloadTime = 0;
	fireTime = $WeaponDelay[Mace];
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing5;
	sfxActivate = AxeSlash2;
};
ItemData Club
{
	heading = "bWeapons";
	description = "Club";
	className = "Weapon";
	shapeFile  = "club";
	hudIcon = "blaster";
	shadowDetailMask = 4;
	imageType = ClubImage;
	price = 0;
	showWeaponBar = true;
};
function ClubImage::onFire(%player, %slot) {
	MeleeAttack(%player);
}

// ======================
// Ranged
// ======================
ItemImageData SlingImage
{
	shapeFile = "sling";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	ammoType = "";
	//projectileType = NoProjectile;
	accuFire = false;
	reloadTime = 0;
	fireTime = $WeaponDelay[LongBow];

	lightType = 3;  // Weapon Fire
	lightRadius = 3;
	lightTime = 1;
	lightColor = { 0.6, 1, 1.0 };

	sfxFire = CrossbowShoot1;
	sfxActivate = CrossbowSwitch1;
	sfxReload = NoSound;
};
ItemData Sling
{
	description = "Sling";
	className = "Weapon";
	shapeFile = "sling";
	hudIcon = "bow";
	heading = "bWeapons";
	shadowDetailMask = 4;
	imageType = SlingImage;
	price = 0;
	showWeaponBar = true;
};
function SlingImage::onFire(%player, %slot) {
	ProjectileAttack(Player::getClient(%player), 100);
}

// ======================
// Admin Weapons
// ======================
// CLUB
ItemImageData CandyCaneImage
{
	shapeFile  = "CANDYCANER";
	mountPoint = 0;

	weaponType = 0;
	reloadTime = 0;
	fireTime = $WeaponDelay[Katana];
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing5;
	sfxActivate = AxeSlash2;
};
ItemData CandyCane
{
	heading = "bWeapons";
	description = "CandyCane";
	className = "Weapon";
	shapeFile  = "CANDYCANER";
	hudIcon = "blaster";
	shadowDetailMask = 4;
	imageType = CandyCaneImage;
	price = 0;
	showWeaponBar = true;
};
function CandyCaneImage::onFire(%player, %slot) {
	MeleeAttack(%player);
}

ItemImageData PistolImage
{
	shapeFile = "pistol";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	ammoType = "";
	//projectileType = NoProjectile;
	accuFire = false;
	reloadTime = 0;
	fireTime = 1;

	lightType = 3;  // Weapon Fire
	lightRadius = 3;
	lightTime = 1;
	lightColor = { 0.6, 1, 1.0 };

	// maybe change sound?
	sfxFire = CrossbowShoot1;
	sfxActivate = CrossbowSwitch1;
	sfxReload = NoSound;
};
ItemData Pistol
{
	description = "Pistol";
	className = "Weapon";
	shapeFile = "pistol";
	hudIcon = "bow";
	heading = "bWeapons";
	shadowDetailMask = 4;
	imageType = PistolImage;
	price = 0;
	showWeaponBar = true;
};
function PistolImage::onFire(%player, %slot) {
	ProjectileAttack(Player::getClient(%player), 100);
}

ItemImageData CyborgGunImage
{
	shapeFile = "cyborggun";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	ammoType = "";
	//projectileType = NoProjectile;
	accuFire = false;
	reloadTime = 0;
	fireTime = 1;

	lightType = 3;  // Weapon Fire
	lightRadius = 3;
	lightTime = 1;
	lightColor = { 0.6, 1, 1.0 };

	// maybe change sound?
	sfxFire = CrossbowShoot1;
	sfxActivate = CrossbowSwitch1;
	sfxReload = NoSound;
};

ItemData CyborgGun
{
	description = "CyborgGun";
	className = "Weapon";
	shapeFile = "cyborggun";
	hudIcon = "bow";
	heading = "bWeapons";
	shadowDetailMask = 4;
	imageType = CyborgGunImage;
	price = 0;
	showWeaponBar = true;
};
function CyborgGunImage::onFire(%player, %slot) {
	ProjectileAttack(Player::getClient(%player), 100);
}

ItemImageData UnarmedImage
{
	shapeFile  = "smallObject"; // blood1
	mountPoint = 0; // 0 mouth/hand, 1 head, 2 bottom?

	weaponType = 0;
	reloadTime = 0;
	fireTime = $WeaponDelay[Dagger];
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing5; // change this mabe?
	sfxActivate = AxeSlash2; // change this mabe?
};
ItemData Unarmed
{
	heading = "bWeapons";
	description = "";
	className = "Weapon";
	shapeFile  = "smallObject"; // blood1
	hudIcon = "blaster";
	shadowDetailMask = 4;
	imageType = UnarmedImage;
	price = 0;
	showWeaponBar = true;
};
function UnarmedImage::onFire(%player, %slot) {
	MeleeAttack(%player);
}

ItemImageData UnarmedFastImage
{
	shapeFile  = "smallObject"; // blood1
	mountPoint = 0; // 0 mouth/hand, 1 head, 2 bottom?

	weaponType = 0;
	reloadTime = 0;
	fireTime = $WeaponDelay[Dagger];
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing5; // change this mabe?
	sfxActivate = AxeSlash2; // change this mabe?
};
ItemData UnarmedFast
{
	heading = "bWeapons";
	description = "";
	className = "Weapon";
	shapeFile  = "smallObject"; // blood1
	hudIcon = "blaster";
	shadowDetailMask = 4;
	imageType = UnarmedFastImage;
	price = 0;
	showWeaponBar = true;
};
function UnarmedFastImage::onFire(%player, %slot) {
	MeleeAttack(%player);
}