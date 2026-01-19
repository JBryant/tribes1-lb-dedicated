//This file is part of Tribes RPG.
//Tribes RPG server side scripts
//New NPC Chat menu system written by Jason "phantom" Daley, tribesrpg.org

//	Copyright (C) 2019  Jason Daley

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

function NewBotMessage(%client, %closestId, %aimessage){//, %list){
	%clientId = %client;

	// make the bot lopok at you (btw... this is pretty intensive and could be buggy... maybe move it to chat only?)
	newRotateTownBot(%client, %closestId, GameBase::getPosition(%clientId), GameBase::getPosition(%closestId));

	if(%client.tmpbottalk == "chat"){
		AI::sayLater(%client, %closestId, %aimessage, True);
		for(%i = 0; $botMenuOption[%client,%i] != ""; %i++)
			$botMenuOption[%client,%i] = "";
		%client.tmpbottalk = "";
		return;
	}

	%aiName = %closestId.name;
	if(%client.repack > 15)//Can have longer messages
		%menuname = "Conversation with "@$BotInfo[%ainame, NAME];
	else
		%menuname = $BotInfo[%ainame, NAME];

	if(%client.keyOverride != "bottalkChoice"){
		disableOverrides(%client);
		%client.keyOverride = "bottalkChoice";
		%client.overrideKeybinds = True;
	}
	%clientPos = GameBase::getPosition(%client);
	%botPos = GameBase::getPosition(%closestId);
	%closest = Vector::getDistance(%clientPos, %botPos);

	if(%closest > $maxAIdistVec)
	{
		$state[%closestId, %client] = "";
		endBotTalkChoice(%client);
		return;
	}

	%msg = %menuname@"\n<jc>"@%aimessage@"\n\n<f2>";
	if(%client.alttext)
		%msg = %menuname@"\n<jc>"@string::newPrintFormat("<f3>"@string::replaceall(%aimessage,"<f0>","<f3>"))@"\n\n<f2>";

	%cnt = 0;
	for(%i = 0; $botMenuOption[%client,%i] != ""; %i++)
	{
		%trigger = $botMenuOption[%client,%i];
		if((%break = string::findsubstr(%trigger, "|")) > 0){
			%trigger1 = string::getsubstr(%trigger, 0, %break);
			%trigger2 = string::getsubstr(%trigger, %break+1, 999);
		}
		else{
			%trigger1 = %trigger;
			%trigger2 = %trigger;
		}
		%cnt++;
		%fcnt = %cnt;
		if(%cnt > 9){
			%fcnt = "ctrl+"@%cnt-9;
		}
		%msg = %msg @ %fcnt@": "@%trigger1@"\n";
	}
	%msg = %msg @ "\n\n0: Close menu.";
	rpg::longPrint(%client, %msg, 1, 0.7);

	%client.curNPC = %closestId;
	%aiMessage = escapeString(%aiMessage);
	schedule::add("NewBotMessage("@%client@","@%closestId@",\""@%aimessage@"\");",0.4,"NewBotMessage"@%client);
}


function endBotTalkChoice(%client){
	%client.curNPC = "";
	bottomPrint(%client,"",0);
	disableOverrides(%client);
	for(%i = 0; $botMenuOption[%client,%i] != ""; %i++)
	{
		$botMenuOption[%client,%i] = "";
	}
	$yousaid[%client] = "";
	
	// Clean up blackjack game if player was in one (but don't clear bet if game is still valid)
	// Only clean up if they're leaving mid-game without finishing
	if($BlackJack::state[%client] != "" && $BlackJack::state[%client] == "playing") {
		// Player left mid-game - we'll keep the state so they can return
		// But if they come back and bet is 0, we'll clean it up then
	}
}


function bottalkChoice(%client,%key){
	if(%key == 0){
		endBotTalkChoice(%client);
		return;
	}
		%object = %client.curNPC;
		for(%i = 0; $botMenuOption[%client,%i] != ""; %i++)
		{
			%trigger = $botMenuOption[%client,%i];
			if((%break = string::findsubstr(%trigger, "|")) > 0){
				%trigger1 = string::getsubstr(%trigger, 0, %break);
				%trigger2 = string::getsubstr(%trigger, %break+1, 999);
			}
			else{
				%trigger1 = %trigger;
				%trigger2 = %trigger;
			}
			%cnt++;
			if(%cnt == %key){
				%msg = %trigger2;
				%validOption = True;
				break;
			}
		}

	if(%validOption){
		endBotTalkChoice(%client);
		$yousaid[%client] = %msg;
		eval("bottalk::"@clipTrailingNumbers(%object.name)@"("@%client@","@%object@",False,\"#say "@%msg@"\");");
	}
	else {
		// TODO: Select from a random list of options that say something more realistic.
		// even better if you can base it off things like race and class
		AI::sayLater(%client, %object, "What was that? Please pick an option on the list.", True);
	}
}



function processbottalk(%clientId, %TrueClientId, %message, %cropped, %w1) {
	//process TownBot talk

	%initTalk = False;
	for(%i = 0; (%w = GetWord("hail hello hi greetings yo hey sup salutations g'day howdy", %i)) != -1; %i++)
		if(String::ICompare(%cropped, %w) == 0)
			%initTalk = True;

	%clientPos = GameBase::getPosition(%TrueClientId);
	%closest = 5000000;
	%closestTownId = "";
	for(%i = 0; (%id = GetWord($TownBotList, %i)) != -1; %i++)
	{
		if(%id == "")
			continue;
		%botPos = GameBase::getPosition(%id);
		%dist = Vector::getDistance(%clientPos, %botPos);

		if(%dist < %closest)
		{
			%closest = %dist;
			%closestTownId = %id;
			%closestPos = %botPos;
		}
	}

	%closestId = %closestTownId;

	%aiName = %closestId.name;
	%displayName = $BotInfo[%aiName, NAME];

	if(%closest <= $maxAIdistVec && Client::getTeam(%TrueClientId) == GameBase::getTeam(%closestId))
	{

		//pecho(%aiName @ " " @ %closestId);
		if(%TrueClientId.curNPC != "")
			endBotTalkChoice(%TrueClientId);
		if(%initTalk)
		{
			//Rotate Bot to look at player
			%rot = Vector::getRotation(Vector::normalize(Vector::sub(%clientPos, %closestPos)));
			%rot = "0 -0 "@GetWord(%rot, 2);
			GameBase::setRotation(%closestId, %rot);
		}

		if(String::findSubStr(%cropped, "\"") != -1){
			return;
		}

		%TrueClientId.tmpbottalk = "chat";
		%fname = clipTrailingNumbers(%aiName);
		eval("bottalk::"@%fName@"("@%TrueClientId@","@%closestId@","@%initTalk@",\""@escapestring(%message)@"\");");
		//echo("bottalk::"@%fName@"("@%TrueClientId@","@%closestId@","@%initTalk@",\""@escapestring(%message)@"\");");
	}
	else
	{
		//This condition occurs when you are talking from too far of any TownBot.  All states are cleared here.
		//This means that potentially, you could initiate a conversation with the banker, travel for an hour
		//WITHOUT saying a word, come back and continue the conversation.  As soon as you speak in a way that
		//townbots hear you (#say, #shout, #tell) and are too far from them, all conversations are reset.

		//This is old code but I am leaving it in just because it could still be useful.

		for(%i = 0; (%id = GetWord($TownBotList, %i)) != -1; %i++)
			if(%id != "")
				$state[%id, %TrueClientId] = "";
	}

}

