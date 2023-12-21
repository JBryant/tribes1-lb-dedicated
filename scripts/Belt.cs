//This file is part of Tribes RPG.
//Tribes RPG server side scripts
//Belt system written by Jason "phantom" Daley, and Carling

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



// ---------------------------------------
// Tribes RPG Belt!!!
//
// Originally created by Carling
// 07/02/04
//
// Updated and ported by phantom
// 09-05-2010 - 04-05-2014
// ---------------------------------------
// Adds a Belt option to tab menu designed to reduce number of itemdatas in server.
//
// This script requires many hookups into other files and will not run correctly without them.
//
// It was originally written for Salmons MoS.
// It has been recoded to be compatible TvT.
// And now, for Tribes RPG v6.0, by phantom.


// ------------------- //
// Menu Functions      //
// ------------------- //

$equippedString = "(+)";

function getDisp(%type) {
	%disp["AmmoItems"] = "Ammunition";
	%disp["GemItems"] = "Gems";
	%disp["PotionItems"] = "Potions";
	%disp["WeaponItems"] = "Weapons";
	%disp["ArmorItems"] = "Armors";
	%disp["MateriaItems"] = "Materia";
	%disp["QuestItems"] = "Quest Items";
	%disp["AccessoryItems"] = "Accessory Items";

	return %disp[%type];
}

$belttypelist = "AmmoItems GemItems PotionItems WeaponItems ArmorItems MateriaItems QuestItems AccessoryItems";

function belt::checkmenus(%clientId)
{
	%x = 0;
	for(%i = 0; getWord($belttypelist, %i) != "" && getWord($belttypelist, %i) != -1; %i++)
	{
		%type = getword($belttypelist,%i);
		%num = getword(Belt::GetNS(%clientid,%type),0);
		if(%num > 0){
			%x++;
			%nf = %nf @ " " @ getWord($belttypelist, %i);
		}
	}
	%nf = %x @ %nf;
	return %nf;
}


function MenuViewBelt(%clientId, %page, %victim)
{
	%victim = confirmVictim(%clientId, %victim);
	if(%victim == -1)
		return;

	$yourstats[%clientId] = True;
	%title = "Belt:";

	if(%victim != %clientId){
		%victimName = rpg::getname(%victim);
		%title = %victimName@"'s " @ %title;
	}

	Client::buildMenu(%clientId, %title, "ViewBelt", true);
	%cnt = -1;

	if(%victim == %clientId.currentInvSteal) {
		//%coins = fetchData(%victim, "COINS");
		//Client::addMenuItem(%clientId, string::getsubstr($menuChars,%cnt++,1) @ "Steal Coins (has "@%coins@")", "stealcoins "@%victim);
		if(!SkillCanUse(%clientId, "#pickpocket")){
			Client::sendMessage(%TrueClientId, 0, "Note: Require 270 Stealing to steal items.");
			return;
		}
	}

	%optionsPerPage = 7;
	if(%clientId.repack >= 18)
		%optionsPerPage = 32;

	%nx = 16;
	%nf = belt::checkmenus(%victim);
	%ns = GetWord(%nf,0);
	%np = floor(%ns / %optionsPerPage);
	%lb = (%page * %optionsPerPage) - (%optionsPerPage-1);
	%ub = %lb + (%optionsPerPage-1);

	if(%ub > %ns)
		%ub = %ns;

	%x = %lb - 1;

	for(%i = %lb; %i <= %ub; %i++)
	{
		%x++;
		%type = getword(%nf,%x);

		if(%type == -1)
			break;

		%num = getword(Belt::GetNS(%victim, %type), 0);
		%beltTypeWeight = Belt::GetWeightByType(%clientid, %type);

		Client::addMenuItem(%clientId, string::getsubstr($menuChars,%cnt++,1) @ getDisp(%type) @ " ("@%num@" types, "@%beltTypeWeight@" wt)", %type@" "@%victim);
	}

	if(%page == 1) {
		if(%ns > %optionsPerPage) Client::addMenuItem(%clientId, "]Next >>", "page " @ %page+1);
	}
	else if(%page == 2) {
		Client::addMenuItem(%clientId, "[<< Prev", "page " @ %page-1);
	}
}

function processMenuViewBelt(%clientId, %opt)
{
	%o = GetWord(%opt, 0);
	%p = GetWord(%opt, 1);

	if(%o == "page")	
	{
		MenuViewBelt(%clientId, %p);
		return;
	}

	%victim = %p;
	if($count[%o] > 0)
	{
		MenuBeltGear(%clientid, %o, 1, %victim);
		return;
	}
	//if(%o == "stealcoins"){
	//	if(%victim == %clientId.currentInvSteal){
	//		newStealCoins(%clientId, %victim);
	//		return;
	//	}
	//}

	if(%o != "done")
		MenuViewBelt(%clientId, 1, %victim);

	return;
}

function MenuBeltGear(%clientid, %type, %page, %victim)
{
	%victim = confirmVictim(%clientId, %victim);
	if(%victim == -1)
		return;

	if(%victim != %clientId)
		%victimName = rpg::getname(%victim);

	%title = getDisp(%type);
	if(%victimName != "")
		%title = %victimName@"'s " @ %title;

	Client::buildMenu(%clientId, %title@":", "BeltGear", true);
	%clientId.bulkNum = "";

	%optionsPerPage = 6;
	if(%clientId.repack >= 18)
		%optionsPerPage = 30;

	%nx = $count[%type];
	%nf = Belt::GetNS(%victim, %type);
	%ns = GetWord(%nf,0);
	%np = floor(%ns / %optionsPerPage);
	%lb = (%page * %optionsPerPage) - (%optionsPerPage-1);
	%ub = %lb + (%optionsPerPage-1);

	if(%ub > %ns)
		%ub = %ns;

	%x = %lb - 1;
	%cnt = -1;
	for(%i = %lb; %i <= %ub; %i++) {
		%x++;
		%item = getword(%nf,%x);
		%amnt = Belt::HasThisStuff(%victim, %item);
		Client::addMenuItem(%clientId, string::getsubstr($menuChars,%cnt++,1) @%amnt@" "@ $beltitem[%item, "Name"], %item @ " " @ %page @" "@%type@" "@%victim);
	}

	if(%page == 1) {
		if(%ns > %optionsPerPage) Client::addMenuItem(%victim, "]Next >>", "page " @ %page+1 @" "@%type@" "@%victim);
		Client::addMenuItem(%clientId, "z<< Back", "back");
	}
	else if(%page == %np+1) {
		Client::addMenuItem(%clientId, "[<< Prev", "page " @ %page-1 @" "@%type@" "@%victim);
	}
	else {
		Client::addMenuItem(%clientId, "]Next >>", "page " @ %page+1 @" "@%type@" "@%victim);
		Client::addMenuItem(%clientId, "[<< Prev", "page " @ %page-1 @" "@%type@" "@%victim);
	}

	return;
}

function processMenuBeltGear(%clientid, %opt)
{
	%o = GetWord(%opt, 0);
	if(%o == "done")
		return;
	if(%o == "back"){
		MenuViewBelt(%clientId, 1, GetWord(%opt, 1));
		return;
	}
	%p = GetWord(%opt, 1);
	%t = GetWord(%opt, 2);
	%victim = GetWord(%opt, 3);

	if(%o != "page")
	{
		if(%clientId.bulkNum < 1)
			%clientId.bulkNum = 1;
		if(%clientId.bulkNum > 500)
			%clientId.bulkNum = 500;
	
		MenuBeltDrop(%clientid, %o, %t, %victim);
		return;
	}
	MenuBeltGear(%clientid, %t, %p, %victim);

	return;
}

function MenuBeltMateria(%clientid, %weaponItem, %page)
{
	%type = "MateriaItems";
	Client::buildMenu(%clientId, "Materia:", "BeltMateria", true);
	%clientId.bulkNum = "";

	%optionsPerPage = 6;
	if(%clientId.repack >= 18)
		%optionsPerPage = 30;

	%nx = $count[%type];
	%nf = Belt::GetNS(%clientid, %type);
	%ns = GetWord(%nf,0);
	%np = floor(%ns / %optionsPerPage);
	%lb = (%page * %optionsPerPage) - (%optionsPerPage-1);
	%ub = %lb + (%optionsPerPage-1);

	if(%ub > %ns)
		%ub = %ns;

	%x = %lb - 1;
	%cnt = -1;
	for(%i = %lb; %i <= %ub; %i++) {
		%x++;
		%item = getword(%nf,%x);
		%amnt = Belt::HasThisStuff(%clientId, %item);
		Client::addMenuItem(%clientId, string::getsubstr($menuChars, %cnt++,1) @ %amnt @ " " @ $beltitem[%item, "Name"], %weaponItem @ " " @ %item @ " " @ %page);
	}

	if(%page == 1) {
		if(%ns > %optionsPerPage) Client::addMenuItem(%clientId, "]Next >>", "page " @ %page+1);
		Client::addMenuItem(%clientId, "z<< Back", "back");
	}
	else if(%page == %np+1) {
		Client::addMenuItem(%clientId, "[<< Prev", "page " @ %page-1);
	}
	else {
		Client::addMenuItem(%clientId, "]Next >>", "page " @ %page+1);
		Client::addMenuItem(%clientId, "[<< Prev", "page " @ %page-1);
	}

	return;
}

function processMenuBeltMateria(%clientId, %opt) {
	%o = GetWord(%opt, 0);

	if(%o == "done") return;

	if(%o == "back") {
		MenuViewBelt(%clientId, 1, GetWord(%opt, 1));
		return;
	}

	%materia = GetWord(%opt, 1);
	%page = GetWord(%opt, 2);

	if(%o != "page")
	{
		%enchant = String::replace(%materia, "Materia", "");
		%enchantedWeapon = %o @ %enchant;

		if ($beltitem[%o, "Enchantment"] != "") {
			Client::sendMessage(%clientId, $MsgWhite, "Enchanted weapons cannot be slotted with Materia.");
			return;
		}

		if (BeltItem::IsEquipped(%clientId, %o)) {
			Client::sendMessage(%clientId, $MsgWhite, "You cannot slot materia into your wepaon while it is eqipped.");
			return;
		}

        if ($beltitem[%enchantedWeapon, "Name"] != "") {
			Belt::TakeThisStuff(%clientid, %o, 1);
			Belt::TakeThisStuff(%clientid, %materia, 1);
			Belt::GiveThisStuff(%clientid, %enchantedWeapon, 1);
		
			Client::sendMessage(%clientId, $MsgWhite, "The " @ $beltitem[%materia, "Name"] @ " has been slotted into your " @ $beltitem[%o, "Name"] @ ".");
			// check if weapon is equipped or not, if it is unequip (and unmount)
			// then remove weapon + materia and add the combo result
		} else {
			Client::sendMessage(%clientId, $MsgWhite, "This weapon cannot be slotted with this Materia.");
		}
	
		return;
	}

	MenuBeltMateria(%clientid, %p);

	return;
}

function MenuBeltDrop(%clientid, %item, %type, %victim)
{
	%victim = confirmVictim(%clientId, %victim);
	if(%victim == -1)
		return;
	%cmnt = Belt::HasThisStuff(%victim, %item);
	%name = $beltitem[%item, "Name"];

	if(%victim != %clientId){
		%victimName = rpg::getname(%victim);
		if(%cmnt < 1){
			Client::sendMessage(%clientId, $MsgWhite, %victimName@" doesn't have any "@%name);
			return;
		}
	}
	if(%cmnt < 1){
		Client::sendMessage(%clientId, $MsgWhite, "you don't have any "@%name);
		return;
	}


	if(%clientId.bulkNum == "")
		%clientId.bulkNum = 1;
	%amnt = %clientId.bulkNum;
	%amnt = floor(%amnt);
	if(%amnt > %cmnt)
		%amnt = %cmnt;

	Client::buildMenu(%clientId, %name@" ("@%cmnt@")", "BeltDrop", true);

	if(%victimName != ""){
		if(%victim == %clientId.currentInvSteal){
			%disp = getDisp(%type);
			if(%type == "WeaponItems" || %type == "ClothingItems")
				Client::addMenuItem(%clientId, %cnt++ @ "(can't steal "@%disp@")", %type@" examine "@%item@" "@ %amnt @" "@%victim);
			else
				Client::addMenuItem(%clientId, %cnt++ @ "Steal 1 "@%item, %type@" steal "@%item@" 1 "@%victim);
		}
		Client::addMenuItem(%clientId, %cnt++ @ "Examine", %type@" examine "@%item@" "@ %amnt @" "@%victim);
		Client::addMenuItem(%clientId, "z<< Back", %type@" back "@%victim);
		return;
	}

	if(%type == "AmmoItems"){
		%list = GetAccessoryList(%clientId, 9, -1);
		%curweap= player::getmounteditem(%clientId,$weaponslot);
		if(String::findSubStr(%list, %curweap) != -1 && String::findSubStr($ProjRestrictions[%item], "," @ %curweap @ ",") != -1){
			Client::addMenuItem(%clientId, %cnt++ @ "Equip to "@%curweap, %type@" arm "@%item);
		}
	}
	else if(%type == "PotionItems") {
		Client::addMenuItem(%clientId, %cnt++ @ "Use", %type@" use "@%item);
	}
	else if(%type == "WeaponItems") {
		// check myhere if it is equipped or not
		if (BeltItem::isEquipped(%clientId, %item)) {
			Client::addMenuItem(%clientId, %cnt++ @ "Unequip", %type@" equip "@%item);
		} else {
			Client::addMenuItem(%clientId, %cnt++ @ "Equip", %type@" equip "@%item);
		}

		if ($beltitem[%item, "Enchantment"] == "") {
			Client::addMenuItem(%clientId, %cnt++ @ "Slot", %type @ " slot " @ %item);
		}
	}
	else if(%type == "ArmorItems") {
		Client::addMenuItem(%clientId, %cnt++ @ "Equip", %type@" equip "@%item);
	}
	else if(%type == "AccessoryItems") {
		Client::addMenuItem(%clientId, %cnt++ @ "Equip", %type@" equip "@%item);
	}

	if(!$playerNoDrop[%item]){
		Client::addMenuItem(%clientId, %cnt++ @ "Drop "@%amnt, %type@" drop "@%item@" "@%amnt);

		if(%cmnt > 50 && %cmnt != %amnt)
			Client::addMenuItem(%clientId, %cnt++ @ "Drop 50", %type@" dropb "@%item@" 50");
		if(%cmnt <= 100 && %cmnt != %amnt)
			Client::addMenuItem(%clientId, %cnt++ @ "Drop "@%cmnt, %type@" dropb "@%item@" "@%cmnt);
		else if(%cmnt > 100 && %cmnt != %amnt){
			Client::addMenuItem(%clientId, %cnt++ @ "Drop 100", %type@" dropb "@%item@" 100");
			Client::addMenuItem(%clientId, %cnt++ @ "Drop "@%cmnt, %type@" dropb "@%item@" "@%cmnt);
		}
	}
	Client::addMenuItem(%clientId, %cnt++ @ "Examine", %type@" examine "@%item);
	Client::addMenuItem(%clientId, "z<< Back", %type@" back");
	return;
}

