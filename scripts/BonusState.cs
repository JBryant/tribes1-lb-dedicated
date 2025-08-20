//======================================================================
// Bonus States are special bonuses for a certain player that last a
// certain amount of ticks.  A tick is decreased every 2 seconds by
// the zone check.
//======================================================================

$maxBonusStates = 20;

function DecreaseBonusStateTicks(%clientId, %b)
{
	// %hasParry = HasBonusState(%clientId, "Parry");
	// lbecho("client " @ %clientId @ " has parry: " @ %hasParry);

	if(%b != "") {
		//Decrease specified tick for the player
		$BonusStateCnt[%clientId, %b]--;

		if($BonusStateCnt[%clientId, %b] <= 0) {
			$BonusStateCnt[%clientId, %b] = "";
			$BonusState[%clientId, %b] = "";
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
					Client::sendMessage(%clientId, 0, $BonusStateName[%clientId, %i] @ " has expired.");

					$BonusStateName[%clientId, %i] = "";
					$BonusStateCnt[%clientId, %i] = "";
					$BonusState[%clientId, %i] = "";
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

function UpdateBonusState(%clientId, %type, %ticks, %name) {
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