function processMercenaryTalk(%clientId, %TrueClientId, %message) {
	%clientPos = GameBase::getPosition(%TrueClientId);
	%closest = 5000000;
	%closestId = "";
	for(%i = 0; (%id = GetWord($MercBotList, %i)) != -1; %i++)
	{
		if(%id == "")
			continue;
		%botPos = GameBase::getPosition(%id);
		%dist = Vector::getDistance(%clientPos, %botPos);

		if(%dist < %closest)
		{
			%closest = %dist;
			%closestId = %id;
			%closestPos = %botPos;
		}
	}

	if(%closestId == "")
		return;

	if(%closest <= $maxAIdistVec && Client::getTeam(%TrueClientId) == GameBase::getTeam(%closestId))
	{
		if(String::findSubStr(%cropped, "\"") != -1){
			return;
		}

		%rot = Vector::getRotation(Vector::normalize(Vector::sub(%clientPos, %closestPos)));
		%rot = "0 -0 "@GetWord(%rot, 2);
		GameBase::setRotation(%closestId, %rot);
		Merc::Talk(%TrueClientId, %closestId, %message);
	}
	else
	{
		for(%i = 0; (%id = GetWord($MercBotList, %i)) != -1; %i++)
			if(%id != "")
				$state[%id, %TrueClientId] = "";
	}
}


function bottalk::merchant(%TrueClientId, %closestId, %initTalk, %message){
	//process merchant code
	%trigger[2] = "buy";

	if(%initTalk) {
		$botMenuOption[%TrueClientId,0] = "I would like to buy something.";

		if ($BotInfo[%closestId.name, GREETING] != "") {
			NewBotMessage(%TrueClientId, %closestId, $BotInfo[%closestId.name, GREETING]);
		}
		else {
			NewBotMessage(%TrueClientId, %closestId, "Did you come to see what items you can buy?");
		}
		$state[%closestId, %TrueClientId] = 1;

		PlaySound("hello.wav", GameBase::getPosition(%TrueClientId));
	}
	else if($state[%closestId, %TrueClientId] == 1) {
		if(String::findSubStr(%message, %trigger[2]) != -1) {
			SetupShop(%TrueClientId, %closestId);
			// AI::sayLater(%TrueClientId, %closestId, "Take a look at what I have.", True);
			$state[%closestId, %TrueClientId] = "";
		}
	}
}


function bottalk::banker(%TrueClientId, %closestId, %initTalk, %message){
	%w1 = GetWord(%message, 0);
	%cropped = String::NEWgetSubStr(%message, (String::len(%w1)+1), 99999);
	//process banker code
	%trigger[2] = "deposit";
	%trigger[3] = "withdraw";
	%trigger[4] = "storage";
	%aiName = %closestId.name;
	%aiGender = $BotInfo[%aiName, RACE];

	if(%initTalk) {
		if(%TrueClientId.repack < 16) {
			$botMenuOption[%TrueClientId,0] = "deposit";
			$botMenuOption[%TrueClientId,1] = "withdraw";
			$botMenuOption[%TrueClientId,2] = "storage";
		}
		else {
			$botMenuOption[%TrueClientId,0] = "I would like to deposit coins.";
			$botMenuOption[%TrueClientId,1] = "I would like to withdraw coins.";
			$botMenuOption[%TrueClientId,2] = "I would like to check my storage.";
		}
		
		if ($BotInfo[%closestId.name, GREETING] != "") {
			NewBotMessage(%TrueClientId, %closestId, $BotInfo[%closestId.name, GREETING] @ "  DEPOSIT, WITHDRAW or look at your STORAGE?  You are carrying " @ Number::Beautify(fetchData(%TrueClientId, "COINS")) @ " coins and I have " @ Number::Beautify(fetchData(%TrueClientId, "BANK")) @ " of yours.");
		} else {
			NewBotMessage(%TrueClientId, %closestId, "I can keep your money from being stolen by thieves.  DEPOSIT, WITHDRAW or look at your STORAGE?  You are carrying " @ Number::Beautify(fetchData(%TrueClientId, "COINS")) @ " coins and I have " @ Number::Beautify(fetchData(%TrueClientId, "BANK")) @ " of yours.");
		}

		$state[%closestId, %TrueClientId] = 1;
	}
	else if($state[%closestId, %TrueClientId] == 1) {
		if(String::findSubStr(%message, %trigger[2]) != -1) {
			//deposit question
			%max = fetchData(%TrueClientId, "COINS");
			%half = floor(%max/2);
			$botMenuOption[%TrueClientId,0] = "all";
			if(%half > 0)
				$botMenuOption[%TrueClientId,1] = "half("@ Number::Beautify(%half) @")|"@%half;
			if(%max > 500)
				$botMenuOption[%TrueClientId,2] = 500;
			if(%max > 1000)
				$botMenuOption[%TrueClientId,3] = 1000;
			if(%max > 2000)
				$botMenuOption[%TrueClientId,4] = 2000;
			if(%max > 5000)
				$botMenuOption[%TrueClientId,5] = 5000;
			if(%max > 10000)
				$botMenuOption[%TrueClientId,6] = 10000;
			%msg = "How much do you want me to hold? You are carrying " @ Number::Beautify(fetchData(%TrueClientId, "COINS")) @ " coins and I have " @ Number::Beautify(fetchData(%TrueClientId, "BANK")) @ " of yours.";
			if(%client.tmpbottalk == "chat")
				%msg = %msg @ " You may also <f1>#say<f0> an amount.";
			NewBotMessage(%TrueClientId, %closestId, %msg);
			$state[%closestId, %TrueClientId] = 2;
		}

		if(String::findSubStr(%message, %trigger[3]) != -1) {
			//withdraw question
			%max = fetchData(%TrueClientId, "BANK");
			%half = floor(%max/2);
			$botMenuOption[%TrueClientId,0] = "all";
			if(%half > 0)
				$botMenuOption[%TrueClientId,1] = "half("@ Number::Beautify(%half) @")|"@%half;
			if(%max > 500)
				$botMenuOption[%TrueClientId,2] = 500;
			if(%max > 1000)
				$botMenuOption[%TrueClientId,3] = 1000;
			if(%max > 2000)
				$botMenuOption[%TrueClientId,4] = 2000;
			if(%max > 5000)
				$botMenuOption[%TrueClientId,5] = 5000;
			if(%max > 10000)
				$botMenuOption[%TrueClientId,6] = 10000;

			%msg = "How much do you want to take out? You are carrying " @ Number::Beautify(fetchData(%TrueClientId, "COINS")) @ " coins and I have " @ Number::Beautify(fetchData(%TrueClientId, "BANK")) @ " of yours.";
			
			if(%client.tmpbottalk == "chat")
				%msg = %msg  @ " You may also <f1>#say<f0> an amount.";
			
				NewBotMessage(%TrueClientId, %closestId, %msg);
			$state[%closestId, %TrueClientId] = 3;
		}
		if(String::findSubStr(%message, %trigger[4]) != -1) {
			//storage
			AI::sayLater(%TrueClientId, %closestId, "This is the equipment you have stored here.", True);
			SetupBank(%TrueClientId, %closestId);
			$state[%closestId, %TrueClientId] = "";
		}
	}
	else if($state[%closestId, %TrueClientId] == 2) {
		//deposit
		if(%cropped == "all")
			%cropped = fetchData(%TrueClientId, "COINS");
		
		%c = floor(%cropped);
		if(%c <= 0) {
			//I think this "error" message is alot more natural sounding than the old robo-banker.
			NewBotMessage(%TrueClientId, %closestId, "Huh? I didn't understand that. Can you say that more clearly?");
			//AI::sayLater(%TrueClientId, %closestId, "Invalid request.  Your transaction has been cancelled.~wError_Message.wav", True);
		}
		else if(%c <= fetchData(%TrueClientId, "COINS")) {
			storeData(%TrueClientId, "BANK", %c, "inc");
			storeData(%TrueClientId, "COINS", %c, "dec");
			RefreshAll(%TrueClientId);

			NewBotMessage(%TrueClientId, %closestId, "You have given me " @ Number::Beautify(%c) @ " coins. You are now carrying " @ Number::Beautify(fetchData(%TrueClientId, "COINS")) @ " coins and I have " @ Number::Beautify(fetchData(%TrueClientId, "BANK")) @ " of yours.  Have a nice day.");

			playSound(SoundMoney1, GameBase::getPosition(%closestId));
		}
		else {

			NewBotMessage(%TrueClientId, %closestId, "Sorry, you don't seem to have that many coins.");
			//AI::sayLater(%TrueClientId, %closestId, "Sorry, you don't seem to have that many coins. Your transaction has been cancelled.", True);
			//beep beep robo-banker sez "duz not compute"
		}
		$state[%closestId, %TrueClientId] = "";
	}
	else if($state[%closestId, %TrueClientId] == 3)
	{
		//withdraw
		if(%cropped == "all")
			%cropped = fetchData(%TrueClientId, "BANK");
		%c = floor(%cropped);
		if(%c <= 0)
		{
			NewBotMessage(%TrueClientId, %closestId, "Huh? didn't understand that. Can you say that more clearly?");
			//AI::sayLater(%TrueClientId, %closestId, "Invalid request.  Your transaction has been cancelled.~wError_Message.wav", True);
			//BEEP BOOP
		}
	else if(%c <= fetchData(%TrueClientId, "BANK"))
		{
			storeData(%TrueClientId, "COINS", %c, "inc");
			storeData(%TrueClientId, "BANK", %c, "dec");
			RefreshAll(%TrueClientId);
			NewBotMessage(%TrueClientId, %closestId, "I have given you " @ Number::Beautify(%c) @ " coins. You are now carrying " @ Number::Beautify(fetchData(%TrueClientId, "COINS")) @ " coins and I have " @ Number::Beautify(fetchData(%TrueClientId, "BANK")) @ " of yours.  Have a nice day.");

			playSound(SoundMoney1, GameBase::getPosition(%TrueClientId));
		}
		else
		{
			NewBotMessage(%TrueClientId, %closestId, "I'm sorry but you don't have that many coins in my bank.");
			//AI::sayLater(%TrueClientId, %closestId, "I'm sorry but you don't have that many coins in my bank.  Your transaction has been cancelled.", True);
			//You know, Robots was a pretty decent movie, you should watch it.
		}
		$state[%closestId, %TrueClientId] = "";
	}
}


