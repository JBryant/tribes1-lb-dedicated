$ImpactDamageType		  = -1;
$LandingDamageType	  =  0;
$BulletDamageType      =  1;
$EnergyDamageType      =  2;
$PlasmaDamageType      =  3;
$ExplosionDamageType   =  4;
$ShrapnelDamageType    =  5;
$LaserDamageType       =  6;
$MortarDamageType      =  7;
$BlasterDamageType     =  8;
$ElectricityDamageType =  9;
$CrushDamageType       = 10;
$DebrisDamageType      = 11;
$MissileDamageType     = 12;
$MineDamageType        = 13;
$NullDamageType        = 14;
$SpellDamageType       = 15;
$WeaponDamage          = 16;

$InpactArea = 1.0; // need to be like on the explsion
$SmallArea = 5.0;
$LargeArea = 10.0;
$HugeArea = 20.0;
$InsaneArea = 30.0;
$MaxArea = 40.0; // shouldn't need it this big anyways

//--------------------------------------
// thrown ball, drops down over time (short distance)
//--------------------------------------
GrenadeData dodgethisboltold
{
  bulletShapeName = "orb.dts";
  explosionTag = DirtyExp;
  collideWithOwner = True;
  ownerGraceMS = 250;
  collisionRadius = 0.3;
  mass = 5.0;
  elasticity = 0.25;
  damageClass = 1;
  damageValue = 2.5;
  damageType = $SpellDamageType;
  explosionRadius = $LargeArea;
  kickBackStrength = 10.0;
  maxLevelFlightDist = 100;
  totalTime = 5.0;
  liveTime = 0.5;
  projSpecialTime = 0.01;
  inheritedVelocityScale = 0.5;
  smokename = "dustplume.dts";
  smokeDist = 6.0;
};
//--------------------------------------
// ball with sand trail, smoke explosion
//--------------------------------------
RocketData dodgethisbolt
{
   bulletShapeName  = "orb.dts";
   explosionTag     = DirtyExp;
   collisionRadius  = 0.0;
   mass             = 2.0;

   damageClass      = 1;       // 0 impact, 1, radius
   damageValue      = 0.5;
   damageType       = $SpellDamageType;

   explosionRadius  = $LargeArea;
   kickBackStrength = 10.0;
   muzzleVelocity   = 65.0;
   terminalVelocity = 80.0;
   acceleration     = 5.0;
   totalTime        = 10.0;
   liveTime         = 11.0;
   lightRange       = 5.0;
   lightColor       = { 1.0, 0.7, 0.5 };
   inheritedVelocityScale = 0.5;

   // rocket specific
   trailType   = 2;                // smoke trail
   trailString = "dustplume.dts"; //"rsmoke.dts";
   smokeDist   = 6; //1.8;

   soundId = SoundJetHeavy;
};
//--------------------------------------
// Super crazy multi shockwave with smaller explosion at end
//--------------------------------------
RocketData goddyshot
{
  bulletShapeName = "shockwave_large.dts";
  explosionTag = Shockwave;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 1.0;
  damageType = $SpellDamageType;
  explosionRadius = $HugeArea;
  kickBackStrength = 10.0;
  muzzleVelocity = 30.0;
  terminalVelocity = 30.0;
  acceleration = 5.0;
  totalTime = 5.0;
  liveTime = 5.0;
  lightRange = 0.0;
  lightColor = { 5.20, 6.7, 1.5 };
  inheritedVelocityScale = 0.0;
  trailType = 2;
  trailString = "shockwave_large.dts";
  smokeDist = 2;
};
//--------------------------------------
// fast moving blue stars with shockwave trail and explosion
//--------------------------------------
RocketData amazonlightbeam
{
  bulletShapeName = "shockwave_large.dts";
  explosionTag = Shockwave;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 0.50;
  damageType = $SpellDamageType;
  explosionRadius = $HugeArea;
  kickBackStrength = 0.0;
  muzzleVelocity = 130.0;
  terminalVelocity = 130.0;
  acceleration = 5.0;
  totalTime = 6.5;
  liveTime = 10.0;
  lightRange = 5.0;
  lightColor = { 5.20, 6.7, 1.5 };
  inheritedVelocityScale = 0.0;
  trailType = 2;
  trailString = "fusionbolt.dts";
  smokeDist = 2;
};
//--------------------------------------
// Throwing a stone
//--------------------------------------
RocketData throwstones
{
  bulletShapeName = "med_rock.dts";
  explosionTag = DirtyExp;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 1.0;
  DamageType = $SpellDamageType;
  explosionRadius = $LargeArea;
  kickBackStrength = 0.0;
  muzzleVelocity = 50.0;
  terminalVelocity = 50.0;
  acceleration = 10.0;
  totalTime = 15.0;
  liveTime = 15.0;
  lightRange = 10.0;
  colors[0]  = { 1.0, 0.25, 0.25 };
  inheritedVelocityScale = 0.5;
  trailType = 2;
  trailString = "fusionex.dts";
  smokeDist = 0.0;
  soundId = Explode3FW;
};
//--------------------------------------
// Slow moving javelin, with blue lightning trail and plasma explosion on impact
//--------------------------------------
RocketData battleswordone
{
  bulletShapeName = "spear.dts";
  explosionTag = plasmaExp;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 0.50;
  DamageType = $SpellDamageType;
  explosionRadius = $LargeArea;
  kickBackStrength = 10.0;
  muzzleVelocity = 20.0;
  terminalVelocity = 20.0;
  acceleration = 5.0;
  totalTime = 15.0;
  liveTime = 15.0;
  lightRange = 10.0;
  colors[0]  = { 1.0, 0.25, 0.25 };
  inheritedVelocityScale = 0.5;
  trailType = 2;
  trailString = "fusionex.dts";
  smokeDist = 5.0;
  soundId = Explode3FW;
};
//--------------------------------------
// Slow moving greataxe with small fire explosion trail and blue cloud explosion
//--------------------------------------
RocketData battleswordtwo
{
  bulletShapeName = "battleaxe.dts";
  explosionTag = mineExp;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 1.0;
  DamageType = $SpellDamageType;
  explosionRadius = 10.0;
  kickBackStrength = 10.0;
  muzzleVelocity = 20.0;
  terminalVelocity = 20.0;
  acceleration = 5.0;
  totalTime = 15.0;
  liveTime = 15.0;
  lightRange = 10.0;
  colors[0]  = { 1.0, 0.25, 0.25 };
  inheritedVelocityScale = 0.5;
  trailType = 2;
  trailString = "plasmabolt.dts";
  smokeDist = 10.0;
  soundId = Explode3FW;
};
//--------------------------------------
// sword with sandy cloud trail and large explosion
//--------------------------------------
RocketData battleswordthree
{
  bulletShapeName = "sword.dts";
  explosionTag = grenadeExp;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 2.0;
  DamageType = $SpellDamageType;
  explosionRadius = 10.0;
  kickBackStrength = 10.0;
  muzzleVelocity = 20.0;
  terminalVelocity = 20.0;
  acceleration = 5.0;
  totalTime = 15.0;
  liveTime = 15.0;
  lightRange = 10.0;
  colors[0]  = { 1.0, 0.25, 0.25 };
  inheritedVelocityScale = 0.5;
  trailType = 2;
  trailString = "dustplume.dts";
  smokeDist = 5.0;
  soundId = Explode3FW;
};
//--------------------------------------
// throwin green gem sword, small fire trail and impulse explosion
//--------------------------------------
RocketData battleswordfour
{
  bulletShapeName = "greensword.dts";
  explosionTag = LargeShockwave;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 5.0;
  DamageType = $SpellDamageType;
  explosionRadius = 20.0;
  kickBackStrength = 80.0;
  muzzleVelocity = 20.0;
  terminalVelocity = 20.0;
  acceleration = 5.0;
  totalTime = 50.0;
  liveTime = 50.0;
  lightRange = 10.0;
  colors[0]  = { 1.0, 0.25, 0.25 };
  inheritedVelocityScale = 0.5;
  trailType = 2;
  trailString = "plasmatrail.dts";
  smokeDist = 5.0;
  soundId = Explode3FW;
};
//--------------------------------------
// slow moving ice ball with glowing trail, no explosion?
//--------------------------------------
RocketData blizzardsummonbolt
{
  bulletShapeName = "fusionex.dts";
  explosionTag = FusionExp;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 3.0;
  DamageType = $SpellDamageType;
  explosionRadius = 10.0;
  kickBackStrength = 80.0;
  muzzleVelocity = 20.0;
  terminalVelocity = 20.0;
  acceleration = 5.0;
  totalTime = 15.0;
  liveTime = 15.0;
  lightRange = 80.0;
  colors[0]  = { 1.0, 0.25, 0.25 };
  inheritedVelocityScale = 0.5;
  trailType = 2;
  trailString = "rsmoke.dts";
  smokeDist = 20.0;
  soundId = Explode3FW;
};
//--------------------------------------
// weird ufo light blade thing? could be a good light spell?
//--------------------------------------
RocketData blizzardsummonboltfake
{
  bulletShapeName = "newproj.dts";
  explosionTag = FusionExp;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 1.0;
  damageType = $SpellDamageType;
  explosionRadius = 0.0;
  kickBackStrength = 80.0;
  muzzleVelocity = 20.0;
  terminalVelocity = 20.0;
  acceleration = 5.0;
  totalTime = 15; //2.1
  liveTime = 15;//2.1
  lightRange = 80.0;
  colors[0]  = { 1.0, 0.25, 0.25 };
  inheritedVelocityScale = 0.5;
  trailType = 2;
  trailString = "breath.dts";
  smokeDist = 100.0;
  soundId = Explode3FW;
};
//--------------------------------------
// slow moving rock, no trail and small blue explosion (maybe change explosion)
//--------------------------------------
RocketData rocksummonbolt
{
  bulletShapeName = "boulder.dts";
  explosionTag = FusionExp;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 1.0;
  DamageType = $SpellDamageType;
  explosionRadius = $SmallArea;
  kickBackStrength = 0.0;
  muzzleVelocity = 20.0;
  terminalVelocity = 20.0;
  acceleration = 5.0;
  totalTime = 15.0;
  liveTime = 15.0;
  lightRange = 80.0;
  colors[0]  = { 1.0, 0.25, 0.25 };
  inheritedVelocityScale = 0.5;
  trailType = 2;
  trailString = "little_rock.dts";
  smokeDist = 20.0;
  soundId = Explode3FW;
};
//--------------------------------------
// slow moving red ball, large light explosion
//--------------------------------------
RocketData lightrocket
{
  bulletShapeName = "shotgunex.dts";
  explosionTag = lightExp;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 1.80;
  damageType = $SpellDamageType;
  explosionRadius = $SmallArea;
  kickBackStrength = 0.1;
  muzzleVelocity = 1.0;
  terminalVelocity = 1.0;
  acceleration = 0.20;
  totalTime = 15; //2.1
  liveTime = 15;//2.1
  lightRange = 80.0;
  colors[0]  = { 1.0, 0.25, 0.25 };
  inheritedVelocityScale = 0.5;
  trailType = 2;
  trailString = "laserhit.dts";
  smokeDist = 10.0;
  soundId = Explode3FW;
};
//--------------------------------------
// tiny fast moving fire ball, no trail, ends with plasma exp
//--------------------------------------
RocketData FireFlames
{
  bulletShapeName = "plasmatrail.dts";
  explosionTag = FireExp;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 1.80;
  damageType = $SpellDamageType;
  explosionRadius = 25.0;
  kickBackStrength = 0.1;
  muzzleVelocity = 50.0;
  terminalVelocity = 50.0;
  acceleration = 5.0;
  totalTime = 6; //2.1
  liveTime = 4;//2.1
  lightRange = 1.0;
  lightColor = { 1.0, 1.0, 9.5 };
  inheritedVelocityScale = 0.5;
  trailType = 2;
  trailString = "plasmaEx.dts";
  smokeDist = $SmokeDist; //4.0;
  soundId = Explode3FW;
};
//--------------------------------------
// medium speed ice ball with fire explosion at end
//--------------------------------------
RocketData FireBlue
{
  bulletShapeName = "fusionex.dts"; //"fusionbolt.dts";
  explosionTag = Blue2Exp;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 1.80;
  damageType = $SpellDamageType;
  explosionRadius = 25.0;
  kickBackStrength = 0.1;
  muzzleVelocity = 50.0;
  terminalVelocity = 50.0;
  acceleration = 5.0;
  totalTime = 6; //2.1
  liveTime = 4;//2.1
  lightRange = 1.0;
  lightColor = { 1.0, 1.0, 9.5 };
  inheritedVelocityScale = 0.5;
  trailType = 2;
  trailString = "fusionex.dts"; //"plasmaEx.dts";
  smokeDist = $SmokeDist; //4.0;
  soundId = Explode3FW;
};
//--------------------------------------
// Fast moving tiny plasma ball with shockwave exp, seems to not be accurate at all?
//--------------------------------------
BulletData PowerBlast
{
bulletShapeName = "plasmatrail.dts";
explosionTag = FireExp;
expRandCycle      = 3;
mass   = 0.05;
bulletHoleIndex    = 0;
damageClass      = 0;       // 0 impact, 1, radius
damageValue    = 0.08;
damageType     = $SpellDamageType;
aimDeflection    = 0.059;
muzzleVelocity  = 500.0;
totalTime       = 5;
inheritedVelocityScale = 0.3;
isVisible       = True;
tracerPercentage  = 2.0;
tracerLength   = 3;
soundId = SoundJetLight;
};
//--------------------------------------
// Fast mopving arrow/plasma thing? seems to be innacurate with big explosion at end
//--------------------------------------
BulletData PowerBlast2
{
bulletShapeName = "plasmatrail.dts";
explosionTag = FireExp;
expRandCycle      = 0;
mass   = 0.05;
bulletHoleIndex    = 0;
damageClass      = 0;       // 0 impact, 1, radius
damageValue    = 0.08;
damageType     = $SpellDamageType;
aimDeflection    = 0.059;
muzzleVelocity  = 500.0;
totalTime       = 5;
inheritedVelocityScale = 0.3;
isVisible       = False;
tracerPercentage  = 2.0;
tracerLength   = 3;
soundId = SoundJetLight;
};
//--------------------------------------
// Very flas moving, but cant see what it is?
//--------------------------------------
LaserData avabolt1
{
   laserBitmapName   = "stafflag.bmp";
   hitName           = "dustplume.dts";

   damageConversion  = 0.0;
   damageType    = $SpellDamageType;

   beamTime          = 1.0;

   lightRange        = 1.0;
   lightColor        = { 0.2, 0.2, 0.2 };

   detachFromShooter = true;
   hitSoundId        = SoundLaserHit;
};
//--------------------------------------
// cactus on fire that falls, maybe used for interesting spells?
//--------------------------------------
GrenadeData brimstoneFall
{
  bulletShapeName = "cactus1.dts";
  explosionTag = grenadeExp;
  collideWithOwner = False;
  ownerGraceMS = 250;
  collisionRadius = 0.3;
  mass = 1.0;
  elasticity = 0.04;
  damageClass = 1;
  damageValue = 0.0;
  damageType = $SpellDamageType;
  explosionRadius = 40.0;
  kickBackStrength = 0.0;
  maxLevelFlightDist = 0;
  totalTime = 30.0;
  liveTime = 2.0;
  projSpecialTime = 0.01;
  inheritedVelocityScale = 0.0;
  smokeName = "plastrail.dts";
};
//--------------------------------------
// Red beam (like sniper laster beam bolt but lighter)
//--------------------------------------
LaserData brimBolt1
{
   laserBitmapName   = "repairAdd.bmp";
   hitName           = "breath.dts";

   damageConversion  = 0.0;
   damageType    = $SpellDamageType;

   beamTime          = 1.0;

   lightRange        = 1.0;
   lightColor        = { 0.0, 0.0, 4.25 };

   detachFromShooter = true;
   hitSoundId        = SoundLaserHit;
};
//--------------------------------------
// Nothing is visible, maybe not working?
//--------------------------------------
LaserData brimBolt2
{
   laserBitmapName   = "warp.bmp";
   hitName           = "breath.dts";

   damageConversion  = 0.0;
   damageType    = $SpellDamageType;

   beamTime          = 1.0;

   lightRange        = 1.0;
   lightColor        = { 0.0, 0.0, 4.25 };

   detachFromShooter = true;
   hitSoundId        = SoundLaserHit;
};
//--------------------------------------
// fast flying zombie with plasma explosion
//--------------------------------------
RocketData doubleshot
{
   bulletShapeName = "zombie.dts";
   explosionTag     = plasmaExp;
   collisionRadius  = 0.0;
   mass             = 0.2;

   damageClass      = 1;       // 0 impact, 1, radius
   damageValue      = 1.0;
   damageType       = $SpellDamageType;

   explosionRadius  = 30.0;
   kickBackStrength = 50.0;
   muzzleVelocity   = 100.0;
   terminalVelocity = 100.0;
   acceleration     = 5.0;
   totalTime        = 10.0;
   liveTime         = 4.0;
   lightRange       = 9.0;
   lightColor       = { 0.4, 0.4, 1.0 };
   inheritedVelocityScale = 0.5;

   // rocket specific
   trailType   = 2;
   trailString = "paint.dts";
   smokeDist   = 0;
};
//--------------------------------------
// 3 small neon green orbs, fast moving, very large end explosion
//--------------------------------------
RocketData deathcoilshot
{
   bulletShapeName = "spitty.dts";
   explosionTag     = mortarEXP;
   collisionRadius  = 0.0;
   mass             = 0.2;

   damageClass      = 1;       // 0 impact, 1, radius
   damageValue      = 1.50;
   damageType       = $SpellDamageType;

   explosionRadius  = 30.0;
   kickBackStrength = 20.0;
   muzzleVelocity   = 100.0;
   terminalVelocity = 100.0;
   acceleration     = 5.0;
   totalTime        = 10.0;
   liveTime         = 4.0;
   lightRange       = 9.0;
   lightColor       = { 0.4, 0.4, 1.0 };
   inheritedVelocityScale = 0.5;

   // rocket specific
   trailType   = 2;
   trailString = "paint.dts";
   smokeDist   = 0;
};
//--------------------------------------
// cant see projectile, but ends with small explosion
//--------------------------------------
BulletData combatbowshot
{
   bulletShapeName   = "tracer.dts";
   explosionTag      = arrowExp;
   expRandCycle      = 0;
   damageType        = 0;
   damageValue       = 3.50;
   bulletholeIndex   = 0;
   damageType    = $SpellDamageType;
   damageType        = $SpellDamageType;
   aimDeflection     = 0.000;
   liveTime          = 3.0;
   totalTime         = 3.0;
   lightRange        = 3.0;
   lightColor        = { 1.0, 0.25, 0.25 };
   muzzleVelocity    = 80.0;
   terminalVelocity  = 80.0;
   acceleration      = 20.0;
   inheritedVelocityScale = 0.2;
   detachFromShooter = false;
};
//--------------------------------------
// fast moving, no proj, no trail, tiny blue explosion
//--------------------------------------
BulletData icestaffshot
{
   bulletShapeName   = "cheefist.dts";
   explosionTag      = energyExp;
   expRandCycle      = 0;
   damageType        = 0;
   damageValue       = 1.0;
   bulletholeIndex   = 0;
   damageType    = $SpellDamageType;
   damageType        = $SpellDamageType;
   aimDeflection     = 0.000;
   liveTime          = 2.0;
   totalTime         = 2.0;
   lightRange        = 4.0;
   lightColor        = { 1.10, 0.25, 0.25 };
   muzzleVelocity    = 80.0;
   terminalVelocity  = 80.0;
   acceleration      = 20.0;
   inheritedVelocityScale = 0.2;
   detachFromShooter = false;
};
//--------------------------------------
// invisible shot, seems to be like a rang melee attack?
//--------------------------------------
BulletData doublebladeshot
{
   bulletShapeName   = "invisable.dts";
   explosionTag      = bladeExp;
   expRandCycle      = 0;
   damageType        = 0;
   damageValue       = 0.80;
   bulletholeIndex   = 0;
   damageType    = $SpellDamageType;
   damageType        = $SpellDamageType;
   aimDeflection     = 0.000;
   liveTime          = 0.5;
   totalTime         = 0.5;
   lightRange        = 4.0;
   lightColor        = { 1.10, 0.25, 0.25 };
   muzzleVelocity    = 80.0;
   terminalVelocity  = 80.0;
   acceleration      = 20.0;
   inheritedVelocityScale = 0.2;
   detachFromShooter = false;
};
//--------------------------------------
// fast moving no trail or proj, plasma explopsion
//--------------------------------------
BulletData icestaffbolt
{
   bulletShapeName   = "plasmabolt.dts";
   explosionTag      = plasmaExp;
   expRandCycle      = 0;
   damageType        = 0;
   damageValue       = 0.80;
   bulletholeIndex   = 0;
   damageType    = $SpellDamageType;
   damageType        = $SpellDamageType;
   aimDeflection     = 0.000;
   liveTime          = 0.4;
   totalTime         = 0.4;
   lightRange        = 4.0;
   lightColor        = { 1.0, 1.25, 0.25 };
   muzzleVelocity    = 80.0;
   terminalVelocity  = 80.0;
   acceleration      = 20.0;
   inheritedVelocityScale = 0.2;
   detachFromShooter = false;
};
//--------------------------------------
// 
//--------------------------------------
BulletData firestaffshot
{
   bulletShapeName   = "plasmabolt.dts";
   explosionTag      = plasmaExp;
   expRandCycle      = 0;
   damageType        = 0;
   damageValue       = 0.80;
   bulletholeIndex   = 0;
   damageType    = $SpellDamageType;
   damageType        = $SpellDamageType;
   aimDeflection     = 0.000;
   liveTime          = 0.4;
   totalTime         = 0.4;
   lightRange        = 4.0;
   lightColor        = { 1.0, 1.25, 0.25 };
   muzzleVelocity    = 80.0;
   terminalVelocity  = 80.0;
   acceleration      = 20.0;
   inheritedVelocityScale = 0.2;
   detachFromShooter = false;
};
//--------------------------------------
// 
//--------------------------------------
BulletData longbowshot
{
   bulletShapeName   = "tracer.dts";
   explosionTag      = arrowExp;
   expRandCycle      = 0;
   damageType        = 0;
   damageValue       = 1.40;
   bulletholeIndex   = 0;
   damageType    = $SpellDamageType;
   damageType        = $SpellDamageType;
   aimDeflection     = 0.000;
   liveTime          = 1.0;
   totalTime         = 1.0;
   lightRange        = 1.0;
   lightColor        = { 1.0, 0.25, 0.25 };
   muzzleVelocity    = 80.0;
   terminalVelocity  = 80.0;
   acceleration      = 20.0;
   inheritedVelocityScale = 0.2;
   detachFromShooter = false;
};
//--------------------------------------
// 
//--------------------------------------
BulletData shortbowshot
{
   bulletShapeName   = "tracer.dts";
   explosionTag      = arrowExp;
   expRandCycle      = 0;
   damageType        = 0;
   damageValue       = 0.80;
   bulletholeIndex   = 0;
   damageType    = $SpellDamageType;
   damageType        = $SpellDamageType;
   aimDeflection     = 0.000;
   liveTime          = 0.8;
   totalTime         = 0.8;
   lightRange        = 1.0;
   lightColor        = { 1.0, 0.25, 0.25 };
   muzzleVelocity    = 80.0;
   terminalVelocity  = 80.0;
   acceleration      = 20.0;
   inheritedVelocityScale = 0.2;
   detachFromShooter = false;
};
//--------------------------------------
// 
//--------------------------------------
BulletData splintstaffshot
{
   bulletShapeName   = "spikeshot.dts";
   explosionTag      = bulletexp1;
   expRandCycle      = 0;
   damageType        = 0;
   damageValue       = 0.30;
   bulletholeIndex   = 0;
   damageType    = $SpellDamageType;
   damageType        = $SpellDamageType;
   aimDeflection     = 0.002;
   liveTime          = 0.4;
   totalTime         = 0.4;
   lightRange        = 4.0;
   lightColor        = { 1.0, 0.25, 0.25 };
   muzzleVelocity    = 100.0;
   terminalVelocity  = 100.0;
   acceleration      = 20.0;
   inheritedVelocityScale = 0.2;
   detachFromShooter = false;
};
//--------------------------------------
// 
//--------------------------------------
BulletData crossbowshot
{
   bulletShapeName   = "tracer.dts";
   explosionTag      = arrowExp;
   expRandCycle      = 0;
   damageType        = 0;
   damageValue       = 0.40;
   bulletholeIndex   = 0;
   damageType    = $SpellDamageType;
   damageType        = $SpellDamageType;
   aimDeflection     = 0.002;
   liveTime          = 0.4;
   totalTime         = 0.4;
   lightRange        = 1.0;
   lightColor        = { 1.0, 0.25, 0.25 };
   muzzleVelocity    = 80.0;
   terminalVelocity  = 80.0;
   acceleration      = 20.0;
   inheritedVelocityScale = 0.2;
   detachFromShooter = false;
};
//--------------------------------------
// 
//--------------------------------------
RocketData arrowbolt
{
  bulletShapeName = "fiery.dts";
  explosionTag = grenadeExp;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 4.0;
  damageType = $SpellDamageType;
  explosionRadius = 5.0;
  kickBackStrength = 40.0;
  muzzleVelocity = 50.0;
  terminalVelocity = 50.0;
  acceleration = 15.0;
  totalTime = 12.1;
  liveTime = 12.1;
  lightRange = 0.0;
  lightColor = { 1.0, 1.0, 9.5 };
  inheritedVelocityScale = 0.5;
  trailType = 2;
  trailString = "plasmatrail.dts";
  smokeDist = 0.0;
  soundId = NoSound;
};
//--------------------------------------
// smoke project / trail with fire explosion
//--------------------------------------
RocketData combustiblebolt
{
  bulletShapeName = "fiery.dts";
  explosionTag = grenadeExp;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 4.0;
  damageType = $SpellDamageType;
  explosionRadius = 5.0;
  kickBackStrength = 40.0;
  muzzleVelocity = 50.0;
  terminalVelocity = 50.0;
  acceleration = 15.0;
  totalTime = 12.1;
  liveTime = 12.1;
  lightRange = 0.0;
  lightColor = { 1.0, 1.0, 9.5 };
  inheritedVelocityScale = 0.5;
  trailType = 2;
  trailString = "plasmatrail.dts";
  smokeDist = 0.0;
  soundId = NoSound;
};
//--------------------------------------
// fire spear with small fire trail and fire explosion
//--------------------------------------
RocketData fspearshot
{
  bulletShapeName = "spear.dts";
  explosionTag = debrisExpSmall;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 0.80;
  damageType = $SpellDamageType;
  explosionRadius = 5.0;
  kickBackStrength = 40.0;
  muzzleVelocity = 50.0;
  terminalVelocity = 50.0;
  acceleration = 15.0;
  totalTime = 12.1;
  liveTime = 12.1;
  lightRange = 0.0;
  lightColor = { 1.0, 1.0, 9.5 };
  inheritedVelocityScale = 0.5;
  trailType = 2;
  trailString = "plasmatrail.dts";
  smokeDist = 10.0;
  soundId = NoSound;
};
//--------------------------------------
// slow moving blue ball, almost like a plasma ball, with double explosion
//--------------------------------------
RocketData screechbolt
{
  bulletShapeName = "spiker.dts";
  explosionTag = screechExp;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 0.8;
  damageType = $LandingDamageType;
  explosionRadius = 5.0;
  kickBackStrength = 5.0;
  muzzleVelocity = 10.0;
  terminalVelocity = 10.0;
  acceleration = 5.0;
  totalTime = 12.1;
  liveTime = 12.1;
  lightRange = 1.0;
  lightColor = { 1.0, 1.0, 9.5 };
  inheritedVelocityScale = 0.5;
  trailType = 2;
  trailString = "spiker.dts";
  smokeDist = 10.0;
  soundId = NoSound;
};
//--------------------------------------
// very skinny red beam, like the other red beam just smaller
//--------------------------------------
LaserData lasercutter
{
   laserBitmapName   = "laserPulse.bmp";
   hitName           = "laserhit.dts";

   damageValue       = 1.50;
   damageType    = $SpellDamageType;

   beamTime          = 0.2;

   lightRange        = 1.0;
   lightColor        = { 4.0, 0.25, 0.25 };

   detachFromShooter = false;
   hitSoundId        = SoundLaserHit;
};
//--------------------------------------
// medium speed small fire ball with fire explosion
//--------------------------------------
RocketData esrockets2
{
  bulletShapeName = "plasmaex.dts";
  explosionTag = debrisExpSmall;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 2.50;
  damageType = $SpellDamageType;
  explosionRadius = 25.0;
  kickBackStrength = 4.0;
  muzzleVelocity = 50.0;
  terminalVelocity = 50.0;
  acceleration = 15.0;
  totalTime = 12.1;
  liveTime = 12.1;
  lightRange = 0.0;
  lightColor = { 1.0, 1.0, 9.5 };
  inheritedVelocityScale = 0.5;
  trailType = 2;
  trailString = "rsmoke.dts";
  smokeDist = 10.0;
  soundId = NoSound;
};
//--------------------------------------
// rocket with plasma explosion
//--------------------------------------
RocketData esrockets
{
  bulletShapeName = "rocket.dts";
  explosionTag = plasmaExp;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 2.0;
  damageType = $SpellDamageType;
  explosionRadius = 25.0;
  kickBackStrength = 5.0;
  muzzleVelocity = 50.0;
  terminalVelocity = 50.0;
  acceleration = 15.0;
  totalTime = 12.1;
  liveTime = 12.1;
  lightRange = 0.0;
  lightColor = { 1.0, 1.0, 9.5 };
  inheritedVelocityScale = 0.5;
  trailType = 2;
  trailString = "rsmoke.dts";
  smokeDist = 10.0;
  soundId = NoSound;
};
//--------------------------------------
// tiny tracer with medium explosion
//--------------------------------------
BulletData voodooshot
{
   bulletShapeName   = "bullet.dts";
   explosionTag      = bulletexp1;
   expRandCycle      = 4;
   damageType        = 0;
   damageValue       = 2.50;
   bulletholeIndex   = 0;
   damageType    = $SpellDamageType;
   damageType        = $SpellDamageType;
   aimDeflection     = 0.002;
   liveTime          = 0.4;
   totalTime         = 0.4;
   lightRange        = 1.0;
   lightColor        = { 1.0, 0.25, 0.25 };
   muzzleVelocity    = 100.0;
   terminalVelocity  = 100.0;
   acceleration      = 20.0;
   inheritedVelocityScale = 0.2;
   detachFromShooter = false;
};
//--------------------------------------
// tiny tracter with small smoke explosion
//--------------------------------------
BulletData buntlineshot
{
   bulletShapeName   = "bullet.dts";
   explosionTag      = bulletexp1;
   expRandCycle      = 4;
   damageType        = 0;
   damageValue       = 0.70;
   bulletholeIndex   = 0;
   damageType    = $SpellDamageType;
   damageType        = $SpellDamageType;
   aimDeflection     = 0.002;
   liveTime          = 0.4;
   totalTime         = 0.4;
   lightRange        = 1.0;
   lightColor        = { 1.0, 0.25, 0.25 };
   muzzleVelocity    = 100.0;
   terminalVelocity  = 100.0;
   acceleration      = 20.0;
   inheritedVelocityScale = 0.2;
   detachFromShooter = false;
};
//--------------------------------------
// kinda looks like the ufo shot again
//--------------------------------------
RocketData CheeBowShot
{
  bulletShapeName = "newproj.dts";
  explosionTag = new1Exp;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 2.0;
  damageType = $SpellDamageType;
  explosionRadius = 30.0;
  kickBackStrength = 2.0;
  muzzleVelocity = 100.0;
  terminalVelocity = 300.0;
  acceleration = 5.0;
  totalTime = 50.0;
  liveTime = 50.0;
  lightRange = 0.0;
  lightColor = { 1.0, 1.0, 9.5 };
  inheritedVelocityScale = 0.5;
  trailType = 2;
  trailString = "plasmatrail.dts";
  smokeDist = 5.0;
  soundId = SoundCheeShot;
};
//--------------------------------------
// very cool almost mortar liek shot with long blue tail, flame trail and large explosion
//--------------------------------------
GrenadeData ssurge
{
  bulletShapeName = "shockwave_large.dts";
  explosionTag = MortarExp;
  collideWithOwner = True;
  ownerGraceMS = 250;
  collisionRadius = 0.3;
  mass = 5.0;
  elasticity = 0.25;
  damageClass = 1;
  damageValue = 1.8;
  damageType = $SpellDamageType;
  explosionRadius = 25.0;
  kickBackStrength = -400.0;
  maxLevelFlightDist = 275;
  totalTime = 20.0;
  liveTime = 0.5;
  projSpecialTime = 0.01;
  inheritedVelocityScale = 0.5;
  smokename = "enex.dts";
  smokeDist = 3.0;
};
//--------------------------------------
// broken beam thing, do not use
//--------------------------------------
LaserData sniperLaser
{
	laserBitmapName   = "forcefield.bmp";
	hitName           = "hitter.dts";

	damageConversion  = 0.0;
	damageType    = $SpellDamageType;

 	beamTime          = 20.0;

	lightRange        = 40.0;
	lightColor        = { 0.2, 0.2, 1.0 };

	detachFromShooter = false;
	hitSoundId        = NoSound;
};
//--------------------------------------
// very cool wind cutter looking projectile with shockwaves, maybe a samurai cut?
//--------------------------------------
RocketData ssurge2
{
   bulletShapeName  = "shockwave_large.dts";
   explosionTag     = LargeShockwave;
   collisionRadius  = 0.0;
   mass             = 0.2;

   damageClass      = 1;       // 0 impact, 1, radius
   damageValue      = 3.15;
   damageType       = $SpellDamageType;

   explosionRadius  = 30.0;
   kickBackStrength = 250.0;
   muzzleVelocity   = 100.0;
   terminalVelocity = 100.0;
   acceleration     = 45.0;
   totalTime        = 15.0;
   liveTime         = 15.0;
   lightRange       = 9.0;
   lightColor       = { 0.4, 0.4, 1.0 };
   inheritedVelocityScale = 0.5;
   rotationPeriod = 1;

   trailType   = 1;
   trailLength = 2000;
   trailWidth  = 5.0;

};
//--------------------------------------
// event large cut wave with blue explosion
//--------------------------------------
RocketData wave
{
  bulletShapeName = "breath.dts";
  explosionTag = waterExp;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 3.00;
  DamageType = $SpellDamageType;
  explosionRadius = 50.0;
  kickBackStrength = 100.0;
  muzzleVelocity = 100.0;
  terminalVelocity = 100.0;
  acceleration = 20.0;
  totalTime = 60.0;
  liveTime = 60.0;
  lightRange = 10.0;
  lightColor = { 1.0, 6.7, 9.5 };
  inheritedVelocityScale = 0.5;
  trailType   = 1;
  trailLength = 2000;
  trailWidth  = 900.0;
  soundId = SoundJetHeavy;
};
//--------------------------------------
// cool green start projectile, blue exp trail, shockwave exp
//--------------------------------------
RocketData makoshot
{
  bulletShapeName = "paint.dts";
  explosionTag = LargeShockwave;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 1.50;
  damageType = $SpellDamageType;
  explosionRadius = 25.0;
  kickBackStrength = 80.0;
  muzzleVelocity = 200.0;
  terminalVelocity = 100.0;
  acceleration = 80.0;
  totalTime = 15.1;
  liveTime = 15.1;
  lightRange = 0.25;
  lightColor = { 1.0, 1.0, 9.5 };
  inheritedVelocityScale = 0.5;
  trailType = 2;
  trailString = "fusionex.dts";
  smokeDist = 20.0;
  soundId = NoSound;
};
//--------------------------------------
// another wind cutter like ability with shockwave
//--------------------------------------
RocketData cheeball
{
  bulletShapeName = "fusionex.dts";
  explosionTag = LargeShockwave;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 6.00;
  DamageType = $SpellDamageType;
  explosionRadius = 50.0;
  kickBackStrength = 100.0;
  muzzleVelocity = 100.0;
  terminalVelocity = 100.0;
  acceleration = 20.0;
  totalTime = 60.0;
  liveTime = 60.0;
  lightRange = 10.0;
  lightColor = { 1.0, 6.7, 9.5 };
  inheritedVelocityScale = 0.5;
  trailType   = 1;
  trailLength = 1000;
  trailWidth  = 15.0;
  soundId = SoundJetHeavy;
};
//--------------------------------------
// large blue cloud, shockwave trail, med blue explosion
//--------------------------------------
RocketData charge1
{
  bulletShapeName = "shockwave_large.dts";
  explosionTag = DCannonBoom;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 0.40;
  DamageType = $SpellDamageType;
  explosionRadius = 25.0;
  kickBackStrength = 450.0;
  muzzleVelocity = 80.0;
  terminalVelocity = 80.0;
  acceleration = 5.0;
  totalTime = 15.0;
  liveTime = 15.0;
  lightRange = 10.0;
  lightColor = { 1.0, 6.7, 9.5 };
  inheritedVelocityScale = 0.5;
  trailType = 2;
  trailString = "flash_medium.dts";
  smokeDist = 1.8;
  soundId = SoundJetHeavy;
};
//--------------------------------------
// tiny blue star, small purple shockwaves, end purple small shockwave
//--------------------------------------
RocketData waterfinal
{
  bulletShapeName = "enex.dts";
  explosionTag = waterExp;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 1.0;
  damageType = $SpellDamageType;
  explosionRadius = 25.0;
  kickBackStrength = 80.0;
  muzzleVelocity = 50.0;
  terminalVelocity = 50.0;
  acceleration = 15.0;
  totalTime = 12.1;
  liveTime = 12.1;
  lightRange = 0.0;
  lightColor = { 1.0, 1.0, 9.5 };
  inheritedVelocityScale = 0.5;
  trailType = 2;
  trailString = "shield_large.dts";
  smokeDist = 10.0;
  soundId = NoSound;
};
//--------------------------------------
// small cutter projectile, end purple small shockwave
//--------------------------------------
RocketData watershottwo
{
   bulletShapeName = "discb.dts";
   explosionTag    = waterExp;

   collisionRadius = 0.0;
   mass            = 2.0;

   damageClass      = 1;       // 0 impact, 1, radius
   damageValue      = 0.60;
   damageType       = $SpellDamageType;

   explosionRadius  = 7.5;
   kickBackStrength = 50.0;

   muzzleVelocity   = 65.0;
   terminalVelocity = 80.0;
   acceleration     = 5.0;

   totalTime        = 6.5;
   liveTime         = 8.0;

   lightRange       = 5.0;
   lightColor       = { 0.4, 0.4, 1.0 };

   inheritedVelocityScale = 0.5;

   // rocket specific
   trailType   = 1;
   trailLength = 100;
   trailWidth  = 1.3;

   soundId = SoundDiscSpin;
};
//--------------------------------------
// small smoke prijectile, no trail, large explosion
//--------------------------------------
RocketData rangerwind
{
  bulletShapeName = "rsmoke.dts";
  explosionTag = rocketExp;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 0.50;
  damageType = $SpellDamageType;
  explosionRadius = 20.5;
  kickBackStrength = 150.50;
  muzzleVelocity = 130.0;
  terminalVelocity = 130.0;
  acceleration = 10.0;
  totalTime = 20.05;
  liveTime = 20.05;
  lightRange = 15.0;
  lightColor = { 5.20, 6.7, 1.5 };
  inheritedVelocityScale = 0.0;
  trailType = 2;
  trailString = "rsmoke.dts";
  smokeDist = 30;
  rotationPeriod = 5;
};
//--------------------------------------
// tiny fireball, fast, no rail, very large explopsion
//--------------------------------------
RocketData rangerfire
{
  bulletShapeName = "plasmatrail.dts";
  explosionTag = grenadeExp;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 0.75;
  damageType = $SpellDamageType;
  explosionRadius = 20.5;
  kickBackStrength = 50.0;
  muzzleVelocity = 130.0;
  terminalVelocity = 130.0;
  acceleration = 15.0;
  totalTime = 20.05;
  liveTime = 20.05;
  lightRange = 15.0;
  lightColor = { 5.20, 6.7, 1.5 };
  inheritedVelocityScale = 0.0;
  trailType = 2;
  trailString = "mflame.dts";
  smokeDist = 30;
  rotationPeriod = 5;
};
//--------------------------------------
// meidum speed blue ball with blue explosion
//--------------------------------------
RocketData rangerice
{
  bulletShapeName = "fusionex.dts";
  explosionTag = flashExpLarge;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 1.20;
  damageType = $SpellDamageType;
  explosionRadius = 0.2;
  kickBackStrength = 100.0;
  muzzleVelocity = 130.0;
  terminalVelocity = 130.0;
  acceleration = 20.0;
  totalTime = 20.05;
  liveTime = 20.05;
  lightRange = 15.0;
  lightColor = { 5.20, 6.7, 1.5 };
  inheritedVelocityScale = 0.0;
  trailType = 2;
  trailString = "rsmoke.dts";
  smokeDist = 30;
  rotationPeriod = 5;
};
//--------------------------------------
// large firebal with shockwave explosion
//--------------------------------------
RocketData flare
{
  bulletShapeName = "plasmatrail.dts";
  explosionTag = LargeShockwave;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 0.20;
  damageType = $SpellDamageType;
  explosionRadius = 25.0;
  kickBackStrength = 0.0;
  muzzleVelocity = 50.0;
  terminalVelocity = 50.0;
  acceleration = 5.0;
  totalTime = 2.1;
  liveTime = 2.1;
  lightRange = 0.0;
  lightColor = { 1.0, 1.0, 9.5 };
  inheritedVelocityScale = 0.5;
  trailType = 2;
  trailString = "plasmaEx.dts";
  smokeDist = 2.8;
  soundId = NoSound;
};

