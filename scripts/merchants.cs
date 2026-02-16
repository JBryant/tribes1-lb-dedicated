// Merchants registry and zone-based spawning.

function Merchant::Init() {
	$Merchant::UseZoneSpawns = True;
	$Merchant::count = 0;

	// Kalm
	Merchant::Add("merchant1", "Kalm", "-2403.5 -296.25 65.0914", "0 -0 0.559927", "Darius", "MaleHuman", "CLASS Chemist LVL 2 LCK 0", "1 508 509 606 607 611 612 616 550 299", "Welcome to the Kalm General Store. If you need better Weapons and Armor, see Willy and Billy next door.");
	Merchant::Add("merchant14", "Kalm", "-2419.5 -284.139 65.0989", "0 -0 3.11992", "Willy", "MaleHuman", "CLASS Chemist LVL 2 LCK 0 Dagger 1", "17 18 19 51 52 53 100 101 102 125 126 127 150 151 152", "Welcome to Willy's Weapons! Talk to my brother Billy if you need Armor.");
	Merchant::Add("merchant15", "Kalm", "-2426.04 -290 65.0989", "0 -0 -1.61989", "Billy", "MaleHuman", "CLASS Chemist LVL 2 LCK 0 Dagger 1", "200 201 202 203 204 250 251 252 253 254", "Looking for good Armor? Talk to my brother Willy if you need Weapons.");
	Merchant::Add("merchant16", "Kalm", "-2413.34 -291.223 65.0989", "0 -0 1.5699", "Kelinor", "MaleHuman", "CLASS Chemist LVL 2 LCK 0 Dagger 1", "1 2 3 174 176 177 178 298 1050 1051 1052 1053", "Looking to hit your target from a distance? Check out my Ranged Weapons.");
	Merchant::Add("merchant17", "Kalm", "-2445.8 -297.309 65.0889", "0 -0 -0.846989", "Celine", "FemaleHuman", "CLASS Chemist LVL 2 LCK 0 Dagger 1", "312 313 314 315 316 307 308 309 310 311", "Come to look at my beautiful selection of Jewelry?");

	// Kalm Inn
	Merchant::Add("merchant13", "Kalm Inn", "1993.79 501.375 2400", "0 -0 -0.853833", "Dustin", "MaleHuman", "CLASS Chemist LVL 2 LCK 0 Dagger 1", "616 801 850 851 852 853 701", "Welcome to Kalm Inn. Care to look at my wares?");
	Merchant::Add("merchant28", "Kalm Inn", "2001.96 503.667 2200", "0 -0 -0.850831", "Becca", "FemaleHuman", "CLASS Archer LVL 2 LCK 0", "1200 1201 1202 1203 1204 1205 1206 1207 1208 1209 1210 1211 1212 1213 1214 1215 1216 1217 1218 1219 1220 1221 1222 1223 1224 1225 1226 1227 1228 1229 1230 1231 1232 1233 1234 1235 1236 1237 1238 1239 1240 1241 1242 1243 1244 1245 1246 1247 1248 1249 1250 1251 1252 1253 1254 1255 1256 1257 1258 1259 1260 1261 1262 1263 1264 1265 1266 1267 1268 1269 1270 1271 1272 1273 1274 1275 1276 1277", "Welcome, builder! I've got homes and furnishings to make your dreams feel real.");

	// Fort Ethren
	Merchant::Add("merchant2", "Fort Ethren", "-2438.75 -2291.25 56.7893", "0 -0 -2.87792", "Cole", "MaleHuman", "CLASS Ranger LVL 2 LCK 0 Dagger 1", "303 304 305 204 205 206 207 208 209", "");
	Merchant::Add("merchant4", "Fort Ethren", "-2438.75 -2303.5 56.7893", "0 -0 0.362497", "Clifton", "MaleHuman", "CLASS Ranger LVL 2 LCK 0 Dagger 1", "21 22 23 55 56 57 104 105 106 129 130 131 153 154 155 178 179 180", "");

	// Jaten Outpost
	Merchant::Add("merchant3", "Jaten Outpost", "-406.125 1798.25 65.2391", "0 -0 3.10138", "Gryffen", "MaleHuman", "CLASS Ranger LVL 2 LCK 0 Dagger 1", "2 3 4 19 20 53 54 102 103 127 128 152 153 176 177 178 203 204 205 206", "");

	// Fisherman's Horizon
	Merchant::Add("merchant5", "Fisherman's Horizon", "-1259.5 342.766 85.4714", "0 -0 1.46425", "Jolline", "FemaleHuman", "", "1 2 3 18 52 102 126 151 176 201 202 203 508", "");

	// Mythril Mine
	Merchant::Add("merchant6", "Mythril Mine", "-1785 -883.625 186.257", "0 -0 0.0612183", "Gary", "MaleHuman", "CLASS Chemist LVL 2 LCK 0 Dagger 1", "1 2 17 18 51 52 100 101 125 126 150 151 174 176 200 201 508 606 611 616", "");

	// Upper Dunega
	Merchant::Add("merchant7", "Upper Dunega", "195.449 -862.338 5054.75", "0 -0 0.0129987", "Snaggit", "MaleHuman", "CLASS Chemist LVL 2 LCK 0 Dagger 1", "1 2 3 4 508 509 606 607 608 611 612 613 616", "Aghk! You humeen scared Snaggit. Now you must buy something!", "2");
	Merchant::Add("merchant8", "Upper Dunega", "187.337 -862.549 5054.75", "0 -0 0.0129987", "Borgul", "MaleHuman", "CLASS Chemist LVL 2 LCK 0 Dagger 1", "203 204 205 206 207 253 254 255", "What iz humeen doing here? Oh well, need good armor?", "2");
	Merchant::Add("merchant9", "Upper Dunega", "180.75 -862.479 5054.75", "0 -0 0.0129987", "Zrogg", "MaleHuman", "CLASS Chemist LVL 2 LCK 0 Dagger 1", "17 18 19 20 21 51 52 53 54 55 100 101 102 103 104 125 126 127 128 129 150 151 152 153 154 174 176 177 178 179", "Greetingz humeen. Need new pointy objects? We have much to sell!", "2");

	// Upper Gooba
	Merchant::Add("merchant10", "Upper Gooba", "329.709 -472.593 -2963.5", "0 -0 1.6655", "Zaggit", "MaleHuman", "CLASS Chemist LVL 2 LCK 0 Dagger 1", "1 2 3 4 509 510 606 607 608 609 611 612 613 614 616", "Dis is general store. You want armor talk to Boggle.", "2");
	Merchant::Add("merchant11", "Upper Gooba", "328.07 -461.661 -2963.5", "0 -0 1.6655", "Bingles", "MaleHuman", "CLASS Chemist LVL 2 LCK 0 Dagger 1", "205 206 207 208 209 210 253 254 255 256 257 258", "Welkom! Need armor? If you need pointy things, see Taggert and Boggert in Lower Gooba.", "2");

	// Lower Gooba
	Merchant::Add("merchant12", "Lower Gooba", "-406.647 -387.95 1569.25", "0 -0 0.178919", "Krush", "MaleHuman", "CLASS Chemist LVL 2 LCK 0 Dagger 1", "20 21 22 23 24 54 55 56 57 58 103 104 105 106 107 128 129 130 131 132 153 154 155 156 157 174 179 180 181 182", "Need a weapon? I haz the best in all of Gooba!", "2");
	Merchant::Add("merchant18", "Lower Gooba", "-442.26 -342.75 1569.75", "0 -0 -2.99689", "Daggert", "MaleHuman", "CLASS Chemist LVL 2 LCK 0 Dagger 1", "616 606 607 608 609 611 612 613 614 550 551 552", "Ahh, I see you are interested in Potion making?", "2");

	// 7th Heaven
	Merchant::Add("merchant19", "7th Heaven", "1411.28 -445.694 -807.692", "0 -0 1.63293", "Marlene", "FemaleHuman", "CLASS Chemist LVL 2 LCK 0", "856 857 702", "Hi! I'm Marlene! What can I get'cha?");
	Merchant::Add("merchant20", "7th Heaven", "1427.06 -458.444 -808.023", "0 -0 0.0452993", "Biggs", "MaleHuman", "CLASS Chemist LVL 2 LCK 0", "208 209 210 211 212 256 257 258 259 260", "Need some protection? Biggs has you covered!");
	Merchant::Add("merchant21", "7th Heaven", "1431.5 -457.792 -808.023", "0 -0 0.0452993", "Wedge", "MaleHuman", "CLASS Chemist LVL 2 LCK 0", "24 25 26 58 59 60 107 108 109 132 133 134 157 158 159", "Need a fancy new weapon? Wedge has you covered!");
	Merchant::Add("merchant22", "7th Heaven", "1425.03 -441.063 -807.679", "0 -0 -3.09994", "Jesse", "FemaleHuman", "CLASS Chemist LVL 2 LCK 0", "4 8 9 10 11 301 302 304 305 503 504 507 510 511 512 608 609 610 616 854 855", "Welcome to Jesse's Fantastic General Store! What will ya have?");
	Merchant::Add("merchant29", "7th Heaven", "1432.56 -439.704 -808.028", "0 -0 2.5218", "Dunedain", "MaleHuman", "CLASS Hunter LVL 80 LCK 0", "174 176 177 178 179 298 1050 1051 1052 1053 1 2 3 4 5 6 7 8 9 10 11 14 15 16 1017", "Keep your distance and keep your aim. Dunedain has the finest ranged gear in Heaven.");

	// Midgar (Wall Market)
	Merchant::Add("merchant23", "Midgar", "-2369.37 -2186.37 7549.11", "0 -0 2.68787", "Sarah", "FemaleHuman", "CLASS Chemist LVL 2 LCK 0", "210 211 212 213 214 215", "Welcome to Wall Market's finest armor shop! Take a look at what I have.");
	Merchant::Add("merchant24", "Midgar", "-2366.86 -2192.35 7549.11", "0 -0 1.53007", "Johnny", "MaleHuman", "CLASS Chemist LVL 2 LCK 0", "27 28 29 61 62 63 110 111 112 135 136 137", "Best protect yourself while in Wall Market. And I got just the thing you need.");
	Merchant::Add("merchant25", "Midgar", "-2393.81 -2253.91 7549.11", "0 -0 0.481352", "Vivaldi", "MaleMage", "CLASS Chemist LVL 2 LCK 0", "161 162 163 261 262 263 264", "The spirits... YES, the SPIRITS. They foretold of your coming... to buy my magical wares!", "6");
	Merchant::Add("merchant26", "Midgar", "-2390.26 -2240.51 7549.11", "0 -0 2.04545", "Kalzaar", "MaleHuman", "CLASS Archer LVL 2 LCK 0", "185 186 187 188 10 11 12 13 14 15 16 1017 1018 1019", "Need something, Friend? I have the finest ranged accessories you'll find here in Wall Market.");
	Merchant::Add("merchant27", "Midgar", "-2473.05 -2300.41 7554.59", "0 -0 -0.393267", "Jenny", "FemaleHuman", "CLASS Archer LVL 2 LCK 0", "503 504 505 514 515 516 517 856 857 703", "Hey there Stranger. What can I get'cha?");
}