function processMenuBeltDrop(%clientId, %opt, %keybind)
{
	%type = GetWord(%opt, 0);
	%option = GetWord(%opt, 1);
	%item = GetWord(%opt, 2);
	%amnt = GetWord(%opt, 3);
	%amnt = floor(%amnt);

	if(%amnt <= 0) %amnt = 1;

	%victim = GetWord(%opt, 4);

	if(isDead(%clientId))
		return;
	if(IsJailed(%clientId)) {
		Client::sendMessage(%clientId, $MsgWhite, "You can't do that in jail.");
		return;
	}
	%clientId.tabMenuSpam++;
	if(%clientId.tabMenuSpam > 20) {
		exploitBan(%clientId, "Item spam", 5);
		return;
	}
	if(%option == "back") {
		MenuBeltGear(%clientId, %type, 1, %item);
		return;
	}
	else if(%option == "examine") {
		WhatIs(%clientId, %item);
		MenuBeltDrop(%clientid, %item, %type, %victim);
		return;
	}
	else if(%option == "equip") {
		Belt::EquipItem(%clientid, %item);
		return;
	}
	else if(%option == "slot") {
		// show slot options
		MenuBeltMateria(%clientId, %item, 1);
		return;
	}

	if(%option == "dropb")
		%clientId.bulkNum = %amnt;
	if(%option == "breakb")
		%clientId.bulkNum = %amnt;
	
	if(%amnt != %clientId.bulkNum)
	{
		if(%clientId.bulkNum < 1)	%clientId.bulkNum = 1;


		if(%clientId.bulkNum > 500)	%clientId.bulkNum = 500;
		MenuBeltDrop(%clientid, %item, %type);
		return;
	}

	else if(%option == "steal")
	{
		startSteal(%clientId, %item);
	}
	else if(%option == "drop")
	{
		%cmnt = belt::hasthisstuff(%clientId, %item);

		if(%amnt > %cmnt)
			return;

		if($playerNoDrop[%item]) {
			Client::sendMessage(%clientId, $MsgWhite, "Sorry. Can't drop that. Reasons.");
			return;
		}

		// TODO: check if armor is equipped
		if (%type == "WeaponItems" && BeltItem::isEquipped(%clientId, %item)) {
			Client::sendMessage(%clientId, $MsgWhite, "You cannot drop equipped weapon.");
			return;
		}

		if (%type == "ArmorItems" && BeltItem::isEquipped(%clientId, %item)) {
			Client::sendMessage(%clientId, $MsgWhite, "You cannot drop equipped armor.");
			return;
		}

		if (%type == "AccessoryItems" && BeltItem::isEquipped(%clientId, %item)) {
			Client::sendMessage(%clientId, $MsgWhite, "You cannot drop equipped accessories.");
			return;
		}

		Belt::DropItem(%clientid,%item,%amnt,%type);

		if(belt::hasthisstuff(%clientId, %item) > 0)
			MenuBeltDrop(%clientid, %item, %type);

		// check if the dropped item was equipped
		if (%type == "WeaponItems") {
			if (%item == Player::getMountedItem(%clientid, $WeaponSlot)) {
				if (belt::hasthisstuff(%clientId, %item) < 1) {
					Player::unMountItem(%clientId, $WeaponSlot);
				}
			}
		}
	}
	else if(%option == "dropb")
	{
			%cmnt = belt::hasthisstuff(%clientId,%item);
			if(%amnt > %cmnt)
				return;

			Belt::DropItem(%clientid,%item,%amnt,%type);
			if(belt::hasthisstuff(%clientId, %item) > 0){
				%clientId.bulkNum = 1;
				MenuBeltDrop(%clientid, %item, %type);
			}
	}
	else if(%option == "arm")
	{
		if(%type == "AmmoItems"){
			%list = GetAccessoryList(%clientId, 9, -1);
			%curweap= player::getmounteditem(%clientId,$weaponslot);
			if(String::findSubStr(%list, %curweap) != -1 && String::findSubStr($ProjRestrictions[%item], "," @ %curweap @ ",") != -1){
				storeData(%clientId, "LoadedProjectile " @ %curweap, %item);
				Client::sendMessage(%clientId, $MsgBeige, rpg::EnglishItem(%item) @ " loaded as projectile for "@ %curweap @".");
			}
			else
				Client::sendMessage(%clientId, $MsgRed, "This projectile cannot be loaded into the weapon you have equipped.");
		}
	}
	else if(%option == "use")
	{
		%has = belt::hasthisstuff(%clientId, %item);
		if(%has < 1)
			return;
		if($restoreValue[%item, HP] > 0){
			%hp = fetchData(%clientId, "HP");
			refreshHP(%clientId, $restoreValue[%item, HP] * -0.01);
			if(fetchData(%clientId, "HP") != %hp)
				UseSkill(%clientId, $SkillHealing, True, True);
		}
		if($restoreValue[%item, MP] > 0){
			refreshMANA(%clientId, $restoreValue[%item, MP] * -1);
		}
		belt::takethisstuff(%clientId, %item, 1);
		%has--;
		Client::sendMessage(%clientId, $MsgWhite, "You used "@$beltitem[%item, "Name"]@". [have "@%has@"]");
		refreshAll(%clientId);
		if(!%keybind){
			if(%has > 0)
				MenuBeltDrop(%clientid, %item, %type);
		}
	}
	%clientId.bulkNum = 1;
	return;
}


function belt::buildMainMenu(%clientId, %page) {
	%l = 6;
	if(%clientId.repack >= 18)
		%l = 31;

	%nx = 15;
	%nf = belt::checkmenus(%clientId);
	%ns = GetWord(%nf,0);

	%np = floor(%ns / %l);
	%lb = (%page * %l) - (%l-1);
	%ub = %lb + (%l-1);

	if(%ub > %ns)
		%ub = %ns;

	%x = %lb - 1;
	%curItem = -1;

	for(%i = %lb; %i <= %ub; %i++) {
		%x++;
		%type = getword(%nf,%x);
		if(%type == -1)
			break;
		%num = getword(Belt::GetNS(%clientid,%type),0);
		Client::addMenuItem(%clientId, string::getsubstr($menuChars,%curItem++,1) @ getDisp(%type) @ " ("@%num@" kinds)", %type);
	}

	if(%page == 1) {
		if(%ns > %l) Client::addMenuItem(%clientId, "]Next >>", "page " @ %page+1);
	}
	else if(%page == 2) {
		Client::addMenuItem(%clientId, "[<< Prev", "page " @ %page-1);
	}
}

function MenuSellBelt(%clientId, %page) {
	Client::buildMenu(%clientId, "Sell:", "SellBelt", true);

	if(%page == "")
		%page = 1;

	belt::buildMainMenu(%clientId, %page);
	Client::addMenuItem(%clientId, "bBuy", "buy");
	Client::addMenuItem(%clientId, "xDone", "done");

	return;
}

function processMenuSellBelt(%clientId, %opt) {
	%o = GetWord(%opt, 0);
	%p = GetWord(%opt, 1);

	if (%o == "done") {
		ClearCurrentShopVars(%clientId);
	}

	if(%o == "page") {
		MenuSellBelt(%clientId, %p);
		return;
	}

	if($count[%opt] > 0) {
		MenuSellBeltItem(%clientid, %opt, 1);
		return;
	}

	if(%opt == "buy") {
		MenuBuyBeltItem(%clientid, 1);
		return;
	}
	else if(%opt != "done")
		MenuSellBelt(%clientId);

	return;
}


function MenuSellBeltItem(%clientid, %type, %page) {
	%disp = getDisp(%type);

	Client::buildMenu(%clientId, %disp@" sell:", "SellBeltItem", true);
	%clientId.bulkNum = "";

	%l = 6;
	%nx = $count[%type];
	%nf = Belt::GetNS(%clientid,%type);
	%ns = GetWord(%nf,0);
	%np = floor(%ns / %l);
	%lb = (%page * %l) - (%l-1);
	%ub = %lb + (%l-1);

	if(%ub > %ns)
		%ub = %ns;

	%x = %lb - 1;
	for(%i = %lb; %i <= %ub; %i++) {
		%x++;
		%item = getword(%nf,%x);
		%amnt = Belt::HasThisStuff(%clientid, %item);
		Client::addMenuItem(%clientId, %cnt++ @%amnt@" "@ $beltitem[%item, "Name"], %item @ " " @ %page @" "@%type);
	}

	if(%page == 1) {
		if(%ns > 6) Client::addMenuItem(%clientId, "]Next >>", "page " @ %page+1 @" "@%type);
		Client::addMenuItem(%clientId, "bBack", "back");
		Client::addMenuItem(%clientId, "xDone", "done");
	}
	else if(%page == %np+1) {
		Client::addMenuItem(%clientId, "[<< Prev", "page " @ %page-1 @" "@%type);
		Client::addMenuItem(%clientId, "bBack", "back");
		Client::addMenuItem(%clientId, "xDone", "done");
	}
	else {
		Client::addMenuItem(%clientId, "]Next >>", "page " @ %page+1 @" "@%type);
		Client::addMenuItem(%clientId, "[<< Prev", "page " @ %page-1 @" "@%type);
	}

	return;
}


function MenuBuyBeltItem(%clientid, %page)
{
	Client::buildMenu(%clientId, "Buy:", "BuyBeltItem", true);
	%clientId.bulkNum = "";

	%id = %clientId.beltShop;

	%botname = %id.name;

	%l = 6;
	if(%clientId.repack >= 18)
		%l = 31;

	%info = $BotInfo[%botname, BELTSHOP];

	if(%info != "") {
		for(%i = 0; GetWord(%info, %i) != -1; %i++) {
			%a = GetWord(%info, %i);
			
			%max = $numBeltItems;
			for(%z = 0; %z < %max; %z++) {
				%item = $beltItemData[%z];
				
				if($AccessoryVar[%item, $ShopIndex] == %a) {
					%nf = %nf @ " " @ %item;
				}
			}
		}
		%nf = %i @ " " @ %nf;
	}
	else
		%nf = 0;


	%ns = %i;//NUMBER OF ITEMS SOLD AT SHOP
	%lb = (%page * %l) - (%l-1);
	%np = floor(%ns / %l);
	%ub = %lb + (%l-1);

	if(%ub > %ns)
		%ub = %ns;

	%x = %lb - 1;
	%cnt = -1;

	for(%i = %lb; %i <= %ub; %i++) {
		%x++;
		%item = getword(%nf,%x);
		Client::addMenuItem(%clientId, string::getsubstr($menuChars,%cnt++,1) @ $beltitem[%item, "Name"], %item @ " " @ %page);
	}

	if(%page == 1) {
		if(%ns > %l) Client::addMenuItem(%clientId, "]Next >>", "page " @ %page+1);
		Client::addMenuItem(%clientId, "sSell", "sell");
		Client::addMenuItem(%clientId, "xDone", "done");
	}
	else if(%page == %np+1) {
		Client::addMenuItem(%clientId, "[<< Prev", "page " @ %page-1);
		Client::addMenuItem(%clientId, "sSell", "sell");
	}
	else {
		Client::addMenuItem(%clientId, "]Next >>", "page " @ %page+1);
		Client::addMenuItem(%clientId, "[<< Prev", "page " @ %page-1);
	}

	return;
}

function processMenuSellBeltItem(%clientid, %opt) {
	%o = GetWord(%opt, 0);
	%p = GetWord(%opt, 1);
	%t = GetWord(%opt, 2);

	if (%o == "done") {
		ClearCurrentShopVars(%clientId);
		return;
	}

	if (%o == "back") {
		MenuSellBelt(%clientId);
		return;
	}

	if(%o != "page" && %o != "done") {
		if(%clientId.bulkNum < 1)	%clientId.bulkNum = 1;
		if(%clientId.bulkNum > 500)	%clientId.bulkNum = 500;
		MenuSellBeltItemFinal(%clientid, %o, %t);
		return;
	}

	if(%o != "done")
		MenuSellBeltItem(%clientid, %t, %p);

	return;
}

