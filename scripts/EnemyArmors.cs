//This file is part of Tribes RPG.
//Tribes RPG server side scripts
//Written by Jason "phantom" Daley,  Matthiew "JeremyIrons" Bouchard, and more (yet undetermined)

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

$Server::teamName[0] = "Citizen";
$Server::teamSkin[0] = "rpghuman"; // rpgbase, new: rpghuman, RMSkins1

$Server::teamName[1] = "Enemy";
$Server::teamSkin[1] = "RMSkins2";

$Server::teamName[2] = "Greenskins";
$Server::teamSkin[2] = "RMSkins1"; // RMSkins3 - RMSkins2 - rpgorc (was RMSkins1)

$Server::teamName[3] = "Gnoll";
$Server::teamSkin[3] = "rpggnoll";

$Server::teamName[4] = "Undead";
$Server::teamSkin[4] = "undead";

$Server::teamName[5] = "Elf";
$Server::teamSkin[5] = "rpgelf";

$Server::teamName[6] = "Magical Beasts"; // Minotaur
$Server::teamSkin[6] = "RMSkins3";

$Server::teamName[7] = "Uber";
$Server::teamSkin[7] = "fedmonster";

// Skin Information
// = Light Armor =

// = Medium =
// duke - all black with red eyes - very spooky and cool for dark areas
// GreenGnoll (Pink/Red/Yellow) - Gnoll skin with green (color) shirt
// RedDemon - Read skin with less facial detail
// XenoDemon - Purple skin with less facial detail
// undead - Orange skin with good facial detail
// RMSkins1 - gnoll
// RMSkins2 - mole looking weird thing
// RMSkins3 - creepy stone demon? or cyborg? (metal / stone)
// RMSkins4 - Brown earthy pure dirt
// skquid - all black with yellow eyes, same as duke
// adtnight2 - Dark knight wth red eyes in mask
// CoK - Undead death knight
// death - Undead black unholy knight with symbol (gray)
// deathinc - Black undead knight with symbol and green eyes
// dg - Amazon looking male human with muscles
// dstar3 - kinda like dg, but blue and weird mask
// ObsidianOrder - Black dsword like with purple eyes
// osb - Dark obs order like knight with flames (Flame Knight)?
// predator - all black with white mask, weird looking thing
// rpgorc - The regular orc model
// spawn - It's spawn
// tef/tef2 - boba fet looking green/yellow
// widowmaker - dark black knight with red symbol on chest
// ws - armored barbarian with claw marks on chest

// = OgreArmor =
// RMSkins1 - Brown earthy look
// RMSkins2 - Blue with eyeballs all over
// RMSkins3 - Red with eyeballs all over
// RMSkins4 - Brown earthy but broken looking
// Duke - Cool looking DOOM like monster
// skquid - Dark black with white trim metal monster with anarchy sign on chest

// spawn - looks like Spawn the demon hero
// TEF - Green cyborg thing (almost boba fett like)
// TEF2 - Yellow version of TEF
// templar - White and Black knight with red head
// tkk - Blue golem monster kinda cyborgish
// widomaker - creepy dark cyborg with red symbol on chest
// southpark - Cartman
// predator - Dark black with white mask
// deathinc - same as skquid, dark black body with skull
// death - same as skquid but lighter gray, good for diff variations
// CoK - kind of a big zombier knight thing


//------------------------------

$NameForRace[generic] = "MaleHuman";
$NameForRace[merchant] = "MaleHuman";
$NameForRace[banker] = "MaleHuman";
$NameForRace[assassin] = "MaleHuman";
$NameForRace[mage] = "MaleHuman";
$NameForRace[porter] = "FemaleHuman";
$NameForRace[manager] = "MaleHuman";

$NameForRace[Thug] = "Traveller";
$NameForRace[Monk] = "Traveller";
$NameForRace[Miner] = "Traveller";
$NameForRace[Commoner] = "Traveller";
$NameForRace[Mercenary] = "Traveller";
$NameForRace[Militia] = "Traveller";

// travellers den
$SkinForRace[Brigand] = "RMJerkilin"; // dynamic skin rendering
$SkinForRace[Marauder] = "RMJerkilinPlate"; // dynamic skin rendering
$SkinForRace[Knight] = "rpgringmail"; // dynamic skin rendering
$SkinForRace[BlackMage] = "robeblue"; // dynamic skin rendering

$NameForRace[GoblinRunt] = "Goblin";
$NameForRace[GoblinThief] = "Goblin";
$NameForRace[GoblinWizard] = "Goblin";
$NameForRace[GoblinRaider] = "Goblin";

$NameForRace[GnollPup] = "Gnoll";
$NameForRace[GnollShaman] = "Gnoll";
$NameForRace[GnollScavenger] = "Gnoll";
$NameForRace[GnollHunter] = "Gnoll";

$NameForRace[OrcWarlock] = "Orc";
$SkinForRace[OrcWarlock] = "rpgorc";
$NameForRace[OrcBerserker] = "Orc";
$SkinForRace[OrcBerserker] = "rpgorc";
$NameForRace[OrcRavager] = "Orc";
$SkinForRace[OrcRavager] = "rpgorc";
$NameForRace[OrcSlayer] = "Orc";
$SkinForRace[OrcSlayer] = "rpgorc";

// mythril mines
$NameForRace[OgreRuffian] = "Ogre";
$SkinForRace[DraOgreRuffianiner] = "undead";
$NameForRace[OgreDestroyer] = "Ogre";
$SkinForRace[OgreDestroyer] = "undead";
$NameForRace[OgreHalberdier] = "Ogre";
$SkinForRace[OgreHalberdier] = "undead";
$NameForRace[OgreDreadnought] = "Ogre";
$SkinForRace[OgreDreadnought] = "undead";
$NameForRace[OgreMagi] = "Ogre";
$SkinForRace[OgreMagi] = "undead";
$NameForRace[OgreHellion] = "Ogre";
$SkinForRace[OgreHellion] = "death";
$NameForRace[OgreDemon] = "Ogre";
$SkinForRace[OgreDemon] = "death";
$NameForRace[OgreNecromancer] = "Ogre";
$SkinForRace[OgreNecromancer] = "death";

$NameForRace[ZombieMauler] = "Zombie";
$NameForRace[ZombieThrasher] = "Zombie";
$NameForRace[UndeadSkeleton] = "Undead";
$NameForRace[UndeadNecromancer] = "Undead";
$NameForRace[DemonSpawn] = "Demon";

// shinra mansion
$NameForRace[Shambler] = "Wight";
$SkinForRace[Shambler] = "RMSkins2";
$NameForRace[ShadowDemon] = "Shadow";
$SkinForRace[ShadowDemon] = "duke";
$NameForRace[ShadowFiend] = "Shadow";
$SkinForRace[ShadowFiend] = "duke";
$NameForRace[Drainer] = "CacoDemon";
$SkinForRace[Drainer] = "skquid";

$NameForRace[Protector] = "MaleElf";
$NameForRace[Peacekeeper] = "MaleElf";
$NameForRace[Lord] = "MaleElf";
$NameForRace[Champion] = "MaleElf";
$NameForRace[Conjurer] = "FemaleElf";

$NameForRace[Civilian] = "MaleHuman";
$NameForRace[Gladiator] = "MaleHuman";

$NameForRace[Goliath] = "Minotaur";
$SkinForRace[Goliath] = "RMSkins2";
$NameForRace[Reaper] = "Minotaur";
$SkinForRace[Reaper] = "RMSkins2";
$NameForRace[Charger] = "Minotaur";
$SkinForRace[Charger] = "RMSkins2";
$NameForRace[Smasher] = "Minotaur";
$SkinForRace[Smasher] = "RMSkins2";

$NameForRace[Sloth] = "Uber";
$NameForRace[Gohort] = "Uber";

$NameForRace[Acolyte] = "Cultist";
$SkinForRace[Acolyte] = "robeblack"; // dynamic skin rendering
$NameForRace[Doomsayer] = "Cultist";
$SkinForRace[Doomsayer] = "RMSkins3"; // dynamic skin rendering

// New Races
$NameForRace[Spiderling] = "Spider";
$NameForRace[Huntsman] = "Spider";
$NameForRace[BrownRecluse] = "Spider";
$NameForRace[BlackWidow] = "Spider";

$NameForRace[CaveBat] = "Bat";
$NameForRace[MateriaBat] = "Bat";

$NameForRace[MateriaBear] = "Bear";

// dunegan crypt
$NameForRace[ZombieCorpse] = "Zombie";
$NameForRace[ZombieWalker] = "Zombie";
$NameForRace[UndeadRattler] = "Undead";
$NameForRace[UndeadMagician] = "Undead";

// upper dunegan
$NameForRace[ShinraGoon] = "Shinra";
$SkinForRace[ShinraGoon] = "SWAT";
$NameForRace[ShinraGrunt] = "Shinra";
$SkinForRace[ShinraGrunt] = "SWAT";
$NameForRace[ShinraInfantry] = "Shinra";
$SkinForRace[ShinraInfantry] = "SWAT";

// Bloodan Stratum
$NameForRace[ShinraTrooper] = "Shinra";
$SkinForRace[ShinraTrooper] = "SWAT";
$NameForRace[ShinraOfficer] = "Shinra";
$SkinForRace[ShinraOfficer] = "SWAT";
$NameForRace[ShinraSergeant] = "Shinra";
$SkinForRace[ShinraSergeant] = "SWAT";

// TBD
$NameForRace[ShinraTurk] = "Shinra";
$SkinForRace[ShinraTurk] = "SWAT"; // change this
$NameForRace[ShinraSoldier3] = "Shinra";
$SkinForRace[ShinraSoldier3] = "SWAT";  // change this
$NameForRace[ShinraSoldier2] = "Shinra";  // change this
$SkinForRace[ShinraSoldier2] = "SWAT";  // change this
$NameForRace[ShinraSoldier1] = "Shinra";
$SkinForRace[ShinraSoldier1] = "SWAT";  // change this

// lower stratum
$NameForRace[DemonImp] = "Demon";
$NameForRace[DemonRunt] = "Demon";
$NameForRace[DemonCaster] = "Demon";

// howling earth
$NameForRace[UberWhelp] = "Uber";
$SkinForRace[UberCrusher] = "duke";
$NameForRace[UberCrusher] = "Uber";
$SkinForRace[UberCrusher] = "duke";
$NameForRace[UberElemantalist] = "Uber";
$SkinForRace[UberElemantalist] = "duke";

// catacombs
$NameForRace[HorrorDemon] = "Daemon";
$NameForRace[NightmareDemon] = "Daemon";

// Humaine Society
$NameForRace[Abomination] = "Godeye";
$SkinForRace[Abomination] = "RMSkins2";  // change this

// Center of World
$NameForRace[Whelp] = "Dragon";

// Materia Cave
$NameForRace[AcidMateriaSlime] = "Slime";
$SkinForRace[AcidMateriaSlime] = "RMSkins4";

// Lower Heaven
$NameForRace[OgreMagi] = "Ogre";

// Lower Obsidian Mines
$NameForRace[CyclopsAbomination] = "Cyclops";
$SkinForRace[CyclopsAbomination] = "RMSkins2";

$NameForRace[CyclopsObscenity] = "Cyclops";
$SkinForRace[CyclopsObscenity] = "RMSkins3";

// Obsidian Mines Shaft
$NameForRace[ObsidianKnight] = "HornedKnight";
$SkinForRace[ObsidianKnight] = "adtnight2";
$NameForRace[ObsidianBerserker] = "HornedKnight";
$SkinForRace[ObsidianBerserker] = "adtnight2";
$NameForRace[ObsidianChanter] = "HornedKnight";
$SkinForRace[ObsidianChanter] = "adtnight2";

// Temple of Ancients
$NameForRace[TempleCultist] = "Cultist";
$SkinForRace[TempleCultist] = "dg";
$NameForRace[TempleDefender] = "Cultist";
$SkinForRace[TempleDefender] = "dg";
$NameForRace[TempleAcolyte] = "Cultist";
$SkinForRace[TempleAcolyte] = "dg";

$NameForRace[TempleBerserker] = "CultistAbomination";
$SkinForRace[TempleBerserker] = "dg";

$NameForRace[TempleGiant] = "CultistGiant";
$SkinForRace[TempleGiant] = "dg";
$NameForRace[TempleWarlock] = "CultistGiant";
$SkinForRace[TempleWarlock] = "dg";

// Reactor 1
$NameForRace[FailedExperiment] = "Wight";
$SkinForRace[FailedExperiment] = "RMSkins2";
$NameForRace[TorturedExperiment] = "Wight";
$SkinForRace[TorturedExperiment] = "RMSkins2";

// Reactor 2
$NameForRace[MechSoldier] = "Mech";
$SkinForRace[MechSoldier] = "TKK";
$NameForRace[MechBeamer] = "Mech";
$SkinForRace[MechBeamer] = "TKK";

// Reactor 4
$NameForRace[FireDragon] = "Dragon";
$NameForRace[MoltenDragon] = "Dragon";

// -------------- armor data ------------------

$ArmorTypeToRace[TravellerArmor] = "Traveller";
$ArmorTypeToRace[GoblinArmor] = "Goblin"; // GoblinArmor // TestArmor
$ArmorTypeToRace[GnollArmor] = "Gnoll";
$ArmorTypeToRace[OrcArmor] = "Orc";
$ArmorTypeToRace[OgreArmor] = "Ogre";
$ArmorTypeToRace[UndeadArmor] = "Undead";
$ArmorTypeToRace[MaleElfArmor] = "MaleElf";
$ArmorTypeToRace[FemaleElfArmor] = "FemaleElf";
$ArmorTypeToRace[NewMinoArmor] = "Minotaur"; // MinotaurArmor
$ArmorTypeToRace[UberArmor] = "Uber";
$ArmorTypeToRace[ZombieArmor] = "Zombie";
$ArmorTypeToRace[DemonArmor] = "Demon";
$ArmorTypeToRace[CultistArmor] = "Cultist";
$ArmorTypeToRace[SpiderArmor] = "Spider";
$ArmorTypeToRace[ShinraArmor] = "Shinra";
$ArmorTypeToRace[SDaemonArmor] = "Daemon";
$ArmorTypeToRace[DragonArmor] = "Dragon";
$ArmorTypeToRace[GodeyeArmor] = "Godeye";
$ArmorTypeToRace[RMZombieArmor] = "Wight";
$ArmorTypeToRace[NewMinoArmor] = "Shadow";
$ArmorTypeToRace[FloatingHeadArmor] = "CacoDemon";
$ArmorTypeToRace[BlobMonsterArmor] = "Slime";
$ArmorTypeToRace[BatArmor] = "Bat";
$ArmorTypeToRace[BearArmor] = "Bear";
$ArmorTypeToRace[NewMinoArmor] = "HornedKnight";
$ArmorTypeToRace[OrcArmor] = "CultistAbomination";
$ArmorTypeToRace[OgreArmorFast] = "Mech";

$RaceToArmorType[Goblin] = "GoblinArmor"; // GoblinArmor // TestArmor
$RaceToArmorType[Gnoll] = "GnollArmor";
$RaceToArmorType[Orc] = "OrcArmor";
$RaceToArmorType[Ogre] = "OgreArmor";
$RaceToArmorType[Undead] = "UndeadArmor";
$RaceToArmorType[Traveller] = "TravellerArmor";
$RaceToArmorType[MaleElf] = "MaleElfArmor";
$RaceToArmorType[FemaleElf] = "FemaleElfArmor";
$RaceToArmorType[Minotaur] = "NewMinoArmor";
$RaceToArmorType[Uber] = "UberArmor";
$RaceToArmorType[Zombie] = "ZombieArmor";
$RaceToArmorType[Demon] = "DemonArmor";
$RaceToArmorType[Cultist] = "CultistArmor";
$RaceToArmorType[Spider] = "SpiderArmor";
$RaceToArmorType[Shinra] = "ShinraArmor";
$RaceToArmorType[Daemon] = "SDaemonArmor";
$RaceToArmorType[Dragon] = "DragonArmor";
$RaceToArmorType[Godeye] = "GodeyeArmor";
$RaceToArmorType[Wight] = "RMZombieArmor";
$RaceToArmorType[Shadow] = "NewMinoArmor";
$RaceToArmorType[CacoDemon] = "FloatingHeadArmor";
$RaceToArmorType[Slime] = "BlobMonsterArmor";
$RaceToArmorType[Bat] = "BatArmor";
$RaceToArmorType[Bear] = "BearArmor";
$RaceToArmorType[Cyclops] = "OgreArmor";
$RaceToArmorType[HornedKnight] = "NewMinoArmor";
$RaceToArmorType[CultistAbomination] = "OrcArmor";
$RaceToArmorType[CultistGiant] = "OgreArmor";
$RaceToArmorType[Mech] = "OgreArmorFast";

$RaceToNamesList[Traveller] = "Alphonse Cedric Lucian Darius Leontius Gregor Matthias Silvain Emeric Veyron Hadrian Tobias Valens Octavian Magnus Raphael Victor Alistair Remiel Lysander Cassian Garrick Percival Thaddeus Gideon Theodric Isidore Cornelius Reginald Leofric Oswald Baldwin Edric Ronan Severin Aldous Soren Valentin Leopold Desmond Eustace Corbin Ignatius Bertram Seraphim Maximus Felix Quentin Roderic Atticus Nicodemus Zephyrus Aurelius Fabian Tiberius Evander Cormac Orion Vesper Drystan Cassius Lazarus Marcellus Gideon Tarquin Lucan Zephiel Oberon Tristam Aurelian Myron Edgar Nathaniel Augustus Hector Vespasian Sirus Caliban Damian Cyprian Theron Alaric Thelonius Ulrich Galen Phineas Anselm Varian Valmont Bastien Xavier Leoric Simeon Zephyr Darian Florian Armand Hadrianus Orestes Fenrir Gael Romulus Malachai Noctis Thalric Eamon Belisarius Callum Solon";
$RaceToNamesList[Goblin] = "Griknak Snaggit Borgul Zrogg Ruknash Dribbik Murgul Vrogg Tazgul Skarnak Drekz Broggit Klurg Snibbit Vraggo Trognash Glubnik Grizzik Nobnash Krognar Zraggit Blornik Snaggul Throgg Klibbit Drizzik Grobnar Vraknash Trogzit Borknash Graknik Zlubb Knorvik Drizzgul Trognik Krabnash Glubzit Morzik Zorknash Broggul Tarnik Flibbit Skragnak Zriggo Krobnash Vrixik Drobbit Skrognar Blaggit Truznik Frobnash Skribbit Klorgnak Vrobnash Gribzik Traknor Zlibbit Knarzik Frozgul Skraknit Grozzik Triggan Zorblik Broggar Trogzit Kribzik Slorbag Vragbit Gronbit Trasknak Zroblik Klibzit Kragnik Blibbit Driznash Skornak Froggit Trigblik Zrumblik Krobzit Snorggul Thragbit Glibnash Skragzit Draknor Vrobbit Zrobnik Snibnash Frakgul Triznak Grobnash Blugbit Kraznik Snibzit Trombit Skrubnik Grubzit Vorblik Zlagbit Kroggul Tragnor Blornash";
$RaceToNamesList[Gnoll] = "Grathak Vrognash Brakkan Thrognir Skrallik Droggar Vrekkul Brashnak Krallgor Zrathik Gnarzuk Throbbik Zraggul Bralkin Skorvik Trakkul Grothik Vrunzak Drallik Snorvik Krathul Vroggar Brakzul Thurnik Zlarkash Gorrik Thraggul Skrunnak Zrokkal Braskir Thalzok Drukkal Skorgrim Vrozgul Brazzik Trathgar Zrikkul Grashnok Thrubnik Drozzar Skarnul Bragnir Throzzik Skrithar Gorrak Zruknal Brathik Skrozzar Krannok Thurlik Zlabrak Skraggir Thalrik Vrugnal Brakkir Skrolgar Drognik Zralkur Gronvik Thralzak Skorrik Krathnik Thruzzal Vrathik Braknor Skralgor Zroggar Grizzar Thrazkul Skrallik Dralkor Snarlik Vrogmir Bragnok Throzzul Skrelzak Krashnal Thurlgar Zlakkir Gralzik Throkal Skrugnal Bronnak Thrandik Zlarvik Skarzuk Gruthik Thronzak Skragnor Brullik Thraznok Zlargul Skorthak Gronnak Thraknal Skrilzak Krulgor Throzgal Zrokkin Skrallak Grunvik Thrazkir Zlurkal";
$RaceToNamesList[Orc] = "Gorgrim Thrakul Drogmar Kraghol Urzok Brokkar Varnak Gorlash Drathul Zogrim Krulgar Bralzuk Throgar Skurnak Vorgul Gralnok Druzzik Thralgor Bruknar Zurnok Grashul Throznak Vrokkar Dranlok Korgash Thragzul Skargrin Bralnok Vrognar Drakzul Thurzog Krollik Gronmak Drozgul Skarnok Bruthar Vrogzul Kragnir Thrukmar Gorzak Drannok Skrulgar Broznar Krashgul Throlgar Vruzok Drogkul Gruthmar Skolgar Bruthok Thrazzul Korrak Dromgar Skorzak Bruknal Throznik Vronzul Dralkmar Skarnul Gronnir Thalzuk Krolgar Brathok Droznik Skrallmar Vurnok Granzak Throggul Kralkmar Bruthnok Dorzak Skragnar Vrozzok Druthar Skolnok Bragnok Throlzuk Korrnal Drakkar Skornak Vurzul Gralzok Throllik Krulnok Brozmar Skrulnok Vrozgul Dralkir Skothmar Brakkal Throznir Korgnal Drogzak Skrulgor Vrolnik Druthok Skurnir Brullok Thrazgar Krashnok Brozzik Skorgrim Vrokkal Dronzik Skarnik";
$RaceToNamesList[Ogre] = "Gulmok Brathul Vorgak Drozgar Krugnar Thromak Zogthar Brakzul Drunmok Thorgash Vrognok Gralzak Krallgor Thrumok Zarnok Grozthul Drakmok Skarnul Vrothok Brukkal Thalzok Gorvok Druzgal Skothok Bralgar Krugmok Throlzar Zograk Druthnok Gralkar Skruznak Vorgrak Bruthmok Throznal Krullgar Gronmok Skarzok Druzzak Throkkul Bragnar Skulnok Vronmak Krashgar Draknok Skruthok Bralnok Grulmar Throggar Vuznok Dorgul Skragnar Krulgar Braknok Thorzal Grullok Skrulmok Vrozmar Drakkul Skurnok Brulzar Thoggar Kroznik Brulmak Skorzak Gruthok Thrognok Krashgul Drogmok Skragnar Vrothul Dranmak Skurzak Brakkor Thoznal Kruzgar Brulkul Skolgar Groznak Thalkor Krulmar Drozgul Skurthok Vronzak Drathmok Skaggul Bruthok Thalgar Kruzmak Brulgor Skovnok Grulzak Throzzik Krozmok Druthul Skornok Bruthnar Thalzul Korgmok Dranlok Skorvok";
$RaceToNamesList[Undead] = "";
$RaceToNamesList[MaleElf] = "";
$RaceToNamesList[FemaleElf] = "";
$RaceToNamesList[Minotaur] = "";
$RaceToNamesList[Uber] = "Nyogthar Ulzhaeth Kharzolth Yogthun Varnethis Quorlax Xazhul Ithgorak Zhulmor Ylzaroth Nothquor Grulzekh Thonvyr Ilzarak Qulmaroth Drexhul Zhaegoth Umbryxar Phalthoz Azkareth Vulzorin Drunethis Khaegmor Zazhaloth Inzyrok Galthurak Cthyvron Volquarth Shabrekh Orzalneth Uryzgar Kholmeth Zuthlaroth Elgothar Thrauzhul Zorthulak Vreznor Ixolmar Ubrakhel Zarnuqoth Alzavun Gralgorith Krenzuth Umlakar Shaznoroth Ulgvyrak Qazhulon Nurnvek Izquorth Velgarok Ghorniloth Drelzumar Phazgothon Yalzureth Iggaroth Kzharvun Xelthurog Grulnazor Zaurmoth Enquoraz Zulqenoth Xurvaloth Noqtharil Kelzharoth Azruneth Cthelvok Quorvakth Uruveloth Nalkarth Yuvrakhal Vornuzeth Khralmogar Jhazhorin Xirvethul Drunqaroth Althuvak Orzguloth Halvyran Ylquoraz Nothgaroth Phrezhalun Quzaroth Urzynak Velqthul Iggthazor Draqulvek Uthnorak Zalqumor Khurnuveth Zalvorgoth Xavreloth Qornilak Drolvethis Uzgarolth Nezrakar Khalzethun Yzraloth Gharxuloth Volgruneth";
$RaceToNamesList[Zombie] = "";
$RaceToNamesList[Demon] = "Azgorth Malphas Vezreth Drokan Ygzor Kelvax Thamior Brakzul Onreth Skarvox Durnak Xelmor Ravzek Trigor Valthor Zarneth Quoril Nazgoth Umbrak Krymzor Balzor Ignaroth Zulketh Morgash Felbrak Gorthax Dravun Helkor Kurneth Zethar Vornak Thrakul Dalgor Belzrak Xurvon Nemtar Dravok Jolzeth Arkamon Valmorth Nexigar Zulthar Orgrak Kraznor Flamgoth Urmoth Ralkesh Zorvak Tremoth Yalgrun Makzor Kroval Duzgar Belneth Falthor Xarvek Gralnax Izkarn Vezmor Quarnak Mordeth Glavorn Zalgrim Bryzok Kurnath Dorvax Zulmor Klaveth Ravnok Blazgul Korgash Ulgor Morgrak Truzeth Dalkor Ignarth Skelvor Branthor Duzvek Valthak Azroth Helgar Zulgron Malvek Gravor Torkhul Krethor Xalthor Drakzor Kraveth Jolgar Vurzok Grenthul Flamvor Ralzeth Ulgarth Nexzor Zolmok Volgrun Graveth Skornak Droxun Tarnoth Krevak Malgar Blazkor Grallor Velzeth";
// $RaceToNamesList[Cultist] = "";
$RaceToNamesList[Spider] = "";

