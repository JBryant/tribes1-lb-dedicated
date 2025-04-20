$Tree::limit[1] = 5;
$Tree::limit[2] = 5;
$Tree::limit[3] = 20;

function init::Tree(%pos) {
	// TODO: Make init:Tree take a seed instead of just a position (or just use tree::spawn directly)
	%obj = newObject("", "Item", "Ruby", 1, true);
	%obj.name = "TreeFruit";

	Gamebase::setposition(%obj, %pos);
	Item::setvelocity(%obj, "0 0 0");

	schedule("tree::spawn("@%obj@");", 5, %obj);
}

function Tree::ents(%clientId, %pos) {
	if($treenum[3] < 45) {
		%obj = newObject("Static","Staticshape","TreeShape",true);
		%rot = GameBase::GetRotation(%clientId);
		%rotx = Getword(%rot, 0);
		%roty = Getword(%rot, 1);
		%rotz = Getword(%rot, 2);
		%rotx = "-1.512";
		%rot = %rotx @ " " @ %roty @ " "  @ %rotz;
		%pos = Getword(%pos, 0) @ " " @ GetWord(%pos, 1) @ " " @  (Getword(%pos, 2) -2);
		%x = GetWord(%pos, 0);
		%y = getword(%pos, 1);
		%obj.bonuscut = 10;
		%obj.nocount = 1;
		%obj.hp = -30;

		if (%x <= -353 && %x >= -412.8 && %y >= 1702 && %y <= 1883.16)
			%t = 1;
		else if (%x <= -4429.76 && %x >= -4511 && %y >= 1702 && %y <= 1883.16)
			%t = "2";
		else if (%x <= -2392.74 && %x >= -2462.02 && %y >= 1702 && %y <= 1883.16)
			%t = "3";
		else
			%t = "Area";

		if($trees[%t] == "")
			$trees[%t] = %obj;
		else
			$trees[%t] = $trees[%t]@" "@%obj;

		$treenum[%t]++;

		GameBase::SetPosition(%obj, %pos);
		GameBase::SetRotation(%obj, %rot);
	}
}

function Tree::starts(%clientId, %pos, %bonus) {
	%obj = newObject("Static","Staticshape","TreeShape",true);
	%rot = GameBase::GetRotation(%clientId);
	%rotx = Getword(%rot, 0);
	%roty = Getword(%rot, 1);
	%rotz = Getword(%rot, 2);
	%rotx = "-1.512";
	%rot = %rotx @ " " @ %roty @ " "  @ %rotz;
	%pos = Getword(%pos, 0) @ " " @ GetWord(%pos, 1) @ " " @  (Getword(%pos, 2));
	%obj.bonuscut = %bonus;
	%obj.nocount = 0;
	%obj.hp = -30;
	GameBase::SetPosition(%obj, %pos);
	GameBase::SetRotation(%obj, %rot);
}

function tree::periodic(%id) {
 	//echo("tree::periodic");
 	%d = gamebase::getposition(%id);
 	%z = getword(%d, 2);
 	%z = %z -2;
 	%d = getword(%d, 0) @ " " @ getword(%d, 1) @ " " @ %z;
 	gamebase::Setposition(%id, %d);
 	Item::setvelocity(%id, "0 0 10");

 	if( (getrandom() * 4 > 3 && %id.per <= 0) || %id.per < -1) {
 		schedule("tree::spawn(" @ %id @ ");", 10, %id);
  	}
 	else {
		%id.per--;
 		schedule("tree::periodic(" @ %id @ ");", 10, %id);
 	}
}

function tree::sprout(%tree) {
	//echo("tree::sprout" @ %id.hp);

	if(%tree) {
		if (%tree.hp > 0) {
			//if(getRandom() >= 0.005)
			%fruit = Item::onDrop(%tree, %tree.fruit);
            //else
            //    %obj = Item::onDrop(%id, "EvilTreeFruit");
			// %obj.per = 2;
			%tree.life--;
			
			if (%tree.life > 0)
				// schedule("tree::sprout(" @ %tree @ ");", GetRandom() * 200 * 9, %tree);
				schedule("tree::sprout(" @ %tree @ ");", 5, %tree);
			else
				tree::delete(%tree);
		}
		// else
		// 	tree::delete(%tree);
	}

	return;
}

