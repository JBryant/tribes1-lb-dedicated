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

function StartPlaceMode(%clientId, %name, %objectShape, %slot) {
    Client::sendMessage(%clientId, 2, "You are placing " @ %name @ ". Type #place when you are done.");
    storeData(%clientId, "PlaceMode", 1);
    $userMovingHouseItem[%clientId] = %name;
    %tag = %clientId @ "_" @ %name;

    if ($tagToObjectId[%tag] == "" || $tagToObjectId[%tag] == 0 || $tagToObjectId[%tag] == "0") {
        %object = newObject(%name, InteriorShape, %objectShape, true);
        %object.owner = %clientId;
        %object.name = %name;
        if (%slot != "") %object.slot = %slot;
        $tagToObjectId[%tag] = %object;
        $tagToObjectShape[%tag] = %objectShape;
    }

    PlaceModeLoop(%clientId, %name);
}

function PlaceModeLoop(%clientId, %name) {
    %object = $tagToObjectId[%clientId @ "_" @ %name];
    %player = Client::getOwnedObject(%clientId);

    // lbecho("PlaceModeLoop for " @ %name @ ": clientId=" @ %clientId @ " object=" @ %object @ " player=" @ %player);
    if (fetchData(%clientId, "PlaceMode") == 1 && %player != -1 && %object != -1) {
        %player = Client::getOwnedObject(%clientId);

        if(GameBase::getLOSinfo(%player, 1000)) {
            %pos = $los::position;
            %obj = $los::object;

            if ($los::object != %object && getObjectType($los::object) != "Player") {
                // lbecho("set position of " @ %name @ " to " @ %pos);
                GameBase::setPosition(%object, %pos);
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
        }

        schedule("PlaceModeLoop(" @ %clientId @ ", " @ %name @ ");", 0.2);
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
    storeData(%clientId, "PlaceMode", 0);
}

function HomeAddX(%clientId, %offset) {
    %home = $tagToObjectId[%clientId @ "_home"];
    %homePos = fetchData(%clientId, "HomePos");
    %homePosX = getWord(%homePos, 0);
    %newPosX = %homePosX + %offset;
    GameBase::setPosition(%home, %newPosX @ " " @ getWord(%homePos, 1) @ " " @ getWord(%homePos, 2));
    storeData(%clientId, "HomePos", %newPosX @ " " @ getWord(%homePos, 1) @ " " @ getWord(%homePos, 2));
}

function HomeAddY(%clientId, %offset) {
    %home = $tagToObjectId[%clientId @ "_home"];
    %homePos = fetchData(%clientId, "HomePos");
    %homePosY = getWord(%homePos, 1);
    %newPosY = %homePosY + %offset;
    GameBase::setPosition(%home, getWord(%homePos, 0) @ " " @ %newPosY @ " " @ getWord(%homePos, 2));
    storeData(%clientId, "HomePos", getWord(%homePos, 0) @ " " @ %newPosY @ " " @ getWord(%homePos, 2));
}

function HomeAddZ(%clientId, %offset) {
    %home = $tagToObjectId[%clientId @ "_home"];
    %homePos = fetchData(%clientId, "HomePos");
    %homePosZ = getWord(%homePos, 2);
    %newPosZ = %homePosZ + %offset;
    GameBase::setPosition(%home, getWord(%homePos, 0) @ " " @ getWord(%homePos, 1) @ " " @ %newPosZ);
    storeData(%clientId, "HomePos", getWord(%homePos, 0) @ " " @ getWord(%homePos, 1) @ " " @ %newPosZ);
}

function HomeSetRot(%clientId, %rotation) {
    %home = $tagToObjectId[%clientId @ "_home"];
    GameBase::setRotation(%home, "0 0 " @ %rotation);
    storeData(%clientId, "HomeRot", "0 0 " @ %rotation);
}

function HomeItemAddX(%clientId, %offset, %slot) {
    %homeitem = $tagToObjectId[%clientId @ "_homeitem_" @ %slot];
    %homeitemPos = GameBase::getPosition(%homeitem);
    %newPosX = getWord(%homeitemPos, 0) + %offset;
    GameBase::setPosition(%homeitem, %newPosX @ " " @ getWord(%homeitemPos, 1) @ " " @ getWord(%homeitemPos, 2));
    %homeitem.posOffset = %newPosX @ " " @ getWord(%homeitemPos, 1) @ " " @ getWord(%homeitemPos, 2);
    //storeData(%clientId, "HomeItemRot_" @ %slot, "0 0 " @ %rotation);
}

function HomeItemAddY(%clientId, %offset, %slot) {
    %homeitem = $tagToObjectId[%clientId @ "_homeitem_" @ %slot];
    %homeitemPos = GameBase::getPosition(%homeitem);
    %newPosY = getWord(%homeitemPos, 1) + %offset;
    GameBase::setPosition(%homeitem, getWord(%homeitemPos, 0) @ " " @ %newPosY @ " " @ getWord(%homeitemPos, 2));
    %homeitem.posOffset = getWord(%homeitemPos, 0) @ " " @ %newPosY @ " " @ getWord(%homeitemPos, 2);
    //storeData(%clientId, "HomeItemRot_" @ %slot, "0 0 " @ %rotation);
}

function HomeItemAddZ(%clientId, %offset, %slot) {
    %homeitem = $tagToObjectId[%clientId @ "_homeitem_" @ %slot];
    %homeitemPos = GameBase::getPosition(%homeitem);
    %newPosZ = getWord(%homeitemPos, 2) + %offset;
    GameBase::setPosition(%homeitem, getWord(%homeitemPos, 0) @ " " @ getWord(%homeitemPos, 1) @ " " @ %newPosZ);
    %homeitem.posOffset = getWord(%homeitemPos, 0) @ " " @ getWord(%homeitemPos, 1) @ " " @ %newPosZ;
    //storeData(%clientId, "HomeItemRot_" @ %slot, "0 0 " @ %rotation);
}

function HomeItemSetRot(%clientId, %rotation, %slot) {
    %homeitem = $tagToObjectId[%clientId @ "_homeitem_" @ %slot];
    GameBase::setRotation(%homeitem, "0 0 " @ %rotation);
    %homeitem.rot = "0 0 " @ %rotation;
    //storeData(%clientId, "HomeItemRot_" @ %slot, "0 0 " @ %rotation);
}

function RemoveHome(%clientId) {
    storeData(%clientId, "HomeShape", "");
    storeData(%clientId, "HomePos", "");
    storeData(%clientId, "HomeRot", "");
    // set all other values to empty as well

    // TODO: If items are used to place homes / home items, return those items to player inventory

    ClearHomeVariables(%clientId);
    
    Client::sendMessage(%clientId, 2, "Home and all house items removed.");
}

function RemoveHomeItem(%clientId, %slot) {
    %old = $tagToObjectId[%clientId @ "_homeitem_" @ %slot];
    deleteObject(%old);
    $tagToObjectId[%clientId @ "_homeitem_" @ %slot] = "";

    Client::sendMessage(%clientId, 2, "Home item removed.");
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