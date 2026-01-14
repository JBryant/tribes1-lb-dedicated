// This file is part of Tribes RPG.
// Tribes RPG server side scripts
// Game systems (Blackjack, etc.) by LongBow

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

// ============================================================
// BLACKJACK GAME SYSTEM
// ============================================================

// Blackjack game state storage
// Format: $BlackJack::deck[%clientId] = "card1 card2 card3 ..." (52 cards)
// Format: $BlackJack::playerHand[%clientId] = "card1 card2 ..."
// Format: $BlackJack::dealerHand[%clientId] = "card1 card2 ..."
// Format: $BlackJack::bet[%clientId] = amount
// Format: $BlackJack::state[%clientId] = "betting|playing|dealer|finished"

// Card values: A=1, 2-10=face value, J=11, Q=12, K=13
// Suits: S=Spades, H=Hearts, D=Diamonds, C=Clubs
// Format: "AS" = Ace of Spades, "2H" = 2 of Hearts, etc.

// ============================================================
// BLACKJACK HELPER FUNCTIONS
// ============================================================

function BlackJack::CreateDeck() {
	%suits = "S H D C";
	%ranks = "A 2 3 4 5 6 7 8 9 10 J Q K";
	%deck = "";
	
	for(%s = 0; (%suit = GetWord(%suits, %s)) != -1; %s++) {
		for(%r = 0; (%rank = GetWord(%ranks, %r)) != -1; %r++) {
			%deck = %deck @ %rank @ %suit @ " ";
		}
	}
	
	return %deck;
}

function BlackJack::ShuffleDeck(%deck) {
	%cards = "";
	%deckArray = "";
	%count = 0;
	
	// Convert deck string to array
	for(%i = 0; (%card = GetWord(%deck, %i)) != -1; %i++) {
		%deckArray[%count] = %card;
		%count++;
	}
	
	// Fisher-Yates shuffle
	for(%i = %count - 1; %i > 0; %i--) {
		%j = floor(getRandom() * (%i + 1));
		%temp = %deckArray[%i];
		%deckArray[%i] = %deckArray[%j];
		%deckArray[%j] = %temp;
	}
	
	// Convert back to string
	%shuffled = "";
	for(%i = 0; %i < %count; %i++) {
		%shuffled = %shuffled @ %deckArray[%i] @ " ";
	}
	
	return %shuffled;
}

function BlackJack::DrawCard(%clientId) {
	%deck = $BlackJack::deck[%clientId];
	if(%deck == "" || GetWordCount(%deck) == 0) {
		// Reshuffle if deck is empty
		%deck = BlackJack::CreateDeck();
		%deck = BlackJack::ShuffleDeck(%deck);
		$BlackJack::deck[%clientId] = %deck;
	}
	
	%card = GetWord(%deck, 0);
	%deck = String::getSubStr(%deck, String::len(%card) + 1, 9999);
	$BlackJack::deck[%clientId] = %deck;
	
	return %card;
}

function BlackJack::GetCardValue(%card) {
	%rank = String::getSubStr(%card, 0, String::len(%card) - 1);
	
	if(%rank == "A")
		return 1;
	else if(%rank == "J")
		return 11;
	else if(%rank == "Q")
		return 12;
	else if(%rank == "K")
		return 13;
	else
		return %rank;
}

function BlackJack::GetHandValue(%hand) {
	%total = 0;
	%aces = 0;
	
	for(%i = 0; (%card = GetWord(%hand, %i)) != -1; %i++) {
		%value = BlackJack::GetCardValue(%card);
		if(%value == 1) {
			%aces++;
			%total += 11; // Start with ace as 11
		}
		else if(%value > 10)
			%total += 10; // Face cards are 10
		else
			%total += %value;
	}
	
	// Adjust for aces if over 21
	while(%total > 21 && %aces > 0) {
		%total -= 10;
		%aces--;
	}
	
	return %total;
}

function BlackJack::FormatHand(%hand, %hideFirst) {
	%formatted = "";
	%count = 0;
	
	for(%i = 0; (%card = GetWord(%hand, %i)) != -1; %i++) {
		if(%hideFirst && %count == 0) {
			%formatted = %formatted @ "?? ";
		}
		else {
			%rank = String::getSubStr(%card, 0, String::len(%card) - 1);
			%suit = String::getSubStr(%card, String::len(%card) - 1, 1);
			%formatted = %formatted @ %rank @ %suit @ " ";
		}
		%count++;
	}
	
	return %formatted;
}

function BlackJack::StartGame(%clientId) {
	// Create and shuffle deck
	%deck = BlackJack::CreateDeck();
	%deck = BlackJack::ShuffleDeck(%deck);
	$BlackJack::deck[%clientId] = %deck;
	
	// Deal initial cards
	$BlackJack::playerHand[%clientId] = "";
	$BlackJack::dealerHand[%clientId] = "";
	
	// Deal 2 cards to player
	$BlackJack::playerHand[%clientId] = BlackJack::DrawCard(%clientId) @ " " @ BlackJack::DrawCard(%clientId);
	
	// Deal 2 cards to dealer
	$BlackJack::dealerHand[%clientId] = BlackJack::DrawCard(%clientId) @ " " @ BlackJack::DrawCard(%clientId);
	
	$BlackJack::state[%clientId] = "playing";
}

function BlackJack::PlayerHit(%clientId) {
	%card = BlackJack::DrawCard(%clientId);
	$BlackJack::playerHand[%clientId] = $BlackJack::playerHand[%clientId] @ " " @ %card;
	
	%value = BlackJack::GetHandValue($BlackJack::playerHand[%clientId]);
	
	if(%value > 21) {
		$BlackJack::state[%clientId] = "finished";
		return "bust";
	}
	
	return %value;
}

