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
// LEGACY MAP QUESTS
// =====================
// Legacy map quest2
// Legacy SHOP: 33
$Quest::name[6] = "Miguel Request";
$Quest::desc[6] = "Speak to Miguel to learn what they need.";
$Quest::npcId[6] = 6;
$Quest::type[6] = 0;

$Quest::stepName[6, 0] = "Meet Miguel";
$Quest::stepName[6, 1] = "Complete the request";

$Quest::stepDescription[6, 0] = "Speak to Miguel to learn what they need.";
$Quest::stepDescription[6, 1] = "Bring BlackStatue 3 to Miguel.";

$Quest::stepReq[6, 0] = "";
$Quest::stepReq[6, 1] = "BlackStatue 3";

$Quest::stepReward[6, 0] = "";
$Quest::stepReward[6, 1] = "CheetaursPaws 1";

$QuestNPC::name[6] = "Miguel";
$QuestNPC::shape[6] = "MaleHumanTownBot";
$QuestNPC::pos[6] = "-2446 -2307.5 85.7895";
$QuestNPC::rot[6] = "0 -0 -0.32289";
$QuestNPC::questId[6] = 6;

$QuestNPC::conversations[6, 6, 0, 1, 0] = "As a thief, I get my hands on alot of things.|things";
$QuestNPC::conversations[6, 6, 0, 1, 1] = "If you bring me three Black Statues, I will give you something of mine.|next";
$QuestNPC::conversations[6, 6, 1, 0, 0] = "Have you brought what I asked for?|Not yet.";
$QuestNPC::conversations[6, 6, 1, 1, 0] = "Ah, you have returned.  Hand me the statues.  Now!|yes";
$QuestNPC::conversations[6, 6, 1, 1, 1] = "Excellent. Here is your reward.|next";
$QuestNPC::conversations[6, 6, 2, 1, 0] = "Thanks again for your help.|Any time.";


// Legacy map quest3
// Legacy SHOP: 2 4 34 79 80 81 82
$Quest::name[7] = "Apprentice Request";
$Quest::desc[7] = "Speak to Apprentice to learn what they need.";
$Quest::npcId[7] = 7;
$Quest::type[7] = 0;

$Quest::stepName[7, 0] = "Meet Apprentice";
$Quest::stepName[7, 1] = "Complete the request";

$Quest::stepDescription[7, 0] = "Speak to Apprentice to learn what they need.";
$Quest::stepDescription[7, 1] = "Bring EnchantedStone 5 to Apprentice.";

$Quest::stepReq[7, 0] = "";
$Quest::stepReq[7, 1] = "EnchantedStone 5";

$Quest::stepReward[7, 0] = "";
$Quest::stepReward[7, 1] = "EXP 30 COINS 200";

$QuestNPC::name[7] = "Apprentice";
$QuestNPC::shape[7] = "MaleHumanTownBot";
$QuestNPC::pos[7] = "-2719.5 214.625 390.375";
$QuestNPC::rot[7] = "0 -0 2.07833";
$QuestNPC::questId[7] = 7;

$QuestNPC::conversations[7, 7, 0, 1, 0] = "I am looking for rare Enchanted Stones, but I am too weak to kill an Orc...|stone";
$QuestNPC::conversations[7, 7, 0, 1, 1] = "Bring me five Enchanted Stones, and I will give you a few coins.|next";
$QuestNPC::conversations[7, 7, 1, 0, 0] = "Have you brought what I asked for?|Not yet.";
$QuestNPC::conversations[7, 7, 1, 1, 0] = "I see you have five Enchanted Stones, will you hand them to me?|yes";
$QuestNPC::conversations[7, 7, 1, 1, 1] = "You have my thanks.  Here is your reward.|next";
$QuestNPC::conversations[7, 7, 2, 1, 0] = "Thanks again for your help.|Any time.";


// Legacy map quest4
// Legacy SHOP: 83 84
$Quest::name[8] = "Arkemn Request";
$Quest::desc[8] = "Speak to Arkemn to learn what they need.";
$Quest::npcId[8] = 8;
$Quest::type[8] = 0;

$Quest::stepName[8, 0] = "Meet Arkemn";
$Quest::stepName[8, 1] = "Complete the request";

$Quest::stepDescription[8, 0] = "Speak to Arkemn to learn what they need.";
$Quest::stepDescription[8, 1] = "Bring SkeletonBone 3 LVLG 4 to Arkemn.";

$Quest::stepReq[8, 0] = "";
$Quest::stepReq[8, 1] = "SkeletonBone 3 LVLG 4";

$Quest::stepReward[8, 0] = "";
$Quest::stepReward[8, 1] = "EXP 6280";

$QuestNPC::name[8] = "Arkemn";
$QuestNPC::shape[8] = "MaleHumanTownBot";
$QuestNPC::pos[8] = "-2623.25 619.25 714.5";
$QuestNPC::rot[8] = "0 -0 -2.49795";
$QuestNPC::questId[8] = 8;

$QuestNPC::conversations[8, 8, 0, 1, 0] = "My apprentice tells me you have been very helpful.  Perhaps you could help me...|help";
$QuestNPC::conversations[8, 8, 0, 1, 1] = "I need three skeleton bones.  Find me these and I will reward you well.|next";
$QuestNPC::conversations[8, 8, 1, 0, 0] = "Have you brought what I asked for?|Not yet.";
$QuestNPC::conversations[8, 8, 1, 1, 0] = "Incredible, you have three skeleton bones!  Do you still want to hand them to me?|yes";
$QuestNPC::conversations[8, 8, 1, 1, 1] = "Thank you, here is your reward.|next";
$QuestNPC::conversations[8, 8, 2, 1, 0] = "Thanks again for your help.|Any time.";


// Legacy map quest5
// Legacy SHOP: 63 64 65 66 67 68 69 70 71 99
$Quest::name[9] = "Nevim Request";
$Quest::desc[9] = "Speak to Nevim to learn what they need.";
$Quest::npcId[9] = 9;
$Quest::type[9] = 0;

$Quest::stepName[9, 0] = "Meet Nevim";
$Quest::stepName[9, 1] = "Complete the request";

$Quest::stepDescription[9, 0] = "Speak to Nevim to learn what they need.";
$Quest::stepDescription[9, 1] = "Bring EnchantedStone 5 to Nevim.";

$Quest::stepReq[9, 0] = "";
$Quest::stepReq[9, 1] = "EnchantedStone 5";

$Quest::stepReward[9, 0] = "";
$Quest::stepReward[9, 1] = "EXP 50 COINS 400";

$QuestNPC::name[9] = "Nevim";
$QuestNPC::shape[9] = "MaleHumanTownBot";
$QuestNPC::pos[9] = "-2430 -223.658 71.5914";
$QuestNPC::rot[9] = "0 -0 0.859791";
$QuestNPC::questId[9] = 9;

$QuestNPC::conversations[9, 9, 0, 1, 0] = "That damned Apprentice has been keeping all the Enchanted Stones to himself!|stones";
$QuestNPC::conversations[9, 9, 0, 1, 1] = "If you bring me five Enchanted Stones, I will reward you well.|next";
$QuestNPC::conversations[9, 9, 1, 0, 0] = "Have you brought what I asked for?|Not yet.";
$QuestNPC::conversations[9, 9, 1, 1, 0] = "Well, looks like you have the stones!  Will you hand them to me?|yes";
$QuestNPC::conversations[9, 9, 1, 1, 1] = "Thanks for making the right choice.  Make sure to stay away from that Apprentice!|next";
$QuestNPC::conversations[9, 9, 2, 1, 0] = "Thanks again for your help.|Any time.";


// Legacy map quest6
$Quest::name[10] = "Thorin Request";
$Quest::desc[10] = "Speak to Thorin to learn what they need.";
$Quest::npcId[10] = 10;
$Quest::type[10] = 0;

$Quest::stepName[10, 0] = "Meet Thorin";
$Quest::stepName[10, 1] = "Complete the request";

$Quest::stepDescription[10, 0] = "Speak to Thorin to learn what they need.";
$Quest::stepDescription[10, 1] = "Bring COINS 1000000 LVLG 2 to Thorin.";

$Quest::stepReq[10, 0] = "";
$Quest::stepReq[10, 1] = "COINS 1000000 LVLG 2";

$Quest::stepReward[10, 0] = "";
$Quest::stepReward[10, 1] = "Parchment 1";

$QuestNPC::name[10] = "Thorin";
$QuestNPC::shape[10] = "MaleHumanTownBot";
$QuestNPC::pos[10] = "-2203.25 -502.125 45.8595";
$QuestNPC::rot[10] = "0 -0 3.00289";
$QuestNPC::questId[10] = 10;

$QuestNPC::conversations[10, 10, 0, 1, 0] = "Hello there, fellow adventurer.|hello";
$QuestNPC::conversations[10, 10, 0, 1, 1] = "For one million coins, I will give you a parchment that will give you a very rare item.|next";
$QuestNPC::conversations[10, 10, 1, 0, 0] = "Have you brought what I asked for?|Not yet.";
$QuestNPC::conversations[10, 10, 1, 1, 0] = "Incredible, you are quite a resourceful person! Will you hand over the coins?|yes";
$QuestNPC::conversations[10, 10, 1, 1, 1] = "Thank you. Please take this parchment to my friend at Hemac Tower. Good luck friend.|next";
$QuestNPC::conversations[10, 10, 2, 1, 0] = "Thanks again for your help.|Any time.";


// Legacy map quest7
$Quest::name[11] = "Hemac Request";
$Quest::desc[11] = "Speak to Hemac to learn what they need.";
$Quest::npcId[11] = 11;
$Quest::type[11] = 0;

$Quest::stepName[11, 0] = "Meet Hemac";
$Quest::stepName[11, 1] = "Complete the request";

$Quest::stepDescription[11, 0] = "Speak to Hemac to learn what they need.";
$Quest::stepDescription[11, 1] = "Bring Parchment 1 LVLG 2 to Hemac.";

$Quest::stepReq[11, 0] = "";
$Quest::stepReq[11, 1] = "Parchment 1 LVLG 2";

$Quest::stepReward[11, 0] = "";
$Quest::stepReward[11, 1] = "MagicDust 1";

