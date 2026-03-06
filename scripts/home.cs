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

$DisList::Loaded = False;

function DisList::Init() {
	if($DisList::Loaded)
		return;
	
	$DisList::Loaded = True;

	// Auto-generated from lbnotes.txt
	$DisList::Count = 0;
	$DisList::Name[0] = "1caven";
	$DisList::Desc[0] = "town well where access to water is gated";
	$DisList::Count = 1;
	$DisList::Name[1] = "2caven";
	$DisList::Desc[1] = "big square, maybe something inside? no doors";
	$DisList::Count = 2;
	$DisList::Name[2] = "acidflag2";
	$DisList::Desc[2] = "not working";
	$DisList::Count = 3;
	$DisList::Name[3] = "anvil";
	$DisList::Desc[3] = "A small black anvil";
	$DisList::Count = 4;
	$DisList::Name[4] = "barn";
	$DisList::Desc[4] = "wooden modern barn";
	$DisList::Count = 5;
	$DisList::Name[5] = "bench";
	$DisList::Desc[5] = "invisible, could be overwritten by another";
	$DisList::Count = 6;
	$DisList::Name[6] = "castle";
	$DisList::Desc[6] = "low poly / quality light gray castle (duplicate)";
	$DisList::Count = 7;
	$DisList::Name[7] = "catipult";
	$DisList::Desc[7] = "wooden catipult with black wheels";
	$DisList::Count = 8;
	$DisList::Name[8] = "desk";
	$DisList::Desc[8] = "invisible, cannot see it";
	$DisList::Count = 9;
	$DisList::Name[9] = "olbridge";
	$DisList::Desc[9] = "straight wooden suspension bridge";
	$DisList::Count = 10;
	$DisList::Name[10] = "pathway";
	$DisList::Desc[10] = "bright yellow/black metal bridge";
	$DisList::Count = 11;
	$DisList::Name[11] = "throne";
	$DisList::Desc[11] = "gray low/metal throne, not very high quality (duplicate)";
	$DisList::Count = 12;
	$DisList::Name[12] = "bbridge";
	$DisList::Desc[12] = "large black bridge across from keldrin";
	$DisList::Count = 13;
	$DisList::Name[13] = "beachwharf";
	$DisList::Desc[13] = "large square dark brown wharf. jaten wharf?";
	$DisList::Count = 14;
	$DisList::Name[14] = "blacksmith";
	$DisList::Desc[14] = "small dark cave with water below";
	$DisList::Count = 15;
	$DisList::Name[15] = "bridge";
	$DisList::Desc[15] = "curved bridge/walkway (above mino)";
	$DisList::Count = 16;
	$DisList::Name[16] = "bridge5";
	$DisList::Desc[16] = "super tall black bridge for crossing large chasms";
	$DisList::Count = 17;
	$DisList::Name[17] = "bssign";
	$DisList::Desc[17] = "blacksmith sign";
	$DisList::Count = 18;
	$DisList::Name[18] = "keldrinhouse1";
	$DisList::Desc[18] = "interior space for keldrin house";
	$DisList::Count = 19;
	$DisList::Name[19] = "lucanshouse";
	$DisList::Desc[19] = "interior space for lucans house";
	$DisList::Count = 20;
	$DisList::Name[20] = "strawberrymines";
	$DisList::Desc[20] = "very large and deep mine system";
	$DisList::Count = 21;
	$DisList::Name[21] = "thievesden";
	$DisList::Desc[21] = "invalid dis? failed to load";
	$DisList::Count = 22;
	$DisList::Name[22] = "vendoralley";
	$DisList::Desc[22] = "invalid dis? failed to load";
	$DisList::Count = 23;
	$DisList::Name[23] = "vendorvalleyarch";
	$DisList::Desc[23] = "invalid dis? failed to load";
	$DisList::Count = 24;
	$DisList::Name[24] = "castle";
	$DisList::Desc[24] = "low poly / quality light gray castle (duplicate)";
	$DisList::Count = 25;
	$DisList::Name[25] = "keep";
	$DisList::Desc[25] = "ethren keep";
	$DisList::Count = 26;
	$DisList::Name[26] = "cave";
	$DisList::Desc[26] = "small turnaround part of the cave (entrance/exit)";
	$DisList::Count = 27;
	$DisList::Name[27] = "cdoora";
	$DisList::Desc[27] = "";
	$DisList::Count = 28;
	$DisList::Name[28] = "cdoorb";
	$DisList::Desc[28] = "";
	$DisList::Count = 29;
	$DisList::Name[29] = "cdoorc";
	$DisList::Desc[29] = "";
	$DisList::Count = 30;
	$DisList::Name[30] = "cdoord";
	$DisList::Desc[30] = "";
	$DisList::Count = 31;
	$DisList::Name[31] = "cdoore";
	$DisList::Desc[31] = "";
	$DisList::Count = 32;
	$DisList::Name[32] = "cdoorf";
	$DisList::Desc[32] = "";
	$DisList::Count = 33;
	$DisList::Name[33] = "cdoorg";
	$DisList::Desc[33] = "";
	$DisList::Count = 34;
	$DisList::Name[34] = "bridgesection1";
	$DisList::Desc[34] = "long flat bridge with house at end";
	$DisList::Count = 35;
	$DisList::Name[35] = "bridgesection2";
	$DisList::Desc[35] = "couldnt see it, maybe under ground?";
	$DisList::Count = 36;
	$DisList::Name[36] = "town51";
	$DisList::Desc[36] = "iceworld blue house with trees, 2 story and nice interior";
	$DisList::Count = 37;
	$DisList::Name[37] = "town52";
	$DisList::Desc[37] = "large 1 story house with bedroom, kitchen and main living room";
	$DisList::Count = 38;
	$DisList::Name[38] = "town53";
	$DisList::Desc[38] = "3 small blue stores in a row";
	$DisList::Count = 39;
	$DisList::Name[39] = "cbank1";
	$DisList::Desc[39] = "sideways bank, not correct";
	$DisList::Count = 40;
	$DisList::Name[40] = "cbar1";
	$DisList::Desc[40] = "sideways";
	$DisList::Count = 41;
	$DisList::Name[41] = "chouse1";
	$DisList::Desc[41] = "sideways";
	$DisList::Count = 42;
	$DisList::Name[42] = "cmerchant1";
	$DisList::Desc[42] = "sideways";
	$DisList::Count = 43;
	$DisList::Name[43] = "cwalls1";
	$DisList::Desc[43] = "sideways";
	$DisList::Count = 44;
	$DisList::Name[44] = "bed1";
	$DisList::Desc[44] = "single dark brown wood blue matress";
	$DisList::Count = 45;
	$DisList::Name[45] = "bed2";
	$DisList::Desc[45] = "king size light wood, light colored matress";
	$DisList::Count = 46;
	$DisList::Name[46] = "bed3";
	$DisList::Desc[46] = "king with drapes, dark wood and brown mattress";
	$DisList::Count = 47;
	$DisList::Name[47] = "bench1";
	$DisList::Desc[47] = "small stone bench";
	$DisList::Count = 48;
	$DisList::Name[48] = "bench2";
	$DisList::Desc[48] = "ornate wood bench";
	$DisList::Count = 49;
	$DisList::Name[49] = "bench3";
	$DisList::Desc[49] = "dark older ornate wood bench";
	$DisList::Count = 50;
	$DisList::Name[50] = "bigtable1";
	$DisList::Desc[50] = "large dark wood table (dinner)";
	$DisList::Count = 51;
	$DisList::Name[51] = "bigtable2";
	$DisList::Desc[51] = "large light wood table (dinner)";
	$DisList::Count = 52;
	$DisList::Name[52] = "bookshelfl";
	$DisList::Desc[52] = "very large book shelf";
	$DisList::Count = 53;
	$DisList::Name[53] = "bookshelfm";
	$DisList::Desc[53] = "large light wooden book shelf";
	$DisList::Count = 54;
	$DisList::Name[54] = "candelabra";
	$DisList::Desc[54] = "candle lights";
	$DisList::Count = 55;
	$DisList::Name[55] = "chair1";
	$DisList::Desc[55] = "light brown chair patterned";
	$DisList::Count = 56;
	$DisList::Name[56] = "chair1a";
	$DisList::Desc[56] = "light brown char, white pattern";
	$DisList::Count = 57;
	$DisList::Name[57] = "cthh";
	$DisList::Desc[57] = "evil looking cathedral, very cool";
	$DisList::Count = 58;
	$DisList::Name[58] = "endtable";
	$DisList::Desc[58] = "nice light wooden end table";
	$DisList::Count = 59;
	$DisList::Name[59] = "evbr";
	$DisList::Desc[59] = "elvish stone looking bridge";
	$DisList::Count = 60;
	$DisList::Name[60] = "fireplace";
	$DisList::Desc[60] = "nice lightg marble/stone fireplace";
	$DisList::Count = 61;
	$DisList::Name[61] = "fireplaceb";
	$DisList::Desc[61] = "dark wood and stone fireplace";
	$DisList::Count = 62;
	$DisList::Name[62] = "keldabhm";
	$DisList::Desc[62] = "keldrin small room interior";
	$DisList::Count = 63;
	$DisList::Name[63] = "keldinn";
	$DisList::Desc[63] = "keldrin inn interior";
	$DisList::Count = 64;
	$DisList::Name[64] = "keldint1";
	$DisList::Desc[64] = "keldrin large house interior";
	$DisList::Count = 65;
	$DisList::Name[65] = "keldthhm";
	$DisList::Desc[65] = "keldrin very large interior house";
	$DisList::Count = 66;
	$DisList::Name[66] = "pic1";
	$DisList::Desc[66] = "picture of a town";
	$DisList::Count = 67;
	$DisList::Name[67] = "pic2";
	$DisList::Desc[67] = "picture of a town";
	$DisList::Count = 68;
	$DisList::Name[68] = "pic3";
	$DisList::Desc[68] = "picture of a town";
	$DisList::Count = 69;
	$DisList::Name[69] = "pic4";
	$DisList::Desc[69] = "picture of a town";
	$DisList::Count = 70;
	$DisList::Name[70] = "pic5";
	$DisList::Desc[70] = "large picture of backgropund";
	$DisList::Count = 71;
	$DisList::Name[71] = "throne";
	$DisList::Desc[71] = "gray low/metal throne, not very high quality (duplicate)";
	$DisList::Count = 72;
	$DisList::Name[72] = "throne2";
	$DisList::Desc[72] = "large wooden throne chair";
	$DisList::Count = 73;
	$DisList::Name[73] = "twosideflag";
	$DisList::Desc[73] = "nice two sided hanging flag";
	$DisList::Count = 74;
	$DisList::Name[74] = "ubzn";
	$DisList::Desc[74] = "interior of old stone uber zone";
	$DisList::Count = 75;
	$DisList::Name[75] = "woodcrate";
	$DisList::Desc[75] = "small wood crate";
	$DisList::Count = 76;
	$DisList::Name[76] = "woodcrateb";
	$DisList::Desc[76] = "large wod crate";
	$DisList::Count = 77;
	$DisList::Name[77] = "chouse2";
	$DisList::Desc[77] = "simple wooden barn looking home";
	$DisList::Count = 78;
	$DisList::Name[78] = "cchurch1";
	$DisList::Desc[78] = "whiet and red church with bell";
	$DisList::Count = 79;
	$DisList::Name[79] = "hotel";
	$DisList::Desc[79] = "large quirky hotel with 2 floors but weird textures";
	$DisList::Count = 80;
	$DisList::Name[80] = "schurch";
	$DisList::Desc[80] = "higher quality church with benches and cross";
	$DisList::Count = 81;
	$DisList::Name[81] = "lptown";
	$DisList::Desc[81] = "very cool wooden wharf town, meant to be on the water";
	$DisList::Count = 82;
	$DisList::Name[82] = "crypt0";
	$DisList::Desc[82] = "original underground crypt";
	$DisList::Count = 83;
	$DisList::Name[83] = "porttown";
	$DisList::Desc[83] = "same as lptown, cool wooden wharf town to be on water";
	$DisList::Count = 84;
	$DisList::Name[84] = "ccolos1";
	$DisList::Desc[84] = "marble column square with roof, not sure what to use it for";
	$DisList::Count = 85;
	$DisList::Name[85] = "cfarm1";
	$DisList::Desc[85] = "large farm with attached home";
	$DisList::Count = 86;
	$DisList::Name[86] = "chest";
	$DisList::Desc[86] = "a chest, but it always spawns under ground and is hard to work with";
	$DisList::Count = 87;
	$DisList::Name[87] = "cozyhouse";
	$DisList::Desc[87] = "small white, one room home with lower texture quality";
	$DisList::Count = 88;
	$DisList::Name[88] = "richtower";
	$DisList::Desc[88] = "better version of the tower, needs ww or working elevator";
	$DisList::Count = 89;
	$DisList::Name[89] = "ccliff";
	$DisList::Desc[89] = "spawned under ground, can't see";
	$DisList::Count = 90;
	$DisList::Name[90] = "chaunted";
	$DisList::Desc[90] = "rudimentary mansion that doesn't look very haunted";
	$DisList::Count = 91;
	$DisList::Name[91] = "gardens";
	$DisList::Desc[91] = "a large grass labythn / maze. can fly over, but with no ww looks okay";
	$DisList::Count = 92;
	$DisList::Name[92] = "clbar1";
	$DisList::Desc[92] = "cant see it";
	$DisList::Count = 93;
	$DisList::Name[93] = "chouse1";
	$DisList::Desc[93] = "sideways house";
	$DisList::Count = 94;
	$DisList::Name[94] = "chouse2";
	$DisList::Desc[94] = "standard brown home";
	$DisList::Count = 95;
	$DisList::Name[95] = "ctower1";
	$DisList::Desc[95] = "early prototype of richtower hotel, not complete";
	$DisList::Count = 96;
	$DisList::Name[96] = "ctower2";
	$DisList::Desc[96] = "short wooden guard tower";
	$DisList::Count = 97;
	$DisList::Name[97] = "ctower3";
	$DisList::Desc[97] = "medium wooden guard tower";
	$DisList::Count = 98;
	$DisList::Name[98] = "ctower4";
	$DisList::Desc[98] = "tall wooden guard tower";
	$DisList::Count = 99;
	$DisList::Name[99] = "dcty";
	$DisList::Desc[99] = "delkin city";
	$DisList::Count = 100;
	$DisList::Name[100] = "castle4";
	$DisList::Desc[100] = "small castle fort";
	$DisList::Count = 101;
	$DisList::Name[101] = "waterhouse";
	$DisList::Desc[101] = "underground simple stone house";
	$DisList::Count = 102;
	$DisList::Name[102] = "forsol";
	$DisList::Desc[102] = "stone monument with floating pads and flashing lights on the pads";
	$DisList::Count = 103;
	$DisList::Name[103] = "cheetemple";
	$DisList::Desc[103] = "";
	$DisList::Count = 104;
	$DisList::Name[104] = "cheetempleenter";
	$DisList::Desc[104] = "";
	$DisList::Count = 105;
	$DisList::Name[105] = "headstone";
	$DisList::Desc[105] = "";
	$DisList::Count = 106;
	$DisList::Name[106] = "desertgate";
	$DisList::Desc[106] = "";
	$DisList::Count = 107;
	$DisList::Name[107] = "magictree";
	$DisList::Desc[107] = "";
	$DisList::Count = 108;
	$DisList::Name[108] = "sphere";
	$DisList::Desc[108] = "";
	$DisList::Count = 109;
	$DisList::Name[109] = "dtest";
	$DisList::Desc[109] = "";
	$DisList::Count = 110;
	$DisList::Name[110] = "dsewers";
	$DisList::Desc[110] = "";
	$DisList::Count = 111;
	$DisList::Name[111] = "gpasspasslit2";
	$DisList::Desc[111] = "";
	$DisList::Count = 112;
	$DisList::Name[112] = "graveyarddlit";
	$DisList::Desc[112] = "";
	$DisList::Count = 113;
	$DisList::Name[113] = "gnoll";
	$DisList::Desc[113] = "";
	$DisList::Count = 114;
	$DisList::Name[114] = "gnollhouse2";
	$DisList::Desc[114] = "";
	$DisList::Count = 115;
	$DisList::Name[115] = "uuagkeep";
	$DisList::Desc[115] = "";
	$DisList::Count = 116;
	$DisList::Name[116] = "neogpasspass";
	$DisList::Desc[116] = "";
	$DisList::Count = 117;
	$DisList::Name[117] = "newgpass";
	$DisList::Desc[117] = "";
	$DisList::Count = 118;
	$DisList::Name[118] = "golemai2final";
	$DisList::Desc[118] = "";
	$DisList::Count = 119;
	$DisList::Name[119] = "mountainring";
	$DisList::Desc[119] = "";
	$DisList::Count = 120;
	$DisList::Name[120] = "newgpassfinal";
	$DisList::Desc[120] = "";
	$DisList::Count = 121;
	$DisList::Name[121] = "grindalpassfinal";
	$DisList::Desc[121] = "";
	$DisList::Count = 122;
	$DisList::Name[122] = "grindalpassenterfinal";
	$DisList::Desc[122] = "";
	$DisList::Count = 123;
	$DisList::Name[123] = "grindalpassexitfinal";
	$DisList::Desc[123] = "";
	$DisList::Count = 124;
	$DisList::Name[124] = "thecavernsfinal";
	$DisList::Desc[124] = "";
	$DisList::Count = 125;
	$DisList::Name[125] = "demongatefinal";
	$DisList::Desc[125] = "";
	$DisList::Count = 126;
	$DisList::Name[126] = "ethrenwalls";
	$DisList::Desc[126] = "";
	$DisList::Count = 127;
	$DisList::Name[127] = "farm";
	$DisList::Desc[127] = "";
	$DisList::Count = 128;
	$DisList::Name[128] = "test2";
	$DisList::Desc[128] = "";
	$DisList::Count = 129;
	$DisList::Name[129] = "fxsmall";
	$DisList::Desc[129] = "";
	$DisList::Count = 130;
	$DisList::Name[130] = "fsmall";
	$DisList::Desc[130] = "";
	$DisList::Count = 131;
	$DisList::Name[131] = "fmedium";
	$DisList::Desc[131] = "";
	$DisList::Count = 132;
	$DisList::Name[132] = "flarge";
	$DisList::Desc[132] = "";
	$DisList::Count = 133;
	$DisList::Name[133] = "fxlarge";
	$DisList::Desc[133] = "";
	$DisList::Count = 134;
	$DisList::Name[134] = "fhuge";
	$DisList::Desc[134] = "";
	$DisList::Count = 135;
	$DisList::Name[135] = "fclub";
	$DisList::Desc[135] = "";
	$DisList::Count = 136;
	$DisList::Name[136] = "ffort";
	$DisList::Desc[136] = "";
	$DisList::Count = 137;
	$DisList::Name[137] = "gpasspass";
	$DisList::Desc[137] = "";
	$DisList::Count = 138;
	$DisList::Name[138] = "cwalls2";
	$DisList::Desc[138] = "";
	$DisList::Count = 139;
	$DisList::Name[139] = "memorial1";
	$DisList::Desc[139] = "";
	$DisList::Count = 140;
	$DisList::Name[140] = "trees1";
	$DisList::Desc[140] = "";
	$DisList::Count = 141;
	$DisList::Name[141] = "trees2";
	$DisList::Desc[141] = "";
	$DisList::Count = 142;
	$DisList::Name[142] = "cbridge2";
	$DisList::Desc[142] = "";
	$DisList::Count = 143;
	$DisList::Name[143] = "harena";
	$DisList::Desc[143] = "";
	$DisList::Count = 144;
	$DisList::Name[144] = "haunthouse";
	$DisList::Desc[144] = "";
	$DisList::Count = 145;
	$DisList::Name[145] = "hkeep1";
	$DisList::Desc[145] = "";
	$DisList::Count = 146;
	$DisList::Name[146] = "bigfort";
	$DisList::Desc[146] = "";
	$DisList::Count = 147;
	$DisList::Name[147] = "keep";
	$DisList::Desc[147] = "";
	$DisList::Count = 148;
	$DisList::Name[148] = "bank";
	$DisList::Desc[148] = "";
	$DisList::Count = 149;
	$DisList::Name[149] = "barrack";
	$DisList::Desc[149] = "";
	$DisList::Count = 150;
	$DisList::Name[150] = "merchant";
	$DisList::Desc[150] = "";
	$DisList::Count = 151;
	$DisList::Name[151] = "npchut";
	$DisList::Desc[151] = "";
	$DisList::Count = 152;
	$DisList::Name[152] = "outpost";
	$DisList::Desc[152] = "";
	$DisList::Count = 153;
	$DisList::Name[153] = "nbank";
	$DisList::Desc[153] = "";
	$DisList::Count = 154;
	$DisList::Name[154] = "icehut";
	$DisList::Desc[154] = "";
	$DisList::Count = 155;
	$DisList::Name[155] = "icettd";
	$DisList::Desc[155] = "";
	$DisList::Count = 156;
	$DisList::Name[156] = "icetdown";
	$DisList::Desc[156] = "";
	$DisList::Count = 157;
	$DisList::Name[157] = "icetee";
	$DisList::Desc[157] = "";
	$DisList::Count = 158;
	$DisList::Name[158] = "icetlb";
	$DisList::Desc[158] = "";
	$DisList::Count = 159;
	$DisList::Name[159] = "icetdnl";
	$DisList::Desc[159] = "";
	$DisList::Count = 160;
	$DisList::Name[160] = "icettdn";
	$DisList::Desc[160] = "";
	$DisList::Count = 161;
	$DisList::Name[161] = "icetd";
	$DisList::Desc[161] = "";
	$DisList::Count = 162;
	$DisList::Name[162] = "icetstr";
	$DisList::Desc[162] = "";
	$DisList::Count = 163;
	$DisList::Name[163] = "icest";
	$DisList::Desc[163] = "";
	$DisList::Count = 164;
	$DisList::Name[164] = "icespier";
	$DisList::Desc[164] = "";
	$DisList::Count = 165;
	$DisList::Name[165] = "entrance";
	$DisList::Desc[165] = "";
	$DisList::Count = 166;
	$DisList::Name[166] = "tunnelice";
	$DisList::Desc[166] = "";
	$DisList::Count = 167;
	$DisList::Name[167] = "jfnt";
	$DisList::Desc[167] = "";
	$DisList::Count = 168;
	$DisList::Name[168] = "jbank";
	$DisList::Desc[168] = "";
	$DisList::Count = 169;
	$DisList::Name[169] = "jbarr";
	$DisList::Desc[169] = "";
	$DisList::Count = 170;
	$DisList::Name[170] = "jhut";
	$DisList::Desc[170] = "";
	$DisList::Count = 171;
	$DisList::Name[171] = "jmerch";
	$DisList::Desc[171] = "";
	$DisList::Count = 172;
	$DisList::Name[172] = "joutp";
	$DisList::Desc[172] = "";
	$DisList::Count = 173;
	$DisList::Name[173] = "bridge1";
	$DisList::Desc[173] = "";
	$DisList::Count = 174;
	$DisList::Name[174] = "bridge5";
	$DisList::Desc[174] = "";
	$DisList::Count = 175;
	$DisList::Name[175] = "mine1";
	$DisList::Desc[175] = "";
	$DisList::Count = 176;
	$DisList::Name[176] = "mine2";
	$DisList::Desc[176] = "";
	$DisList::Count = 177;
	$DisList::Name[177] = "mine3a";
	$DisList::Desc[177] = "";
	$DisList::Count = 178;
	$DisList::Name[178] = "mine3b";
	$DisList::Desc[178] = "";
	$DisList::Count = 179;
	$DisList::Name[179] = "mine4";
	$DisList::Desc[179] = "";
	$DisList::Count = 180;
	$DisList::Name[180] = "mine5";
	$DisList::Desc[180] = "";
	$DisList::Count = 181;
	$DisList::Name[181] = "mine6";
	$DisList::Desc[181] = "";
	$DisList::Count = 182;
	$DisList::Name[182] = "mine8";
	$DisList::Desc[182] = "";
	$DisList::Count = 183;
	$DisList::Name[183] = "mines";
	$DisList::Desc[183] = "";
	$DisList::Count = 184;
	$DisList::Name[184] = "jlaby";
	$DisList::Desc[184] = "";
	$DisList::Count = 185;
	$DisList::Name[185] = "jring";
	$DisList::Desc[185] = "";
	$DisList::Count = 186;
	$DisList::Name[186] = "jrock";
	$DisList::Desc[186] = "";
	$DisList::Count = 187;
	$DisList::Name[187] = "labrinyth";
	$DisList::Desc[187] = "";
	$DisList::Count = 188;
	$DisList::Name[188] = "lichlair";
	$DisList::Desc[188] = "";
	$DisList::Count = 189;
	$DisList::Name[189] = "m1";
	$DisList::Desc[189] = "";
	$DisList::Count = 190;
	$DisList::Name[190] = "m2";
	$DisList::Desc[190] = "";
	$DisList::Count = 191;
	$DisList::Name[191] = "m3";
	$DisList::Desc[191] = "";
	$DisList::Count = 192;
	$DisList::Name[192] = "m4";
	$DisList::Desc[192] = "";
	$DisList::Count = 193;
	$DisList::Name[193] = "magetower";
	$DisList::Desc[193] = "";
	$DisList::Count = 194;
	$DisList::Name[194] = "doora";
	$DisList::Desc[194] = "";
	$DisList::Count = 195;
	$DisList::Name[195] = "doorb";
	$DisList::Desc[195] = "";
	$DisList::Count = 196;
	$DisList::Name[196] = "doorc";
	$DisList::Desc[196] = "";
	$DisList::Count = 197;
	$DisList::Name[197] = "doord";
	$DisList::Desc[197] = "";
	$DisList::Count = 198;
	$DisList::Name[198] = "doore";
	$DisList::Desc[198] = "";
	$DisList::Count = 199;
	$DisList::Name[199] = "doorf";
	$DisList::Desc[199] = "";
	$DisList::Count = 200;
	$DisList::Name[200] = "ncity";
	$DisList::Desc[200] = "";
	$DisList::Count = 201;
	$DisList::Name[201] = "shildrikhouses";
	$DisList::Desc[201] = "";
	$DisList::Count = 202;
	$DisList::Name[202] = "cblackbridge1";
	$DisList::Desc[202] = "";
	$DisList::Count = 203;
	$DisList::Name[203] = "blackbridgehouse1";
	$DisList::Desc[203] = "";
	$DisList::Count = 204;
	$DisList::Name[204] = "rmcasterstower";
	$DisList::Desc[204] = "";
	$DisList::Count = 205;
	$DisList::Name[205] = "templebattleroom";
	$DisList::Desc[205] = "";
	$DisList::Count = 206;
	$DisList::Name[206] = "losttempleaddmaze";
	$DisList::Desc[206] = "";
	$DisList::Count = 207;
	$DisList::Name[207] = "pstone_cube_s";
	$DisList::Desc[207] = "";
	$DisList::Count = 208;
	$DisList::Name[208] = "pstone_cube_m";
	$DisList::Desc[208] = "";
	$DisList::Count = 209;
	$DisList::Name[209] = "pstone_cube_l";
	$DisList::Desc[209] = "";
	$DisList::Count = 210;
	$DisList::Name[210] = "pstone_wall_s";
	$DisList::Desc[210] = "";
	$DisList::Count = 211;
	$DisList::Name[211] = "pstone_wall_m";
	$DisList::Desc[211] = "";
	$DisList::Count = 212;
	$DisList::Name[212] = "pstone_wall_l";
	$DisList::Desc[212] = "";
	$DisList::Count = 213;
	$DisList::Name[213] = "pstone_window_s";
	$DisList::Desc[213] = "";
	$DisList::Count = 214;
	$DisList::Name[214] = "pstone_window_m";
	$DisList::Desc[214] = "";
	$DisList::Count = 215;
	$DisList::Name[215] = "pstone_door_s";
	$DisList::Desc[215] = "";
	$DisList::Count = 216;
	$DisList::Name[216] = "pstone_door_m";
	$DisList::Desc[216] = "";
	$DisList::Count = 217;
	$DisList::Name[217] = "pstone_pillar_s";
	$DisList::Desc[217] = "";
	$DisList::Count = 218;
	$DisList::Name[218] = "pstone_pillar_m";
	$DisList::Desc[218] = "";
	$DisList::Count = 219;
	$DisList::Name[219] = "pstone_rpillar_s";
	$DisList::Desc[219] = "";
	$DisList::Count = 220;
	$DisList::Name[220] = "pstone_rpillar_m";
	$DisList::Desc[220] = "";
	$DisList::Count = 221;
	$DisList::Name[221] = "pstone_rpillar_l";
	$DisList::Desc[221] = "";
	$DisList::Count = 222;
	$DisList::Name[222] = "pstone_spike_s";
	$DisList::Desc[222] = "";
	$DisList::Count = 223;
	$DisList::Name[223] = "pstone_spike_m";
	$DisList::Desc[223] = "";
	$DisList::Count = 224;
	$DisList::Name[224] = "pstone_base_s";
	$DisList::Desc[224] = "";
	$DisList::Count = 225;
	$DisList::Name[225] = "pstone_base_m";
	$DisList::Desc[225] = "";
	$DisList::Count = 226;
	$DisList::Name[226] = "pstone_base_l";
	$DisList::Desc[226] = "";
	$DisList::Count = 227;
	$DisList::Name[227] = "pwood_cube_s";
	$DisList::Desc[227] = "";
	$DisList::Count = 228;
	$DisList::Name[228] = "pwood_cube_m";
	$DisList::Desc[228] = "";
	$DisList::Count = 229;
	$DisList::Name[229] = "pwood_cube_l";
	$DisList::Desc[229] = "";
	$DisList::Count = 230;
	$DisList::Name[230] = "pwood_wall_s";
	$DisList::Desc[230] = "";
	$DisList::Count = 231;
	$DisList::Name[231] = "pwood_wall_m";
	$DisList::Desc[231] = "";
	$DisList::Count = 232;
	$DisList::Name[232] = "pwood_wall_l";
	$DisList::Desc[232] = "";
	$DisList::Count = 233;
	$DisList::Name[233] = "bigblock";
	$DisList::Desc[233] = "";
	$DisList::Count = 234;
	$DisList::Name[234] = "blocker";
	$DisList::Desc[234] = "";
	$DisList::Count = 235;
	$DisList::Name[235] = "drawbridge";
	$DisList::Desc[235] = "";
	$DisList::Count = 236;
	$DisList::Name[236] = "horse";
	$DisList::Desc[236] = "";
	$DisList::Count = 237;
	$DisList::Name[237] = "mines";
	$DisList::Desc[237] = "";
	$DisList::Count = 238;
	$DisList::Name[238] = "mineshaft";
	$DisList::Desc[238] = "";
	$DisList::Count = 239;
	$DisList::Name[239] = "plat";
	$DisList::Desc[239] = "";
	$DisList::Count = 240;
	$DisList::Name[240] = "level";
	$DisList::Desc[240] = "";
	$DisList::Count = 241;
	$DisList::Name[241] = "levelwall";
	$DisList::Desc[241] = "";
	$DisList::Count = 242;
	$DisList::Name[242] = "level2";
	$DisList::Desc[242] = "";
	$DisList::Count = 243;
	$DisList::Name[243] = "level3";
	$DisList::Desc[243] = "";
	$DisList::Count = 244;
	$DisList::Name[244] = "level4";
	$DisList::Desc[244] = "";
	$DisList::Count = 245;
	$DisList::Name[245] = "level5";
	$DisList::Desc[245] = "";
	$DisList::Count = 246;
	$DisList::Name[246] = "remorterhall";
	$DisList::Desc[246] = "";
	$DisList::Count = 247;
	$DisList::Name[247] = "limbo1";
	$DisList::Desc[247] = "";
	$DisList::Count = 248;
	$DisList::Name[248] = "limbo2";
	$DisList::Desc[248] = "";
	$DisList::Count = 249;
	$DisList::Name[249] = "rodm_1";
	$DisList::Desc[249] = "";
	$DisList::Count = 250;
	$DisList::Name[250] = "rodm_2";
	$DisList::Desc[250] = "";
	$DisList::Count = 251;
	$DisList::Name[251] = "cchurchchurch";
	$DisList::Desc[251] = "Nice dark church with path down to small cavernous lair. Room for 1 teleporter somewhere.";
	$DisList::Count = 252;
	$DisList::Name[252] = "cglyph";
	$DisList::Desc[252] = "black marble looking monolith";
	$DisList::Count = 253;
	$DisList::Name[253] = "watcher";
	$DisList::Desc[253] = "Black watch tower, no entrances to top, not very useful except for background Scenery";
	$DisList::Count = 254;
	$DisList::Name[254] = "rmdeserts";
	$DisList::Desc[254] = "";
	$DisList::Count = 255;
	$DisList::Name[255] = "castle4";
	$DisList::Desc[255] = "Very small stone square house surrounded by walls, very small and not too exciting";
	$DisList::Count = 256;
	$DisList::Name[256] = "waterhouse";
	$DisList::Desc[256] = "small gray water wheel house, good for next to rivers?";
	$DisList::Count = 257;
	$DisList::Name[257] = "forsol";
	$DisList::Desc[257] = "small circular gray tower with floating circular pads and lights, not sure what to do with this, looks interesting?";
	$DisList::Count = 258;
	$DisList::Name[258] = "cheetemple";
	$DisList::Desc[258] = "part of the old ancient looking temple. smaller with one teleport landing in and a qick walk to end room?";
	$DisList::Count = 259;
	$DisList::Name[259] = "cheetemple1";
	$DisList::Desc[259] = "looks like duplicate of cheetemple";
	$DisList::Count = 260;
	$DisList::Name[260] = "cheetempleenter";
	$DisList::Desc[260] = "Aztec looking temple entrance";
	$DisList::Count = 261;
	$DisList::Name[261] = "desertgate";
	$DisList::Desc[261] = "stone henge looking teleporter, kind of cool";
	$DisList::Count = 262;
	$DisList::Name[262] = "newkobarev2";
	$DisList::Desc[262] = "small floating fortress, looks dark and great for evil acoltys";
	$DisList::Count = 263;
	$DisList::Name[263] = "cheehouselights";
	$DisList::Desc[263] = "cute detailed house with gray walls, lights in front and wood windows. very detailed, but needs interiors.";
	$DisList::Count = 264;
	$DisList::Name[264] = "shildrikhouse";
	$DisList::Desc[264] = "small dark dark gray house with blue roof, not much detail";
	$DisList::Count = 265;
	$DisList::Name[265] = "shildrikhousesfinal";
	$DisList::Desc[265] = "and arc of 3 shildrikhouse's, no other change to model";
	$DisList::Count = 266;
	$DisList::Name[266] = "blackbridgefinal";
	$DisList::Desc[266] = "end portion of a black bridge with lights, hollow square at end only possible to enter via door teleport";
	$DisList::Count = 267;
	$DisList::Name[267] = "blackbridgehousefinal";
	$DisList::Desc[267] = "same as blackbridgefinal except it has a small house over the hollow portion with ramps going up either side";
	$DisList::Count = 268;
	$DisList::Name[268] = "cblackbridgefinal1";
	$DisList::Desc[268] = "a piece of the black bridge for extension purposes";
	$DisList::Count = 269;
	$DisList::Name[269] = "lowershildriksfinal";
	$DisList::Desc[269] = "6 tightly packed shildrick houses (maybe a poor district)";
	$DisList::Count = 270;
	$DisList::Name[270] = "cswordfinal";
	$DisList::Desc[270] = "Sword monument with surrounding gray wall";
	$DisList::Count = 271;
	$DisList::Name[271] = "cbarracksfinal";
	$DisList::Desc[271] = "black wall barracks with many beds, matches aesthetic of the shildrik houses";
	$DisList::Count = 272;
	$DisList::Name[272] = "rmrdungeons";
	$DisList::Desc[272] = "";
	$DisList::Count = 273;
	$DisList::Name[273] = "rmrsewers";
	$DisList::Desc[273] = "Entrance to small sewers";
	$DisList::Count = 274;
	$DisList::Name[274] = "cavernsenter";
	$DisList::Desc[274] = "another smaller stonehenge for teleporter";
	$DisList::Count = 275;
	$DisList::Name[275] = "rmrcavernspart1";
	$DisList::Desc[275] = "Cemetary entrance to the caverns";
	$DisList::Count = 276;
	$DisList::Name[276] = "rmrcavernspart2";
	$DisList::Desc[276] = "part of deep cavern system, looks like upper part";
	$DisList::Count = 277;
	$DisList::Name[277] = "rmrcavernspart3";
	$DisList::Desc[277] = "part of deep cavern system, looks like upper part (small)";
	$DisList::Count = 278;
	$DisList::Name[278] = "rmrcavernspart4";
	$DisList::Desc[278] = "square section sthat goes down";
	$DisList::Count = 279;
	$DisList::Name[279] = "rmrcavernspart5";
	$DisList::Desc[279] = "short transtition to red area";
	$DisList::Count = 280;
	$DisList::Name[280] = "rmrcavernspart6";
	$DisList::Desc[280] = "red area with end of caverns to a teleporter to go deeper";
	$DisList::Count = 281;
	$DisList::Name[281] = "rmrbloodgate";
	$DisList::Desc[281] = "small rock stonehenge red teleporter area";
	$DisList::Count = 282;
	$DisList::Name[282] = "rmrbloodanpart1";
	$DisList::Desc[282] = "red rocky area, requires invistp to move to next section";
	$DisList::Count = 283;
	$DisList::Name[283] = "rmrbloodanpart2";
	$DisList::Desc[283] = "red part ends with stairway down to empty hallway";
	$DisList::Count = 284;
	$DisList::Name[284] = "rmrbloodanpart3";
	$DisList::Desc[284] = "not useable with paret2";
	$DisList::Count = 285;
	$DisList::Name[285] = "rmrbloodanpart3revised";
	$DisList::Desc[285] = "use this instead to continue the path";
	$DisList::Count = 286;
	$DisList::Name[286] = "rmrse1final";
	$DisList::Desc[286] = "house with basement that leads to small cavern";
	$DisList::Count = 287;
	$DisList::Name[287] = "rmrse1finala";
	$DisList::Desc[287] = "- house with basement that leads to small cavern";
	$DisList::Count = 288;
	$DisList::Name[288] = "howlingearthp1";
	$DisList::Desc[288] = "entrance to howlig earth, connect to rmrbloodanpart3revised";
	$DisList::Count = 289;
	$DisList::Name[289] = "keegasdwelling";
	$DisList::Desc[289] = "small cavern entrance that goes down to small cavernous abode (blue lights)";
	$DisList::Count = 290;
	$DisList::Name[290] = "rmrtemplep1";
	$DisList::Desc[290] = "pyramid that is part of ancient temple? small section that leads to two maze entrance?";
	$DisList::Count = 291;
	$DisList::Name[291] = "rmrtemplep2";
	$DisList::Desc[291] = "temple portion entrance with one entrance, tree area, and next area (small)";
	$DisList::Count = 292;
	$DisList::Name[292] = "rmrtemplep3";
	$DisList::Desc[292] = "end portion with lots of areas for fighting and sarcophuguses";
	$DisList::Count = 293;
	$DisList::Name[293] = "rmrsirastrialp1";
	$DisList::Desc[293] = "the blue maze";
	$DisList::Count = 294;
	$DisList::Name[294] = "rmrsirastrialp2";
	$DisList::Desc[294] = "end of blue maze, goes down to the crack to hell";
	$DisList::Count = 295;
	$DisList::Name[295] = "rmrscenery";
	$DisList::Desc[295] = "";
	$DisList::Count = 296;
	$DisList::Name[296] = "rmrforestspike1";
	$DisList::Desc[296] = "base of tree tunk (sm)";
	$DisList::Count = 297;
	$DisList::Name[297] = "rmrforestspike2";
	$DisList::Desc[297] = "base of tree tunk (md)";
	$DisList::Count = 298;
	$DisList::Name[298] = "rmrforestspike3";
	$DisList::Desc[298] = "base of tree tunk (lg)";
	$DisList::Count = 299;
	$DisList::Name[299] = "rmrpinetrees";
	$DisList::Desc[299] = "multiple triangulkar pine trees";
	$DisList::Count = 300;
	$DisList::Name[300] = "rmrthings1";
	$DisList::Desc[300] = "";
	$DisList::Count = 301;
	$DisList::Name[301] = "rmrwindmill";
	$DisList::Desc[301] = "";
	$DisList::Count = 302;
	$DisList::Name[302] = "rmrtowns";
	$DisList::Desc[302] = "";
	$DisList::Count = 303;
	$DisList::Name[303] = "rmrrinvale";
	$DisList::Desc[303] = "";
	$DisList::Count = 304;
	$DisList::Name[304] = "rmrringate";
	$DisList::Desc[304] = "";
	$DisList::Count = 305;
	$DisList::Name[305] = "rmr7thheaven";
	$DisList::Desc[305] = "";
	$DisList::Count = 306;
	$DisList::Name[306] = "rmrrinvalefinal";
	$DisList::Desc[306] = "";
	$DisList::Count = 307;
	$DisList::Name[307] = "rmrmayorhouse";
	$DisList::Desc[307] = "";
	$DisList::Count = 308;
	$DisList::Name[308] = "rmrshildrasinn";
	$DisList::Desc[308] = "";
	$DisList::Count = 309;
	$DisList::Name[309] = "rmrhousing";
	$DisList::Desc[309] = "";
	$DisList::Count = 310;
	$DisList::Name[310] = "rmrsuntemplefinal";
	$DisList::Desc[310] = "cool temple that looks to be the entrance to maybe some of the other temple pieces around";
	$DisList::Count = 311;
	$DisList::Name[311] = "rmrcliffhouse";
	$DisList::Desc[311] = "";
	$DisList::Count = 312;
	$DisList::Name[312] = "rmrtombstone";
	$DisList::Desc[312] = "";
	$DisList::Count = 313;
	$DisList::Name[313] = "rmrgooba";
	$DisList::Desc[313] = "thius is where we go from rmrbloodpart3revised I thinbk?";
	$DisList::Count = 314;
	$DisList::Name[314] = "rmrgoobap2";
	$DisList::Desc[314] = "This is what leads to the blue maze I think!";
	$DisList::Count = 315;
	$DisList::Name[315] = "masamunefinal";
	$DisList::Desc[315] = "the big sword";
	$DisList::Count = 316;
	$DisList::Name[316] = "rmrtree";
	$DisList::Desc[316] = "";
	$DisList::Count = 317;
	$DisList::Name[317] = "rmrburialtree";
	$DisList::Desc[317] = "seems to be the top of the first rmr dungeon";
	$DisList::Count = 318;
	$DisList::Name[318] = "rmrwdungs";
	$DisList::Desc[318] = "";
	$DisList::Count = 319;
	$DisList::Name[319] = "gden";
	$DisList::Desc[319] = "";
	$DisList::Count = 320;
	$DisList::Name[320] = "gdenfinal";
	$DisList::Desc[320] = "";
	$DisList::Count = 321;
	$DisList::Name[321] = "eyelair";
	$DisList::Desc[321] = "";
	$DisList::Count = 322;
	$DisList::Name[322] = "uuagden";
	$DisList::Desc[322] = "";
	$DisList::Count = 323;
	$DisList::Name[323] = "rmrwabshelter";
	$DisList::Desc[323] = "";
	$DisList::Count = 324;
	$DisList::Name[324] = "rmrwtester";
	$DisList::Desc[324] = "";
	$DisList::Count = 325;
	$DisList::Name[325] = "marosaruinstester";
	$DisList::Desc[325] = "";
	$DisList::Count = 326;
	$DisList::Name[326] = "rmtemple";
	$DisList::Desc[326] = "";
	$DisList::Count = 327;
	$DisList::Name[327] = "losttempletop";
	$DisList::Desc[327] = "";
	$DisList::Count = 328;
	$DisList::Name[328] = "losttemplepart1";
	$DisList::Desc[328] = "";
	$DisList::Count = 329;
	$DisList::Name[329] = "losttemplepart2";
	$DisList::Desc[329] = "";
	$DisList::Count = 330;
	$DisList::Name[330] = "losttemplepart3";
	$DisList::Desc[330] = "";
	$DisList::Count = 331;
	$DisList::Name[331] = "losttemplepart4";
	$DisList::Desc[331] = "";
	$DisList::Count = 332;
	$DisList::Name[332] = "RPGcastle";
	$DisList::Desc[332] = "";
	$DisList::Count = 333;
	$DisList::Name[333] = "castle";
	$DisList::Desc[333] = "";
	$DisList::Count = 334;
	$DisList::Name[334] = "keep";
	$DisList::Desc[334] = "";
	$DisList::Count = 335;
	$DisList::Name[335] = "RPGshapes";
	$DisList::Desc[335] = "";
	$DisList::Count = 336;
	$DisList::Name[336] = "woodchair";
	$DisList::Desc[336] = "";
	$DisList::Count = 337;
	$DisList::Name[337] = "table";
	$DisList::Desc[337] = "";
	$DisList::Count = 338;
	$DisList::Name[338] = "roundtable";
	$DisList::Desc[338] = "";
	$DisList::Count = 339;
	$DisList::Name[339] = "sign";
	$DisList::Desc[339] = "";
	$DisList::Count = 340;
	$DisList::Name[340] = "barstool";
	$DisList::Desc[340] = "";
	$DisList::Count = 341;
	$DisList::Name[341] = "stove";
	$DisList::Desc[341] = "";
	$DisList::Count = 342;
	$DisList::Name[342] = "cabinet1";
	$DisList::Desc[342] = "";
	$DisList::Count = 343;
	$DisList::Name[343] = "cabinet2";
	$DisList::Desc[343] = "";
	$DisList::Count = 344;
	$DisList::Name[344] = "bar";
	$DisList::Desc[344] = "";
	$DisList::Count = 345;
	$DisList::Name[345] = "tavern";
	$DisList::Desc[345] = "";
	$DisList::Count = 346;
	$DisList::Name[346] = "thecrypt";
	$DisList::Desc[346] = "";
	$DisList::Count = 347;
	$DisList::Name[347] = "house1";
	$DisList::Desc[347] = "";
	$DisList::Count = 348;
	$DisList::Name[348] = "store1";
	$DisList::Desc[348] = "";
	$DisList::Count = 349;
	$DisList::Name[349] = "bank1";
	$DisList::Desc[349] = "";
	$DisList::Count = 350;
	$DisList::Name[350] = "arena1";
	$DisList::Desc[350] = "";
	$DisList::Count = 351;
	$DisList::Name[351] = "ring";
	$DisList::Desc[351] = "";
	$DisList::Count = 352;
	$DisList::Name[352] = "desk";
	$DisList::Desc[352] = "";
	$DisList::Count = 353;
	$DisList::Name[353] = "bed";
	$DisList::Desc[353] = "";
	$DisList::Count = 354;
	$DisList::Name[354] = "lhouse";
	$DisList::Desc[354] = "";
	$DisList::Count = 355;
	$DisList::Name[355] = "fort";
	$DisList::Desc[355] = "";
	$DisList::Count = 356;
	$DisList::Name[356] = "easel";
	$DisList::Desc[356] = "";
	$DisList::Count = 357;
	$DisList::Name[357] = "Scenery";
	$DisList::Desc[357] = "";
	$DisList::Count = 358;
	$DisList::Name[358] = "trees1";
	$DisList::Desc[358] = "";
	$DisList::Count = 359;
	$DisList::Name[359] = "trees2";
	$DisList::Desc[359] = "";
	$DisList::Count = 360;
	$DisList::Name[360] = "trees3";
	$DisList::Desc[360] = "";
	$DisList::Count = 361;
	$DisList::Name[361] = "trees4";
	$DisList::Desc[361] = "";
	$DisList::Count = 362;
	$DisList::Name[362] = "cbuilding1";
	$DisList::Desc[362] = "";
	$DisList::Count = 363;
	$DisList::Name[363] = "hut1";
	$DisList::Desc[363] = "";
	$DisList::Count = 364;
	$DisList::Name[364] = "stree";
	$DisList::Desc[364] = "";
	$DisList::Count = 365;
	$DisList::Name[365] = "stree";
	$DisList::Desc[365] = "";
	$DisList::Count = 366;
	$DisList::Name[366] = "streeb";
	$DisList::Desc[366] = "";
	$DisList::Count = 367;
	$DisList::Name[367] = "streec";
	$DisList::Desc[367] = "";
	$DisList::Count = 368;
	$DisList::Name[368] = "streed";
	$DisList::Desc[368] = "";
	$DisList::Count = 369;
	$DisList::Name[369] = "streee";
	$DisList::Desc[369] = "";
	$DisList::Count = 370;
	$DisList::Name[370] = "town5";
	$DisList::Desc[370] = "";
	$DisList::Count = 371;
	$DisList::Name[371] = "tent";
	$DisList::Desc[371] = "";
	$DisList::Count = 372;
	$DisList::Name[372] = "towerf";
	$DisList::Desc[372] = "";
	$DisList::Count = 373;
	$DisList::Name[373] = "shildriklit";
	$DisList::Desc[373] = "";
	$DisList::Count = 374;
	$DisList::Name[374] = "edmire";
	$DisList::Desc[374] = "";
	$DisList::Count = 375;
	$DisList::Name[375] = "edmirelit";
	$DisList::Desc[375] = "";
	$DisList::Count = 376;
	$DisList::Name[376] = "edmire2lit";
	$DisList::Desc[376] = "";
	$DisList::Count = 377;
	$DisList::Name[377] = "townhouse";
	$DisList::Desc[377] = "";
	$DisList::Count = 378;
	$DisList::Name[378] = "koba";
	$DisList::Desc[378] = "";
	$DisList::Count = 379;
	$DisList::Name[379] = "newedmire";
	$DisList::Desc[379] = "";
	$DisList::Count = 380;
	$DisList::Name[380] = "cbar4";
	$DisList::Desc[380] = "";
	$DisList::Count = 381;
	$DisList::Name[381] = "gooba";
	$DisList::Desc[381] = "";
	$DisList::Count = 382;
	$DisList::Name[382] = "ctown";
	$DisList::Desc[382] = "";
	$DisList::Count = 383;
	$DisList::Name[383] = "newkoba";
	$DisList::Desc[383] = "";
	$DisList::Count = 384;
	$DisList::Name[384] = "kobastand";
	$DisList::Desc[384] = "";
	$DisList::Count = 385;
	$DisList::Name[385] = "arrowsign";
	$DisList::Desc[385] = "";
	$DisList::Count = 386;
	$DisList::Name[386] = "looklook";
	$DisList::Desc[386] = "";
	$DisList::Count = 387;
	$DisList::Name[387] = "telebox";
	$DisList::Desc[387] = "";
	$DisList::Count = 388;
	$DisList::Name[388] = "telebox2";
	$DisList::Desc[388] = "";
	$DisList::Count = 389;
	$DisList::Name[389] = "carcarchee";
	$DisList::Desc[389] = "";
	$DisList::Count = 390;
	$DisList::Name[390] = "neobridge1";
	$DisList::Desc[390] = "";
	$DisList::Count = 391;
	$DisList::Name[391] = "goblinhouse";
	$DisList::Desc[391] = "";
	$DisList::Count = 392;
	$DisList::Name[392] = "milburnewalls1final";
	$DisList::Desc[392] = "";
	$DisList::Count = 393;
	$DisList::Name[393] = "milburnewalls2final";
	$DisList::Desc[393] = "";
	$DisList::Count = 394;
	$DisList::Name[394] = "cruins1final";
	$DisList::Desc[394] = "";
	$DisList::Count = 395;
	$DisList::Name[395] = "cruins2final";
	$DisList::Desc[395] = "";
	$DisList::Count = 396;
	$DisList::Name[396] = "cruins3final";
	$DisList::Desc[396] = "";
	$DisList::Count = 397;
	$DisList::Name[397] = "cswordfinal";
	$DisList::Desc[397] = "";
	$DisList::Count = 398;
	$DisList::Name[398] = "rmcasterstowerfinal";
	$DisList::Desc[398] = "";
	$DisList::Count = 399;
	$DisList::Name[399] = "undeadresearch";
	$DisList::Desc[399] = "";
	$DisList::Count = 400;
	$DisList::Name[400] = "walk01";
	$DisList::Desc[400] = "";
	$DisList::Count = 401;
	$DisList::Name[401] = "walk02";
	$DisList::Desc[401] = "";
	$DisList::Count = 402;
	$DisList::Name[402] = "walk03";
	$DisList::Desc[402] = "";
	$DisList::Count = 403;
	$DisList::Name[403] = "walk04";
	$DisList::Desc[403] = "";
	$DisList::Count = 404;
	$DisList::Name[404] = "walk05";
	$DisList::Desc[404] = "";
	$DisList::Count = 405;
	$DisList::Name[405] = "walk06";
	$DisList::Desc[405] = "";
	$DisList::Count = 406;
	$DisList::Name[406] = "walk07";
	$DisList::Desc[406] = "";
	$DisList::Count = 407;
	$DisList::Name[407] = "basetree";
	$DisList::Desc[407] = "";
	$DisList::Count = 408;
	$DisList::Name[408] = "bookshelf";
	$DisList::Desc[408] = "";
	$DisList::Count = 409;
	$DisList::Name[409] = "cow";
	$DisList::Desc[409] = "";
	$DisList::Count = 410;
	$DisList::Name[410] = "sb";
	$DisList::Desc[410] = "";
	$DisList::Count = 411;
	$DisList::Name[411] = "sbl";
	$DisList::Desc[411] = "";
	$DisList::Count = 412;
	$DisList::Name[412] = "walkcabin";
	$DisList::Desc[412] = "";
	$DisList::Count = 413;
	$DisList::Name[413] = "walkhome";
	$DisList::Desc[413] = "";
	$DisList::Count = 414;
	$DisList::Name[414] = "walkmind";
	$DisList::Desc[414] = "";
	$DisList::Count = 415;
	$DisList::Name[415] = "walkringsmall";
	$DisList::Desc[415] = "";
	$DisList::Count = 416;
	$DisList::Name[416] = "walkringmed";
	$DisList::Desc[416] = "";
	$DisList::Count = 417;
	$DisList::Name[417] = "walkringlarge";
	$DisList::Desc[417] = "";
	$DisList::Count = 418;
	$DisList::Name[418] = "walkringxl";
	$DisList::Desc[418] = "";
	$DisList::Count = 419;
	$DisList::Name[419] = "windmill";
	$DisList::Desc[419] = "";
	$DisList::Count = 420;
	$DisList::Name[420] = "watchtower";
	$DisList::Desc[420] = "";
	$DisList::Count = 421;
	$DisList::Name[421] = "well";
	$DisList::Desc[421] = "";
	$DisList::Count = 422;
	$DisList::Name[422] = "wharf";
	$DisList::Desc[422] = "";
	$DisList::Count = 423;
	$DisList::Name[423] = "wizaint9";
	$DisList::Desc[423] = "";
	$DisList::Count = 424;
}

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