function processMenuBuyBeltItem(%clientid, %opt) {
	%o = GetWord(%opt, 0);
	%p = GetWord(%opt, 1);

	if (%o == "done") {
		ClearCurrentShopVars(%clientId);
	}

	if(%o == "sell") {
		Belt::Sell(%clientId,%clientId.beltShop, 1);
		return;
	}
	if(%o != "page" && %o != "done") {
		if(%clientId.bulkNum < 1)	%clientId.bulkNum = 1;
		if(%clientId.bulkNum > 500)	%clientId.bulkNum = 500;
		MenuBuyBeltItemFinal(%clientid, %o);
		return;
	}

	if(%o != "done")
		MenuBuyBeltItem(%clientid, %p);

	return;
}

function MenuSellBeltItemFinal(%clientid, %item, %type) {
	%name = $beltitem[%item, "Name"];
	%amnt = %clientId.bulkNum;
	%cmnt = Belt::HasThisStuff(%clientid,%item);

	if(%amnt > %cmnt)
		%amnt = %cmnt;

	Client::buildMenu(%clientId, %name@" ("@%cmnt@")", "SellBeltItemFinal", true);
	%cost = Belt::GetSellCost(%clientid,%item);
	Client::addMenuItem(%clientId, %cnt++ @ "Sell "@%amnt@" for "@(%cost * %amnt)@" coins.", %type@" sell "@%item@" "@%amnt);

	if(%cmnt != %amnt)
		Client::addMenuItem(%clientId, %cnt++ @ "Sell "@%cmnt@" (all) for "@(%cost * %cmnt)@" coins.", %type@" sellall "@%item@" "@%cmnt);

	Client::addMenuItem(%clientId, "zBack", %type@" back");
	return;
}


function MenuBuyBeltItemFinal(%clientid, %item) {
	if($AccessoryVar[%item,$ShopIndex] == "")
		return;

	%id = %clientId.beltShop;
	%botname = %id.name;
	if(String::findSubStr($BotInfo[%botname, BELTSHOP],$AccessoryVar[%item,$ShopIndex]) == -1)
		return;


	%name = $beltitem[%item, "Name"];
	%amnt = %clientId.bulkNum;
	%cmnt = 100;

	if(%amnt > %cmnt)
		%amnt = %cmnt;

	Client::buildMenu(%clientId, %name, "BuyBeltItemFinal", true);
	%cost = getBuyCost(%clientId, %item);

	Client::addMenuItem(%clientId, %cnt++ @ "Buy "@%amnt@" for "@(%cost * %amnt)@" coins.", "buy "@%item@" "@%amnt);
	%cmnt = 10;
	if(%cmnt != %amnt)
		Client::addMenuItem(%clientId, %cnt++ @ "Buy "@%cmnt@" for "@(%cost * %cmnt)@" coins.", "buy "@%item@" "@%cmnt);
	%cmnt = 25;
	if(%cmnt != %amnt)
		Client::addMenuItem(%clientId, %cnt++ @ "Buy "@%cmnt@" for "@(%cost * %cmnt)@" coins.", "buy "@%item@" "@%cmnt);
	%cmnt = 50;
	if(%cmnt != %amnt)
		Client::addMenuItem(%clientId, %cnt++ @ "Buy "@%cmnt@" for "@(%cost * %cmnt)@" coins.", "buy "@%item@" "@%cmnt);
	%cmnt = 100;
	if(%cmnt != %amnt)
		Client::addMenuItem(%clientId, %cnt++ @ "Buy "@%cmnt@" for "@(%cost * %cmnt)@" coins.", "buy "@%item@" "@%cmnt);

	Client::addMenuItem(%clientId, "eExamine", "examine "@%item);
	Client::addMenuItem(%clientId, "xCancel", "done");
	Client::addMenuItem(%clientId, "bBack", "back");

	remoteEval(%clientId, "setInfoLine", 1, %name@":");

	%s = $SkillDesc[$SkillType[%item]];
	if(%s != "")
		remoteEval(%clientId, "setInfoLine", 3, "Skill Type: "@%s);

	%w = GetAccessoryVar(%item, $Weight);
	if(%w == "")
		%w = 0;

	remoteEval(%clientId, "setInfoLine", 4, "Weight: "@fixDecimals(%w));
	remoteEval(%clientId, "setInfoLine", 5, "Restrictions: "@WhatSkills(%item));
	remoteEval(%clientId, "setInfoLine", 6, $AccessoryVar[%item, $MiscInfo]);

	return;
}

function processMenuBuyBeltItemFinal(%clientId, %opt) {
	%option = GetWord(%opt, 0);
	%item = GetWord(%opt, 1);
	%amnt = GetWord(%opt, 2);
	%amnt = floor(%amnt);

	if(%option == "done") {
		ClearCurrentShopVars(%clientId);
	}
	else if(%option == "back") {
		MenuBuyBeltItem(%clientid, 1);
		return;
	}
	else if(%option == "examine") {
		WhatIs(%clientId, %item);
		MenuBuyBeltItemFinal(%clientid, %item);
		return;
	}
	else if(%option == "buy") {
		if(%clientId.beltShop != "") {
			%clientPos = GameBase::getPosition(%clientId);
			%botPos = GameBase::getPosition(%clientid.beltShop);
			%dist = Vector::getDistance(%clientPos, %botPos);

			if(%dist > 20) {
				ClearCurrentShopVars(%clientId);
				return;
			}

			if($AccessoryVar[%item,$ShopIndex] == "")
				return;

			%id = %clientId.beltShop;
			%botname = %id.name;

			if(String::findSubStr($BotInfo[%botname, BELTSHOP],$AccessoryVar[%item,$ShopIndex]) == -1)
				return;

			%cost = getBuyCost(%clientid,%item) * %amnt;
			%player = Client::getOwnedObject(%clientId);

			if(checkResources(%player, %item, %cost, %clientId.bulkNum) && !IsDead(%clientId)) {
				%name = $beltitem[%item, "Name"];
				UseSkill(%clientId, $SkillHaggling, True, True);
				storeData(%clientId, "COINS", %cost, "dec");
				Belt::GiveThisStuff(%clientid,%item,%amnt);
				Client::SendMessage(%clientId, $MsgWhite, "You purchased "@%amnt@" "@%name@" for "@%cost@" coins.~wbuysellsound.wav");
				RefreshAll(%clientId);
				%clientId.bulkNum = 1;

				MenuBuyBeltItem(%clientid, 1);
				return;
			}
		}
	}

	%clientId.beltShop = "";
	return;
}

function processMenuSellBeltItemFinal(%clientId, %opt)
{
	%type = GetWord(%opt, 0);
	%option = GetWord(%opt, 1);
	%item = GetWord(%opt, 2);
	%amnt = GetWord(%opt, 3);
	%amnt = floor(%amnt);

	if(%option == "done") {
		ClearCurrentShopVars(%clientId);
	}
	else if(%option == "back") {
		MenuSellBeltItem(%clientid, %type, 1);
		return;
	}
	else if(%option == "sellall") {
		%clientPos = GameBase::getPosition(%clientId);
		%botPos = GameBase::getPosition(%clientId.beltShop);
		%dist = Vector::getDistance(%clientPos, %botPos);

		if(%dist > 20) {
			ClearCurrentShopVars(%clientId);
			return;
		}

		%itemCnt = belt::hasthisstuff(%clientId,%item);

		if(%itemCnt != %amnt)
			return;

		%cost = Belt::GetSellCost(%clientid,%item) * %amnt;
		UseSkill(%clientId, $SkillHaggling, True, True);
		storeData(%clientId, "COINS", %cost, "inc");
		Belt::TakeThisStuff(%clientid,%item,%amnt);
		Client::SendMessage(%clientId, $MsgWhite, "You received "@%cost@" coins.~wbuysellsound.wav");
		RefreshAll(%clientId);
		%clientId.bulkNum = 1;
	}
	else if(%clientId.bulkNum != %amnt)
	{
		if(%clientId.bulkNum < 1)	%clientId.bulkNum = 1;
		if(%clientId.bulkNum > 500)	%clientId.bulkNum = 500;
		MenuSellBeltItemFinal(%clientid, %item, %type);
	}
	else if(%option == "sell")
	{
		%cmnt = Belt::HasThisStuff(%clientid, %item);
		if(%cmnt >= %amnt)
		{
			%clientPos = GameBase::getPosition(%clientId);
			%botPos = GameBase::getPosition(%clientId.beltShop);
			%dist = Vector::getDistance(%clientPos, %botPos);

			if(%dist > 20) {
				ClearCurrentShopVars(%clientId);
				return;
			}

			%cost = Belt::GetSellCost(%clientid,%item) * %amnt;
			UseSkill(%clientId, $SkillHaggling, True, True);
			storeData(%clientId, "COINS", %cost, "inc");
			Belt::TakeThisStuff(%clientid,%item,%amnt);
			Client::SendMessage(%clientId, $MsgWhite, "You received "@%cost@" coins.~wbuysellsound.wav");
			RefreshAll(%clientId);
			%clientId.bulkNum = 1;

			MenuSellBeltItem(%clientid, %type, 1);
			return;
		}
	}

	return;
}


//-----------------------------------------------------------------

function MenuStoreBelt(%clientId, %page) {
	Client::buildMenu(%clientId, "Belt store:", "StoreBelt", true);

	if(%page == "")
		%page = 1;

	belt::buildMainMenu(%clientId, %page);
	Client::addMenuItem(%clientid, "wWithdraw","withdraw");
}

function processMenuStoreBelt(%clientId, %opt) {
	%o = GetWord(%opt, 0);
	%p = GetWord(%opt, 1);

	if(%o == "page") {
		MenuStoreBelt(%clientId, %p);
		return;
	}

	if($count[%opt] > 0) {
		MenuStoreBeltItem(%clientid, %opt, 1);
		return;
	}

	if(%opt == "withdraw") {
		MenuWithdrawBelt(%clientId);
		return;
	}

	if(%opt != "done")
		MenuStoreBelt(%clientId);

	return;
}
function belt::checkbankmenus(%clientId) {
	%x = 0;

	for(%i = 0; getWord($belttypelist, %i) != "" && getWord($belttypelist, %i) != -1; %i++) {
		%type = getword($belttypelist,%i);
		%num = getword(Belt::BankGetNS(%clientid,%type),0);

		if(%num > 0){
			%x++;
			%nf = %nf @ " " @ getWord($belttypelist, %i);
		}
	}

	%nf = %x @ %nf;
	return %nf;
}
function belt::buildBankMenu(%clientId, %page){
	%l = 6;
	if(%clientId.repack >= 18)
		%l = 31;
	%nx = 15;

	%nf = belt::checkbankmenus(%clientId);
	%ns = GetWord(%nf,0);

	%np = floor(%ns / %l);
	%lb = (%page * %l) - (%l-1);
	%ub = %lb + (%l-1);
	if(%ub > %ns)
		%ub = %ns;

	%x = %lb - 1;
	%curItem = -1;
	for(%i = %lb; %i <= %ub; %i++)
	{
		%x++;
		%type = getword(%nf,%x);
		if(%type == -1)
			break;
		%num = getword(Belt::BankGetNS(%clientid,%type),0);
		Client::addMenuItem(%clientId, string::getsubstr($menuChars,%curItem++,1) @ getDisp(%type) @ " ("@%num@" kinds)", %type);
	}

	if(%page == 1)
	{
		if(%ns > %l) Client::addMenuItem(%clientId, "]Next >>", "page " @ %page+1);
	}
	else if(%page == 2)
	{
		Client::addMenuItem(%clientId, "[<< Prev", "page " @ %page-1);
	}
}
function MenuWithdrawBelt(%clientId, %page)
{
	Client::buildMenu(%clientId, "Belt withdraw:", "WithdrawBelt", true);
	if(%page == "")
		%page = 1;

	belt::buildBankMenu(%clientId, %page);
	Client::addMenuItem(%clientid, "sStore","store");
}
function processMenuWithdrawBelt(%clientId, %opt)
{
	%o = GetWord(%opt, 0);
	%p = GetWord(%opt, 1);

	if(%o == "page")
	{
		MenuWithdrawBelt(%clientId, %p);
		return;
	}
	if($count[%opt] > 0)
	{
		MenuWithdrawBeltItem(%clientid, %opt, 1);
		return;
	}

	if(%opt == "store")
	{
		MenuStoreBelt(%clientId);
		return;
	}

	if(%opt != "done")
		MenuWithdrawBelt(%clientId);

	return;
}
function MenuStoreBeltItem(%clientid, %type, %page)
{
	%disp = getDisp(%type);
	Client::buildMenu(%clientId, %disp@" store:", "StoreBeltItem", true);
	%clientId.bulkNum = "";

	%l = 6;
	if(%clientId.repack >= 18)
		%l = 30;
	%nx = $count[%type];
	%nf = Belt::GetNS(%clientid,%type);
	%ns = GetWord(%nf,0);
	%np = floor(%ns / %l);
	%lb = (%page * %l) - (%l-1);
	%ub = %lb + (%l-1);
	if(%ub > %ns)
		%ub = %ns;

	%x = %lb - 1;
	%cnt = -1;
	for(%i = %lb; %i <= %ub; %i++)
	{
		%x++;
		%item = getword(%nf,%x);
		%amnt = Belt::HasThisStuff(%clientid,%item);
		Client::addMenuItem(%clientId, string::getsubstr($menuChars,%cnt++,1) @%amnt@" "@ $beltitem[%item, "Name"], %item @ " " @ %page @" "@%type);
	}

	if(%page == 1)
	{
		if(%ns > %l) Client::addMenuItem(%clientId, "]Next >>", "page " @ %page+1 @" "@%type);
		Client::addMenuItem(%clientId, "xDone", "done");
	}
	else if(%page == %np+1)
	{
		Client::addMenuItem(%clientId, "[<< Prev", "page " @ %page-1 @" "@%type);
		Client::addMenuItem(%clientId, "xDone", "done");
	}
	else
	{
		Client::addMenuItem(%clientId, "]Next >>", "page " @ %page+1 @" "@%type);
		Client::addMenuItem(%clientId, "[<< Prev", "page " @ %page-1 @" "@%type);
	}
	Client::addMenuItem(%clientId, "z<< Back", "back");

	return;
}
function processMenuStoreBeltItem(%clientid, %opt)
{
	%o = GetWord(%opt, 0);
	%p = GetWord(%opt, 1);
	%t = GetWord(%opt, 2);
	if(%o == "done")
		return;
	if(%o == "back"){
		MenuStoreBelt(%clientId);
		return;
	}

	if(%o != "page")
	{
		if(%clientId.bulkNum < 1)	%clientId.bulkNum = 1;
		if(%clientId.bulkNum > 500)	%clientId.bulkNum = 500;
		MenuStoreBeltItemFinal(%clientid, %o, %t);
		return;
	}
	MenuStoreBeltItem(%clientid, %t, %p);

	return;
}
function MenuStoreBeltItemFinal(%clientid, %item, %type)
{
	%name = $beltitem[%item, "Name"];
	%amnt = %clientId.bulkNum;
	%cmnt = Belt::HasThisStuff(%clientid,%item);

	if(%amnt > %cmnt)
		%amnt = %cmnt;

	Client::buildMenu(%clientId, %name@" ("@%cmnt@")", "StoreBeltItemFinal", true);
	Client::addMenuItem(%clientId, %cnt++ @ "Store "@%amnt, %type@" store "@%item@" "@%amnt);

	if(%cmnt > 10)
		Client::addMenuItem(%clientId, %cnt++ @ "Store 10", %type@" store "@%item@" 10");
	if(%cmnt > 50)
		Client::addMenuItem(%clientId, %cnt++ @ "Store 50", %type@" store "@%item@" 50");
	if(%cmnt > 100)
		Client::addMenuItem(%clientId, %cnt++ @ "Store 100", %type@" store "@%item@" 100");
	if(%cmnt > 200)
		Client::addMenuItem(%clientId, %cnt++ @ "Store 200", %type@" store "@%item@" 200");
	if(%cmnt != %amnt)
		Client::addMenuItem(%clientId, %cnt++ @ "Store "@%cmnt@" (all)", %type@" storeall "@%item@" "@%cmnt);

	Client::addMenuItem(%clientId, "xCancel", %type@" done");
	Client::addMenuItem(%clientId, "z<< Back", %type@" back");
	return;
}


