// Home system overview
// - Home shapes and home item shapes are listed in $homeDisList and $homeItemDisList.
// - Placement uses StartPlaceMode/PlaceModeLoop/EndPlaceMode:
//   * StartPlaceMode spawns (or reuses) the InteriorShape and begins a LOS-follow loop.
//   * PlaceModeLoop moves the object to the LOS position; if placing a home, it also
//     moves all placed home items by their stored offsets.
//   * EndPlaceMode finalizes placement and saves HomeShape/HomePos/HomeRot or
//     item offsets/rotations into runtime data (storeData) and object fields.
// - Objects are tracked with tags like "<clientId>_home" and "<clientId>_homeitem_<slot>"
//   via $tagToObjectId and $tagToObjectShape.
// - Persistence lives in charfunk.cs:
//   * Save: HomeShape/HomePos/HomeRot and item shape/offset/rot to $funk::var
//   * Load: Recreates the home/group and restores each item relative to HomePos.
// - Removal uses RemoveHome/RemoveHomeItem/ClearHomeVariables to clear tags and delete
//   the MissionCleanup group "Home<clientId>" and its objects.
// - Current system is prototype-level: no ownership costs, no purchase gating, and
//   no buff/tax logic yet (see notes in TODOs and expansion plan).
//
// Home DIS options
// ----- small homes ------
// house1 - The standard brown house with an upstairs attic
// store1 - 2 door 1 floor shop house
// nbank - blue roof small home with shimey tower
// cozyhouse - all white small 1 room house
// ----- medium homes ------
// tavern - Large brown house with fireplace and upstairs
// lhouse - large 2 story brown house, L shape with upper porch
// cheehouselights - large 1 story 2 bedroom home
// shildrikhouse - medium 2 story blue roof with upper out patio
// rmr7thheaven - large bar with upper sleeping area
// cfarm1 - medium farm house with plot for animal pen and crops
// chaunted - small 2 floor mansion style home
// ----- large homes ------
// keep - large castle (Ethren)
// castle - large white low quality castle (more building opportunities)
// magetower - large mage tower
// shildriklit - large 2 story base
// town51 - large 2/3 story blue roof with amenities
// town52 - large 1 story multi building complex
// cthh - large temple
// limbo1 - cool looking heaven area
// ----- small towns ------
// fort - Jaten Fort, Large wooden complex
// DCTY - Raised town (Delkin Port)
// rmrrinvale - rinvale
// edmire2lit - small wall surround town (Edmire)
// ----- large towns ------
// CTown - nibelheim
// ncity - Keldrin Town

$homeDisList = "house1 store1 nbank cozyhouse tavern lhouse cheehouselights shildrikhouse rmr7thheaven cfarm1 chaunted keep castle magetower shildriklit town51 town52 cthh limbo1 fort dcty rmrrinvale edmire2lit ctown ncity";

// House Items DIS options
// cabinet1 - Tall wooden cabinet
// cabinet2 - Short wooden cabinet
// woodchair - short brown wooden chair
// bar - wooden bar
// barstool - wooden bar stool
// table - small low quality wooden table
// roundtable - small round wooden table
// stove - metal cooking stove
// easel - painting easel
// bed - single brown frame white sheets bed
// JFNT - Small water fountain
// woodfire - small wood burning fireplace
// anvil - blacksmith's anvil
// bed1 - double blue sheet
// bed1b -  double brown sheet
// bed1c - double lioght brown sheet
// bed2 - fancy queen with 2 pillows and bed posts
// bed3 - ultrea fancy queen with canopy and fur blanket
// bench1 - stone bench
// bench2 - ornate wooden bench (light)
// bench3 - ornate wooden bench (dark)
// bigtable1 - large dark fancy table
// bigtable2 - large light fancy table
// candleabra - wall mounted candles
// chair1 - nice light wooden chair with cushion
// chair1a - nice light wooden chair with all white cushion
// endtable - small end table wooden
// fireplace - nice stone fireplace
// fireplaceb - fancy wood and dark stone fireplace
// pic1-5 - various wall pictures
// throne2 - very nice wood thrown for house
// 