function DisStartPlaceMode(%clientId, %objectId) {
	if(fetchData(%clientId, "DisPlaceMode") == 1)
		return;
	if(%objectId == "" || %objectId == 0)
		return;

	%player = Client::getOwnedObject(%clientId);
	if(%player == -1)
		return;

	storeData(%clientId, "DisPlaceMode", 1);
	$disPlaceObject[%clientId] = %objectId;
	$disPlaceRot[%clientId] = getWord(GameBase::getRotation(%objectId), 2);
	$disPlaceLockPos[%clientId] = "";

	Client::sendMessage(%clientId, 2, "Moving object. Type #placedis when you are done.");
	DisPlaceModeLoop(%clientId);
}

function DisPlaceModeLoop(%clientId) {
	if(fetchData(%clientId, "DisPlaceMode") != 1)
		return;

	%object = $disPlaceObject[%clientId];
	%player = Client::getOwnedObject(%clientId);
	if(%object == "" || %object == 0 || %player == -1)
		return;

	if($disPlaceLockPos[%clientId] != "") {
		%pos = $disPlaceLockPos[%clientId];
		%obj = "";
	} else if(GameBase::getLOSinfo(%player, 1000)) {
		%pos = $los::position;
		%obj = $los::object;
	} else {
		%pos = "";
		%obj = "";
	}

	if(%pos != "" && (%obj == "" || (%obj != %object && getObjectType(%obj) != "Player"))) {
		GameBase::setPosition(%object, %pos);
		if($disPlaceRot[%clientId] != "")
			GameBase::setRotation(%object, "0 0 " @ $disPlaceRot[%clientId]);
	}

	schedule("DisPlaceModeLoop(" @ %clientId @ ");", 0.2);
}

