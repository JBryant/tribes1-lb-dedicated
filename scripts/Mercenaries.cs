// Mercenary templates and helpers
echo("### mercenaries.cs LOADED ###");

$Merc::init = False;
$Merc::count = 0;
$MercBotList = "";

function Merc::Init() {
	if($Merc::init && $Merc::count > 0)
		return;

	$Merc::init = True;
	$Merc::count = 0;
	$Merc::namePool = "Alden Bria Cora Dax Elen Fenn Garr Hal Ilya Jax Kira Lorn Mira Nox Orin Pax Quin Risa Soren Tavi Varn Wren Yara Zane";

	// id, displayName, class, defaults, cost, race, gender, role
	Merc::AddTemplate(1, "Pelinor", "Squire", "Longsword 1 LVL 20", 1500, "MaleHuman", "Male", "tank", "Pelinor is a stout and sturdy boy.");
	Merc::AddTemplate(2, "Mr Squiggles", "Chemist", "IronwoodStaff 1 LVL 20", 2000, "MaleHuman", "Male", "support", "Mr. Squiggles is a mischievous chemist.");
	Merc::AddTemplate(3, "Lady Lisandra", "BlackMage", "CastingBlade 1 LVL 20", 2400, "FemaleHuman", "Female", "dps", "Lady Lisandra is a confident mage with a teasing streak.");

	Merc::SpawnTownMerc(3, "-2397.2 -250.891 65.0002", "0 -0 2.98419");
}

function Merc::AddTemplate(%id, %displayName, %class, %defaults, %cost, %race, %gender, %role, %description) {
	$Merc::name[%id] = %displayName;
	$Merc::class[%id] = %class;
	$Merc::defaults[%id] = %defaults;
	$Merc::cost[%id] = %cost;
	$Merc::race[%id] = %race;
	$Merc::gender[%id] = %gender;
	$Merc::role[%id] = %role;
	$Merc::description[%id] = %description;
    
	if(%id > $Merc::count)
		$Merc::count = %id;
}

function Merc::GetCount() {
	return $Merc::count;
}

function Merc::SpawnTownMerc(%templateId, %pos, %rot) {
	%displayName = $Merc::name[%templateId];
	if(%displayName == "")
		return "";

	%existing = NEWgetClientByName(%displayName);
	if(%existing != -1 && Player::isAiControlled(%existing)) {
		%id = %existing;
	}
	else {
		%class = $Merc::class[%templateId];
		%defaults = $Merc::defaults[%templateId];
		if(%class == "" || %defaults == "")
			return "";

		%aiKey = "generic";
		$BotEquipment[%aiKey] = "CLASS " @ %class @ " " @ %defaults;
		%aiName = AI::helper(%aiKey, %displayName, "TempSpawn " @ %pos @ " 0");
		%id = AI::getId(%aiName);

		if(%id == "")
			return "";
	}

	if($Merc::race[%templateId] != "")
		ChangeRace(%id, $Merc::race[%templateId]);

	GameBase::setPosition(%id, %pos);
	GameBase::setRotation(%id, %rot);

	storeData(%id, "botAttackMode", 1);
	storeData(%id, "frozen", True);
	storeData(%id, "tmpbotdata", "");
	storeData(%id, "petowner", "");
	storeData(%id, "OwnerID", "");

	$Merc::owner[%id] = "";
	$Merc::ownerName[%id] = "";
	%id.ownerId = "";
	%id.ownerName = "";

	%id.mercTemplate = %templateId;
	$Merc::templateById[%id] = %templateId;
	$Merc::name[%id] = %displayName;

	Merc::NormalizeList();
	if (String::findSubStr($MercBotList, " " @ %id @ " ") == -1)
		$MercBotList = $MercBotList @ " " @ %id;

	$Merc::townMerc[%templateId] = %id;
	return %id;
}

function Merc::PickName() {
	%list = $Merc::namePool;
	for(%i = 0; (%n = getWord(%list, %i)) != -1; %i++) {
		if(NEWgetClientByName(%n) == -1)
			return %n;
	}

	return "Mercenary";
}