function processMenuStoreBeltItemFinal(%clientId, %opt)
{

	%type = GetWord(%opt, 0);
	%option = GetWord(%opt, 1);
	%item = GetWord(%opt, 2);
	%amnt = GetWord(%opt, 3);

	if(%type == "done"){
		return;
	}
	else if(%option == "back"){
		MenuStoreBeltItem(%clientId, %type, 1);
		return;
	}
	else if(%option == "storeall")
	{
		%cmnt = Belt::HasThisStuff(%clientid,%item);
		if(%cmnt >= %amnt)
		{
			Client::SendMessage(%clientid,0,"You store "@%amnt@" "@$beltitem[%item, "Name"]@".");
			Belt::TakeThisStuff(%clientid,%item,%amnt);
			Belt::BankGiveThisSTuff(%clientid,%item,%amnt);
			if(Belt::GetNS(%clientid,%type) != "0")
				MenuStoreBeltItem(%clientId, %type, 1);
			else
				MenuStoreBelt(%clientId, 1);
		}
	}
	else if(%option == "store")
	{
		%cmnt = Belt::HasThisStuff(%clientid,%item);
		if(%cmnt >= %amnt)
		{
			Client::SendMessage(%clientid,0,"You store "@%amnt@" "@$beltitem[%item, "Name"]@".");
			Belt::TakeThisStuff(%clientid,%item,%amnt);
			Belt::BankGiveThisSTuff(%clientid,%item,%amnt);
			if(%amnt < %cmnt)
				MenuStoreBeltItemFinal(%clientid, %item, %type);
			else if(Belt::GetNS(%clientid,%type) != "0")
				MenuStoreBeltItem(%clientId, %type, 1);
			else
				MenuStoreBelt(%clientId, 1);
		}
	}
	refreshWeight(%clientId);
	return;
}

//---------------------------

function MenuWithdrawBeltItem(%clientid, %type, %page)
{
	%disp = getDisp(%type);

	Client::buildMenu(%clientId, %disp@" withdraw:", "WithdrawBeltItem", true);
	%clientId.bulkNum = "";

	%l = 6;
	if(%clientId.repack >= 18)
		%l = 31;
	%nx = $count[%type];
	%nf = Belt::BankGetNS(%clientid,%type);
	%ns = GetWord(%nf,0);
	%np = floor(%ns / %l);
	%lb = (%page * %l) - (%l-1);
	%ub = %lb + (%l-1);
	if(%ub > %ns)
		%ub = %ns;

	%x = %lb - 1;
	%cnt = -1;
	for(%i = %lb; %i <= %ub; %i++)
	{
		%x++;
		%item = getword(%nf,%x);
		%amnt = Belt::BankHasThisStuff(%clientid,%item);
		Client::addMenuItem(%clientId, string::getsubstr($menuChars,%cnt++,1) @%amnt@" "@ $beltitem[%item, "Name"], %item @ " " @ %page @" "@%type);
	}

	if(%page == 1)
	{
		if(%ns > %l) Client::addMenuItem(%clientId, "]Next >>", "page " @ %page+1 @" "@%type);
		Client::addMenuItem(%clientId, "xDone", "done");
	}
	else if(%page == %np+1)
	{
		Client::addMenuItem(%clientId, "[<< Prev", "page " @ %page-1 @" "@%type);
		Client::addMenuItem(%clientId, "xDone", "done");
	}
	else
	{
		Client::addMenuItem(%clientId, "]Next >>", "page " @ %page+1 @" "@%type);
		Client::addMenuItem(%clientId, "[<< Prev", "page " @ %page-1 @" "@%type);
	}
	Client::addMenuItem(%clientId, "z<< Back", "back");

	return;
}

function processMenuWithdrawBeltItem(%clientid, %opt)
{
	%o = GetWord(%opt, 0);
	%p = GetWord(%opt, 1);
	%t = GetWord(%opt, 2);
	if(%o == "done")
		return;
	if(%o == "back"){
		MenuWithdrawBelt(%clientId);
		return;
	}

	if(%o != "page")
	{
		if(%clientId.bulkNum < 1)	%clientId.bulkNum = 1;
		if(%clientId.bulkNum > 500)	%clientId.bulkNum = 500;
		MenuWithdrawBeltItemFinal(%clientid, %o, %t);
	return;
	}
	MenuWithdrawBeltItem(%clientid, %t, %p);

	return;
}

function MenuWithdrawBeltItemFinal(%clientid, %item, %type)
{
	%name = $beltitem[%item, "Name"];
	%amnt = %clientId.bulkNum;
	%cmnt = Belt::BankHasThisStuff(%clientid,%item);

	if(%amnt > %cmnt)
		%amnt = %cmnt;

	Client::buildMenu(%clientId, %name@" ("@%cmnt@")", "WithdrawBeltItemFinal", true);

	Client::addMenuItem(%clientId, %cnt++ @ "Withdraw "@%amnt, %type@" withdraw "@%item@" "@%amnt);
	if(%cmnt >= 10)
		Client::addMenuItem(%clientId, %cnt++ @ "Withdraw 10", %type@" withdraw "@%item@" 10");
	if(%cmnt >= 50)
		Client::addMenuItem(%clientId, %cnt++ @ "Withdraw 50", %type@" withdraw "@%item@" 50");
	if(%cmnt >= 100)
		Client::addMenuItem(%clientId, %cnt++ @ "Withdraw 100", %type@" withdraw "@%item@" 100");
	if(%cmnt >= 200)
		Client::addMenuItem(%clientId, %cnt++ @ "Withdraw 200", %type@" withdraw "@%item@" 200");
	Client::addMenuItem(%clientId, %cnt++ @ "Withdraw all ("@%cmnt@")", %type@" withdrawall "@%item@" "@%amnt);
	Client::addMenuItem(%clientId, "xCancel", "done");
	Client::addMenuItem(%clientId, "z<< Back", %type@" back");
	return;
}

function processMenuWithdrawBeltItemFinal(%clientId, %opt)
{
	%type = GetWord(%opt, 0);
	%option = GetWord(%opt, 1);
	%item = GetWord(%opt, 2);
	%amnt = GetWord(%opt, 3);

	if(%type == "done"){
		return;
	}
	else if(%option == "back")
	{
		MenuWithdrawBeltItem(%clientid, %type, 1);
	}
	else if(%option == "withdrawall")
	{
		%amnt = Belt::BankHasThisStuff(%clientid,%item);
		Client::SendMessage(%clientid,0,"You withdraw "@%amnt@" "@$beltitem[%item, "Name"]@".");
		Belt::BankTakeThisSTuff(%clientid,%item,%amnt);
		Belt::GiveThisStuff(%clientid,%item,%amnt);
		MenuWithdrawBeltItem(%clientid, %type, 1);
	}
	else if(%option == "withdraw")
	{
		%cmnt = Belt::BankHasThisStuff(%clientid,%item);
		if(%cmnt >= %amnt)
		{
			Client::SendMessage(%clientid,0,"You withdraw "@%amnt@" "@$beltitem[%item, "Name"]@".");
			Belt::BankTakeThisSTuff(%clientid,%item,%amnt);
			Belt::GiveThisStuff(%clientid,%item,%amnt);
			if(%cmnt == %amnt)
				MenuWithdrawBeltItem(%clientid, %type, 1);
			else
				MenuWithdrawBeltItemFinal(%clientid, %item, %type);
		}
	}
	return;
}
// ------------------- //
// Non Menu Functions  //
// ------------------- //

function Belt::GetSellCost(%clientid,%item)
{
	%p = $HardcodedItemCost[%item];
	%cost = round(%p * ($resalePercentage/100));

	%p = round($PlayerSkill[%clientId, $SkillHaggling] / 11) / 100;
	%x = round(%cost * Cap(%p, 0.0, 1.0) );
	%cost += %x;

	return %cost;
}

function Belt::Mug(%clientid,%id)
{
	Client::SendMessage(%clientid,1,"#mugbelt");
}

function Belt::Sell(%clientid,%npc, %silent)
{
	if(!%silent)
		AI::sayLater(%clientid, %npc, "What would you like to sell?", True);
	MenuSellBelt(%clientId);
}

function Belt::Store(%clientid,%npc,%page)
{
	AI::sayLater(%clientid, %npc, "This is the equipment you have stored from your belt.", True);
	MenuStoreBelt(%clientid,%page);
}

function Belt::GetWeight(%clientid)
{
	%list[1] = "AmmoItems";
	%list[2] = "GemItems";
	%list[3] = "PotionItems";
	%list[4] = "WeaponItems";
	%list[5] = "ArmorItems";
	%list[6] = "QuestItems";
	%list[7] = "AccessoryItems";
	%list[8] = "MateriaItems";

	for(%s=1;%list[%s] != "";%s++)
	{
		%type = %list[%s];
		for(%i=0;%i<=$count[%type];%i++)
		{
			%item = $beltitem[%i, "Num", %type];
			%amnt = Belt::HasThisStuff(%clientid, %item);
			%weig = $AccessoryVar[%item, $Weight];
			%total += %amnt * %weig;
		}
	}

	return fixDecimals(%total);
}

function Belt::GetWeightByType(%clientid, %type) {
	for(%i=0; %i <= $count[%type]; %i++) {
		%item = $beltitem[%i, "Num", %type];
		%amnt = Belt::HasThisStuff(%clientid, %item);
		%weig = $AccessoryVar[%item, $Weight];
		%total += %amnt * %weig;
	}
	
	return fixDecimals(%total);
}

function Belt::DropItem(%clientid,%item,%amnt,%type) {
	%chk = Belt::HasThisStuff(%clientid,%item);
	if(%chk >= %amnt)
	{
		Belt::TakeThisStuff(%clientid, %item, %amnt);
		TossLootbag(%clientId, %item@" "@%amnt, 8, "*", 0, 1);
		refreshWeight(%clientId);
	}
}

function Belt::GetNS(%clientid, %type) {
	%bn = 0;
	%num = $count[%type];
	for(%i;%i<=%num;%i++)
	{
		%item = $beltitem[%i, "Num", %type];
		%amnt = Belt::HasThisStuff(%clientid, %item);

		if(%amnt > 0) {
			%list = %list @" "@ %item;
			%bn++;
		}
	}

	return %bn@%list;
}

function BeltItem::Add(%name, %item, %type, %weight, %cost, %image, %shopIndex) {
	$numBeltItems++;
	%num = $count[%type]++;

	$beltItemData[$numBeltItems] = %item;
	$beltItemNameToItem[$name] = %item;
	$beltitem[%num, "Num", %type] = %item;
	$beltitem[%item, "Item"] = %item;
	$beltitem[%item, "Name"] = %name;
	$beltitem[%item, "Type"] = %type;
	$beltitem[%item, "Image"] = %image;

	$AccessoryVar[%item, $Weight] = %weight;
	if (%shopIndex != "") {
		$AccessoryVar[%item, $ShopIndex] = %shopIndex;
	}
	$HardcodedItemCost[%item] = %cost;
}