$homeItemDisList = "cabinet1 cabinet2 woodchair bar barstool table roundtable stove easel bed jfnt woodfire anvil bed1 bed1b bed1c bed2 bed3 bench1 bench2 bench3 bigtable1 bigtable2 candleabra chair1 chair1a endtable fireplace fireplaceb pic1 pic2 pic3 pic4 pic5 throne2";

function StartPlaceMode(%clientId, %name, %objectShape, %slot, %objectId, %itemName) {
    storeData(%clientId, "PlaceMode", 1);
    $userMovingHouseItem[%clientId] = %name;
    %tag = %clientId @ "_" @ %name;

    if (%objectId != "" && %objectId != 0) {
		if (%itemName != "")
			%objectId.name = %itemName;
        if (%name == "")
            %name = %objectId.name;
        if (%name == "" && %slot != "")
            %name = "homeitem_" @ %slot;
        $userMovingHouseItem[%clientId] = %name;
        %tag = %clientId @ "_" @ %name;
        $tagToObjectId[%tag] = %objectId;
        if (%objectShape == "")
            %objectShape = %objectId.shape;
        if (%objectShape == "")
            %objectShape = $tagToObjectShape[%tag];
        if (%objectShape != "")
            $tagToObjectShape[%tag] = %objectShape;
    }

    if (%objectShape == "" && $tagToObjectId[%tag] == "") {
        Client::sendMessage(%clientId, 1, "Unable to place item: missing shape data.");
        storeData(%clientId, "PlaceMode", 0);
        $userMovingHouseItem[%clientId] = "";
        return;
    }

	if ($tagToObjectId[%tag] == "" || $tagToObjectId[%tag] == 0 || $tagToObjectId[%tag] == "0") {
        %object = newObject(%name, InteriorShape, %objectShape, true);
        %object.owner = %clientId;
		if (%itemName != "")
			%object.name = %itemName;
		else
			%object.name = %name;
        %object.shape = %objectShape;
        if (%slot != "") %object.slot = %slot;
        $tagToObjectId[%tag] = %object;
        $tagToObjectShape[%tag] = %objectShape;
    }

    Client::sendMessage(%clientId, 2, "You are placing " @ %name @ ". Type #place when you are done.");

    // Initialize placement rotation from current object rotation (Z only)
    %currentRot = GameBase::getRotation($tagToObjectId[%tag]);
    $placeRot[%clientId] = getWord(%currentRot, 2);
    $placeLockPos[%clientId] = "";

    PlaceModeLoop(%clientId, %name);
}

function PlaceModeLoop(%clientId, %name) {
    %object = $tagToObjectId[%clientId @ "_" @ %name];
    %player = Client::getOwnedObject(%clientId);

    // lbecho("PlaceModeLoop for " @ %name @ ": clientId=" @ %clientId @ " object=" @ %object @ " player=" @ %player);
    if (fetchData(%clientId, "PlaceMode") == 1 && %player != -1 && %object != -1) {
        %player = Client::getOwnedObject(%clientId);

        if($placeLockPos[%clientId] != "") {
            %pos = $placeLockPos[%clientId];
            %obj = "";
        } else if(GameBase::getLOSinfo(%player, 1000)) {
            %pos = $los::position;
            %obj = $los::object;
        } else {
            %pos = "";
            %obj = "";
        }

        if (%pos != "" && (%obj == "" || (%obj != %object && getObjectType(%obj) != "Player"))) {
                // lbecho("set position of " @ %name @ " to " @ %pos);
                GameBase::setPosition(%object, %pos);
                if ($placeRot[%clientId] != "")
                    GameBase::setRotation(%object, "0 0 " @ $placeRot[%clientId]);
                if (%name == "home") {
                    // lbecho("Also moving all house items with it");
                    // also move all the home items with it
                    %homePos = %pos;
                    for (%i = 1; %i <= $maxHouseItems; %i++) {
                        %houseItem = $tagToObjectId[%clientId @ "_homeitem_" @ %i];

                        if (%houseItem != "") {
                            %offset = %houseItem.posOffset;
                            %newPos = (getWord(%homePos, 0) + getWord(%offset, 0)) @ " " @ (getWord(%homePos, 1) + getWord(%offset, 1)) @ " " @ (getWord(%homePos, 2) + getWord(%offset, 2));
                            GameBase::setPosition(%houseItem, %newPos);
                        }
                    }
                }
        }

        schedule("PlaceModeLoop(" @ %clientId @ ", \"" @ %name @ "\");", 0.2);
    }
}