function DisEndPlaceMode(%clientId) {
	if(fetchData(%clientId, "DisPlaceMode") != 1)
		return;

	%object = $disPlaceObject[%clientId];
	if(%object != "" && %object != 0) {
		%objectPos = GameBase::getPosition(%object);
		Client::sendMessage(%clientId, 2, "Object placed at position " @ %objectPos @ ".");
	}

	storeData(%clientId, "DisPlaceMode", 0);
	$disPlaceObject[%clientId] = "";
	$disPlaceRot[%clientId] = "";
	$disPlaceLockPos[%clientId] = "";
}

function DisStartRotateMode(%clientId, %objectId) {
	if(fetchData(%clientId, "DisRotateMode") == 1)
		return;
	if(%objectId == "" || %objectId == 0)
		return;

	%player = Client::getOwnedObject(%clientId);
	if(%player == -1)
		return;

	storeData(%clientId, "DisRotateMode", 1);
	$disRotateObject[%clientId] = %objectId;
	$disRotateLastPos[%clientId] = GameBase::getPosition(%player);
	$disRotateRot[%clientId] = getWord(GameBase::getRotation(%objectId), 2);

	Client::sendMessage(%clientId, 2, "Rotate mode started. Move to rotate, type #rotatedis again to stop.");
	DisRotateModeLoop(%clientId);
}