function bottalk::assassin(%TrueClientId, %closestId, %initTalk, %message){
	%w1 = GetWord(%message, 0);
	%cropped = String::NEWgetSubStr(%message, (String::len(%w1)+1), 99999);
	//process assassin code
	%trigger[2] = "yes";
	%trigger[3] = "no";
	%trigger[4] = "buy";
	if(%initTalk)
	{
		//%clist = "buy ";
		%highest = -1;
		%list = GetPlayerIdList();
		for(%i = 0; (%id = GetWord(%list, %i)) != -1; %i++)
		{
			if(%curItem < 8){
				//%clist = %clist @ rpg::getname(%id)@ " ";
				$botMenuOption[%TrueClientId,%i+1] = rpg::getname(%id);
			}
			if(fetchData(%id, "bounty") == "")
				storeData(%id, "bounty", 0);
			if(fetchData(%id, "bounty") > %highest)
			{
				%h = %id;
				%highest = fetchData(%id, "bounty");
			}
		}
		%n = rpg::getname(%h);
		%c = fetchData(%h, "bounty");
		%aiGender = $BotInfo[%aiName, RACE];
		playSound("Sound" @ %aiGender @ "Hey", GameBase::getPosition(%closestId));
		$botMenuOption[%TrueClientId,0] = "I want to buy LCK.";//higher numbers reserved for player names
		NewBotMessage(%TrueClientId, %closestId, "The highest bounty is currently on " @ %n @ " for $" @  Number::Beautify(%c) @ ". Give me someone's name and I'll tell you their bounty, unless you want to buy something.");
		$state[%closestId, %TrueClientId] = 1;
	}
	else if($state[%closestId, %TrueClientId] == 1)
	{
		if(String::findSubStr(%message, %trigger[4]) != -1)
		{
			%cost = GetLCKcost(%TrueClientId);
			$botMenuOption[%TrueClientId,0] = "yes";
			$botMenuOption[%TrueClientId,1] = "no";
			NewBotMessage(%TrueClientId, %closestId, "I will sell you one LCK point for $" @  Number::Beautify(%cost) @ ". (YES/NO)");
			$state[%closestId, %TrueClientId] = 2;
		}
		else
		{
			%lowest = 99999;
			%h = "";
			%list = GetPlayerIdList();
			for(%i = 0; (%id = GetWord(%list, %i)) != -1; %i++)
			{
				%comp = String::ICompare(%cropped, rpg::getname(%id));
				if(%comp < 0) %comp = -%comp;
				if(%comp < %lowest)
				{
					%h = %id;
					%lowest = %comp;
				}
			}
			if(%h != "")
			{
				%l = fetchData(%h, "LVL");
				%c = getFinalCLASS(%h);
				$botMenuOption[%TrueClientId,0] = "yes";
				$botMenuOption[%TrueClientId,1] = "no";
				NewBotMessage(%TrueClientId, %closestId, "Are you talking about " @ rpg::getname(%h) @ " the Level " @ %l @ " " @ %c @ "?");
				storeData(%TrueClientId, "tmpdata", %h);
				$state[%closestId, %TrueClientId] = 3;
			}
			else
			{
				%aiGender = $BotInfo[%aiName, RACE];
				playSound("Sound" @ %aiGender @ "Bye", GameBase::getPosition(%closestId));
				NewBotMessage(%TrueClientId, %closestId, "I have no idea who you are talking about. Goodbye.");
				$state[%closestId, %TrueClientId] = "";
			}
		}
	}
	else if($state[%closestId, %TrueClientId] == 2)
	{
		if(String::findSubStr(%message, %trigger[2]) != -1)
		{
			%cost = GetLCKcost(%TrueClientId);
			if(fetchData(%TrueClientId, "COINS") >= %cost)
			{
				NewBotMessage(%TrueClientId, %closestId, "Here's your LCK point, thanks for your business.");
				GiveThisStuff(%TrueClientId, "LCK 1", True);
				storeData(%TrueClientId, "COINS", %cost, "dec");
				RefreshAll(%TrueClientId);
			}
			else
				NewBotMessage(%TrueClientId, %closestId, "You can't afford this.");
			$state[%closestId, %TrueClientId] = "";
		}
		else if(String::findSubStr(%message, %trigger[3]) != -1)
		{
			AI::sayLater(%TrueClientId, %closestId, "See ya.", True);
			$state[%closestId, %TrueClientId] = "";
		}
	}
	else if($state[%closestId, %TrueClientId] == 3)
	{
		if(String::findSubStr(%message, %trigger[2]) != -1)
		{
			%id = fetchData(%TrueClientId, "tmpdata");
			if(%id != %TrueClientId)
			{
				%n = rpg::getname(%id);
				if(IsInCommaList(fetchData(%TrueClientId, "TempKillList"), %n))
				{
					storeData(%TrueClientId, "TempKillList", RemoveFromCommaList(fetchData(%TrueClientId, "TempKillList"), %n));
					NewBotMessage(%TrueClientId, %closestId, "I see you've killed " @ %n @ ". Here's your reward... " @  Number::Beautify(fetchData(%id, "bounty")) @ " coins. Goodbye.", "");
					storeData(%TrueClientId, "COINS", fetchData(%id, "bounty"), "inc");
					storeData(%id, "bounty", 0);
					playSound(SoundMoney1, GameBase::getPosition(%TrueClientId));
					RefreshAll(%TrueClientId);
				}
				else
					NewBotMessage(%TrueClientId, %closestId, %n @ "'s bounty is currently at " @ Number::Beautify(fetchData(%id, "bounty")) @ " coins. Goodbye.", "");
			}
			else
					NewBotMessage(%TrueClientId, %closestId, "You can't get a reward for killing yourself... idiot.", "");
			$state[%closestId, %TrueClientId] = "";
		}
		else if(String::findSubStr(%message, %trigger[3]) != -1)
		{
			NewBotMessage(%TrueClientId, %closestId, "Well then, I have no idea who you are talking about. Goodbye.", "");
			storeData(%TrueClientId, "tmpdata", "");
			$state[%closestId, %TrueClientId] = "";
		}
	}
}