function EndPlaceMode(%clientId) {
    %name = $userMovingHouseItem[%clientId];
    %tag = %clientId @ "_" @ %name;
    %object = $tagToObjectId[%tag];
    %shape = $tagToObjectShape[%tag];
    %objectPos = GameBase::getPosition(%object);
    %objectRot = GameBase::getRotation(%object);

    Client::sendMessage(%clientId, 2, %name @ " placed at position " @ %objectPos @ ".");

    %homeGroup = nameToId("MissionCleanup\\Home" @ %clientId);
    if(%homeGroup == -1) {
        lbecho("No home group found, creating one.");
        %group = newObject("Home" @ %clientId, SimGroup);
	    addToSet("MissionCleanup", %group);
    }

    // add to DIS list for the character?
    if (%name == "home") {
        storeData(%clientId, "HomeShape", %shape);
        storeData(%clientId, "HomePos", %objectPos);
        storeData(%clientId, "HomeRot", %objectRot);
        storeData(%clientId, "HasHome", 1);
    } else {
        %homePos = fetchData(%clientId, "HomePos");
        %homePosX = getWord(%homePos, 0);
        %homePosY = getWord(%homePos, 1);
        %homePosZ = getWord(%homePos, 2);
        %objectOffsetX = getWord(%objectPos, 0) - %homePosX;
        %objectOffsetY = getWord(%objectPos, 1) - %homePosY;
        %objectOffsetZ = getWord(%objectPos, 2) - %homePosZ;
        %object.shape = %shape;
        %object.posOffset = %objectOffsetX @ " " @ %objectOffsetY @ " " @ %objectOffsetZ;
        %object.rot = %objectRot;
        //$ClientHouseItemData[%clientId, %object.itemNumber] = %object;
        $tagToObjectId[%tag] = %object;
    }

    addToSet("MissionCleanup\\Home" @ %clientId, %object);
    $userMovingHouseItem[%clientId] = "";
    $placeRot[%clientId] = "";
    $placeLockPos[%clientId] = "";
    storeData(%clientId, "PlaceMode", 0);
}

function PlaceLockPos(%clientId) {
    if (fetchData(%clientId, "PlaceMode") != 1)
        return;

    %name = $userMovingHouseItem[%clientId];
    if (%name == "")
        return;

    %object = $tagToObjectId[%clientId @ "_" @ %name];
    if (%object == "" || %object == 0)
        return;

    $placeLockPos[%clientId] = GameBase::getPosition(%object);
}

function PlaceUnlockPos(%clientId) {
    $placeLockPos[%clientId] = "";
}

function StartRotateMode(%clientId, %name, %objectId) {
    if (fetchData(%clientId, "RotateMode") == 1)
        return;

    if (%objectId != "" && %objectId != 0) {
        if (%name == "")
            %name = %objectId.name;
        if (%name == "" && %objectId.slot != "")
            %name = "homeitem_" @ %objectId.slot;
        %tag = %clientId @ "_" @ %name;
        $tagToObjectId[%tag] = %objectId;
        %object = %objectId;
    } else {
        %tag = %clientId @ "_" @ %name;
        %object = $tagToObjectId[%tag];
    }
    if (%object == "" || %object == 0 || %name == "")
        return;

    %player = Client::getOwnedObject(%clientId);
    if (%player == -1)
        return;

    storeData(%clientId, "RotateMode", 1);
    $userRotatingHouseItem[%clientId] = %name;
    $rotateLastPos[%clientId] = GameBase::getPosition(%player);
    $rotateRot[%clientId] = getWord(GameBase::getRotation(%object), 2);

    Client::sendMessage(%clientId, 2, "Rotate mode started. Move to rotate, type #rotate again to stop.");
    RotateModeLoop(%clientId, %name);
}