function Merc::GetOwnerMerc(%clientId) {
	%id = fetchData(%clientId, "MercenaryId");
	if(%id == "" || %id == 0)
		return "";
	if(Player::isAiControlled(%id))
		return %id;
	return "";
}

function Merc::SpawnFor(%clientId, %templateId) {
	if (Merc::GetOwnerMerc(%clientId) != "")
		return "";

	%class = $Merc::class[%templateId];
	%defaults = $Merc::defaults[%templateId];
	if(%class == "" || %defaults == "")
		return "";

	%aiKey = "generic";
	$BotEquipment[%aiKey] = "CLASS " @ %class @ " " @ %defaults;

	%spawnPos = GameBase::getPosition(%clientId);
	%displayName = $Merc::name[%templateId]; // Merc::PickName();
	%aiName = AI::helper(%aiKey, %displayName, "TempSpawn " @ %spawnPos @ " " @ GameBase::getTeam(%clientId));
	%id = AI::getId(%aiName);

	if(%id == "")
		return "";

	if($Merc::race[%templateId] != "")
		ChangeRace(%id, $Merc::race[%templateId]);

	storeData(%id, "tmpbotdata", %clientId);
	storeData(%id, "botAttackMode", 2);
	storeData(%id, "petowner", %clientId);
	storeData(%id, "OwnerID", %clientId);
	$Merc::owner[%id] = %clientId;
	$Merc::ownerName[%id] = Client::getName(%clientId);
	%id.ownerId = %clientId;
	%id.ownerName = Client::getName(%clientId);

	storeData(%clientId, "MercenaryId", %id);
	storeData(%clientId, "MercenaryTemplate", %templateId);
	%id.mercTemplate = %templateId;
	$Merc::templateById[%id] = %templateId;
	$Merc::name[%id] = %displayName;

	$PetList = AddToCommaList($PetList, %id);
	storeData(%clientId, "PersonalPetList", AddToCommaList(fetchData(%clientId, "PersonalPetList"), %id));
	Merc::NormalizeList();
	if (String::findSubStr($MercBotList, " " @ %id @ " ") == -1)
		$MercBotList = $MercBotList @ " " @ %id;

	if(!fetchData(%clientId, "partyOwned"))
		CreateParty(%clientId);
	AddToParty(%clientId, Client::getName(%id));

	return %id;
}

function Merc::RequestJoin(%mercId, %clientId) {
	lbecho("Merc::RequestJoin(" @ %mercId @ ", " @ %clientId @ ")");
	%mercId = floor(%mercId);
	if(%mercId == "" || %mercId == 0 || %clientId == "" || %clientId == 0)
		return;

	if(!Player::isAiControlled(%mercId))
		return;

	%currentOwner = $Merc::owner[%mercId];
	if(%currentOwner != "" && %currentOwner != False && %currentOwner != %clientId) {
		AI::sayLater(%clientId, %mercId, "I am already in another's service.", True);
		return;
	}

	if(Merc::GetOwnerMerc(%clientId) != "" && %currentOwner != %clientId) {
		AI::sayLater(%clientId, %mercId, "You already have a mercenary.", True);
		return;
	}

	storeData(%mercId, "tmpbotdata", %clientId);
	storeData(%mercId, "botAttackMode", 2);
	storeData(%mercId, "petowner", %clientId);
	storeData(%mercId, "OwnerID", %clientId);
	storeData(%mercId, "frozen", "");

	$Merc::owner[%mercId] = %clientId;
	$Merc::ownerName[%mercId] = Client::getName(%clientId);
	%mercId.ownerId = %clientId;
	%mercId.ownerName = Client::getName(%clientId);

	%templateId = $Merc::templateById[%mercId];
	if(%templateId == "")
		%templateId = %mercId.mercTemplate;
	storeData(%clientId, "MercenaryId", %mercId);
	storeData(%clientId, "MercenaryTemplate", %templateId);

	$PetList = AddToCommaList($PetList, %mercId);
	storeData(%clientId, "PersonalPetList", AddToCommaList(fetchData(%clientId, "PersonalPetList"), %mercId));
	Merc::NormalizeList();
	if (String::findSubStr($MercBotList, " " @ %mercId @ " ") == -1)
		$MercBotList = $MercBotList @ " " @ %mercId;

	if(!fetchData(%clientId, "partyOwned"))
		CreateParty(%clientId);
	AddToParty(%clientId, Client::getName(%mercId));
}