function tree::spawn(%seed) {
	//echo("tree::spawn");
	//make sure seed hasnt been picked up.
	%pos = Gamebase::GetPosition(%seed);
	// %x = getword(%pos, 0);
	// %y = getword(%pos, 1);
	// %z = getword(%pos, 2);

	// if (%x <= -353 && %x >= -412.8 && %y >= 1702 && %y <= 1883.16)
	// 	%t = 1;
	// else if (%x <= -4429.76 && %x >= -4511 && %y >= 1702 && %y <= 1883.16)
	// 	%t = "2";
	// else if (%x <= -2392.74 && %x >= -2462.02 && %y >= 1702 && %y <= 1883.16)
	// 	%t = "3";
	// else
	// 	%t = "Area";

	// TODO: modify or remove the tree area check / limit
	%t = 1;

	if ($treenum[%t] < $Tree::limit[%t]) { // if ($treenum[%t] < $Tree::limit[%t] && %t != "Area") {
		if (%pos != -1) {
			// %posx = GetWord(%pos, 0);
			// %posy = GetWord(%pos, 1);
			%posz = GetWord(%pos, 2)-1;
			%posz = %posz + 1;
			// %pos = %posx @ " " @ %posy @ " " @ %posz;

			if (%posz > 58 && %posz < 66.5) {
				%tree = newObject("Static", "StaticShape", "TreeShape", true);
				%tree.hp = 20;
				%tree.fruit = $beltitem[%seed.name, "TreeFruit"];
				// TODO: life based off the seed as well (the tree type)
				%tree.life = 8;

				if($trees[%t] == "")
					$trees[%t] = %tree;
				else
					$trees[%t] = $trees[%t]@" "@%tree;

				GameBase::setPosition(%tree, %pos);
				%rz = Getrandom() * 3.14*2;
				%rot = "0 0 " @ %rz;
				GameBase::SetRotation(%tree, %rot);
				GameBase::setMapname(%tree, "Tree " @ %t @ $treenum[%t]);
				GameBase::StartFadeIn(%tree);
				// schedule("tree::sprout(" @ %tree @ ");", GetRandom() * 600, %obj);
				schedule("tree::sprout(" @ %tree @ ");", 5, %tree);
				// %z = getword(%pos, 2);
				$treenum[%t]++;
				%tree.nocount = 0;
			}
		}
	}

	deleteObject(%seed);
}

function tree::chop(%client, %player, %obj, %harvest) {
	//echo(%obj.hp);
	//echo(object::getname(%obj));
	//echo(%obj);
	%obj.hp--;
	//echo(%client);
	if (%obj.hp > 1) {
		return "";
	}
	else if (%obj.hp == 0) {
		//chop the tree down
		%rot = GameBase::GetRotation(%player);
		%pos = GameBase::GetPosition(%obj);
		%rotx = Getword(%rot, 0);
		%roty = Getword(%rot, 1);
		%rotz = Getword(%rot, 2);
		%rotx = "-1.512";
		%rot = %rotx @ " " @ %roty @ " "  @ %rotz;
		%pos = Getword(%pos, 0) @ " " @ GetWord(%pos, 1) @ " " @  (Getword(%pos, 2) + 1);
		GameBase::SetPosition(%obj, %pos);
		GameBase::SetRotation(%obj, %rot);
		//echo(%rot);
		//%obj.hp++;
		%value = 1;
		//storeData(%client, "EXP", %value, "inc");
		//Client::sendMessage(%client, $MsgWhite, "You have gained " @ %value @ " experience for chopping down a tree!");
		//Game::refreshClientScore(%client);
		return "";
	}
	else if (%obj.hp < 0 ) {
		%hit = "";
		
		if ( %obj.hp < -60 ) {
			if(%obj.hp == -61) {
				Tree::Delete(%obj);
			}
		}
		else {
			%r2 = $PlayerSkill[%client, $SkillWoodCutting] / ( $PlayerSkill[%client, $SkillWoodCutting] + 10 )/100*getRandom()/2 + getRandom()*2;

			if ( %r2 > 1 ) {
				if(%obj.bonuscut >= 0)
					%r = 1+ ($PlayerSkill[%client, $SkillWoodCutting]+%obj.bonuscut) * (1/5) * getRandom();
				else
					%r = 1+ $PlayerSkill[%client, $SkillWoodCutting] * (1/5) * getRandom();

				%hit = GetWord($ItemList[WoodCutting, 1], 0);

				for(%i = 1; $ItemList[WoodCutting, %i] != ""; %i++) {
					%w1 = GetWord($ItemList[WoodCutting, %i], 1);
					%n = Cap( (%w1 * getRandom()) + (%w1 / 2), 0, %w1);
					//%r = 1 + ($PlayerSkill[%client, $SkillWoodCutting] * (1/5)) * getRandom();

					if(%n > %r) {
						return %hit;
					}

					%hit = GetWord($ItemList[WoodCutting, %i], 0);
				}

				return %hit;
			}
			else {
				Client::sendMessage(%client, 0, "You fail to split the wood with your axe.");	
				return "";
			}
		}
	//harvest
	//%obj.hp++;
	}

	return "";
}