function RotateModeLoop(%clientId, %name) {
    if (fetchData(%clientId, "RotateMode") != 1)
        return;

    %object = $tagToObjectId[%clientId @ "_" @ %name];
    %player = Client::getOwnedObject(%clientId);
    if (%object == "" || %object == 0 || %player == -1)
        return;

    %currentPos = GameBase::getPosition(%player);
    %lastPos = $rotateLastPos[%clientId];
    %dx = getWord(%currentPos, 0) - getWord(%lastPos, 0);
    %dy = getWord(%currentPos, 1) - getWord(%lastPos, 1);
    %delta = (%dx + %dy) * 0.5;

    if (%delta > 5) %delta = 5;
    if (%delta < -5) %delta = -5;

    if (%delta != 0) {
        $rotateRot[%clientId] = $rotateRot[%clientId] + %delta;
        GameBase::setRotation(%object, "0 0 " @ $rotateRot[%clientId]);
    }

    $rotateLastPos[%clientId] = %currentPos;
    schedule("RotateModeLoop(" @ %clientId @ ", \"" @ %name @ "\");", 0.2);
}

function EndRotateMode(%clientId) {
    if (fetchData(%clientId, "RotateMode") != 1)
        return;

    %name = $userRotatingHouseItem[%clientId];
    if (%name != "") {
        %object = $tagToObjectId[%clientId @ "_" @ %name];
        if (%object != "" && %object != 0) {
            %object.rot = GameBase::getRotation(%object);
        }
    }

    storeData(%clientId, "RotateMode", 0);
    $userRotatingHouseItem[%clientId] = "";
    $rotateLastPos[%clientId] = "";
    $rotateRot[%clientId] = "";
    Client::sendMessage(%clientId, 2, "Rotate mode ended.");
}

function HomeAddX(%clientId, %offset) {
    %home = $tagToObjectId[%clientId @ "_home"];
    if (%home == "" || %home == 0) {
        Client::sendMessage(%clientId, 1, "You don't have a home placed.");
        return;
    }
    %homePos = fetchData(%clientId, "HomePos");
    if (%homePos == "") {
        Client::sendMessage(%clientId, 1, "Home position data is missing.");
        return;
    }
    %homePosX = getWord(%homePos, 0);
    %newPosX = %homePosX + %offset;
    GameBase::setPosition(%home, %newPosX @ " " @ getWord(%homePos, 1) @ " " @ getWord(%homePos, 2));
    storeData(%clientId, "HomePos", %newPosX @ " " @ getWord(%homePos, 1) @ " " @ getWord(%homePos, 2));
}

function HomeAddY(%clientId, %offset) {
    %home = $tagToObjectId[%clientId @ "_home"];
    if (%home == "" || %home == 0) {
        Client::sendMessage(%clientId, 1, "You don't have a home placed.");
        return;
    }
    %homePos = fetchData(%clientId, "HomePos");
    if (%homePos == "") {
        Client::sendMessage(%clientId, 1, "Home position data is missing.");
        return;
    }
    %homePosY = getWord(%homePos, 1);
    %newPosY = %homePosY + %offset;
    GameBase::setPosition(%home, getWord(%homePos, 0) @ " " @ %newPosY @ " " @ getWord(%homePos, 2));
    storeData(%clientId, "HomePos", getWord(%homePos, 0) @ " " @ %newPosY @ " " @ getWord(%homePos, 2));
}