function BeltItem::AddItem(%name, %item, %type, %weight, %miscInfo, %shopIndex) {
	$numBeltItems++;
	%num = $count[%type]++;

	$beltItemData[$numBeltItems] = %item;
	$beltItemNameToItem[%name] = %item;
	$beltitem[%num, "Num", %type] = %item;
	$beltitem[%item, "Item"] = %item;
	$beltitem[%item, "Name"] = %name;
	$beltitem[%item, "Type"] = %type;

	$AccessoryVar[%item, $Weight] = %weight;
	$AccessoryVar[%item, $MiscInfo] = %miscInfo;
	if (%shopIndex != "") {
		$AccessoryVar[%item, $ShopIndex] = %shopIndex;
	}
	$HardcodedItemCost[%item] = %cost;
}

// TODO: add skill restrictions, etc
function BeltItem::AddEquippable(%name, %item, %type, %weight, %shopIndex) {
	// add base version
	$numBeltItems++;
	%num = $count[%type]++;

	$beltItemData[$numBeltItems] = %item;
	$beltItemNameToItem[%name] = %item;
	$beltitem[%num, "Num", %type] = %item;
	$beltitem[%item, "Item"] = %item;
	$beltitem[%item, "Name"] = %name;
	$beltitem[%item, "Type"] = %type;
	// $beltitem[%item, "Image"] = %image;
	$AccessoryVar[%item, $Weight] = %weight;
	$HardcodedItemCost[%item] = GenerateItemCost(%item);
	$ItemCost[%item] = %cost;

	if (%shopIndex != "") {
		$AccessoryVar[%item, $ShopIndex] = %shopIndex;
	}

	// now add the equipped version
	%equippedName = %name @ " " @ $equippedString;
	%equippedItem = %item @ "0";

	$numBeltItems++;
	%num = $count[%type]++;

	$beltItemData[$numBeltItems] = %equippedItem;
	$beltItemNameToItem[%equippedName] = %equippedItem;
	$beltitem[%num, "Num", %type] = %equippedItem;
	$beltitem[%equippedItem, "Item"] = %equippedItem;
	$beltitem[%equippedItem, "Name"] = %equippedName;
	$beltitem[%equippedItem, "Type"] = %type;
	// $beltitem[%equippedItem, "Image"] = %image;

	$AccessoryVar[%equippedItem, $Weight] = %weight;
	$AccessoryVar[%equippedItem, $ShopIndex] = %shopIndex;
	$HardcodedItemCost[%equippedItem] = %cost;
}

function BeltItem::AddAccessory(%name, %item, %accessoryType, %beltType, %special, %weight, %miscInfo, %shopIndex) {
	BeltItem::AddEquippable(%name, %item, %beltType, %weight, %shopIndex);

	$AccessoryVar[%item, $SpecialVar] = %special;
	$AccessoryVar[%item, $MiscInfo] = %miscInfo;
	$AccessoryVar[%item, $AccessoryType] = %accessoryType;
}

$armorListIndex = 1;
function BeltItem::AddArmor(%name, %item, %skin, %hitSound, %special, %weight, %skillRestriction, %miscInfo, %shopIndex) {
	BeltItem::AddAccessory(%name, %item, $BodyAccessoryType, "ArmorItems", %special, %weight, %miscInfo, %shopIndex);

	$SkillRestriction[%item] = %skillRestriction;
	$ArmorSkin[%item] = %skin;
	$ArmorPlayerModel[%item] = "";
	$ArmorHitSound[%item] = %hitSound;
	$ArmorList[$armorListIndex] = %item;
	$armorListIndex++;
}

function BeltItem::AddRobe(%name, %item, %skin, %special, %weight, %skillRestriction, %miscInfo, %shopIndex) {
	BeltItem::AddAccessory(%name, %item, $BodyAccessoryType, "ArmorItems", %special, %weight, %miscInfo, %shopIndex);
	
	$SkillRestriction[%item] = %skillRestriction;
	$ArmorSkin[%item] = %skin;
	$ArmorPlayerModel[%item] = "Robed";
	$ArmorHitSound[%item] = SoundHitFlesh;
	$ArmorList[$armorListIndex] = %item;
	$armorListIndex++;
}

function BeltItem::AddShield(%name, %item, %special, %weight, %miscInfo, %shopIndex) {
	BeltItem::AddAccessory(%name, %item, $ShieldAccessoryType, "ArmorItems", %special, %weight, %miscInfo, %shopIndex);
}

function BeltItem::AddWeaponData(%name, %item, %image, %accessoryType, %miscInfo, %weaponSkill, %skillRestriction, %dps, %enchant, %shopIndex) {
	// copied from GetDelay() if you change that formula update it here
	%type = "WeaponItems";
	%a = 3.0;
	%weaponDelay = %image.imageType.fireTime;
	%suggestedWeight = FixDecimals(Cap(%weaponDelay * %a, 1.0, "inf"));

	// generate belt information
	$numBeltItems++;
	%num = $count[%type]++;

	$beltItemData[$numBeltItems] = %item;
	$beltItemNameToItem[%name] = %item;
	$beltitem[%num, "Num", %type] = %item;
	$beltitem[%item, "Item"] = %item;
	$beltitem[%item, "Name"] = %name;
	$beltitem[%item, "Type"] = %type;
	$beltitem[%item, "Image"] = %image;

	// calculate special var - ATK = (DPS * Delay)
	%delay = %image.imageType.fireTime;
	%atk = round(%dps * %weaponDelay);

	// generate weapon information
	$AccessoryVar[%item, $Weight] = %suggestedWeight;
	$AccessoryVar[%item, $AccessoryType] = %accessoryType;
	$AccessoryVar[%item, $SpecialVar] = "6 " @ %atk;
	$AccessoryVar[%item, $MiscInfo] = %miscInfo;
	if (%shopIndex != "") {
		$AccessoryVar[%item, $ShopIndex] = %shopIndex;
	}
	$SkillType[%item] = %weaponSkill;
	$SkillRestriction[%item] = %skillRestriction;

	// generate cost
	%cost = GenerateItemCost(%item);
	$HardcodedItemCost[%item] = %cost;
	$ItemCost[%item] = %cost;

	if (%enchant != "") {
		$beltitem[%item, "Enchantment"] = %enchant;
	}
}

// ==============================
// ========== SMITHING ==========
// ==============================

$smithingNum = 0;
// Smith::addItem("RHatchet","RHatchet 1","Hatchet 1", $smithingNum++);
// Smith::addItem("RBroadSword","RBroadSword 1","BroadSword 1", $smithingNum++);
// Smith::addItem("RLongSword","RLongSword 1","LongSword 1", $smithingNum++);
// Smith::addItem("RClub","RClub 1","Club 1", $smithingNum++);
// Smith::addItem("RSpikedClub","RSpikedClub 1","SpikedClub 1", $smithingNum++);
// Smith::addItem("RKnife","RKnife 1","BroadSword 1", $smithingNum++);
// Smith::addItem("RDagger","RDagger 1","Dagger 1", $smithingNum++);
// Smith::addItem("RShortSword","RShortSword 1","ShortSword 1", $smithingNum++);
// Smith::addItem("RPickAxe","RPickAxe 1","PickAxe 1", $smithingNum++);
// Smith::addItem("RShortBow","RShortBow 1","ShortBow 1", $smithingNum++);
// Smith::addItem("RLightCrossbow","RLightCrossbow 1","LightCrossbow 1", $smithingNum++);
// Smith::addItem("RWarAxe","RWarAxe 1","WarAxe 1", $smithingNum++);

// Smith::addItem("KeldriniteLS","Keldrinite 1 LongSword 1","KeldriniteLS 1", $smithingNum++);
// Smith::addItem("AeolusWing","ElvenBow 1 CompositeBow 1 Quartz 3","AeolusWing 1", $smithingNum++);
// Smith::addItem("StoneFeather","SmallRock 1 Quartz 1","StoneFeather 1", $smithingNum++);
// Smith::addItem("MetalFeather","Knife 1 Quartz 1","MetalFeather 1", $smithingNum++);
// Smith::addItem("Talon","Dagger 1 Quartz 1 Granite 2","Talon 1", $smithingNum++);
// Smith::addItem("CeraphumsFeather","Dagger 2 Jade 2 Quartz 4","CeraphumsFeather 1", $smithingNum++);
// Smith::addItem("BoneClub","Club 1 SkeletonBone 1 Granite 3","BoneClub 1", $smithingNum++);
// Smith::addItem("SpikedBoneClub","SpikedClub 1 SkeletonBone 2 Granite 5","SpikedBoneClub 1", $smithingNum++);
// Smith::addItem("FineRobe","LightRobe 1 ApprenticeRobe 1 EnchantedStone 5","FineRobe 1", $smithingNum++);
// Smith::addItem("KeldrinArmor","Keldrinite 2 FullPlateArmor 1 Gold 5 Emerald 5 Diamond 5 EnchantedStone 5","KeldrinArmor 1", $smithingNum++);
// Smith::addItem("DragonMail","DragonScale 5 Diamond 5 Ruby 3","DragonMail 1", $smithingNum++);
// Smith::addItem("DragonShield","DragonScale 3 Ruby 2","DragonShield 1", $smithingNum++);
// Smith::addItem("ElvenRobe","AdvisorRobe 1 Topaz 2 EnchantedStone 4","ElvenRobe 1", $smithingNum++);
// Smith::addItem("JusticeStaff","LongStaff 1 Granite 4 Turquoise 2","JusticeStaff 1", $smithingNum++);
// Smith::addItem("JusticeStaff","LongStaff 1 Granite 4 Turquoise 2","JusticeStaff 1", $smithingNum++);

// ==============================
// ======== ENCHANTMENTS ========
// ==============================

$WeaponEnchantments = "";
$baseEnchants = "Fire Lightning Ice Earth Poison Holy";

$enchantDamageVerb["Fire"] = "burned";
$enchantDamageVerb["Lightning"] = "shocked";
$enchantDamageVerb["Ice"] = "froze";
$enchantDamageVerb["Earth"] = "smashed";
$enchantDamageVerb["Poison"] = "poisoned";
$enchantDamageVerb["Holy"] = "smited";

$materiaMiscInfo["Fire"] = "A small red glowing orb that gives off a warm aura. This materia is embued with the element of Fire.";
$materiaMiscInfo["Lightning"] = "A small yellow glowing orb that crackles with energy. This materia is embued with the element of Lightning.";
$materiaMiscInfo["Ice"] = "A small blue glowing orb that softly swirls a cold breeze around it. This materia is embued with the element of Ice.";
$materiaMiscInfo["Earth"] = "A small brown glowing orb that feels rock hard. This materia is embued with the element of Earth.";
$materiaMiscInfo["Poison"] = "A small green glowing orb that emanates a sickly smell and green tint. This materia is embued with the element of Poison.";
$materiaMiscInfo["Holy"] = "A small white glowing orb that emanates a holy aura of peace and justice. This materia is embued with the element of Holy.";

$enchantLevels[1] = "I";
$enchantLevels[2] = "II";
$enchantLevels[3] = "III";
$enchantLevels[4] = "IV";
$enchantLevels[5] = "V";
$enchantLevels[6] = "VI";
$enchantLevels[7] = "VII";
$enchantLevels[8] = "VIII";
$enchantLevels[9] = "IX";
$enchantLevels[10] = "X";

function generateEnchantsAndMateria() {
	// base enchant damage
	%baseDamage = 5;

	for(%i = 0; getWord($baseEnchants, %i) != "" && getWord($baseEnchants, %i) != -1; %i++) {
		%baseEnchant = getWord($baseEnchants, %i);

		for(%x = 1; %x <= 10; %x++) {
			%enchantLevel = $enchantLevels[%x];
			%enchant = %baseEnchant@%enchantLevel;
			// forumala for damage scaling eg: lvl 1 = 4 additional dmg, lvl 10 = 40 additional damage
			%damage = %baseDamage * %x;

			$WeaponEnchantment[%enchant, "name"] = %baseEnchant @ " " @ %enchantLevel;
			$WeaponEnchantment[%enchant, "mod"] = "1 " @ %damage;
			$WeaponEnchantment[%enchant, "action"] = $enchantDamageVerb[%baseEnchant];
			$WeaponEnchantment[%enchant, "materia"] = %baseEnchant @ "Materia" @ %enchantLevel;

			$WeaponEnchantments = $WeaponEnchantments @ " " @ %enchant;
			// add materia to belt
			%item = %baseEnchant @ "Materia" @ %enchantLevel;
			BeltItem::AddItem(%baseEnchant @ " Materia " @ %enchantLevel, %item, "MateriaItems", 1, $materiaMiscInfo[%baseEnchant]);

			// create the smithing recipes
			if (%x > 1) {
				%prevMateria = %baseEnchant @ "Materia" @ $enchantLevels[%x-1];
				Smith::addItem(%prevMateria, %prevMateria @ " 5", %item @ " 1", $smithingNum++);
			}
		}
	}
}

