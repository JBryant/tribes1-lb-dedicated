//----------------------------------------------------------------------------
// MINE DYNAMIC DATA

MineData AntipersonelMine
{
	className = "Mine";
   description = "Antipersonel Mine";
   shapeFile = "mine";
   shadowDetailMask = 4;
   explosionId = mineExp;
	explosionRadius = 10.0;
	damageValue = 2.0;
	damageType = $SpellDamageType;
	kickBackStrength = 150;
	triggerRadius = 2.5;
	maxDamage = 0.5;
	shadowDetailMask = 0;
	destroyDamage = 1.0;
	damageLevel = {1.0, 1.0};
};

function AntipersonelMine::onAdd(%this)
{
	%this.damage = 0;
	AntipersonelMine::deployCheck(%this);
}

function AntipersonelMine::onCollision(%this,%object)
{
	%type = getObjectType(%object);
	%data = GameBase::getDataName(%this);
	if ((%type == "Player" || %data == AntipersonelMine || %data == Vehicle || %type == "Moveable") &&
			GameBase::isActive(%this))
		GameBase::setDamageLevel(%this, %data.maxDamage);
}

function AntipersonelMine::deployCheck(%this)
{
	if (GameBase::isAtRest(%this)) {
		GameBase::playSequence(%this,1,"deploy");
	 	GameBase::setActive(%this,true);
		%set = newObject("set",SimSet);
		if(1 != containerBoxFillSet(%set,$MineObjectType,GameBase::getPosition(%this),1,1,1,0)) {
			%data = GameBase::getDataName(%this);
			GameBase::setDamageLevel(%this, %data.maxDamage);
		}
		deleteObject(%set);
	}
	else
		schedule("AntipersonelMine::deployCheck(" @ %this @ ");", 3, %this);
}

function AntipersonelMine::onDestroyed(%this)
{
	$TeamItemCount[GameBase::getTeam(%this) @ "mineammo"]--;
}

function AntipersonelMine::onDamage(%this,%type,%value,%pos,%vec,%mom,%object)
{
   if (%type == $MineDamageType)
      %value = %value * 0.25;

	%data = GameBase::getDataName(%this);
	if((%data.maxDamage/1.5) < %this.damage+%value)
		GameBase::setDamageLevel(%this, %data.maxDamage);
	else
		%this.damage += %value;
}

//----------------------------------------------------------------------------
// very large radius yellow bomb, low quality
// ------------------------------------
MineData Bomb1
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "bullet";
	shadowDetailMask = 4;
	explosionId = mortarExp;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $SpellDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb1::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// blue cloud
MineData Bomb2
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = mineExp;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $SpellDamageType;
	kickBackStrength = 10.00;
	triggerRadius = 2.5;
	maxDamage = 1.0;
};
function Bomb2::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// weird yellow flash bomb
MineData Bomb3
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "bullet";
	shadowDetailMask = 4;
	explosionId = fire2Exp;
	explosionRadius = 15.0;
	damageValue = 1.25;
	damageType = $SpellDamageType;
	kickBackStrength = 10.0;
	triggerRadius = 15.0;
	maxDamage = 1.25;
};
function Bomb3::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// standard shockwave
MineData Bomb4
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "bullet";
	shadowDetailMask = 4;
	explosionId = Shockwave;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $SpellDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb4::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// blue electrical blal
MineData Bomb24
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "discb";
	shadowDetailMask = 4;
	explosionId = Fusionex;
	explosionRadius = 2.0;
	damageValue = 10.0;
	damageType = $SpellDamageType;
	kickBackStrength = 40.5;
	triggerRadius = 0.5;
	maxDamage = 10.0;
};
function Bomb24::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// shockwave
MineData Bomb5
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "discb";
	shadowDetailMask = 4;
	explosionId = LargeShockwave;
	explosionRadius = 10.0;
	damageValue = 10.0;
	damageType = $SpellDamageType;
	kickBackStrength = 0;
	triggerRadius = 10.5;
	maxDamage = 10.0;
};
function Bomb5::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// veryt large yellow mushroom cloud
MineData Bomb6
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = rocketExp;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $SpellDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb6::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// small blue twinkle star
MineData Bomb7
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = energyExp;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $SpellDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb7::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}