// $RaceToNamesList[Dragon] = "Emberwing Frostscale Nightflame Stormclaw Shadowfire Blazeclaw Thunderwing";
$spawnIndex[2] = "banker";
$spawnIndex[3] = "assassin";
$spawnIndex[4] = "mage";
$spawnIndex[5] = "engineer";
$spawnIndex[6] = "elder";
$spawnIndex[8] = "porter";
$spawnIndex[10] = "manager";

$spawnIndex[11] = "Thug";
$spawnIndex[12] = "Monk";
$spawnIndex[13] = "Miner";
$spawnIndex[14] = "Commoner";

$spawnIndex[15] = "GoblinRunt";
$spawnIndex[16] = "GoblinThief";
$spawnIndex[17] = "GoblinWizard";
$spawnIndex[18] = "GoblinRaider";

$spawnIndex[19] = "GnollPup";
$spawnIndex[20] = "GnollShaman";
$spawnIndex[21] = "GnollScavenger";
$spawnIndex[22] = "GnollHunter";

$spawnIndex[23] = "OrcWarlock";
$spawnIndex[24] = "OrcBerserker";
$spawnIndex[25] = "OrcRavager";
$spawnIndex[26] = "OrcSlayer";

$spawnIndex[27] = "OgreRuffian";
$spawnIndex[28] = "OgreDestroyer";
$spawnIndex[29] = "OgreHalberdier";
$spawnIndex[30] = "OgreDreadnought";

$spawnIndex[31] = "ZombieMauler";
$spawnIndex[32] = "ZombieThrasher";
$spawnIndex[33] = "UndeadSkeleton";
$spawnIndex[34] = "UndeadNecromancer";

$spawnIndex[35] = "Protector";
$spawnIndex[36] = "Peacekeeper";
$spawnIndex[37] = "Lord";
$spawnIndex[38] = "Champion";

$spawnIndex[39] = "Brigand";
$spawnIndex[40] = "Marauder";
$spawnIndex[41] = "Knight";
$spawnIndex[42] = "BlackMage";

$spawnIndex[43] = "Civilian";
$spawnIndex[44] = "Gladiator";
$spawnIndex[45] = "Mercenary";
$spawnIndex[46] = "Militia";

$spawnIndex[47] = "Goliath";
$spawnIndex[48] = "Reaper";

$spawnIndex[49] = "Sloth";
$spawnIndex[50] = "Gohort";

$spawnIndex[51] = "Conjurer";
$spawnIndex[52] = "OgreMagi";

$spawnIndex[53] = "DemonSpawn";

$spawnIndex[54] = "Acolyte";
$spawnIndex[55] = "Doomsayer";

$spawnIndex[56] = "Spiderling";
$spawnIndex[57] = "Huntsman";
$spawnIndex[58] = "BrownRecluse";
$spawnIndex[59] = "BlackWidow";

$spawnIndex[60] = "ShinraGoon";
$spawnIndex[61] = "ShinraGrunt";
$spawnIndex[62] = "ShinraInfantry";
$spawnIndex[63] = "ShinraTrooper";
$spawnIndex[64] = "ShinraOfficer";
$spawnIndex[65] = "ShinraSergeant";
$spawnIndex[66] = "ShinraTurk";
$spawnIndex[67] = "ShinraSoldier3";
$spawnIndex[68] = "ShinraSoldier2";
$spawnIndex[69] = "ShinraSoldier1";

$spawnIndex[70] = "ZombieCorpse";
$spawnIndex[71] = "ZombieWalker";
$spawnIndex[72] = "UndeadRattler";
$spawnIndex[73] = "UndeadMagician";

$spawnIndex[74] = "Charger";
$spawnIndex[75] = "Smasher";

$spawnIndex[76] = "DemonImp";
$spawnIndex[77] = "DemonRunt";
$spawnIndex[78] = "DemonCaster";

$spawnIndex[79] = "UberWhelp";
$spawnIndex[80] = "UberCrusher";
$spawnIndex[81] = "UberElemantalist";

$spawnIndex[82] = "HorrorDemon";
$spawnIndex[83] = "NightmareDemon";

$spawnIndex[84] = "Whelp";

$spawnIndex[85] = "Abomination";

$spawnIndex[86] = "Shambler";

$spawnIndex[87] = "ShadowDemon";

$spawnIndex[88] = "Drainer";

$spawnIndex[89] = "AcidMateriaSlime";

$spawnIndex[90] = "CaveBat";
$spawnIndex[91] = "MateriaBat";

$spawnIndex[92] = "MateriaBear";

$spawnIndex[93] = "OgreHellion";
$spawnIndex[94] = "OgreDemon";
$spawnIndex[95] = "OgreNecromancer";

$spawnIndex[96] = "ShadowFiend";

$spawnIndex[97] = "CyclopsAbomination";
$spawnIndex[98] = "CyclopsObscenity";

$spawnIndex[99] = "ObsidianKnight";
$spawnIndex[100] = "ObsidianBerserker";
$spawnIndex[101] = "ObsidianChanter";

$spawnIndex[102] = "TempleCultist";
$spawnIndex[103] = "TempleDefender";
$spawnIndex[104] = "TempleAcolyte";

$spawnIndex[105] = "TempleBerserker";

$spawnIndex[106] = "TempleGiant";
$spawnIndex[107] = "TempleWarlock";

$spawnIndex[108] = "FailedExperiment";
$spawnIndex[109] = "TorturedExperiment";

$spawnIndex[110] = "MechSoldier";
$spawnIndex[111] = "MechBeamer";

$spawnIndex[112] = "FireDragon";
$spawnIndex[113] = "MoltenDragon";
//------------------------------

// range looks like: RShortBow 1 BasicArrow 20/50
//
// Drop Rate Formula: "ItemName Amount/-X"
// The formula calculates: %r = floor(getRandom() * (100+X)) - X + 1
// Item drops when %r >= 0, giving approximately (101/(100+X))% chance
//
// Common drop rate values:
//   75% chance: Amount/-35   (e.g., "SpiderFang 2/-35")
//   50% chance: Amount/-100  (e.g., "SpiderFang 2/-100")
//   25% chance: Amount/-300  (e.g., "SpiderFang 2/-300")
//   10% chance: Amount/-910  (e.g., "SpiderFang 2/-910")
//    5% chance: Amount/-1920 (e.g., "SpiderFang 2/-1920")
//    1% chance: Amount/-10000 (e.g., "SpiderFang 2/-10000")
//
// Note: When item drops, amount ranges from 0 to Amount (weighted toward lower values)

%defaultAlchemyDropsI = "HealingHerb 5/-200 VialOfWater 3/-200 BombCore 3/-200 CrackedFlask 3/-200";
%defaultAlchemyDropsII = "HealingHerb 5/-200 VialOfWater 3/-200 MaidensTear 3/-200 TonberryOil 3/-400 WornGlassVial 3/-200";
%defaultAlchemyDropsIII = "HealingHerb 5/-200 Sylphroot 2/-200 VialOfWater 3/-200 BehemothHornFragment 3/-200 ReinforcedAlchemistsBottle 3/-200 ChocoboFeather 3/-800";
%defaultAlchemyDropsIV = "HealingHerb 5/-200 Sylphroot 3/-200 VialOfWater 3/-200 MalboroSporeSac 3/-200 ArcaneCrystalPhial 3/-200 ChocoboFeather 3/-400";
%defaultAlchemyDropsV = "HealingHerb 5/-200 Sylphroot 5/-200 VialOfWater 3/-200 MalboroSporeSac 3/-200 EtherealStasisFlask 3/-200 ChocoboFeather 3/-200";

$BotEquipment[GoblinRunt] = 	"CLASS Enemy LVL 2+1 COINS 1/50 ChippedDagger 1 Quartz 4/-300 FireMateriaI 1/-2000 " @ %defaultAlchemyDropsI;
$BotEquipment[EliteGoblinRunt] = "LVL 4+2 Quartz 5/-250 FireMateriaII 1/-1800 " @ %defaultAlchemyDropsI;
$BotEquipment[GoblinThief] = 	"CLASS Enemy LVL 5+2 COINS 3/50 Sling 1 SmallRock 20/50 BlackStatue 1/-100 FireMateriaI 1/-1800 " @ %defaultAlchemyDropsI;
$BotEquipment[EliteGoblinThief] = "LVL 10+4 BlackStatue 1/-75 FireMateriaII 1/-1600 " @ %defaultAlchemyDropsI;
$BotEquipment[GoblinWizard] = 	"CLASS Enemy LVL 9+2 COINS 5/50 CastingBlade 1 FireMateriaI 1/-1650 "  @ %defaultAlchemyDropsI; // 1/-500
$BotEquipment[EliteGoblinWizard] = "LVL 18+4 FireMateriaII 1/-1500 " @ %defaultAlchemyDropsI;
$BotEquipment[GoblinRaider] = 	"CLASS Enemy LVL 11+3 COINS 4/50 WarpedClub 1 BlackStatue 1/-150 Jade 1/-300 FireMateriaI 1/-1500 " @ %defaultAlchemyDropsI;
$BotEquipment[EliteGoblinRaider] = "LVL 22+6 BlackStatue 1/-100 Jade 1/-250 FireMateriaII 1/-1300 " @ %defaultAlchemyDropsI;

$BotEquipment[GnollPup] = 		"CLASS Enemy LVL 10+3 COINS 6/50 ShatteredBoneClub 1 Potion 1 Ruby 1/-2000 FireMateriaI 1/-1500 " @ %defaultAlchemyDropsI;
$BotEquipment[EliteGnollPup] = 	"LVL 20+6 Ruby 2/-1500 FireMateriaII 1/-1300 " @ %defaultAlchemyDropsI;
$BotEquipment[GnollShaman] = 	"CLASS Enemy LVL 12+3 COINS 7/50 CastingBlade 1 FireMateriaI 1/-1400 " @ %defaultAlchemyDropsI;
$BotEquipment[EliteGnollShaman] = "LVL 24+6 FireMateriaII 1/-1200 " @ %defaultAlchemyDropsI;
$BotEquipment[GnollScavenger] = 	"CLASS Enemy LVL 15+3 COINS 8/50 ShatteredBoneClub 1 Sapphire 2/-5000 FireMateriaI 1/-1250 " @ %defaultAlchemyDropsI;
$BotEquipment[EliteGnollScavenger] = "LVL 30+6 Sapphire 3/-4000 FireMateriaII 1/-1000 " @ %defaultAlchemyDropsI;
$BotEquipment[GnollHunter] = 	"CLASS Enemy LVL 17+3 COINS 9/50 RustyShank 1 Sling 1 SmallRock 20/50 Topaz 3/-3000 FireMateriaI 1/-1000 " @ %defaultAlchemyDropsI;
$BotEquipment[EliteGnollHunter] = "LVL 34+6 Topaz 4/-2500 FireMateriaII 1/-800 " @ %defaultAlchemyDropsI;

$BotEquipment[OrcWarlock] = 	"CLASS Enemy LVL 16+3 COINS 10/50 CastingBlade 1 Sling 1 SmallRock 20/50 EnchantedStone 1/-100 EarthMateriaI 1/-1500 " @ %defaultAlchemyDropsI;
$BotEquipment[EliteOrcWarlock] = "LVL 32+6 EnchantedStone 1/-75 EarthMateriaII 1/-1300 " @ %defaultAlchemyDropsI;
$BotEquipment[OrcBerserker] = 	"CLASS Enemy LVL 20+4 COINS 13/50 HandAxe 1 Topaz 4/-500 EarthMateriaI 1/-1500 " @ %defaultAlchemyDropsI;
$BotEquipment[EliteOrcBerserker] = "LVL 40+8 Topaz 5/-400 EarthMateriaII 1/-1200 " @ %defaultAlchemyDropsI;
$BotEquipment[OrcRavager] = 	"CLASS Enemy LVL 24+4 COINS 16/50 Club 1 Potion 3/30 Opal 4/-300 EarthMateriaI 1/-1500 " @ %defaultAlchemyDropsI;
$BotEquipment[EliteOrcRavager] = "LVL 48+8 Opal 5/-250 EarthMateriaII 1/-1000 " @ %defaultAlchemyDropsI;
$BotEquipment[OrcSlayer] = 	"CLASS Enemy LVL 28+4 COINS 19/50 Broadsword 1 BasicArrow 20/50 Opal 5/-250 EarthMateriaI 1/-1500 " @ %defaultAlchemyDropsI;
$BotEquipment[EliteOrcSlayer] = "LVL 56+8 Opal 6/-200 EarthMateriaII 1/-800 " @ %defaultAlchemyDropsI;

$BotEquipment[OgreRuffian] = 	"CLASS Enemy LVL 22+4 COINS 20/50 Club 1 Quartz 8/-200 EarthMateriaI 1/-1500 " @ %defaultAlchemyDropsII;
$BotEquipment[EliteOgreRuffian] = "LVL 44+8 Quartz 10/-150 EarthMateriaII 1/-1300 " @ %defaultAlchemyDropsII;
$BotEquipment[OgreDestroyer] = 	"CLASS Enemy LVL 27+4 COINS 23/50 HandAxe 1 EarthMateriaI 1/-1500 " @ %defaultAlchemyDropsII;
$BotEquipment[EliteOgreDestroyer] = "LVL 54+8 EarthMateriaII 1/-1200 " @ %defaultAlchemyDropsII;
$BotEquipment[OgreHalberdier] = "CLASS Enemy LVL 31+5 COINS 26/50 Broadsword 1 Potion 3/30 EarthMateriaI 1/-1500 " @ %defaultAlchemyDropsII;
$BotEquipment[EliteOgreHalberdier] = "LVL 62+10 EarthMateriaII 1/-1000 " @ %defaultAlchemyDropsII;
$BotEquipment[OgreDreadnought] = "CLASS Enemy LVL 36+5 COINS 29/50 WalkingStaff 1 BasicArrow 15/75 EarthMateriaI 1/-1500 " @ %defaultAlchemyDropsII;
$BotEquipment[EliteOgreDreadnought] = "LVL 72+10 EarthMateriaII 1/-800 " @ %defaultAlchemyDropsII;
$BotEquipment[OgreMagi] =		"CLASS Enemy LVL 42+6 COINS 50/50 CastingBlade 1 Emerald 1/-6000 Quartz 10/-200 EarthMateriaI 1/-1500 " @ %defaultAlchemyDropsII;
$BotEquipment[EliteOgreMagi] = 	"LVL 84+12 Emerald 1/-5000 Quartz 15/-150 EarthMateriaII 1/-700 " @ %defaultAlchemyDropsII;

$BotEquipment[ZombieMauler] = 	"CLASS Enemy LVL 45/50 COINS 20/50 SpikedClub 1 Granite 10/-300 PoisonMateriaI 1/-1500 " @ %defaultAlchemyDropsII;
$BotEquipment[EliteZombieMauler] = "LVL 90/50 Granite 15/-250 PoisonMateriaII 1/-1300 " @ %defaultAlchemyDropsII;
$BotEquipment[ZombieThrasher] =	"CLASS Enemy LVL 49/50 COINS 23/50 Axe 1 Opal 3/-300 PoisonMateriaI 1/-1500 " @ %defaultAlchemyDropsII;
$BotEquipment[EliteZombieThrasher] = "LVL 98/50 Opal 4/-250 PoisonMateriaII 1/-1200 " @ %defaultAlchemyDropsII;
$BotEquipment[UndeadSkeleton] = 	"CLASS Enemy LVL 54/50 COINS 26/50 Longsword 1 SkeletonBone 1/-250 Turquoise 4/-300 PoisonMateriaI 1/-1500 " @ %defaultAlchemyDropsIII;
$BotEquipment[EliteUndeadSkeleton] = "LVL 108/50 SkeletonBone 1/-200 Turquoise 5/-250 PoisonMateriaII 1/-1000 " @ %defaultAlchemyDropsIII;
$BotEquipment[UndeadNecromancer] = "CLASS Enemy LVL 61/50 COINS 29/50 CastingBlade 1 Sling 1 SmallRock 20/50 Diamond 1/-3000 PoisonMateriaI 1/-1500 " @ %defaultAlchemyDropsIII;
$BotEquipment[EliteUndeadNecromancer] = "LVL 122/50 Diamond 1/-2500 PoisonMateriaII 1/-800 " @ %defaultAlchemyDropsIII;
$BotEquipment[DemonSpawn] = 		"CLASS Enemy LVL 180/90 COINS 500/50 IronwoodStaff 1 Diamond 1/-1000 Emerald 1/-700 PoisonMateriaI 1/-1500 " @ %defaultAlchemyDropsIII;
$BotEquipment[EliteDemonSpawn] = 	"LVL 360/90 Diamond 1/-800 Emerald 1/-600 PoisonMateriaII 1/-700 " @ %defaultAlchemyDropsIII;