$QuestNPC::name[11] = "Hemac";
$QuestNPC::shape[11] = "MaleHumanTownBot";
$QuestNPC::pos[11] = "-320.5 2361.5 464.5";
$QuestNPC::rot[11] = "0 0 0";
$QuestNPC::questId[11] = 11;

$QuestNPC::conversations[11, 11, 0, 1, 0] = "Welcome to Hemac Tower, friend.|hail";
$QuestNPC::conversations[11, 11, 0, 1, 1] = "I would ask you to take magic dust to a friend, but I can't do this without a specific parchment.|next";
$QuestNPC::conversations[11, 11, 1, 0, 0] = "Have you brought what I asked for?|Not yet.";
$QuestNPC::conversations[11, 11, 1, 1, 0] = "What's this? Can I read this parchment of yours?|yes";
$QuestNPC::conversations[11, 11, 1, 1, 1] = "*reads parchment* Ah! A parchment from Thorin! Take this magic dust to Mithrandir. She's far from here... Good luck on your journey.|next";
$QuestNPC::conversations[11, 11, 2, 1, 0] = "Thanks again for your help.|Any time.";


// Legacy map quest8
$Quest::name[12] = "Mithrandir Request";
$Quest::desc[12] = "Speak to Mithrandir to learn what they need.";
$Quest::npcId[12] = 12;
$Quest::type[12] = 0;

$Quest::stepName[12, 0] = "Meet Mithrandir";
$Quest::stepName[12, 1] = "Complete the request";

$Quest::stepDescription[12, 0] = "Speak to Mithrandir to learn what they need.";
$Quest::stepDescription[12, 1] = "Bring MagicDust 1 LVLG 2 to Mithrandir.";

$Quest::stepReq[12, 0] = "";
$Quest::stepReq[12, 1] = "MagicDust 1 LVLG 2";

$Quest::stepReward[12, 0] = "";
$Quest::stepReward[12, 1] = "EXP 4625";

$QuestNPC::name[12] = "Mithrandir";
$QuestNPC::shape[12] = "FemaleHumanTownBot";
$QuestNPC::pos[12] = "2751 -590.5 225.25";
$QuestNPC::rot[12] = "0 0 0";
$QuestNPC::questId[12] = 12;

$QuestNPC::conversations[12, 12, 0, 1, 0] = "Welcome to my home.|hello";
$QuestNPC::conversations[12, 12, 0, 1, 1] = "I wish I had some magic dust... I would grant you a great deal of Experience for such an item.|next";
$QuestNPC::conversations[12, 12, 1, 0, 0] = "Have you brought what I asked for?|Not yet.";
$QuestNPC::conversations[12, 12, 1, 1, 0] = "Magic dust! May I have it?|yes";
$QuestNPC::conversations[12, 12, 1, 1, 1] = "Thank you very much. Here is your reward!|next";
$QuestNPC::conversations[12, 12, 2, 1, 0] = "Thanks again for your help.|Any time.";


// Legacy map quest9
$Quest::name[13] = "Arlette Request";
$Quest::desc[13] = "Speak to Arlette to learn what they need.";
$Quest::npcId[13] = 13;
$Quest::type[13] = 0;

$Quest::stepName[13, 0] = "Meet Arlette";
$Quest::stepName[13, 1] = "Complete the request";

$Quest::stepDescription[13, 0] = "Speak to Arlette to learn what they need.";
$Quest::stepDescription[13, 1] = "Bring Trancephyte 1 to Arlette.";

$Quest::stepReq[13, 0] = "";
$Quest::stepReq[13, 1] = "Trancephyte 1";

$Quest::stepReward[13, 0] = "";
$Quest::stepReward[13, 1] = "SP 20";

$QuestNPC::name[13] = "Arlette";
$QuestNPC::shape[13] = "FemaleHumanTownBot";
$QuestNPC::pos[13] = "-2424.5 -257.011 71.0914";
$QuestNPC::rot[13] = "0 -0 -2.72282";
$QuestNPC::questId[13] = 13;

$QuestNPC::conversations[13, 13, 0, 1, 0] = "Ahh, a new adventurer. Come to learn more about Materia?|yes";
$QuestNPC::conversations[13, 13, 0, 1, 1] = "Materia is the main source of magic in this world and it has many different kinds of uses.|uses";
$QuestNPC::conversations[13, 13, 0, 1, 2] = "It can be used by mages to improve their spellcasting and by fighters to slot into different equipment.|slot";
$QuestNPC::conversations[13, 13, 0, 1, 3] = "Materia can be added to weapons and armor to improve them. There are also different kinds of Materia that have different effects.|kinds";
$QuestNPC::conversations[13, 13, 0, 1, 4] = "There are six differnet kinds of materia that you can use on equipment. Fire, Lightning, Ice, Earth, Poison, and Holy.|equipment";
$QuestNPC::conversations[13, 13, 0, 1, 5] = "To slot Materia into equipment go to the item in your inventory, click on it and click Slot to choose your materia. But be careful!|careful";
$QuestNPC::conversations[13, 13, 0, 1, 6] = "Slotting Materia is a permanent process which cannot be undone. Items also can only hold one Materia each.|powerful";
$QuestNPC::conversations[13, 13, 0, 1, 7] = "There are many levels of Materia. Lower levels of Materia can be combined to create stronger Materia at a Blacksmith.|thanks";
$QuestNPC::conversations[13, 13, 0, 1, 8] = "Any time adventurer. Always keep your eye out for new Materia and play with different combinations to strengthen yourself!|next";
$QuestNPC::conversations[13, 13, 1, 0, 0] = "Have you brought what I asked for?|Not yet.";
$QuestNPC::conversations[13, 13, 1, 1, 0] = "I'll give you 20 SP credits for a Trancephyte.|ok";
$QuestNPC::conversations[13, 13, 1, 1, 1] = "Thank you very much. Here is your SP!|next";
$QuestNPC::conversations[13, 13, 2, 1, 0] = "Thanks again for your help.|Any time.";


// Legacy map quest10
$Quest::name[14] = "Johannes Request";
$Quest::desc[14] = "Speak to Johannes to learn what they need.";
$Quest::npcId[14] = 14;
$Quest::type[14] = 0;

$Quest::stepName[14, 0] = "Meet Johannes";
$Quest::stepName[14, 1] = "Complete the request";

$Quest::stepDescription[14, 0] = "Speak to Johannes to learn what they need.";
$Quest::stepDescription[14, 1] = "Bring EnchantedStone 3 to Johannes.";

$Quest::stepReq[14, 0] = "";
$Quest::stepReq[14, 1] = "EnchantedStone 3";

$Quest::stepReward[14, 0] = "";
$Quest::stepReward[14, 1] = "SkeletonBone 1";

$QuestNPC::name[14] = "Johannes";
$QuestNPC::shape[14] = "MaleHumanTownBot";
$QuestNPC::pos[14] = "-2436.75 -258.375 77.5914";
$QuestNPC::rot[14] = "0 -0 -2.23957";
$QuestNPC::questId[14] = 14;

$QuestNPC::conversations[14, 14, 0, 1, 0] = "Welcome to Kalm! I'm Johannes, the mayor of this town. We're just a small rural village but there are plenty of jobs to be found.|jobs";
$QuestNPC::conversations[14, 14, 0, 1, 1] = "Try talking to some of the other villagers around town. I am sure someone will have something for you to do.|thanks";
$QuestNPC::conversations[14, 14, 0, 1, 2] = "Also, If you are new make sure talk to everyone in this building. They can help teach you about some of the new things about this world.|new";
$QuestNPC::conversations[14, 14, 0, 1, 3] = "Things like the Belt, Classes, Active Skills and Materia. They may even have tasks for you to help you on your journey.|next";
$QuestNPC::conversations[14, 14, 0, 1, 4] = "If you can spare 3 Enchanted Stones, bring them to me and I'll trade you a Skeleton Bone.|ok";
$QuestNPC::conversations[14, 14, 0, 1, 4] = "If you can spare 3 Enchanted Stones, bring them to me and I'll trade you a Skeleton Bone.|ok";
$QuestNPC::conversations[14, 14, 1, 0, 0] = "Have you brought what I asked for?|Not yet.";
$QuestNPC::conversations[14, 14, 1, 1, 0] = "I'll give you a Skeleton Bone for those 3 Enchanted Stones you have there.|ok";
$QuestNPC::conversations[14, 14, 1, 1, 1] = "Thanks, here's your Skeleton Bone.|next";
$QuestNPC::conversations[14, 14, 2, 1, 0] = "Thanks again for your help.|Any time.";


// Legacy map quest11
$Quest::name[15] = "Brien Request";
$Quest::desc[15] = "Speak to Brien to learn what they need.";
$Quest::npcId[15] = 15;
$Quest::type[15] = 0;

$Quest::stepName[15, 0] = "Meet Brien";
$Quest::stepName[15, 1] = "Complete the request";

$Quest::stepDescription[15, 0] = "Speak to Brien to learn what they need.";

$Quest::stepReq[15, 0] = "";
$Quest::stepReq[15, 1] = "";

$Quest::stepReward[15, 0] = "";
$Quest::stepReward[15, 1] = "SmallBeltPouch 1";

$QuestNPC::name[15] = "Brien";
$QuestNPC::shape[15] = "MaleHumanTownBot";
$QuestNPC::pos[15] = "-2430.5 -246.25 77.5914";
$QuestNPC::rot[15] = "0 -0 2.38281";
$QuestNPC::questId[15] = 15;

$QuestNPC::conversations[15, 15, 0, 1, 0] = "Hey, nice belt you got there!|belt?";
$QuestNPC::conversations[15, 15, 0, 1, 1] = "That thing you are wearing around your waist. It gives you the power to press TAB and view items in your Inventory.|inventory";
$QuestNPC::conversations[15, 15, 0, 1, 2] = "It even organizes all your things for you. A very handy item indeed, right?|sure";
$QuestNPC::conversations[15, 15, 0, 1, 3] = "Tell you what, once you have gained some experience, come back and visit me. I'll give you a nice upgrade for your belt!|thanks";
$QuestNPC::conversations[15, 15, 0, 1, 4] = "Just make sure to help the town out while you are at it. Oh, and make sure to talk to Lance. He can tell you about Skills.|next";
$QuestNPC::conversations[15, 15, 1, 0, 0] = "Have you brought what I asked for?|Not yet.";
$QuestNPC::conversations[15, 15, 1, 1, 0] = "You made it! I'm very impressed!|thanks";
$QuestNPC::conversations[15, 15, 1, 1, 1] = "Take this Small Belt Pouch. It's an accessory you can equip to increase your carrying capacity!|next";
$QuestNPC::conversations[15, 15, 2, 1, 0] = "Thanks again for your help.|Any time.";