function DisRotateModeLoop(%clientId) {
	if(fetchData(%clientId, "DisRotateMode") != 1)
		return;

	%object = $disRotateObject[%clientId];
	%player = Client::getOwnedObject(%clientId);
	if(%object == "" || %object == 0 || %player == -1)
		return;

	%currentPos = GameBase::getPosition(%player);
	%lastPos = $disRotateLastPos[%clientId];
	%dx = getWord(%currentPos, 0) - getWord(%lastPos, 0);
	%dy = getWord(%currentPos, 1) - getWord(%lastPos, 1);
	%delta = (%dx + %dy) * 0.5;

	if(%delta > 5) %delta = 5;
	if(%delta < -5) %delta = -5;

	if(%delta != 0) {
		$disRotateRot[%clientId] = $disRotateRot[%clientId] + %delta;
		GameBase::setRotation(%object, "0 0 " @ $disRotateRot[%clientId]);
	}

	$disRotateLastPos[%clientId] = %currentPos;
	schedule("DisRotateModeLoop(" @ %clientId @ ");", 0.2);
}

function DisEndRotateMode(%clientId) {
	if(fetchData(%clientId, "DisRotateMode") != 1)
		return;

	storeData(%clientId, "DisRotateMode", 0);
	$disRotateObject[%clientId] = "";
	$disRotateLastPos[%clientId] = "";
	$disRotateRot[%clientId] = "";
	Client::sendMessage(%clientId, 2, "Rotate mode ended.");
}

