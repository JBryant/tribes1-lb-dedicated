// Zone-based dynamic interior/static shapes.

function ZoneShapes::Init() {
	$ZoneShapes::UseZoneSpawns = True;
	$ZoneShapes::count = 0;

	// Seventh Heaven (7th Heaven)
	ZoneShapes::AddInterior("7th Heaven", "cdoore1", "CDoorE.dis", 0, "1436.75 -464.981 -808.135", "0 0 0", "0");
	ZoneShapes::AddInterior("7th Heaven", "pic51", "pic5.dis", 1, "1416.78 -447.194 -804.25", "0 -0 -1.57989", "0");
	ZoneShapes::AddInterior("7th Heaven", "bssign1", "bssign.dis", 1, "1433 -463.329 -808.031", "0 -0 0.0199925", "0");
	ZoneShapes::AddInterior("7th Heaven", "anvil1a", "anvil.dis", 0, "1432 -457.093 -808.031", "0 -0 3.13983", "0");
	ZoneShapes::AddInterior("7th Heaven", "anvil1b", "anvil.dis", 0, "1426.54 -456.088 -808.031", "0 -0 2.60927e-05", "0");
	ZoneShapes::AddInterior("7th Heaven", "lucanshouse1", "lucanshouse.dis", 1, "1419 -437.773 -768.104", "0 0 0", "0");
	ZoneShapes::AddInterior("7th Heaven", "bench21a", "bench2.dis", 0, "1410.75 -438.863 -761.854", "0 -0 1.55988", "0");
	ZoneShapes::AddInterior("7th Heaven", "bench21b", "bench2.dis", 0, "1413.75 -435.626 -761.854", "0 0 0", "0");
	ZoneShapes::AddInterior("7th Heaven", "bed31", "bed3.dis", 0, "1428.26 -436.966 -761.854", "0 -0 -1.57989", "0");
	ZoneShapes::AddInterior("7th Heaven", "chair11a", "chair1.dis", 0, "1429.04 -442.376 -761.854", "0 -0 0.879958", "0");
	ZoneShapes::AddInterior("7th Heaven", "endtable1a", "endtable.dis", 0, "1430.02 -433.807 -761.705", "0 0 0", "0");
	ZoneShapes::AddInterior("7th Heaven", "candelabra1a", "candelabra.dis", 0, "1411.13 -435.958 -761.854", "0 0 0", "0");
	ZoneShapes::AddInterior("7th Heaven", "woodcrate1a", "woodcrate.dis", 0, "1408.31 -442.394 -761.854", "0 -0 1.86397e-06", "0");
	ZoneShapes::AddInterior("7th Heaven", "pic31", "pic3.dis", 0, "1414.25 -443.82 -758.854", "0 -0 -3.13988", "0");
	ZoneShapes::AddInterior("7th Heaven", "fireplace1", "fireplace.dis", 1, "1427.25 -432.442 -768.104", "0 0 0", "0");
	ZoneShapes::AddInterior("7th Heaven", "chair11b", "chair1.dis", 0, "1428.75 -436.882 -768.104", "0 -0 0.299989", "0");
	ZoneShapes::AddInterior("7th Heaven", "chair1a1", "chair1a.dis", 0, "1425.75 -436.67 -768.104", "0 -0 -0.559985", "0");
	ZoneShapes::AddInterior("7th Heaven", "woodcrate1b", "woodcrate.dis", 0, "1411.52 -436.18 -768.104", "0 -0 0.399987", "0");
	ZoneShapes::AddInterior("7th Heaven", "bigtable11", "bigtable1.dis", 1, "1426.25 -427.807 -768.104", "0 0 0", "0");
	ZoneShapes::AddInterior("7th Heaven", "chair11c", "chair1.dis", 0, "1427.58 -430.475 -768.104", "0 0 0", "0");
	ZoneShapes::AddInterior("7th Heaven", "chair11d", "chair1.dis", 0, "1424.29 -430.454 -768.104", "0 0 0", "0");
	ZoneShapes::AddInterior("7th Heaven", "chair11e", "chair1.dis", 0, "1427.5 -425.04 -768.104", "0 -0 3.11986", "0");
	ZoneShapes::AddInterior("7th Heaven", "chair11f", "chair1.dis", 0, "1424.35 -425.092 -768.104", "0 -0 -3.11986", "0");
	ZoneShapes::AddInterior("7th Heaven", "woodcrate1c", "woodcrate.dis", 0, "1429.85 -420.678 -768.104", "0 0 0", "0");
	ZoneShapes::AddInterior("7th Heaven", "bench31", "bench3.dis", 0, "1413.75 -428.009 -768.104", "0 -0 -3.13986", "0");
	ZoneShapes::AddInterior("7th Heaven", "candelabra1b", "candelabra.dis", 0, "1410.85 -427.613 -768.104", "0 0 0", "0");
	ZoneShapes::AddInterior("7th Heaven", "bed21", "bed2.dis", 0, "1428.25 -425.376 -761.854", "0 -0 -1.59985", "0");
	ZoneShapes::AddInterior("7th Heaven", "bar1a", "bar.dis", 1, "1416.75 -442.736 -808.5", "0 -0 1.57987", "0");
	ZoneShapes::AddInterior("7th Heaven", "barstool1a", "barstool.dis", 0, "1408.56 -445.014 -808.036", "0 0 0", "0");
	ZoneShapes::AddInterior("7th Heaven", "barstool1b", "barstool.dis", 0, "1408.51 -447.815 -808.036", "0 0 0", "0");
	ZoneShapes::AddInterior("7th Heaven", "barstool1c", "barstool.dis", 0, "1408.5 -450.882 -808.036", "0 0 0", "0");
	ZoneShapes::AddInterior("7th Heaven", "easel1", "easel.dis", 0, "1412.03 -426.635 -761.854", "0 -0 2.35988", "0");
	ZoneShapes::AddStatic("7th Heaven", "bigfountain", "fountain", "1432 -491.25 -804.593", "0 0 0", True, False, 0);
	ZoneShapes::AddStatic("7th Heaven", "bigfountainw", "fountainwater", "1432 -491.25 -804.593", "0 0 0", True, False, 0);
	ZoneShapes::AddInterior("7th Heaven", "bookshelfM1", "bookshelfM.dis", 1, "-3557 -262.925 330.208", "0 -0 -0.436322", "0");
	ZoneShapes::AddInterior("7th Heaven", "bench21c", "bench2.dis", 0, "1419.31 -509.459 -804.781", "0 -0 3.13986", "0");
	ZoneShapes::AddInterior("7th Heaven", "bench21d", "bench2.dis", 0, "1424.88 -509.558 -804.781", "0 -0 -3.13988", "0");
	ZoneShapes::AddStatic("7th Heaven", "PlantTwo1", "PlantTwo", "1416.13 -509.048 -804.781", "0 -0 2.09988", True, False, "");
	ZoneShapes::AddInterior("7th Heaven", "bench21e", "bench2.dis", 0, "1439.65 -509.703 -804.781", "0 -0 3.13988", "0");
	ZoneShapes::AddInterior("7th Heaven", "bench21f", "bench2.dis", 0, "1444.63 -509.8 -804.781", "0 -0 3.13988", "0");
	ZoneShapes::AddInterior("7th Heaven", "chair11g", "chair1.dis", 0, "1422.03 -487.545 -808.002", "0 -0 0.959978", "0");
	ZoneShapes::AddInterior("7th Heaven", "endtable1b", "endtable.dis", 0, "1419.76 -487.514 -808.002", "0 0 0", "0");
	ZoneShapes::AddInterior("7th Heaven", "chair11h", "chair1.dis", 0, "1417.5 -487.385 -808.002", "0 -0 -0.839969", "0");
	ZoneShapes::AddInterior("7th Heaven", "bench11a", "bench1.dis", 0, "1416.08 -501.916 -804.781", "0 -0 -1.55989", "0");
	ZoneShapes::AddInterior("7th Heaven", "bench11b", "bench1.dis", 0, "1416 -495.274 -804.781", "0 -0 1.57989", "0");
	ZoneShapes::AddInterior("7th Heaven", "bench11c", "bench1.dis", 0, "1448.77 -498.026 -804.781", "0 -0 -1.5999", "0");
	ZoneShapes::AddInterior("7th Heaven", "bench11d", "bench1.dis", 0, "1448.75 -503.263 -804.781", "0 -0 -1.5999", "0");
	ZoneShapes::AddInterior("7th Heaven", "table1", "table.dis", 0, "1400.85 -448.959 -808.031", "0 0 0", "0");
	ZoneShapes::AddInterior("7th Heaven", "barstool1d", "barstool.dis", 0, "1401 -445.984 -808.231", "0 0 0", "0");
	ZoneShapes::AddInterior("7th Heaven", "barstool1e", "barstool.dis", 0, "1401.02 -451.875 -808.231", "0 0 0", "0");
	ZoneShapes::AddInterior("7th Heaven", "bar1b", "bar.dis", 1, "1417.25 -435.6 -808.432", "0 -0 3.13988", "0");
	ZoneShapes::AddInterior("7th Heaven", "woodfire1", "woodfire.dis", 0, "1443.79 -490.628 -808.002", "0 0 0", "1 1.250000 1");
	ZoneShapes::AddInterior("7th Heaven", "woodcrate1d", "woodcrate.dis", 0, "1432.75 -436.901 -808.031", "0 -0 0.0599987", "0");
	ZoneShapes::AddInterior("7th Heaven", "woodcrateb1", "woodcrateb.dis", 0, "1435.5 -437.145 -808.031", "0 -0 0.0199989", "0");
	ZoneShapes::AddInterior("7th Heaven", "woodcrate1e", "woodcrate.dis", 0, "1435.53 -439.912 -808.031", "0 -0 -0.279989", "0");
	ZoneShapes::AddInterior("7th Heaven", "pic11", "pic1.dis", 0, "1399.83 -448.891 -804.661", "0 -0 1.57989", "0");
}