// Legacy map quest12
$Quest::name[16] = "Lance Request";
$Quest::desc[16] = "Speak to Lance to learn what they need.";
$Quest::npcId[16] = 16;
$Quest::type[16] = 0;

$Quest::stepName[16, 0] = "Meet Lance";
$Quest::stepName[16, 1] = "Complete the request";

$Quest::stepDescription[16, 0] = "Speak to Lance to learn what they need.";
$Quest::stepDescription[16, 1] = "Bring SmallRock 20 to Lance.";

$Quest::stepReq[16, 0] = "";
$Quest::stepReq[16, 1] = "SmallRock 20";

$Quest::stepReward[16, 0] = "";
$Quest::stepReward[16, 1] = "HealingKitI 1";

$QuestNPC::name[16] = "Lance";
$QuestNPC::shape[16] = "MaleHumanTownBot";
$QuestNPC::pos[16] = "-2421.5 -252.25 77.5914";
$QuestNPC::rot[16] = "0 -0 2.12282";
$QuestNPC::questId[16] = 16;

$QuestNPC::conversations[16, 16, 0, 1, 0] = "Hey there stranger. Have you learned about skills yet?|skills";
$QuestNPC::conversations[16, 16, 0, 1, 1] = "There are lots of skills! Most skills can only be used certain classes but there are some that anybody can use.|really?";
$QuestNPC::conversations[16, 16, 0, 1, 2] = "Of course! Everyone knows about [mend]. It's a skill to heal yourself, although it does require a Healing Kit to use.|how?";
$QuestNPC::conversations[16, 16, 0, 1, 3] = "All you have to do is type #skill and then the name of the skill. For mend you just type '#skill mend', but it's the same for every skill.|thanks";
$QuestNPC::conversations[16, 16, 0, 1, 4] = "You can buy Healing Kits at the Merchant by the Fountain. Make sure to stock up on them before heading out to the mines.|mines";
$QuestNPC::conversations[16, 16, 0, 1, 5] = "The Mythril Mines south-east from town. People used to go their to mine for Materia before it was overrun by monsters.|monsters";
$QuestNPC::conversations[16, 16, 0, 1, 6] = "Goblins and Gnolls have overrun the place, and some people say something even worse lingers deeper in the mines. Probably attracted to the Materia.|materia";
$QuestNPC::conversations[16, 16, 0, 1, 7] = "You don't know about materia? You should go talk to Arlette downstairs about it. She can tell you more about it than myself.|next";
$QuestNPC::conversations[16, 16, 0, 1, 8] = "Bring me 20 Small Rocks and I'll set you up with a Healing Kit for the road.|ok";
$QuestNPC::conversations[16, 16, 0, 1, 8] = "Bring me 20 Small Rocks and I'll set you up with a Healing Kit for the road.|ok";
$QuestNPC::conversations[16, 16, 1, 0, 0] = "Have you brought what I asked for?|Not yet.";
$QuestNPC::conversations[16, 16, 1, 1, 0] = "Excellent, you have 20 small rocks! Will you hand them over to me?|yes";
$QuestNPC::conversations[16, 16, 1, 1, 1] = "Here's your reward!|next";
$QuestNPC::conversations[16, 16, 2, 1, 0] = "Thanks again for your help.|Any time.";


// Legacy map quest13
$Quest::name[17] = "Esmeralda Request";
$Quest::desc[17] = "Speak to Esmeralda to learn what they need.";
$Quest::npcId[17] = 17;
$Quest::type[17] = 0;

$Quest::stepName[17, 0] = "Meet Esmeralda";
$Quest::stepName[17, 1] = "Complete the request";

$Quest::stepDescription[17, 0] = "Speak to Esmeralda to learn what they need.";
$Quest::stepDescription[17, 1] = "Bring DragonScale 1 to Esmeralda.";

$Quest::stepReq[17, 0] = "";
$Quest::stepReq[17, 1] = "DragonScale 1";

$Quest::stepReward[17, 0] = "";
$Quest::stepReward[17, 1] = "COINS 50000 RP 1";

$QuestNPC::name[17] = "Esmeralda";
$QuestNPC::shape[17] = "FemaleHumanTownBot";
$QuestNPC::pos[17] = "-2414.5 -263.033 65";
$QuestNPC::rot[17] = "0 -0 -1.64254";
$QuestNPC::questId[17] = 17;

$QuestNPC::conversations[17, 17, 0, 1, 0] = "If you look at the Score menu (TAB) you will notice a Skill Points section. Make sure to assign skill points to your favorite skills|more";
$QuestNPC::conversations[17, 17, 0, 1, 1] = "You will notice that skills go up slower or faster than others. These are preset based on your class, such that a fighter can learn to cast, but is better off fighting|next";
$QuestNPC::conversations[17, 17, 0, 1, 2] = "Find me a Dragon Scale and I'll pay you 50000 coins and a RP for it.|ok";
$QuestNPC::conversations[17, 17, 0, 1, 2] = "Find me a Dragon Scale and I'll pay you 50000 coins and a RP for it.|ok";
$QuestNPC::conversations[17, 17, 1, 0, 0] = "Have you brought what I asked for?|Not yet.";
$QuestNPC::conversations[17, 17, 1, 1, 0] = "A dragon scale! I will give you 50000 coins and teach you a few adventuring tips for one.|ok";
$QuestNPC::conversations[17, 17, 1, 1, 1] = "Thank you! Here are your coins.|next";
$QuestNPC::conversations[17, 17, 2, 1, 0] = "Thanks again for your help.|Any time.";


// Legacy map quest14
$Quest::name[18] = "Damaris Request";
$Quest::desc[18] = "Speak to Damaris to learn what they need.";
$Quest::npcId[18] = 18;
$Quest::type[18] = 0;

$Quest::stepName[18, 0] = "Meet Damaris";
$Quest::stepName[18, 1] = "Complete the request";

$Quest::stepDescription[18, 0] = "Speak to Damaris to learn what they need.";
$Quest::stepDescription[18, 1] = "Bring EXP 4000 to Damaris.";

$Quest::stepReq[18, 0] = "";
$Quest::stepReq[18, 1] = "";

$Quest::stepReward[18, 0] = "";
$Quest::stepReward[18, 1] = "LeatherArmor 1";

$QuestNPC::name[18] = "Damaris";
$QuestNPC::shape[18] = "MaleHumanTownBot";
$QuestNPC::pos[18] = "-2434 -243.766 71.0914";
$QuestNPC::rot[18] = "0 -0 -2.79957";
$QuestNPC::questId[18] = 18;

$QuestNPC::conversations[18, 18, 0, 1, 0] = "Come to learn more about classes?|classes";
$QuestNPC::conversations[18, 18, 0, 1, 1] = "Classes are what separates all adventurers and what gives them their powers. But becoming a certain class isn't always easy.|easy";
$QuestNPC::conversations[18, 18, 0, 1, 2] = "To reach the strongest classes you must have trained long in enough in lower classes.|trained";
$QuestNPC::conversations[18, 18, 0, 1, 3] = "Once you have reach level 100 in a class you can Remort to get one level of that class in your Class Levels.|list";
$QuestNPC::conversations[18, 18, 0, 1, 4] = "Your Class Levels are history of all your past classes you have trained in. You need different combinations of classes to get access to new ones.|combinations";
$QuestNPC::conversations[18, 18, 0, 1, 5] = "Some combinations are easy. For instance you only need 2 levels of Squire to become a Knight, or 2 levels of Chemist to become a Black Mage|more";
$QuestNPC::conversations[18, 18, 0, 1, 6] = "Other classes are much harder. The Holy Knight class requires 8 White Mage, 8 Mystic, 8 Geomancer, and 8 Samurai classes to attain. Not an easy feat!|wow";
$QuestNPC::conversations[18, 18, 0, 1, 7] = "It's a lot to take in, but there are Class Trainers around the world that can help you on your Journey.|next";
$QuestNPC::conversations[18, 18, 1, 0, 0] = "Have you brought what I asked for?|Not yet.";
$QuestNPC::conversations[18, 18, 1, 1, 0] = "I see your skills have improved since the last time we met!|indeed";
$QuestNPC::conversations[18, 18, 1, 1, 1] = "For being such a brave adventurer, here is a gift I'm sure you will appreciate.|next";
$QuestNPC::conversations[18, 18, 2, 1, 0] = "Thanks again for your help.|Any time.";


// Legacy map quest15
$Quest::name[19] = "Missing Townsfolk";
$Quest::desc[19] = "Help Mayor Brian investigate the disappearances in Nibelheim.";
$Quest::npcId[19] = 19;
$Quest::type[19] = 0;

$Quest::stepName[19, 0] = "Meet Mayor Brian";
$Quest::stepName[19, 1] = "Find Evidence of Kidnappings";
$Quest::stepName[19, 2] = "Bring 10 Cultist Badges";

$Quest::stepDescription[19, 0] = "Speak to Mayor Brian in Nibelheim.";
$Quest::stepDescription[19, 1] = "Find a Cultist Badge from the cultists and bring it back.";
$Quest::stepDescription[19, 2] = "Bring 10 Cultist Badges as proof the threat has been handled.";

$Quest::stepReq[19, 0] = "LVLG 100";
$Quest::stepReq[19, 1] = "CultistBadge 1";
$Quest::stepReq[19, 2] = "CultistBadge 10";

$Quest::stepReward[19, 0] = "";
$Quest::stepReward[19, 1] = "EXP 2000";
$Quest::stepReward[19, 2] = "EXP 6000";

$QuestNPC::name[19] = "Brian";
$QuestNPC::shape[19] = "MaleHumanTownBot";
$QuestNPC::pos[19] = "-4474.5 -268 65.829";
$QuestNPC::rot[19] = "0 -0 1.55037";
$QuestNPC::questId[19] = 19;