$BotEquipment[Protector] = 	"CLASS Enemy LVL 55/50 COINS 25/50 Mace 1 Ruby 2/-500 LightningMateriaI 1/-1500 " @ %defaultAlchemyDropsIII;
$BotEquipment[EliteProtector] = "LVL 110/50 Ruby 3/-400 LightningMateriaII 1/-1300 " @ %defaultAlchemyDropsIII;
$BotEquipment[Peacekeeper] = "CLASS Enemy LVL 57/50 COINS 28/50 HuntingSpear 1 SheafArrow 40/50 Jade 5/-500 LightningMateriaI 1/-1500 " @ %defaultAlchemyDropsIII;
$BotEquipment[ElitePeacekeeper] = "LVL 114/50 Jade 6/-400 LightningMateriaII 1/-1200 " @ %defaultAlchemyDropsIII;
$BotEquipment[Lord] = 		"CLASS Enemy LVL 59/50 COINS 31/50 BattleAxe 1 RLightCrossbow 1 LightQuarrel 25/75 Emerald 1/-2800 LightningMateriaI 1/-1500 " @ %defaultAlchemyDropsIII;
$BotEquipment[EliteLord] = 	"LVL 118/50 Emerald 1/-2500 LightningMateriaII 1/-1000 " @ %defaultAlchemyDropsIII;
$BotEquipment[Champion] = 	"CLASS Enemy LVL 63/50 COINS 34/50 IronSword 1 RLightCrossbow 1 HeavyQuarrel 25/75 Sapphire 3/-1000 LightningMateriaI 1/-1500 " @ %defaultAlchemyDropsIII;
$BotEquipment[EliteChampion] = "LVL 126/50 Sapphire 4/-800 LightningMateriaII 1/-800 " @ %defaultAlchemyDropsIII;
$BotEquipment[Conjurer] =	"CLASS Enemy LVL 70/50 COINS 32/50 CastingBlade 1 Topaz 2/-300 LightningMateriaI 1/-1500 " @ %defaultAlchemyDropsIII;
$BotEquipment[EliteConjurer] = 	"LVL 140/50 Topaz 3/-250 LightningMateriaII 1/-700 " @ %defaultAlchemyDropsIII;

$BotEquipment[Brigand] = 	"CLASS Enemy LVL 80/50 COINS 30/50 MythrilAxe 1 Sapphire 2/-3000 IceMateriaI 1/-1500 " @ %defaultAlchemyDropsIV;
$BotEquipment[Marauder] =	"CLASS Enemy LVL 80/50 COINS 33/50 IronHammer 1 Opal 4/-300 Turquoise 1/-800 IceMateriaI 1/-1500 " @ %defaultAlchemyDropsIV;
$BotEquipment[Knight] = 	"CLASS Enemy LVL 83/50 COINS 36/50 MythrilSword 1  SheafArrow 40/50 Jade 2/-600 IceMateriaI 1/-1500 " @ %defaultAlchemyDropsIV;
$BotEquipment[BlackMage] = 	"CLASS Enemy LVL 87/50 COINS 39/50 CastingBlade 1 Topaz 1/-300 IceMateriaI 1/-1500 " @ %defaultAlchemyDropsIV;

$BotEquipment[Civilian] = 	"CLASS Enemy LVL 1 COINS 5/50 ChippedDagger 1";
$BotEquipment[Gladiator] =	"CLASS Enemy LVL 1";
$BotEquipment[Mercenary] = 	"CLASS Enemy LVL 65/50 COINS 32/50 ChippedDagger 1";
$BotEquipment[Militia] = 	"CLASS Enemy LVL 75/50 COINS 35/50 ChippedDagger 1";

$BotEquipment[Thug] = 		"CLASS Enemy LVL 65/50 COINS 32/50 ChippedDagger 1 Jade 5/-500";
$BotEquipment[Miner] = 		"CLASS Enemy LVL 29/50 COINS 35/50 ChippedDagger 1 Parchment 1/-16000 Quartz 10/50 Opal 5/50 Turquoise 2/-50 Emerald 1/-1000";

$BotEquipment[Charger] = 	"CLASS Enemy LVL 33+4 COINS 70/50 IronSword 1 LightningMateriaI 1/-1500 " @ %defaultAlchemyDropsII;
$BotEquipment[EliteCharger] = "LVL 66+8 LightningMateriaII 1/-1300 " @ %defaultAlchemyDropsII;
$BotEquipment[Smasher] = 	"CLASS Enemy LVL 37+5 COINS 105/50 BattleAxe 1 Turquoise 5/-500 LightningMateriaI 1/-1500 " @ %defaultAlchemyDropsII;
$BotEquipment[EliteSmasher] = "LVL 74+10 Turquoise 6/-400 LightningMateriaII 1/-1200 " @ %defaultAlchemyDropsII;
$BotEquipment[Goliath] = 	"CLASS Enemy LVL 107/50 COINS 70/50 GiantAxe 1 LightningMateriaI 1/-1500 " @ %defaultAlchemyDropsV;
$BotEquipment[EliteGoliath] = 	"LVL 214/50 GiantAxe 1 LightningMateriaII 1/-1300 " @ %defaultAlchemyDropsV;
$BotEquipment[Reaper] = 	"CLASS Enemy LVL 174/50 COINS 105/50 CastingBlade 1 Turquoise 5/-500 LightningMateriaI 1/-1500 " @ %defaultAlchemyDropsV;
$BotEquipment[EliteReaper] = 	"LVL 348/50 Turquoise 6/-400 LightningMateriaII 1/-1200 " @ %defaultAlchemyDropsV;

$BotEquipment[Sloth] = 		"CLASS Enemy LVL 317/50 COINS 115/50 AncientSword 1 DragonScale 1/-3000 Gold 1/-1000 DarkMateriaI 1/-1500 " @ %defaultAlchemyDropsV;
$BotEquipment[EliteSloth] = 	"LVL 634/50 AncientSword 1 DragonScale 1/-2500 Gold 1/-800 DarkMateriaII 1/-1200 " @ %defaultAlchemyDropsV;
$BotEquipment[Gohort] = 	"CLASS Enemy LVL 527/50 COINS 135/50 CastingBlade 1 DragonScale 1/-300 Emerald 1/-1000 DarkMateriaI 1/-1500 " @ %defaultAlchemyDropsV;
$BotEquipment[EliteGohort] = 	"LVL 1054/50 CastingBlade 1 DragonScale 1/-250 Emerald 1/-800 DarkMateriaII 1/-1200 " @ %defaultAlchemyDropsV;

$BotEquipment[Acolyte] = 	"CLASS Enemy LVL 200+50 COINS 115/50 CultistBadge 1/-100 DiamondSword 1 DragonScale 1/-3000 Gold 1/-1000 DarkMateriaI 1/-1500";
$BotEquipment[EliteAcolyte] = 	"LVL 400+50 DiamondSword 1 DragonScale 1/-2500 Gold 1/-800 DarkMateriaII 1/-1200 ";
$BotEquipment[Doomsayer] = 	"CLASS Enemy LVL 250+50 COINS 135/50 CastingBlade 1 DragonScale 1/-300 CultistBadge 1/-100 Emerald 1/-1000 DarkMateriaI 1/-1500";
$BotEquipment[EliteDoomsayer] = 	"LVL 500+50 CastingBlade 1 DragonScale 1/-250 Emerald 1/-800 DarkMateriaII 1/-1200 ";

$BotEquipment[Spiderling] = "CLASS Enemy LVL 2+1 COINS 5/50 BeastClawI 1 PoisonMateriaI 1/-1000 SpiderFang 2/-100 " @ %defaultAlchemyDropsI;
$BotEquipment[EliteSpiderling] = "LVL 4+1 PoisonMateriaII 1/-1000";
$BotEquipment[Huntsman] = "CLASS Enemy LVL 5+2 COINS 10/50 BeastClawI 1 PoisonMateriaI 1/-1000 SpiderFang 2/-100 " @ %defaultAlchemyDropsI;
$BotEquipment[EliteHuntsman] = "LVL 10+2 PoisonMateriaII 1/-1000";
$BotEquipment[BrownRecluse] = "CLASS Enemy LVL 9+2 COINS 15/50 BeastClawV 1 PoisonMateriaI 1/-1000 SpiderFang 2/-100 SpiderVenom 1/-100 " @ %defaultAlchemyDropsI;
$BotEquipment[EliteBrownRecluse] = "LVL 18+4 PoisonMateriaII 1/-1000";
$BotEquipment[BlackWidow] = "CLASS Enemy LVL 11+3 COINS 20/50 BeastClawV 1 PoisonMateriaI 1/-1000 SpiderFang 2/-100 SpiderVenom 1/-100 " @ %defaultAlchemyDropsI;
$BotEquipment[EliteBlackWidow] = "LVL 22+4 PoisonMateriaII 1/-1000";

// write bot equipment for each shinra type, 3 should be grouped together at a time
// ex goose grunt infantry lvl 20 - 35, trooper officer sergeant 40 - 55, turk soldier3 soldier2 60 - 75, soldier1 shinra 80 - 90
// the + indicates the max +/- variance in level from the base level, this should get higher as the level increases but go no larger than 15%
$BotEquipment[ShinraGoon] = "CLASS Enemy LVL 10+2 COINS 20/50 Club 1 FireMateriaI 1/-800 MakoVial 1/-100 " @ %defaultAlchemyDropsI;
$BotEquipment[EliteShinraGoon] = "LVL 20+4 FireMateriaII 1/-800";
$BotEquipment[ShinraGrunt] = "CLASS Enemy LVL 15+3 COINS 23/50 HandAxe 1 FireMateriaI 1/-800 MakoVial 1/-100 " @ %defaultAlchemyDropsI;
$BotEquipment[EliteShinraGrunt] = "LVL 30+6 FireMateriaII 1/-800";
$BotEquipment[ShinraInfantry] = "CLASS Enemy LVL 20+3 COINS 26/50 Broadsword 1 FireMateriaI 1/-800 MakoVial 1/-100 " @ %defaultAlchemyDropsI;
$BotEquipment[EliteShinraInfantry] = "LVL 40+6 FireMateriaII 1/-800";

$BotEquipment[ShinraTrooper] = "CLASS Enemy LVL 41+4 COINS 29/50 IronHammer 1 FireMateriaI 1/-700 " @ %defaultAlchemyDropsII;
$BotEquipment[EliteShinraTrooper] = "LVL 82+8 FireMateriaII 1/-700";
$BotEquipment[ShinraOfficer] = "CLASS Enemy LVL 44+5 COINS 32/50 CastingBlade 1 FireMateriaI 1/-700 " @ %defaultAlchemyDropsII;
$BotEquipment[EliteShinraOfficer] = "LVL 88+10 FireMateriaII 1/-700";
$BotEquipment[ShinraSergeant] = "CLASS Enemy LVL 48+6 COINS 35/50 MythrilSword 1 FireMateriaI 1/-700 " @ %defaultAlchemyDropsII;
$BotEquipment[EliteShinraSergeant] = "LVL 96+12 FireMateriaII 1/-700";

$BotEquipment[ShinraTurk] = "CLASS Enemy LVL 50+3 COINS 38/50 ChippedDagger 1 FireMateriaI 1/-600 BombCore 10/-125 TonberryOil 1/-200 " @ %defaultAlchemyDropsIII;
$BotEquipment[EliteShinraTurk] = "LVL 100+10 FireMateriaII 1/-600 BombCore 10/-125 TonberryOil 1/-200";
$BotEquipment[ShinraSoldier3] = "CLASS Enemy LVL 95+7 COINS 41/50 ChippedDagger 1 FireMateriaI 1/-600 BombCore 10/-125 TonberryOil 1/-175 " @ %defaultAlchemyDropsIV;
$BotEquipment[EliteShinraSoldier3] = "LVL 190+14 FireMateriaII 1/-600 BombCore 10/-125 TonberryOil 1/-175";
$BotEquipment[ShinraSoldier2] = "CLASS Enemy LVL 100+8 COINS 44/50 ChippedDagger 1 FireMateriaI 1/-600 BombCore 10/-125 TonberryOil 1/-125 " @ %defaultAlchemyDropsIV;
$BotEquipment[EliteShinraSoldier2] = "LVL 200+16 FireMateriaII 1/-600 BombCore 10/-125 TonberryOil 1/-125";
$BotEquipment[ShinraSoldier1] = "CLASS Enemy LVL 105+10 COINS 47/50 ChippedDagger 1 FireMateriaI 1/-600 BombCore 10/-125 TonberryOil 1/-100 " @ %defaultAlchemyDropsV;
$BotEquipment[EliteShinraSoldier1] = "LVL 210+20 FireMateriaII 1/-600 BombCore 10/-125 TonberryOil 1/-100";

// dunega crypt bot equipment
$BotEquipment[ZombieCorpse] = "CLASS Enemy LVL 20+3 COINS 20/50 Club 1 Quartz 8/-200 IceMateriaI 1/-500 SkeletonBonePowder 1/-200 ZombieViscera 1/-35 WrigglyWorm 3/-100 " @ %defaultAlchemyDropsI;
$BotEquipment[EliteZombieCorpse] = "LVL 40+6 IceMateriaII 1/-500 SkeletonBonePowder 1/-200";
$BotEquipment[ZombieWalker] = "CLASS Enemy LVL 22+4 COINS 20/50 HandAxe 1 Quartz 8/-200 IceMateriaI 1/-500 SkeletonBonePowder 1/-175 ZombieViscera 1/-35 WrigglyWorm 3/-100 " @ %defaultAlchemyDropsI;
$BotEquipment[EliteZombieWalker] = "LVL 44+8 IceMateriaII 1/-500 SkeletonBonePowder 1/-175";
$BotEquipment[UndeadRattler] = "CLASS Enemy LVL 27+4 COINS 23/50 Broadsword 1 IceMateriaI 1/-500 SkeletonBonePowder 1/-125 WrigglyWorm 3/-100 " @ %defaultAlchemyDropsII;
$BotEquipment[EliteUndeadRattler] = "LVL 54+8 IceMateriaII 1/-500 SkeletonBonePowder 1/-125";
$BotEquipment[UndeadMagician] = "CLASS Enemy LVL 31+5 COINS 26/50 CastingBlade 1 IceMateriaI 1/-500 SkeletonBonePowder 1/-100 WrigglyWorm 3/-100 " @ %defaultAlchemyDropsII;
$BotEquipment[EliteUndeadMagician] = "LVL 62+10 IceMateriaII 1/-500 SkeletonBonePowder 1/-100";

$BotEquipment[DemonImp] = "CLASS Enemy LVL 50+5 COINS 23/50 Kodachi 1 Opal 3/-300 FireMateriaI 1/-400 ChimeraFlameGland 1/-200 " @ %defaultAlchemyDropsIII;
$BotEquipment[EliteDemonImp] = "LVL 100+10 FireMateriaII 1/-400 ChimeraFlameGland 1/-200";
$BotEquipment[DemonRunt] = "CLASS Enemy LVL 55+5 COINS 26/50 MythrilSword 1 SkeletonBone 1/-250 Turquoise 4/-300 FireMateriaI 1/-400 ChimeraFlameGland 1/-150 " @ %defaultAlchemyDropsIII;
$BotEquipment[EliteDemonRunt] = "LVL 110+10 FireMateriaII 1/-400 ChimeraFlameGland 1/-150";
$BotEquipment[DemonCaster] = "CLASS Enemy LVL 60+5 COINS 29/50 CastingBlade 1 Diamond 1/-3000 FireMateriaI 1/-400 ChimeraFlameGland 1/-100 " @ %defaultAlchemyDropsIII;
$BotEquipment[EliteDemonCaster] = "LVL 120+10 FireMateriaII 1/-400 ChimeraFlameGland 1/-100";

$BotEquipment[UberWhelp] = "CLASS Enemy LVL 65+5 COINS 23/50 CoralSword 1 Opal 3/-300 DarkMateriaI 1/-300 DarkMateriaII 1/-3000 BehemothHornFragment 1/-200 " @ %defaultAlchemyDropsIII;
$BotEquipment[EliteUberWhelp] = "LVL 130+10 DarkMateriaIII 1/-3000";
$BotEquipment[UberCrusher] = "CLASS Enemy LVL 75+6 COINS 26/50 GiantAxe 1 SkeletonBone 1/-250 Turquoise 4/-300 DarkMateriaI 1/-300 DarkMateriaII 1/-3000 BehemothHornFragment 1/-150 " @ %defaultAlchemyDropsIV;
$BotEquipment[EliteUberCrusher] = "LVL 150+12 DarkMateriaIII 1/-3000";
$BotEquipment[UberElemantalist] = "CLASS Enemy LVL 85+6 COINS 29/50 CastingBlade 1 Diamond 1/-3000 DarkMateriaI 1/-300 DarkMateriaII 1/-3000 BehemothHornFragment 1/-100 " @ %defaultAlchemyDropsIV;
$BotEquipment[EliteUberElemantalist] = "LVL 170+12 DarkMateriaIII 1/-3000";

$BotEquipment[HorrorDemon] = "CLASS Enemy LVL 90+5 COINS 23/50 BloodSword 1 Opal 3/-300 DarkMateriaI 1/-250 DarkMateriaII 1/-2500 AhrimanEyeLens 1/-150 " @ %defaultAlchemyDropsIV;
$BotEquipment[EliteHorrorDemon] = "LVL 180+10 DarkMateriaIII 1/-2500";
$BotEquipment[NightmareDemon] = "CLASS Enemy LVL 96+6 COINS 26/50 AncientAxe 1 SkeletonBone 1/-250 Turquoise 4/-250 DarkMateriaI 1/-250 DarkMateriaII 1/-2500 AhrimanEyeLens 1/-100 " @ %defaultAlchemyDropsIV;
$BotEquipment[EliteNightmareDemon] = "LVL 192+12 DarkMateriaIII 1/-2500";

$BotEquipment[Abomination] = "CLASS Enemy LVL 125+8 COINS 500/50 CastingBlade 1 PoisonMateriaI 1/-200 PoisonMateriaI 1/-2000 MalboroSporeSac 1/-100 " @ %defaultAlchemyDropsV;
$BotEquipment[EliteAbomination] = "LVL 250+16 PoisonMateriaII 1/-2000";

$BotEquipment[Whelp] = "CLASS Enemy LVL 150+10 COINS 1000/50 CastingBlade 1 FireMateriaI 1/-200 FireMateriaII 1/-2000 ChimeraFlameGland 1/-100 " @ %defaultAlchemyDropsV;
$BotEquipment[EliteWhelp] = "LVL 300+20 FireMateriaIII 1/-2000";

$BotEquipment[Shambler] = "CLASS Enemy LVL 200+50 COINS 115/50 DragonBoneClub 1 DarkMateriaII 1/-800 " @ %defaultAlchemyDropsV;
$BotEquipment[EliteShambler] = "LVL 400+100 DarkMateriaIII 1/-800";

$BotEquipment[ShadowDemon] = "CLASS Enemy LVL 250+50 COINS 115/50 SteelJavelin 1 DarkMateriaII 1/-500 " @ %defaultAlchemyDropsV;
$BotEquipment[EliteShadowDemon] = "LVL 500+100 DarkMateriaIII 1/-500";
$BotEquipment[ShadowFiend] = "CLASS Enemy LVL 300+50 COINS 115/50 CastingBlade 1 DarkMateriaII 1/-500 " @ %defaultAlchemyDropsV;
$BotEquipment[EliteShadowFiend] = "LVL 600+100 DarkMateriaIII 1/-500";

$BotEquipment[Drainer] = "CLASS Enemy LVL 350+50 COINS 115/50 CastingBlade 1 DarkMateriaII 1/-250 " @ %defaultAlchemyDropsV;
$BotEquipment[EliteDrainer] = "LVL 700+100 DarkMateriaIII 1/-250";

$BotEquipment[AcidMateriaSlime] = "CLASS Enemy LVL 375+75 COINS 11500/50 CastingBlade 1 PoisonMateriaII 1/-250 " @ %defaultAlchemyDropsV;
$BotEquipment[EliteAcidMateriaSlime] = "LVL 750+100 PoisonMateriaIII 1/-250";

$BotEquipment[CaveBat] = "CLASS Enemy LVL 10+3 COINS 11500/50 BeastClawI 1 PoisonMateriaI 1/-250 " @ %defaultAlchemyDropsI;
$BotEquipment[EliteCaveBat] = "LVL 20+5 PoisonMateriaII 1/-250";
$BotEquipment[MateriaBat] = "CLASS Enemy LVL 400+75 COINS 11500/50 BeastClawII 1 PoisonMateriaII 1/-250 " @ %defaultAlchemyDropsV;
$BotEquipment[EliteMateriaBat] = "LVL 800+100 PoisonMateriaIII 1/-250";
$BotEquipment[MateriaBear] = "CLASS Enemy LVL 400+75 COINS 11500/50 BeastClawII 1 IceMateriaII 1/-250 " @ %defaultAlchemyDropsV;
$BotEquipment[EliteMateriaBear] = "LVL 800+100 IceMateriaIII 1/-250";

$BotEquipment[OgreHellion] = "CLASS Enemy LVL 175+50 COINS 11500/50 DragonBoneClub 1 DarkMateriaII 1/-600 " @ %defaultAlchemyDropsV;
$BotEquipment[EliteOgreHellion] = "LVL 350+100 DarkMateriaIII 1/-600";
$BotEquipment[OgreDemon] = "CLASS Enemy LVL 225+50 COINS 11500/50 BloodSword 1 DarkMateriaII 1/-600 " @ %defaultAlchemyDropsV;
$BotEquipment[EliteOgreDemon] = "LVL 450+100 DarkMateriaIII 1/-600";
$BotEquipment[OgreNecromancer] = "CLASS Enemy LVL 200+50 COINS 11500/50 CastingBlade 1 DarkMateriaII 1/-600 " @ %defaultAlchemyDropsV;
$BotEquipment[EliteOgreNecromancer] = "LVL 400+100 DarkMateriaIII 1/-600";

// lower obsidan mines (lvl 350 - 450)
$BotEquipment[CyclopsAbomination] = "CLASS Enemy LVL 325+50 COINS 11500/50 AncientSword 1 FireMateriaII 1/-600 " @ %defaultAlchemyDropsV;
$BotEquipment[EliteCyclopsAbomination] = "LVL 650+100 FireMateriaIII 1/-600";
$BotEquipment[CyclopsObscenity] = "CLASS Enemy LVL 375+50 COINS 11500/50 CastingBlade 1 FireMateriaII 1/-600 " @ %defaultAlchemyDropsV;
$BotEquipment[EliteCyclopsObscenity] = "LVL 750+100 FireMateriaIII 1/-600";