function Merc::Dismiss(%clientId, %mercId) {
	if (%mercId == "" || %mercId == 0)
		return;

	$PetList = RemoveFromCommaList($PetList, %mercId);
	storeData(%clientId, "PersonalPetList", RemoveFromCommaList(fetchData(%clientId, "PersonalPetList"), %mercId));
	Merc::NormalizeList();
	$MercBotList = String::replace($MercBotList, " " @ %mercId @ " ", " ");

	storeData(%clientId, "MercenaryId", "");
	storeData(%clientId, "MercenaryTemplate", "");

	storeData(%mercId, "petowner", "");
	storeData(%mercId, "OwnerID", "");
	storeData(%mercId, "tmpbotdata", "");
	storeData(%mercId, "botAttackMode", 1);
	$Merc::owner[%mercId] = "";
	$Merc::ownerName[%mercId] = "";
	%mercId.ownerId = "";
	%mercId.ownerName = "";
	%mercId.mercTemplate = "";
	$Merc::templateById[%mercId] = "";
	$Merc::name[%mercId] = "";

	RemoveFromParty(%clientId, Client::getName(%mercId), True);

	AI::newDirectiveRemove(fetchData(%mercId, "BotInfoAiName"), 99);
	deleteObject(%mercId);
}

function Merc::NormalizeList() {
	// Normalize to a space-delimited list without commas
	if (String::findSubStr($MercBotList, ",") != -1)
		$MercBotList = String::replaceAll($MercBotList, ",", " ");
	if (String::getSubStr($MercBotList, 0, 1) != " ")
		$MercBotList = " " @ $MercBotList;
}

function Merc::Escape(%s) {
    %s = String::replace(%s, "\\", "\\\\");
    %s = String::replace(%s, "\t", "\\t");
    %s = String::replace(%s, "\n", "\\n");
    %s = String::replace(%s, "\r", "");
    return %s;
}

function Merc::Talk(%clientId, %mercId, %message) {
	if(%mercId == "" || %mercId == 0)
		return;

	%ownerId = $Merc::owner[%mercId];
	%ownerName = $Merc::ownerName[%mercId];
	%mercName = $Merc::name[%mercId];
	if(%mercName == "") {
		%templateId = $Merc::templateById[%mercId];
		if(%templateId == "")
			%templateId = %mercId.mercTemplate;
		%mercName = $Merc::name[%templateId];
	}

	if(%ownerId == "")
		%ownerId = %mercId.ownerId;
	if(%ownerName == "")
		%ownerName = %mercId.ownerName;

	%isOwner = False;
	if(%ownerId != "") {
		if(%ownerId == %clientId)
			%isOwner = True;
	}

	if(!%isOwner && %ownerName != "") {
		if(String::ICompare(%ownerName, Client::getName(%clientId)) == 0)
			%isOwner = True;
	}

	if(!%isOwner && IsInCommaList(fetchData(%clientId, "PersonalPetList"), %mercId))
		%isOwner = True;

	// if(!%isOwner) {
	// 	AI::sayLater(%clientId, %mercId, "I'm not your mercenary.", True);
	// 	return;
	// }

	// AI::sayLater(%clientId, %mercId, "I'm ready. Use #merc commands to direct me.", True);
    
    // echo message to console.log to pickup by aidaemon.js
    lbecho(
        "LLM_MERC_CHAT\t" @
        "v1\t" @
        $LLM::ServerId @ "\t" @
        %mercId @ "\t" @
         %mercName @ "\t" @
        %clientId @ "\t" @
        Client::getName(%clientId) @ "\t" @
        "say\t" @
        %message @
        ""
    );
}