$QuestNPC::conversations[19, 19, 0, 1, 0] = "Welcome to Nibelheim, traveler. Our town is in mourning. People vanish every other week with no trace.|What can I do?";
$QuestNPC::conversations[19, 19, 0, 1, 1] = "We have signs of cultists at the old well. Find any evidence of their presence.|Evidence?";
$QuestNPC::conversations[19, 19, 0, 1, 2] = "Bring me a Cultist Badge. If they are involved, we must know.|I'll return with one.";
$QuestNPC::conversations[19, 19, 1, 0, 0] = "Have you found any evidence of the kidnappings?|Not yet.";
$QuestNPC::conversations[19, 19, 1, 1, 0] = "A Cultist Badge... So it is true. Take this for your trouble.|What now?";
$QuestNPC::conversations[19, 19, 1, 1, 1] = "Bring me 10 more badges as proof the culprits have been dealt with.|I'll handle it.";
$QuestNPC::conversations[19, 19, 2, 0, 0] = "Do you have the 10 Cultist Badges?|Not yet.";
$QuestNPC::conversations[19, 19, 2, 0, 1] = "Please hurry. Every day matters.|I'll be back.";
$QuestNPC::conversations[19, 19, 2, 1, 0] = "You've done us a great service. Nibelheim owes you a debt.|Glad to help.";
$QuestNPC::conversations[19, 19, 3, 1, 0] = "Thank you again for standing with us.|Any time.";


// Legacy map quest16
$Quest::name[20] = "Chemist Trainer Request";
$Quest::desc[20] = "Speak to Chemist Trainer to learn what they need.";
$Quest::npcId[20] = 20;
$Quest::type[20] = 0;

$Quest::stepName[20, 0] = "Meet Chemist Trainer";
$Quest::stepName[20, 1] = "Complete the request";

$Quest::stepDescription[20, 0] = "Speak to Chemist Trainer to learn what they need.";
$Quest::stepDescription[20, 1] = "Bring HealingHerb 10 to Chemist Trainer.";

$Quest::stepReq[20, 0] = "";
$Quest::stepReq[20, 1] = "HealingHerb 10";

$Quest::stepReward[20, 0] = "";
$Quest::stepReward[20, 1] = "CrackedFlask 1 VialOfWater 1 CrudeClayAlembic 1";

$QuestNPC::name[20] = "Chemist Trainer";
$QuestNPC::shape[20] = "MaleHumanTownBot";
$QuestNPC::pos[20] = "-2430.65 -271.341 65.0923";
$QuestNPC::rot[20] = "0 -0 0.638029";
$QuestNPC::questId[20] = 20;

$QuestNPC::conversations[20, 20, 0, 1, 0] = "Hello, are you are interested in learning more about being a Chemist?|yes";
$QuestNPC::conversations[20, 20, 0, 1, 1] = "Chemists get their strength from the potions they create, from simple healing potions to life saving panaceas.|potions";
$QuestNPC::conversations[20, 20, 0, 1, 2] = "While anyone can [harvest] alchemy ingredients, only a Chemist can use the alchemy skill to create new potions.|alchemy";
$QuestNPC::conversations[20, 20, 0, 1, 3] = "To use the [alchemy] skill you must have the correct tools, ingredients and knowledge of what you want to make.|tools";
$QuestNPC::conversations[20, 20, 0, 1, 4] = "To make potions you must have an Alembic. They are sold at many stores and you only need one of them to grind up your ingredients.|ingredients";
$QuestNPC::conversations[20, 20, 0, 1, 5] = "Ingredients can be harvested from plants around Gaia and can be used for various alchemical recipes.|recipes";
$QuestNPC::conversations[20, 20, 0, 1, 6] = "Tell you what. I'm always in need of more Healing Herbs. Bring me 10 and I will teach you the recipe to make a Potion.|herbs";
$QuestNPC::conversations[20, 20, 0, 1, 7] = "Theres a healthy plant outside this door next to the street lamp. Bring back 10 herbs and I'll get you set up with proper tools.|next";
$QuestNPC::conversations[20, 20, 1, 0, 0] = "Have you brought what I asked for?|Not yet.";
$QuestNPC::conversations[20, 20, 1, 1, 0] = "Excellent, you have the healing herbs! Crafting a [Potion] requires 5 Healing Herbs, 1 Cracked Flask, 1 Vial of Water and of course an Alembic.|thanks";
$QuestNPC::conversations[20, 20, 1, 1, 1] = "To craft a Potion simply type #alchemy Potion. Take my old Alembic here to get started, and make sure to stock up on more flasks and water before you head out!|next";
$QuestNPC::conversations[20, 20, 2, 1, 0] = "Thanks again for your help.|Any time.";


// Legacy map quest17
$Quest::name[21] = "Squire Trainer Request";
$Quest::desc[21] = "Speak to Squire Trainer to learn what they need.";
$Quest::npcId[21] = 21;
$Quest::type[21] = 0;

$Quest::stepName[21, 0] = "Meet Squire Trainer";
$Quest::stepName[21, 1] = "Finish the conversation";

$Quest::stepDescription[21, 0] = "Speak to Squire Trainer to learn what they need.";
$Quest::stepDescription[21, 1] = "Listen and learn from Squire Trainer.";

$Quest::stepReq[21, 0] = "";
$Quest::stepReq[21, 1] = "";

$Quest::stepReward[21, 0] = "";
$Quest::stepReward[21, 1] = "HealingHerb 1";

$QuestNPC::name[21] = "Squire Trainer";
$QuestNPC::shape[21] = "MaleHumanTownBot";
$QuestNPC::pos[21] = "-2426.07 -266.713 65.0923";
$QuestNPC::rot[21] = "0 -0 0.888099";
$QuestNPC::questId[21] = 21;

$QuestNPC::conversations[21, 21, 0, 1, 0] = "Greetings Adventurer. Come to learn more about what it takes to be a Squire?|squire";
$QuestNPC::conversations[21, 21, 0, 1, 1] = "A squire is a budding warrior who is prepared to train every day to improve their skills.|skills";
$QuestNPC::conversations[21, 21, 0, 1, 2] = "Oh yes, Squires have lots of skills! Although, only some of them are coded-*ahem*, I mean discovered right now. Blame Ramza for that.|coded?";
$QuestNPC::conversations[21, 21, 0, 1, 3] = "Forget about that. Have YOU ever thought yourself: Hey, why are Mages the only ones with cool flashy abilities?|Yes!";
$QuestNPC::conversations[21, 21, 0, 1, 4] = "Or have you ever thought: Why are Mages the only ones who get to do big explosive AOE damage?|ABSOLUTELY!";
$QuestNPC::conversations[21, 21, 0, 1, 5] = "Well have no fear, your trainer is here. And I am here to teach you about [cleave]!|Finally!";
$QuestNPC::conversations[21, 21, 0, 1, 6] = "To use it simply type #skill cleave or just #cleave for short, and start watching your enemies falling all around you!|amazing";
$QuestNPC::conversations[21, 21, 0, 1, 7] = "Enjoy it while it lasts, it's honestly a bit broken and I imagine Ramza will tinker with it in the future. But hey, it's all about having FUN right?|next";
$QuestNPC::conversations[21, 21, 1, 0, 0] = "Have you brought what I asked for?|Not yet.";
$QuestNPC::conversations[21, 21, 1, 1, 0] = "Excellent, you have the healing herbs! Crafting a [Potion] requires 5 Healing Herbs, 1 Cracked Flask, 1 Vial of Water and of course an Alembic.|thanks";
$QuestNPC::conversations[21, 21, 1, 1, 1] = "To craft a Potion simply type #alchemy Potion. Take my old Alembic here to get started, and make sure to stock up on more flasks and water before you head out!|next";
$QuestNPC::conversations[21, 21, 2, 1, 0] = "Thanks again for your help.|Any time.";


// Legacy map quest18
$Quest::name[22] = "Taggerung Request";
$Quest::desc[22] = "Speak to Taggerung to learn what they need.";
$Quest::npcId[22] = 22;
$Quest::type[22] = 0;

$Quest::stepName[22, 0] = "Meet Taggerung";
$Quest::stepName[22, 1] = "Complete the request";

$Quest::stepDescription[22, 0] = "Speak to Taggerung to learn what they need.";
$Quest::stepDescription[22, 1] = "Bring AhrimanEyeLens 1 to Taggerung.";

$Quest::stepReq[22, 0] = "";
$Quest::stepReq[22, 1] = "AhrimanEyeLens 1";

$Quest::stepReward[22, 0] = "";
$Quest::stepReward[22, 1] = "GoobaHearthstone 1";

$QuestNPC::name[22] = "Taggerung";
$QuestNPC::shape[22] = "MaleHumanTownBot";
$QuestNPC::pos[22] = "246.97 -477.832 -2962.5";
$QuestNPC::rot[22] = "0 -0 -1.4563";
$QuestNPC::questId[22] = 22;
$BotInfo["Taggerung", TEAM] = 2;

$QuestNPC::conversations[22, 22, 0, 1, 0] = "Welkom Humeen. I am Taggerung, king of the Uuags. What brings you to my town?|Heaven";
$QuestNPC::conversations[22, 22, 0, 1, 1] = "Going to Heaven you say? Well plenty of monstiez to help with dat. But I have heard of dis place before.|place";
$QuestNPC::conversations[22, 22, 0, 1, 2] = "Oh yes, you are not the first to come here with same idea. Rest a while before you continue.|rest";
$QuestNPC::conversations[22, 22, 0, 1, 3] = "We have inn in Lower Gooba and stores to trade wares. You might even meet others who know more about this Heaven.|thanks";
$QuestNPC::conversations[22, 22, 0, 1, 4] = "One more thing Adventurer. On your quest if you happen to find a Ahriman Eye Lens, bring one back to me and I give reward.|Ahriman";
$QuestNPC::conversations[22, 22, 0, 1, 5] = "Yes, it iz rare ingredient we need for our potionz. Demons snack on dem in the Maze below but we have great need for dem.|okay";
$QuestNPC::conversations[22, 22, 0, 1, 6] = "Bring me an Ahriman Eye Lens and I'll hand you a Gooba Hearthstone as thanks.|next";
$QuestNPC::conversations[22, 22, 1, 0, 0] = "Have you brought what I asked for?|Not yet.";
$QuestNPC::conversations[22, 22, 1, 1, 0] = "Ah! An Ahriman Eye Lens! Geeve it here.|sure";
$QuestNPC::conversations[22, 22, 1, 1, 1] = "Thankee adventurer. Take thiz as a token of my thankz. It can bring you back to Gooba quick like!|next";
$QuestNPC::conversations[22, 22, 2, 1, 0] = "Thanks again for your help.|Any time.";