// obsidian mines shaft
$BotEquipment[ObsidianKnight] = "CLASS Enemy LVL 400+50 COINS 11500/50 SleepBlade 1 IceMateriaII 1/-600 " @ %defaultAlchemyDropsV;
$BotEquipment[EliteObsidianKnight] = "LVL 800+100 IceMateriaIII 1/-600";
$BotEquipment[ObsidianChanter] = "CLASS Enemy LVL 450+50 COINS 11500/50 CastingBlade 1 IceMateriaII 1/-600 " @ %defaultAlchemyDropsV;
$BotEquipment[EliteObsidianChanter] = "LVL 900+100 IceMateriaIII 1/-600";
$BotEquipment[ObsidianBerserker] = "CLASS Enemy LVL 500+50 COINS 11500/50 Slasher 1 IceMateriaII 1/-600 " @ %defaultAlchemyDropsV;
$BotEquipment[EliteObsidianBerserker] = "LVL 1000+100 IceMateriaIII 1/-600";

// Upper ToA
$BotEquipment[TempleDefender] = "CLASS Enemy LVL 500+50 COINS 11500/50 HolyHammer 1 LightningMateriaII 1/-600 " @ %defaultAlchemyDropsV;
$BotEquipment[EliteTempleDefender] = "LVL 1000+100 LightningMateriaIII 1/-600";
$BotEquipment[TempleAcolyte] = "CLASS Enemy LVL 550+50 COINS 11500/50 CastingBlade 1 LightningMateriaII 1/-600 " @ %defaultAlchemyDropsV;
$BotEquipment[EliteTempleAcolyte] = "LVL 1100+100 LightningMateriaIII 1/-600";
$BotEquipment[TempleCultist] = "CLASS Enemy LVL 600+50 COINS 11500/50 Onimusha 1 CultistBadge 1/-150 LightningMateriaII 1/-600 " @ %defaultAlchemyDropsV;
$BotEquipment[EliteTempleCultist] = "LVL 1200+100 CultistBadge 1/-100 LightningMateriaIII 1/-600";

// Mid ToA
$BotEquipment[TempleBerserker] = "CLASS Enemy LVL 700+50 COINS 11500/50 DiamondAxe 1 LightningMateriaII 1/-600 " @ %defaultAlchemyDropsV;
$BotEquipment[EliteTempleBerserker] = "LVL 1400+150 LightningMateriaIII 1/-600";

// Lower ToA
$BotEquipment[TempleGiant] = "CLASS Enemy LVL 750+50 COINS 11500/50 GiantsHammer 1 LightningMateriaII 1/-600 " @ %defaultAlchemyDropsV;
$BotEquipment[EliteTempleGiant] = "LVL 1500+150 LightningMateriaIII 1/-600";
$BotEquipment[TempleWarlock] = "CLASS Enemy LVL 800+50 COINS 11500/50 CastingBlade 1 LightningMateriaII 1/-600 " @ %defaultAlchemyDropsV;
$BotEquipment[EliteTempleWarlock] = "LVL 1500+150 LightningMateriaIII 1/-600";

// Reactor 2
$BotEquipment[FailedExperiment] = "CLASS Enemy LVL 1000+100 COINS 11500/50 MagmaHammer 1 IceMateriaIII 1/-600 " @ %defaultAlchemyDropsV;
$BotEquipment[EliteFailedExperiment] = "LVL 2000+200 IceMateriaIV 1/-600";
$BotEquipment[TorturedExperiment] = "CLASS Enemy LVL 1000+100 COINS 11500/50 CastingBlade 1 IceMateriaIII 1/-600 " @ %defaultAlchemyDropsV;
$BotEquipment[EliteTorturedExperiment] = "LVL 2000+200 IceMateriaIV 1/-600";

// Reactor 3
$BotEquipment[MechSoldier] = "CLASS Enemy LVL 2000+200 COINS 11500/50 MateriaBlade 1 LightningMateriaIII 1/-600 " @ %defaultAlchemyDropsV;
$BotEquipment[EliteMechSoldier] = "LVL 4000+300 LightningMateriaIV 1/-600";
$BotEquipment[MechBeamer] = "CLASS Enemy LVL 2000+100 COINS 11500/50 CastingBlade 1 LightningMateriaIII 1/-600 " @ %defaultAlchemyDropsV;
$BotEquipment[EliteMechBeamer] = "LVL 4000+200 LightningMateriaIV 1/-600";

// Reactor 4
$BotEquipment[FireDragon] = "CLASS Enemy LVL 4000+200 COINS 11500/50 DragonBreath 1 DragonBreathShot 1000 FireMateriaIV 1/-600 " @ %defaultAlchemyDropsV;
$BotEquipment[EliteFireDragon] = "LVL 6000+300 FireMateriaV 1/-600";
$BotEquipment[MoltenDragon] = "CLASS Enemy LVL 4000+100 COINS 11500/50 CastingBlade 1 FireMateriaIV 1/-600 " @ %defaultAlchemyDropsV;
$BotEquipment[EliteMoltenDragon] = "LVL 6000+200 FireMateriaV 1/-600";

//------------------------------

$TeamForRace[Traveller] = 1;
$TeamForRace[Goblin] = 2;
$TeamForRace[Gnoll] = 3;
$TeamForRace[Orc] = 2;
$TeamForRace[Ogre] = 2;
$TeamForRace[Undead] = 4;
$TeamForRace[MaleElf] = 5;
$TeamForRace[FemaleElf] = 5;
$TeamForRace[Minotaur] = 6;
$TeamForRace[Uber] = 7;
$TeamForRace[Zombie] = 4;
$TeamForRace[Demon] = 4;
$TeamForRace[Cultist] = 1;
$TeamForRace[Spider] = 6;
$TeamForRace[Shinra] = 1;
$TeamForRace[Daemon] = 4;
$TeamForRace[Dragon] = 6;
$TeamForRace[Godeye] = 4;
$TeamForRace[Wight] = 4;
$TeamForRace[Shadow] = 4;
$TeamForRace[CacoDemon] = 4;
$TeamForRace[Slime] = 6;
$TeamForRace[Bat] = 6;
$TeamForRace[Bear] = 6;
$TeamForRace[Cyclops] = 2;
$TeamForRace[HornedKnight] = 1;
$TeamForRace[CultistAbomination] = 1;
$TeamForRace[CultistGiant] = 1;
$TeamForRace[Mech] = 1;

//------------------------------

$RaceSound[Ogre, Death, 1] = SoundOgreDeath1;
$RaceSound[Ogre, Acquired, 1] = SoundOgreAcquired1;
$RaceSound[Ogre, Acquired, 2] = SoundOgreAcquired2;
$RaceSound[Ogre, Hit, 1] = SoundOgreHit1;
$RaceSound[Ogre, Hit, 2] = SoundOgreHit2;
$RaceSound[Ogre, Taunt, 1] = SoundOgreTaunt1;
$RaceSound[Ogre, Taunt, 2] = SoundOgreTaunt2;
$RaceSound[Ogre, RandomWait, 1] = SoundOgreRandom1;
$RaceSound[Ogre, RandomWait, 2] = SoundOgreRandom2;

$RaceSound[Mech, Death, 1] = SoundOgreDeath1;
$RaceSound[Mech, Acquired, 1] = SoundOgreAcquired1;
$RaceSound[Mech, Acquired, 2] = SoundOgreAcquired2;
$RaceSound[Mech, Hit, 1] = SoundOgreHit1;
$RaceSound[Mech, Hit, 2] = SoundOgreHit2;
$RaceSound[Mech, Taunt, 1] = SoundOgreTaunt1;
$RaceSound[Mech, Taunt, 2] = SoundOgreTaunt2;
$RaceSound[Mech, RandomWait, 1] = SoundOgreRandom1;
$RaceSound[Mech, RandomWait, 2] = SoundOgreRandom2;

$RaceSound[Cyclops, Death, 1] = SoundOgreDeath1;
$RaceSound[Cyclops, Acquired, 1] = SoundOgreAcquired1;
$RaceSound[Cyclops, Acquired, 2] = SoundOgreAcquired2;
$RaceSound[Cyclops, Hit, 1] = SoundOgreHit1;
$RaceSound[OgCyclopsre, Hit, 2] = SoundOgreHit2;
$RaceSound[Cyclops, Taunt, 1] = SoundOgreTaunt1;
$RaceSound[Cyclops, Taunt, 2] = SoundOgreTaunt2;
$RaceSound[Cyclops, RandomWait, 1] = SoundOgreRandom1;
$RaceSound[Cyclops, RandomWait, 2] = SoundOgreRandom2;

$RaceSound[HornedKnight, Death, 1] = SoundOgreDeath1;
$RaceSound[HornedKnight, Acquired, 1] = SoundOgreAcquired1;
$RaceSound[HornedKnight, Acquired, 2] = SoundOgreAcquired2;
$RaceSound[HornedKnight, Hit, 1] = SoundOgreHit1;
$RaceSound[HornedKnight, Hit, 2] = SoundOgreHit2;
$RaceSound[HornedKnight, Taunt, 1] = SoundOgreTaunt1;
$RaceSound[HornedKnight, Taunt, 2] = SoundOgreTaunt2;
$RaceSound[HornedKnight, RandomWait, 1] = SoundOgreRandom1;
$RaceSound[HornedKnight, RandomWait, 2] = SoundOgreRandom2;

$RaceSound[Undead, Death, 1] = SoundUndeadDeath1;
$RaceSound[Undead, Acquired, 1] = SoundUndeadAcquired1;
$RaceSound[Undead, Hit, 1] = SoundUndeadHit1;
$RaceSound[Undead, Hit, 2] = SoundUndeadHit2;
$RaceSound[Undead, Taunt, 1] = SoundUndeadTaunt1;
$RaceSound[Undead, RandomWait, 1] = SoundUndeadRandom1;

$RaceSound[Shadow, Death, 1] = SoundUndeadDeath1;
$RaceSound[Shadow, Acquired, 1] = SoundUndeadAcquired1;
$RaceSound[Shadow, Hit, 1] = SoundUndeadHit1;
$RaceSound[Shadow, Hit, 2] = SoundUndeadHit2;
$RaceSound[Shadow, Taunt, 1] = SoundUndeadTaunt1;
$RaceSound[Shadow, RandomWait, 1] = SoundUndeadRandom1;

$RaceSound[CacoDemon, Death, 1] = SoundUndeadDeath1;
$RaceSound[CacoDemon, Acquired, 1] = SoundUndeadAcquired1;
$RaceSound[CacoDemon, Hit, 1] = SoundUndeadHit1;
$RaceSound[CacoDemon, Hit, 2] = SoundUndeadHit2;
$RaceSound[CacoDemon, Taunt, 1] = SoundUndeadTaunt1;
$RaceSound[CacoDemon, RandomWait, 1] = SoundUndeadRandom1;

$RaceSound[MaleElf, Death, 1] = SoundTravellerDeath1;
$RaceSound[MaleElf, Acquired, 1] = SoundTravellerAcquired1;
$RaceSound[MaleElf, Acquired, 2] = SoundTravellerAcquired2;
$RaceSound[MaleElf, Acquired, 3] = SoundTravellerAcquired3;
$RaceSound[MaleElf, Hit, 1] = SoundTravellerHit1;
$RaceSound[MaleElf, Hit, 2] = SoundTravellerHit2;
$RaceSound[MaleElf, Hit, 3] = SoundTravellerHit3;

$RaceSound[Traveller, Death, 1] = SoundTravellerDeath1;
$RaceSound[Traveller, Acquired, 1] = SoundTravellerAcquired1;
$RaceSound[Traveller, Acquired, 2] = SoundTravellerAcquired2;
$RaceSound[Traveller, Acquired, 3] = SoundTravellerAcquired3;
$RaceSound[Traveller, Hit, 1] = SoundTravellerHit1;
$RaceSound[Traveller, Hit, 2] = SoundTravellerHit2;
$RaceSound[Traveller, Hit, 3] = SoundTravellerHit3;

$RaceSound[Minotaur, Death, 1] = SoundMinotaurDeath1;
$RaceSound[Minotaur, Acquired, 1] = SoundMinotaurAcquired1;
$RaceSound[Minotaur, Acquired, 2] = SoundMinotaurAcquired2;
$RaceSound[Minotaur, Hit, 1] = SoundMinotaurHit1;

$RaceSound[Uber, Death, 1] = SoundUberDeath1;
$RaceSound[Uber, Acquired, 1] = SoundUberAcquired1;
$RaceSound[Uber, Acquired, 2] = SoundUberAcquired2;
$RaceSound[Uber, RandomWait, 1] = SoundUberRandom1;
$RaceSound[Uber, Hit, 1] = SoundUberHit1;

$RaceSound[Goblin, Death, 1] = SoundGoblinDeath1;
$RaceSound[Goblin, Death, 2] = SoundGoblinDeath2;
$RaceSound[Goblin, Acquired, 1] = SoundGoblinAcquired1;
$RaceSound[Goblin, Acquired, 2] = SoundGoblinAcquired2;
$RaceSound[Goblin, Acquired, 3] = SoundGoblinAcquired3;
$RaceSound[Goblin, Taunt, 1] = SoundGoblinTaunt1;
$RaceSound[Goblin, RandomWait, 1] = SoundGoblinRandom1;
$RaceSound[Goblin, Hit, 1] = SoundGoblinHit1;
$RaceSound[Goblin, Hit, 2] = SoundGoblinHit2;
$RaceSound[Goblin, Hit, 3] = SoundGoblinHit3;
$RaceSound[Goblin, Hit, 4] = SoundGoblinHit4;
$RaceSound[Goblin, Hit, 5] = SoundGoblinHit5;
$RaceSound[Goblin, Hit, 6] = SoundGoblinHit6;
$RaceSound[Goblin, Hit, 7] = SoundGoblinHit7;
$RaceSound[Goblin, Hit, 8] = SoundGoblinHit8;

$RaceSound[Gnoll, Death, 1] = SoundGnollDeath1;
$RaceSound[Gnoll, Death, 2] = SoundGnollDeath2;
$RaceSound[Gnoll, Acquired, 1] = SoundGnollAcquired1;
$RaceSound[Gnoll, Taunt, 1] = SoundGnollTaunt1;
$RaceSound[Gnoll, RandomWait, 1] = SoundGnollRandom1;
$RaceSound[Gnoll, RandomWait, 2] = SoundGnollRandom2;
$RaceSound[Gnoll, Hit, 1] = SoundGnollHit1;
$RaceSound[Gnoll, Hit, 2] = SoundGnollHit2;

$RaceSound[Orc, Death, 1] = SoundUberDeath1;
$RaceSound[Orc, Acquired, 1] = SoundMinotaurAcquired1;
$RaceSound[Orc, Acquired, 2] = SoundMinotaurAcquired2;
$RaceSound[Orc, Acquired, 3] = SoundUberAcquired1;
$RaceSound[Orc, Acquired, 4] = SoundUberAcquired2;
$RaceSound[Orc, Hit, 1] = SoundMinotaurHit1;

$RaceSound[Zombie, Death, 1] = SoundUndeadDeath1;
$RaceSound[Zombie, Acquired, 1] = SoundUndeadRandom1;
$RaceSound[Zombie, Hit, 1] = SoundGnollRandom1;
$RaceSound[Zombie, Hit, 2] = SoundGnollRandom2;
$RaceSound[Zombie, Taunt, 1] = SoundUndeadTaunt1;
$RaceSound[Zombie, RandomWait, 1] = SoundUberAcquired2;

$RaceSound[Wight, Death, 1] = SoundUndeadDeath1;
$RaceSound[Wight, Acquired, 1] = SoundUndeadRandom1;
$RaceSound[Wight, Hit, 1] = SoundGnollRandom1;
$RaceSound[Wight, Hit, 2] = SoundGnollRandom2;
$RaceSound[Wight, Taunt, 1] = SoundUndeadTaunt1;
$RaceSound[Wight, RandomWait, 1] = SoundUberAcquired2;

$RaceSound[Demon, Death, 1] = SoundUndeadDeath1;
$RaceSound[Demon, Acquired, 1] = SoundGnollAcquired1;
$RaceSound[Demon, Hit, 1] = SoundUndeadHit1;
$RaceSound[Demon, Hit, 2] = SoundUndeadHit2;
$RaceSound[Demon, Taunt, 1] = SoundUndeadTaunt1;
$RaceSound[Demon, RandomWait, 1] = SoundUndeadRandom1;

$RaceSound[Cultist, Death, 1] = SoundTravellerDeath1;
$RaceSound[Cultist, Acquired, 1] = SoundTravellerAcquired1;
$RaceSound[Cultist, Acquired, 2] = SoundTravellerAcquired2;
$RaceSound[Cultist, Acquired, 3] = SoundTravellerAcquired3;
$RaceSound[Cultist, Hit, 1] = SoundTravellerHit1;
$RaceSound[Cultist, Hit, 2] = SoundTravellerHit2;
$RaceSound[Cultist, Hit, 3] = SoundTravellerHit3;

$RaceSound[CultistAbomination, Death, 1] = SoundTravellerDeath1;
$RaceSound[CultistAbomination, Acquired, 1] = SoundTravellerAcquired1;
$RaceSound[CultistAbomination, Acquired, 2] = SoundTravellerAcquired2;
$RaceSound[CultistAbomination, Acquired, 3] = SoundTravellerAcquired3;
$RaceSound[CultistAbomination, Hit, 1] = SoundTravellerHit1;
$RaceSound[CultistAbomination, Hit, 2] = SoundTravellerHit2;
$RaceSound[CultistAbomination, Hit, 3] = SoundTravellerHit3;

$RaceSound[CultistGiant, Death, 1] = SoundOgreDeath1;
$RaceSound[CultistGiant, Acquired, 1] = SoundOgreAcquired1;
$RaceSound[CultistGiant, Acquired, 2] = SoundOgreAcquired2;
$RaceSound[CultistGiant, Hit, 1] = SoundOgreHit1;
$RaceSound[CultistGiant, Hit, 2] = SoundOgreHit2;
$RaceSound[CultistGiant, Taunt, 1] = SoundOgreTaunt1;
$RaceSound[CultistGiant, Taunt, 2] = SoundOgreTaunt2;
$RaceSound[CultistGiant, RandomWait, 1] = SoundOgreRandom1;
$RaceSound[CultistGiant, RandomWait, 2] = SoundOgreRandom2;

$RaceSound[Shinra, Death, 1] = SoundTravellerDeath1;
$RaceSound[Shinra, Acquired, 1] = SoundTravellerAcquired1;
$RaceSound[Shinra, Acquired, 2] = SoundTravellerAcquired2;
$RaceSound[Shinra, Acquired, 3] = SoundTravellerAcquired3;
$RaceSound[Shinra, Hit, 1] = SoundTravellerHit1;
$RaceSound[Shinra, Hit, 2] = SoundTravellerHit2;
$RaceSound[Shinra, Hit, 3] = SoundTravellerHit3;

$RaceSound[Spider, Death, 1] = Ostrix;
$RaceSound[Slime, Death, 1] = Ostrix;
$RaceSound[Bat, Death, 1] = Ostrix;

$RaceSound[Daemon, Death, 1] = RockMonsterDeath1;
$RaceSound[Daemon, Acquired, 1] = RockMonsterSound1;
$RaceSound[Daemon, Hit, 1] = SoundMinotaurAcquired1;
$RaceSound[Daemon, Hit, 2] = RockMonsterSound2;

$RaceSound[Dragon, Death, 1] = SoundGnollDeath1;
$RaceSound[Dragon, Death, 2] = SoundGnollDeath2;
$RaceSound[Dragon, Acquired, 1] = LairEnterRoar;
$RaceSound[Dragon, Hit, 1] = SoundGnollHit1;
$RaceSound[Dragon, Hit, 2] = SoundGnollHit2;
$RaceSound[Dragon, Taunt, 1] = SoundGnollTaunt1;

$RaceSound[Godeye, Death, 1] = RockMonsterDeath1;
$RaceSound[Godeye, Acquired, 1] = SoundUberAcquired2;
$RaceSound[Godeye, Hit, 1] = SoundHitFlesh;

//------------------------------------------------------------------
// Traveller armor data:	(light)
//------------------------------------------------------------------