function bottalk::porter(%TrueClientId, %closestId, %initTalk, %message){
	//process porter code
	%trigger[2] = "enter";
	if(%initTalk)
	{
		if($arenaOn)
		{
			$botMenuOption[%TrueClientId,0] = "I want to enter the arena.";
			NewBotMessage(%TrueClientId, %closestId, "I am in charge of admitting fighters. Do you want to ENTER for $" @ $teleportInArenaCost @ "?");
			$state[%closestId, %TrueClientId] = 1;
		}
		else
		{
			NewBotMessage(%TrueClientId, %closestId, "The arena's not available right now, we're still cleaning up the mess from when one of the fighters exploded. It was really gory and awesome. But you can't see it. Sorry.");
			$state[%closestId, %TrueClientId] = "";
		}
	}
	else if($state[%closestId, %TrueClientId] == 1)
	{
		if(String::findSubStr(%message, %trigger[2]) != -1)
		{
			if(fetchData(%TrueClientId, "COINS") >= $teleportInArenaCost)
			{
				%retval = TeleportToMarker(%TrueClientId, "TheArena\\TeleportEntranceMarkers", 1, 0);
				if(%retval != False)
				{
					storeData(%TrueClientId, "COINS", $teleportInArenaCost, "dec");
					storeData(%TrueClientId, "inArena", 1);
					RefreshArenaTextBox(%TrueClientId);
					RefreshAll(%TrueClientId);

					$state[%closestId, %TrueClientId] = "";
				}
				else
				{
					NewBotMessage(%TrueClientId, %closestId, "Hmmm... I guess there are people standing in the way of the teleport destinations. Try again later.");
					$state[%closestId, %TrueClientId] = "";
				}
			}
			else
			{
				NewBotMessage(%TrueClientId, %closestId, "You don't even have that many coins. Sorry, you can't get in.");
				$state[%closestId, %TrueClientId] = "";
			}
		}
	}
}

function bottalk::quest(%TrueClientId, %closestId, %initTalk, %message) {
	%aiName = %closestId.name;
	
	// allow dyanmic amount of talking triggers
    %triggerCount = 0;
    %trigger[%triggerCount++] = "buy";

    %index = 1;
    while ($BotInfo[%aiName, CUE, %index] != "") {
        %trigger[%triggerCount++] = $BotInfo[%aiName, CUE, %index];
        %trigger[%triggerCount++] = $BotInfo[%aiName, NCUE, %index];
        %index++;
    }
	
	%hasTheStuff = HasThisStuff(%TrueClientId, $BotInfo[%aiName, NEED]);

	if($BotInfo[%aiName, CSAY] == "" && %hasTheStuff == 666)
		%hasTheStuff = False;
	if($BotInfo[%aiName, LSAY] == "" && %hasTheStuff == 667)
		%hasTheStuff = False;

    // if they say "buy" check if they have anything to shop (should we even show buy if they dont have anything to sell?)
	if (String::findSubStr(%message, %trigger[1]) != -1) {
        if ($BotInfo[%aiName, SHOP] != "" || $BotInfo[%aiName, BELTSHOP] != "") {
            SetupShop(%TrueClientId, %closestId);
            AI::sayLater(%TrueClientId, %closestId, "Take a look at what I have.", True);
        } else {
            NewBotMessage(%TrueClientId, %closestId, "Oh, well I have nothing to sell.");
        }
        $state[%closestId, %TrueClientId] = "";
        return;
    }

	if(%hasTheStuff == 666 && %initTalk) { // $state[%closestId, %TrueClientId] == "")
		NewBotMessage(%TrueClientId, %closestId, $BotInfo[%aiName, CSAY], True);
		$state[%closestId, %TrueClientId] = -5;
	}
	else if(%hasTheStuff == 667 && %initTalk) { // $state[%closestId, %TrueClientId] == "")
		NewBotMessage(%TrueClientId, %closestId, $BotInfo[%aiName, LSAY], True);
		$state[%closestId, %TrueClientId] = -5;
	}
	else if(%hasTheStuff == False) {
		if(%initTalk) {
			$botMenuOption[%TrueClientId,0] = %trigger[2];
			if ($BotInfo[%aiName, SHOP] != "" || $BotInfo[%aiName, BELTSHOP] != "") {
				$botMenuOption[%TrueClientId,1] = "Have anything for me to buy?";
			}
			NewBotMessage(%TrueClientId, %closestId, $BotInfo[%aiName, SAY, 1] @ " [" @ %trigger[2] @ "]", True);
			$state[%closestId, %TrueClientId] = 1;
		}
		else if($state[%closestId, %TrueClientId] == 1) {
            // LongBow: Allow even more talking... they can talk all day now if they want
			%dialogueIndex = 1;
			while ($BotInfo[%aiName, SAY, %dialogueIndex + 1] != "" && %trigger[%dialogueIndex * 2] != "") {
				%triggerIdx = %dialogueIndex * 2;
				if(String::findSubStr(%message, %trigger[%triggerIdx]) != -1) {
					if (%trigger[%triggerIdx + 2] != "") {
						$botMenuOption[%TrueClientId,0] = %trigger[%triggerIdx + 2];
						NewBotMessage(%TrueClientId, %closestId, $BotInfo[%aiName, SAY, %dialogueIndex + 1] @ " [" @ %trigger[%triggerIdx + 2] @ "]", True);
					} else {
						NewBotMessage(%TrueClientId, %closestId, $BotInfo[%aiName, SAY, %dialogueIndex + 1], True);
						$state[%closestId, %TrueClientId] = "";
					}	
				}
				%dialogueIndex++;
			}
		}
	}
	else if(%hasTheStuff == True)
	{
		if(%initTalk)
		{
			$botMenuOption[%TrueClientId,0] = %trigger[3];
			$botMenuOption[%TrueClientId,1] = "Have anything for me to buy?";
			NewBotMessage(%TrueClientId, %closestId, $BotInfo[%aiName, NSAY, 1] @ " [" @ %trigger[3] @ "]", True);
			$state[%closestId, %TrueClientId] = 1;
		}
		else if($state[%closestId, %TrueClientId] == 1)
		{
			if(String::findSubStr(%message, %trigger[3]) != -1)
			{
				if(HasThisStuff(%TrueClientId, $BotInfo[%aiName, NEED]))
				{
					if($BotInfo[%aiName, TAKE] != "")
						TakeThisStuff(%TrueClientId, $BotInfo[%aiName, TAKE], True);
					if($BotInfo[%aiName, GIVE] != "")
						GiveThisStuff(%TrueClientId, $BotInfo[%aiName, GIVE], True);

					NewBotMessage(%TrueClientId, %closestId, $BotInfo[%aiName, NSAY, 2], True);
				}
				else
					AI::sayLater(%TrueClientId, %closestId, "Nice try, I'm keeping what I managed to get from you.", True);
	
				$state[%closestId, %TrueClientId] = "";
				Game::refreshClientScore(%TrueClientId);
			}
		}
	}
}