// Legacy map quest19
$Quest::name[23] = "Frik Request";
$Quest::desc[23] = "Speak to Frik to learn what they need.";
$Quest::npcId[23] = 23;
$Quest::type[23] = 0;

$Quest::stepName[23, 0] = "Meet Frik";
$Quest::stepName[23, 1] = "Finish the conversation";

$Quest::stepDescription[23, 0] = "Speak to Frik to learn what they need.";
$Quest::stepDescription[23, 1] = "Listen and learn from Frik.";

$Quest::stepReq[23, 0] = "";
$Quest::stepReq[23, 1] = "";

$Quest::stepReward[23, 0] = "";
$Quest::stepReward[23, 1] = "COINS 100";

$QuestNPC::name[23] = "Frik";
$QuestNPC::shape[23] = "MaleHumanTownBot";
$QuestNPC::pos[23] = "280.589 -411.889 -2963";
$QuestNPC::rot[23] = "0 -0 0.129189";
$QuestNPC::questId[23] = 23;
$BotInfo["Frik", TEAM] = 2;

$QuestNPC::conversations[23, 23, 0, 1, 0] = "What you doing in my house?|hello";
$QuestNPC::conversations[23, 23, 0, 1, 1] = "Yes, Hello. But why you in my house?|directions";
$QuestNPC::conversations[23, 23, 0, 1, 2] = "Nothing here humeen. General Store and Bank of Gooba in other room. Smith and Inn are in Lower Gooba.|thanks";
$QuestNPC::conversations[23, 23, 0, 1, 3] = "Thank me by leaving, I am very busy and important Uuag.|next";
$QuestNPC::conversations[23, 23, 1, 0, 0] = "Have you brought what I asked for?|Not yet.";
$QuestNPC::conversations[23, 23, 1, 1, 0] = "Excellent!|thanks";
$QuestNPC::conversations[23, 23, 1, 1, 1] = "End|next";
$QuestNPC::conversations[23, 23, 2, 1, 0] = "Thanks again for your help.|Any time.";


// Legacy map quest20
$Quest::name[24] = "Klurg Request";
$Quest::desc[24] = "Speak to Klurg to learn what they need.";
$Quest::npcId[24] = 24;
$Quest::type[24] = 0;

$Quest::stepName[24, 0] = "Meet Klurg";
$Quest::stepName[24, 1] = "Finish the conversation";

$Quest::stepDescription[24, 0] = "Speak to Klurg to learn what they need.";
$Quest::stepDescription[24, 1] = "Listen and learn from Klurg.";

$Quest::stepReq[24, 0] = "";
$Quest::stepReq[24, 1] = "";

$Quest::stepReward[24, 0] = "";
$Quest::stepReward[24, 1] = "COINS 100";

$QuestNPC::name[24] = "Klurg";
$QuestNPC::shape[24] = "MaleHumanTownBot";
$QuestNPC::pos[24] = "298.669 -392.209 -2963";
$QuestNPC::rot[24] = "0 -0 -3.0499";
$QuestNPC::questId[24] = 24;
$BotInfo["Klurg", TEAM] = 2;

$QuestNPC::conversations[24, 24, 0, 1, 0] = "Don't mind Frik in other home. He think he better than all other Uuags.|Why";
$QuestNPC::conversations[24, 24, 0, 1, 1] = "His family was great adventurers, but they never returned from trip to Gooba Catacombs.|catacombs";
$QuestNPC::conversations[24, 24, 0, 1, 2] = "Yes. We bury our dead in maze so their souls wander lost for eternity, but it is dangerous to get their.|dangerous";
$QuestNPC::conversations[24, 24, 0, 1, 3] = "Dark and ancient things stalk the catacombs. Restless evils. I suggest you stay away if you want to live.|next";
$QuestNPC::conversations[24, 24, 1, 0, 0] = "Have you brought what I asked for?|Not yet.";
$QuestNPC::conversations[24, 24, 1, 1, 0] = "Excellent!|thanks";
$QuestNPC::conversations[24, 24, 1, 1, 1] = "End|next";
$QuestNPC::conversations[24, 24, 2, 1, 0] = "Thanks again for your help.|Any time.";


// Legacy map quest21
$Quest::name[25] = "Urgot Request";
$Quest::desc[25] = "Speak to Urgot to learn what they need.";
$Quest::npcId[25] = 25;
$Quest::type[25] = 0;

$Quest::stepName[25, 0] = "Meet Urgot";
$Quest::stepName[25, 1] = "Finish the conversation";

$Quest::stepDescription[25, 0] = "Speak to Urgot to learn what they need.";
$Quest::stepDescription[25, 1] = "Listen and learn from Urgot.";

$Quest::stepReq[25, 0] = "";
$Quest::stepReq[25, 1] = "";

$Quest::stepReward[25, 0] = "";
$Quest::stepReward[25, 1] = "COINS 50";

$QuestNPC::name[25] = "Urgot";
$QuestNPC::shape[25] = "MaleHumanTownBot";
$QuestNPC::pos[25] = "331 -446 -2963.5";
$QuestNPC::rot[25] = "0 -0 1.68529";
$QuestNPC::questId[25] = 25;
$BotInfo["Urgot", TEAM] = 2;

$QuestNPC::conversations[25, 25, 0, 1, 0] = "OooOooh. Urgot so hungry...|hungry";
$QuestNPC::conversations[25, 25, 0, 1, 1] = "I am vee-gun, other Uuags make fun of me because not much food for me to eat.|vegan?";
$QuestNPC::conversations[25, 25, 0, 1, 2] = "Yis, thats what it called. Please, bring me some mushrooms, I beg you!|next";
$QuestNPC::conversations[25, 25, 1, 0, 0] = "Have you brought what I asked for?|Not yet.";
$QuestNPC::conversations[25, 25, 1, 1, 0] = "Excellent!|thanks";
$QuestNPC::conversations[25, 25, 1, 1, 1] = "End|next";
$QuestNPC::conversations[25, 25, 2, 1, 0] = "Thanks again for your help.|Any time.";


// Legacy map quest22
$Quest::name[26] = "Deekin Request";
$Quest::desc[26] = "Speak to Deekin to learn what they need.";
$Quest::npcId[26] = 26;
$Quest::type[26] = 0;

$Quest::stepName[26, 0] = "Meet Deekin";
$Quest::stepName[26, 1] = "Finish the conversation";

$Quest::stepDescription[26, 0] = "Speak to Deekin to learn what they need.";
$Quest::stepDescription[26, 1] = "Listen and learn from Deekin.";

$Quest::stepReq[26, 0] = "";
$Quest::stepReq[26, 1] = "";

$Quest::stepReward[26, 0] = "";
$Quest::stepReward[26, 1] = "COINS 50";

$QuestNPC::name[26] = "Deekin";
$QuestNPC::shape[26] = "MaleHumanTownBot";
$QuestNPC::pos[26] = "324.394 -430 -2963.5";
$QuestNPC::rot[26] = "0 -0 1.68529";
$QuestNPC::questId[26] = 26;
$BotInfo["Deekin", TEAM] = 2;

$QuestNPC::conversations[26, 26, 0, 1, 0] = "Ahh! Dont sneak up on Deekin. Me cooking for Uuag soldiers, me no want to spill!|cook";
$QuestNPC::conversations[26, 26, 0, 1, 1] = "Not much food in caves, only Rat Kebabs and occasional Uber Sandwiches.|rat";
$QuestNPC::conversations[26, 26, 0, 1, 2] = "Dont worry, we kleen good before eatin. Not that it help Urgot much. That one strange... dont like rat! Blasphemy!|urgot";
$QuestNPC::conversations[26, 26, 0, 1, 3] = "Yis. You can talk to him. He probably very hungry for food.|next";
$QuestNPC::conversations[26, 26, 1, 0, 0] = "Have you brought what I asked for?|Not yet.";
$QuestNPC::conversations[26, 26, 1, 1, 0] = "Excellent!|thanks";
$QuestNPC::conversations[26, 26, 1, 1, 1] = "End|next";
$QuestNPC::conversations[26, 26, 2, 1, 0] = "Thanks again for your help.|Any time.";


// Legacy map quest23
$Quest::name[27] = "Ragabag Request";
$Quest::desc[27] = "Speak to Ragabag to learn what they need.";
$Quest::npcId[27] = 27;
$Quest::type[27] = 0;

$Quest::stepName[27, 0] = "Meet Ragabag";
$Quest::stepName[27, 1] = "Finish the conversation";

$Quest::stepDescription[27, 0] = "Speak to Ragabag to learn what they need.";
$Quest::stepDescription[27, 1] = "Listen and learn from Ragabag.";

$Quest::stepReq[27, 0] = "";
$Quest::stepReq[27, 1] = "";

$Quest::stepReward[27, 0] = "";
$Quest::stepReward[27, 1] = "COINS 50";

$QuestNPC::name[27] = "Ragabag";
$QuestNPC::shape[27] = "MaleHumanTownBot";
$QuestNPC::pos[27] = "293 -500.589 -2963.32";
$QuestNPC::rot[27] = "0 -0 -3.02589";
$QuestNPC::questId[27] = 27;
$BotInfo["Ragabag", TEAM] = 2;

$QuestNPC::conversations[27, 27, 0, 1, 0] = "Welkom to Gooba, Humeen. Need directions?|directions";
$QuestNPC::conversations[27, 27, 0, 1, 1] = "You are in Upper Gooba. Up here is the Item Store, Bank of Gooba and the King.|store";
$QuestNPC::conversations[27, 27, 0, 1, 2] = "Behind me to the right is the General store, Armorer and Bank of Gooba.|king";
$QuestNPC::conversations[27, 27, 0, 1, 3] = "Behind me to the left and back of hall is the King. Go talk to heem.|next";
$QuestNPC::conversations[27, 27, 1, 0, 0] = "Have you brought what I asked for?|Not yet.";
$QuestNPC::conversations[27, 27, 1, 1, 0] = "Excellent!|thanks";
$QuestNPC::conversations[27, 27, 1, 1, 1] = "End|next";
$QuestNPC::conversations[27, 27, 2, 1, 0] = "Thanks again for your help.|Any time.";