PlayerData TravellerArmor
{
	className = "Armor";
	shapeFile = "rpgmalehuman";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	flameShapeName = "lflame";
	shieldShapeName = "shield";
	shadowDetailMask = 1;

	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
	canCrouch = false;

	maxJetSideForceFactor = 1;
	maxJetForwardVelocity = 1.0;
	minJetEnergy = 60;
	jetForce = 1;
	jetEnergyDrain = 0.0;

	maxDamage = 1.0;
	maxForwardSpeed = $spdmed;
	maxBackwardSpeed = $spdmed * 0.8;
	maxSideSpeed = $spdmed * 0.75;

	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 60;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

	jumpImpulse = 75;
	jumpSurfaceMinDot = $jumpSurfaceMinDot;

	// animation data:
	// animation name, one shot, direction, firstPerson, chaseCam, thirdPerson, signalThread
	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "die back", none, 1, true, false, false, false, 0 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
	// death animations:
	animData[25] = { "crouch die", none, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", none, 1, false, false, false, false, 4 };
	animData[27] = { "die head", none, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", none, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", none, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", none, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", none, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", none, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", none, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", none, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", none, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", none, 1, false, false, false, false, 4 };
	animData[37] = { "die back", none, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 

	// celebration animations:
	animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
	// taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;
	rFootSounds = 
	{
		SoundLFootRSoft,
		SoundLFootRHard,
		SoundLFootRSoft,
		SoundLFootRHard,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRHard,
		SoundLFootRSnow,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft
	}; 
	lFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLHard,
		SoundLFootLSoft,
		SoundLFootLHard,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLHard,
		SoundLFootLSnow,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft
	};

	footPrints = { 0, 1 };

	boxWidth = 0.5;
	boxDepth = 0.5;
	boxNormalHeight = 2.3;
	boxCrouchHeight = 1.8;

	boxNormalHeadPercentage  = 0.83;
	boxNormalTorsoPercentage = 0.53;
	boxCrouchHeadPercentage  = 0.6666;
	boxCrouchTorsoPercentage = 0.3333;

	boxHeadLeftPercentage  = 0;
	boxHeadRightPercentage = 1;
	boxHeadBackPercentage  = 0;
	boxHeadFrontPercentage = 1;
};

//------------------------------------------------------------------
// Goblin armor data:	(light)
//------------------------------------------------------------------

PlayerData GoblinArmor
{
	className = "Armor";
	shapeFile = "goblin";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	flameShapeName = "lflame";
	shieldShapeName = "shield";
	shadowDetailMask = 1;

	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
	canCrouch = false;

	maxJetSideForceFactor = 1;
	maxJetForwardVelocity = 1.0;
	minJetEnergy = 60;
	jetForce = 1;
	jetEnergyDrain = 0.0;

	maxDamage = 1.0;
	maxForwardSpeed = $spdlowmed;
	maxBackwardSpeed = $spdlowmed * 0.8;
	maxSideSpeed = $spdlowmed * 0.75;

	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 60;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

	jumpImpulse = 75;
	jumpSurfaceMinDot = $jumpSurfaceMinDot;

	// animation data:
	// animation name, one shot, direction, firstPerson, chaseCam, thirdPerson, signalThread
	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "die back", none, 1, true, false, false, false, 0 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
	// death animations:
	animData[25] = { "crouch die", none, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", none, 1, false, false, false, false, 4 };
	animData[27] = { "die head", none, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", none, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", none, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", none, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", none, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", none, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", none, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", none, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", none, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", none, 1, false, false, false, false, 4 };
	animData[37] = { "die back", none, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 

	// celebration animations:
	animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
	// taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;
	rFootSounds = 
	{
		SoundLFootRSoft,
		SoundLFootRHard,
		SoundLFootRSoft,
		SoundLFootRHard,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRHard,
		SoundLFootRSnow,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft
	}; 
	lFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLHard,
		SoundLFootLSoft,
		SoundLFootLHard,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLHard,
		SoundLFootLSnow,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft
	};

	footPrints = { 0, 1 };

	boxWidth = 0.5;
	boxDepth = 0.5;
	boxNormalHeight = 2.3;
	boxCrouchHeight = 1.8;

	boxNormalHeadPercentage  = 0.83;
	boxNormalTorsoPercentage = 0.53;
	boxCrouchHeadPercentage  = 0.6666;
	boxCrouchTorsoPercentage = 0.3333;

	boxHeadLeftPercentage  = 0;
	boxHeadRightPercentage = 1;
	boxHeadBackPercentage  = 0;
	boxHeadFrontPercentage = 1;
};

//------------------------------------------------------------------
// Gnoll Armor data:	(medium)
//------------------------------------------------------------------

PlayerData GnollArmor
{
	className = "Armor";
	shapeFile = "marmorgnoll";
	flameShapeName = "mflame";
	shieldShapeName = "shield";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	shadowDetailMask = 1;

	canCrouch = false;
	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";

	maxJetSideForceFactor = 1;
	maxJetForwardVelocity = 1.0;
	minJetEnergy = 60;
	jetForce = 1;
	jetEnergyDrain = 0.0;

	maxDamage = 1.0;
	maxForwardSpeed = $spdmed;
	maxBackwardSpeed = $spdmed * 0.8;
	maxSideSpeed = $spdmed * 0.75;
	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 80;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

	jumpImpulse = 75;
	jumpSurfaceMinDot = $jumpSurfaceMinDot;

	// animation data:
	// animation name, one shot, exclude, direction, firstPerson, chaseCam, thirdPerson, signalThread

	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "die back", none, 1, true, false, false, false, 0 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
	// death animations:
	animData[25] = { "crouch die", none, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", none, 1, false, false, false, false, 4 };
	animData[27] = { "die head", none, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", none, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", none, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", none, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", none, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", none, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", none, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", none, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", none, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", none, 1, false, false, false, false, 4 };
	animData[37] = { "die back", none, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 

	// celebraton animations:
	animData[43] = { "celebration 1", none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };

	// taunt anmations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };

	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;

	rFootSounds = 
	{
		SoundMFootRSoft,
		SoundMFootRHard,
		SoundMFootRSoft,
		SoundMFootRHard,
		SoundMFootRSoft,
		SoundMFootRSoft,
		SoundMFootRSoft,
		SoundMFootRHard,
		SoundMFootRSnow,
		SoundMFootRSoft,
		SoundMFootRSoft,
		SoundMFootRSoft,
		SoundMFootRSoft,
		SoundMFootRSoft,
		SoundMFootRSoft
	}; 
	lFootSounds =
	{
		SoundMFootLSoft,
		SoundMFootLHard,
		SoundMFootLSoft,
		SoundMFootLHard,
		SoundMFootLSoft,
		SoundMFootLSoft,
		SoundMFootLSoft,
		SoundMFootLHard,
		SoundMFootLSnow,
		SoundMFootLSoft,
		SoundMFootLSoft,
		SoundMFootLSoft,
		SoundMFootLSoft,
		SoundMFootLSoft,
		SoundMFootLSoft
	};

	footPrints = { 2, 3 };

	boxWidth = 0.7;
	boxDepth = 0.7;
	boxNormalHeight = 2.4;

	boxNormalHeadPercentage  = 0.83;
	boxNormalTorsoPercentage = 0.49;

	boxHeadLeftPercentage  = 0;
	boxHeadRightPercentage = 1;
	boxHeadBackPercentage  = 0;
	boxHeadFrontPercentage = 1;
};

//------------------------------------------------------------------
// Orc Armor data:	(medium)
//------------------------------------------------------------------

PlayerData OrcArmor
{
	className = "Armor";
	shapeFile = "marmor";
	flameShapeName = "mflame";
	shieldShapeName = "shield";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	shadowDetailMask = 1;

	canCrouch = false;
	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";

	maxJetSideForceFactor = 1;
	maxJetForwardVelocity = 1.0;
	minJetEnergy = 60;
	jetForce = 1;
	jetEnergyDrain = 0.0;

	maxDamage = 1.0;
	maxForwardSpeed = $spdmed;
	maxBackwardSpeed = $spdmed * 0.8;
	maxSideSpeed = $spdmed * 0.75;
	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 80;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

	jumpImpulse = 75;
	jumpSurfaceMinDot = $jumpSurfaceMinDot;

	// animation data:
	// animation name, one shot, exclude, direction, firstPerson, chaseCam, thirdPerson, signalThread

	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "die back", none, 1, true, false, false, false, 0 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
	// death animations:
	animData[25] = { "crouch die", none, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", none, 1, false, false, false, false, 4 };
	animData[27] = { "die head", none, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", none, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", none, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", none, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", none, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", none, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", none, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", none, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", none, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", none, 1, false, false, false, false, 4 };
	animData[37] = { "die back", none, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 

	// celebraton animations:
	animData[43] = { "celebration 1", none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };

	// taunt anmations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };

	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;

	rFootSounds = 
	{
		SoundMFootRSoft,
		SoundMFootRHard,
		SoundMFootRSoft,
		SoundMFootRHard,
		SoundMFootRSoft,
		SoundMFootRSoft,
		SoundMFootRSoft,
		SoundMFootRHard,
		SoundMFootRSnow,
		SoundMFootRSoft,
		SoundMFootRSoft,
		SoundMFootRSoft,
		SoundMFootRSoft,
		SoundMFootRSoft,
		SoundMFootRSoft
	}; 
	lFootSounds =
	{
		SoundMFootLSoft,
		SoundMFootLHard,
		SoundMFootLSoft,
		SoundMFootLHard,
		SoundMFootLSoft,
		SoundMFootLSoft,
		SoundMFootLSoft,
		SoundMFootLHard,
		SoundMFootLSnow,
		SoundMFootLSoft,
		SoundMFootLSoft,
		SoundMFootLSoft,
		SoundMFootLSoft,
		SoundMFootLSoft,
		SoundMFootLSoft
	};

	footPrints = { 2, 3 };

	boxWidth = 0.7;
	boxDepth = 0.7;
	boxNormalHeight = 2.4;

	boxNormalHeadPercentage  = 0.83;
	boxNormalTorsoPercentage = 0.49;

	boxHeadLeftPercentage  = 0;
	boxHeadRightPercentage = 1;
	boxHeadBackPercentage  = 0;
	boxHeadFrontPercentage = 1;
};

//------------------------------------------------------------------
// Ogre Armor data:		(heavy)
//------------------------------------------------------------------

PlayerData OgreArmor
{
	className = "Armor";
	shapeFile = "harmor";
	flameShapeName = "hflame";
	shieldShapeName = "shield";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	shadowDetailMask = 1;

	canCrouch = false;
	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";

	maxJetSideForceFactor = 1;
	maxJetForwardVelocity = 1.0;
	minJetEnergy = 60;
	jetForce = 1;
	jetEnergyDrain = 0.0;

	maxDamage = 1.0;
	maxForwardSpeed = $spdlow;
	maxBackwardSpeed = $spdlow * 0.8;
	maxSideSpeed = $spdlow * 0.75;
	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 110;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 16;
	damageScale = 0.006;

	jumpImpulse = 75;
	jumpSurfaceMinDot = $jumpSurfaceMinDot;
  
	// animation data:
	// animation name, one shot, exclude, direction, firstPerson, chaseCam, thirdPerson, signalThread

	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "die back", none, 1, true, false, false, false, 0 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
	// death animations:
	animData[25] = { "crouch die", none, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", none, 1, false, false, false, false, 4 };
	animData[27] = { "die head", none, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", none, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", none, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", none, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", none, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", none, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", none, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", none, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", none, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", none, 1, false, false, false, false, 4 };
	animData[37] = { "die back", none, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 

	// celebraton animations:
	animData[43] = { "celebration 1", none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };

	// taunt anmations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };

	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;

	rFootSounds = 
	{
		SoundHFootRSoft,
		SoundHFootRHard,
		SoundHFootRSoft,
		SoundHFootRHard,
		SoundHFootRSoft,
		SoundHFootRSoft,
		SoundHFootRSoft,
		SoundHFootRHard,
		SoundHFootRSnow,
		SoundHFootRSoft,
		SoundHFootRSoft,
		SoundHFootRSoft,
		SoundHFootRSoft,
		SoundHFootRSoft,
		SoundHFootRSoft
	}; 
	lFootSounds =
	{
		SoundHFootLSoft,
		SoundHFootLHard,
		SoundHFootLSoft,
		SoundHFootLHard,
		SoundHFootLSoft,
		SoundHFootLSoft,
		SoundHFootLSoft,
		SoundHFootLHard,
		SoundHFootLSnow,
		SoundHFootLSoft,
		SoundHFootLSoft,
		SoundHFootLSoft,
		SoundHFootLSoft,
		SoundHFootLSoft,
		SoundHFootLSoft
	};

	footPrints = { 4, 5 };

	boxWidth = 0.8;
	boxDepth = 0.8;
	boxNormalHeight = 2.6;

	boxNormalHeadPercentage  = 0.70;
	boxNormalTorsoPercentage = 0.45;

	boxHeadLeftPercentage  = 0.48;
	boxHeadRightPercentage = 0.70;
	boxHeadBackPercentage  = 0.48;
	boxHeadFrontPercentage = 0.60;
};

//------------------------------------------------------------------
// Ogre Armor data:		(heavy)
//------------------------------------------------------------------

PlayerData OgreArmorFast
{
	className = "Armor";
	shapeFile = "harmor";
	flameShapeName = "hflame";
	shieldShapeName = "shield";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	shadowDetailMask = 1;

	canCrouch = false;
	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";

	maxJetSideForceFactor = 1;
	maxJetForwardVelocity = 1.0;
	minJetEnergy = 60;
	jetForce = 1;
	jetEnergyDrain = 0.0;

	maxDamage = 1.0;
	maxForwardSpeed = $spdhigher;
	maxBackwardSpeed = $spdhigher * 0.8;
	maxSideSpeed = $spdhigher * 0.75;
	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 110;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 16;
	damageScale = 0.006;

	jumpImpulse = 75;
	jumpSurfaceMinDot = $jumpSurfaceMinDot;
  
	// animation data:
	// animation name, one shot, exclude, direction, firstPerson, chaseCam, thirdPerson, signalThread

	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "die back", none, 1, true, false, false, false, 0 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
	// death animations:
	animData[25] = { "crouch die", none, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", none, 1, false, false, false, false, 4 };
	animData[27] = { "die head", none, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", none, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", none, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", none, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", none, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", none, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", none, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", none, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", none, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", none, 1, false, false, false, false, 4 };
	animData[37] = { "die back", none, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 

	// celebraton animations:
	animData[43] = { "celebration 1", none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };

	// taunt anmations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };

	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;

	rFootSounds = 
	{
		SoundHFootRSoft,
		SoundHFootRHard,
		SoundHFootRSoft,
		SoundHFootRHard,
		SoundHFootRSoft,
		SoundHFootRSoft,
		SoundHFootRSoft,
		SoundHFootRHard,
		SoundHFootRSnow,
		SoundHFootRSoft,
		SoundHFootRSoft,
		SoundHFootRSoft,
		SoundHFootRSoft,
		SoundHFootRSoft,
		SoundHFootRSoft
	}; 
	lFootSounds =
	{
		SoundHFootLSoft,
		SoundHFootLHard,
		SoundHFootLSoft,
		SoundHFootLHard,
		SoundHFootLSoft,
		SoundHFootLSoft,
		SoundHFootLSoft,
		SoundHFootLHard,
		SoundHFootLSnow,
		SoundHFootLSoft,
		SoundHFootLSoft,
		SoundHFootLSoft,
		SoundHFootLSoft,
		SoundHFootLSoft,
		SoundHFootLSoft
	};

	footPrints = { 4, 5 };

	boxWidth = 0.8;
	boxDepth = 0.8;
	boxNormalHeight = 2.6;

	boxNormalHeadPercentage  = 0.70;
	boxNormalTorsoPercentage = 0.45;

	boxHeadLeftPercentage  = 0.48;
	boxHeadRightPercentage = 0.70;
	boxHeadBackPercentage  = 0.48;
	boxHeadFrontPercentage = 0.60;
};

//------------------------------------------------------------------
// MaleElf armor data:	(light)
//------------------------------------------------------------------

PlayerData MaleElfArmor
{
	className = "Armor";
	shapeFile = "rpgmalehuman";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	flameShapeName = "lflame";
	shieldShapeName = "shield";
	shadowDetailMask = 1;

	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
	canCrouch = false;

	maxJetSideForceFactor = 1;
	maxJetForwardVelocity = 1.0;
	minJetEnergy = 60;
	jetForce = 1;
	jetEnergyDrain = 0.0;

	maxDamage = 1.0;
	maxForwardSpeed = $spdmed;
	maxBackwardSpeed = $spdmed * 0.8;
	maxSideSpeed = $spdmed * 0.75;

	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 60;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

	jumpImpulse = 75;
	jumpSurfaceMinDot = $jumpSurfaceMinDot;

	// animation data:
	// animation name, one shot, direction, firstPerson, chaseCam, thirdPerson, signalThread
	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "die back", none, 1, true, false, false, false, 0 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
	// death animations:
	animData[25] = { "crouch die", none, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", none, 1, false, false, false, false, 4 };
	animData[27] = { "die head", none, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", none, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", none, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", none, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", none, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", none, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", none, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", none, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", none, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", none, 1, false, false, false, false, 4 };
	animData[37] = { "die back", none, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 

	// celebration animations:
	animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
	// taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;
	rFootSounds = 
	{
		SoundLFootRSoft,
		SoundLFootRHard,
		SoundLFootRSoft,
		SoundLFootRHard,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRHard,
		SoundLFootRSnow,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft
	}; 
	lFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLHard,
		SoundLFootLSoft,
		SoundLFootLHard,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLHard,
		SoundLFootLSnow,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft
	};

	footPrints = { 0, 1 };

	boxWidth = 0.5;
	boxDepth = 0.5;
	boxNormalHeight = 2.3;
	boxCrouchHeight = 1.8;

	boxNormalHeadPercentage  = 0.83;
	boxNormalTorsoPercentage = 0.53;
	boxCrouchHeadPercentage  = 0.6666;
	boxCrouchTorsoPercentage = 0.3333;

	boxHeadLeftPercentage  = 0;
	boxHeadRightPercentage = 1;
	boxHeadBackPercentage  = 0;
	boxHeadFrontPercentage = 1;
};

//------------------------------------------------------------------
// FemaleElf armor data:	(light)
//------------------------------------------------------------------

PlayerData FemaleElfArmor
{
	className = "Armor";
	shapeFile = "lfemalehuman";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	flameShapeName = "lflame";
	shieldShapeName = "shield";
	shadowDetailMask = 1;

	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
	canCrouch = false;

	maxJetSideForceFactor = 1;
	maxJetForwardVelocity = 1.0;
	minJetEnergy = 60;
	jetForce = 1;
	jetEnergyDrain = 0.0;

	maxDamage = 1.0;
	maxForwardSpeed = $spdmed;
	maxBackwardSpeed = $spdmed * 0.8;
	maxSideSpeed = $spdmed * 0.75;

	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 60;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

	jumpImpulse = 75;
	jumpSurfaceMinDot = $jumpSurfaceMinDot;

	// animation data:
	// animation name, one shot, direction, firstPerson, chaseCam, thirdPerson, signalThread
	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "die back", none, 1, true, false, false, false, 0 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
	// death animations:
	animData[25] = { "crouch die", none, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", none, 1, false, false, false, false, 4 };
	animData[27] = { "die head", none, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", none, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", none, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", none, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", none, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", none, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", none, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", none, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", none, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", none, 1, false, false, false, false, 4 };
	animData[37] = { "die back", none, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 

	// celebration animations:
	animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
	// taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;
	rFootSounds = 
	{
		SoundLFootRSoft,
		SoundLFootRHard,
		SoundLFootRSoft,
		SoundLFootRHard,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRHard,
		SoundLFootRSnow,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft
	}; 
	lFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLHard,
		SoundLFootLSoft,
		SoundLFootLHard,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLHard,
		SoundLFootLSnow,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft
	};

	footPrints = { 0, 1 };

	boxWidth = 0.5;
	boxDepth = 0.5;
	boxNormalHeight = 2.3;
	boxCrouchHeight = 1.8;

	boxNormalHeadPercentage  = 0.83;
	boxNormalTorsoPercentage = 0.53;
	boxCrouchHeadPercentage  = 0.6666;
	boxCrouchTorsoPercentage = 0.3333;

	boxHeadLeftPercentage  = 0;
	boxHeadRightPercentage = 1;
	boxHeadBackPercentage  = 0;
	boxHeadFrontPercentage = 1;
};

//------------------------------------------------------------------
// Minotaur Armor data:	(minotaur player model)
//------------------------------------------------------------------

PlayerData MinotaurArmor
{
	className = "Armor";
	shapeFile = "min";
	flameShapeName = "mflame";
	shieldShapeName = "shield";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	shadowDetailMask = 1;

	canCrouch = false;
	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";

	maxJetSideForceFactor = 1;
	maxJetForwardVelocity = 1.0;
	minJetEnergy = 60;
	jetForce = 1;
	jetEnergyDrain = 0.0;

	maxDamage = 1.0;
	maxForwardSpeed = $spdlowmed;
	maxBackwardSpeed = $spdlowmed * 0.8;
	maxSideSpeed = $spdlowmed * 0.75;
	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 80;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

	jumpImpulse = 75;
	jumpSurfaceMinDot = $jumpSurfaceMinDot;

	// animation data:
	// animation name, one shot, exclude, direction, firstPerson, chaseCam, thirdPerson, signalThread

	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "die back", none, 1, true, false, false, false, 0 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
	// death animations:
	animData[25] = { "crouch die", none, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", none, 1, false, false, false, false, 4 };
	animData[27] = { "die head", none, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", none, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", none, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", none, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", none, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", none, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", none, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", none, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", none, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", none, 1, false, false, false, false, 4 };
	animData[37] = { "die back", none, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 

	// celebraton animations:
	animData[43] = { "celebration 1", none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };

	// taunt anmations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };

	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;

	rFootSounds = 
	{
		SoundMFootRSoft,
		SoundMFootRHard,
		SoundMFootRSoft,
		SoundMFootRHard,
		SoundMFootRSoft,
		SoundMFootRSoft,
		SoundMFootRSoft,
		SoundMFootRHard,
		SoundMFootRSnow,
		SoundMFootRSoft,
		SoundMFootRSoft,
		SoundMFootRSoft,
		SoundMFootRSoft,
		SoundMFootRSoft,
		SoundMFootRSoft
	}; 
	lFootSounds =
	{
		SoundMFootLSoft,
		SoundMFootLHard,
		SoundMFootLSoft,
		SoundMFootLHard,
		SoundMFootLSoft,
		SoundMFootLSoft,
		SoundMFootLSoft,
		SoundMFootLHard,
		SoundMFootLSnow,
		SoundMFootLSoft,
		SoundMFootLSoft,
		SoundMFootLSoft,
		SoundMFootLSoft,
		SoundMFootLSoft,
		SoundMFootLSoft
	};

	footPrints = { 2, 3 };

	boxWidth = 0.7;
	boxDepth = 0.7;
	boxNormalHeight = 2.4;

	boxNormalHeadPercentage  = 0.83;
	boxNormalTorsoPercentage = 0.49;

	boxHeadLeftPercentage  = 0;
	boxHeadRightPercentage = 1;
	boxHeadBackPercentage  = 0;
	boxHeadFrontPercentage = 1;
};

//------------------------------------------------------------------
// Uber Armor data:		(fedmonster player model)
//------------------------------------------------------------------

PlayerData UberArmor
{
	className = "Armor";
	shapeFile = "fedmonster";
	flameShapeName = "hflame";
	shieldShapeName = "shield";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	shadowDetailMask = 1;

	canCrouch = false;
	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";

	maxJetSideForceFactor = 1;
	maxJetForwardVelocity = 1.0;
	minJetEnergy = 60;
	jetForce = 1;
	jetEnergyDrain = 0.0;

	maxDamage = 1.0;
	maxForwardSpeed = $spdfast;
	maxBackwardSpeed = $spdfast * 0.8;
	maxSideSpeed = $spdfast * 0.75;
	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 110;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 16;
	damageScale = 0.006;

	jumpImpulse = 75;
	jumpSurfaceMinDot = $jumpSurfaceMinDot;
  
	// animation data:
	// animation name, one shot, exclude, direction, firstPerson, chaseCam, thirdPerson, signalThread

	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "die back", none, 1, true, false, false, false, 0 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
	// death animations:
	animData[25] = { "crouch die", none, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", none, 1, false, false, false, false, 4 };
	animData[27] = { "die head", none, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", none, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", none, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", none, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", none, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", none, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", none, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", none, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", none, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", none, 1, false, false, false, false, 4 };
	animData[37] = { "die back", none, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 

	// celebraton animations:
	animData[43] = { "celebration 1", none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };

	// taunt anmations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };

	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;

	rFootSounds = 
	{
		SoundHFootRSoft,
		SoundHFootRHard,
		SoundHFootRSoft,
		SoundHFootRHard,
		SoundHFootRSoft,
		SoundHFootRSoft,
		SoundHFootRSoft,
		SoundHFootRHard,
		SoundHFootRSnow,
		SoundHFootRSoft,
		SoundHFootRSoft,
		SoundHFootRSoft,
		SoundHFootRSoft,
		SoundHFootRSoft,
		SoundHFootRSoft
	}; 
	lFootSounds =
	{
		SoundHFootLSoft,
		SoundHFootLHard,
		SoundHFootLSoft,
		SoundHFootLHard,
		SoundHFootLSoft,
		SoundHFootLSoft,
		SoundHFootLSoft,
		SoundHFootLHard,
		SoundHFootLSnow,
		SoundHFootLSoft,
		SoundHFootLSoft,
		SoundHFootLSoft,
		SoundHFootLSoft,
		SoundHFootLSoft,
		SoundHFootLSoft
	};

	footPrints = { 4, 5 };

	boxWidth = 0.8;
	boxDepth = 0.8;
	boxNormalHeight = 2.6;

	boxNormalHeadPercentage  = 0.70;
	boxNormalTorsoPercentage = 0.45;

	boxHeadLeftPercentage  = 0.48;
	boxHeadRightPercentage = 0.70;
	boxHeadBackPercentage  = 0.48;
	boxHeadFrontPercentage = 0.60;
};

//------------------------------------------------------------------
// Zombie armor data:	(light)
//------------------------------------------------------------------

PlayerData ZombieArmor
{
	className = "Armor";
	shapeFile = "zombie";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	flameShapeName = "lflame";
	shieldShapeName = "shield";
	shadowDetailMask = 1;

	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
	canCrouch = false;

	maxJetSideForceFactor = 1;
	maxJetForwardVelocity = 1.0;
	minJetEnergy = 60;
	jetForce = 1;
	jetEnergyDrain = 0.0;

	maxDamage = 1.0;
	maxForwardSpeed = $spdlowmed;
	maxBackwardSpeed = $spdlowmed * 0.8;
	maxSideSpeed = $spdlowmed * 0.75;

	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 60;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

	jumpImpulse = 75;
	jumpSurfaceMinDot = $jumpSurfaceMinDot;

	// animation data:
	// animation name, one shot, direction, firstPerson, chaseCam, thirdPerson, signalThread
	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "die back", none, 1, true, false, false, false, 0 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
	// death animations:
	animData[25] = { "crouch die", none, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", none, 1, false, false, false, false, 4 };
	animData[27] = { "die head", none, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", none, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", none, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", none, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", none, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", none, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", none, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", none, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", none, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", none, 1, false, false, false, false, 4 };
	animData[37] = { "die back", none, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 

	// celebration animations:
	animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
	// taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;
	rFootSounds = 
	{
		SoundLFootRSoft,
		SoundLFootRHard,
		SoundLFootRSoft,
		SoundLFootRHard,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRHard,
		SoundLFootRSnow,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft
	}; 
	lFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLHard,
		SoundLFootLSoft,
		SoundLFootLHard,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLHard,
		SoundLFootLSnow,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft
	};

	footPrints = { 0, 1 };

	boxWidth = 0.5;
	boxDepth = 0.5;
	boxNormalHeight = 2.3;
	boxCrouchHeight = 1.8;

	boxNormalHeadPercentage  = 0.83;
	boxNormalTorsoPercentage = 0.53;
	boxCrouchHeadPercentage  = 0.6666;
	boxCrouchTorsoPercentage = 0.3333;

	boxHeadLeftPercentage  = 0;
	boxHeadRightPercentage = 1;
	boxHeadBackPercentage  = 0;
	boxHeadFrontPercentage = 1;
};

//------------------------------------------------------------------
// Undead armor data:	(light)
//------------------------------------------------------------------

PlayerData UndeadArmor
{
	className = "Armor";
	shapeFile = "skel";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	flameShapeName = "lflame";
	shieldShapeName = "shield";
	shadowDetailMask = 1;

	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
	canCrouch = false;

	maxJetSideForceFactor = 1;
	maxJetForwardVelocity = 1.0;
	minJetEnergy = 60;
	jetForce = 1;
	jetEnergyDrain = 0.0;

	maxDamage = 1.0;
	maxForwardSpeed = $spdmed;
	maxBackwardSpeed = $spdmed * 0.8;
	maxSideSpeed = $spdmed * 0.75;

	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 60;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

	jumpImpulse = 75;
	jumpSurfaceMinDot = $jumpSurfaceMinDot;

	// animation data:
	// animation name, one shot, direction, firstPerson, chaseCam, thirdPerson, signalThread
	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "die back", none, 1, true, false, false, false, 0 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
	// death animations:
	animData[25] = { "crouch die", none, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", none, 1, false, false, false, false, 4 };
	animData[27] = { "die head", none, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", none, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", none, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", none, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", none, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", none, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", none, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", none, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", none, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", none, 1, false, false, false, false, 4 };
	animData[37] = { "die back", none, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 

	// celebration animations:
	animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
	// taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;
	rFootSounds = 
	{
		SoundLFootRSoft,
		SoundLFootRHard,
		SoundLFootRSoft,
		SoundLFootRHard,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRHard,
		SoundLFootRSnow,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft
	}; 
	lFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLHard,
		SoundLFootLSoft,
		SoundLFootLHard,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLHard,
		SoundLFootLSnow,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft
	};

	footPrints = { 0, 1 };

	boxWidth = 0.5;
	boxDepth = 0.5;
	boxNormalHeight = 2.3;
	boxCrouchHeight = 1.8;

	boxNormalHeadPercentage  = 0.83;
	boxNormalTorsoPercentage = 0.53;
	boxCrouchHeadPercentage  = 0.6666;
	boxCrouchTorsoPercentage = 0.3333;

	boxHeadLeftPercentage  = 0;
	boxHeadRightPercentage = 1;
	boxHeadBackPercentage  = 0;
	boxHeadFrontPercentage = 1;
};

//------------------------------------------------------------------
// Demon Armor data:	(minotaur player model)
//------------------------------------------------------------------

PlayerData DemonArmor
{
	className = "Armor";
	shapeFile = "min";
	flameShapeName = "mflame";
	shieldShapeName = "shield";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	shadowDetailMask = 1;

	canCrouch = false;
	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";

	maxJetSideForceFactor = 1;
	maxJetForwardVelocity = 1.0;
	minJetEnergy = 60;
	jetForce = 1;
	jetEnergyDrain = 0.0;

	maxDamage = 1.0;
	maxForwardSpeed = $spdmed;
	maxBackwardSpeed = $spdmed * 0.8;
	maxSideSpeed = $spdmed * 0.75;
	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 80;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

	jumpImpulse = 75;
	jumpSurfaceMinDot = $jumpSurfaceMinDot;

	// animation data:
	// animation name, one shot, exclude, direction, firstPerson, chaseCam, thirdPerson, signalThread

	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "die back", none, 1, true, false, false, false, 0 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
	// death animations:
	animData[25] = { "crouch die", none, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", none, 1, false, false, false, false, 4 };
	animData[27] = { "die head", none, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", none, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", none, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", none, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", none, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", none, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", none, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", none, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", none, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", none, 1, false, false, false, false, 4 };
	animData[37] = { "die back", none, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 

	// celebraton animations:
	animData[43] = { "celebration 1", none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };

	// taunt anmations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };

	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;

	rFootSounds = 
	{
		SoundMFootRSoft,
		SoundMFootRHard,
		SoundMFootRSoft,
		SoundMFootRHard,
		SoundMFootRSoft,
		SoundMFootRSoft,
		SoundMFootRSoft,
		SoundMFootRHard,
		SoundMFootRSnow,
		SoundMFootRSoft,
		SoundMFootRSoft,
		SoundMFootRSoft,
		SoundMFootRSoft,
		SoundMFootRSoft,
		SoundMFootRSoft
	}; 
	lFootSounds =
	{
		SoundMFootLSoft,
		SoundMFootLHard,
		SoundMFootLSoft,
		SoundMFootLHard,
		SoundMFootLSoft,
		SoundMFootLSoft,
		SoundMFootLSoft,
		SoundMFootLHard,
		SoundMFootLSnow,
		SoundMFootLSoft,
		SoundMFootLSoft,
		SoundMFootLSoft,
		SoundMFootLSoft,
		SoundMFootLSoft,
		SoundMFootLSoft
	};

	footPrints = { 2, 3 };

	boxWidth = 0.7;
	boxDepth = 0.7;
	boxNormalHeight = 2.4;

	boxNormalHeadPercentage  = 0.83;
	boxNormalTorsoPercentage = 0.49;

	boxHeadLeftPercentage  = 0;
	boxHeadRightPercentage = 1;
	boxHeadBackPercentage  = 0;
	boxHeadFrontPercentage = 1;
};

//------------------------------------------------------------------
// Cultist armor data:	(light) (this might be unecssary with just a skin change...)
//------------------------------------------------------------------

PlayerData CultistArmor
{
	className = "Armor";
	shapeFile = "rpgmalehuman";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	flameShapeName = "lflame";
	shieldShapeName = "shield";
	shadowDetailMask = 1;

	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
	canCrouch = false;

	maxJetSideForceFactor = 1;
	maxJetForwardVelocity = 1.0;
	minJetEnergy = 60;
	jetForce = 1;
	jetEnergyDrain = 0.0;

	maxDamage = 1.0;
	maxForwardSpeed = $spdmed;
	maxBackwardSpeed = $spdmed * 0.8;
	maxSideSpeed = $spdmed * 0.75;

	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 60;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

	jumpImpulse = 75;
	jumpSurfaceMinDot = $jumpSurfaceMinDot;

	// animation data:
	// animation name, one shot, direction, firstPerson, chaseCam, thirdPerson, signalThread
	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "die back", none, 1, true, false, false, false, 0 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
	// death animations:
	animData[25] = { "crouch die", none, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", none, 1, false, false, false, false, 4 };
	animData[27] = { "die head", none, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", none, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", none, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", none, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", none, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", none, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", none, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", none, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", none, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", none, 1, false, false, false, false, 4 };
	animData[37] = { "die back", none, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 

	// celebration animations:
	animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
	// taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;
	rFootSounds = 
	{
		SoundLFootRSoft,
		SoundLFootRHard,
		SoundLFootRSoft,
		SoundLFootRHard,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRHard,
		SoundLFootRSnow,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft
	}; 
	lFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLHard,
		SoundLFootLSoft,
		SoundLFootLHard,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLHard,
		SoundLFootLSnow,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft
	};

	footPrints = { 0, 1 };

	boxWidth = 0.5;
	boxDepth = 0.5;
	boxNormalHeight = 2.3;
	boxCrouchHeight = 1.8;

	boxNormalHeadPercentage  = 0.83;
	boxNormalTorsoPercentage = 0.53;
	boxCrouchHeadPercentage  = 0.6666;
	boxCrouchTorsoPercentage = 0.3333;

	boxHeadLeftPercentage  = 0;
	boxHeadRightPercentage = 1;
	boxHeadBackPercentage  = 0;
	boxHeadFrontPercentage = 1;
};

//------------------------------------------------------------------
// Cultist armor data:	(light) (this might be unecssary with just a skin change...)
//------------------------------------------------------------------

PlayerData ShinraArmor
{
	className = "Armor";
	shapeFile = "rpgmalehuman";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	flameShapeName = "lflame";
	shieldShapeName = "shield";
	shadowDetailMask = 1;

	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
	canCrouch = false;

	maxJetSideForceFactor = 1;
	maxJetForwardVelocity = 1.0;
	minJetEnergy = 60;
	jetForce = 1;
	jetEnergyDrain = 0.0;

	maxDamage = 1.0;
	maxForwardSpeed = $spdmed;
	maxBackwardSpeed = $spdmed * 0.8;
	maxSideSpeed = $spdmed * 0.75;

	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 60;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

	jumpImpulse = 75;
	jumpSurfaceMinDot = $jumpSurfaceMinDot;

	// animation data:
	// animation name, one shot, direction, firstPerson, chaseCam, thirdPerson, signalThread
	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "die back", none, 1, true, false, false, false, 0 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
	// death animations:
	animData[25] = { "crouch die", none, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", none, 1, false, false, false, false, 4 };
	animData[27] = { "die head", none, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", none, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", none, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", none, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", none, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", none, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", none, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", none, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", none, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", none, 1, false, false, false, false, 4 };
	animData[37] = { "die back", none, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 

	// celebration animations:
	animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
	// taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;
	rFootSounds = 
	{
		SoundLFootRSoft,
		SoundLFootRHard,
		SoundLFootRSoft,
		SoundLFootRHard,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRHard,
		SoundLFootRSnow,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft
	}; 
	lFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLHard,
		SoundLFootLSoft,
		SoundLFootLHard,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLHard,
		SoundLFootLSnow,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft
	};

	footPrints = { 0, 1 };

	boxWidth = 0.5;
	boxDepth = 0.5;
	boxNormalHeight = 2.3;
	boxCrouchHeight = 1.8;

	boxNormalHeadPercentage  = 0.83;
	boxNormalTorsoPercentage = 0.53;
	boxCrouchHeadPercentage  = 0.6666;
	boxCrouchTorsoPercentage = 0.3333;

	boxHeadLeftPercentage  = 0;
	boxHeadRightPercentage = 1;
	boxHeadBackPercentage  = 0;
	boxHeadFrontPercentage = 1;
};

//------------------------------------------------------------------
// Spider Armor data: Creepy brown spider that crawls around
//------------------------------------------------------------------
PlayerData SpiderArmor
{
	className = "Armor";
	shapeFile = "spiderarmor1";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	flameShapeName = "lflame";
	shieldShapeName = "shield";
	shadowDetailMask = 1;

	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
	canCrouch = false;

	maxJetSideForceFactor = 1;
	maxJetForwardVelocity = 1.0;
	minJetEnergy = 60;
	jetForce = 1;
	jetEnergyDrain = 0.0;

	maxDamage = 1.0;
	maxForwardSpeed = $spdmed;
	maxBackwardSpeed = $spdmed * 0.8;
	maxSideSpeed = $spdmed * 0.75;

	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 60;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

	jumpImpulse = 75;
	jumpSurfaceMinDot = $jumpSurfaceMinDot;

	// animation data:
	// animation name, one shot, direction, firstPerson, chaseCam, thirdPerson, signalThread
	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "die back", none, 1, true, false, false, false, 0 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
	// death animations:
	animData[25] = { "crouch die", none, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", none, 1, false, false, false, false, 4 };
	animData[27] = { "die head", none, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", none, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", none, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", none, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", none, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", none, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", none, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", none, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", none, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", none, 1, false, false, false, false, 4 };
	animData[37] = { "die back", none, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 

	// celebration animations:
	animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
	// taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;
	rFootSounds = 
	{
		SoundLFootRSoft,
		SoundLFootRHard,
		SoundLFootRSoft,
		SoundLFootRHard,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRHard,
		SoundLFootRSnow,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft
	}; 
	lFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLHard,
		SoundLFootLSoft,
		SoundLFootLHard,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLHard,
		SoundLFootLSnow,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft
	};

	footPrints = { 0, 1 };

	boxWidth = 0.5;
	boxDepth = 0.5;
	boxNormalHeight = 2.3;
	boxCrouchHeight = 1.8;

	boxNormalHeadPercentage  = 0.83;
	boxNormalTorsoPercentage = 0.53;
	boxCrouchHeadPercentage  = 0.6666;
	boxCrouchTorsoPercentage = 0.3333;

	boxHeadLeftPercentage  = 0;
	boxHeadRightPercentage = 1;
	boxHeadBackPercentage  = 0;
	boxHeadFrontPercentage = 1;
};

//------------------------------------------------------------------
// Godeye Armor data: Red blob demon surounded by a metal sphere, kinda weird but cool
//------------------------------------------------------------------

PlayerData GodeyeArmor
{
	className = "Armor";
	shapeFile = "godeyes";
	flameShapeName = "hflame";
	shieldShapeName = "shield";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	shadowDetailMask = 1;

	canCrouch = false;
	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";

	maxJetSideForceFactor = 0.8;
	maxJetForwardVelocity = 22;
	minJetEnergy = 1;
	jetForce = 320;
	jetEnergyDrain = 100.0;

	maxDamage = 1.0;
	maxForwardSpeed = 30;
	maxBackwardSpeed = $spdhigher-1;
	maxSideSpeed = $spdhigher-1;
	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 110;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 25;
	damageScale = 0.006;

	jumpImpulse = 75;
	jumpSurfaceMinDot = 0.2;

	// animation data:
	// animation name, one shot, exclude, direction, firstPerson, chaseCam, thirdPerson, signalThread

	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "PDA access", none, 1, true, false, false, false, 3 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };

	// death animations:
	animData[25] = { "crouch die", none, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", none, 1, false, false, false, false, 4 };
	animData[27] = { "die head", none, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", none, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", none, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", none, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", none, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", none, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", none, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", none, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", none, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", none, 1, false, false, false, false, 4 };
	animData[37] = { "die back", none, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, true, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 };

	// celebraton animations:
	animData[43] = { "celebration 1", none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };

	// taunt anmations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };

	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;

	rFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft
	};
	lFootSounds =
	{
		SoundLFootLSoft, // godeyestepsound,
		SoundLFootLSoft, // godeyestepsound,
		SoundLFootLSoft, // godeyestepsound,
		SoundLFootLSoft, // godeyestepsound,
		SoundLFootLSoft, // godeyestepsound,
		SoundLFootLSoft, // godeyestepsound,
		SoundLFootLSoft, // godeyestepsound,
		SoundLFootLSoft, // godeyestepsound,
		SoundLFootLSoft, // godeyestepsound,
		SoundLFootLSoft, // godeyestepsound,
		SoundLFootLSoft, // godeyestepsound,
		SoundLFootLSoft, // godeyestepsound,
		SoundLFootLSoft, // godeyestepsound,
		SoundLFootLSoft, // godeyestepsound,
		SoundLFootLSoft // godeyestepsound
	};

	footPrints = { 4, 5 };

	boxWidth = 0.8;
	boxDepth = 0.8;
	boxNormalHeight = 2.6;

	boxNormalHeadPercentage  = 0.70;
	boxNormalTorsoPercentage = 0.45;

	boxHeadLeftPercentage  = 0.48;
	boxHeadRightPercentage = 0.70;
	boxHeadBackPercentage  = 0.48;
	boxHeadFrontPercentage = 0.60;
};

//------------------------------------------------------------------
// Bat Armor: Cute little brown bat that flies around
//------------------------------------------------------------------

PlayerData BatArmor
{
	className = "Armor";
	shapeFile = "batarmor";
	flameShapeName = "hflame";
	shieldShapeName = "shield";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	shadowDetailMask = 1;

	canCrouch = false;
	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";

	maxJetSideForceFactor = 0.8;
	maxJetForwardVelocity = 22;
	minJetEnergy = 1;
	jetForce = 320;
	jetEnergyDrain = 100.0;

	maxDamage = 1.0;
	maxForwardSpeed = 30;
	maxBackwardSpeed = $spdhigher-1;
	maxSideSpeed = $spdhigher-1;
	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 110;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 25;
	damageScale = 0.006;

	jumpImpulse = 75;
	jumpSurfaceMinDot = 0.2;

	// animation data:
	// animation name, one shot, exclude, direction, firstPerson, chaseCam, thirdPerson, signalThread

	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "PDA access", none, 1, true, false, false, false, 3 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };

	// death animations:
	animData[25] = { "crouch die", none, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", none, 1, false, false, false, false, 4 };
	animData[27] = { "die head", none, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", none, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", none, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", none, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", none, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", none, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", none, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", none, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", none, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", none, 1, false, false, false, false, 4 };
	animData[37] = { "die back", none, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, true, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 };

	// celebraton animations:
	animData[43] = { "celebration 1", none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };

	// taunt anmations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };

	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;

	rFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft
	};
	lFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft, 
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft 
	};

	footPrints = { 4, 5 };

	boxWidth = 0.8;
	boxDepth = 0.8;
	boxNormalHeight = 2.6;

	boxNormalHeadPercentage  = 0.70;
	boxNormalTorsoPercentage = 0.45;

	boxHeadLeftPercentage  = 0.48;
	boxHeadRightPercentage = 0.70;
	boxHeadBackPercentage  = 0.48;
	boxHeadFrontPercentage = 0.60;
};

//------------------------------------------------------------------
// Golem Armor: Weird heavy armor with shoulder blades? not sure if good or not to use, seems like it needs skin applied
// works well with duke (nasty looking demon) and skquid (crazy black anarchistic looking thing)
//------------------------------------------------------------------

PlayerData GolemArmor
{
	className = "Armor";
	shapeFile = "golem";
	flameShapeName = "hflame";
	shieldShapeName = "shield";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	shadowDetailMask = 1;

	canCrouch = false;
	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";

	maxJetSideForceFactor = 0.8;
	maxJetForwardVelocity = 22;
	minJetEnergy = 1;
	jetForce = 320;
	jetEnergyDrain = 100.0;

	maxDamage = 1.0;
	maxForwardSpeed = 30;
	maxBackwardSpeed = $spdhigher-1;
	maxSideSpeed = $spdhigher-1;
	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 110;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 25;
	damageScale = 0.006;

	jumpImpulse = 75;
	jumpSurfaceMinDot = 0.2;

	// animation data:
	// animation name, one shot, exclude, direction, firstPerson, chaseCam, thirdPerson, signalThread

	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "PDA access", none, 1, true, false, false, false, 3 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };

	// death animations:
	animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, true, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 };

	// celebraton animations:
	animData[43] = { "celebration 1", none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };

	// taunt anmations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };

	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;

	rFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft
	};
	lFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft, 
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft 
	};

	footPrints = { 4, 5 };

	boxWidth = 0.8;
	boxDepth = 0.8;
	boxNormalHeight = 2.6;

	boxNormalHeadPercentage  = 0.70;
	boxNormalTorsoPercentage = 0.45;

	boxHeadLeftPercentage  = 0.48;
	boxHeadRightPercentage = 0.70;
	boxHeadBackPercentage  = 0.48;
	boxHeadFrontPercentage = 0.60;
};

//------------------------------------------------------------------
// SDaemon Armor: Purple and yellow bug looking demon, freaky and skin looks okay
//------------------------------------------------------------------

PlayerData SDaemonArmor
{
	className = "Armor";
	shapeFile = "sdaemon";
	flameShapeName = "hflame";
	shieldShapeName = "shield";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	shadowDetailMask = 1;

	canCrouch = false;
	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";

	maxJetSideForceFactor = 0.8;
	maxJetForwardVelocity = 22;
	minJetEnergy = 1;
	jetForce = 320;
	jetEnergyDrain = 100.0;

	maxDamage = 1.0;
	maxForwardSpeed = $spdmed;
	maxBackwardSpeed = $spdmed * 0.8;
	maxSideSpeed = $spdmed * 0.75;

	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 110;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 25;
	damageScale = 0.006;

	jumpImpulse = 75;
	jumpSurfaceMinDot = 0.2;

	// animation data:
	// animation name, one shot, exclude, direction, firstPerson, chaseCam, thirdPerson, signalThread

	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "PDA access", none, 1, true, false, false, false, 3 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };

	// death animations:
	animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, true, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 };

	// celebraton animations:
	animData[43] = { "celebration 1", none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };

	// taunt anmations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };

	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;

	rFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft
	};
	lFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft, 
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft 
	};

	footPrints = { 4, 5 };

	boxWidth = 0.8;
	boxDepth = 0.8;
	boxNormalHeight = 2.6;

	boxNormalHeadPercentage  = 0.70;
	boxNormalTorsoPercentage = 0.45;

	boxHeadLeftPercentage  = 0.48;
	boxHeadRightPercentage = 0.70;
	boxHeadBackPercentage  = 0.48;
	boxHeadFrontPercentage = 0.60;
};

//------------------------------------------------------------------
// BlobMonsterArmor: Looks like a black and gray slime
// RMSKins1 (Lava Blob), RMSkins2 (gray blob), 3 (black blob) 4 (Green acid)
//------------------------------------------------------------------

PlayerData BlobMonsterArmor
{
	className = "Armor";
	shapeFile = "blobmonster";
	flameShapeName = "hflame";
	shieldShapeName = "shield";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	shadowDetailMask = 1;

	canCrouch = false;
	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";

	maxJetSideForceFactor = 0.8;
	maxJetForwardVelocity = 22;
	minJetEnergy = 1;
	jetForce = 320;
	jetEnergyDrain = 100.0;

	maxDamage = 1.0;
	maxForwardSpeed = $spdlow;
	maxBackwardSpeed = $spdlow-1;
	maxSideSpeed = $spdlow-1;
	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 110;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 25;
	damageScale = 0.006;

	jumpImpulse = 75;
	jumpSurfaceMinDot = 0.2;

	// animation data:
	// animation name, one shot, exclude, direction, firstPerson, chaseCam, thirdPerson, signalThread

	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "PDA access", none, 1, true, false, false, false, 3 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };

	// death animations:
	animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, true, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 };

	// celebraton animations:
	animData[43] = { "celebration 1", none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };

	// taunt anmations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };

	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;

	rFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft
	};
	lFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft, 
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft 
	};

	footPrints = { 4, 5 };

	boxWidth = 0.8;
	boxDepth = 0.8;
	boxNormalHeight = 2.6;

	boxNormalHeadPercentage  = 0.70;
	boxNormalTorsoPercentage = 0.45;

	boxHeadLeftPercentage  = 0.48;
	boxHeadRightPercentage = 0.70;
	boxHeadBackPercentage  = 0.48;
	boxHeadFrontPercentage = 0.60;
};

//------------------------------------------------------------------
// DragonArmor: A friggen big red dragon, very cool looking
//------------------------------------------------------------------

PlayerData DragonArmor
{
	className = "Armor";
	shapeFile = "dragonarmor";
	flameShapeName = "hflame";
	shieldShapeName = "shield";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	shadowDetailMask = 1;

	canCrouch = false;
	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";

	maxJetSideForceFactor = 0.8;
	maxJetForwardVelocity = 22;
	minJetEnergy = 1;
	jetForce = 320;
	jetEnergyDrain = 100.0;

	maxDamage = 1.0;
	maxForwardSpeed = 30;
	maxBackwardSpeed = $spdhigher-1;
	maxSideSpeed = $spdhigher-1;
	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 110;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 25;
	damageScale = 0.006;

	jumpImpulse = 75;
	jumpSurfaceMinDot = 0.2;

	// animation data:
	// animation name, one shot, exclude, direction, firstPerson, chaseCam, thirdPerson, signalThread

	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "PDA access", none, 1, true, false, false, false, 3 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };

	// death animations:
	animData[25] = { "crouch die", none, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", none, 1, false, false, false, false, 4 };
	animData[27] = { "die head", none, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", none, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", none, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", none, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", none, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", none, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", none, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", none, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", none, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", none, 1, false, false, false, false, 4 };
	animData[37] = { "die back", none, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, true, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 };

	// celebraton animations:
	animData[43] = { "celebration 1", none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };

	// taunt anmations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };

	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;

	rFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft
	};
	lFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft, 
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft 
	};

	footPrints = { 4, 5 };

	// boxWidth = 0.8;
	// boxDepth = 0.8;
	// boxNormalHeight = 2.6;
	boxWidth = 4;
	boxDepth = 2;
	boxNormalHeight = 8.5; // goood

	boxNormalHeadPercentage  = 0.70;
	boxNormalTorsoPercentage = 0.45;

	boxHeadLeftPercentage  = 0.48;
	boxHeadRightPercentage = 0.70;
	boxHeadBackPercentage  = 0.48;
	boxHeadFrontPercentage = 0.60;
};

//------------------------------------------------------------------
// WalkSkeleArmor - Glowing white skeleton, minimal motion (can walk though)
//------------------------------------------------------------------

PlayerData WalkSkeleArmor
{
	className = "Armor";
	shapeFile = "walkskelearmor1";
	flameShapeName = "hflame";
	shieldShapeName = "shield";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	shadowDetailMask = 1;

	canCrouch = false;
	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";

	maxJetSideForceFactor = 0.8;
	maxJetForwardVelocity = 22;
	minJetEnergy = 1;
	jetForce = 320;
	jetEnergyDrain = 100.0;

	maxDamage = 1.0;
	maxForwardSpeed = 30;
	maxBackwardSpeed = $spdhigher-1;
	maxSideSpeed = $spdhigher-1;
	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 110;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 25;
	damageScale = 0.006;

	jumpImpulse = 75;
	jumpSurfaceMinDot = 0.2;

	// animation data:
	// animation name, one shot, exclude, direction, firstPerson, chaseCam, thirdPerson, signalThread

	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "PDA access", none, 1, true, false, false, false, 3 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };

	// death animations:
	animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, true, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 };

	// celebraton animations:
	animData[43] = { "celebration 1", none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };

	// taunt anmations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };

	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;

	rFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft
	};
	lFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft, 
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft 
	};

	footPrints = { 4, 5 };

	boxWidth = 0.8;
	boxDepth = 0.8;
	boxNormalHeight = 2.6;

	boxNormalHeadPercentage  = 0.70;
	boxNormalTorsoPercentage = 0.45;

	boxHeadLeftPercentage  = 0.48;
	boxHeadRightPercentage = 0.70;
	boxHeadBackPercentage  = 0.48;
	boxHeadFrontPercentage = 0.60;
};

//------------------------------------------------------------------
// RMRUuagArmor - Orange weird headed gobllin, RMSKins2 - Pure black oakish looking demon thing?
//------------------------------------------------------------------

PlayerData RMRUuagArmor
{
	className = "Armor";
	shapeFile = "rmruuag";
	flameShapeName = "hflame";
	shieldShapeName = "shield";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	shadowDetailMask = 1;

	canCrouch = false;
	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";

	maxJetSideForceFactor = 0.8;
	maxJetForwardVelocity = 22;
	minJetEnergy = 1;
	jetForce = 320;
	jetEnergyDrain = 100.0;

	maxDamage = 1.0;
	maxForwardSpeed = 30;
	maxBackwardSpeed = $spdhigher-1;
	maxSideSpeed = $spdhigher-1;
	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 110;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 25;
	damageScale = 0.006;

	jumpImpulse = 75;
	jumpSurfaceMinDot = 0.2;

	// animation data:
	// animation name, one shot, exclude, direction, firstPerson, chaseCam, thirdPerson, signalThread

	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "PDA access", none, 1, true, false, false, false, 3 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };

	// death animations:
	animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, true, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 };

	// celebraton animations:
	animData[43] = { "celebration 1", none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };

	// taunt anmations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };

	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;

	rFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft
	};
	lFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft, 
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft 
	};

	footPrints = { 4, 5 };

	boxWidth = 0.8;
	boxDepth = 0.8;
	boxNormalHeight = 2.6;

	boxNormalHeadPercentage  = 0.70;
	boxNormalTorsoPercentage = 0.45;

	boxHeadLeftPercentage  = 0.48;
	boxHeadRightPercentage = 0.70;
	boxHeadBackPercentage  = 0.48;
	boxHeadFrontPercentage = 0.60;
};

//------------------------------------------------------------------
// BearArmor - Bear armor, looks like a brown bear, has a bear head, and is a bear
//------------------------------------------------------------------

PlayerData BearArmor
{
	className = "Armor";
	shapeFile = "beararmor";
	flameShapeName = "hflame";
	shieldShapeName = "shield";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	shadowDetailMask = 1;

	canCrouch = false;
	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";

	maxJetSideForceFactor = 0.8;
	maxJetForwardVelocity = 22;
	minJetEnergy = 1;
	jetForce = 320;
	jetEnergyDrain = 100.0;

	maxDamage = 1.0;
	maxForwardSpeed = $spdmed;
	maxBackwardSpeed = $spdmed-5;
	maxSideSpeed = $spdmed-5;
	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 110;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 25;
	damageScale = 0.006;

	jumpImpulse = 75;
	jumpSurfaceMinDot = 0.2;

	// animation data:
	// animation name, one shot, exclude, direction, firstPerson, chaseCam, thirdPerson, signalThread

	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "PDA access", none, 1, true, false, false, false, 3 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };

	// death animations:
	animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, true, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 };

	// celebraton animations:
	animData[43] = { "celebration 1", none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };

	// taunt anmations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };

	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;

	rFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft
	};
	lFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft, 
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft 
	};

	footPrints = { 4, 5 };

	boxWidth = 0.8;
	boxDepth = 0.8;
	boxNormalHeight = 2.6;

	boxNormalHeadPercentage  = 0.70;
	boxNormalTorsoPercentage = 0.45;

	boxHeadLeftPercentage  = 0.48;
	boxHeadRightPercentage = 0.70;
	boxHeadBackPercentage  = 0.48;
	boxHeadFrontPercentage = 0.60;
};

//------------------------------------------------------------------
// Floating Head Armor - Floating head with spike, Duke (doomish/demonish) and skquid (undead looking)
//------------------------------------------------------------------

PlayerData FloatingHeadArmor
{
	className = "Armor";
	shapeFile = "floatinghead";
	flameShapeName = "lflame";
	shieldShapeName = "shield";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	shadowDetailMask = 1;

	canCrouch = false;
	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";

	maxJetSideForceFactor = 0.8;
	maxJetForwardVelocity = 22;
	minJetEnergy = 1;
	jetForce = 320;
	jetEnergyDrain = 100.0;

	maxDamage = 1.0;
	maxForwardSpeed = 30;
	maxBackwardSpeed = $spdhigher-1;
	maxSideSpeed = $spdhigher-1;
	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 110;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 25;
	damageScale = 0.006;

	jumpImpulse = 75;
	jumpSurfaceMinDot = 0.2;

	// animation data:
	// animation name, one shot, exclude, direction, firstPerson, chaseCam, thirdPerson, signalThread

	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "PDA access", none, 1, true, false, false, false, 3 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };

	// death animations:
	animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, true, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 };

	// celebraton animations:
	animData[43] = { "celebration 1", none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };

	// taunt anmations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };

	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;

	rFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft
	};
	lFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft, 
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft 
	};

	footPrints = { 4, 5 };

	boxWidth = 0.8;
	boxDepth = 0.8;
	boxNormalHeight = 2.6;

	boxNormalHeadPercentage  = 0.70;
	boxNormalTorsoPercentage = 0.45;

	boxHeadLeftPercentage  = 0.48;
	boxHeadRightPercentage = 0.70;
	boxHeadBackPercentage  = 0.48;
	boxHeadFrontPercentage = 0.60;
};

//----------------------------------------------------------------------
// Ghost Armor - Invisible state, kind of like an invisible stalker
//------------------------------------------------------------------

PlayerData GhostArmor
{
	className = "Armor";
	shapeFile = "invisable";
	flameShapeName = "lflame";
	shieldShapeName = "shield";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	shadowDetailMask = 1;

	canCrouch = false;
	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";

	maxJetSideForceFactor = 0.8;
	maxJetForwardVelocity = 22;
	minJetEnergy = 1;
	jetForce = 320;
	jetEnergyDrain = 100.0;

	maxDamage = 1.0;
	maxForwardSpeed = 30;
	maxBackwardSpeed = $spdhigher-1;
	maxSideSpeed = $spdhigher-1;
	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 110;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 25;
	damageScale = 0.006;

	jumpImpulse = 75;
	jumpSurfaceMinDot = 0.2;

	// animation data:
	// animation name, one shot, exclude, direction, firstPerson, chaseCam, thirdPerson, signalThread

	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "PDA access", none, 1, true, false, false, false, 3 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };

	// death animations:
	animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, true, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 };

	// celebraton animations:
	animData[43] = { "celebration 1", none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };

	// taunt anmations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };

	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;

	rFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft
	};
	lFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft, 
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft 
	};

	footPrints = { 4, 5 };

	boxWidth = 0.8;
	boxDepth = 0.8;
	boxNormalHeight = 2.6;

	boxNormalHeadPercentage  = 0.70;
	boxNormalTorsoPercentage = 0.45;

	boxHeadLeftPercentage  = 0.48;
	boxHeadRightPercentage = 0.70;
	boxHeadBackPercentage  = 0.48;
	boxHeadFrontPercentage = 0.60;
};

//------------------------------------------------------------------
// Amazon Armor - Requires RMSkins3
//------------------------------------------------------------------

PlayerData AmazonArmor
{
	className = "Armor";
	shapeFile = "rmoonfemale";
	flameShapeName = "lflame";
	shieldShapeName = "shield";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	shadowDetailMask = 1;

	canCrouch = false;
	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";

	maxJetSideForceFactor = 0.8;
	maxJetForwardVelocity = 22;
	minJetEnergy = 1;
	jetForce = 320;
	jetEnergyDrain = 100.0;

	maxDamage = 1.0;
	maxForwardSpeed = 30;
	maxBackwardSpeed = $spdhigher-1;
	maxSideSpeed = $spdhigher-1;
	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 110;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 25;
	damageScale = 0.006;

	jumpImpulse = 75;
	jumpSurfaceMinDot = 0.2;

	// animation data:
	// animation name, one shot, exclude, direction, firstPerson, chaseCam, thirdPerson, signalThread

	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "PDA access", none, 1, true, false, false, false, 3 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };

	// death animations:
	animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, true, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 };

	// celebraton animations:
	animData[43] = { "celebration 1", none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };

	// taunt anmations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };

	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;

	rFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft
	};
	lFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft, 
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft 
	};

	footPrints = { 4, 5 };

	boxWidth = 0.8;
	boxDepth = 0.8;
	boxNormalHeight = 2.6;

	boxNormalHeadPercentage  = 0.70;
	boxNormalTorsoPercentage = 0.45;

	boxHeadLeftPercentage  = 0.48;
	boxHeadRightPercentage = 0.70;
	boxHeadBackPercentage  = 0.48;
	boxHeadFrontPercentage = 0.60;
};

//------------------------------------------------------------------
// RMZombieArmor - Requires RMSKins2
//------------------------------------------------------------------

PlayerData RMZombieArmor
{
	className = "Armor";
	shapeFile = "rmzombie";
	flameShapeName = "lflame";
	shieldShapeName = "shield";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	shadowDetailMask = 1;

	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
	canCrouch = false;

	maxJetSideForceFactor = 1;
	maxJetForwardVelocity = 1.0;
	minJetEnergy = 60;
	jetForce = 1;
	jetEnergyDrain = 0.0;

	maxDamage = 1.0;
	maxForwardSpeed = $spdlowmed;
	maxBackwardSpeed = $spdlowmed * 0.8;
	maxSideSpeed = $spdlowmed * 0.75;

	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 60;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

	jumpImpulse = 75;
	jumpSurfaceMinDot = $jumpSurfaceMinDot;

	// animation data:
	// animation name, one shot, direction, firstPerson, chaseCam, thirdPerson, signalThread
	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "die back", none, 1, true, false, false, false, 0 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
	// death animations:
	animData[25] = { "crouch die", none, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", none, 1, false, false, false, false, 4 };
	animData[27] = { "die head", none, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", none, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", none, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", none, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", none, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", none, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", none, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", none, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", none, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", none, 1, false, false, false, false, 4 };
	animData[37] = { "die back", none, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 

	// celebration animations:
	animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
	// taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;
	rFootSounds = 
	{
		SoundLFootRSoft,
		SoundLFootRHard,
		SoundLFootRSoft,
		SoundLFootRHard,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRHard,
		SoundLFootRSnow,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft,
		SoundLFootRSoft
	}; 
	lFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLHard,
		SoundLFootLSoft,
		SoundLFootLHard,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLHard,
		SoundLFootLSnow,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft
	};

	footPrints = { 0, 1 };

	boxWidth = 0.5;
	boxDepth = 0.5;
	boxNormalHeight = 2.3;
	boxCrouchHeight = 1.8;

	boxNormalHeadPercentage  = 0.83;
	boxNormalTorsoPercentage = 0.53;
	boxCrouchHeadPercentage  = 0.6666;
	boxCrouchTorsoPercentage = 0.3333;

	boxHeadLeftPercentage  = 0;
	boxHeadRightPercentage = 1;
	boxHeadBackPercentage  = 0;
	boxHeadFrontPercentage = 1;
};

//------------------------------------------------------------------
// Mage Male - Basically adds the robe, good for cultist skin (RMSkins3)
//------------------------------------------------------------------

PlayerData MageMaleArmor
{
	className = "Armor";
	shapeFile = "magemale";
	flameShapeName = "lflame";
	shieldShapeName = "shield";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	shadowDetailMask = 1;

	canCrouch = false;
	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";

	maxJetSideForceFactor = 0.8;
	maxJetForwardVelocity = 22;
	minJetEnergy = 1;
	jetForce = 320;
	jetEnergyDrain = 100.0;

	maxDamage = 1.0;
	maxForwardSpeed = 30;
	maxBackwardSpeed = $spdhigher-1;
	maxSideSpeed = $spdhigher-1;
	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 110;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 25;
	damageScale = 0.006;

	jumpImpulse = 75;
	jumpSurfaceMinDot = 0.2;

	// animation data:
	// animation name, one shot, exclude, direction, firstPerson, chaseCam, thirdPerson, signalThread

	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "PDA access", none, 1, true, false, false, false, 3 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };

	// death animations:
	animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, true, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 };

	// celebraton animations:
	animData[43] = { "celebration 1", none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };

	// taunt anmations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };

	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;

	rFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft
	};
	lFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft, 
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft 
	};

	footPrints = { 4, 5 };

	boxWidth = 0.8;
	boxDepth = 0.8;
	boxNormalHeight = 2.6;

	boxNormalHeadPercentage  = 0.70;
	boxNormalTorsoPercentage = 0.45;

	boxHeadLeftPercentage  = 0.48;
	boxHeadRightPercentage = 0.70;
	boxHeadBackPercentage  = 0.48;
	boxHeadFrontPercentage = 0.60;
};