function Merc::IsOwner(%clientId, %mercId) {
	%ownerId = $Merc::owner[%mercId];
	%ownerName = $Merc::ownerName[%mercId];

	if(%ownerId == "")
		%ownerId = %mercId.ownerId;
	if(%ownerName == "")
		%ownerName = %mercId.ownerName;

	if(%ownerId != "" && %ownerId == %clientId)
		return True;
	if(%ownerName != "" && String::ICompare(%ownerName, Client::getName(%clientId)) == 0)
		return True;
	if(IsInCommaList(fetchData(%clientId, "PersonalPetList"), %mercId))
		return True;
	return False;
}

function Merc::GetHealAmount(%mercId) {
	%healSkill = $PlayerSkill[%mercId, $SkillHealing];
	if(%healSkill == "" || %healSkill <= 0)
		%healSkill = 1;
	%amount = floor(%healSkill * 2) + 10;
	if(%amount > 200)
		%amount = 200;
	return %amount;
}

function Merc::GetBestHealSpell(%mercId) {
	%level = getFinalLVL(%mercId);
	%mana = getMANA(%mercId);

	%spell = "medic4 medic3 medic2";
	for(%i = 0; (%kw = getWord(%spell, %i)) != -1; %i++) {
		%index = $Spell::index[%kw];
		if(%index == "")
			continue;
		if(%level < $Spell::minLevel[%index])
			continue;
		if(%mana < $Spell::manaCost[%index])
			continue;
		return %kw;
	}

	return "";
}

function Merc::RequestHeal(%mercId, %clientId) {
	if(%mercId == "" || %mercId == 0 || %clientId == "" || %clientId == 0)
		return;
	if(!Player::isAiControlled(%mercId))
		return;
	if(!Merc::IsOwner(%clientId, %mercId))
		return;

	%templateId = $Merc::templateById[%mercId];
	if(%templateId == "")
		%templateId = %mercId.mercTemplate;
	%role = $Merc::role[%templateId];
	if(%role != "" && %role != "support")
		return;

	Merc::TryHeal(%mercId, %clientId, 0);
}

function Merc::TryHeal(%mercId, %clientId, %attempts) {
	if(%attempts == "")
		%attempts = 0;

	if(%attempts > 3)
		return;

	if(fetchData(%clientId, "HP") <= 0)
		return;

	%mercPos = GameBase::getPosition(%mercId);
	%clientPos = GameBase::getPosition(%clientId);

	if(%mercPos == "" || %clientPos == "")
		return;

	if(Vector::getDistance(%mercPos, %clientPos) > 25) {
		%aiName = fetchData(%mercId, "BotInfoAiName");

		if(%aiName != "")
			AI::moveToLOS(%aiName, %clientId);

		schedule("Merc::TryHeal(" @ %mercId @ ", " @ %clientId @ ", " @ (%attempts + 1) @ ");", 1.0);
		return;
	}

	%spellKeyword = Merc::GetBestHealSpell(%mercId);
	if(%spellKeyword == "")
		return;

	%rot = Vector::getRotation(Vector::normalize(Vector::sub(%clientPos, %mercPos)));
	%rot = "0 -0 " @ GetWord(%rot, 2);
	GameBase::setRotation(%mercId, %rot);

	%mercObj = Client::getOwnedObject(%mercId);
	%clientObj = Client::getOwnedObject(%clientId);

	if(%mercObj != "" && GameBase::getLOSinfo(%mercObj, 500)) {
		if($los::object == %clientObj) {
			BeginCastSpell(%mercId, %spellKeyword);
			return;
		}
	}

	%aiName = fetchData(%mercId, "BotInfoAiName");
	if(%aiName != "")
		AI::moveToLOS(%aiName, %clientId);
	
	schedule("Merc::TryHeal(" @ %mercId @ ", " @ %clientId @ ", " @ (%attempts + 1) @ ");", 1.0);
}

function Merc::DeliverReply(%mercClientId, %playerClientId, %text) {
	say(%mercClientId, %text);
 }

 function DeliverMercReply(%mercClientId, %playerClientId, %text) {
    Merc::DeliverReply(%mercClientId, %playerClientId, %text);
 }