function HomeAddZ(%clientId, %offset) {
    %home = $tagToObjectId[%clientId @ "_home"];
    if (%home == "" || %home == 0) {
        Client::sendMessage(%clientId, 1, "You don't have a home placed.");
        return;
    }
    %homePos = fetchData(%clientId, "HomePos");
    if (%homePos == "") {
        Client::sendMessage(%clientId, 1, "Home position data is missing.");
        return;
    }
    %homePosZ = getWord(%homePos, 2);
    %newPosZ = %homePosZ + %offset;
    GameBase::setPosition(%home, getWord(%homePos, 0) @ " " @ getWord(%homePos, 1) @ " " @ %newPosZ);
    storeData(%clientId, "HomePos", getWord(%homePos, 0) @ " " @ getWord(%homePos, 1) @ " " @ %newPosZ);
}

function HomeSetRot(%clientId, %rotation) {
    %home = $tagToObjectId[%clientId @ "_home"];
    if (%home == "" || %home == 0) {
        Client::sendMessage(%clientId, 1, "You don't have a home placed.");
        return;
    }
    GameBase::setRotation(%home, "0 0 " @ %rotation);
    storeData(%clientId, "HomeRot", "0 0 " @ %rotation);
}

function HomeItemAddX(%clientId, %offset, %slot) {
    %homeitem = $tagToObjectId[%clientId @ "_homeitem_" @ %slot];
    if (%homeitem == "" || %homeitem == 0) {
        Client::sendMessage(%clientId, 1, "Home item not found.");
        return;
    }
    %homePos = fetchData(%clientId, "HomePos");
    if (%homePos == "") {
        Client::sendMessage(%clientId, 1, "Home position data is missing.");
        return;
    }
    %homeitemPos = GameBase::getPosition(%homeitem);
    %newPosX = getWord(%homeitemPos, 0) + %offset;
    GameBase::setPosition(%homeitem, %newPosX @ " " @ getWord(%homeitemPos, 1) @ " " @ getWord(%homeitemPos, 2));
    %homeitem.posOffset = (%newPosX - getWord(%homePos, 0)) @ " " @ (getWord(%homeitemPos, 1) - getWord(%homePos, 1)) @ " " @ (getWord(%homeitemPos, 2) - getWord(%homePos, 2));
    //storeData(%clientId, "HomeItemRot_" @ %slot, "0 0 " @ %rotation);
}

function HomeItemAddY(%clientId, %offset, %slot) {
    %homeitem = $tagToObjectId[%clientId @ "_homeitem_" @ %slot];
    if (%homeitem == "" || %homeitem == 0) {
        Client::sendMessage(%clientId, 1, "Home item not found.");
        return;
    }
    %homePos = fetchData(%clientId, "HomePos");
    if (%homePos == "") {
        Client::sendMessage(%clientId, 1, "Home position data is missing.");
        return;
    }
    %homeitemPos = GameBase::getPosition(%homeitem);
    %newPosY = getWord(%homeitemPos, 1) + %offset;
    GameBase::setPosition(%homeitem, getWord(%homeitemPos, 0) @ " " @ %newPosY @ " " @ getWord(%homeitemPos, 2));
    %homeitem.posOffset = (getWord(%homeitemPos, 0) - getWord(%homePos, 0)) @ " " @ (%newPosY - getWord(%homePos, 1)) @ " " @ (getWord(%homeitemPos, 2) - getWord(%homePos, 2));
    //storeData(%clientId, "HomeItemRot_" @ %slot, "0 0 " @ %rotation);
}

function HomeItemAddZ(%clientId, %offset, %slot) {
    %homeitem = $tagToObjectId[%clientId @ "_homeitem_" @ %slot];
    if (%homeitem == "" || %homeitem == 0) {
        Client::sendMessage(%clientId, 1, "Home item not found.");
        return;
    }
    %homePos = fetchData(%clientId, "HomePos");
    if (%homePos == "") {
        Client::sendMessage(%clientId, 1, "Home position data is missing.");
        return;
    }
    %homeitemPos = GameBase::getPosition(%homeitem);
    %newPosZ = getWord(%homeitemPos, 2) + %offset;
    GameBase::setPosition(%homeitem, getWord(%homeitemPos, 0) @ " " @ getWord(%homeitemPos, 1) @ " " @ %newPosZ);
    %homeitem.posOffset = (getWord(%homeitemPos, 0) - getWord(%homePos, 0)) @ " " @ (getWord(%homeitemPos, 1) - getWord(%homePos, 1)) @ " " @ (%newPosZ - getWord(%homePos, 2));
    //storeData(%clientId, "HomeItemRot_" @ %slot, "0 0 " @ %rotation);
}

