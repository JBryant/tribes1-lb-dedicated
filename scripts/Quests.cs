// =====================
// QUEST DEFINITIONS
// =====================
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
$Quest::stepReward[2, 1] = "EXP 2000";
$Quest::stepReward[2, 2] = "EXP 3000 PoisonMateriaI 1";

$QuestNPC::name[2] = "Researcher Arin";
$QuestNPC::shape[2] = "MaleHumanTownBot";
$QuestNPC::pos[2] = "-2833.05 -1181.97 701.008";
$QuestNPC::rot[2] = "0 -0 -1.56603";
$QuestNPC::questId[2] = 2;

// =====================
// STEP 0 — ACCEPT QUEST
// =====================
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


// quest 3 - mako vials and zombie viscera
$Quest::name[3] = "A Dirty Job";
$Quest::desc[3] = "Help Researcher Arin collect more research materials from the catacombs.";
$Quest::npcId[3] = 3;
$Quest::type[3] = 0;

$Quest::stepName[3, 0] = "Help out the Researcher";
$Quest::stepName[3, 1] = "Retrieve 6 Mako Vials";
$Quest::stepName[3, 2] = "Retrieve 10 Zombie Viscera";

$Quest::stepDescription[3, 0] = "Researcher Arin needs your help collecting more research materials. Speak to him to find out more.";
$Quest::stepDescription[3, 1] = "Researcher Arin has asked you to collect 6 Mako Vials. You can find them on Shinra guards that patrol the tree back up where you came from.";
$Quest::stepDescription[3, 2] = "Researcher Arin also needs 10 Zombie Viscera. Collect them from zombies in the catacombs below where you currently are.";

$Quest::stepReq[3, 0] = "";
$Quest::stepReq[3, 1] = "MakoVial 4";
$Quest::stepReq[3, 2] = "ZombieViscera 10";

$Quest::stepReward[3, 0] = "";
$Quest::stepReward[3, 1] = "EXP 2000";
$Quest::stepReward[3, 2] = "EXP 3000 IceMateriaII 1";

$QuestNPC::name[3] = "Researcher Arin";
$QuestNPC::shape[3] = "MaleHumanTownBot";
$QuestNPC::pos[3] = "194.691 -842.015 5050.75";
$QuestNPC::rot[3] = "0 -0 0.815921";
$QuestNPC::questId[3] = 3;

// =====================
// STEP 0 — ACCEPT QUEST
// =====================
$QuestNPC::conversations[3, 3, 0, 1, 0] =
  "Ah, it's you again! Perfect timing. I've moved deeper into the catacombs and found something... *interesting*. And I'll need your help to collect some more research materials.|What is it this time?";
$QuestNPC::conversations[3, 3, 0, 1, 1] =
  "The Shinra guards up above are carrying Mako Vials - concentrated energy samples. And these zombies down here... well, they're not exactly *fresh*, but their viscera will be valuable for my research.|That sounds... unpleasant.";
$QuestNPC::conversations[3, 3, 0, 1, 2] =
  "Science rarely is pleasant! But it's necessary. First, I need 4 Mako Vials from those Shinra guards. They patrol the tree back up where you came from.|I can handle that.";

// =====================
// STEP 1 — MAKO VIALS
// =====================
$QuestNPC::conversations[3, 3, 1, 0, 0] =
  "Any progress on those Mako Vials? I've been documenting the ambient energy fluctuations while you were gone.|Not yet.";
$QuestNPC::conversations[3, 3, 1, 0, 1] =
  "Take your time - but not too much time. These readings are fascinating!|I'll hurry.";

$QuestNPC::conversations[3, 3, 1, 1, 0] =
  "Excellent! These vials are pulsing with raw Mako energy. Can you feel the tingle?|I think so?";
$QuestNPC::conversations[3, 3, 1, 1, 1] =
  "Good, good. Now for the... messier part. I need 10 samples of Zombie Viscera from the undead down in the catacombs below. Try not to think about what you're collecting.|I'll try not to.";

// =====================
// STEP 2 — ZOMBIE VISCERA
// =====================
$QuestNPC::conversations[3, 3, 2, 0, 0] =
  "You're back! Please tell me you have the viscera - and that you washed your hands.|Not yet.";
$QuestNPC::conversations[3, 3, 2, 0, 1] =
  "Ah... well. I'll prepare the preservation containers. And maybe some disinfectant.|I'll be back.";

$QuestNPC::conversations[3, 3, 2, 1, 0] =
  "Perfect! These samples are... well, they're exactly what I needed. The decomposition patterns are revealing!|Here you go.";
