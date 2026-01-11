// =====================
// QUEST DEFINITIONS
// =====================

// IDs as numbers are fine; no need to also store $Quest::id[1] = "1";
$Quest::name[1] = "Helping Your Elders";
$Quest::desc[1] = "Speak to the village elder to begin your journey.";
$Quest::npcId[1] = 1;
$Quest::type[1] = 0; // 0 one-time per remort | 1 repeatable | 2 daily | 3 weekly | 4 one-time ever

$Quest::stepName[1, 0] = "Help out the Elder";
$Quest::stepName[1, 1] = "Find a Chipped Dagger";
$Quest::stepName[1, 2] = "Find a Quartz";

$Quest::stepDescription[1, 0] = "Word around town is that the Town Elder needs help. Speak to him to find out more.";
$Quest::stepDescription[1, 1] = "Elder Thalos has asked you to find a Chipped Dagger. Search the mines to the South-East over the bridge.";
$Quest::stepDescription[1, 2] = "A piece of Quartz is needed to complete the Elder's request. Find it in the same mine where you found the Chipped Dagger.";

// Requirements to ACCEPT quest (step 0 gate)
$Quest::stepReq[1, 0] = "LVLG 4"; // LVLG = level greater than or equal to 4, also LVLS = level less than or equal to X and LVLE = level equal to X
$Quest::stepReq[1, 1] = "ChippedDagger 1";
$Quest::stepReq[1, 2] = "Quartz 1";

// Rewards for completing the quest
$Quest::stepReward[1, 0] = "";
$Quest::stepReward[1, 1] = "EXP 1000";
$Quest::stepReward[1, 2] = "EXP 2000";

$QuestNPC::name[1] = "Elder Thalos";
$QuestNPC::shape[1] = "MaleHumanTownBot";
$QuestNPC::pos[1] = "-2369.98 -292.01 65.0002";
$QuestNPC::rot[1] = "0 -0 0.389879";
$QuestNPC::questId[1] = 1;

// Conversations:
// [npcId, questId, step, meetsRequirements, dialogueNumber]
// step 0 = not accepted yet (accept gate)
// step 1..N = player is on that step
$QuestNPC::conversations[1, 1, 0, 0, 0] = "Greetings, traveler. I need someone to help me with a task. But you are not ready yet.|Oh, okay...";
$QuestNPC::conversations[1, 1, 0, 0, 1] = "Come back when you have more experience under your belt.|Sure thing pal.";
$QuestNPC::conversations[1, 1, 0, 1, 0] = "Greetings, traveler. Can you bring me a Chipped Dagger?|Where can I find one?";
$QuestNPC::conversations[1, 1, 0, 1, 1] = "You can find them on goblins in the mines to the East over the bridge.|Wait, why should I help you?";
$QuestNPC::conversations[1, 1, 0, 1, 2] = "Bring me back that dagger and I'll make it worth your while.|I guess I can do that.";

$QuestNPC::conversations[1, 1, 1, 0, 0] = "Have you found the Chipped Dagger yet?|Uhh... yes?";
$QuestNPC::conversations[1, 1, 1, 0, 1] = "Seems not. Well Come back when you have it.|Fine";
$QuestNPC::conversations[1, 1, 1, 1, 0] = "Ahh, a Chipped Dagger. Excellent! Now, I need you to bring me a piece of Quartz?|A piece of court?";
$QuestNPC::conversations[1, 1, 1, 1, 1] = "No, Quartz! It's shiny and... well nevermind. You can find Quartz in the same mine from you just came from.|I like shiny.";
$QuestNPC::conversations[1, 1, 1, 1, 2] = "Yesss... Bring me back that \"shiny\" Quartz and I can help make you a new weapon.|This better be worth it.";

$QuestNPC::conversations[1, 1, 2, 0, 0] = "Have you found the Quartz yet?|I have not gone to court yet.";
$QuestNPC::conversations[1, 1, 2, 0, 1] = "*He stares blankly at you for a moment* Just - come back with the Quartz...|Aww, your no fun!";
$QuestNPC::conversations[1, 1, 2, 1, 0] = "Wonderful, you have found the Quartz! Now just give it to me.|Yay!";
$QuestNPC::conversations[1, 1, 2, 1, 1] = "Here's a shiny new weapon for your efforts!|Ooh, shiny!";