function HomeItemSetRot(%clientId, %rotation, %slot) {
    %homeitem = $tagToObjectId[%clientId @ "_homeitem_" @ %slot];
    GameBase::setRotation(%homeitem, "0 0 " @ %rotation);
    %homeitem.rot = "0 0 " @ %rotation;
    //storeData(%clientId, "HomeItemRot_" @ %slot, "0 0 " @ %rotation);
}

function RemoveHome(%clientId) {
    %home = $tagToObjectId[%clientId @ "_home"];
    if (%home != "" && %home != 0) {
        %shape = %home.shape;
        if (%shape == "")
            %shape = $tagToObjectShape[%clientId @ "_home"];
        if (String::findSubStr(%shape, ".dis") != -1)
            %shape = String::replace(%shape, ".dis", "");
        if (%shape != "")
            Belt::GiveThisStuff(%clientId, $Housing::itemName["home", %shape], 1);
    }

    for (%i = 1; %i <= $maxHouseItems; %i++) {
        %homeItem = $tagToObjectId[%clientId @ "_homeitem_" @ %i];
        if (%homeItem != "" && %homeItem != 0)
            RemoveHomeItem(%clientId, %i, true);
    }

    storeData(%clientId, "HomeShape", "");
    storeData(%clientId, "HomePos", "");
    storeData(%clientId, "HomeRot", "");
    storeData(%clientId, "HasHome", 0);
    // set all other values to empty as well

    // TODO: If items are used to place homes / home items, return those items to player inventory

    ClearHomeVariables(%clientId);
    
    Client::sendMessage(%clientId, 2, "Home and all house items removed.");
    SaveCharacter(%clientId, true);
}

function RemoveHomeItem(%clientId, %slot, %skipSave) {
    %old = $tagToObjectId[%clientId @ "_homeitem_" @ %slot];
    if (%old != "" && %old != 0) {
        %shape = %old.shape;
        if (%shape == "")
            %shape = $tagToObjectShape[%clientId @ "_homeitem_" @ %slot];
        if (String::findSubStr(%shape, ".dis") != -1)
            %shape = String::replace(%shape, ".dis", "");
        if (%shape != "")
            Belt::GiveThisStuff(%clientId, $Housing::itemName["homeitem", %shape], 1);
    }
    deleteObject(%old);
    $tagToObjectId[%clientId @ "_homeitem_" @ %slot] = "";

    Client::sendMessage(%clientId, 2, "Home item removed.");
    if (%skipSave == "")
        SaveCharacter(%clientId, true);
}

function ClearHomeVariables(%clientId) {
    // clean up up house and house items from global arrays
    $tagToObjectId[%clientId @ "_home"] = "";
    for (%i = 1; %i <= $maxHouseItems; %i++) {
        $tagToObjectId[%clientId @ "_homeitem_" @ %i] = "";
    }

    %g = "MissionCleanup/Home" @ %clientId;
    //so the players in the grouptrigger get kicked out first.
    Group::iterateRecursive(%g, GameBase::setPosition, "0 0 0");
    schedule("deleteObject(" @ nameToId(%g) @ ");", 1);
}

// home items

function Housing::AddItemDef(%housingType, %shape, %displayName, %itemName, %weight, %cost, %shopIndex) {
    $Housing::itemName[%housingType, %shape] = %itemName;
    BeltItem::Add(%displayName, %itemName, "HousingItems", %weight, %cost, "", %shopIndex);
    $beltitem[%itemName, "isHousingItem"] = True;
    $beltitem[%itemName, "housingType"] = %housingType;
    $beltitem[%itemName, "shape"] = %shape;
    $beltitem[%itemName, "reusable"] = True;
}