$QuestNPC::conversations[3, 3, 2, 1, 1] =
  "You've been invaluable. As a reward, I found this Fire Materia while studying the area. It should complement your collection nicely.|Thank you.";
$QuestNPC::conversations[3, 3, 2, 1, 2] =
  "Just remember - science is a dirty job, but someone's got to do it!|I'll keep that in mind.";

// =====================
// STEP 3 — COMPLETED CHATTER
// =====================
$QuestNPC::conversations[3, 3, 3, 1, 0] =
  "That Fire Materia should serve you well. Handle it carefully - it's been exposed to some interesting energy signatures.|I'll be careful.";
$QuestNPC::conversations[3, 3, 3, 1, 1] =
  "If you find any more... unusual materials, feel free to bring them by. I'm always interested in expanding my research.|I'll keep an eye out.";


// quest 4 - wriggly worms
$Quest::name[4] = "Wriggly Things";
$Quest::desc[4] = "Help the Old Fisherman by bringing him Wriggly Worms.";
$Quest::npcId[4] = 4;
$Quest::type[4] = 0;

$Quest::stepName[4, 0] = "Meet the Old Fisherman";
$Quest::stepName[4, 1] = "Bring 15 Wriggly Worms";

$Quest::stepDescription[4, 0] = "An old fisherman at Fisherman's Horizon could use a hand. Speak to him to see what he needs.";
$Quest::stepDescription[4, 1] = "The Old Fisherman asked for 15 Wriggly Worms. They can be found on zombies in the catacombs atop the mountain to the North.";

$Quest::stepReq[4, 0] = "";
$Quest::stepReq[4, 1] = "WrigglyWorm 15";

$Quest::stepReward[4, 0] = "";
$Quest::stepReward[4, 1] = "EXP 2500 FishingRod 1";

$QuestNPC::name[4] = "Old Fisherman";
$QuestNPC::shape[4] = "MaleHumanTownBot";
$QuestNPC::pos[4] = "-1267.47 355.396 85.4751";
$QuestNPC::rot[4] = "0 -0 2.37237";
$QuestNPC::questId[4] = 4;

// =====================
// STEP 0 — ACCEPT QUEST
// =====================
$QuestNPC::conversations[4, 4, 0, 1, 0] =
  "Ahh, a friendly face! The fish aren't biting, but I could still use a hand.|What can I do to help?";
$QuestNPC::conversations[4, 4, 0, 1, 1] =
  "I'm old, but I still know a good bait when I see one. I need 15 Wriggly Worms for my next trip out.|Where can I find them?";
$QuestNPC::conversations[4, 4, 0, 1, 2] =
  "The worms show up on the zombies in the catacombs atop the mountain to the North. Bring me 15 and I'll make it worth your while.|I'll be back with them.";

// =====================
// STEP 1 — WRIGGLY WORMS
// =====================
$QuestNPC::conversations[4, 4, 1, 0, 0] =
  "Have you found those Wriggly Worms yet?|Not yet.";
$QuestNPC::conversations[4, 4, 1, 0, 1] =
  "Take your time, lad. But the fish won't wait forever.|I'll hurry.";

$QuestNPC::conversations[4, 4, 1, 1, 0] =
  "Now that's a fine haul! These will do nicely.|Here you go.";
$QuestNPC::conversations[4, 4, 1, 1, 1] =
  "You've earned this. A sturdy Fishing Rod and a bit of experience for your troubles.|Thank you.";

// =====================
// STEP 2 — COMPLETED CHATTER
// =====================
$QuestNPC::conversations[4, 4, 2, 1, 0] =
  "That Fishing Rod should serve you well. A calm shoreline does wonders for the soul.|I'll keep that in mind.";
$QuestNPC::conversations[4, 4, 2, 1, 1] =
  "If you ever find more worms, or just want to talk fishing, I'm here.|I'll stop by again.";

// Create a new quest NPC for the Fisherman's Horizon.
// this NPC will be called Old Fisherman, the quest will be called "Wriggly Things"
// his personality will be old, friendly and helpful.
// The quest will be a simple 1 stepquest to find and bring to him 15 Wriggly Worms. 
// These worms can be found on the zombies in the catacombs on top of the mountain to the North.
// If the player brings the worms to him, he will give them a reward of 2500 EXP and a Fishing Rod (Item: FishingRod)
// pos: -1267.47 355.396 85.4751
// rot: 0 -0 2.37237