//------------------------------------------------------------------
// New Mino Armor - Has better horns, looks weird as a mino (RMSkins3) butttt, duke looks like an awesome shadow demon with horns
//------------------------------------------------------------------

PlayerData NewMinoArmor
{
	className = "Armor";
	shapeFile = "newmino";
	flameShapeName = "lflame";
	shieldShapeName = "shield";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	shadowDetailMask = 1;

	canCrouch = false;
	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";

	maxJetSideForceFactor = 1;
	maxJetForwardVelocity = 1.0;
	minJetEnergy = 60;
	jetForce = 1;
	jetEnergyDrain = 0.0;

	maxDamage = 1.0;
	maxForwardSpeed = $spdlowmed;
	maxBackwardSpeed = $spdlowmed * 0.8;
	maxSideSpeed = $spdlowmed * 0.75;
	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 80;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

	jumpImpulse = 75;
	jumpSurfaceMinDot = $jumpSurfaceMinDot;

	// animation data:
	// animation name, one shot, exclude, direction, firstPerson, chaseCam, thirdPerson, signalThread

	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "die back", none, 1, true, false, false, false, 0 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
	// death animations:
	animData[25] = { "crouch die", none, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", none, 1, false, false, false, false, 4 };
	animData[27] = { "die head", none, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", none, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", none, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", none, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", none, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", none, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", none, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", none, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", none, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", none, 1, false, false, false, false, 4 };
	animData[37] = { "die back", none, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 

	// celebraton animations:
	animData[43] = { "celebration 1", none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };

	// taunt anmations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };

	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;

	rFootSounds = 
	{
		SoundMFootRSoft,
		SoundMFootRHard,
		SoundMFootRSoft,
		SoundMFootRHard,
		SoundMFootRSoft,
		SoundMFootRSoft,
		SoundMFootRSoft,
		SoundMFootRHard,
		SoundMFootRSnow,
		SoundMFootRSoft,
		SoundMFootRSoft,
		SoundMFootRSoft,
		SoundMFootRSoft,
		SoundMFootRSoft,
		SoundMFootRSoft
	}; 
	lFootSounds =
	{
		SoundMFootLSoft,
		SoundMFootLHard,
		SoundMFootLSoft,
		SoundMFootLHard,
		SoundMFootLSoft,
		SoundMFootLSoft,
		SoundMFootLSoft,
		SoundMFootLHard,
		SoundMFootLSnow,
		SoundMFootLSoft,
		SoundMFootLSoft,
		SoundMFootLSoft,
		SoundMFootLSoft,
		SoundMFootLSoft,
		SoundMFootLSoft
	};

	footPrints = { 2, 3 };

	boxWidth = 0.7;
	boxDepth = 0.7;
	boxNormalHeight = 2.4;

	boxNormalHeadPercentage  = 0.83;
	boxNormalTorsoPercentage = 0.49;

	boxHeadLeftPercentage  = 0;
	boxHeadRightPercentage = 1;
	boxHeadBackPercentage  = 0;
	boxHeadFrontPercentage = 1;
};

//------------------------------------------------------------------
// BunnyArmor - Huge rabbits, so evil!
//------------------------------------------------------------------

PlayerData BunnyArmor
{
	className = "Armor";
	shapeFile = "bunnyarmor1";
	flameShapeName = "lflame";
	shieldShapeName = "shield";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	shadowDetailMask = 1;

	canCrouch = false;
	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";

	maxJetSideForceFactor = 0.8;
	maxJetForwardVelocity = 22;
	minJetEnergy = 1;
	jetForce = 320;
	jetEnergyDrain = 100.0;

	maxDamage = 1.0;
	maxForwardSpeed = 30;
	maxBackwardSpeed = $spdhigher-1;
	maxSideSpeed = $spdhigher-1;
	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 110;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 25;
	damageScale = 0.006;

	jumpImpulse = 75;
	jumpSurfaceMinDot = 0.2;

	// animation data:
	// animation name, one shot, exclude, direction, firstPerson, chaseCam, thirdPerson, signalThread

	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "PDA access", none, 1, true, false, false, false, 3 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };

	// death animations:
	animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, true, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 };

	// celebraton animations:
	animData[43] = { "celebration 1", none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };

	// taunt anmations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };

	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;

	rFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft
	};
	lFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft, 
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft 
	};

	footPrints = { 4, 5 };

	boxWidth = 0.8;
	boxDepth = 0.8;
	boxNormalHeight = 2.6;

	boxNormalHeadPercentage  = 0.70;
	boxNormalTorsoPercentage = 0.45;

	boxHeadLeftPercentage  = 0.48;
	boxHeadRightPercentage = 0.70;
	boxHeadBackPercentage  = 0.48;
	boxHeadFrontPercentage = 0.60;
};