// Legacy map quest24
$Quest::name[28] = "Zugzug Request";
$Quest::desc[28] = "Speak to Zugzug to learn what they need.";
$Quest::npcId[28] = 28;
$Quest::type[28] = 0;

$Quest::stepName[28, 0] = "Meet Zugzug";
$Quest::stepName[28, 1] = "Finish the conversation";

$Quest::stepDescription[28, 0] = "Speak to Zugzug to learn what they need.";
$Quest::stepDescription[28, 1] = "Listen and learn from Zugzug.";

$Quest::stepReq[28, 0] = "";
$Quest::stepReq[28, 1] = "";

$Quest::stepReward[28, 0] = "";
$Quest::stepReward[28, 1] = "COINS 50";

$QuestNPC::name[28] = "Zugzug";
$QuestNPC::shape[28] = "MaleHumanTownBot";
$QuestNPC::pos[28] = "278.5 -497.089 -2963.5";
$QuestNPC::rot[28] = "0 -0 -1.4829";
$QuestNPC::questId[28] = 28;
$BotInfo["Zugzug", TEAM] = 2;

$QuestNPC::conversations[28, 28, 0, 1, 0] = "Dis way to Lower Gooba.|lower";
$QuestNPC::conversations[28, 28, 0, 1, 1] = "Go to Lower Gooba if you want Inn or Blacksmith.|thanks";
$QuestNPC::conversations[28, 28, 0, 1, 2] = "Just watch your back there. Things tend to go missin there.|next";
$QuestNPC::conversations[28, 28, 1, 0, 0] = "Have you brought what I asked for?|Not yet.";
$QuestNPC::conversations[28, 28, 1, 1, 0] = "Excellent!|thanks";
$QuestNPC::conversations[28, 28, 1, 1, 1] = "End|next";
$QuestNPC::conversations[28, 28, 2, 1, 0] = "Thanks again for your help.|Any time.";


// Legacy map quest25
$Quest::name[29] = "Yorrik Request";
$Quest::desc[29] = "Speak to Yorrik to learn what they need.";
$Quest::npcId[29] = 29;
$Quest::type[29] = 0;

$Quest::stepName[29, 0] = "Meet Yorrik";
$Quest::stepName[29, 1] = "Finish the conversation";

$Quest::stepDescription[29, 0] = "Speak to Yorrik to learn what they need.";
$Quest::stepDescription[29, 1] = "Listen and learn from Yorrik.";

$Quest::stepReq[29, 0] = "";
$Quest::stepReq[29, 1] = "";

$Quest::stepReward[29, 0] = "";
$Quest::stepReward[29, 1] = "COINS 50";

$QuestNPC::name[29] = "Yorrik";
$QuestNPC::shape[29] = "MaleHumanTownBot";
$QuestNPC::pos[29] = "-398.625 -382.468 1569.25";
$QuestNPC::rot[29] = "0 -0 1.72195";
$QuestNPC::questId[29] = 29;
$BotInfo["Yorrik", TEAM] = 2;

$QuestNPC::conversations[29, 29, 0, 1, 0] = "Where did it go?|what";
$QuestNPC::conversations[29, 29, 0, 1, 1] = "My missing tools! Krush is gunna keel me...|help";
$QuestNPC::conversations[29, 29, 0, 1, 2] = "You could? If you happen to find them, bring em to me right away!|next";
$QuestNPC::conversations[29, 29, 1, 0, 0] = "Have you brought what I asked for?|Not yet.";
$QuestNPC::conversations[29, 29, 1, 1, 0] = "Excellent!|thanks";
$QuestNPC::conversations[29, 29, 1, 1, 1] = "End|next";
$QuestNPC::conversations[29, 29, 2, 1, 0] = "Thanks again for your help.|Any time.";


// Legacy map quest26
$Quest::name[30] = "Xero Request";
$Quest::desc[30] = "Speak to Xero to learn what they need.";
$Quest::npcId[30] = 30;
$Quest::type[30] = 0;

$Quest::stepName[30, 0] = "Meet Xero";
$Quest::stepName[30, 1] = "Finish the conversation";

$Quest::stepDescription[30, 0] = "Speak to Xero to learn what they need.";
$Quest::stepDescription[30, 1] = "Listen and learn from Xero.";

$Quest::stepReq[30, 0] = "";
$Quest::stepReq[30, 1] = "";

$Quest::stepReward[30, 0] = "";
$Quest::stepReward[30, 1] = "COINS 50";

$QuestNPC::name[30] = "Xero";
$QuestNPC::shape[30] = "MaleHumanTownBot";
$QuestNPC::pos[30] = "-379.13 -362.203 1521.25";
$QuestNPC::rot[30] = "0 -0 -1.45899";
$QuestNPC::questId[30] = 30;
$BotInfo["Xero", TEAM] = 2;

$QuestNPC::conversations[30, 30, 0, 1, 0] = "Heading into da maze? Wouldnt do daty if I wuz you.|maze";
$QuestNPC::conversations[30, 30, 0, 1, 1] = "Many uuags gone missing in there. Hear *bad* things echoing the halls.|bad";
$QuestNPC::conversations[30, 30, 0, 1, 2] = "Screaming, yelling, roarin... death shrieks. Those kinda *bad* things...|help";
$QuestNPC::conversations[30, 30, 0, 1, 3] = "Want to help? Sure thing. Just dont say I didnt warn ya.|next";
$QuestNPC::conversations[30, 30, 1, 0, 0] = "Have you brought what I asked for?|Not yet.";
$QuestNPC::conversations[30, 30, 1, 1, 0] = "Excellent!|thanks";
$QuestNPC::conversations[30, 30, 1, 1, 1] = "End|next";
$QuestNPC::conversations[30, 30, 2, 1, 0] = "Thanks again for your help.|Any time.";


// Legacy map quest27
$Quest::name[31] = "Karthus Request";
$Quest::desc[31] = "Speak to Karthus to learn what they need.";
$Quest::npcId[31] = 31;
$Quest::type[31] = 0;

$Quest::stepName[31, 0] = "Meet Karthus";
$Quest::stepName[31, 1] = "Finish the conversation";

$Quest::stepDescription[31, 0] = "Speak to Karthus to learn what they need.";
$Quest::stepDescription[31, 1] = "Listen and learn from Karthus.";

$Quest::stepReq[31, 0] = "";
$Quest::stepReq[31, 1] = "";

$Quest::stepReward[31, 0] = "";
$Quest::stepReward[31, 1] = "COINS 50";

$QuestNPC::name[31] = "Karthus";
$QuestNPC::shape[31] = "MaleHumanTownBot";
// $QuestNPC::pos[31] = "-2294.62 -440.998 96.6916";
// $QuestNPC::rot[31] = "0 -0 0.503522";
$QuestNPC::pos[31] = "-2401.97 -356.53 65.0079";
$QuestNPC::rot[31] = "0 -0 -0.78814";
$QuestNPC::questId[31] = 31;

$QuestNPC::conversations[31, 31, 0, 1, 0] = "Have you visited the haunted tree yet?|tree";
$QuestNPC::conversations[31, 31, 0, 1, 1] = "There is a tree at the very top of this hill behind me. Some folks say it is haunted, other folks say it's how you get to Heaven.|heaven";
$QuestNPC::conversations[31, 31, 0, 1, 2] = "I haven't got a clue what they mean by that. But it's sure a long way up just to meet your maker.|thanks";
$QuestNPC::conversations[31, 31, 0, 1, 3] = "If you plan on going, make sure to stock up on provisions in town first before you head up there.|next";
$QuestNPC::conversations[31, 31, 1, 0, 0] = "Have you brought what I asked for?|Not yet.";
$QuestNPC::conversations[31, 31, 1, 1, 0] = "Excellent!|thanks";
$QuestNPC::conversations[31, 31, 1, 1, 1] = "End|next";
$QuestNPC::conversations[31, 31, 2, 1, 0] = "Thanks again for your help.|Any time.";


// Legacy map quest28
$Quest::name[32] = "BlackMage Trainer Request";
$Quest::desc[32] = "Speak to BlackMage Trainer to learn what they need.";
$Quest::npcId[32] = 32;
$Quest::type[32] = 0;

$Quest::stepName[32, 0] = "Meet BlackMage Trainer";
$Quest::stepName[32, 1] = "Finish the conversation";

$Quest::stepDescription[32, 0] = "Speak to BlackMage Trainer to learn what they need.";
$Quest::stepDescription[32, 1] = "Listen and learn from BlackMage Trainer.";

$Quest::stepReq[32, 0] = "";
$Quest::stepReq[32, 1] = "";

$Quest::stepReward[32, 0] = "";
$Quest::stepReward[32, 1] = "EXP 200";

$QuestNPC::name[32] = "BlackMage Trainer";
$QuestNPC::shape[32] = "MaleMageTownBot";
$QuestNPC::pos[32] = "-2445.15 -294.295 71.5923";
$QuestNPC::rot[32] = "0 -0 -1.57481";
$QuestNPC::questId[32] = 32;
$BotInfo["BlackMage Trainer", TEAM] = 6;

$QuestNPC::conversations[32, 32, 0, 1, 0] = "Ahh, a new scholar in training. Come to learn what you can about becoming a Black Mage?|mage";
$QuestNPC::conversations[32, 32, 0, 1, 1] = "To become a Mage you must first train as a Chemist. After 2 remorts in the Chemist class you will learn about spells.|spells";
$QuestNPC::conversations[32, 32, 0, 1, 2] = "Here, take this tome. If you want to read up on all the spells that exist across all schools just type #spells.|schools";
$QuestNPC::conversations[32, 32, 0, 1, 3] = "There are many spells across different schools and disciplines. You can also use this tome to find your best spell.|best";
$QuestNPC::conversations[32, 32, 0, 1, 4] = "If you type #bestspell the Tome will show you the best spell you are capable of at that moment.|next";
$QuestNPC::conversations[32, 32, 1, 0, 0] = "Have you brought what I asked for?|Not yet.";
$QuestNPC::conversations[32, 32, 1, 1, 0] = "Excellent!|thanks";
$QuestNPC::conversations[32, 32, 1, 1, 1] = "End|next";
$QuestNPC::conversations[32, 32, 2, 1, 0] = "Thanks again for your help.|Any time.";


