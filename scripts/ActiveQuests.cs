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
	$ActiveQuest::GoblinAttackKalm::MobList = "EliteGoblinRunt EliteGoblinThief EliteGoblinWizard EliteGoblinRaider";

	ActiveQuests::InitTownSpawns();
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
	// Reward bounds (four corners)
	%x1 = -2361.34; %y1 = -280.924;
	%x2 = -2372.3;  %y2 = -291.231;
	%x3 = -2392.63; %y3 = -267.974;
	%x4 = -2380.87; %y4 = -257.924;

	%minX = %x1; %maxX = %x1;
	if(%x2 < %minX) %minX = %x2; if(%x2 > %maxX) %maxX = %x2;
	if(%x3 < %minX) %minX = %x3; if(%x3 > %maxX) %maxX = %x3;
	if(%x4 < %minX) %minX = %x4; if(%x4 > %maxX) %maxX = %x4;

	%minY = %y1; %maxY = %y1;
	if(%y2 < %minY) %minY = %y2; if(%y2 > %maxY) %maxY = %y2;
	if(%y3 < %minY) %minY = %y3; if(%y3 > %maxY) %maxY = %y3;
	if(%y4 < %minY) %minY = %y4; if(%y4 > %maxY) %maxY = %y4;

	%x = %minX + (getRandom() * (%maxX - %minX));
	%y = %minY + (getRandom() * (%maxY - %minY));
	%z = 80;
	return %x @ " " @ %y @ " " @ %z;
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
