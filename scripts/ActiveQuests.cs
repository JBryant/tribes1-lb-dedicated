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
	$ActiveQuest::GoblinAttackKalm::MobType[0] = "GoblinRunt";
	$ActiveQuest::GoblinAttackKalm::MobType[1] = "GoblinThief";
	$ActiveQuest::GoblinAttackKalm::MobType[2] = "GoblinWizard";
	$ActiveQuest::GoblinAttackKalm::MobType[3] = "GoblinRaider";
	$ActiveQuest::GoblinAttackKalm::MobList = "GoblinRunt GoblinThief GoblinWizard GoblinRaider";

	ActiveQuests::InitTownSpawns();
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
	$ActiveQuest::GoblinAttackKalm::RewardScheduled = False;
	$ActiveQuest::GoblinAttackKalm::RewardActive = False;
	$ActiveQuest::GoblinAttackKalm::RewardRemaining = "";

	ActiveQuests::StartTownRaid(
		"GoblinAttackKalm",
		"Kalm",
		$ActiveQuest::GoblinAttackKalm::MobList,
		%duration,
		%interval,
		2,
		"Kalm is under attack by a goblin horde!",
		"The attack on Kalm by the goblin horde has subsided.",
		"ActiveQuests::GoblinAttackKalmRaidEnded"
	);
}

function ActiveQuests::EndGoblinAttackKalm() {
	if(!$ActiveQuest::GoblinAttackKalm::Active)
		return;
	ActiveQuests::EndTownRaid("GoblinAttackKalm");
}

function ActiveQuests::RewardGoblinAttackKalm() {
	ActiveQuests::StartGoblinAttackKalmRewards();
}

function ActiveQuests::GoblinAttackKalmRaidEnded() {
	$ActiveQuest::GoblinAttackKalm::Active = False;

	if(!$ActiveQuest::GoblinAttackKalm::RewardScheduled) {
		$ActiveQuest::GoblinAttackKalm::RewardScheduled = True;
		messageAll($MsgGreen, "Quest rewards will begin in 60 seconds.");
		schedule("messageAll(" @ $MsgGreen @ ", \"Quest rewards will begin in 30 seconds.\");", 30);
		schedule("messageAll(" @ $MsgGreen @ ", \"Quest rewards will begin in 10 seconds.\");", 50);
		schedule("ActiveQuests::StartGoblinAttackKalmRewards();", 60);
	}
}

function ActiveQuests::StartGoblinAttackKalmRewards() {
	if($ActiveQuest::GoblinAttackKalm::RewardActive)
		return;

	$ActiveQuest::GoblinAttackKalm::RewardActive = True;
	$ActiveQuest::GoblinAttackKalm::RewardRemaining = 60;
	messageAll($MsgGreen, "Quest rewards have begun! Watch the sky over Kalm.");
	Quests::GiveGoblinHordeMedallionToEligiblePlayers();
	ActiveQuests::GoblinAttackKalmRewardLoop();
}

function ActiveQuests::GoblinAttackKalmRewardLoop() {
	if(!$ActiveQuest::GoblinAttackKalm::RewardActive)
		return;

	if($ActiveQuest::GoblinAttackKalm::RewardRemaining <= 0) {
		$ActiveQuest::GoblinAttackKalm::RewardActive = False;
		return;
	}

	%pos = RandomGoblinAttackKalmRewardPos();
	%loot = RandomEliteMobPackLoot();
	DeployLootbag(%pos, "0 0 0", "Server * " @ %loot);

	$ActiveQuest::GoblinAttackKalm::RewardRemaining--;
	schedule("ActiveQuests::GoblinAttackKalmRewardLoop();", 1);
}