$QuestNPC::conversations[1, 1, 3, 1, 0] = "How is that new weapon treating you?|It's still shiny!";
$QuestNPC::conversations[1, 1, 3, 1, 1] = "I'm glad you like it! Keep it safe... and shiny!|I will!";

// quest 2 - spider fangs
$Quest::name[2] = "Creepy Crawlers";
$Quest::desc[2] = "Collect spider materials for Researcher Arin.";
$Quest::npcId[2] = 2;
$Quest::type[2] = 0;

$Quest::stepName[2, 0] = "Help out the Researcher";
$Quest::stepName[2, 1] = "Retrieve 5 Spider Fangs";
$Quest::stepName[2, 2] = "Retrieve 5 Spider Venom";

$Quest::stepDescription[2, 0] = "Researcher Arin needs your help collecting spider materials. Speak to him to find out more.";
$Quest::stepDescription[2, 1] = "Researcher Arin has asked you to collect 5 Spider Fangs. You can find them on spiders in the caves of the Burial Tree.";
$Quest::stepDescription[2, 2] = "Researcher Arin also needs 5 Spider Venom. Collect them from the stronger spiders in the caves of the Burial Tree.";

$Quest::stepReq[2, 0] = "";
$Quest::stepReq[2, 1] = "SpiderFang 5";
$Quest::stepReq[2, 2] = "SpiderVenom 5";

$Quest::stepReward[2, 0] = "";
$Quest::stepReward[2, 1] = "EXP 1000";
$Quest::stepReward[2, 2] = "EXP 2000 PoisonMateriaI";

$QuestNPC::name[2] = "Researcher Arin";
$QuestNPC::shape[2] = "MaleHumanTownBot";
$QuestNPC::pos[2] = "-2833.05 -1181.97 701.008";
$QuestNPC::rot[2] = "0 -0 -1.56603";
$QuestNPC::questId[2] = 2;

// =====================
// STEP 0 — ACCEPT QUEST
// =====================
$QuestNPC::conversations[2, 2, 0, 0, 0] =
  "Ah-! Oh. Sorry. I didn't hear you approach. Are you... brave? Or at least *reckless*?|What are you talking about?";
$QuestNPC::conversations[2, 2, 0, 0, 1] =
  "The spiders nesting in the Burial Tree have begun showing signs of magical infusion. Fascinating! Terrifying! Mostly fascinating.|That sounds dangerous.";
$QuestNPC::conversations[2, 2, 0, 0, 2] =
  "Dangerous, yes. Which is why *you* will be collecting the samples. I'll take notes from a safe distance. First, I need 5 Spider Fangs.|I can handle that.";

$QuestNPC::conversations[2, 2, 0, 1, 0] =
  "Ah-! Oh. Sorry. I didn't hear you approach. Are you... brave? Or at least *reckless*?|What are you talking about?";
$QuestNPC::conversations[2, 2, 0, 1, 1] =
  "The spiders nesting in the Burial Tree have begun showing signs of magical infusion. Fascinating! Terrifying! Mostly fascinating.|That sounds dangerous.";
$QuestNPC::conversations[2, 2, 0, 1, 2] =
  "Dangerous, yes. Which is why *you* will be collecting the samples. I'll take notes from a safe distance. First, I need 5 Spider Fangs.|I can handle that.";

// =====================
// STEP 1 — SPIDER FANGS
// =====================
$QuestNPC::conversations[2, 2, 1, 0, 0] =
  "Any luck with the Spider Fangs? I've been sketching theories while you were gone.|Not yet.";
$QuestNPC::conversations[2, 2, 1, 0, 1] =
  "No worries - research is patient. Try not to get bitten. Or webbed. Or eaten.|I'll try.";

$QuestNPC::conversations[2, 2, 1, 1, 0] =
  "Marvelous! These fangs are resonating with residual magic. Do you feel that hum?|I think so?";
$QuestNPC::conversations[2, 2, 1, 1, 1] =
  "Excellent. Now for the trickier part. I need 5 samples of Spider Venom. The stronger specimens below should have it.|Of course they do.";

// =====================
// STEP 2 — SPIDER VENOM
// =====================
$QuestNPC::conversations[2, 2, 2, 0, 0] =
  "You're back! Please tell me you have the venom - and that you still have all your limbs.|Not yet.";
$QuestNPC::conversations[2, 2, 2, 0, 1] =
  "Ah... well. I'll prepare the containment vials. Slowly. Carefully.|I'll be back.";