function bottalk::botmaker(%TrueClientId, %closestId, %initTalk, %message){
	%w1 = GetWord(%message, 0);
	%cropped = String::NEWgetSubStr(%message, (String::len(%w1)+1), 99999);
	%aiName = %closestId.name;
	//process botmaker code
	%trigger[2] = "yes";
	%trigger[3] = "no";
	if(%initTalk)
	{
		if(CountObjInCommaList($PetList) >= $maxPets)
		{
			NewBotMessage(%TrueClientId, %closestId, "I'm sorry but all my helpers are already on duty.");
			$state[%closestId, %TrueClientId] = "";
		}
		else if(CountObjInCommaList(fetchData(%TrueClientId, "PersonalPetList")) >= $maxPetsPerPlayer)
		{
			NewBotMessage(%TrueClientId, %closestId, "I'm sorry but you have too many helpers currently at your disposal.");
			$state[%closestId, %TrueClientId] = "";
		}
		else
		{
			$botMenuOption[%TrueClientId,0] = "squire";
			$botMenuOption[%TrueClientId,1] = "chemist";
			// $botMenuOption[%TrueClientId,2] = "paladin";
			// $botMenuOption[%TrueClientId,3] = "thief";
			// $botMenuOption[%TrueClientId,4] = "bard";
			// $botMenuOption[%TrueClientId,5] = "ranger";
			// $botMenuOption[%TrueClientId,6] = "squire";
			// $botMenuOption[%TrueClientId,7] = "chemist";
			NewBotMessage(%TrueClientId, %closestId, "I have all sorts of helpers at my disposal. Tell me which class you are interested in.");
			$state[%closestId, %TrueClientId] = 1;
		}
	}
	else if($state[%closestId, %TrueClientId] == 1)
	{
		%class = GetWord(%cropped, 0);
		%gender = GetWord(%cropped, 1);
		%defaults = $BotInfo[%aiName, DEFAULTS, %class];
		if(%gender == -1)
			%gender = "Male";

		if(String::ICompare(%gender, "male") == 0)
		{
			%gender = "Male";
			%gflag = True;
		}
		else if(String::ICompare(%gender, "female") == 0)
		{
			%gender = "Female";
			%gflag = True;
		}

		// if(String::ICompare(%class, "mage") == 0)
		// 	%class = "Mage";
		// else if(String::ICompare(%class, "fighter") == 0)
		// 	%class = "Fighter";
		// else if(String::ICompare(%class, "paladin") == 0)
		// 	%class = "Paladin";
		// else if(String::ICompare(%class, "thief") == 0)
		// 	%class = "Thief";
		// else if(String::ICompare(%class, "bard") == 0)
		// 	%class = "Bard";
		// else if(String::ICompare(%class, "ranger") == 0)
		// 	%class = "Ranger";
		else if(String::ICompare(%class, "squire") == 0)
			%class = "Squire";
		else if(String::ICompare(%class, "chemist") == 0)
			%class = "Chemist";

		if(%defaults != "")
		{
			if(%gflag)
			{
				%lvl = GetStuffStringCount(%defaults, "LVL");
				%nc = pow(%lvl, 2) * 3;
				$tmpdata[%TrueClientId, 1] = %class;
				$tmpdata[%TrueClientId, 2] = %gender;
				$tmpdata[%TrueClientId, 3] = %nc;	//just so the equation is only in one place.

				$botMenuOption[%TrueClientId,0] = "yes";
				$botMenuOption[%TrueClientId,1] = "no";
				NewBotMessage(%TrueClientId, %closestId, "My " @ %class @ "s are Level " @ %lvl @ ", and will cost you " @ %nc @ " coins. [yes/no]");
				$state[%closestId, %TrueClientId] = 2;
			}
			else
			{
				NewBotMessage(%TrueClientId, %closestId, "Invalid gender. Use 'male' or 'female'.");
				$state[%closestId, %TrueClientId] = "";
			}
		}
		else
		{
			NewBotMessage(%TrueClientId, %closestId, "Invalid class. Use any of the following: squire chemist.");
			$state[%closestId, %TrueClientId] = "";
		}
	}
	else if($state[%closestId, %TrueClientId] == 2)
	{
		if(String::findSubStr(%message, %trigger[2]) != -1)
		{
			%nc = $tmpdata[%TrueClientId, 3];

			if(%nc <= 0)
			{
				NewBotMessage(%TrueClientId, %closestId, "Invalid request.  Your transaction has been cancelled.~wError_Message.wav");
				$state[%closestId, %TrueClientId] = "";
			}
			else if(%nc <= fetchData(%TrueClientId, "COINS"))
			{
				%class = $tmpdata[%TrueClientId, 1];
				%gender = $tmpdata[%TrueClientId, 2];
				%defaults = $BotInfo[%aiName, DEFAULTS, %class];
				%lvl = GetStuffStringCount(%defaults, "LVL");
	
				storeData(%TrueClientId, "COINS", %nc, "dec");
				playSound(SoundMoney1, GameBase::getPosition(%closestId));
				RefreshAll(%TrueClientId);

				%n = "";
				for(%i = 0; (%a = GetWord($BotInfo[%aiName, NAMES], %i)) != -1; %i++)
				{
					if(NEWgetClientByName(%a) == -1)
					{
						%n = %a;
						break;
					}
				}
				if(%n == "")
					%n = "generic";

				$BotEquipment[generic] = "CLASS " @ %class @ " " @ %defaults;
				%spawnPos = "-2487.32 -58.0211 108.125";
				//%an = AI::helper("generic", %n, "TempSpawn " @ GameBase::getPosition($BotInfo[%aiName, DESTSPAWN]) @ " " @ GameBase::getTeam(%TrueClientId));
				%an = AI::helper("generic", %n, "TempSpawn " @ %spawnPos @ " " @ GameBase::getTeam(%TrueClientId));
				%id = AI::getId(%an);
				ChangeRace(%id, %gender @ "Human");
				storeData(%id, "tmpbotdata", %TrueClientId);
				storeData(%id, "botAttackMode", 2);

				schedule("Pet::BeforeTurnEvil(" @ %id @ ");", 55*60, Client::getOwnedObject(%id));
				schedule("Pet::TurnEvil(" @ %id @ ");", 60*60, Client::getOwnedObject(%id));

				$PetList = AddToCommaList($PetList, %id);
				storeData(%TrueClientId, "PersonalPetList", AddToCommaList(fetchData(%TrueClientId, "PersonalPetList"), %id));
				storeData(%id, "petowner", %TrueClientId);
				storeData(%id, "OwnerID", %TrueClientId);
						
				AI::sayLater(%TrueClientId, %closestId, "This is " @ %n @ ", a Level " @ %lvl @ " " @ %class @ "! He is at your disposal. He will follow you around and fight for you for the next hour.", True);
				$state[%closestId, %TrueClientId] = "";
			}
			else
			{
				NewBotMessage(%TrueClientId, %closestId, "You don't have enough coins. Goodbye.");
				$state[%closestId, %TrueClientId] = "";
			}

		}
		else if(String::findSubStr(%message, %trigger[3]) != -1)
		{
			NewBotMessage(%TrueClientId, %closestId, "As you wish. Goodbye.");
			$state[%closestId, %TrueClientId] = "";
		}
	}
}