function Merchant::Add(%name, %zoneDesc, %pos, %rot, %displayName, %race, %items, %beltshop, %greeting, %team) {
	%index = $Merchant::count;
	$Merchant::count++;

	$Merchant::name[%index] = %name;
	$Merchant::pos[%index] = %pos;
	$Merchant::rot[%index] = %rot;
	$Merchant::zoneDesc[%index] = %zoneDesc;

	$BotInfo[%name, NAME] = %displayName;
	$BotInfo[%name, RACE] = %race;
	$BotInfo[%name, TEAM] = %team;

	if(%items != "")
		$BotInfo[%name, ITEMS] = %items;
	if(%beltshop != "")
		$BotInfo[%name, BELTSHOP] = %beltshop;
	if(%greeting != "")
		$BotInfo[%name, GREETING] = %greeting;

	$Merchant::zone[%index] = Merchant::ResolveZone(%zoneDesc, %pos);
}

function Merchant::ResolveZone(%zoneDesc, %pos) {
	if(%zoneDesc != "") {
		%zoneId = Zone::descToId(%zoneDesc);
		if(%zoneId != False && %zoneId != "")
			return %zoneId;
	}
	return Merchant::FindZoneByPos(%pos);
}

function Merchant::FindZoneByPos(%pos) {
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

function Merchant::OnZoneEnter(%clientId, %zoneId) {
	Merchant::SpawnZone(%zoneId);
}

function Merchant::OnZoneExit(%clientId, %zoneId) {
	if(%zoneId == "" || %zoneId == False)
		return;

	%remaining = Zone::getNumPlayers(%zoneId, False) - 1;
	if(%remaining <= 0)
		Merchant::DespawnZone(%zoneId);
}

function Merchant::SpawnZone(%zoneId) {
	for(%i = 0; %i < $Merchant::count; %i++) {
		if($Merchant::zone[%i] == %zoneId)
			Merchant::Spawn(%i);
	}
}

function Merchant::DespawnZone(%zoneId) {
	for(%i = 0; %i < $Merchant::count; %i++) {
		if($Merchant::zone[%i] == %zoneId)
			Merchant::Despawn(%i);
	}
}

function Merchant::Spawn(%index) {
	if($Merchant::active[%index] != "")
		return $Merchant::active[%index];

	%name = $Merchant::name[%index];
	%race = $BotInfo[%name, RACE];

	%townbot = newObject("", "StaticShape", %race @ "TownBot", true);
	addToSet("MissionCleanup", %townbot);
	GameBase::setMapName(%townbot, $BotInfo[%name, NAME]);
	GameBase::setPosition(%townbot, $Merchant::pos[%index]);
	GameBase::setRotation(%townbot, $Merchant::rot[%index]);
	GameBase::setTeam(%townbot, $BotInfo[%name, TEAM]);
	GameBase::playSequence(%townbot, 0, "root");
	Client::setSkin(%townbot, "RMSkins1");
	%townbot.name = %name;

	$TownBotList = $TownBotList @ %townbot @ " ";
	$Merchant::active[%index] = %townbot;
	$Merchant::idToIndex[%townbot] = %index;

	return %townbot;
}

function Merchant::Despawn(%index) {
	%id = $Merchant::active[%index];
	if(%id == "")
		return;

	$TownBotList = String::replace($TownBotList, %id @ " ", "");
	$Merchant::idToIndex[%id] = "";
	$Merchant::active[%index] = "";
	deleteObject(%id);
}