$QuestNPC::conversations[2, 2, 2, 1, 0] =
  "Incredible! The venom is pulsing with arcane energy! Oh, don't worry, it's *probably* stable.|Here you go.";
$QuestNPC::conversations[2, 2, 2, 1, 1] =
  "You've been an enormous help. As promised, here's something... interesting I found while studying the area.|What is it?";
$QuestNPC::conversations[2, 2, 2, 1, 2] =
  "If my calculations are correct, I believe this is Poison Materia. It could retain some of the spiders' properties.|Thank you.";

// =====================
// STEP 3 — COMPLETED CHATTER
// =====================
$QuestNPC::conversations[2, 2, 3, 1, 0] =
  "That Poison Materia should retain some of the spiders' properties. Handle it carefully - it tends to... linger.|I'll keep that in mind.";
$QuestNPC::conversations[2, 2, 3, 1, 1] =
  "If more creatures start glowing, hissing, or whispering at you - do let me know.|That's... reassuring.";

// =====================
// QUEST INITIALIZATION
// =====================
$QuestBotList = "";

function InitQuests() {
    %questBotId = 1;

    while($QuestNPC::name[%questBotId] != "") {
        %name = $QuestNPC::name[%questBotId];
        %questbot = newObject("", "StaticShape", $QuestNPC::shape[%questBotId], true);

        addToSet("MissionCleanup", %questbot);

        GameBase::setMapName(%questbot, %name);
        GameBase::setPosition(%questbot, $QuestNPC::pos[%questBotId]);
        GameBase::setRotation(%questbot, $QuestNPC::rot[%questBotId]);
        GameBase::setTeam(%questbot, $BotInfo[%name, TEAM]);
        GameBase::playSequence(%questbot, 0, "root");	//thanks Adger!!

        Client::setSkin(%questbot, "RMSkins1");

        %questbot.name = "QuestBot" @ %questBotId;
        %questbot.botId = %questBotId;
		$BotInfo[%questbot.name, NAME] = $QuestNPC::name[%questBotId];
        $QuestBotList = $QuestBotList @ %questbot @ " ";
        %questBotId++;
    }
}

function bottalk::QuestBot(%clientId, %object, %initTalk, %message) {
	%botId = %object.botId;
	%questId = $QuestNPC::questId[%botId];

	%step = 0;
	%data = Quests::GetData(%clientId, %questId);

	%state = 0;
	%savedStep = 0;

	if (%data != "") {
		%state = getWord(%data, 0);
		%savedStep = getWord(%data, 1);

		if (%savedStep == "" || %savedStep == -1)
			%savedStep = 0;

		if (%state > 0)
			%step = %savedStep;

		// If completed, show post-completion chatter step
		if (%state == 2)
			%step = Quests::GetLastStep(%questId) + 1;
	}

	%requirements = $Quest::stepReq[%questId, %step];
	%meetsRequirements = 1;

	if (%requirements != "" && !HasThisStuff(%clientId, %requirements))
		%meetsRequirements = 0;

	// Build triggers for each dialogue line
	%index = 0;
	while ($QuestNPC::conversations[%botId, %questId, %step, %meetsRequirements, %index] != "") {
		%line = $QuestNPC::conversations[%botId, %questId, %step, %meetsRequirements, %index];
		%pipePos = String::findSubStr(%line, "|");

		if (%pipePos != -1)
			%trigger[%index] = String::getSubStr(%line, %pipePos + 1, 1000);
		else
			%trigger[%index] = "next";
			%index++;
	}

	if (%initTalk) {
		$state[%object, %clientId] = 1;
		$stateIndex[%object, %clientId] = 0; // start at first line
	}
	else if ($state[%object, %clientId] != 1) {
		return;
	}
	else {
		// advance one line per trigger press
		$stateIndex[%object, %clientId] = $stateIndex[%object, %clientId] + 1;
	}

	%dialogueIndex = $stateIndex[%object, %clientId];

	// If out of lines, end conversation
	%line = $QuestNPC::conversations[%botId, %questId, %step, %meetsRequirements, %dialogueIndex];
	if (%line == "") {
		Quests::ProgressQuest(%clientId, %questId);
		$state[%object, %clientId] = "";
		$stateIndex[%object, %clientId] = "";
		return;
	}

	%pipePos = String::findSubStr(%line, "|");
	if (%pipePos != -1) {
		%strippedMessage = String::getSubStr(%line, 0, %pipePos);
		$botMenuOption[%clientId, 0] = %trigger[%dialogueIndex];
		NewBotMessage(%clientId, %object, %strippedMessage);
	}
	else {
		// no trigger; just show message and end
		NewBotMessage(%clientId, %object, %line);
		$state[%object, %clientId] = "";
		$stateIndex[%object, %clientId] = "";
	}
}