function BeltItem::AddWeapon(%name, %item, %image, %accessoryType, %miscInfo, %weaponSkill, %skillRestriction, %dps, %shopIndex) {
	// add base weapon
	BeltItem::AddWeaponData(%name, %item, %image, %accessoryType, %miscInfo, %weaponSkill, %skillRestriction, %dps, "", %shopIndex);

	// add equipped version
	%equippedName = %name @ " " @ $equippedString;
	%equippedItem = %item @ "0";
	BeltItem::AddWeaponData(%equippedName, %equippedItem, %image, %accessoryType, %miscInfo, %weaponSkill, %skillRestriction, %dps);

	// create enchanted versions
	for(%i = 0; getWord($WeaponEnchantments, %i) != "" && getWord($WeaponEnchantments, %i) != -1; %i++) {
		%enchant = getWord($WeaponEnchantments, %i);
		%enchantName = $WeaponEnchantment[%enchant, "name"];
		%enchantMateria = $WeaponEnchantment[%enchant, "materia"];

		%enchantedWeaponName = %name @ " of " @ %enchantName;
		%enchantedWeaponItem = %item @ %enchant;
		BeltItem::AddWeaponData(%enchantedWeaponName, %enchantedWeaponItem, %image, %accessoryType, %miscInfo, %weaponSkill, %skillRestriction, %dps, %enchant);

		%equippedEnchantedName = %enchantedWeaponName @ " " @ $equippedString;
		%equippedEnchantedItem = %enchantedWeaponItem @ "0";
		BeltItem::AddWeaponData(%equippedEnchantedName, %equippedEnchantedItem, %image, %accessoryType, %miscInfo, %weaponSkill, %skillRestriction, %dps, %enchant);

		// add the smithing recipe for the enchant
		// Smith::addItem(%enchantedWeaponItem, %item @ " 1 " @ %enchantMateria @ " 1", %enchantedWeaponItem @ " 1", $smithingNum++);
	}
}

function BeltItem::GetType(%item) {
	return $beltitem[%item, "Type"];
}

function BeltItem::GetName(%item) {
	return $beltitem[%item, "Name"];
}

function BeltItem::GetImage(%item) {
	return $beltitem[%item, "Image"];
}

function BeltItem::GetEnchant(%item) {
	return $beltitem[%item, "Enchantment"];
}

function BeltItem::IsEquipped(%clientId, %item) {
	%amnt = Belt::HasThisStuff(%clientid, %item);
	%itemIsWorn = String::findSubStr(BeltItem::GetName(%item), $equippedString) != -1;

	if (%amnt > 0 && %itemIsWorn)
		return true;

	return false;
}

function Belt::HasThisStuff(%clientid, %item) {
	%item = $beltitem[%item, "Item"];
	%type = $beltitem[%item, "Type"];
	%list = fetchdata(%clientid, %type);
	%amnt = Belt::ItemCount(%item, %list);
	return %amnt;
}

function Belt::GiveThisStuff(%clientid, %item, %amnt, %echo) {
	%amnt = floor(%amnt);

	if(%amnt > 0) {
		%item = $beltitem[%item, "Item"];
		%type = $beltitem[%item, "Type"];
		%list = fetchdata(%clientid,%type);
		%count = Belt::ItemCount(%item,%list);


		if(%echo)
			Client::sendMessage(%clientId, 0, "You received " @ %amnt @ " " @ $beltitem[%item, "Name"] @". " @ "["@getDisp($beltitem[%item, "Type"])@", have "@(%count+%amnt)@"]");

		if(%count > 0) {
			%list = Belt::RemoveFromList(%list, %item@" "@%count);
			%amnt = %amnt + %count;
		}

		%list = Belt::AddToList(%list, %item@" "@%amnt);

		Storedata(%clientid, %type, %list);
		refreshWeight(%clientId);
	}
}

function Belt::TakeThisStuff(%clientid, %item, %amnt) {
	%amnt = floor(%amnt);

	if(%amnt > 0) {
		%item = $beltitem[%item, "Item"];
		%type = $beltitem[%item, "Type"];
		%list = fetchdata(%clientid,%type);
		%count = Belt::ItemCount(%item,%list);
		%amnt = %count - %amnt;
		%list = Belt::RemoveFromList(%list, %item@" "@%count);

		if(%amnt > 0)	%list = Belt::AddToList(%list, %item@" "@%amnt);

		Storedata(%clientid,%type,%list);
	}
}

function isBeltItem(%item) {
	%flag = false;

	if((String::ICompare($beltitem[%item, "Item"], %item) == 0))
		%flag = True;
 
	return %flag;
}

function Belt::ItemCount(%item,%list) {
	%count = 0;

	for(%i=0;(%w = getword(%list,%i)) != -1;%i+=2) {
		if(%w == %item) {
			%count = getword(%list,%i+1);
			break;
		}
	}
	return %count;
}

function Belt::HasItemNamed(%client, %itemName) {
	%count = 0;

	for(%ii=0;(%type = getword($belttypelist,%ii)) != -1;%ii++) {
		%list = fetchData(%client,%type);

		for(%i=0;(%w = getword(%list,%i)) != -1;%i+=2) {
			if(string::icompare(%itemName, $beltitem[%w, "Name"]) == 0) {
				%count = getword(%list,%i+1);
				return %w@" "@%count;
			}
		}
	}

	return false;
}

function Belt::AddToList(%list, %item) {
	%list = %list @ %item @ " ";
	return %list;
}

function Belt::RemoveFromList(%list, %item) {
	%a = " " @ %list;
	%a = String::replace(%a, " " @ %item @ " ", " ");
	%list = String::NEWgetSubStr(%a, 1, 99999);
	return %list;
}

function Belt::IsInList(%list, %item) {
	%a = " " @ %list;
	if(String::findSubStr(%a, " " @ %item @ " ") != -1)
		return True;
	else
		return False;
}

function Belt::BankStorageConversion(%clientid) {
	%bank =  fetchData(%clientId, "BankStorage");
	for(%i=0;getword(%bank,%i)!=-1;%i++) {
		%a = getword(%bank,%i);
		%b = getword(%bank,%i++);

		if(IsBeltItem(%a))
			Belt::BankGiveThisStuff(%clientid, %a, %b);
		else
			%banklist = %banklist@%a@" "@%b@" ";
	}
	storeData(%clientId, "BankStorage", " "@%banklist);
}

function Belt::BankGiveThisStuff(%clientid, %item, %amnt) {
	if(%amnt > 0) {
		%item = $beltitem[%item, "Item"];
		%type = $beltitem[%item, "Type"];
		%list = fetchdata(%clientid,"Bank"@%type);
		%count = Belt::ItemCount(%item,%list);

		if(%count > 0) {
			%list = Belt::RemoveFromList(%list, %item@" "@%count);
			%amnt = %amnt + %count;
		}

		%list = Belt::AddToList(%list, %item@" "@%amnt);
		Storedata(%clientid,"Bank"@%type,%list);
	}
}

function Belt::BankTakeThisStuff(%clientid,%item,%amnt) {
	if(%amnt > 0) {
		%item = $beltitem[%item, "Item"];
		%type = $beltitem[%item, "Type"];
		%list = fetchdata(%clientid,"Bank"@%type);
		%count = Belt::ItemCount(%item,%list);
		%amnt = %count - %amnt;

		%list = Belt::RemoveFromList(%list, %item@" "@%count);
		if(%amnt > 0)	%list = Belt::AddToList(%list, %item@" "@%amnt);

		Storedata(%clientid,"Bank"@%type,%list);
	}
}

function Belt::BankHasThisStuff(%clientid,%item) {
	%item = $beltitem[%item, "Item"];
	%type = $beltitem[%item, "Type"];
	%list = fetchdata(%clientid,"Bank"@%type);
	%amnt = Belt::ItemCount(%item,%list);
	return %amnt;
}

function Belt::BankGetNS(%clientid,%type) {
	%bn = 0;
	%num = $count[%type];
	for(%i;%i<=%num;%i++) {
		%item = $beltitem[%i, "Num", %type];
		%amnt = Belt::BankHasThisStuff(%clientid,%item);
		if(%amnt > 0) {
			%list = %list @" "@%item;
			%bn++;
		}
	}

	return %bn@%list;
}

function Belt::packgen(%clientId, %tmploot) {
	if(Player::isAiControlled(%clientId))
		TossLootbag(%clientId, %tmploot, 1, "*", 300);
	else {
		%namelist = rpg::getname(%clientId) @ ",";

		if(fetchData(%clientId, "LCK") >= 0)
			%tehLootBag = TossLootbag(%clientId, %tmploot, 5, %namelist, 0);//Cap(fetchData(%clientId, "LVL") * 300, 300, 0) //, 3600));
		else
			%tehLootBag = TossLootbag(%clientId, %tmploot, 5, %namelist, Cap(fetchData(%clientId, "LVL") * 0.2, 5, "inf"));

		pecho("Packgen num: "@%tehLootBag);
		pecho("Items: "@String::getSubStr(%tmploot, 0, 245));

		for(%i=0;getword(%tmploot,%i)!=-1;%i++) {
			%a = getword(%tmploot,%i);
			%b = getword(%tmploot,%i++);

			if($StealProtectedItem[%a] || $playerNoDrop[%a]) {
				%ba = Belt::RemoveFromList(%tmploot, %a@" "@%b);
				%tmploot = %ba;
				%i-=2;
			}
			else
				Belt::TakeThisStuff(%clientid, %a, %b);
		}
	}
}

function Belt::GetDeathItems(%clientid, %killerId) {
	%tmploot = "";

	if(fetchData(%clientId, "LCK") < 0) {
		%WeaponItems = fetchdata(%clientid, "WeaponItems");
		%unequippedWeaponItems = "";

		for(%i=0; (%w = getword(%WeaponItems, %i)) != -1; %i+=2) {
			%count = getword(%WeaponItems, %i+1);

            if (%i == 0) {
				%unequippedWeaponItems = getCroppedItem(%w) @ " " @ %count;
			} else {
				%unequippedWeaponItems = %unequippedWeaponItems @ " " @ getCroppedItem(%w) @ " " @ %count;
			}
		}

		if((String::len(%tmploot) + String::len(%unequippedWeaponItems)) > 200) {
			Belt::packgen(%clientId, %tmploot);
			%tmploot = "";
		}
		// need to remove all equipped weapons trailing 0 getCroppedItem()
		%tmploot = %tmploot @ %unequippedWeaponItems;

		%AmmoItems = fetchdata(%clientid,"AmmoItems");

		if((String::len(%tmploot) + String::len(%AmmoItems)) > 200) {
			Belt::packgen(%clientId, %tmploot);
			%tmploot = "";
		}
		%tmploot = %tmploot @ %AmmoItems;

		%PotionItems = fetchdata(%clientid,"PotionItems");
		if((String::len(%tmploot) + String::len(%PotionItems)) > 200){
			Belt::packgen(%clientId, %tmploot);
			%tmploot = "";
		}
		%tmploot = %tmploot @ %PotionItems;

		%GemItems = fetchdata(%clientid,"GemItems");
		if((String::len(%tmploot) + String::len(%GemItems)) > 200){
			Belt::packgen(%clientId, %tmploot);
			%tmploot = "";
		}
		%tmploot = %tmploot @ %GemItems;

		%QuestItems = fetchdata(%clientid,"QuestItems");
		if((String::len(%tmploot) + String::len(%QuestItems)) > 200){
			Belt::packgen(%clientId, %tmploot);
			%tmploot = "";
		}
		%tmploot = %tmploot @ %QuestItems;

		// should materia be droppable?
		// %MateriaItems = fetchdata(%clientid, "MateriaItems");
		// if((String::len(%tmploot) + String::len(%MateriaItems)) > 200){
		// 	Belt::packgen(%clientId, %tmploot);
		// 	%tmploot = "";
		// }
		// %tmploot = %tmploot @ %QuestItems;
	}//LCK < 0 happens when the player ran out, 0 is after the last one is used to protect this pack
	else {
		%tmpItems = fetchdata(%clientid, "QuestItems");
		for(%i = 0; GetWord(%tmpItems, %i) != -1; %i+=2) {
			%a = GetWord(%tmpItems, %i);
			if($loreitem[%a]) {
				%b = GetWord(%tmpItems, %i+1);
				%tmploot = %tmploot @ %a @ " " @ %b @ " ";
			}
		}
	}
	if(%tmploot != "") {
		for(%i=0;getword(%tmploot,%i)!=-1;%i++) {
			%a = getword(%tmploot,%i);
			%b = getword(%tmploot,%i++);

			if($StealProtectedItem[%a] || $playerNoDrop[%a]) {
				%ba = Belt::RemoveFromList(%tmploot, %a@" "@%b);
				%tmploot = %ba;
				%i-=2;
			}
			else
				Belt::TakeThisStuff(%clientid, %a, %b);
		}
	}
	if(%tmploot == "")
		%tmploot = " ";
	return %tmploot;
}

// handle equiping belt items
function Belt::EquipItem(%clientid, %item) {
	%count = belt::hasthisstuff(%clientId, %item);
	
	if (%count <= 0) {
		Client::sendMessage(%clientId, $MsgRed, "You do not have a " @ BeltItem::GetName(%item) @ ".~wbutton3.wav");
		return;
	}

	%beltItemType = BeltItem::GetType(%item);

	if (%beltItemType == "WeaponItems") {
		if (BeltItem::isEquipped(%clientId, %item)) {
			Belt::UnequipWeapon(%clientid, %item);
		} else {
			RPGmountItem(%clientid, %item, $WeaponSlot);
		}
	}
	else if (%beltItemType == "ArmorItems" || %beltItemType == "AccessoryItems") {
		Item::onUse(%clientId, %item);
	}
}

function Belt::EquipWeapon(%clientid, %item) {
	Client::sendMessage(%clientId, $MsgBeige, "You equipped " @ BeltItem::GetName(%item) @ ".~wCrossbow_Switch1.wav");
	Belt::TakeThisStuff(%clientId, %item, 1);
	Belt::GiveThisStuff(%clientid, %item @ "0", 1);
}

