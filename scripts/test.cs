function String::includes(%this, %substr) {
    // return (strstr(%this, %substr) != -1);
}

function SpawnLight(%pos, %range, %rgb, %duration, %fade) {
    %x = getWord(%pos,0);
    %y = getWord(%pos,1);
    %z = getWord(%pos,2);

    %r = getWord(%rgb, 0);
    %g = getWord(%rgb, 1);
    %b = getWord(%rgb, 2);
    
    %light = newObject("", SimLight, Point, %range, %r, %g, %b, %x, %y, %z);

    if (%fade == True) {
        %steps = %duration / 0.1;
        for (%i = 1; %i <= %steps; %i++) {
            schedule("deleteObject("@%light@");", %i * 0.1, %light);
            schedule("SpawnLight(\""@%pos@"\", " @ (%range - (%i * (%range / %steps))) @", \""@%rgb@"\", 0.1);", %i * 0.1);
        }
    } else {
        schedule("deleteObject("@%light@");", %duration, %light);
    }
}

function DivineMeteor::ShineLight(%this, %str) {
    //newObject("",SimLight,Point);
    //SimLight: Point range intR intG intB posX posY posZ
    %pos = GameBase::getPosition(%this);
    %range = %str/50;
    %x = getWord(%pos,0);
    %y = getWord(%pos,1);
    %z = getWord(%pos,2);
    %light = newObject("",SimLight,Point,%range,1.0,1.0,1.0,%x,%y,%z);
    schedule("deleteObject("@%light@");",0.105,%light);
    %str--;
    if(%str > 0 && %pos != "0 0 0")
        schedule("DivineMeteor::ShineLight("@%this@","@%str@");",0.1);
    else
    {
        $DivineMeteorList = RemoveFromWordList($DivineMeteorList,%this);
        %list = $DivineMeteorList;
        for(%i=0;%i<30;%i++)
        {
            if(getWord(%list,%i) != -1)
            {
                $DivineMeteorTrackPos = GameBase::getPosition(getWord(%list,%i));
                break;
            }
        }
        $DivineMeteorTrackPos = "0 0 0";
    }
}

function test() {
    lbecho("===================================================");
    lbecho("=                 TEST SCRIPT                     =");                                                                             
    lbecho("===================================================");
}