function Quests::SaveCharacter(%clientId) {
	%list = "";
	%name = Client::getName(%clientId);

	for (%i = 0; %i < $Quest::activeCount[%clientId]; %i++) {
		%qid = $Quest::active[%clientId, %i];

		if (%qid == "")
			continue;

		// Only save if touched (state != NOT_STARTED)
		%data = Quests::GetData(%clientId, %qid); // "state step count lastDone flags"
		%state = getWord(%data, 0);

		if (%list == "")
			%list = %qid;
		else
			%list = %list @ " " @ %qid;

		$funk::var["[\"" @ %name @ "\", 10, " @ %qid @ "]"] = %data;
	}

	$funk::var["[\"" @ %name @ "\", 10, 0]"] = %list;
}

function Quests::LoadCharacter(%clientId) {
	%name = Client::getName(%clientId);
	$Quest::activeCount[%clientId] = 0;

	for (%i = 0; $Quest::active[%clientId, %i] != ""; %i++)
		$Quest::active[%clientId, %i] = "";

	%questList = $funk::var[%name, 10, 0];

	if (%questList == "")
		return;

	for (%i = 0; (%qid = getWord(%questList, %i)) != -1; %i++) {
		%data = $funk::var[%name, 10, %qid];

		if (%data == "")
			continue;

		Quests::SetData(%clientId, %qid, %data, True);
		Quests::MarkActive(%clientId, %qid);
	}
}


// [state, step, count, lastDone, flags]
function Quests::GetData(%clientId, %questId) {
	%d = $QuestPlayer::data[%clientId, %questId];

	if (%d == "") return "0 0 0 0 0";

	return %d;
}

function Quests::SetData(%clientId, %questId, %data, %skipSave) {
	$QuestPlayer::data[%clientId, %questId] = %data;

	if (!%skipSave)
		SaveCharacter(%clientId, True);
}

// Returns: 0 no change, 1 advanced, 2 completed
function Quests::ProgressQuest(%clientId, %questId) {
	%data  = Quests::GetData(%clientId, %questId); // "state step count lastDone flags"
	%state = getWord(%data, 0);
	%step  = getWord(%data, 1);
	%count = getWord(%data, 2);
	%last  = getWord(%data, 3);
	%flags = getWord(%data, 4);

	// Normalize missing/out-of-range fields (your getWord can return -1)
	if (%step  == "" || %step  == -1) %step  = 0;
	if (%count == "" || %count == -1) %count = 0;
	if (%last  == "" || %last  == -1) %last  = 0;
	if (%flags == "" || %flags == -1) %flags = 0;

	// Already completed
	if (%state == 2)
		return 0;

	// Determine which requirements apply RIGHT NOW
	// state 0 uses step 0 gate (accept gate)
	%req = $Quest::stepReq[%questId, %step];

	// If not started yet, %step should be 0.
	// If your data ever has state 0 but step > 0, force step to 0.
	if (%state == 0 && %step > 0)
		%step = 0;

	// Re-pull req if we changed step
	%req = $Quest::stepReq[%questId, %step];

	// Not ready
	if (%req != "" && !HasThisStuff(%clientId, %req))
		return 0;

	// If accepting quest (state 0), start it and notify
	if (%state == 0) {
		%state = 1;
		Client::sendMessage(%clientId, 0, "You have accepted the quest " @ $Quest::name[%questId]);
		PlaySound(EnterProtected, GameBase::getPosition(%clientId));
	}

	// Consume only for real turn-ins (usually steps >= 1)
	// If you want step 0 to consume too, remove this check.
	if (%step >= 1)
		Quests::ConsumeRequirements(%clientId, %req);

	// Grant reward for completing THIS step
	Quests::GrantStepReward(%clientId, %questId, %step);

	// Determine next step
	%nextStep = %step + 1;
	%nextReq  = $Quest::stepReq[%questId, %nextStep];

	// If next step doesn't exist, quest completes NOW
	if (%nextReq == "") {
		%state = 2;
		%count = %count + 1;
		%last  = getSimTime();

		// Keep step as the last completed step
		%newData = %state @ " " @ %step @ " " @ %count @ " " @ %last @ " " @ %flags;
		Quests::SetData(%clientId, %questId, %newData);
		Quests::MarkActive(%clientId, %questId);
		return 2;
	}

	// Otherwise advance to the next step
	%step = %nextStep;

	%newData = %state @ " " @ %step @ " " @ %count @ " " @ %last @ " " @ %flags;
	Quests::SetData(%clientId, %questId, %newData);
	Quests::MarkActive(%clientId, %questId);

	return 1;
}

