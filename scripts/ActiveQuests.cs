// Active quest events (admin-triggered)

// Goblin Attack on Kalm
function ActiveQuests::InitGoblinAttackKalm() {
	if($ActiveQuest::GoblinAttackKalm::Initialized)
		return;

	$ActiveQuest::GoblinAttackKalm::Initialized = True;
	$ActiveQuest::GoblinAttackKalm::Active = False;
	$ActiveQuest::GoblinAttackKalm::SpawnInterval = 10;
	$ActiveQuest::GoblinAttackKalm::Duration = 300;

	$ActiveQuest::GoblinAttackKalm::SpawnCount = 35;
	$ActiveQuest::GoblinAttackKalm::SpawnPos[0] = "-2358.63 -294.659 65.0922";
	$ActiveQuest::GoblinAttackKalm::SpawnPos[1] = "-2362.35 -290.545 65.0922";
	$ActiveQuest::GoblinAttackKalm::SpawnPos[2] = "-2370.28 -281.784 65.0922";
	$ActiveQuest::GoblinAttackKalm::SpawnPos[3] = "-2377.32 -273.929 65.0923";
	$ActiveQuest::GoblinAttackKalm::SpawnPos[4] = "-2386.66 -268.705 65.0923";
	$ActiveQuest::GoblinAttackKalm::SpawnPos[5] = "-2397.89 -264.281 65.0923";
	$ActiveQuest::GoblinAttackKalm::SpawnPos[6] = "-2406.44 -259.108 65.0923";
	$ActiveQuest::GoblinAttackKalm::SpawnPos[7] = "-2413.27 -252.398 65.0923";
	$ActiveQuest::GoblinAttackKalm::SpawnPos[8] = "-2417.97 -245.54 65.0923";
	$ActiveQuest::GoblinAttackKalm::SpawnPos[9] = "-2412.35 -238.666 65.0923";
	$ActiveQuest::GoblinAttackKalm::SpawnPos[10] = "-2404.38 -231.743 65.0923";
	$ActiveQuest::GoblinAttackKalm::SpawnPos[11] = "-2407.16 -222.161 65.0923";
	$ActiveQuest::GoblinAttackKalm::SpawnPos[12] = "-2417.83 -219.532 65.0923";
	$ActiveQuest::GoblinAttackKalm::SpawnPos[13] = "-2435.43 -234.801 65.0923";
	$ActiveQuest::GoblinAttackKalm::SpawnPos[14] = "-2450.25 -248.396 65.0923";
	$ActiveQuest::GoblinAttackKalm::SpawnPos[15] = "-2451.9 -259.323 65.0923";
	$ActiveQuest::GoblinAttackKalm::SpawnPos[16] = "-2448.84 -271.79 65.0923";
	$ActiveQuest::GoblinAttackKalm::SpawnPos[17] = "-2441.93 -280.204 65.0923";
	$ActiveQuest::GoblinAttackKalm::SpawnPos[18] = "-2434.67 -288.754 65.0923";
	$ActiveQuest::GoblinAttackKalm::SpawnPos[19] = "-2427.82 -296.814 65.0923";
	$ActiveQuest::GoblinAttackKalm::SpawnPos[20] = "-2420.5 -305.291 65.0923";
	$ActiveQuest::GoblinAttackKalm::SpawnPos[21] = "-2411.99 -311.648 65.0923";
	$ActiveQuest::GoblinAttackKalm::SpawnPos[22] = "-2400.87 -302.767 65.0923";
	$ActiveQuest::GoblinAttackKalm::SpawnPos[23] = "-2392.06 -295.304 65.0923";
	$ActiveQuest::GoblinAttackKalm::SpawnPos[24] = "-2381.67 -286.236 65.0923";
	$ActiveQuest::GoblinAttackKalm::SpawnPos[25] = "-2370.4 -261.76 65.0002";
	$ActiveQuest::GoblinAttackKalm::SpawnPos[26] = "-2378.86 -257.685 65.0002";
	$ActiveQuest::GoblinAttackKalm::SpawnPos[27] = "-2390.91 -258.152 65.0002";
	$ActiveQuest::GoblinAttackKalm::SpawnPos[28] = "-2420.23 -268.611 65.0002";
	$ActiveQuest::GoblinAttackKalm::SpawnPos[29] = "-2430.36 -276.341 65.0002";
	$ActiveQuest::GoblinAttackKalm::SpawnPos[30] = "-2432.91 -286.809 65.0923";
	$ActiveQuest::GoblinAttackKalm::SpawnPos[31] = "-2427.72 -281.638 65.0923";
	$ActiveQuest::GoblinAttackKalm::SpawnPos[32] = "-2417.28 -272.167 65.0923";
	$ActiveQuest::GoblinAttackKalm::SpawnPos[33] = "-2411.41 -279.939 65.0923";
	$ActiveQuest::GoblinAttackKalm::SpawnPos[34] = "-2400.61 -279.153 65.0002";

	$ActiveQuest::GoblinAttackKalm::MobCount = 4;
	$ActiveQuest::GoblinAttackKalm::MobType[0] = "EliteGoblinRunt";
	$ActiveQuest::GoblinAttackKalm::MobType[1] = "EliteGoblinThief";
	$ActiveQuest::GoblinAttackKalm::MobType[2] = "EliteGoblinWizard";
	$ActiveQuest::GoblinAttackKalm::MobType[3] = "EliteGoblinRaider";
}