function RandomGoblinAttackKalmRewardPos() {
	%posList = "-2367.96 -293.15 -2365.86 -291.043 -2363.81 -289.164 -2361.35 -287.052 -2358.76 -284.862 -2360.8 -282.407 -2362.77 -283.791 -2364.45 -285.195 -2366.42 -286.883 -2368.07 -288.456 -2369.9 -290.185 -2372.05 -291.644 -2373.7 -289.778 -2371.71 -288.039 -2369.97 -286.557 -2367.81 -284.808 -2365.63 -283.112 -2363.41 -281.458 -2361.29 -279.886 -2365.37 -279.494 -2367.58 -281.143 -2368.98 -282.33 -2370.75 -283.948 -2372.34 -285.85 -2375.37 -287.072 -2377.14 -285.047 -2375.2 -283.301 -2373.08 -281.41 -2370.37 -279.09 -2367.58 -276.799 -2365.87 -275.401 -2367.41 -273.41 -2368.66 -274.547 -2371.15 -276.796 -2373.38 -278.734 -2375.91 -280.897 -2378.67 -283.254 -2380.67 -281.018 -2378.52 -279.211 -2375.66 -276.901 -2373.08 -274.85 -2370.44 -272.753 -2371.93 -270.014 -2373.67 -271.392 -2375.83 -273.453 -2378.41 -275.717 -2381.42 -278.311 -2384.56 -281.023 -2386.43 -278.884 -2388.14 -276.985 -2386.16 -275.352 -2384.46 -273.891 -2382.04 -276.456 -2380.12 -274.592 -2378.08 -272.944 -2375.71 -270.718 -2373.37 -268.521 -2375.64 -266.753 -2377.67 -268.466 -2380.02 -270.369 -2382.16 -272.062 -2384.79 -274.138 -2390.36 -275.557 -2388.29 -273.554 -2386.08 -271.698 -2383.5 -269.502 -2380.81 -267.217 -2378.72 -265.435 -2376.34 -263.408 -2378.31 -261.333 -2380.26 -262.963 -2382.65 -264.987 -2385 -266.937 -2387.6 -269.078 -2389.72 -270.793 -2393.02 -273.478 -2394.65 -271.366 -2392.5 -269.986 -2390.42 -268.216 -2387.48 -265.749 -2384.74 -263.482 -2381.97 -261.293 -2379.71 -259.511 -2376.94 -257.334 -2377.11 -254.523 -2379.27 -256.396 -2381.45 -258.269 -2384.33 -260.696 -2387.08 -262.983 -2389.89 -265.319 -2391.85 -266.953 -2394.66 -269.289";
	%count = 92;
	%idx = floor(getRandom() * %count);
	%offset = %idx * 2;
	%x = getWord(%posList, %offset);
	%y = getWord(%posList, %offset + 1);
	return %x @ " " @ %y @ " 200";
}

function RandomEliteMobPackLoot() {
	return GenerateSpecialLoot(9999);
}

function ActiveQuests::InitTownSpawns() {
	if($ActiveQuest::Town["Kalm", "Initialized"] && $ActiveQuest::Town["Kalm", "SpawnCount"] > 0)
		return;

	$ActiveQuest::Town["Kalm", "Initialized"] = True;
	$ActiveQuest::Town["Kalm", "SpawnCount"] = $ActiveQuest::GoblinAttackKalm::SpawnCount;
	for(%i = 0; %i < $ActiveQuest::GoblinAttackKalm::SpawnCount; %i++)
		$ActiveQuest::Town["Kalm", "SpawnPos", %i] = $ActiveQuest::GoblinAttackKalm::SpawnPos[%i];
}

function ActiveQuests::ClearTownSpawns(%townName) {
	%count = $ActiveQuest::Town[%townName, "SpawnCount"];
	for(%i = 0; %i < %count; %i++)
		$ActiveQuest::Town[%townName, "SpawnPos", %i] = "";
	$ActiveQuest::Town[%townName, "SpawnCount"] = 0;
	$ActiveQuest::Town[%townName, "Initialized"] = True;
}

function ActiveQuests::AddTownSpawn(%townName, %pos) {
	%count = $ActiveQuest::Town[%townName, "SpawnCount"];
	if(%count == "")
		%count = 0;
	$ActiveQuest::Town[%townName, "SpawnPos", %count] = %pos;
	$ActiveQuest::Town[%townName, "SpawnCount"] = %count + 1;
	$ActiveQuest::Town[%townName, "Initialized"] = True;
}

