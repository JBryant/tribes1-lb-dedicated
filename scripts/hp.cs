function setHP(%clientId, %val, %lckCost)
{
	dbecho($dbechoMode, "setHP(" @ %clientId @ ", " @ %val @ ")");

	%armor = Player::getArmor(%clientId);

	if(%val < 0)
		%val = 0;
	if(%val == "")
		%val = fetchData(%clientId, "MaxHP");

	%a = %val * %armor.maxDamage; // maxDamage is usually just 1.0
	%b = %a / fetchData(%clientId, "MaxHP");
	%c = %armor.maxDamage - %b;

	if(%c < 0)
		%c = 0;
	else if(%c > %armor.maxDamage)
		%c = %armor.maxDamage;

	if(%c == %armor.maxDamage && !IsStillArenaFighting(%clientId))
	{
		%lck = 1;
		if(%lckCost != "")
			%lck = %lckCost;

		storeData(%clientId, "LCK", %lck, "dec");

		if(fetchData(%clientId, "LCK") >= 0)
		{
			Client::sendMessage(%clientId, $MsgRed, "You have permanently lost an LCK point!");

			if(fetchData(%clientId, "LCKconsequence") == "miss")
			{
				%c = GameBase::getDamageLevel(Client::getOwnedObject(%clientId));
				%val = -1;
			}
		}
	}

	GameBase::setDamageLevel(Client::getOwnedObject(%clientId), %c);

	return %val;
}

function refreshHP(%clientId, %value)
{
	dbecho($dbechoMode, "refreshHP(" @ %clientId @ ", " @ %value @ ")");

	return setHP(%clientId, fetchData(%clientId, "HP") - round(%value * $TribesDamageToNumericDamage));
}

$healingSkillRegenModifier = 0.01; // was 0.10 then 0.01

function getHealthRegenPerSecond(%clientId)
{
	// base hp per second (100 -> 1 hp per second, 1000 -> 10 hp per second)
	%healingPerSecond = $PlayerSkill[%clientId, $SkillHealing] * $healingSkillRegenModifier;
	%hpPerSecond = AddPoints(%clientId, 10);

	return round(%healingPerSecond + %hpPerSecond);
}

// updated function to use HP/Second as that is much easier to understand for players -LB
function refreshHPREGEN(%clientId)
{
	if(%clientId.sleepMode == 1)
		%b = 1.0;
	else if(%clientId.sleepMode == 2)
		%b = 0; // meditation
	else
		%b = 0;

	// get health regen per second and divide by max HP to get the recharge rate
	%c = getHealthRegenPerSecond(%clientId) / fetchData(%clientId, "MaxHP");
	%r = %b + %c;

	GameBase::setAutoRepairRate(Client::getOwnedObject(%clientId), %r);
}

// old regen HP function, way too poweful at end game
// function refreshHPREGEN(%clientId)
// {
// 	dbecho($dbechoMode, "refreshHPREGEN(" @ %clientId @ ")");

// 	%a = $PlayerSkill[%clientId, $SkillHealing] / 250000;

// 	if(%clientId.sleepMode == 1)
// 		%b = %a + 0.0200;
// 	else if(%clientId.sleepMode == 2)
// 		%b = %a;
// 	else
// 		%b = %a;

// 	%c = AddPoints(%clientId, 10) / 2000;
// 	%r = %b + %c;

// 	GameBase::setAutoRepairRate(Client::getOwnedObject(%clientId), %r);
// }