//------------------------------------------------------------------
// CatArmor - A small cat
//------------------------------------------------------------------

PlayerData CatArmor
{
	className = "Armor";
	shapeFile = "catarmor1";
	flameShapeName = "lflame";
	shieldShapeName = "shield";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	shadowDetailMask = 1;

	canCrouch = false;
	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";

	maxJetSideForceFactor = 0.8;
	maxJetForwardVelocity = 22;
	minJetEnergy = 1;
	jetForce = 320;
	jetEnergyDrain = 100.0;

	maxDamage = 1.0;
	maxForwardSpeed = 30;
	maxBackwardSpeed = $spdhigher-1;
	maxSideSpeed = $spdhigher-1;
	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 110;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 25;
	damageScale = 0.006;

	jumpImpulse = 75;
	jumpSurfaceMinDot = 0.2;

	// animation data:
	// animation name, one shot, exclude, direction, firstPerson, chaseCam, thirdPerson, signalThread

	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "PDA access", none, 1, true, false, false, false, 3 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };

	// death animations:
	animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, true, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 };

	// celebraton animations:
	animData[43] = { "celebration 1", none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };

	// taunt anmations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };

	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;

	rFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft
	};
	lFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft, 
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft 
	};

	footPrints = { 4, 5 };

	boxWidth = 0.8;
	boxDepth = 0.8;
	boxNormalHeight = 2.6;

	boxNormalHeadPercentage  = 0.70;
	boxNormalTorsoPercentage = 0.45;

	boxHeadLeftPercentage  = 0.48;
	boxHeadRightPercentage = 0.70;
	boxHeadBackPercentage  = 0.48;
	boxHeadFrontPercentage = 0.60;
};