function bottalk::mercenary(%TrueClientId, %closestId, %initTalk, %message){
	%w1 = GetWord(%message, 0);
	%cropped = String::NEWgetSubStr(%message, (String::len(%w1)+1), 99999);
	%aiName = %closestId.name;
	%trigger[2] = "yes";
	%trigger[3] = "no";

	Merc::Init();

	if(%initTalk)
	{
		%TrueClientId.tmpbottalk = "";
		for(%i = 0; %i < 20; %i++)
			$botMenuOption[%TrueClientId, %i] = "";

		if(Merc::GetOwnerMerc(%TrueClientId) != "")
		{
			NewBotMessage(%TrueClientId, %closestId, "You already have a mercenary. Dismiss them before hiring another.");
			$state[%closestId, %TrueClientId] = "";
			return;
		}

		%idx = 0;
		%max = Merc::GetCount();
		if(%max <= 0)
		{
			Merc::Init();
			%max = Merc::GetCount();
		}
		for(%i = 1; %i <= %max; %i++)
		{
			if($Merc::name[%i] == "")
				continue;
			%opt = $Merc::name[%i] @ " - " @ $Merc::class[%i] @ " (" @ $Merc::cost[%i] @ " coins)|merc " @ %i;
			$botMenuOption[%TrueClientId, %idx] = %opt;
			%idx++;
		}

		if(%idx <= 0)
		{
			NewBotMessage(%TrueClientId, %closestId, "No mercenaries are available right now.");
			$state[%closestId, %TrueClientId] = "";
			return;
		}

		NewBotMessage(%TrueClientId, %closestId, "Looking to hire a mercenary? Pick one from the list.");
		$state[%closestId, %TrueClientId] = 1;
	}
	else if($state[%closestId, %TrueClientId] == 1)
	{
		if(String::findSubStr(%cropped, "merc") != -1)
		{
			%templateId = floor(getWord(%cropped, 1));
			if($Merc::name[%templateId] == "")
			{
				NewBotMessage(%TrueClientId, %closestId, "That mercenary is not available.");
				$state[%closestId, %TrueClientId] = "";
				return;
			}

			$tmpdata[%TrueClientId, "MercTemplate"] = %templateId;
			$botMenuOption[%TrueClientId,0] = "yes";
			$botMenuOption[%TrueClientId,1] = "no";
			NewBotMessage(%TrueClientId, %closestId, "Hire a " @ $Merc::name[%templateId] @ " for " @ $Merc::cost[%templateId] @ " coins? [yes/no]");
			$state[%closestId, %TrueClientId] = 2;
		}
	}
	else if($state[%closestId, %TrueClientId] == 2)
	{
		if(String::findSubStr(%message, %trigger[2]) != -1)
		{
			%templateId = $tmpdata[%TrueClientId, "MercTemplate"];
			%cost = $Merc::cost[%templateId];

			if(%templateId == "" || %cost <= 0)
			{
				NewBotMessage(%TrueClientId, %closestId, "Invalid request. Your transaction has been cancelled.~wError_Message.wav");
				$state[%closestId, %TrueClientId] = "";
				return;
			}

			if(Merc::GetOwnerMerc(%TrueClientId) != "")
			{
				NewBotMessage(%TrueClientId, %closestId, "You already have a mercenary.");
				$state[%closestId, %TrueClientId] = "";
				return;
			}

			if(%cost <= fetchData(%TrueClientId, "COINS"))
			{
				storeData(%TrueClientId, "COINS", %cost, "dec");
				playSound(SoundMoney1, GameBase::getPosition(%closestId));
				RefreshAll(%TrueClientId);

				%id = Merc::SpawnFor(%TrueClientId, %templateId);
				if(%id == "")
				{
					NewBotMessage(%TrueClientId, %closestId, "Something went wrong. Please try again.");
					$state[%closestId, %TrueClientId] = "";
					return;
				}

				AI::sayLater(%TrueClientId, %closestId, "Your mercenary is ready and will follow you. Use #merc to control them.", True);
				$state[%closestId, %TrueClientId] = "";
			}
			else
			{
				NewBotMessage(%TrueClientId, %closestId, "You don't have enough coins.");
				$state[%closestId, %TrueClientId] = "";
			}
		}
		else if(String::findSubStr(%message, %trigger[3]) != -1)
		{
			NewBotMessage(%TrueClientId, %closestId, "As you wish. Goodbye.");
			$state[%closestId, %TrueClientId] = "";
		}
	}
}

function bottalk::blacksmith(%TrueClientId, %closestId, %initTalk, %message){
	%aiName = %closestId.name;
	//process smith code
	%trigger[2] = "buy";
	%trigger[3] = "smith";

	if(%initTalk)
	{
		if($BotInfo[%aiName, SHOP] != "")
			$botMenuOption[%TrueClientId,0] = "Buy";
		NewBotMessage(%TrueClientId, %closestId, "Hail friend, look at the anvil and say #smith to smith things.");
		$state[%closestId, %TrueClientId] = 1;

		//We stop using the blacksmith because it isn't belt-compatible.
		return;
		$botMenuOption[%TrueClientId,0] = "Yeah I'd like to smith.";
		NewBotMessage(%TrueClientId, %closestId, "Hail friend, are you here to have me SMITH an old weapon?");
		$state[%closestId, %TrueClientId] = 1;
	}
	else if($state[%closestId, %TrueClientId] == 1)
	{
		if(String::findSubStr(%message, %trigger[2]) != -1)
		{
			if($BotInfo[%aiName, SHOP] != "")
			{
				SetupShop(%TrueClientId, %closestId);
				AI::sayLater(%TrueClientId, %closestId, "Take a look at what I have.", True);
			}
			else
				NewBotMessage(%TrueClientId, %closestId, "I have nothing to sell.");
			$state[%closestId, %TrueClientId] = "";
		}
		//We stop using the blacksmith because it isn't belt-compatible.
		return;
		if(String::findSubStr(%message, %trigger[3]) != -1)
		{
			AI::sayLater(%TrueClientId, %closestId, "Click Use on an item and I will tell you how much it will cost to smith. Click Use on this item again and I will get to work.", True);
			SetupBlacksmith(%TrueClientId, %closestId);
			$state[%closestId, %TrueClientId] = "";
		}
	}
}

function bottalk::guildmaster(%TrueClientId, %closestId, %initTalk, %message){
	%w1 = GetWord(%message, 0);
	%cropped = String::NEWgetSubStr(%message, (String::len(%w1)+1), 99999);
	//process guildmaster code
	%trigger[2] = "join";
	if(%initTalk)
	{
		if(fetchData(%TrueClientId, "LVL") >= 25)
		{
			%h = fetchData(%TrueClientId, "MyHouse");
			if(%h == "")
			{
				$botMenuOption[%TrueClientId,0] = "I would like to join a guild.";
				%msg = "Hello adventurer. Are you interested in joining a guild for " @ $joinHouseCost @ " coins? By joining a guild you may be attacked by players from other guilds, at any level, when outside of protected land.";
				if(%trueClientId.tmpbottalk == "chat")
					%msg = %msg @ " [join]";
				NewBotMessage(%TrueClientId, %closestId, %msg);
				$state[%closestId, %TrueClientId] = 1;
			}
			else
			{
				$botMenuOption[%TrueClientId,0] = "I would like to join a different guild.";
				%msg = "Members of " @ %h @ " are welcome here. Are you interested in joining a new guild at the cost of " @ $changeHouseCost @ " coins and all your RP?";
				if(%trueClientId.tmpbottalk == "chat")
					%msg = %msg @  " [join]";
				NewBotMessage(%TrueClientId, %closestId, %msg);
				$state[%closestId, %TrueClientId] = 2;
			}
		}
		else
		{
			NewBotMessage(%TrueClientId, %closestId, "Come back when you are at least level 25. Goodbye.");
			$state[%closestId, %TrueClientId] = "";
		}
	}
	else if($state[%closestId, %TrueClientId] == 1 || $state[%closestId, %TrueClientId] == 2)
	{
		if(String::findSubStr(%message, %trigger[2]) != -1)
		{
			%ch = fetchData(%TrueClientId, "MyHouse");
			%hlist = "";
			%num = 0;
			for(%i = 1; $HouseName[%i] != ""; %i++)
			{
				if($HouseName[%i] != %ch){
					$botMenuOption[%TrueClientId,%num] = $HouseName[%i];
					%num++;
					%hlist = %hlist @ $HouseName[%i] @ ", ";
				}
			}
			%fhlist = String::NEWgetSubStr(%hlist, 0, String::len(%hlist)-2) @ ".";
			if($state[%closestId, %TrueClientId] == 1)
			{
				//join new house
				%msg = "Which guild would you like to join?";
				if(%trueClientId.tmpbottalk == "chat")
					%msg = %msg @ " [" @ %fhlist @ "]";
				NewBotMessage(%TrueClientId, %closestId, %msg);
				$state[%closestId, %TrueClientId] = 3;
			}
			else if($state[%closestId, %TrueClientId] == 2)
			{
				//change house
				%msg = "Which guild would you like to change to?";
				if(%trueClientId.tmpbottalk == "chat")
					%msg = %msg @ " [" @ %fhlist @ "]";
				NewBotMessage(%TrueClientId, %closestId, %msg);
				$state[%closestId, %TrueClientId] = 4;
			}
		}
	}
	else if($state[%closestId, %TrueClientId] == 3 || $state[%closestId, %TrueClientId] == 4)
	{
		%houseNum = "";
		for(%i = 1; $HouseName[%i] != ""; %i++)
		{
			if(String::ICompare(%cropped, $HouseName[%i]) == 0)
				%houseNum = %i;
		}
		if(%houseNum != "")
		{
			if($state[%closestId, %TrueClientId] == 3)
				%cost = $joinHouseCost;
			else if($state[%closestId, %TrueClientId] == 4)
				%cost = $changeHouseCost;
			%c = floor(fetchData(%TrueClientId, "COINS"));
			if(%c >= %cost)
			{
				storeData(%TrueClientId, "COINS", %cost, "dec");
				BootFromCurrentHouse(%TrueClientId, True);
				JoinHouse(%TrueClientId, %houseNum, True);
				GiveThisStuff(%TrueClientId, $HouseStartUpEq[%houseNum]);
				RefreshAll(%TrueClientId);
				NewBotMessage(%TrueClientId, %closestId, "Welcome to " @ $HouseName[%houseNum] @ "! You have "@fetchData(%TrueClientId,"RankPoints")@" rank points. Good luck on your adventures!");

				playSound(SoundMoney1, GameBase::getPosition(%TrueClientId));
			}
			else
			{
				NewBotMessage(%TrueClientId, %closestId, "I'm sorry but you do not have enough coins. Goodbye.");
			}
		}
		else
		{
			NewBotMessage(%TrueClientId, %closestId, "This guild does not exist.");
		}
		$state[%closestId, %TrueClientId] = "";
	}
}