// Legacy map quest29
$Quest::name[33] = "Tifa Request";
$Quest::desc[33] = "Speak to Tifa to learn what they need.";
$Quest::npcId[33] = 33;
$Quest::type[33] = 0;

$Quest::stepName[33, 0] = "Meet Tifa";
$Quest::stepName[33, 1] = "Finish the conversation";

$Quest::stepDescription[33, 0] = "Speak to Tifa to learn what they need.";
$Quest::stepDescription[33, 1] = "Listen and learn from Tifa.";

$Quest::stepReq[33, 0] = "";
$Quest::stepReq[33, 1] = "";

$Quest::stepReward[33, 0] = "";
$Quest::stepReward[33, 1] = "COINS 50";

$QuestNPC::name[33] = "Tifa";
$QuestNPC::shape[33] = "FemaleHumanTownBot";
$QuestNPC::pos[33] = "1411.28 -450.093 -807.692";
$QuestNPC::rot[33] = "0 -0 1.63293";
$QuestNPC::questId[33] = 33;

$QuestNPC::conversations[33, 33, 0, 1, 0] = "Welcome to my bar 7th Heaven! You look like you could use some rest and a strong drink!|Heaven";
$QuestNPC::conversations[33, 33, 0, 1, 1] = "Yup! That's here. Although it's really called 7th Heaven. I opened this bar while adventuring down here and more people began to join.|adventuring";
$QuestNPC::conversations[33, 33, 0, 1, 2] = "I originally came with some friends while looking for the Temple of the Ancients.|temple";
$QuestNPC::conversations[33, 33, 0, 1, 3] = "It's further down the dungeon, but be careful, the enemies get much tougher the farther down you go.|farther";
$QuestNPC::conversations[33, 33, 0, 1, 4] = "I'm not sure how much farther down the Temple is, but if you find my friends please let me know!|next";
$QuestNPC::conversations[33, 33, 1, 0, 0] = "Have you brought what I asked for?|Not yet.";
$QuestNPC::conversations[33, 33, 1, 1, 0] = "Excellent!|thanks";
$QuestNPC::conversations[33, 33, 1, 1, 1] = "End|next";
$QuestNPC::conversations[33, 33, 2, 1, 0] = "Thanks again for your help.|Any time.";


// Legacy map quest30
$Quest::name[34] = "Knight Trainer Request";
$Quest::desc[34] = "Speak to Knight Trainer to learn what they need.";
$Quest::npcId[34] = 34;
$Quest::type[34] = 0;

$Quest::stepName[34, 0] = "Meet Knight Trainer";
$Quest::stepName[34, 1] = "Finish the conversation";

$Quest::stepDescription[34, 0] = "Speak to Knight Trainer to learn what they need.";
$Quest::stepDescription[34, 1] = "Listen and learn from Knight Trainer.";

$Quest::stepReq[34, 0] = "";
$Quest::stepReq[34, 1] = "";

$Quest::stepReward[34, 0] = "";
$Quest::stepReward[34, 1] = "HealingHerb 1";

$QuestNPC::name[34] = "Knight Trainer";
$QuestNPC::shape[34] = "MaleHumanTownBot";
$QuestNPC::pos[34] = "1994.79 508.063 2400";
$QuestNPC::rot[34] = "0 -0 -2.66623";
$QuestNPC::questId[34] = 34;

$QuestNPC::conversations[34, 34, 0, 1, 0] = "Need something, friend? Im just an old Knight looking for a stiff drink.|knight";
$QuestNPC::conversations[34, 34, 0, 1, 1] = "Want to learn about becoming a Knight? All knights started as Squires first. After training a few years you can become a Knight.|years";
$QuestNPC::conversations[34, 34, 0, 1, 2] = "I think it took me about 2 years as a Squire before I graduated to Knight. It took effort but the skills are definitely worth it.|skills";
$QuestNPC::conversations[34, 34, 0, 1, 3] = "Yes. All Squires are required to learn Cleave, but Knights learn how to use Great Cleave. A stronger variation of cleave.|greatcleave";
$QuestNPC::conversations[34, 34, 0, 1, 4] = "Yup, you just use #skill greatcleave and there you have it. Also Knights learn to use the Parry skill.|parry";
$QuestNPC::conversations[34, 34, 0, 1, 5] = "Parry is a skill that prepares you to dodge and block all melee damage for a short time. Saved my hide a few times.|melee";
$QuestNPC::conversations[34, 34, 0, 1, 6] = "Right, it let's you block melee attacks but you still need to watch out for magic!|thanks";
$QuestNPC::conversations[34, 34, 0, 1, 7] = "No problem kid. Always open to helping a new Knight in training!|next";
$QuestNPC::conversations[34, 34, 1, 0, 0] = "Have you brought what I asked for?|Not yet.";
$QuestNPC::conversations[34, 34, 1, 1, 0] = "Excellent, you have the healing herbs! Crafting a [Potion] requires 5 Healing Herbs, 1 Cracked Flask, 1 Vial of Water and of course an Alembic.|thanks";
$QuestNPC::conversations[34, 34, 1, 1, 1] = "To craft a Potion simply type #alchemy Potion. Take my old Alembic here to get started, and make sure to stock up on more flasks and water before you head out!|next";
$QuestNPC::conversations[34, 34, 2, 1, 0] = "Thanks again for your help.|Any time.";


// Legacy map quest31
$Quest::name[35] = "Archer Trainer Request";
$Quest::desc[35] = "Speak to Archer Trainer to learn what they need.";
$Quest::npcId[35] = 35;
$Quest::type[35] = 0;

$Quest::stepName[35, 0] = "Meet Archer Trainer";
$Quest::stepName[35, 1] = "Finish the conversation";

$Quest::stepDescription[35, 0] = "Speak to Archer Trainer to learn what they need.";
$Quest::stepDescription[35, 1] = "Listen and learn from Archer Trainer.";

$Quest::stepReq[35, 0] = "";
$Quest::stepReq[35, 1] = "";

$Quest::stepReward[35, 0] = "";
$Quest::stepReward[35, 1] = "HealingHerb 1";

$QuestNPC::name[35] = "Archer Trainer";
$QuestNPC::shape[35] = "MaleHumanTownBot";
$QuestNPC::pos[35] = "2003.54 493.151 2400";
$QuestNPC::rot[35] = "0 -0 -1.21189";
$QuestNPC::questId[35] = 35;

$QuestNPC::conversations[35, 35, 0, 1, 0] = "Hail stranger. What can I help you with?|training";
$QuestNPC::conversations[35, 35, 0, 1, 1] = "Want to learn about Archers? Sure, like Knights all Archers begin as Squires.|squire";
$QuestNPC::conversations[35, 35, 0, 1, 2] = "Once you have studied for 2 years as a Squire you can choose to become a Knight or an Archer.|acher";
$QuestNPC::conversations[35, 35, 0, 1, 3] = "Archers specialize in fighting at range. Their skills compliment taking enemies down quickly and efficiently.|skills";
$QuestNPC::conversations[35, 35, 0, 1, 4] = "The first skill you will learn is QuickShot. It's a rapid burst attack that focuses on taking down one enemy as fast as possible.|wow";
$QuestNPC::conversations[35, 35, 0, 1, 5] = "Of course, if you are dealing with a group of enemies we have a skill for that too. It's called Explosive Shot.|explosiveshot";
$QuestNPC::conversations[35, 35, 0, 1, 6] = "Correct. You just use #skill explosiveshot and you will shoot an arrow that explodes on impact or after a few seconds.|thanks";
$QuestNPC::conversations[35, 35, 0, 1, 7] = "Of course. Hope you fare well in your adventures.|next";
$QuestNPC::conversations[35, 35, 1, 0, 0] = "Have you brought what I asked for?|Not yet.";
$QuestNPC::conversations[35, 35, 1, 1, 0] = "Excellent, you have the healing herbs! Crafting a [Potion] requires 5 Healing Herbs, 1 Cracked Flask, 1 Vial of Water and of course an Alembic.|thanks";
$QuestNPC::conversations[35, 35, 1, 1, 1] = "To craft a Potion simply type #alchemy Potion. Take my old Alembic here to get started, and make sure to stock up on more flasks and water before you head out!|next";
$QuestNPC::conversations[35, 35, 2, 1, 0] = "Thanks again for your help.|Any time.";


// Legacy map quest32
$Quest::name[36] = "WhiteMage Trainer Request";
$Quest::desc[36] = "Speak to WhiteMage Trainer to learn what they need.";
$Quest::npcId[36] = 36;
$Quest::type[36] = 0;

$Quest::stepName[36, 0] = "Meet WhiteMage Trainer";
$Quest::stepName[36, 1] = "Finish the conversation";

$Quest::stepDescription[36, 0] = "Speak to WhiteMage Trainer to learn what they need.";
$Quest::stepDescription[36, 1] = "Listen and learn from WhiteMage Trainer.";

$Quest::stepReq[36, 0] = "";
$Quest::stepReq[36, 1] = "";

$Quest::stepReward[36, 0] = "";
$Quest::stepReward[36, 1] = "HealingHerb 1";

$QuestNPC::name[36] = "WhiteMage Trainer";
$QuestNPC::shape[36] = "FemaleHumanTownBot";
$QuestNPC::pos[36] = "-2439.44 -301.395 65.0923";
$QuestNPC::rot[36] = "0 -0 -1.36085";
$QuestNPC::questId[36] = 36;