function ZoneShapes::AddInterior(%zoneDesc, %name, %file, %isContainer, %pos, %rot, %lightParams) {
	%index = $ZoneShapes::count;
	$ZoneShapes::count++;

	$ZoneShapes::type[%index] = "Interior";
	$ZoneShapes::name[%index] = %name;
	$ZoneShapes::file[%index] = %file;
	$ZoneShapes::isContainer[%index] = %isContainer;
	$ZoneShapes::pos[%index] = %pos;
	$ZoneShapes::rot[%index] = %rot;
	$ZoneShapes::lightParams[%index] = %lightParams;
	$ZoneShapes::zone[%index] = ZoneShapes::ResolveZone(%zoneDesc, %pos);
}

function ZoneShapes::AddStatic(%zoneDesc, %name, %dataBlock, %pos, %rot, %destroyable, %deleteOnDestroy, %locked) {
	%index = $ZoneShapes::count;
	$ZoneShapes::count++;

	$ZoneShapes::type[%index] = "Static";
	$ZoneShapes::name[%index] = %name;
	$ZoneShapes::dataBlock[%index] = %dataBlock;
	$ZoneShapes::pos[%index] = %pos;
	$ZoneShapes::rot[%index] = %rot;
	$ZoneShapes::destroyable[%index] = %destroyable;
	$ZoneShapes::deleteOnDestroy[%index] = %deleteOnDestroy;
	$ZoneShapes::locked[%index] = %locked;
	$ZoneShapes::zone[%index] = ZoneShapes::ResolveZone(%zoneDesc, %pos);
}