function bottalk::manager(%TrueClientId, %closestId, %initTalk, %message){
	//process manager code
	%trigger[2] = "fight";
	%trigger[3] = "leave";
	if(!$arenaon){
		NewBotMessage(%TrueClientId, %closestId, "The arena's not available right now, we're still cleaning up the mess from when one of the fighters exploded.");
	}
	else if(%initTalk)
	{
		$botMenuOption[%TrueClientId,0] = "I want to fight!";
		$botMenuOption[%TrueClientId,1] = "Let me leave.";
		NewBotMessage(%TrueClientId, %closestId, "Hail. Do you wish to fight or leave?");
		$state[%closestId, %TrueClientId] = 1;
	}
	else if($state[%closestId, %TrueClientId] == 1)
	{
		if(String::findSubStr(%message, %trigger[2]) != -1)
		{
			//FIGHT
			%x = AddToRoster(%TrueClientId);
			if(%x != -1)
			{
				TeleportToMarker(%TrueClientId, "TheArena\\WaitingRoomMarkers", 0, 1);
				$state[%closestId, %TrueClientId] = "";
			}
			else
			{
				//arena is full
				NewBotMessage(%TrueClientId, %closestId, "Sorry, the arena roster is full right now.");
				$state[%closestId, %TrueClientId] = "";
			}
		}
		else if(String::findSubStr(%message, %trigger[3]) != -1)
		{
			$state[%closestId, %TrueClientId] = "";
			//LEAVE
			%retval = TeleportToMarker(%TrueClientId, "TheArena\\TeleportExitMarkers", 1, 0);

			if(%retval != False)
			{
				storeData(%TrueClientId, "inArena", "");
				CloseArenaTextBox(%TrueClientId);

			}
			else
			{
				NewBotMessage(%TrueClientId, %closestId, "Hmmm... I guess there are people standing in the way of the teleport destinations.  Try again later.", "");
			}
		}
	}
}

// ============================================================
// BLACKJACK BOT CONVERSATION HANDLER
// ============================================================
// Note: Blackjack game logic is in Games.cs
// This handler manages the conversation flow and UI

function bottalk::BlackJackBot(%clientId, %object, %initTalk, %message) {
	%w1 = GetWord(%message, 0);
	%cropped = String::NEWgetSubStr(%message, (String::len(%w1)+1), 99999);
	%aiName = %object.name;
	%state = $BlackJack::state[%clientId];
	
	if(%initTalk) {
		// Initial greeting
		if(%state == "") {
			// Not in a game
			$botMenuOption[%clientId, 0] = "play|play";
			$botMenuOption[%clientId, 1] = "rules|rules";
			NewBotMessage(%clientId, %object, "Welcome to the blackjack table! Would you like to <f1>PLAY<f0> a game or learn the <f1>RULES<f0>?");
			$state[%object, %clientId] = 1;
		}
		else {
			// Check if we have a valid game state (bet must exist)
			%bet = $BlackJack::bet[%clientId];
			if(%bet == "" || %bet == 0) {
				// Invalid state - bet was lost, clean up and start fresh
				BlackJack::Cleanup(%clientId);
				$state[%object, %clientId] = "";
				$botMenuOption[%clientId, 0] = "play|play";
				$botMenuOption[%clientId, 1] = "rules|rules";
				NewBotMessage(%clientId, %object, "Welcome back to the blackjack table! Your previous game was interrupted. Would you like to <f1>PLAY<f0> a new game or learn the <f1>RULES<f0>?");
				$state[%object, %clientId] = 1;
			}
			else {
				// Already in a valid game - show current state
				BlackJack::ShowGameState(%clientId, %object);
			}
		}
	}
	else if($state[%object, %clientId] == 1) {
		// Main menu
		if(String::findSubStr(%message, "play") != -1) {
			// Start betting phase
			%coins = fetchData(%clientId, "COINS");
			if(%coins < 100) {
				NewBotMessage(%clientId, %object, "You need at least 100 coins to play. You currently have " @ %coins @ " coins.");
				$state[%object, %clientId] = "";
				return;
			}
			
			// Set up bet options
			%maxBet = %coins;
			if(%maxBet > 100000)
				%maxBet = 100000;
			
			$botMenuOption[%clientId, 0] = "100|100";
			if(%maxBet >= 1000)
				$botMenuOption[%clientId, 1] = "1000|1000";
			if(%maxBet >= 5000)
				$botMenuOption[%clientId, 2] = "5000|5000";
			if(%maxBet >= 10000)
				$botMenuOption[%clientId, 3] = "10000|10000";
			if(%maxBet >= 50000)
				$botMenuOption[%clientId, 4] = "50000|50000";
			if(%maxBet >= 100000)
				$botMenuOption[%clientId, 5] = "100000|100000";
			
			NewBotMessage(%clientId, %object, "Place your bet! You have " @ Number::Beautify(%coins) @ " coins. Minimum bet is 100 coins.");
			$state[%object, %clientId] = 2;
			$BlackJack::state[%clientId] = "betting";
		}
		else if(String::findSubStr(%message, "rules") != -1) {
			// Cancel any scheduled message refresh first
			schedule::Cancel("NewBotMessage"@%clientId);
			
			// Clear existing menu options
			for(%i = 0; $botMenuOption[%clientId,%i] != ""; %i++)
				$botMenuOption[%clientId,%i] = "";
			
			%rules = "Blackjack Rules:\n\n" @
				"<f1>Goal:<f0> Get closer to 21 than the dealer without going over.\n\n" @
				"<f1>Card Values:<f0>\n" @
				"  Number cards = face value\n" @
				"  Face cards (J, Q, K) = 10\n" @
				"  Ace = 1 or 11 (whichever is better)\n\n" @
				"<f1>Blackjack:<f0> 21 with your first 2 cards pays 3:2\n\n" @
				"<f1>Actions:<f0>\n" @
				"  <f1>HIT<f0> - Take another card\n" @
				"  <f1>STAND<f0> - Keep your hand\n\n" @
				"<f1>Payouts:<f0>\n" @
				"  Win = 1:1 (double your bet)\n" @
				"  Blackjack = 3:2\n" @
				"  Push (tie) = return bet";
			
			// Set up menu options to return to main menu
			$botMenuOption[%clientId, 0] = "play|play";
			
			// Use NewBotMessage but it will schedule itself - that's okay since we want it to stay visible
			NewBotMessage(%clientId, %object, %rules);
			$state[%object, %clientId] = 1; // Return to main menu
		}
	}
	else if($state[%object, %clientId] == 2) {
		// Betting phase
		%bet = floor(%cropped);
		if(%bet <= 0)
			%bet = floor(%message);
		
		if(%bet < 100) {
			NewBotMessage(%clientId, %object, "Minimum bet is 100 coins. Please place a valid bet.");
			return;
		}
		
		%coins = fetchData(%clientId, "COINS");
		if(%bet > %coins) {
			NewBotMessage(%clientId, %object, "You don't have enough coins. You have " @ %coins @ " coins.");
			return;
		}
		
		if(%bet > 100000) {
			NewBotMessage(%clientId, %object, "Maximum bet is 100000 coins.");
			return;
		}
		
		// Deduct bet and start game
		storeData(%clientId, "COINS", -%bet, "inc");
		$BlackJack::bet[%clientId] = %bet;
		BlackJack::StartGame(%clientId);
		
		// Show initial hands
		BlackJack::ShowGameState(%clientId, %object);
		$state[%object, %clientId] = 3;
	}
	else if($state[%object, %clientId] == 3) {
		// Playing phase - validate bet exists
		%bet = $BlackJack::bet[%clientId];
		if(%bet == "" || %bet == 0) {
			// Bet was lost, clean up and return to main menu
			BlackJack::Cleanup(%clientId);
			$state[%object, %clientId] = 1;
			$botMenuOption[%clientId, 0] = "play|play";
			$botMenuOption[%clientId, 1] = "rules|rules";
			NewBotMessage(%clientId, %object, "Your game was interrupted. Please place a new bet to start a game.");
			return;
		}
		
		if($BlackJack::state[%clientId] != "playing") {
			// Game finished, show result
			BlackJack::ShowGameState(%clientId, %object, True);
			$state[%object, %clientId] = 4;
			return;
		}
		
		if(String::findSubStr(%message, "hit") != -1) {
			%result = BlackJack::PlayerHit(%clientId);
			
			if(%result == "bust") {
				// Player busted
				$BlackJack::state[%clientId] = "finished";
				BlackJack::ShowGameState(%clientId, %object, True);
				$state[%object, %clientId] = 4;
			}
			else {
				// Show updated hand
				BlackJack::ShowGameState(%clientId, %object);
			}
		}
		else if(String::findSubStr(%message, "stand") != -1) {
			// Player stands, dealer plays
			$BlackJack::state[%clientId] = "dealer";
			%dealerResult = BlackJack::DealerPlay(%clientId);
			$BlackJack::state[%clientId] = "finished";
			
			// Show final result
			BlackJack::ShowGameState(%clientId, %object, True);
			$state[%object, %clientId] = 4;
		}
	}
	else if($state[%object, %clientId] == 4) {
		// Game finished - offer to play again
		if(String::findSubStr(%message, "play") != -1 || String::findSubStr(%message, "again") != -1) {
			BlackJack::Cleanup(%clientId);
			$state[%object, %clientId] = 1;
			// Restart conversation
			eval("bottalk::"@clipTrailingNumbers(%aiName)@"("@%clientId@","@%object@",True,\"#say hello\");");
		}
		else if(String::findSubStr(%message, "leave") != -1 || String::findSubStr(%message, "exit") != -1) {
			BlackJack::Cleanup(%clientId);
			$state[%object, %clientId] = "";
			endBotTalkChoice(%clientId);
		}
	}
}