$QuestNPC::conversations[36, 36, 0, 1, 0] = "Come to learn the priestly ways of the White Mage?|yes";
$QuestNPC::conversations[36, 36, 0, 1, 1] = "White Mages specialize in healing magics to cure wounds and diseases. But don't let that fool you, White Mages are plenty capable fighters.|fighters";
$QuestNPC::conversations[36, 36, 0, 1, 2] = "Along with healing spells like Medic, White Mages have access to special offensive spells using Light Magic.|lightmagic";
$QuestNPC::conversations[36, 36, 0, 1, 3] = "Spells like Spike, Wound, Fist and Missile. You can learn more about them using your spell book. [#spells]|spells";
$QuestNPC::conversations[36, 36, 0, 1, 4] = "Of coure the highest level of white magic is Star, but it takes much determination and training to acquire it.|star";
$QuestNPC::conversations[36, 36, 0, 1, 5] = "It summons a holy star to fall down and smite your enemies. As i said before, do not under estimate a White Mage.|thanks";
$QuestNPC::conversations[36, 36, 0, 1, 6] = "In time you may even be able to work your way up to a Mystic! Those are White Mages who have trained for many years to access even stonger abilities.|thanks";
$QuestNPC::conversations[36, 36, 0, 1, 7] = "Any time young one. Now be careful out on the road, and do your best to help others in need.|next";
$QuestNPC::conversations[36, 36, 1, 0, 0] = "Have you brought what I asked for?|Not yet.";
$QuestNPC::conversations[36, 36, 1, 1, 0] = "Excellent, you have the healing herbs! Crafting a [Potion] requires 5 Healing Herbs, 1 Cracked Flask, 1 Vial of Water and of course an Alembic.|thanks";
$QuestNPC::conversations[36, 36, 1, 1, 1] = "To craft a Potion simply type #alchemy Potion. Take my old Alembic here to get started, and make sure to stock up on more flasks and water before you head out!|next";
$QuestNPC::conversations[36, 36, 2, 1, 0] = "Thanks again for your help.|Any time.";


// Legacy map quest33
$Quest::name[37] = "Hank Request";
$Quest::desc[37] = "Speak to Hank to learn what they need.";
$Quest::npcId[37] = 37;
$Quest::type[37] = 0;

$Quest::stepName[37, 0] = "Meet Hank";
$Quest::stepName[37, 1] = "Finish the conversation";

$Quest::stepDescription[37, 0] = "Speak to Hank to learn what they need.";
$Quest::stepDescription[37, 1] = "Listen and learn from Hank.";

$Quest::stepReq[37, 0] = "";
$Quest::stepReq[37, 1] = "";

$Quest::stepReward[37, 0] = "";
$Quest::stepReward[37, 1] = "COINS 100";

$QuestNPC::name[37] = "Hank";
$QuestNPC::shape[37] = "MaleHumanTownBot";
$QuestNPC::pos[37] = "1998.29 494.529 2200";
$QuestNPC::rot[37] = "0 -0 -2.41004";
$QuestNPC::questId[37] = 37;

$QuestNPC::conversations[37, 37, 0, 1, 0] = "Hey there. Want to learn how to build a home?|yes";
$QuestNPC::conversations[37, 37, 0, 1, 1] = "Start by buying home deeds and furniture from housing merchants. You can find them all over the world.|home";
$QuestNPC::conversations[37, 37, 0, 1, 2] = "To place a home, open Housing in your belt and Use the home item. Aim where you want it, then type #place.|place";
$QuestNPC::conversations[37, 37, 0, 1, 3] = "Need adjustments? Look at your home and use #move or #rotate, then #place again to confirm.|more";
$QuestNPC::conversations[37, 37, 0, 1, 4] = "You can also purchase furniture from merchants. Place them inside your home and they will follow your house even if you move it.|move";
$QuestNPC::conversations[37, 37, 0, 1, 5] = "You can #move, #rotate, and #place furniture just like the home itself.|thanks";
$QuestNPC::conversations[37, 37, 0, 1, 6] = "That's the basics. Build something cozy and make it yours.|next";
$QuestNPC::conversations[37, 37, 1, 0, 0] = "Have you brought what I asked for?|Not yet.";
$QuestNPC::conversations[37, 37, 1, 1, 0] = "Thank you for your help.|Glad to help.";
$QuestNPC::conversations[37, 37, 2, 1, 0] = "Thanks again for your help.|Any time.";

// Nibelheim villager
$Quest::name[38] = "Missing Husband";
$Quest::desc[38] = "Help a villager find evidence about her missing husband.";
$Quest::npcId[38] = 38;
$Quest::type[38] = 0;

$Quest::stepName[38, 0] = "Meet the Villager";
$Quest::stepName[38, 1] = "Find Evidence of the Kidnapping";

$Quest::stepDescription[38, 0] = "A villager in Nibelheim begs for help. Speak with her.";
$Quest::stepDescription[38, 1] = "Bring a Cultist Badge as evidence of who took her husband.";

$Quest::stepReq[38, 0] = "LVLG 100";
$Quest::stepReq[38, 1] = "CultistBadge 1";

$Quest::stepReward[38, 0] = "";
$Quest::stepReward[38, 1] = "COINS 2000";

$QuestNPC::name[38] = "Liora";
$QuestNPC::shape[38] = "FemaleHumanTownBot";
$QuestNPC::pos[38] = "-4419.98 -308.881 65.0978";
$QuestNPC::rot[38] = "0 -0 -0.000835243";
$QuestNPC::questId[38] = 38;

$QuestNPC::conversations[38, 38, 0, 1, 0] = "Please, my husband is missing. No one will listen.|Tell me what happened.";
$QuestNPC::conversations[38, 38, 0, 1, 1] = "He went to draw water at the old well and never returned. If you find any evidence, bring it to me.|I'll look.";
$QuestNPC::conversations[38, 38, 0, 1, 2] = "Anything, even a scrap from those cultists, would ease my heart.|I'll return.";
$QuestNPC::conversations[38, 38, 1, 0, 0] = "Did you find anything about my husband?|Not yet.";
$QuestNPC::conversations[38, 38, 1, 1, 0] = "A Cultist Badge... So they took him. It's not much, but please take this.|Thank you.";
$QuestNPC::conversations[38, 38, 2, 1, 0] = "Thank you for listening. Please be careful down there.|I will.";

// Nibelheim innkeeper
$Quest::name[39] = "Innkeeper's Welcome";
$Quest::desc[39] = "Speak with the innkeeper in Nibelheim.";
$Quest::npcId[39] = 39;
$Quest::type[39] = 0;

$Quest::stepName[39, 0] = "Meet the Innkeeper";
$Quest::stepName[39, 1] = "Finish the conversation";

$Quest::stepDescription[39, 0] = "The innkeeper welcomes travelers to Nibelheim.";
$Quest::stepDescription[39, 1] = "Listen to the innkeeper's advice.";

$Quest::stepReq[39, 0] = "LVLG 100";
$Quest::stepReq[39, 1] = "";

$Quest::stepReward[39, 0] = "";
$Quest::stepReward[39, 1] = "";

$QuestNPC::name[39] = "Innkeeper Rhea";
$QuestNPC::shape[39] = "FemaleHumanTownBot";
$QuestNPC::pos[39] = "-4386.1 -246.77 71.3045";
$QuestNPC::rot[39] = "0 -0 2.04084";
$QuestNPC::questId[39] = 39;

$QuestNPC::conversations[39, 39, 0, 1, 0] = "Welcome to Nibelheim. Rooms are free if you help with our troubles.|What's wrong?";
$QuestNPC::conversations[39, 39, 0, 1, 1] = "People vanish every other week. We suspect cultists slipping in through the old well.|Old well?";
$QuestNPC::conversations[39, 39, 0, 1, 2] = "Deep below, something hums with dark power. If you can, find the source.|I'll look into it.";
$QuestNPC::conversations[39, 39, 1, 1, 0] = "Rest if you need it. Nibelheim stands with its helpers.|Thanks.";

// =====================
// QUEST INITIALIZATION
// =====================
$QuestBotList = "";

function InitQuests() {
	$Quest::UseZoneSpawns = True;
    %questBotId = 1;

    while($QuestNPC::name[%questBotId] != "") {
		$QuestNPC::zone[%questBotId] = Quest::ResolveZone($QuestNPC::pos[%questBotId]);

		if(!$Quest::UseZoneSpawns)
			Quest::Spawn(%questBotId);

		%questBotId++;
    }
}

function Quest::ResolveZone(%pos) {
	%closest = 99999;
	%fid = "";

	for(%z = 1; %z <= $numZones; %z++) {
		%rad = ($Zone::Length[%z] + $Zone::Width[%z] + $Zone::Height[%z]) / 3;
		%dist = Vector::getDistance(%pos, $Zone::Marker[%z]);
		if(%dist <= %rad) {
			if(%dist < %closest) {
				%closest = %dist;
				%fid = $Zone::FolderID[%z];
			}
		}
	}

	return %fid;
}

function Quest::OnZoneEnter(%clientId, %zoneId) {
	Quest::SpawnZone(%zoneId);
}

function Quest::OnZoneExit(%clientId, %zoneId) {
	if(%zoneId == "" || %zoneId == False)
		return;

	%remaining = Zone::getNumPlayers(%zoneId, False) - 1;
	if(%remaining <= 0)
		Quest::DespawnZone(%zoneId);
}

function Quest::SpawnZone(%zoneId) {
	for(%questBotId = 1; $QuestNPC::name[%questBotId] != ""; %questBotId++) {
		if($QuestNPC::zone[%questBotId] == %zoneId)
			Quest::Spawn(%questBotId);
	}
}

function Quest::DespawnZone(%zoneId) {
	for(%questBotId = 1; $QuestNPC::name[%questBotId] != ""; %questBotId++) {
		if($QuestNPC::zone[%questBotId] == %zoneId)
			Quest::Despawn(%questBotId);
	}
}

function Quest::Spawn(%questBotId) {
	if($QuestNPC::active[%questBotId] != "")
		return $QuestNPC::active[%questBotId];

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
	$TownBotList = $TownBotList @ %questbot @ " ";

	$QuestNPC::active[%questBotId] = %questbot;
	$QuestNPC::idToIndex[%questbot] = %questBotId;

	return %questbot;
}

function Quest::Despawn(%questBotId) {
	%id = $QuestNPC::active[%questBotId];
	if(%id == "")
		return;

	$QuestBotList = String::replace($QuestBotList, %id @ " ", "");
	$TownBotList = String::replace($TownBotList, %id @ " ", "");
	$QuestNPC::idToIndex[%id] = "";
	$QuestNPC::active[%questBotId] = "";
	deleteObject(%id);
}

function bottalk::QuestBot(%clientId, %object, %initTalk, %message) {
	%botId = %object.botId;
	%questId = $QuestNPC::questId[%botId];
	%isChatterOnly = ($Quest::stepReq[%questId, 1] == "");

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
		if(!%isChatterOnly)
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