if (!$Housing::ItemsInitialized) {
	$Housing::ItemsInitialized = True;

	// Homes (1200+)
	Housing::AddItemDef("home", "house1", "Standard House", "StandardHouse", 800, 150000, 1200);
	Housing::AddItemDef("home", "store1", "Small Shop House", "SmallShopHouse", 900, 200000, 1201);
	Housing::AddItemDef("home", "nbank", "Blue Roof House", "BlueRoofHouse", 850, 180000, 1202);
	Housing::AddItemDef("home", "cozyhouse", "Cozy Cottage", "CozyCottage", 700, 140000, 1203);
	Housing::AddItemDef("home", "tavern", "Tavern House", "TavernHouse", 1200, 350000, 1204);
	Housing::AddItemDef("home", "lhouse", "Large L-House", "LargeLHouse", 1400, 450000, 1205);
	Housing::AddItemDef("home", "cheehouselights", "Cheetah Lights Home", "CheetahLightsHome", 1300, 420000, 1206);
	Housing::AddItemDef("home", "shildrikhouse", "Shildrik House", "ShildrikHouse", 1350, 480000, 1207);
	Housing::AddItemDef("home", "rmr7thheaven", "Seventh Heaven Bar", "SeventhHeavenBar", 1500, 600000, 1208);
	Housing::AddItemDef("home", "cfarm1", "Country Farmhouse", "CountryFarmhouse", 1250, 380000, 1209);
	Housing::AddItemDef("home", "chaunted", "Haunted Manor", "HauntedManor", 1600, 700000, 1210);
	Housing::AddItemDef("home", "keep", "Stone Keep", "StoneKeep", 2500, 1200000, 1211);
	Housing::AddItemDef("home", "castle", "Grand Castle", "GrandCastle", 3000, 1800000, 1212);
	Housing::AddItemDef("home", "magetower", "Mage Tower", "MageTower", 2200, 1500000, 1213);
	Housing::AddItemDef("home", "shildriklit", "Shildrik Base", "ShildrikBase", 2000, 1100000, 1214);
	Housing::AddItemDef("home", "town51", "Blue Roof Townhouse", "BlueRoofTownhouse", 2300, 900000, 1215);
	Housing::AddItemDef("home", "town52", "Multi-Building Complex", "MultiBuildingComplex", 2600, 1300000, 1216);
	Housing::AddItemDef("home", "cthh", "Temple Estate", "TempleEstate", 2400, 1250000, 1217);
	Housing::AddItemDef("home", "limbo1", "Limbo Sanctuary", "LimboSanctuary", 2600, 1400000, 1218);
	Housing::AddItemDef("home", "fort", "Jaten Fort", "JatenFort", 3500, 2200000, 1219);
	Housing::AddItemDef("home", "dcty", "Delkin Port Town", "DelkinPortTown", 3800, 2500000, 1220);
	Housing::AddItemDef("home", "rmrrinvale", "Rinvale Town", "RinvaleTown", 3600, 2300000, 1221);
	Housing::AddItemDef("home", "edmire2lit", "Edmire Town", "EdmireTown", 3400, 2100000, 1222);
	Housing::AddItemDef("home", "ctown", "Nibelheim Town", "NibelheimTown", 4500, 3500000, 1223);
	Housing::AddItemDef("home", "ncity", "Keldrin City", "KeldrinCity", 5000, 4500000, 1224);

	// Home items (1225 - 1259)
	Housing::AddItemDef("homeitem", "cabinet1", "Tall Wood Cabinet", "TallWoodCabinet", 60, 4500, 1225);
	Housing::AddItemDef("homeitem", "cabinet2", "Short Wood Cabinet", "ShortWoodCabinet", 45, 3500, 1226);
	Housing::AddItemDef("homeitem", "woodchair", "Wooden Chair", "WoodenChair", 10, 1500, 1227);
	Housing::AddItemDef("homeitem", "bar", "Wooden Bar", "WoodenBar", 40, 8000, 1228);
	Housing::AddItemDef("homeitem", "barstool", "Bar Stool", "BarStool", 6, 1200, 1229);
	Housing::AddItemDef("homeitem", "table", "Small Wood Table", "SmallWoodTable", 10, 2000, 1230);
	Housing::AddItemDef("homeitem", "roundtable", "Small Round Table", "SmallRoundTable", 12, 2200, 1231);
	Housing::AddItemDef("homeitem", "stove", "Metal Stove", "MetalStove", 60, 9000, 1232);
	Housing::AddItemDef("homeitem", "easel", "Artist Easel", "ArtistEasel", 15, 3000, 1233);
	Housing::AddItemDef("homeitem", "bed", "Single Bed", "SingleBed", 80, 5000, 1234);
	Housing::AddItemDef("homeitem", "jfnt", "Small Fountain", "SmallFountain", 90, 7000, 1235);
	Housing::AddItemDef("homeitem", "woodfire", "Wood Fireplace", "WoodFireplace", 50, 6500, 1236);
	Housing::AddItemDef("homeitem", "anvil", "Blacksmith Anvil", "BlacksmithAnvil", 150, 10000, 1237);
	Housing::AddItemDef("homeitem", "bed1", "Blue Double Bed", "BlueDoubleBed", 120, 7000, 1238);
	Housing::AddItemDef("homeitem", "bed1b", "Brown Double Bed", "BrownDoubleBed", 120, 7000, 1239);
	Housing::AddItemDef("homeitem", "bed1c", "Light Double Bed", "LightDoubleBed", 120, 7000, 1240);
	Housing::AddItemDef("homeitem", "bed2", "Queen Bed", "QueenBed", 150, 9000, 1241);
	Housing::AddItemDef("homeitem", "bed3", "Canopy Bed", "CanopyBed", 180, 10000, 1242);
	Housing::AddItemDef("homeitem", "bench1", "Stone Bench", "StoneBench", 60, 4000, 1243);
	Housing::AddItemDef("homeitem", "bench2", "Ornate Bench (Light)", "OrnateBenchLight", 55, 4500, 1244);
	Housing::AddItemDef("homeitem", "bench3", "Ornate Bench (Dark)", "OrnateBenchDark", 55, 4500, 1245);
	Housing::AddItemDef("homeitem", "bigtable1", "Large Fancy Table (Dark)", "LargeFancyTableDark", 90, 8000, 1246);
	Housing::AddItemDef("homeitem", "bigtable2", "Large Fancy Table (Light)", "LargeFancyTableLight", 90, 8000, 1247);
	Housing::AddItemDef("homeitem", "candleabra", "Wall Candelabra", "WallCandelabra", 15, 3000, 1248);
	Housing::AddItemDef("homeitem", "chair1", "Cushioned Chair", "CushionedChair", 12, 2500, 1249);
	Housing::AddItemDef("homeitem", "chair1a", "White Cushioned Chair", "WhiteCushionedChair", 12, 2600, 1250);
	Housing::AddItemDef("homeitem", "endtable", "Small End Table", "SmallEndTable", 12, 2000, 1251);
	Housing::AddItemDef("homeitem", "fireplace", "Stone Fireplace", "StoneFireplace", 250, 10000, 1252);
	Housing::AddItemDef("homeitem", "fireplaceb", "Grand Fireplace", "GrandFireplace", 300, 10000, 1253);
	Housing::AddItemDef("homeitem", "pic1", "Wall Picture I", "WallPicture1", 5, 1200, 1254);
	Housing::AddItemDef("homeitem", "pic2", "Wall Picture II", "WallPicture2", 5, 1200, 1255);
	Housing::AddItemDef("homeitem", "pic3", "Wall Picture III", "WallPicture3", 5, 1200, 1256);
	Housing::AddItemDef("homeitem", "pic4", "Wall Picture IV", "WallPicture4", 5, 1200, 1257);
	Housing::AddItemDef("homeitem", "pic5", "Wall Picture V", "WallPicture5", 5, 1200, 1258);
	Housing::AddItemDef("homeitem", "throne2", "Ornate Throne", "OrnateThrone", 120, 9500, 1259);
}