//Chee small blue twinkle star
MineData Bomb40
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "discb";
	shadowDetailMask = 4;
	explosionId = EnergyExp;
	explosionRadius = 0.0;
	damageValue = 0.10;
	damageType = $SpellDamageType;
	kickBackStrength = 0;
	triggerRadius = 10.5;
	maxDamage = 10.0;
};
function Bomb40::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// medium yellow cloud with explosion sound
MineData Bomb41
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "discb";
	shadowDetailMask = 4;
	explosionId = debrisExplarge;
	explosionRadius = 10.0;
	damageValue = 0.60;
	damageType = $SpellDamageType;
	kickBackStrength = 0;
	triggerRadius = 10.5;
	maxDamage = 0.10;
};
function Bomb41::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// blue spellcasting ghosty thingies with booms
MineData Bomb44
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "discb";
	shadowDetailMask = 4;
	explosionId = freezeExp;
	explosionRadius = 10.0;
	damageValue = 0.60;
	damageType = $SpellDamageType;
	kickBackStrength = 0;
	triggerRadius = 10.5;
	maxDamage = 0.10;
};
function Bomb44::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// blue spellcasting ghosty thingies with booms
MineData Bomb42
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "discb";
	shadowDetailMask = 4;
	explosionId = freezeExp;
	explosionRadius = 10.0;
	damageValue = 0.20;
	damageType = $SpellDamageType;
	kickBackStrength = 0;
	triggerRadius = 10.5;
	maxDamage = 0.10;
};
function Bomb42::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// blue spellcasting ghosty thingies with booms
MineData Bomb43
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "discb";
	shadowDetailMask = 4;
	explosionId = freezeExp;
	explosionRadius = 10.0;
	damageValue = 0.10;
	damageType = $SpellDamageType;
	kickBackStrength = 0;
	triggerRadius = 10.5;
	maxDamage = 0.10;
};
function Bomb43::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// raining bullets?
MineData Bomb107
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "bullet";
	shadowDetailMask = 4;
	explosionId = LargeShockwave;
	explosionRadius = 10.0;
	damageValue = 1.5;
	damageType = $SpellDamageType;
	kickBackStrength = 100.0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb4::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// raining bullets?
MineData Bomb108
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "bullet";
	shadowDetailMask = 4;
	explosionId = ustarExp;
	explosionRadius = 10.0;
	damageValue = 2.5;
	damageType = $SpellDamageType;
	kickBackStrength = 100.0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb4::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// raining bullets?
MineData Bomb200
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "bullet";
	shadowDetailMask = 4;
	explosionId = ustarExp;
	explosionRadius = 10.0;
	damageValue = 5.0;
	damageType = $SpellDamageType;
	kickBackStrength = 700.0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb4::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// 1 bullet plus blue ice explosion
MineData bomb201
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "bullet";
	shadowDetailMask = 4;
	explosionId = iceExp;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $SpellDamageType;
	kickBackStrength = 300.0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb201::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// now souind medium large yellow/white cloud explosion
MineData Bomb202
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "bullet";
	shadowDetailMask = 4;
	explosionId = rocketExp;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $SpellDamageType;
	kickBackStrength = 300.0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb202::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// small blue twinkle star no sound
MineData Bomb300
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "blueball";
	shadowDetailMask = 4;
	explosionId = energyExp;
	explosionRadius = 10.0;
	damageValue = 0.70;
	damageType = $SpellDamageType;
	kickBackStrength = 300.0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb300::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

MineData Bomb301
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "blueball";
	shadowDetailMask = 4;
	explosionId = rocketExp;
	explosionRadius = 10.0;
	damageValue = 0.80;
	damageType = $SpellDamageType;
	kickBackStrength = 300.0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb301::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// small blue twinkle star
MineData Bomb302
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "zap";
	shadowDetailMask = 4;
	explosionId = energyExp;
	explosionRadius = 10.0;
	damageValue = 0.80;
	damageType = $SpellDamageType;
	kickBackStrength = 0.0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb302::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// small blue shock ball (ice)
MineData Bomb303
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "zap";
	shadowDetailMask = 4;
	explosionId = turretExp;
	explosionRadius = 10.0;
	damageValue = 1.50;
	damageType = $SpellDamageType;
	kickBackStrength = 0.0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb303::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// large shockwave no sound
MineData Bomb304
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "zap";
	shadowDetailMask = 4;
	explosionId = LargeShockwave;
	explosionRadius = 10.0;
	damageValue = 2.0;
	damageType = $SpellDamageType;
	kickBackStrength = 300.0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb304::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// small blue twinkle star
MineData Bomb305
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "discb";
	shadowDetailMask = 4;
	explosionId = energyExp;
	explosionRadius = 10.0;
	damageValue = 0.0;
	damageType = $SpellDamageType;
	kickBackStrength = 300.0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb305::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