//--------------------------------------
// small blue start proj, medium blue explosion
//--------------------------------------
BulletData blizzagashot
{
  bulletShapeName = "fusionbolt.dts";
  explosionTag = flashExplarge;
  damageClass = 0;
  damageValue = 0.20;
  damageType = $SpellDamageType;
  muzzleVelocity = 100.0;
  totalTime = 3.0;
  liveTime = 3.0;
  lightRange = 3.0;
  lightColor = { 1, 1, 0 };
  inheritedVelocityScale = 0.3;
  isVisible = True;
  soundId = SoundJetHeavy;
};
//--------------------------------------
// short blue star trail, following small purple shockwave
//--------------------------------------
RocketData shocklvone
{
  bulletShapeName = "shield_large.dts";
  explosionTag = Shockwave;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 0.50;
  damageType = $SpellDamageType;
  explosionRadius = 20.5;
  kickBackStrength = 200.0;
  muzzleVelocity = 130.0;
  terminalVelocity = 130.0;
  acceleration = 5.0;
  totalTime = 6.5;
  liveTime = 10.0;
  lightRange = 5.0;
  lightColor = { 5.20, 6.7, 1.5 };
  inheritedVelocityScale = 0.0;
  trailType = 2;
  trailString = "fusionbolt.dts";
  smokeDist = 2;
};