function DisStartMoveZMode(%clientId, %objectId) {
	if(fetchData(%clientId, "DisMoveZMode") == 1)
		return;
	if(%objectId == "" || %objectId == 0)
		return;

	%player = Client::getOwnedObject(%clientId);
	if(%player == -1)
		return;

	storeData(%clientId, "DisMoveZMode", 1);
	$disMoveZObject[%clientId] = %objectId;
	$disMoveZLastPos[%clientId] = GameBase::getPosition(%player);

	Client::sendMessage(%clientId, 2, "Move Z mode started. Move to adjust height, type #movedisz again to stop.");
	DisMoveZModeLoop(%clientId);
}

function DisMoveZModeLoop(%clientId) {
	if(fetchData(%clientId, "DisMoveZMode") != 1)
		return;

	%object = $disMoveZObject[%clientId];
	%player = Client::getOwnedObject(%clientId);
	if(%object == "" || %object == 0 || %player == -1)
		return;

	%currentPos = GameBase::getPosition(%player);
	%lastPos = $disMoveZLastPos[%clientId];
	%dx = getWord(%currentPos, 0) - getWord(%lastPos, 0);
	%dy = getWord(%currentPos, 1) - getWord(%lastPos, 1);
	%deadzone = 0.05;
	if(mAbs(%dx) < %deadzone) %dx = 0;
	if(mAbs(%dy) < %deadzone) %dy = 0;
	%delta = (%dx + %dy) * 0.5;

	if(%delta > 5) %delta = 5;
	if(%delta < -5) %delta = -5;

	if(%delta != 0) {
		%objPos = GameBase::getPosition(%object);
		%newZ = getWord(%objPos, 2) + %delta;
		GameBase::setPosition(%object, getWord(%objPos, 0) @ " " @ getWord(%objPos, 1) @ " " @ %newZ);
	}

	$disMoveZLastPos[%clientId] = %currentPos;
	schedule("DisMoveZModeLoop(" @ %clientId @ ");", 0.2);
}