function tree::delete(%tree) {
	%pos = GameBase::GetPosition(%tree);
	%x = getword(%pos, 0);
	%y = getword(%pos, 1);
	%z = getword(%pos, 2);

	Item::Pop(%tree);

	// if (%x <= -353 && %x >= -412.8 && %y >= 1702 && %y <= 1883.16)
	// 	%t = 1;
	// else if (%x <= -4429.76 && %x >= -4511 && %y >= 1702 && %y <= 1883.16)
	// 	%t = "2";
	// else if (%x <= -2392.74 && %x >= -2462.02 && %y >= 1702 && %y <= 1883.16)
	// 	%t = "3";
	// else
	// 	%t = "loose";

	// TODO: Modify t to be based off users owner or something else
	%t = 1;
	$trees[%t] = String::erase($trees[%t], %tree);

	if(!%tree.nocount)
		$treenum[%t]--;
}

function init::bush(%type, %pos) {
	%item = $ItemList[Cooking, %type];

	if ( %item != "" ) {
		%class = "StaticShape";
		%obj = newObject("Static", %class, "PlantTwo", true);
		%obj.type = %type;
		%obj.item = %item;
		%obj.hp = 1000;
		%obj.seed = 0;
		addToSet("MissionCleanup", %obj);
		GameBase::setPosition(%obj, %pos);
		GameBase::setRotation(%obj, "0 0 " @ GetRandom() * 3.14*2);
		GameBase::setMapname(%obj, "Tree " @ floor(GetRandom() * 20));
		schedule("bush::sprout(" @ %obj @ ");", GetRandom() * 600, %obj);
		$bushnum++;		
	}

	return;
}
function bush::hit(%id) {
	//ECHO("bush hit");
	playsound("SoundLeatherHit", GameBase::GetPosition(%id));
	%id.hp--;

	if (%id.hp == 0)
		bush::delete(%id);

	return;
}

function bush::sprout(%id) {
	if(%id) {
		%id.seed = %id.seed+1;
		//echo(%id @ "|" @ %id.seed @ "|" @ %id.type);
		schedule("bush::sprout(" @ %id @ ");", GetRandom() * 600, %id);
	}

	return;
}

function bush::spawn(%id) {
	//echo("Bush::spawn(" @ %id @ ");");
	%client = %id.client;
	
	%pos = Gamebase::GetPosition(%id);
	%x = getword(%pos, 0);
	%y = getword(%pos, 1);
	%z = getword(%pos, 2);
	%pos = %x @ " " @ %y @ " " @ (%z - 0.15);

	if (%z > 0 && %client.plant <= 20) {
		// %item = GameBase::getDataName(%id); // maybe this will be image data?
		%item = %id;
		%type = %id.type;
		%obj = newObject("Static", "StaticShape", "PlantTwo", true);
		%obj.type = %type;
		%obj.item = %item;
		%obj.hp = 3;
		%obj.seed = 0;
		%client.plant++;
		%obj.client = %client;
		addToSet("MissionCleanup", %obj);
		GameBase::setPosition(%obj, %pos);
		GameBase::setRotation(%obj, "0 0 " @ GetRandom() * 3.14*2);
		GameBase::setMapname(%obj, "Bush " @ floor(GetRandom() * 20));
		deleteObject(%id);
		schedule("bush::sprout(" @ %obj @ ");", GetRandom() * 300, %obj);
		schedule("bush::delete(" @ %obj @ ");", GetRandom() * 2200 + 3000, %obj);
		$bushnum++;
	}
}

function bush::delete(%id) {
	%client = %id.client;
	%client.plant--;
	Item::Pop(%id);
}

// $AccessoryVar[TreeFruit, $Weight] = "0.5";
// $AccessoryVar[TreeFruit, $MiscInfo] = "You can drop this on the ground to grow a tree.";