function BlackJack::DealerPlay(%clientId) {
	%dealerHand = $BlackJack::dealerHand[%clientId];
	%dealerValue = BlackJack::GetHandValue(%dealerHand);
	
	// Dealer must hit on 16 or less, stand on 17+
	while(%dealerValue < 17) {
		%card = BlackJack::DrawCard(%clientId);
		$BlackJack::dealerHand[%clientId] = $BlackJack::dealerHand[%clientId] @ " " @ %card;
		%dealerValue = BlackJack::GetHandValue($BlackJack::dealerHand[%clientId]);
		
		if(%dealerValue > 21)
			return "bust";
	}
	
	return %dealerValue;
}

function BlackJack::DetermineWinner(%clientId) {
	%playerValue = BlackJack::GetHandValue($BlackJack::playerHand[%clientId]);
	%dealerValue = BlackJack::GetHandValue($BlackJack::dealerHand[%clientId]);
	%bet = $BlackJack::bet[%clientId];
	
	// Player busted
	if(%playerValue > 21)
		return "dealer";
	
	// Dealer busted
	if(%dealerValue > 21)
		return "player";
	
	// Blackjack (21 with 2 cards)
	%playerBlackjack = False;
	%dealerBlackjack = False;
	if(%playerValue == 21 && GetWordCount($BlackJack::playerHand[%clientId]) == 2)
		%playerBlackjack = True;
	if(%dealerValue == 21 && GetWordCount($BlackJack::dealerHand[%clientId]) == 2)
		%dealerBlackjack = True;
	
	if(%playerBlackjack && !%dealerBlackjack)
		return "player_blackjack";
	if(%dealerBlackjack && !%playerBlackjack)
		return "dealer_blackjack";
	if(%playerBlackjack && %dealerBlackjack)
		return "push";
	
	// Compare values
	if(%playerValue > %dealerValue)
		return "player";
	else if(%dealerValue > %playerValue)
		return "dealer";
	else
		return "push";
}

function BlackJack::Payout(%clientId, %result) {
	%bet = $BlackJack::bet[%clientId];
	
	if(%result == "player_blackjack") {
		// Blackjack pays 3:2 - bet was already deducted, so add back bet + winnings
		// For 3:2, if bet is 100: winnings = 150, total return = 250 (bet 100 + winnings 150)
		%winnings = floor(%bet * 1.5); // 3:2 means 1.5x the bet as winnings
		%totalReturn = %bet + %winnings; // Return bet + winnings
		storeData(%clientId, "COINS", %totalReturn, "inc");
		return %winnings;
	}
	else if(%result == "player") {
		// Normal win pays 1:1 - bet was already deducted, so add back bet + winnings
		// For 1:1, if bet is 100: winnings = 100, total return = 200 (bet 100 + winnings 100)
		%winnings = %bet; // 1:1 means equal to bet as winnings
		%totalReturn = %bet + %winnings; // Return bet + winnings
		storeData(%clientId, "COINS", %totalReturn, "inc");
		return %winnings;
	}
	else if(%result == "push") {
		// Push returns bet only (no winnings)
		storeData(%clientId, "COINS", %bet, "inc");
		return 0;
	}
	else {
		// Loss - bet already deducted, nothing to return
		return -%bet;
	}
}

function BlackJack::Cleanup(%clientId) {
	$BlackJack::deck[%clientId] = "";
	$BlackJack::playerHand[%clientId] = "";
	$BlackJack::dealerHand[%clientId] = "";
	$BlackJack::bet[%clientId] = "";
	$BlackJack::state[%clientId] = "";
}

// ============================================================
// BLACKJACK BOT INITIALIZATION
// ============================================================

$BlackJackBotList = "";

function InitBlackJackBots() {
	// Example: Create a blackjack dealer bot
	// You can add more dealers by adding entries to $BlackJackDealer:: arrays
	
	// Blackjack dealer configuration
	// Format: $BlackJackDealer::name[%id], $BlackJackDealer::shape[%id], $BlackJackDealer::pos[%id], $BlackJackDealer::rot[%id], $BlackJackDealer::team[%id]
	
	// Example dealer (uncomment and modify as needed):
	$BlackJackDealer::name[1] = "BlackJackDealer";
	$BlackJackDealer::shape[1] = "MaleHumanTownBot"; // Use appropriate shape
	$BlackJackDealer::pos[1] = "2002.03 499.591 2300"; // Set position
	$BlackJackDealer::rot[1] = "0 -0 -2.48109"; // Set rotation
	$BlackJackDealer::team[1] = 0; // Set team
	
	%dealerId = 1;
	
	while($BlackJackDealer::name[%dealerId] != "") {
		%name = $BlackJackDealer::name[%dealerId];
		%dealer = newObject("", "StaticShape", $BlackJackDealer::shape[%dealerId], true);
		
		addToSet("MissionCleanup", %dealer);
		
		GameBase::setMapName(%dealer, %name);
		GameBase::setPosition(%dealer, $BlackJackDealer::pos[%dealerId]);
		GameBase::setRotation(%dealer, $BlackJackDealer::rot[%dealerId]);
		GameBase::setTeam(%dealer, $BlackJackDealer::team[%dealerId]);
		GameBase::playSequence(%dealer, 0, "root");
		
		Client::setSkin(%dealer, "RMSkins1");
		
		%dealer.name = "BlackJackBot" @ %dealerId;
		$BotInfo[%dealer.name, NAME] = $BlackJackDealer::name[%dealerId];
		
		$BlackJackBotList = $BlackJackBotList @ %dealer @ " ";
		$TownBotList = $TownBotList @ %dealer @ " "; // Add to TownBotList so conversation system works
		
		%dealerId++;
	}
}