function Belt::UnequipWeapon(%clientid, %item) {
	lbecho("Belt::UnequipWeapon");
	%baseItem = String::getSubStr(%item, 0, String::len(%item)-1);	//remove the 0
	lbecho(%baseItem);
	Client::sendMessage(%clientId, $MsgBeige, "You unequipped " @ BeltItem::GetName(%baseItem) @ ".~wCrossbow_Switch1.wav");
	Belt::TakeThisStuff(%clientId, %item, 1);
	Belt::GiveThisStuff(%clientid, %baseItem, 1);
	// need to unmount weapon somehow
	Player::unMountItem(%clientid, $WeaponSlot);
}

function Belt::EquipAccessory(%clientid, %item) {
	Client::sendMessage(%clientId, $MsgBeige, "You equipped " @ BeltItem::GetName(%item) @ ".~wCrossbow_Switch1.wav");
	Belt::TakeThisStuff(%clientId, %item, 1);
	Belt::GiveThisStuff(%clientid, %item @ "0", 1);
}

function Belt::UnequipAccessory(%clientid, %item) {
	%baseItem = String::getSubStr(%item, 0, String::len(%item)-1);	//remove the 0
	Client::sendMessage(%clientId, $MsgBeige, "You unequipped " @ BeltItem::GetName(%baseItem) @ ".");
	Belt::TakeThisStuff(%clientId, %item, 1);
	Belt::GiveThisStuff(%clientid, %baseItem, 1);
}

$count["AmmoItems"] = 0;
$count["GemItems"] = 0;
$count["PotionItems"] = 0;
$count["WeaponItems"] = 0;
$count["ArmorItems"] = 0;
$count["QuestItems"] = 0;
$count["AccessoryItems"] = 0;
$count["MateriaItems"] = 0;
$numBeltItems = 0;

generateEnchantsAndMateria();

//Ammunition
BeltItem::Add("Small Rock","SmallRock","AmmoItems",0.2,13, "SmallRock", 1);
BeltItem::Add("Basic Arrow","BasicArrow","AmmoItems",0.1,GenerateItemCost(BasicArrow), "Arrow", 2);
BeltItem::Add("Sheaf Arrow","SheafArrow","AmmoItems",0.1,GenerateItemCost(SheafArrow), "Arrow", 3);
BeltItem::Add("Bladed Arrow","BladedArrow","AmmoItems",0.1,GenerateItemCost(BladedArrow), "Arrow", 4);
BeltItem::Add("Light Quarrel","LightQuarrel","AmmoItems",0.1,GenerateItemCost(LightQuarrel), "Quarrel", 5);
BeltItem::Add("Heavy Quarrel","HeavyQuarrel","AmmoItems",0.1,GenerateItemCost(HeavyQuarrel), "Quarrel", 6);
BeltItem::Add("Short Quarrel","ShortQuarrel","AmmoItems",0.1,GenerateItemCost(ShortQuarrel), "Quarrel", 7);
BeltItem::Add("Stone Feather","StoneFeather","AmmoItems",0.1,GenerateItemCost(StoneFeather), "Arrow", 8);
BeltItem::Add("Metal Feather","MetalFeather","AmmoItems",0.1,GenerateItemCost(MetalFeather), "Arrow", 9);
BeltItem::Add("Talon","Talon","AmmoItems",0.1,GenerateItemCost(Talon), "Arrow", 10);
BeltItem::Add("Ceraphum's Feather","CeraphumsFeather","AmmoItems",0.1,GenerateItemCost(CeraphumsFeather), "Arrow", 11);
BeltItem::Add("Poison Arrow", "PoisonArrow", "AmmoItems", 0.1, 200, "Arrow", 12);


//Gems
BeltItem::Add("Quartz","Quartz","GemItems",0.2,100);
BeltItem::Add("Granite","Granite","GemItems",0.2,180);
BeltItem::Add("Opal","Opal","GemItems",0.2,300);
BeltItem::Add("Jade","Jade","GemItems",0.25,550);
BeltItem::Add("Turquoise","Turquoise","GemItems",0.3,850);
BeltItem::Add("Ruby","Ruby","GemItems",0.3,1200);
BeltItem::Add("Topaz","Topaz","GemItems",0.3,1604);
BeltItem::Add("Sapphire","Sapphire","GemItems",0.3,2930);
BeltItem::Add("Gold","Gold","GemItems",0.35,4680);
BeltItem::Add("Emerald","Emerald","GemItems",0.2,9702);
BeltItem::Add("Diamond","Diamond","GemItems",0.1,16575);
BeltItem::Add("Keldrinite","Keldrinite","GemItems",5.0,125200);


//Potions
BeltItem::Add("Heal Potion","HealPotion","PotionItems", 0.5, 20, "", 13);
$AccessoryVar[Healpotion, $MiscInfo] = "A potion of Light healing that heals 25 HP";
$restoreValue[Healpotion, HP] = 25;

BeltItem::Add("Greater Heal Potion","GreaterHealPotion","PotionItems", 1, 100, "", 14);
$AccessoryVar[GreaterHealPotion, $MiscInfo] = "A potion of Greater Healing that heals 80 HP";
$restoreValue[GreaterHealPotion, HP] = 80;

BeltItem::Add("Mana Potion","ManaPotion","PotionItems", 0.5, 20, "", 15);
$AccessoryVar[ManaPotion, $MiscInfo] = "A Mana Potion that provides 20 MP";
$restoreValue[ManaPotion, MP] = 20;

BeltItem::Add("Energy Potion","EnergyPotion","PotionItems", 1, 100, "", 16);
$AccessoryVar[EnergyPotion, $MiscInfo] = "An Energy Potion that provides 50 MP";
$restoreValue[EnergyPotion, MP] = 50;

// $AccessoryVar[Hatchet, $SpecialVar] = "6 20";                  //12 (5)
// $AccessoryVar[BroadSword, $SpecialVar] = "6 35";               //21 (5)
// $AccessoryVar[WarAxe, $SpecialVar] = "6 70";                   //30 (7)
// $AccessoryVar[LongSword, $SpecialVar] = "6 65";                //39 (5)
// $AccessoryVar[BattleAxe, $SpecialVar] = "6 144";               //48 (9)
// $AccessoryVar[BastardSword, $SpecialVar] = "6 133";            //57 (7)
// $AccessoryVar[Halberd, $SpecialVar] = "6 176";                 //66 (8)
// $AccessoryVar[Claymore, $SpecialVar] = "6 188";                //75.2 (7.5)
// $AccessoryVar[KeldriniteLS, $SpecialVar] = "6 90";

// ============== WEAPONS=============================================
// IMPORTANT: The weight of the weapon needs to match up with the Image Being used otherwise they will not be in sync.
// To help with this, try to set the weight of all weapons that use the same image to be the same.
// If you specifically WANT to create a faster or slower verison if something you will need
// to make a new ItemImage for that speed. Name it as such and use it as much as you want.
// -------------------------------------------------------------------
// AddWeapon(%name, %item, %image, %accessoryType, %miscInfo, %weaponSkill, %skillRestriction, %dps, %shopIndex)