//------------------------------------------------------------------
// ChickenArmor - Small white chicken
//------------------------------------------------------------------

PlayerData ChickenArmor
{
	className = "Armor";
	shapeFile = "chickenarmor1";
	flameShapeName = "lflame";
	shieldShapeName = "shield";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	shadowDetailMask = 1;

	canCrouch = false;
	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";

	maxJetSideForceFactor = 0.8;
	maxJetForwardVelocity = 22;
	minJetEnergy = 1;
	jetForce = 320;
	jetEnergyDrain = 100.0;

	maxDamage = 1.0;
	maxForwardSpeed = 30;
	maxBackwardSpeed = $spdhigher-1;
	maxSideSpeed = $spdhigher-1;
	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 110;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 25;
	damageScale = 0.006;

	jumpImpulse = 75;
	jumpSurfaceMinDot = 0.2;

	// animation data:
	// animation name, one shot, exclude, direction, firstPerson, chaseCam, thirdPerson, signalThread

	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "PDA access", none, 1, true, false, false, false, 3 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };

	// death animations:
	animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, true, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 };

	// celebraton animations:
	animData[43] = { "celebration 1", none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };

	// taunt anmations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };

	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;

	rFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft
	};
	lFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft, 
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft 
	};

	footPrints = { 4, 5 };

	boxWidth = 0.8;
	boxDepth = 0.8;
	boxNormalHeight = 2.6;

	boxNormalHeadPercentage  = 0.70;
	boxNormalTorsoPercentage = 0.45;

	boxHeadLeftPercentage  = 0.48;
	boxHeadRightPercentage = 0.70;
	boxHeadBackPercentage  = 0.48;
	boxHeadFrontPercentage = 0.60;
};

//------------------------------------------------------------------
// CowArmor - Very ugly lol
//------------------------------------------------------------------

PlayerData CowArmor
{
	className = "Armor";
	shapeFile = "cowarmor1";
	flameShapeName = "lflame";
	shieldShapeName = "shield";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	shadowDetailMask = 1;

	canCrouch = false;
	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";

	maxJetSideForceFactor = 0.8;
	maxJetForwardVelocity = 22;
	minJetEnergy = 1;
	jetForce = 320;
	jetEnergyDrain = 100.0;

	maxDamage = 1.0;
	maxForwardSpeed = 30;
	maxBackwardSpeed = $spdhigher-1;
	maxSideSpeed = $spdhigher-1;
	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 110;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 25;
	damageScale = 0.006;

	jumpImpulse = 75;
	jumpSurfaceMinDot = 0.2;

	// animation data:
	// animation name, one shot, exclude, direction, firstPerson, chaseCam, thirdPerson, signalThread

	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "PDA access", none, 1, true, false, false, false, 3 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };

	// death animations:
	animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, true, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 };

	// celebraton animations:
	animData[43] = { "celebration 1", none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };

	// taunt anmations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };

	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;

	rFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft
	};
	lFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft, 
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft 
	};

	footPrints = { 4, 5 };

	boxWidth = 0.8;
	boxDepth = 0.8;
	boxNormalHeight = 2.6;

	boxNormalHeadPercentage  = 0.70;
	boxNormalTorsoPercentage = 0.45;

	boxHeadLeftPercentage  = 0.48;
	boxHeadRightPercentage = 0.70;
	boxHeadBackPercentage  = 0.48;
	boxHeadFrontPercentage = 0.60;
};

//------------------------------------------------------------------
// Blue Dragon Armor
//------------------------------------------------------------------

PlayerData BlueDragonArmor
{
	className = "Armor";
	shapeFile = "dragonarmorblue";
	flameShapeName = "lflame";
	shieldShapeName = "shield";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	shadowDetailMask = 1;

	canCrouch = false;
	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";

	maxJetSideForceFactor = 0.8;
	maxJetForwardVelocity = 22;
	minJetEnergy = 1;
	jetForce = 320;
	jetEnergyDrain = 100.0;

	maxDamage = 1.0;
	maxForwardSpeed = 30;
	maxBackwardSpeed = $spdhigher-1;
	maxSideSpeed = $spdhigher-1;
	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 110;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 25;
	damageScale = 0.006;

	jumpImpulse = 75;
	jumpSurfaceMinDot = 0.2;

	// animation data:
	// animation name, one shot, exclude, direction, firstPerson, chaseCam, thirdPerson, signalThread

	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "PDA access", none, 1, true, false, false, false, 3 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };

	// death animations:
	animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, true, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 };

	// celebraton animations:
	animData[43] = { "celebration 1", none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };

	// taunt anmations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };

	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;

	rFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft
	};
	lFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft, 
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft 
	};

	footPrints = { 4, 5 };

	boxWidth = 0.8;
	boxDepth = 0.8;
	boxNormalHeight = 2.6;

	boxNormalHeadPercentage  = 0.70;
	boxNormalTorsoPercentage = 0.45;

	boxHeadLeftPercentage  = 0.48;
	boxHeadRightPercentage = 0.70;
	boxHeadBackPercentage  = 0.48;
	boxHeadFrontPercentage = 0.60;
};

//------------------------------------------------------------------
// Green Dragon Armor
//------------------------------------------------------------------

PlayerData GreenDragonArmor
{
	className = "Armor";
	shapeFile = "dragonarmorgreen";
	flameShapeName = "lflame";
	shieldShapeName = "shield";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	shadowDetailMask = 1;

	canCrouch = false;
	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";

	maxJetSideForceFactor = 0.8;
	maxJetForwardVelocity = 22;
	minJetEnergy = 1;
	jetForce = 320;
	jetEnergyDrain = 100.0;

	maxDamage = 1.0;
	maxForwardSpeed = 30;
	maxBackwardSpeed = $spdhigher-1;
	maxSideSpeed = $spdhigher-1;
	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 110;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 25;
	damageScale = 0.006;

	jumpImpulse = 75;
	jumpSurfaceMinDot = 0.2;

	// animation data:
	// animation name, one shot, exclude, direction, firstPerson, chaseCam, thirdPerson, signalThread

	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "PDA access", none, 1, true, false, false, false, 3 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };

	// death animations:
	animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, true, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 };

	// celebraton animations:
	animData[43] = { "celebration 1", none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };

	// taunt anmations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };

	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;

	rFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft
	};
	lFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft, 
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft 
	};

	footPrints = { 4, 5 };

	boxWidth = 0.8;
	boxDepth = 0.8;
	boxNormalHeight = 2.6;

	boxNormalHeadPercentage  = 0.70;
	boxNormalTorsoPercentage = 0.45;

	boxHeadLeftPercentage  = 0.48;
	boxHeadRightPercentage = 0.70;
	boxHeadBackPercentage  = 0.48;
	boxHeadFrontPercentage = 0.60;
};

//------------------------------------------------------------------
// Mimic Armor
//------------------------------------------------------------------

PlayerData MimicArmor
{
	className = "Armor";
	shapeFile = "mimicarmor1";
	flameShapeName = "lflame";
	shieldShapeName = "shield";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	shadowDetailMask = 1;

	canCrouch = false;
	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";

	maxJetSideForceFactor = 0.8;
	maxJetForwardVelocity = 22;
	minJetEnergy = 1;
	jetForce = 320;
	jetEnergyDrain = 100.0;

	maxDamage = 1.0;
	maxForwardSpeed = 30;
	maxBackwardSpeed = $spdhigher-1;
	maxSideSpeed = $spdhigher-1;
	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 110;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 25;
	damageScale = 0.006;

	jumpImpulse = 75;
	jumpSurfaceMinDot = 0.2;

	// animation data:
	// animation name, one shot, exclude, direction, firstPerson, chaseCam, thirdPerson, signalThread

	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "PDA access", none, 1, true, false, false, false, 3 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };

	// death animations:
	animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, true, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 };

	// celebraton animations:
	animData[43] = { "celebration 1", none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };

	// taunt anmations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };

	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;

	rFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft
	};
	lFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft, 
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft 
	};

	footPrints = { 4, 5 };

	boxWidth = 0.8;
	boxDepth = 0.8;
	boxNormalHeight = 2.6;

	boxNormalHeadPercentage  = 0.70;
	boxNormalTorsoPercentage = 0.45;

	boxHeadLeftPercentage  = 0.48;
	boxHeadRightPercentage = 0.70;
	boxHeadBackPercentage  = 0.48;
	boxHeadFrontPercentage = 0.60;
};

//------------------------------------------------------------------
// T2HeavyArmor - Big cyborg looking thing, heavy armor
//------------------------------------------------------------------

PlayerData T2HeavyArmor
{
	className = "Armor";
	shapeFile = "t2heavy"; // tempcyborg, treeWalk, turtlearmor1, undeadDogArmor, unholyarmor, walkdinoarmor1
	flameShapeName = "lflame";
	shieldShapeName = "shield";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	shadowDetailMask = 1;

	canCrouch = false;
	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";

	maxJetSideForceFactor = 0.8;
	maxJetForwardVelocity = 22;
	minJetEnergy = 1;
	jetForce = 320;
	jetEnergyDrain = 100.0;

	maxDamage = 1.0;
	maxForwardSpeed = 30;
	maxBackwardSpeed = $spdhigher-1;
	maxSideSpeed = $spdhigher-1;
	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 110;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 25;
	damageScale = 0.006;

	jumpImpulse = 75;
	jumpSurfaceMinDot = 0.2;

	// animation data:
	// animation name, one shot, exclude, direction, firstPerson, chaseCam, thirdPerson, signalThread

	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "PDA access", none, 1, true, false, false, false, 3 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };

	// death animations:
	animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, true, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 };

	// celebraton animations:
	animData[43] = { "celebration 1", none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };

	// taunt anmations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };

	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;

	rFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft
	};
	lFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft, 
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft 
	};

	footPrints = { 4, 5 };

	boxWidth = 0.8;
	boxDepth = 0.8;
	boxNormalHeight = 2.6;

	boxNormalHeadPercentage  = 0.70;
	boxNormalTorsoPercentage = 0.45;

	boxHeadLeftPercentage  = 0.48;
	boxHeadRightPercentage = 0.70;
	boxHeadBackPercentage  = 0.48;
	boxHeadFrontPercentage = 0.60;
};

//------------------------------------------------------------------
// UndeadDogArmor
//------------------------------------------------------------------

PlayerData UndeadDogArmor
{
	className = "Armor";
	shapeFile = "undeadDogArmor"; // treeWalk, turtlearmor1, walkdinoarmor1
	flameShapeName = "lflame";
	shieldShapeName = "shield";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	shadowDetailMask = 1;

	canCrouch = false;
	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";

	maxJetSideForceFactor = 0.8;
	maxJetForwardVelocity = 22;
	minJetEnergy = 1;
	jetForce = 320;
	jetEnergyDrain = 100.0;

	maxDamage = 1.0;
	maxForwardSpeed = 30;
	maxBackwardSpeed = $spdhigher-1;
	maxSideSpeed = $spdhigher-1;
	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 110;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 25;
	damageScale = 0.006;

	jumpImpulse = 75;
	jumpSurfaceMinDot = 0.2;

	// animation data:
	// animation name, one shot, exclude, direction, firstPerson, chaseCam, thirdPerson, signalThread

	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "PDA access", none, 1, true, false, false, false, 3 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };

	// death animations:
	animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, true, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 };

	// celebraton animations:
	animData[43] = { "celebration 1", none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };

	// taunt anmations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };

	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;

	rFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft
	};
	lFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft, 
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft 
	};

	footPrints = { 4, 5 };

	boxWidth = 0.8;
	boxDepth = 0.8;
	boxNormalHeight = 2.6;

	boxNormalHeadPercentage  = 0.70;
	boxNormalTorsoPercentage = 0.45;

	boxHeadLeftPercentage  = 0.48;
	boxHeadRightPercentage = 0.70;
	boxHeadBackPercentage  = 0.48;
	boxHeadFrontPercentage = 0.60;
};

//------------------------------------------------------------------
// DinoArmor
//------------------------------------------------------------------

PlayerData DinoArmor
{
	className = "Armor";
	shapeFile = "walkdinoarmor1";
	flameShapeName = "lflame";
	shieldShapeName = "shield";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	shadowDetailMask = 1;

	canCrouch = false;
	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";

	maxJetSideForceFactor = 0.8;
	maxJetForwardVelocity = 22;
	minJetEnergy = 1;
	jetForce = 320;
	jetEnergyDrain = 100.0;

	maxDamage = 1.0;
	maxForwardSpeed = 30;
	maxBackwardSpeed = $spdhigher-1;
	maxSideSpeed = $spdhigher-1;
	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 110;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 25;
	damageScale = 0.006;

	jumpImpulse = 75;
	jumpSurfaceMinDot = 0.2;

	// animation data:
	// animation name, one shot, exclude, direction, firstPerson, chaseCam, thirdPerson, signalThread

	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "PDA access", none, 1, true, false, false, false, 3 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };

	// death animations:
	animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, true, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 };

	// celebraton animations:
	animData[43] = { "celebration 1", none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };

	// taunt anmations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };

	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;

	rFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft
	};
	lFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft, 
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft 
	};

	footPrints = { 4, 5 };

	boxWidth = 0.8;
	boxDepth = 0.8;
	boxNormalHeight = 2.6;

	boxNormalHeadPercentage  = 0.70;
	boxNormalTorsoPercentage = 0.45;

	boxHeadLeftPercentage  = 0.48;
	boxHeadRightPercentage = 0.70;
	boxHeadBackPercentage  = 0.48;
	boxHeadFrontPercentage = 0.60;
};

//------------------------------------------------------------------
// 
//------------------------------------------------------------------

PlayerData TestArmor
{
	className = "Armor";
	shapeFile = "walkdinoarmor1"; // treeWalk, turtlearmor1, walkdinoarmor1
	flameShapeName = "lflame";
	shieldShapeName = "shield";
	damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
	shadowDetailMask = 1;

	canCrouch = false;
	visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";

	maxJetSideForceFactor = 0.8;
	maxJetForwardVelocity = 22;
	minJetEnergy = 1;
	jetForce = 320;
	jetEnergyDrain = 100.0;

	maxDamage = 1.0;
	maxForwardSpeed = 30;
	maxBackwardSpeed = $spdhigher-1;
	maxSideSpeed = $spdhigher-1;
	groundForce = 75 * 9.0;
	mass = 9.0;
	groundTraction = 3.0;
	maxEnergy = 110;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 25;
	damageScale = 0.006;

	jumpImpulse = 75;
	jumpSurfaceMinDot = 0.2;

	// animation data:
	// animation name, one shot, exclude, direction, firstPerson, chaseCam, thirdPerson, signalThread

	// movement animations:
	animData[0]  = { "root", none, 1, true, true, true, false, 0 };
	animData[1]  = { "run", none, 1, true, false, true, false, 3 };
	animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
	animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
	animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
	animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
	animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
	animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
	animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
	animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
	animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
	animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
	animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
	animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
	animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
	animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
	animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
	animData[19] = { "jet", none, 1, true, true, true, false, 3 };

	// misc. animations:
	animData[20] = { "PDA access", none, 1, true, false, false, false, 3 };
	animData[21] = { "throw", none, 1, true, false, false, false, 3 };
	animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
	animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
	animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };

	// death animations:
	animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
	animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

	// signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
	animData[39] = { "sign point", none, 1, true, false, false, true, 1 };
	animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
	animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
	animData[42] = { "sign salut", none, 1, true, false, false, true, 1 };

	// celebraton animations:
	animData[43] = { "celebration 1", none, 1, true, false, false, false, 2 };
	animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
	animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };

	// taunt anmations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };

	// poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
	animData[50] = { "wave", none, 1, true, false, false, true, 1 };

	jetSound = NoSound;

	rFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft
	};
	lFootSounds =
	{
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft, 
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft,
		SoundLFootLSoft 
	};

	footPrints = { 4, 5 };

	boxWidth = 0.8;
	boxDepth = 0.8;
	boxNormalHeight = 2.6;

	boxNormalHeadPercentage  = 0.70;
	boxNormalTorsoPercentage = 0.45;

	boxHeadLeftPercentage  = 0.48;
	boxHeadRightPercentage = 0.70;
	boxHeadBackPercentage  = 0.48;
	boxHeadFrontPercentage = 0.60;
};