// =========== Mythril Mines Quest ===========
$Quest::name[5] = "Pesky Pests";
$Quest::desc[5] = "Help Elira Stoneveil by defeating the pesky goblins and gnolls.";
$Quest::npcId[5] = 5;
$Quest::type[5] = 0; // 0 one-time per remort | 1 repeatable | 2 daily | 3 weekly | 4 one-time ever

$Quest::stepName[5, 0] = "Help out the Elder";
$Quest::stepName[5, 1] = "Find a Chipped Dagger";
$Quest::stepName[5, 2] = "Find a Quartz";

$Quest::stepDescription[5, 0] = "Word around town is that the Town Elder needs help. Speak to him to find out more.";
$Quest::stepDescription[5, 1] = "Elder Thalos has asked you to find a Chipped Dagger. Search the mines to the South-East over the bridge.";
$Quest::stepDescription[5, 2] = "A piece of Quartz is needed to complete the Elder's request. Find it in the same mine where you found the Chipped Dagger.";

// Requirements to ACCEPT quest (step 0 gate)
$Quest::stepReq[5, 0] = "LVLG 1"; // LVLG = level greater than or equal to 4, also LVLS = level less than or equal to X and LVLE = level equal to X
$Quest::stepReq[5, 1] = "ChippedDagger 15";
$Quest::stepReq[5, 2] = "ShatteredBoneClub 10";

// Rewards for completing the quest
$Quest::stepReward[5, 0] = "";
$Quest::stepReward[5, 1] = "EXP 2000";
$Quest::stepReward[5, 2] = "EXP 3000 FireMateriaI 1";

$QuestNPC::name[5] = "Elira Stoneveil";
$QuestNPC::shape[5] = "FemaleHumanTownBot";
$QuestNPC::pos[5] = "-1713.04 -1001.81 268.572";
$QuestNPC::rot[5] = "0 -0 -1.06919";
$QuestNPC::questId[5] = 5;

$QuestNPC::conversations[5, 5, 0, 1, 0] = "Excuse me, Sir. You wouldn't happen to be an adventurer would you?|Why yes, I am.";
$QuestNPC::conversations[5, 5, 0, 1, 1] = "Oh thank goodness! Our home nearby has been under attack by nasty goblins and gnolls. Could you help us get rid of them?|Of course, m'lady!";
$QuestNPC::conversations[5, 5, 0, 1, 2] = "Thank you. First take out those pesky goblins. Bring me 15 Chipper Daggers and I will know the deed is done.|I'll be back with them.";

$QuestNPC::conversations[5, 5, 1, 0, 0] = "Have you delt with the goblins yet?|No, sorry.";
$QuestNPC::conversations[5, 5, 1, 0, 1] = "I see, well it must be dangerous in there. Stay safe and good luck.|Thanks.";
$QuestNPC::conversations[5, 5, 1, 1, 0] = "Ahh, 15 Chipped Daggers. Excellent! Your next quarry will not be as easy. The gnolls are a fair bit stronger.|Gnolls?";
$QuestNPC::conversations[5, 5, 1, 1, 1] = "You will find them further down in the mines than the golbins. Bring me 10 Shattered Bone Clubs as proof of your deed.|Clubbin' time!";
$QuestNPC::conversations[5, 5, 1, 1, 2] = "Please be safe while in there, and make sure to not go too deep!|Will do.";

$QuestNPC::conversations[5, 5, 2, 0, 0] = "Have you taken care of those gnolls yet?|Not yet...";
$QuestNPC::conversations[5, 5, 2, 0, 1] = "I don't think can feel safe until you do. Please hurry!|I'll update you when I have them.";
$QuestNPC::conversations[5, 5, 2, 1, 0] = "Oh my! Look at all these clubs! That should teach them to leave us alone!|It was easy enough.";
$QuestNPC::conversations[5, 5, 2, 1, 1] = "Thank you so much Adventuer. I don't have much but I did find this lying around outside the mines.|Looks expensive...";

$QuestNPC::conversations[5, 5, 3, 1, 0] = "Thank you for your help again. I will be sure to inform the townsfolk of your deed.|It was nothing.";
$QuestNPC::conversations[5, 5, 3, 1, 1] = "You say that, but this really does mean a lot to us. Thank you again.|You are very welcome m'lady.";

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

	// Client::sendMessage(%clientId, $MsgWhite, "You received: " @ %reward);
	GiveThisStuff(%clientId, %reward, True);
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
	// Start from step 1 (skip step 0 which is the accept gate)
	%last = 0;

	for (%i = 1; %i < 100; %i++) {
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