function DisEndMoveZMode(%clientId) {
	if(fetchData(%clientId, "DisMoveZMode") != 1)
		return;

	storeData(%clientId, "DisMoveZMode", 0);
	$disMoveZObject[%clientId] = "";
	$disMoveZLastPos[%clientId] = "";
	Client::sendMessage(%clientId, 2, "Move Z mode ended.");
}

function DisStartMoveXYMode(%clientId, %objectId) {
	if(fetchData(%clientId, "DisMoveXYMode") == 1)
		return;
	if(%objectId == "" || %objectId == 0)
		return;

	%player = Client::getOwnedObject(%clientId);
	if(%player == -1)
		return;

	storeData(%clientId, "DisMoveXYMode", 1);
	$disMoveXYObject[%clientId] = %objectId;
	$disMoveXYLastPos[%clientId] = GameBase::getPosition(%player);

	Client::sendMessage(%clientId, 2, "Move XY mode started. Move to adjust position, type #movedisxy again to stop.");
	DisMoveXYModeLoop(%clientId);
}

function DisMoveXYModeLoop(%clientId) {
	if(fetchData(%clientId, "DisMoveXYMode") != 1)
		return;

	%object = $disMoveXYObject[%clientId];
	%player = Client::getOwnedObject(%clientId);
	if(%object == "" || %object == 0 || %player == -1)
		return;

	%currentPos = GameBase::getPosition(%player);
	%lastPos = $disMoveXYLastPos[%clientId];
	%dx = getWord(%currentPos, 0) - getWord(%lastPos, 0);
	%dy = getWord(%currentPos, 1) - getWord(%lastPos, 1);
	%deadzone = 0.05;
	if(mAbs(%dx) < %deadzone) %dx = 0;
	if(mAbs(%dy) < %deadzone) %dy = 0;

	if(%dx != 0 || %dy != 0) {
		%objPos = GameBase::getPosition(%object);
		%newX = getWord(%objPos, 0) + %dx;
		%newY = getWord(%objPos, 1) + %dy;
		GameBase::setPosition(%object, %newX @ " " @ %newY @ " " @ getWord(%objPos, 2));
	}

	$disMoveXYLastPos[%clientId] = %currentPos;
	schedule("DisMoveXYModeLoop(" @ %clientId @ ");", 0.2);
}