MineData Bomb306
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "mflame";
	shadowDetailMask = 4;
	explosionId = rocketExp;
	explosionRadius = 10.0;
	damageValue = 0.10;
	damageType = $SpellDamageType;
	kickBackStrength = 300.0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb306::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// lightning storm
MineData Bomb307
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "zap";
	shadowDetailMask = 4;
	explosionId = electricalExp;
	explosionRadius = 10.0;
	damageValue = 0.20;
	damageType = $SpellDamageType;
	kickBackStrength = 300.0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb307::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// delayed explosion grenades with 2 explosons, one large and one small yellow cloud
MineData Bomb950
{
  mass = 0.3;
  drag = 1.0;
  density = 2.0;
  elasticity = 0.15;
  friction = 1.0;
  className = "Handgrenade";
  description = "Handgrenade";
  shapeFile = "smoke";
  shadowDetailMask = 4;
  explosionId = grenadeExp;
  explosionRadius = 10.0;
  damageValue = 1.5;
  damageType = $SpellDamageType;
  kickBackStrength = 20;
  triggerRadius = 0.5;
  maxDamage = 2.0;
};

function bomb950::onAdd(%this)
{
	schedule("shower(" @ %this @ " , 5);",0.5,%this);
	schedule("Mine::Detonate(" @ %this @ ");",1.5,%this);
}

function shower(%this, %count)
{
	if(%count && %this)
	{
		%obj = newObject("","Mine","bomb951");
 		addToSet("MissionCleanup", %obj);
		GameBase::throw(%obj,%this,5,false);

		%obj = newObject("","Mine","bomb951");
	 	addToSet("MissionCleanup", %obj);
		GameBase::throw(%obj,%this,-5,false);
		//%count -= 1;
		//schedule("DeployDisc(" @ %this @ " , " @ %count @ ");",0.5,%this);
	}
}

// pulsing little red star
MineData Bomb8
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = blasterExp;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $SpellDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb8::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// yellow plasma ball explosion
MineData Bomb9
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = plasmaExp;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $SpellDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb9::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// blue circle small explosion (ice)
MineData Bomb10
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = turretExp;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $SpellDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb10::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// small dust explosion
MineData Bomb11
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = bulletExp0;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $SpellDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb11::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// high quality small blue/white gas explosion
MineData Bomb12
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = debrisExpSmall;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $SpellDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb12::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// medium high quality blue/white gas explosion
MineData Bomb13
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = debrisExpMedium;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $SpellDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb13::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// slightly larger Bomb13
MineData Bomb14
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = debrisExpLarge;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $SpellDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb14::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// small high quality blue/white explosion cloud
MineData Bomb15
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = flashExpSmall;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $SpellDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb15::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// medium high quality blue/white explosion cloud
MineData Bomb16
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = flashExpMedium;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $SpellDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb16::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// large high quality blue/white explosion cloud
MineData Bomb17
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = flashExpLarge;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $SpellDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb17::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

MineData bomb951
{
   	mass = 5.0;
   	drag = 1.0;
   	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "disc";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = DebrisExpMedium;
	explosionRadius = 10.0;
	damageValue = 0.50;
	damageType = $SpellDamageType;
	kickBackStrength = 50;
	triggerRadius = 0.5;
	maxDamage = 1.5;
};

function bomb951::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");",0.9,%this);
}

MineData bomb611
{
   	mass = 5.0;
   	drag = 1.0;
   	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "disc";
	shapeFile = "skel";
	shadowDetailMask = 4;
	explosionId = LargeShockwave;
	explosionRadius = 20.0;
	damageValue = 0.50;
	damageType = $SpellDamageType;
	kickBackStrength = 50;
	triggerRadius = 0.5;
	maxDamage = 1.5;
};

function bomb611::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");",0.9,%this);
}

// T Pose Skeleton with large yellow explosion
MineData bomb612
{
   	mass = 5.0;
   	drag = 1.0;
   	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "disc";
	shapeFile = "skel";
	shadowDetailMask = 4;
	explosionId = MortarExp;
	explosionRadius = 20.0;
	damageValue = 0.20;
	damageType = $SpellDamageType;
	kickBackStrength = 50;
	triggerRadius = 0.5;
	maxDamage = 1.5;
};
function bomb612::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");",0.9,%this);
}