function ActiveQuests::RandomGoblinName() {
	%names = $RaceToNamesList[Goblin];
	%count = getWordCount(%names);
    
	if(%count <= 0)
		%name = "EliteGoblin" @ floor(GetRandom() * 100000);
	else
		%name = "EliteGoblin" @ GetWord(%names, floor(GetRandom() * %count));

	for(%i = 0; %i < 10; %i++) {
		if(NEWgetClientByName(%name) == -1)
			return %name;
		if(%count > 0)
			%name = "EliteGoblin" @ GetWord(%names, floor(GetRandom() * %count));
		else
			%name = "EliteGoblin" @ floor(GetRandom() * 100000);
	}
	return %name;
}

function ActiveQuests::StartGoblinAttackKalm(%duration, %interval) {
	ActiveQuests::InitGoblinAttackKalm();
	if($ActiveQuest::GoblinAttackKalm::Active)
		return;

	if(%duration == "" || %duration <= 0)
		%duration = $ActiveQuest::GoblinAttackKalm::Duration;
	if(%interval == "" || %interval <= 0)
		%interval = $ActiveQuest::GoblinAttackKalm::SpawnInterval;

	$ActiveQuest::GoblinAttackKalm::Duration = %duration;
	$ActiveQuest::GoblinAttackKalm::SpawnInterval = %interval;
	$ActiveQuest::GoblinAttackKalm::Active = True;
	$ActiveQuest::GoblinAttackKalm::EndTime = (getIntegerTime(true) >> 5) + %duration;

	messageAll($MsgRed, "Kalm is under attack by a goblin horde!");
	ActiveQuests::GoblinAttackKalmLoop();
}

function ActiveQuests::EndGoblinAttackKalm() {
	if(!$ActiveQuest::GoblinAttackKalm::Active)
		return;

	$ActiveQuest::GoblinAttackKalm::Active = False;
	$ActiveQuest::GoblinAttackKalm::EndTime = "";
	messageAll($MsgGreen, "The attack on Kalm by the goblin horde has subsided.");
}

function ActiveQuests::RewardGoblinAttackKalm() {
	// Reward phase placeholder (pack drops will be added later)
	messageAll($MsgGreen, "Rewards are being distributed for defending Kalm.");
}

function ActiveQuests::GoblinAttackKalmLoop() {
	if(!$ActiveQuest::GoblinAttackKalm::Active)
		return;

	%now = getIntegerTime(true) >> 5;
	if(%now >= $ActiveQuest::GoblinAttackKalm::EndTime) {
		ActiveQuests::EndGoblinAttackKalm();
		return;
	}

	%posIndex = floor(GetRandom() * $ActiveQuest::GoblinAttackKalm::SpawnCount);
	%mobIndex = floor(GetRandom() * $ActiveQuest::GoblinAttackKalm::MobCount);
	%pos = $ActiveQuest::GoblinAttackKalm::SpawnPos[%posIndex];
	%mob = $ActiveQuest::GoblinAttackKalm::MobType[%mobIndex];
	%name = ActiveQuests::RandomGoblinName();
	%team = 2;
	%loadout = "default";

	AI::helper(%mob, %name, "TempSpawn " @ %pos @ " " @ %team, %loadout);

	schedule("ActiveQuests::GoblinAttackKalmLoop();", $ActiveQuest::GoblinAttackKalm::SpawnInterval);
}