//--------------------------------------
// Basic Arrow Projectile
//--------------------------------------
RocketData BasicArrow {
   bulletShapeName  = "tracer.dts";
   explosionTag     = bulletexp1;
   collisionRadius  = 0;
   mass             = 0.1;

   damageClass      = 0;       // 0 impact, 1, radius
   damageValue      = 1;
   damageType       = $WeaponDamage;

   explosionRadius  = 10;
   kickBackStrength = 1.0;
   muzzleVelocity   = 200.0; // 250.0
   terminalVelocity = 200.0; // 100
   acceleration     = 9.0;
   totalTime        = 10.0;
   liveTime         = 4.0;
   lightRange       = 9.0;
   lightColor       = { 0.4, 0.4, 1.0 };
   inheritedVelocityScale = 1;

//--------------------------------------
// small rocket fast with big shockwave
//--------------------------------------
BulletData testarrow
{
  bulletShapeName = "tracer.dts";
  explosionTag = debrisExpSmall;
  collisionRadius = 0.3;
  mass = 2.0;
  damageClass = 1;
  damageValue = 1;
  explosionRadius = 20.0;
  damageType = $WeaponDamage;
  aimDeflection = 0.0009;
  kickBackStrength = 600.0;
  muzzleVelocity = 100.0;
  terminalVelocity = 100.0; // 100
  acceleration = 5.0;
  totalTime = 8.0;
  liveTime = 15.0;
  inheritedVelocityScale = 0.5;
};

// //--------------------------------------
// // small rocket fast with big shockwave
// //--------------------------------------
RocketData testarrowtwo {
   bulletShapeName  = "tracer.dts";
   explosionTag     = bulletexp1;
   collisionRadius  = 0;
   mass             = 0.1;

   damageClass      = 0;       // 0 impact, 1, radius
   damageValue      = 1;
   damageType       = $WeaponDamage;

   explosionRadius  = 10;
   kickBackStrength = 1.0;
   muzzleVelocity   = 200.0; // 250.0
   terminalVelocity = 200.0; // 100
   acceleration     = 9.0;
   totalTime        = 10.0;
   liveTime         = 4.0;
   lightRange       = 9.0;
   lightColor       = { 0.4, 0.4, 1.0 };
   inheritedVelocityScale = 1;

   // rocket specific
   //trailType   = 2;                // smoke trail
   // trailString = "breath.dts";
   //smokeDist   = 0.8;

  //  soundId = SoundSwing4;
};

//--------------------------------------
// small blue start proj, medium blue explosion
//--------------------------------------
BulletData testarrowthree
{
  bulletShapeName = "tracer.dts";
  explosionTag = bulletexp1;
  damageClass = 0;
  damageValue = 1;
  damageType = $WeaponDamage;
  muzzleVelocity = 100.0; // 100
  totalTime = 3.0;
  liveTime = 3.0;
  lightRange = 3.0;
  lightColor = { 1, 1, 0 };
  inheritedVelocityScale = 0.3;
  isVisible = True;
  soundId = SoundSwing4;
};

//--------------------------------------
// small rocket fast with big shockwave
//--------------------------------------
BulletData shocklvtwo
{
  bulletShapeName = "rocket.dts";
  explosionTag = LargeShockwave;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 0.100;
  explosionRadius = 10.0;
  damageType = $SpellDamageType;
  aimDeflection = 0.0009;
  kickBackStrength = 600.0;
  muzzleVelocity = 120.0;
  terminalVelocity = 120.0;
  acceleration = 5.0;
  totalTime = 8.0;
  liveTime = 15.0;
  inheritedVelocityScale = 0.5;
};
//--------------------------------------
// larger slower rocket with fire tail and bitg shockwave
//--------------------------------------
RocketData shocklvthree
{
   bulletShapeName  = "rocket.dts";
   explosionTag     = LargeShockwave;
   collisionRadius  = 0.3;
   mass             = 2.0;

   damageClass      = 1;       // 0 impact, 1, radius
   damageValue      = 0.150;
   damageType       = $SpellDamageType;

   explosionRadius  = 80.5;
   kickBackStrength = 800.0;
   muzzleVelocity   = 395.0;
   terminalVelocity = 80.0;
   acceleration     = 9.0;
   totalTime        = 10.0;
   liveTime         = 4.0;
   lightRange       = 9.0;
   lightColor       = { 0.4, 0.4, 1.0 };
   inheritedVelocityScale = 0.5;

   // rocket specific
   trailType   = 2;                // smoke trail
   trailString = "plasmabolt.dts";
   smokeDist   = 0.8;

   soundId = MineExplosion;
};
//--------------------------------------
// 
//--------------------------------------
RocketData adminspell
{
  bulletShapeName = "mortar.dts";
  explosionTag = rocketExp;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 1.25;
  damageType = $SpellDamageType;
  explosionRadius = 17.5;
  kickBackStrength = 300.0;
  muzzleVelocity = 65.0;
  terminalVelocity = 2000.0;
  acceleration = 200.0;
  totalTime = 6.5;
  liveTime = 10.0;
  lightRange = 5.0;
  lightColor = { 1.0, 0.7, 0.5 };
  inheritedVelocityScale = 0.5;
  trailType = 2;
  trailString = "chainspk.dts";
  smokeDist = 1.0;
};
//--------------------------------------
// another rocket like spell with medium explosion
//--------------------------------------
BulletData roguefist
{
   bulletShapeName    = "cheefist.dts";
   explosionTag       = debrisExpSmall;
   expRandCycle       = 2;
   mass               = 0.07;
   damageClass        = 1;       // 0 impact, 1, radius
   explosionRadius    = 10.0;
   damageValue        = 0.60;
   damageType         = $SpellDamageType;
   aimDeflection      = 0.009;
   muzzleVelocity     = 150.0;
   totalTime          = 1;
   inheritedVelocityScale = 0.5;
   isVisible          = True;
   rotationPeriod     = 1;
};
//--------------------------------------
// multi spnning small neon green orbs, drops over time, smoke exp
//--------------------------------------
GrenadeData fishspit
{
  bulletShapeName = "poop.dts";
  explosionTag = DirtyExp;
  collideWithOwner = True;
  ownerGraceMS = 250;
  collisionRadius = 0.3;
  mass = 5.0;
  elasticity = 0.25;
  damageClass = 1;
  damageValue = 1.0;
  damageType = $SpellDamageType;
  explosionRadius = 5.0;
  kickBackStrength = 10.0;
  maxLevelFlightDist = 100;
  totalTime = 5.0;
  liveTime = 0.5;
  projSpecialTime = 0.01;
  inheritedVelocityScale = 0.5;
  smokename = "spitty.dts";
  smokeDist = 3.0;
};
//--------------------------------------
// fast straight fishspit, neon green spinning straight shot
//--------------------------------------
RocketData bioone
{
   bulletShapeName = "dustplume.dts";
   explosionTag     = plasmaExp;
   collisionRadius  = 0.0;
   mass             = 0.2;

   damageClass      = 1;       // 0 impact, 1, radius
   damageValue      = 2.0;
   damageType       = $SpellDamageType;

   explosionRadius  = 30.0;
   kickBackStrength = 200.0;
   muzzleVelocity   = 100.0;
   terminalVelocity = 100.0;
   acceleration     = 5.0;
   totalTime        = 10.0;
   liveTime         = 4.0;
   lightRange       = 9.0;
   lightColor       = { 0.4, 0.4, 1.0 };
   inheritedVelocityScale = 0.5;

   // rocket specific
   trailType   = 2;
   trailString = "spitty.dts";
   smokeDist   = 2;
};
//--------------------------------------
// cool green star trail with large explosion
//--------------------------------------
RocketData GravityShot
{
   bulletShapeName = "spitty.dts";
   explosionTag     = mortarEXP;
   collisionRadius  = 0.0;
   mass             = 0.2;

   damageClass      = 1;       // 0 impact, 1, radius
   damageValue      = 0.70;
   damageType       = $SpellDamageType;

   explosionRadius  = 30.0;
   kickBackStrength = -450.0;
   muzzleVelocity   = 100.0;
   terminalVelocity = 100.0;
   acceleration     = 5.0;
   totalTime        = 10.0;
   liveTime         = 4.0;
   lightRange       = 9.0;
   lightColor       = { 0.4, 0.4, 1.0 };
   inheritedVelocityScale = 0.5;

   // rocket specific
   trailType   = 2;
   trailString = "paint.dts";
   smokeDist   = 2;
};
//--------------------------------------
// med smoke proj, shockwave trail, medium explosion
//--------------------------------------
RocketData showshockwave
{
  bulletShapeName = "shockwave_large.dts";
  explosionTag = mortarExp;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 0.0;
  damageType = $SpellDamageType;
  explosionRadius = 40.0;
  kickBackStrength = 0.0;
  muzzleVelocity = 100.0;
  terminalVelocity = 300.0;
  acceleration = 5.0;
  totalTime = 50.0;
  liveTime = 50.0;
  lightRange = 0.0;
  lightColor = { 1.0, 1.0, 9.5 };
  inheritedVelocityScale = 0.5;
  trailType = 2;
  trailString = "dustplume.dts";
  smokeDist = 2.2;
  soundId = SoundDiscSpin;
};
//--------------------------------------
// medium speed blue star with small blue elec exp
//--------------------------------------
BulletData FusionBolt
{
   bulletShapeName    = "fusionbolt.dts";
   explosionTag       = turretExp;
   mass               = 0.05;

   damageClass        = 0;       // 0 impact, 1, radius
   damageValue        = 0.25;
   damageType         = $SpellDamageType;

   muzzleVelocity     = 50.0;
   totalTime          = 6.0;
   liveTime           = 4.0;
   isVisible          = True;

   rotationPeriod = 1.5;
};

//--------------------------------------
// small tinnyy blue star, and small explosion
//--------------------------------------
BulletData MiniFusionBolt
{
   bulletShapeName    = "enbolt.dts";
   explosionTag       = energyExp;

   damageClass        = 0;
   damageValue        = 0.1;
   damageType         = $SpellDamageType;

   muzzleVelocity     = 80.0;
   totalTime          = 4.0;
   liveTime           = 2.0;

   lightRange         = 3.0;
   lightColor         = { 0.25, 0.25, 1.0 };
   //inheritedVelocityScale = 0.5;
   isVisible          = True;

   rotationPeriod = 1;
};
function MiniFusionBolt::onAdd(%this)
{
}

//--------------------------------------
// nice low level firebolt
//--------------------------------------
RocketData FireBolt
{
  bulletShapeName = "spikeshot.dts";
  explosionTag = plasmaExp;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 0.40; // 0.40 / 175
  damageType = $SpellDamageType;
  explosionRadius = 10; // 5.5
  kickBackStrength = 0.0;
  muzzleVelocity = 130.0;
  terminalVelocity = 130.0;
  acceleration = 5.0;
  totalTime = 6.5;
  liveTime = 10.0;
  lightRange = 5.0;
  lightColor = { 5.20, 6.7, 1.5 };
  inheritedVelocityScale = 0.0;
  trailType = 2;
  trailString = "plasmatrail.dts";
  smokeDist = 4;
};

//--------------------------------------
// also small but a little bigger fire bolt
//--------------------------------------
RocketData FlameBolt
{
  bulletShapeName = "multibolt.dts";
  explosionTag = plasmaExp;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 0.40;
  damageType = $SpellDamageType;
  explosionRadius = 5.5;
  kickBackStrength = 5.0;
  muzzleVelocity = 130.0;
  terminalVelocity = 130.0;
  acceleration = 5.0;
  totalTime = 6.5;
  liveTime = 10.0;
  lightRange = 5.0;
  lightColor = { 5.20, 6.7, 1.5 };
  inheritedVelocityScale = 0.0;
  trailType = 2;
  trailString = "dustplume.dts";
  smokeDist = 2;
};

//--------------------------------------
// 
//--------------------------------------
RocketData IceBallBolt
{
  bulletShapeName = "boltbolt1.dts";
  explosionTag = Shockwave;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 0.60;
  damageType = $SpellDamageType;
  explosionRadius = 5.5;
  kickBackStrength = 5.0;
  muzzleVelocity = 130.0;
  terminalVelocity = 130.0;
  acceleration = 5.0;
  totalTime = 6.5;
  liveTime = 10.0;
  lightRange = 5.0;
  lightColor = { 5.20, 6.7, 1.5 };
  inheritedVelocityScale = 0.0;
  trailType = 2;
  trailString = "breath.dts";
  smokeDist = 8;
};

//--------------------------------------
// veryt cool low level ice spell
//--------------------------------------
RocketData IceBolt
{
  bulletShapeName = "blueball.dts";
  explosionTag = Shockwave;
  collisionRadius = 0.0;
  mass = 2.0;
  damageClass = 1;
  damageValue = 0.30;
  damageType = $SpellDamageType;
  explosionRadius = 4.5;
  kickBackStrength = 5.0;
  muzzleVelocity = 130.0;
  terminalVelocity = 130.0;
  acceleration = 5.0;
  totalTime = 6.5;
  liveTime = 10.0;
  lightRange = 5.0;
  lightColor = { 5.20, 6.7, 1.5 };
  inheritedVelocityScale = 0.0;
  trailType = 2;
  trailString = "rsmoke.dts";
  smokeDist = 4;
};
//--------------------------------------
// small blu emagic ball with sm,all explosion
//--------------------------------------
BulletData MagicBolt
{
	bulletShapeName = "spiker.dts";
	explosionTag = debrisExpsmall;
	mass               = 0.005;

	damageClass        = 0;
	damageValue        = 0.15;
	damageType         = $SpellDamageType;
        explosionRadius    = 3.0;

	muzzleVelocity     = 100.0;
	totalTime          = 5.0;
	liveTime           = 4.0;
	lightRange         = 1.0;
	lightColor         = { 0, 0, 1 };
	inheritedVelocityScale = 0.3;
	isVisible          = True;

	soundId = SoundJetLight;

	rotationPeriod = 5;

   smokeName = "rsmoke.dts";
};
//--------------------------------------
// almost invisble looking laser beam
//--------------------------------------
LaserData MagicLaser
{
//   laserBitmapName   = "laserPulse.bmp";
   laserBitmapName   = "lightningNew.bmp";
   hitName           = "laserhit.dts";

   damageConversion  = 100;
   damageValue        = 0.1;
   damageType    = $SpellDamageType;

   beamTime          = 0.5;

   lightRange        = 2.0;
   lightColor        = { 1.0, 0.25, 0.25 };

   detachFromShooter = false;
   hitSoundId        = SoundLaserHit;
};
//--------------------------------------
// weird mortar that looks like a flyer?
//--------------------------------------
GrenadeData MortarTurretShell
{
   bulletShapeName    = "mortar.dts";
   explosionTag       = mortarExp;
   collideWithOwner   = True;
   ownerGraceMS       = 400;
   collisionRadius    = 1.0;
   mass               = 5.0;
   elasticity         = 0.1;

   damageClass        = 1;       // 0 impact, 1, radius
   damageValue        = 1.32;
   damageType         = $SpellDamageType;

   explosionRadius    = 30.0;
   kickBackStrength   = 250.0;
   maxLevelFlightDist = 400;
   totalTime          = 1000.0;
   liveTime           = 2.0;
   projSpecialTime    = 0.05;

   inheritedVelocityScale = 0.5;
   smokeName          = "flyer.dts";
   //smokeName          = "plasmaex.dts";//coolish
   //smokeName          = "plasmatrail.dts";//best
   //smokeName          = "plastrail.dts";//best
   //smokeName              = "mortartrail.dts";
};
//--------------------------------------
// 
//--------------------------------------
RocketData FlierRocket
{
   bulletShapeName  = "rocket.dts";
   explosionTag     = rocketExp;
   collisionRadius  = 0.0;
   mass             = 2.0;

   damageClass      = 1;       // 0 impact, 1, radius
   damageValue      = 0.5;
   damageType       = $SpellDamageType;

   explosionRadius  = 9.5;
   kickBackStrength = 250.0;
   muzzleVelocity   = 65.0;
   terminalVelocity = 80.0;
   acceleration     = 5.0;
   totalTime        = 10.0;
   liveTime         = 11.0;
   lightRange       = 5.0;
   lightColor       = { 1.0, 0.7, 0.5 };
   //inheritedVelocityScale = 0.5;

   // rocket specific
   trailType   = 2;                // smoke trail
   trailString = "rsmoke.dts";
   smokeDist   = 1.8;

   soundId = SoundJetHeavy;
};
//--------------------------------------
// 
//--------------------------------------
SeekingMissileData TurretMissile
{
   bulletShapeName = "rocket.dts";
   explosionTag    = rocketExp;
   collisionRadius = 0.0;
   mass            = 2.0;

   damageClass      = 1;       // 0 impact, 1, radius
   damageValue      = 0.5;
   damageType       = $SpellDamageType;
   explosionRadius  = 9.5;
   kickBackStrength = 175.0;

   muzzleVelocity    = 72.0;
   totalTime         = 10;
   liveTime          = 10;
   seekingTurningRadius    = 9;
   nonSeekingTurningRadius = 75.0;
   proximityDist     = 1.5;
   smokeDist         = 1.75;

   lightRange       = 5.0;
   lightColor       = { 0.4, 0.4, 1.0 };

   inheritedVelocityScale = 0.5;

   soundId = SoundJetHeavy;
};

function Lightning::damageTarget(%target, %timeSlice, %damPerSec, %enDrainPerSec, %pos, %vec, %mom, %shooterId)
{
	dbecho($dbechoMode, "Lightning::damageTarget(" @ %target @ ", " @ %timeSlice @ ", " @ %damPerSec @ ", " @ %enDrainPerSec @ ", " @ %pos @ ", " @ %vec @ ", " @ %mom @ ", " @ %shooterId @ ")");

   %damVal = %timeSlice * %damPerSec;
   %enVal  = %timeSlice * %enDrainPerSec;

   GameBase::applyDamage(%target, $ElectricityDamageType, %damVal, %pos, %vec, %mom, %shooterId);

   %energy = GameBase::getEnergy(%target);
   %energy = %energy - %enVal;
   if (%energy < 0) {
      %energy = 0;
   }
   GameBase::setEnergy(%target, %energy);
}