// goblin with med dust explosion
MineData bomb88888
{
   	mass = 5.0;
   	drag = 1.0;
   	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "sappers";
	shapeFile = "goblin";
	shadowDetailMask = 4;
	explosionId = DirtyExp;
	explosionRadius = 5.0;
	damageValue = 5.0;
	damageType = $SpellDamageType;
	kickBackStrength = 50;
	triggerRadius = 0.5;
	maxDamage = 1.5;
};

function bomb612::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");",0.9,%this);
}
//Chee
MineData Handgrenade
{
   mass = 0.3;
   drag = 1.0;
   density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
   description = "Handgrenade";
   shapeFile = "grenade";
   shadowDetailMask = 4;
   explosionId = grenadeExp;
	explosionRadius = 10.0;
	damageValue = 0.5;
	damageType = $SpellDamageType;
	kickBackStrength = 100;
	triggerRadius = 0.5;
	maxDamage = 2;
};

function Handgrenade::onAdd(%this)
{
	%data = GameBase::getDataName(%this);
	schedule("Mine::Detonate(" @ %this @ ");",2.0,%this);
}

// blue ghosties again no sound
MineData Bomb3000
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "discb";
	shadowDetailMask = 4;
	explosionId = spellExp1;
	explosionRadius = 0.0;
	damageValue = 0.0;
	damageType = $SpellDamageType;
	kickBackStrength = 0;
	triggerRadius = 10.5;
	maxDamage = 0.10;
};
function Bomb3000::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// more ghosties, maybe more?
MineData Bomb3002
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "discb";
	shadowDetailMask = 4;
	explosionId = spellExp2;
	explosionRadius = 0.0;
	damageValue = 0.0;
	damageType = $SpellDamageType;
	kickBackStrength = 0;
	triggerRadius = 10.5;
	maxDamage = 0.10;
};
function Bomb3001::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// blue twinkle star
MineData Bomb3003
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "discb";
	shadowDetailMask = 4;
	explosionId = spellExp3;
	explosionRadius = 0.0;
	damageValue = 0.0;
	damageType = $SpellDamageType;
	kickBackStrength = 0;
	triggerRadius = 10.5;
	maxDamage = 0.10;
};
function Bomb3003::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// tiny baby dust explosions
MineData Bomb6661
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 1.0;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "invisable";
	shadowDetailMask = 4;
	explosionId = windExp;
	explosionRadius = 0.2;
	damageValue = 1.0;
	damageType = $SpellDamageType;
	kickBackStrength = 0;
	triggerRadius = 10.5;
	maxDamage = 0.10;
};
function Bomb6661::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// tiny baby dust explosions
MineData Bomb6662
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 1.0;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "invisable";
	shadowDetailMask = 4;
	explosionId = windExp;
	explosionRadius = 0.0;
	damageValue = 2.0;
	damageType = $SpellDamageType;
	kickBackStrength = 0;
	triggerRadius = 10.5;
	maxDamage = 0.10;
};
function Bomb6662::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// invisible
MineData Bomb6663
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 1.0;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "invisable";
	shadowDetailMask = 4;
	explosionId = windExp;
	explosionRadius = 0.0;
	damageValue = 4.0;
	damageType = $SpellDamageType;
	kickBackStrength = 0;
	triggerRadius = 10.5;
	maxDamage = 0.10;
};
function Bomb6663::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// tiny baby white explosions
MineData Bomb6664
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 1.0;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "invisable";
	shadowDetailMask = 4;
	explosionId = windExp;
	explosionRadius = 0.0;
	damageValue = 8.0;
	damageType = $SpellDamageType;
	kickBackStrength = 0;
	triggerRadius = 10.5;
	maxDamage = 0.10;
};
function Bomb6664::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

// lightning storm
MineData Bomb444
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 1.0;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "boltbolt1";
	shadowDetailMask = 4;
	explosionId = electricalExp;
	explosionRadius = 0.0;
	damageValue = 1.000;
	damageType = $SpellDamageType;
	kickBackStrength = 0;
	triggerRadius = 10.5;
	maxDamage = 0.10;
};
function Bomb444::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

function Mine::onDamage(%this,%type,%value,%pos,%vec,%mom,%object)
{
   if (%type == $MineDamageType)
      %value = %value * 0.25;

	%damageLevel = GameBase::getDamageLevel(%this);
	GameBase::setDamageLevel(%this,%damageLevel + %value);
}

function Mine::Detonate(%this)
{
	%data = GameBase::getDataName(%this);
	GameBase::setDamageLevel(%this, %data.maxDamage);
}