function ZoneShapes::ResolveZone(%zoneDesc, %pos) {
	if(%zoneDesc != "") {
		%zoneId = Zone::descToId(%zoneDesc);
		if(%zoneId != False && %zoneId != "")
			return %zoneId;
	}

	return ZoneShapes::FindZoneByPos(%pos);
}

function ZoneShapes::FindZoneByPos(%pos) {
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

function ZoneShapes::OnZoneEnter(%clientId, %zoneId) {
	ZoneShapes::SpawnZone(%zoneId);
}

function ZoneShapes::OnZoneExit(%clientId, %zoneId) {
	if(%zoneId == "" || %zoneId == False)
		return;

	%remaining = Zone::getNumPlayers(%zoneId, False) - 1;
	if(%remaining <= 0)
		ZoneShapes::DespawnZone(%zoneId);
}

function ZoneShapes::SpawnZone(%zoneId) {
	for(%i = 0; %i < $ZoneShapes::count; %i++) {
		if($ZoneShapes::zone[%i] == %zoneId)
			ZoneShapes::Spawn(%i);
	}
}

function ZoneShapes::DespawnZone(%zoneId) {
	for(%i = 0; %i < $ZoneShapes::count; %i++) {
		if($ZoneShapes::zone[%i] == %zoneId)
			ZoneShapes::Despawn(%i);
	}
}

function ZoneShapes::Spawn(%index) {
	if($ZoneShapes::active[%index] != "")
		return $ZoneShapes::active[%index];

	if($ZoneShapes::type[%index] == "Interior") {
		%obj = newObject($ZoneShapes::name[%index], InteriorShape, $ZoneShapes::file[%index], true);
		%obj.isContainer = $ZoneShapes::isContainer[%index];
		if($ZoneShapes::lightParams[%index] != "")
			%obj.lightParams = $ZoneShapes::lightParams[%index];
	}
	else {
		%obj = newObject($ZoneShapes::name[%index], "StaticShape", $ZoneShapes::dataBlock[%index], true);
		%obj.destroyable = $ZoneShapes::destroyable[%index];
		%obj.deleteOnDestroy = $ZoneShapes::deleteOnDestroy[%index];
		if($ZoneShapes::locked[%index] != "")
			%obj.locked = $ZoneShapes::locked[%index];
	}

	addToSet("MissionCleanup", %obj);
	GameBase::setPosition(%obj, $ZoneShapes::pos[%index]);
	GameBase::setRotation(%obj, $ZoneShapes::rot[%index]);

	$ZoneShapes::active[%index] = %obj;
	$ZoneShapes::idToIndex[%obj] = %index;

	return %obj;
}

function ZoneShapes::Despawn(%index) {
	%obj = $ZoneShapes::active[%index];
	if(%obj == "")
		return;

	$ZoneShapes::idToIndex[%obj] = "";
	$ZoneShapes::active[%index] = "";
	deleteObject(%obj);
}