// Swords
$description = "This broad-bladed sword is suited for large slashing strokes. It is inexpensive, but not particularly powerful.";
BeltItem::AddWeapon("Broadsword", "Broadsword", "Sword", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 1", "20", 17);
$description = "This straight and sharp double-edged blade can be used for either stabbing or slashing.";
BeltItem::AddWeapon("Longsword", "Longsword", "LongSword", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 100", "30", 18);
$description = "This sword has a broad and sturdy blade, but its iron construction makes it very heavy.";
BeltItem::AddWeapon("Iron Sword", "IronSword", "GoliathSword", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 200", "40", 19);
$description = "A sword forged from the metal known as mythril. Its brilliantly shining blade is incredibly lightweight.";
BeltItem::AddWeapon("Mythril Sword", "MythrilSword", "Sword", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 300", "50", 20);
$description = "The handle of this single-edged sword has been decorated with intricate coral piecework.";
BeltItem::AddWeapon("Coral Sword", "CoralSword", "Sword", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 400", "60", 21);
$description = "The blade of this sword is a deep crimson, as if it were drenched in blood. It is cruelly sharp.";
BeltItem::AddWeapon("Blood Sword", "BloodSword", "Sword", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 500", "70", 22);
$description = "A sword constructed using ancient techniques that have long since perished from the world.";
BeltItem::AddWeapon("Ancient Sword", "AncientSword", "Sword", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 600", "80", 23);
$description = "A wide-bladed sword with a midnight blue handle.";
BeltItem::AddWeapon("Sleep Blade", "SleepBlade", "Sword", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 700", "90", 24);
$description = "The countless tiny diamonds embedded into this sword's blade saw into its victims, causing great damage.";
BeltItem::AddWeapon("Diamond Sword", "DiamondSword", "Sword", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 800", "100", 25);
$description = "A sword of extraplanar origin.";
BeltItem::AddWeapon("Materia Blade", "MateriaBlade", "Sword", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 900", "110", 26);
$description = "A shining sword made of a lustrous white alloy of mythril and platinum. Its broad blade is wickedly sharp.";
BeltItem::AddWeapon("Platinum Sword", "PlatinumSword", "Sword", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 1000", "120", 27);
$description = "A sword inscribed with ancient runes.";
BeltItem::AddWeapon("Rune Blade", "RuneBlade", "Sword", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 1200", "140", 28);
$description = "A sword that glitters cruelly like a crescent moon.";
BeltItem::AddWeapon("Moon Blade", "MoonBlade", "Sword", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 1500", "180", 29);
$description = "A blade forged for swordsmen who have mastered every technique and achieved knighthood's most exalted rank.";
BeltItem::AddWeapon("Onion Sword", "OnionSword", "Sword", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 2000", "240", 30); // shop item 46

// Axes
$description = "An inexpensive axe that is easy to wield. It is easy for new axe users, but not particularly powerful.";
BeltItem::AddWeapon("Hand Axe", "HandAxe", "HandAxe", $AxeAccessoryType, $description, $SkillSwords, $SkillSwords @ " 1", "25", 31); // shop item 47
$description = "A merdium sizes axe that is relatively common. It is most often used by woodsman, but is heavy enough to deal considerable damage.";
BeltItem::AddWeapon("Axe", "Axe", "Axe", $AxeAccessoryType, $description, $SkillSwords, $SkillSwords @ " 100", "35", 32);
$description = "A battle axe with a long handle. Designed for two-handed use, it can easily chop off an enemy's limbs.";
BeltItem::AddWeapon("Battle Axe", "BattleAxe", "BattleAxe", $AxeAccessoryType, $description, $SkillSwords, $SkillSwords @ " 200", "45", 33);

// Axes
// BeltItem::AddEquippable("Club", "Club", "WeaponItems", $AccessoryVar[Club, $Weight], GenerateItemCost(Club), "Mace");
// BeltItem::AddEquippable("Quarter Staff", "QuarterStaff", "WeaponItems", $AccessoryVar[QuarterStaff, $Weight], GenerateItemCost(QuarterStaff), "QuarterStaff");
// BeltItem::AddEquippable("Bone Club", "BoneClub", "WeaponItems", $AccessoryVar[BoneClub, $Weight], GenerateItemCost(BoneClub), "Mace");
// BeltItem::AddEquippable("Spiked Club", "SpikedClub", "WeaponItems", $AccessoryVar[SpikedClub, $Weight], GenerateItemCost(SpikedClub), "Mace");
// BeltItem::AddEquippable("Mace", "Mace", "WeaponItems", $AccessoryVar[Mace, $Weight], GenerateItemCost(Mace), "Mace");
// BeltItem::AddEquippable("Hammer Pick", "HammerPick", "WeaponItems", $AccessoryVar[HammerPick, $Weight], GenerateItemCost(HammerPick), "Pick");
// BeltItem::AddEquippable("Spiked Bone Club", "SpikedBoneClub", "WeaponItems", $AccessoryVar[SpikedBoneClub, $Weight], GenerateItemCost(SpikedBoneClub), "Mace");
// BeltItem::AddEquippable("Long Staff", "LongStaff", "WeaponItems", $AccessoryVar[LongStaff, $Weight], GenerateItemCost(LongStaff), "LongStaff");
// BeltItem::AddEquippable("War Hammer", "WarHammer", "WeaponItems", $AccessoryVar[WarHammer, $Weight], GenerateItemCost(WarHammer), "Hammer");
// BeltItem::AddEquippable("Justice Staff", "JusticeStaff", "WeaponItems", $AccessoryVar[JusticeStaff, $Weight], GenerateItemCost(JusticeStaff), "LongStaff");
// BeltItem::AddEquippable("War Maul", "WarMaul", "WeaponItems", $AccessoryVar[WarMaul, $Weight], GenerateItemCost(WarMaul), "Hammer");

// Hammers
// BeltItem::AddEquippable("Pick Axe", "PickAxe", "WeaponItems", $AccessoryVar[PickAxe, $Weight], GenerateItemCost(PickAxe), "Pick");
// BeltItem::AddEquippable("Knife", "Knife", "WeaponItems", $AccessoryVar[Knife, $Weight], GenerateItemCost(Knife), "Dagger");
// BeltItem::AddEquippable("Dagger", "Dagger", "WeaponItems", $AccessoryVar[Dagger, $Weight], GenerateItemCost(Dagger), "Dagger");
// BeltItem::AddEquippable("Short Sword", "ShortSword", "WeaponItems", $AccessoryVar[ShortSword, $Weight], GenerateItemCost(ShortSword), "ShortSword");
// BeltItem::AddEquippable("Spear", "Spear", "WeaponItems", $AccessoryVar[Spear, $Weight], GenerateItemCost(Spear), "Spear");
// BeltItem::AddEquippable("Gladius", "Gladius", "WeaponItems", $AccessoryVar[Gladius, $Weight], GenerateItemCost(Gladius), "Sword");
// BeltItem::AddEquippable("Trident", "Trident", "WeaponItems", $AccessoryVar[Trident, $Weight], GenerateItemCost(Trident), "Trident");
// BeltItem::AddEquippable("Rapier", "Rapier", "WeaponItems", $AccessoryVar[Rapier, $Weight], GenerateItemCost(Rapier), "Katana");
// BeltItem::AddEquippable("Awl Pike", "AwlPike", "WeaponItems", $AccessoryVar[AwlPike, $Weight], GenerateItemCost(AwlPike), "Spear");

// Katanas

// Staves

// Bows
$description = "A sling";
BeltItem::AddWeapon("Sling", "Sling", "Sling", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 1", "15");

// Enemy Weapons
$description = "A casting blade.";
BeltItem::AddWeapon("Casting Blade", "CastingBlade", "CastingBlade", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 1", "20");
$description = "A chipped dagger that looks dirty and worn.";
BeltItem::AddWeapon("Chipped Dagger", "ChippedDagger", "Dagger", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 1", "10");
$description = "A dagger that looks dirty and worn.";
BeltItem::AddWeapon("Dagger", "Dagger", "Dagger", $SwordAccessoryType, $description, $SkillSwords, $SkillSwords @ " 1", "20");

BeltItem::AddWeapon("Rune Sword", "RuneSword", "GemSword", $SwordAccessoryType, "A mystical rune blade", $SkillSwords, $SkillSwords @ " 20", "200");

// rusties + damaged weapons
// BeltItem::AddEquippable("Rusty Hatchet", "RHatchet", "WeaponItems", $AccessoryVar[RHatchet, $Weight], $ItemCost[RHatchet], "Hatchet");
// BeltItem::AddEquippable("Rusty Broad Sword", "RBroadSword", "WeaponItems", $AccessoryVar[RBroadSword, $Weight], $ItemCost[RBroadSword], "Sword");
// BeltItem::AddEquippable("Rusty Long Sword", "RLongSword", "WeaponItems", $AccessoryVar[RLongSword, $Weight], $ItemCost[RLongSword], "LongSword");
// BeltItem::AddEquippable("Cracked Club", "RClub", "WeaponItems", $AccessoryVar[RClub, $Weight], $ItemCost[RClub], "Mace");
// BeltItem::AddEquippable("Cracked Spiked Club", "RSpikedClub", "WeaponItems", $AccessoryVar[RSpikedClub, $Weight], $ItemCost[RSpikedClub], "Mace");
// BeltItem::AddEquippable("Rusty Knife", "RKnife", "WeaponItems", $AccessoryVar[RKnife, $Weight], $ItemCost[RKnife], "Dagger");
// BeltItem::AddEquippable("Rusty Dagger", "RDagger", "WeaponItems", $AccessoryVar[RDagger, $Weight], $ItemCost[RDagger], "Dagger");
// BeltItem::AddEquippable("Rusty Short Sword", "RShortSword", "WeaponItems", $AccessoryVar[RShortSword, $Weight],$ItemCost[RShortSword], "ShortSword");
// BeltItem::AddEquippable("Rusty Pick Axe", "RPickAxe", "WeaponItems", $AccessoryVar[RPickAxe, $Weight], $ItemCost[RPickAxe], "Pick");
// BeltItem::AddEquippable("Rusty Short Bow", "RShortBow", "WeaponItems", $AccessoryVar[RShortBow, $Weight], $ItemCost[RShortBow], "LongBow");
// BeltItem::AddEquippable("Cracked Light Crossbow", "RLightCrossbow", "WeaponItems", $AccessoryVar[RLightCrossbow, $Weight], $ItemCost[RLightCrossbow], "Crossbow");
// BeltItem::AddEquippable("Rusty War Axe", "RWarAxe", "WeaponItems", $AccessoryVar[RWarAxe, $Weight], $ItemCost[RWarAxe], "Axe");

// Medium / Heavy Armors
// BeltItem::AddArmor(%name, %item, %armorSkin, %hitSound, %special, %weight, %miscInfo, %shopIndex)
$description = "Made for use in battle, this is sturdier than normal clothing.";
BeltItem::AddArmor("Leather Clothing", "LeatherClothing", "rpgpadded", SoundHitFlesh, "7 30 4 5", "10", $SkillEndurance @ " 5", $description);
$description = "Armor made from layers of tanned leather.";
BeltItem::AddArmor("Leather Armor", "LeatherArmor", "rpgleather", SoundHitLeather, "7 30 4 5", "10", $SkillEndurance @ " 5", $description);
$description = "Linen armor with a bronze breastplate.";
BeltItem::AddArmor("Linen Cuirass", "LinenCuirass", "rpgstudleather", SoundHitLeather, "7 30 4 5", "10", $SkillEndurance @ " 5", $description);
$description = "Simply fashioned bronze armor.";
BeltItem::AddArmor("Bronze Armor", "BronzeArmor", "rpgspiked", SoundHitLeather, "7 30 4 5", "10", $SkillEndurance @ " 5", $description);
$description = "Armor fashioned from countless interlocking metal rings.";
BeltItem::AddArmor("Chain Mail", "ChainMail", "rpgchainmail", SoundHitLeather, "7 30 4 5", "10", $SkillEndurance @ " 5", $description);
$description = "Armor made from the valuable metal known as mythril. It is surprisingly light and sturdy.";
BeltItem::AddArmor("Mythril Armor", "MythrilArmor", "rpgscalemail", SoundHitChain, "7 30 4 5", "10", $SkillEndurance @ " 5", $description);
$description = "The unique design of this mythril armor greatly increases its protective qualities.";
BeltItem::AddArmor("Plate Mail", "PlateMail", "rpgbrigandine", SoundHitChain, "7 30 4 5", "10", $SkillEndurance @ " 5", $description);
$description = "Improved plate mail that has been decorated with gold.";
BeltItem::AddArmor("Golden Armor", "GoldenArmor", "rpgchainmail", SoundHitChain, "7 30 4 5", "10", $SkillEndurance @ " 5", $description);
$description = "Armor that has been reinforced with incredibly hard gemstones.";
BeltItem::AddArmor("Diamond Armor", "DiamondArmor", "rpgringmail", SoundHitChain, "7 30 4 5", "10", $SkillEndurance @ " 5", $description);
$description = "Brilliantly shining armor made of a lustrous white alloy of mythril and platinum.";
BeltItem::AddArmor("Platinum Armor", "PlatinumArmor", "rpgbandedmail", SoundHitChain, "7 30 4 5", "10", $SkillEndurance @ " 5", $description);
$description = "Thick mythril armor designed to withstand even the most intense shocks.";
BeltItem::AddArmor("Carabineer Mail", "CarabineerMail", "rpgsplintmail", SoundHitChain, "7 30 4 5", "10", $SkillEndurance @ " 5", $description);
$description = "Armor with the power to reflect magick used on the wearer.";
BeltItem::AddArmor("Mirror Mail", "MirrorMail", "rpgbronzeplate", SoundHitPlate, "7 30 4 5", "10", $SkillEndurance @ " 5", $description);
$description = "Platinum armor reinforced in places with crystalline gemstones found deep within the earth.";
BeltItem::AddArmor("Crystal Armor", "CrystalArmor", "rpgplatemail", SoundHitPlate, "7 30 4 5", "10", $SkillEndurance @ " 5", $description);
$description = "Legendary armor given by the gods to a knight in honor of his service. Confers divine protection to the wearer.";
BeltItem::AddArmor("Genji Armor", "GenjiArmor", "rpgfieldplate", SoundHitPlate, "7 30 4 5", "10", $SkillEndurance @ " 5", $description);
$description = "Top-grade armor made with advanced techniques. The materials and design make it exceedingly strong.";
BeltItem::AddArmor("Maximillian", "Maximillian", "rpgfullplate", SoundHitPlate, "7 30 4 5", "10", $SkillEndurance @ " 5", $description);
$description = "A dark mail covered in scales of fallen Dragons.";
BeltItem::AddArmor("Dragon Mail", "DragonMail", "rpghuman6", SoundHitPlate, "7 30 4 5", "10", $SkillEndurance @ " 5", $description);
$description = "Armor forged for swordsmen who have mastered every technique and achieved knighthood's most exalted rank.";
BeltItem::AddArmor("Onion Armor", "OnionArmor", "rpgfullplate",  SoundHitPlate,"7 30 4 5", "10", $SkillEndurance @ " 5", $description);
// Light Armors / Robes
$description = "Padded Armor";
BeltItem::AddRobe("Light Robe", "LightRobe", "rpgpadded", "7 30 4 5", "10", $SkillEndurance @ " 0 " @ $SkillEnergy @ " 8", $description);
$description = "Padded Armor";
BeltItem::AddRobe("Blood Robe", "BloodRobe","rpgpadded", "7 30 4 5", "10", $SkillEndurance @ " 0 " @ $SkillEnergy @ " 8", $description);
$description = "Padded Armor";
BeltItem::AddRobe("Advisor Robe", "AdvisorRobe", "rpgpadded", "7 30 4 5", "10", $SkillEndurance @ " 0 " @ $SkillEnergy @ " 8", $description);
$description = "Padded Armor";
BeltItem::AddRobe("Robe Of Venjance", "RobeOfVenjance", "rpgpadded", "7 30 4 5", "10", $SkillEndurance @ " 0 " @ $SkillEnergy @ " 8", $description);
$description = "Padded Armor";
BeltItem::AddRobe("Phens Robe", "PhensRobe", "rpgpadded", "7 30 4 5", "10", $SkillEndurance @ " 0 " @ $SkillEnergy @ " 8", $description);
$description = "Padded Armor";
BeltItem::AddRobe("Quest Master Robe", "QuestMasterRobe", "rpgpadded", "7 30 4 5", "10", $SkillEndurance @ " 0 " @ $SkillEnergy @ " 8", $description);
$description = "Padded Armor";
BeltItem::AddRobe("Fine Robe", "FineRobe", "rpgpadded", "7 30 4 5", "10", $SkillEndurance @ " 0 " @ $SkillEnergy @ " 8", $description);
$description = "Padded Armor";
BeltItem::AddRobe("Elven Robe", "ElvenRobe", "rpgpadded", "7 30 4 5", "10", $SkillEndurance @ " 0 " @ $SkillEnergy @ " 8", $description);

// Shields
$description = "Padded Armor";
BeltItem::AddShield("Knight Shield", "KnightShield", $AccessoryVar[KnightShield, $Weight]);
$description = "Padded Armor";
BeltItem::AddShield("Heavenly Shield", "HeavenlyShield", $AccessoryVar[HeavenlyShield, $Weight]);
$description = "Padded Armor";
BeltItem::AddShield("Dragon Shield", "DragonShield", $AccessoryVar[DragonShield, $Weight]);

// Accessory Items
BeltItem::Add("Cheetaurs Paws", "CheetaursPaws", "AccessoryItems", $AccessoryVar[CheetaursPaws, $Weight], GenerateItemCost(CheetaursPaws));
BeltItem::Add("Cheetaurs Paws "@$equippedString, "CheetaursPaws0", "AccessoryItems", $AccessoryVar[CheetaursPaws, $Weight], GenerateItemCost(CheetaursPaws));
BeltItem::Add("Boots of Gliding", "BootsOfGliding", "AccessoryItems", $AccessoryVar[BootsOfGliding, $Weight], GenerateItemCost(BootsOfGliding));
BeltItem::Add("Boots of Gliding "@$equippedString, "BootsOfGliding0", "AccessoryItems", $AccessoryVar[BootsOfGliding, $Weight], GenerateItemCost(BootsOfGliding));
BeltItem::Add("Wind Walkers", "WindWalkers", "AccessoryItems", $AccessoryVar[WindWalkers, $Weight], GenerateItemCost(WindWalkers));
BeltItem::Add("Wind Walkers "@$equippedString, "WindWalkers0", "AccessoryItems", $AccessoryVar[WindWalkers, $Weight], GenerateItemCost(WindWalkers));
BeltItem::Add("Tent", "Tent", "AccessoryItems", $AccessoryVar[Tent, $Weight], GenerateItemCost(Tent));

// Quest Items
BeltItem::Add("Black Statue", "BlackStatue", "QuestItems", $AccessoryVar[BlackStatue, $Weight], GenerateItemCost(BlackStatue));
BeltItem::Add("Skeleton Bone", "SkeletonBone", "QuestItems", $AccessoryVar[SkeletonBone, $Weight], GenerateItemCost(SkeletonBone));
BeltItem::Add("Enchanted Stone", "EnchantedStone", "QuestItems", $AccessoryVar[EnchantedStone, $Weight], GenerateItemCost(EnchantedStone));
BeltItem::Add("Dragon Scale", "DragonScale", "QuestItems", $AccessoryVar[DragonScale, $Weight], GenerateItemCost(DragonScale));
BeltItem::Add("Parchment", "Parchment", "QuestItems", $AccessoryVar[Parchment, $Weight], GenerateItemCost(Parchment));
BeltItem::Add("Magic Dust", "MagicDust", "QuestItems", $AccessoryVar[MagicDust, $Weight], GenerateItemCost(MagicDust));