function DisEndMoveXYMode(%clientId) {
	if(fetchData(%clientId, "DisMoveXYMode") != 1)
		return;

	storeData(%clientId, "DisMoveXYMode", 0);
	$disMoveXYObject[%clientId] = "";
	$disMoveXYLastPos[%clientId] = "";
	Client::sendMessage(%clientId, 2, "Move XY mode ended.");
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
        %itemName = %home.name;
        if ($beltitem[%itemName, "isHousingItem"]) {
            Belt::GiveThisStuff(%clientId, %itemName, 1);
        } else {
            %shape = %home.shape;
            if (%shape == "")
                %shape = $tagToObjectShape[%clientId @ "_home"];
            if (String::findSubStr(%shape, ".dis") != -1)
                %shape = String::replace(%shape, ".dis", "");
            if (%shape != "")
                Belt::GiveThisStuff(%clientId, $Housing::itemName["home", %shape], 1);
        }
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
        %itemName = %old.name;
        if ($beltitem[%itemName, "isHousingItem"]) {
            Belt::GiveThisStuff(%clientId, %itemName, 1);
        } else {
            %shape = %old.shape;
            if (%shape == "")
                %shape = $tagToObjectShape[%clientId @ "_homeitem_" @ %slot];
            if (String::findSubStr(%shape, ".dis") != -1)
                %shape = String::replace(%shape, ".dis", "");
            if (%shape != "")
                Belt::GiveThisStuff(%clientId, $Housing::itemName["homeitem", %shape], 1);
        }
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
    if ($Housing::itemName[%housingType, %shape] == "")
        $Housing::itemName[%housingType, %shape] = %itemName;
    BeltItem::Add(%displayName, %itemName, "HousingItems", %weight, %cost, "", %shopIndex);
    $beltitem[%itemName, "isHousingItem"] = True;
    $beltitem[%itemName, "housingType"] = %housingType;
    $beltitem[%itemName, "shape"] = %shape;
    $beltitem[%itemName, "reusable"] = True;
}

