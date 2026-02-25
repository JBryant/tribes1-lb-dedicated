//======================================================================
// Bonus States are special bonuses for a certain player that last a
// certain amount of ticks. A tick is decreased every 2 seconds by the
// zone check.
//
// Notes for agents:
// - Storage: $BonusStateCnt/%Name/%Attribute/%Modifier/%Periodic/%Giver
//   are keyed by [%clientId, %slot] where %slot is 1..$maxBonusStates.
// - UpdateBonusState() refreshes ticks if the same %type already exists,
//   otherwise it fills the first empty slot.
// - DecreaseBonusStateTicks() is called by the zone loop; when a slot
//   hits 0 it clears all slot fields and plays the expire sound. Sneak
//   also resets invisibility and fade.
// - AddBonusStatePoints(%clientId, "ATK"/"DEF"/"MDEF"/"MaxHP"/"MaxMANA"/"MaxWeight")
//   is how fetchData() applies temporary bonuses on stats.
// - Periodic effects: if $BonusStatePeriodic[%id,%slot] == True, the DOT
//   loop in zone.cs applies %Attribute/%Modifier each tick.
// - $SpecialVar indices (Accessory.cs): 3=MDEF, 4=HP, 5=Mana, 6=ATK,
//   7=DEF, 10=HP regen, 11=Mana regen, 12=MaxWeight.
//======================================================================

$maxBonusStates = 20;

function DecreaseBonusStateTicks(%clientId, %b) {
	if(%b != "") {
		//Decrease specified tick for the player
		$BonusStateCnt[%clientId, %b]--;

		if($BonusStateCnt[%clientId, %b] <= 0) {
			$BonusState[%clientId, %b] = "";
			$BonusState[%clientId, %b] = "";
			$BonusStateAttribute[%clientId, %b] = "";
			$BonusStateModifier[%clientId, %b] = "";
			$BonusStatePeriodic[%clientId, %b] = "";
			$BonusStateGiver[%clientId, %b] = "";
			playSound(BonusStateExpire, GameBase::getPosition(%clientId));
		}
	}
	else {
		%totalbcnt = 0;
		%truebcnt = 0;

		//Decrease all ticks for that player
		for(%i = 1; %i <= $maxBonusStates; %i++) {
			if($BonusStateCnt[%clientId, %i] > 0) {
				$BonusStateCnt[%clientId, %i]--;

				if($BonusStateCnt[%clientId, %i] <= 0) {
					if ($BonusStateName[%clientId, %i] == "Sneak") {
						GameBase::startFadeIn(%clientId);
						storeData(%clientId, "invisible", "");
						Client::sendMessage(%clientId, $MsgBeige, "You are no longer hidden in the shadows.");
					} else {
						Client::sendMessage(%clientId, $MsgRed, $BonusStateName[%clientId, %i] @ " has expired.");
					}

					$BonusStateName[%clientId, %i] = "";
					$BonusStateCnt[%clientId, %i] = "";
					$BonusState[%clientId, %i] = "";
					$BonusStateAttribute[%clientId, %i] = "";
					$BonusStateModifier[%clientId, %i] = "";
					$BonusStatePeriodic[%clientId, %i] = "";
					$BonusStateGiver[%clientId, %i] = "";

					playSound(BonusStateExpire, GameBase::getPosition(%clientId));
				}
				else {
					%totalbcnt++;
					if($BonusState[%clientId, %i] != "Jail" && $BonusState[%clientId, %i] != "Theft")
						%truebcnt++;
				}
			}
		}

		if(%truebcnt > 0)
			storeData(%clientId, "isBonused", True);
		else
			storeData(%clientId, "isBonused", "");
			
	}
}

function AddBonusStatePoints(%clientId, %filter) {
	%add = 0;
	for(%i = 1; %i <= $maxBonusStates; %i++) {
		if($BonusStateCnt[%clientId, %i] > 0) {
			for(%z = 0; (%p1 = GetWord($BonusState[%clientId, %i], %z)) != -1; %z+=2) {
				%p2 = GetWord($BonusState[%clientId, %i], %z+1);
				if(String::ICompare(%p1, %filter) == 0) {
					//same filter
					%add += %p2;
				}
			}
		}
	}

	return %add;
}

function UpdateBonusState(%clientId, %type, %ticks, %name, %giver, %attribute, %modifier, %periodic) {
	//look thru the current bonus states and attempt to update
	%flag = False;
	for(%i = 1; %i <= $maxBonusStates; %i++) {
		if($BonusStateCnt[%clientId, %i] > 0) {
			if(String::ICompare($BonusState[%clientId, %i], %type) == 0) {
				$BonusStateCnt[%clientId, %i] = %ticks;
				$BonusStateName[%clientId, %i] = %name;
				%flag = True;
			}
		}
	}

	if(!%flag) {
		//couldn't find a current entry to update, so make a new entry
		for(%i = 1; %i <= $maxBonusStates; %i++) {
			if( !($BonusStateCnt[%clientId, %i] > 0) ) {
				$BonusState[%clientId, %i] = %type;
				$BonusStateCnt[%clientId, %i] = %ticks;
				$BonusStateName[%clientId, %i] = %name;
				$BonusStateGiver[%clientId, %i] = %giver;

				if (%attribute != "")
					$BonusStateAttribute[%clientId, %i] = %attribute;
				if (%modifier != "")
					$BonusStateModifier[%clientId, %i] = %modifier;
				if (%periodic != "")
					$BonusStatePeriodic[%clientId, %i] = %periodic;
				if (%giver != "")
					$BonusStateGiver[%clientId, %i] = %giver;

				return True;
			}
		}
	}

	return %flag;
}

function GetBonusStatesMessage(%clientId) {
	%msg = "";
	for(%i = 1; %i <= $maxBonusStates; %i++) {
		if($BonusStateCnt[%clientId, %i] > 0) {
			%msg = %msg @""@ $BonusStateName[%clientId, %i] @": " @ $BonusState[%clientId, %i] @ " (" @ ($BonusStateCnt[%clientId, %i] * 2) @ "s)\n";
		}
	}

	return %msg;
}

function HasBonusState(%clientId, %type) {
	for(%i = 1; %i <= $maxBonusStates; %i++) {
		if($BonusStateCnt[%clientId, %i] > 0) {
			if(String::ICompare($BonusState[%clientId, %i], %type) == 0) {
				return True;
			}
		}
	}
	return False;
}

function GetBonusStateGiver(%clientId, %type) {
	for(%i = 1; %i <= $maxBonusStates; %i++) {
		if($BonusStateCnt[%clientId, %i] > 0) {
			if(String::ICompare($BonusState[%clientId, %i], %type) == 0) {
				return $BonusStateGiver[%clientId, %i];
			}
		}
	}
	return "";
}

function RemoveBonusState(%clientId, %type) {
	for(%i = 1; %i <= $maxBonusStates; %i++) {
		if($BonusStateCnt[%clientId, %i] > 0) {
			if(String::ICompare($BonusState[%clientId, %i], %type) == 0) {
				$BonusStateCnt[%clientId, %i] = 0;
				$BonusStateName[%clientId, %i] = "";
				$BonusState[%clientId, %i] = "";
				$BonusStateAttribute[%clientId, %i] = "";
				$BonusStateModifier[%clientId, %i] = "";
				$BonusStatePeriodic[%clientId, %i] = "";
				$BonusStateGiver[%clientId, %i] = "";
				return True;
			}
		}
	}
	return False;
}