function Quests::MarkActive(%clientId, %questId) {
	// Normalize activeCount (unset -> 0)
	%count = $Quest::activeCount[%clientId];

	if (%count == "" || %count < 0)
		%count = 0;

	// Don't add duplicates
	for (%i = 0; %i < %count; %i++) {
		if ($Quest::active[%clientId, %i] == %questId)
		return;
	}

	// Add
	$Quest::active[%clientId, %count] = %questId;
	$Quest::activeCount[%clientId] = %count + 1;
}

function Quests::UnmarkActive(%clientId, %questId) {
	%count = $Quest::activeCount[%clientId];
	if (%count == "" || %count <= 0)
		return;

	// Find index
	%found = -1;
	for (%i = 0; %i < %count; %i++) {
		if ($Quest::active[%clientId, %i] == %questId) {
			%found = %i;
			break;
		}
	}

	if (%found == -1)
		return;

	// Shift down to fill the gap
	for (%j = %found; %j < %count - 1; %j++)
		$Quest::active[%clientId, %j] = $Quest::active[%clientId, %j + 1];

	// Clear last slot and decrement
	$Quest::active[%clientId, %count - 1] = "";
	$Quest::activeCount[%clientId] = %count - 1;
}

function Quests::ConsumeRequirements(%clientId, %req) {
	if (%req == "")
		return;

	%wc = getWordCount(%req);
	for (%i = 0; %i < %wc; %i += 2) {
		%item = getWord(%req, %i);
		%amt  = getWord(%req, %i + 1);

		if (%item == "" || %amt == "")
			continue;

		if (isBeltItem(%item)) {
			%hasLeft = Belt::HasThisStuff(%clientId, %item) - %amt;
			Client::sendMessage(%clientId, $MsgWhite, "You gave " @ %amt @ " " @ $beltitem[%item, "Name"] @ ". [have " @ %hasLeft @ "]");
			Belt::TakeThisStuff(%clientId, %item, %amt);
		} else {
			TakeThisStuff(%clientId, %item @ " " @ %amt);
		}
	}
}

function Quests::GrantStepReward(%clientId, %questId, %step) {
	%reward = $Quest::stepReward[%questId, %step];
	
	if (%reward == "")
		return;

	Client::sendMessage(%clientId, $MsgWhite, "You received: " @ %reward);
	GiveThisStuff(%clientId, %reward);
	PlaySound(bigheal, GameBase::getPosition(%clientId));
}

function Quests::ResetQuest(%clientId, %questId, %removeFromActive) {
	if (%questId == "" || %questId == 0 || %questId == -1)
		return;

	Quests::SetData(%clientId, %questId, "0 0 0 0 0");

	if (%removeFromActive)
		Quests::UnmarkActive(%clientId, %questId);
}

function Quests::GetLastStep(%questId) {
	// Find the highest step index with a defined stepReq
	%last = 0;

	for (%i = 0; %i < 100; %i++) {
		if ($Quest::stepReq[%questId, %i] == "")
			break;

		%last = %i;
	}

	return %last;
}

function Quests::ResetAllByType(%clientId, %type) {
	%count = $Quest::activeCount[%clientId];

	if (%count == "" || %count <= 0)
		return 0;

	%reset = 0;

	// Iterate backwards since we'll be removing entries
	for (%i = %count - 1; %i >= 0; %i--) {
		%qid = $Quest::active[%clientId, %i];
		// Skip invalid quest IDs
		if (%qid == "" || %qid == -1)
			continue;

		if ($Quest::type[%qid] == %type) {
			Quests::ResetQuest(%clientId, %qid, true);
			%reset++;
		}
	}

	return %reset;
}