function ActiveQuests::StartTownRaid(%raidName, %townName, %mobList, %duration, %interval, %team, %startMsg, %endMsg, %endCallback) {
	if(%raidName == "" || %townName == "")
		return;
	if($ActiveQuest::Raid[%raidName, "Active"])
		return;
	if(!$ActiveQuest::Town[%townName, "Initialized"])
		ActiveQuests::InitTownSpawns();
	if(String::ICompare(%townName, "Kalm") == 0) {
		if($ActiveQuest::GoblinAttackKalm::SpawnCount == "" || $ActiveQuest::GoblinAttackKalm::SpawnCount <= 0)
			ActiveQuests::InitGoblinAttackKalm();
		%spawnCount = $ActiveQuest::Town[%townName, "SpawnCount"];
		if(%spawnCount == "" || %spawnCount <= 0)
			ActiveQuests::InitTownSpawns();
	}

	if(%duration == "" || %duration <= 0)
		%duration = 300;
	if(%interval == "" || %interval <= 0)
		%interval = 10;
	if(%team == "" || %team == -1)
		%team = 2;

	$ActiveQuest::Raid[%raidName, "Active"] = True;
	$ActiveQuest::Raid[%raidName, "Town"] = %townName;
	$ActiveQuest::Raid[%raidName, "MobList"] = %mobList;
	$ActiveQuest::Raid[%raidName, "SpawnInterval"] = %interval;
	$ActiveQuest::Raid[%raidName, "EndTime"] = (getIntegerTime(true) >> 5) + %duration;
	$ActiveQuest::Raid[%raidName, "Team"] = %team;
	$ActiveQuest::Raid[%raidName, "EndMsg"] = %endMsg;
	$ActiveQuest::Raid[%raidName, "EndCallback"] = %endCallback;

	if(String::ICompare(%townName, "Kalm") == 0) {
		$ActiveQuest::GoblinAttackKalm::RewardScheduled = False;
		$ActiveQuest::GoblinAttackKalm::RewardActive = False;
		$ActiveQuest::GoblinAttackKalm::RewardRemaining = "";
	}

	if(%startMsg != "")
		messageAll($MsgRed, %startMsg);

	schedule("ActiveQuests::TownRaidLoop(\"" @ %raidName @ "\");", 0);
}

function ActiveQuests::EndTownRaid(%raidName) {
	if(!$ActiveQuest::Raid[%raidName, "Active"])
		return;

	$ActiveQuest::Raid[%raidName, "Active"] = False;
	$ActiveQuest::Raid[%raidName, "EndTime"] = "";

	%town = $ActiveQuest::Raid[%raidName, "Town"];

	%endMsg = $ActiveQuest::Raid[%raidName, "EndMsg"];
	if(%endMsg != "")
		messageAll($MsgGreen, %endMsg);

	%endCallback = $ActiveQuest::Raid[%raidName, "EndCallback"];
	if(%endCallback != "")
		schedule(%endCallback @ "();", 0);

	if(String::ICompare(%town, "Kalm") == 0 && String::ICompare(%endCallback, "ActiveQuests::GoblinAttackKalmRaidEnded") != 0)
		ActiveQuests::GoblinAttackKalmRaidEnded();
}

function ActiveQuests::TownRaidLoop(%raidName) {
	if(!$ActiveQuest::Raid[%raidName, "Active"])
		return;

	%now = getIntegerTime(true) >> 5;
	if(%now >= $ActiveQuest::Raid[%raidName, "EndTime"]) {
		ActiveQuests::EndTownRaid(%raidName);
		return;
	}

	%town = $ActiveQuest::Raid[%raidName, "Town"];
	%spawnCount = $ActiveQuest::Town[%town, "SpawnCount"];
	if(%spawnCount <= 0) {
		ActiveQuests::EndTownRaid(%raidName);
		return;
	}

	%mobList = $ActiveQuest::Raid[%raidName, "MobList"];
	%mobCount = getWordCount(%mobList);
	if(%mobCount <= 0) {
		schedule("ActiveQuests::TownRaidLoop(\"" @ %raidName @ "\");", $ActiveQuest::Raid[%raidName, "SpawnInterval"]);
		return;
	}

	%pos = $ActiveQuest::Town[%town, "SpawnPos", floor(getRandom() * %spawnCount)];
	%mob = getWord(%mobList, floor(getRandom() * %mobCount));
	%name = ActiveQuests::RandomRaidDisplayName(%mob);
	%team = $ActiveQuest::Raid[%raidName, "Team"];

	AI::helper(%mob, %name, "TempSpawn " @ %pos @ " " @ %team, "default");

	schedule("ActiveQuests::TownRaidLoop(\"" @ %raidName @ "\");", $ActiveQuest::Raid[%raidName, "SpawnInterval"]);
}

function ActiveQuests::RandomRaidDisplayName(%mobType) {
	%race = $NameForRace[%mobType];
	%names = $RaceToNamesList[%race];
	%count = getWordCount(%names);

	%elitePrefix = "";
	if(String::findSubStr(%mobType, "Elite") == 0)
		%elitePrefix = "Elite";

	if(%race == "")
		%race = %mobType;

	if(%count > 0)
		%baseName = %race @ GetWord(%names, floor(getRandom() * %count));
	else
		%baseName = %race @ floor(getRandom() * 100000);

	%name = %elitePrefix @ %baseName;
	for(%i = 0; %i < 10; %i++) {
		if(NEWgetClientByName(%name) == -1)
			return %name;
		if(%count > 0)
			%baseName = %race @ GetWord(%names, floor(getRandom() * %count));
		else
			%baseName = %race @ floor(getRandom() * 100000);
		%name = %elitePrefix @ %baseName;
	}
	return %name;
}