function Housing::AddShrineDef(%displayName, %itemName, %weight, %cost, %shopIndex, %bonus, %ticks) {
	Housing::AddItemDef("homeitem", "endtable", %displayName, %itemName, %weight, %cost, %shopIndex);
	$Housing::shrineBonus[%itemName] = %bonus;
	$Housing::shrineTicks[%itemName] = %ticks;
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

	// Buff shrines (1260+)
	Housing::AddShrineDef("Lesser Shrine of Strength I", "LesserShrineStrengthI", 20, 3000, 1260, "ATK 25", 1800);
	Housing::AddShrineDef("Shrine of Strength II", "ShrineStrengthII", 25, 6000, 1261, "ATK 50", 1800);
	Housing::AddShrineDef("Greater Shrine of Strength III", "GreaterShrineStrengthIII", 30, 9000, 1262, "ATK 100", 1800);

	Housing::AddShrineDef("Lesser Shrine of Defense I", "LesserShrineDefenseI", 20, 3000, 1263, "DEF 25", 1800);
	Housing::AddShrineDef("Shrine of Defense II", "ShrineDefenseII", 25, 6000, 1264, "DEF 50", 1800);
	Housing::AddShrineDef("Greater Shrine of Defense III", "GreaterShrineDefenseIII", 30, 9000, 1265, "DEF 100", 1800);

	Housing::AddShrineDef("Lesser Shrine of Warding I", "LesserShrineWardingI", 20, 3000, 1266, "MDEF 25", 1800);
	Housing::AddShrineDef("Shrine of Warding II", "ShrineWardingII", 25, 6000, 1267, "MDEF 50", 1800);
	Housing::AddShrineDef("Greater Shrine of Warding III", "GreaterShrineWardingIII", 30, 9000, 1268, "MDEF 100", 1800);

	Housing::AddShrineDef("Lesser Shrine of Vitality I", "LesserShrineVitalityI", 20, 3000, 1269, "MaxHP 25", 1800);
	Housing::AddShrineDef("Shrine of Vitality II", "ShrineVitalityII", 25, 6000, 1270, "MaxHP 50", 1800);
	Housing::AddShrineDef("Greater Shrine of Vitality III", "GreaterShrineVitalityIII", 30, 9000, 1271, "MaxHP 100", 1800);

	Housing::AddShrineDef("Lesser Shrine of Focus I", "LesserShrineFocusI", 20, 3000, 1272, "MaxMANA 25", 1800);
	Housing::AddShrineDef("Shrine of Focus II", "ShrineFocusII", 25, 6000, 1273, "MaxMANA 50", 1800);
	Housing::AddShrineDef("Greater Shrine of Focus III", "GreaterShrineFocusIII", 30, 9000, 1274, "MaxMANA 100", 1800);

	Housing::AddShrineDef("Lesser Shrine of Capacity I", "LesserShrineCapacityI", 20, 3000, 1275, "MaxWeight 25", 1800);
	Housing::AddShrineDef("Shrine of Capacity II", "ShrineCapacityII", 25, 6000, 1276, "MaxWeight 50", 1800);
	Housing::AddShrineDef("Greater Shrine of Capacity III", "GreaterShrineCapacityIII", 30, 9000, 1277, "MaxWeight 100", 1800);
}