function BlackJack::ShowGameState(%clientId, %object, %showDealer) {
	%playerHand = $BlackJack::playerHand[%clientId];
	%dealerHand = $BlackJack::dealerHand[%clientId];
	%bet = $BlackJack::bet[%clientId];
	%state = $BlackJack::state[%clientId];
	
	%playerValue = BlackJack::GetHandValue(%playerHand);
	%playerFormatted = BlackJack::FormatHand(%playerHand, False);
	
	if(%showDealer || %state == "finished") {
		%dealerValue = BlackJack::GetHandValue(%dealerHand);
		%dealerFormatted = BlackJack::FormatHand(%dealerHand, False);
		%message = "Bet: " @ Number::Beautify(%bet) @ " coins\n\n" @
			"<f1>Your Hand:<f0> " @ %playerFormatted @ "(<f1>" @ %playerValue @ "<f0>)\n" @
			"<f1>Dealer Hand:<f0> " @ %dealerFormatted @ "(<f1>" @ %dealerValue @ "<f0>)";
		
		if(%state == "finished") {
			%result = BlackJack::DetermineWinner(%clientId);
			%winnings = BlackJack::Payout(%clientId, %result);
			%coins = fetchData(%clientId, "COINS");
			
			if(%result == "player_blackjack") {
				%message = %message @ "\n\n<f1>BLACKJACK!<f0> You win " @ Number::Beautify(%winnings) @ " coins!";
				Client::sendMessage(%clientId, $MsgWhite, "You won " @ Number::Beautify(%winnings) @ " coins from blackjack!~wbuysellsound.wav");
			}
			else if(%result == "player") {
				%message = %message @ "\n\n<f1>You Win!<f0> You win " @ Number::Beautify(%winnings) @ " coins!";
				Client::sendMessage(%clientId, $MsgWhite, "You won " @ Number::Beautify(%winnings) @ " coins!~wbuysellsound.wav");
			}
			else if(%result == "dealer_blackjack") {
				%message = %message @ "\n\n<f1>Dealer Blackjack!<f0> You lose " @ Number::Beautify(%bet) @ " coins.";
				Client::sendMessage(%clientId, $MsgWhite, "You lost " @ Number::Beautify(%bet) @ " coins.~wbuysellsound.wav");
			}
			else if(%result == "dealer") {
				%message = %message @ "\n\n<f1>Dealer Wins!<f0> You lose " @ Number::Beautify(%bet) @ " coins.";
				Client::sendMessage(%clientId, $MsgWhite, "You lost " @ Number::Beautify(%bet) @ " coins.~wbuysellsound.wav");
			}
			else {
				%message = %message @ "\n\n<f1>Push!<f0> It's a tie. Your bet is returned.";
				Client::sendMessage(%clientId, $MsgWhite, "Push! Your bet of " @ Number::Beautify(%bet) @ " coins was returned.~wbuysellsound.wav");
			}
			
			%message = %message @ "\n\nYou now have " @ Number::Beautify(%coins) @ " coins.";
			
			$botMenuOption[%clientId, 0] = "play again|play";
			$botMenuOption[%clientId, 1] = "leave|leave";
		}
	}
	else {
		%dealerFormatted = BlackJack::FormatHand(%dealerHand, True);
		%message = "Bet: " @ Number::Beautify(%bet) @ " coins\n\n" @
			"<f1>Your Hand:<f0> " @ %playerFormatted @ "(<f1>" @ %playerValue @ "<f0>)\n" @
			"<f1>Dealer Hand:<f0> " @ %dealerFormatted;
		
		if(%playerValue == 21) {
			%message = %message @ "\n\n<f1>21!<f0> You must stand.";
			$botMenuOption[%clientId, 0] = "stand|stand";
		}
		else {
			$botMenuOption[%clientId, 0] = "hit|hit";
			$botMenuOption[%clientId, 1] = "stand|stand";
		}
	}
	
	NewBotMessage(%clientId, %object, %message);
	
	// Update inventory text
	%txt = "<f1><jc>COINS: " @ fetchData(%clientId, "COINS");
	Client::setInventoryText(%clientId, %txt);
}