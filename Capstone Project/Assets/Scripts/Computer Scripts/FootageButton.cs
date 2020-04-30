using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FootageButton : MonoBehaviour
{
    public GameObject audioTranscript;

    public void Start()
    {
        audioTranscript.GetComponent<Text>();
    }

    public void SceneOne()
    {
        audioTranscript.GetComponent<Text>().text = 
            "Nikar: Patrisha? \n" +
            "Patrisha: Hmm? \n" +
            "Nikar: How are you holding up? \n" +
            "Patrisha: Fine... \n" +
            "Nikar: Hey, do you know anything about the new dents on the droid's exterior plating?... Come on man. I can't keep writing it off as normal wear-and-tear...the camera is all messed up too. \n" +
            "Patrisha: Like I care. \n" +
            "Nikar: Are you ok? I know you haven't gotten over what happened to Connie. Don't blame the droid, he had nothing to do with it. \n" +
            "Patrisha: ...Connie was the only good one. The only one who wasn't total garbage. Everyone else is trash. \n" +
            "Nikar: I understand. You're grieving. But you need to stop beating up the droid. We need it. \n" +
            "Patrisha: Whatever..." +
            "\n\n End Log"
            ;
    }

    public void SceneTwo()
    {
        audioTranscript.GetComponent<Text>().text = 
            "BG-19: Engineer Atlas, this repair requires your authorization code. \n" +
            "Nikar: What? What's wrong with your code? \n" +
            "BG-19: You deleted it when attempting to update my vocal processor. \n" +
            "Nikar: What? When did I do that? \n" +
            "BG-19: Galactic standard 2245.312.1427 Log Entry 329. Attempt to modify BG's vocal processor to make BG sound less creepy. \n" +
            "Dex: Damnit Nikar. Not again. \n" +
            "Nikar: Here, I'll authorize it. Engineer Nikar Atlas, Authorization Code 3891. \n" +
            "Patrisha: Move droid. \n" +
            "Nikar: Patrisha, cut it out. \n" +
            "Patrisha: Back off Nikar. I'm on backup comms duty and I need to use this terminal. \n" +
            "Nikar: Dude, there are four terminals in here. You can literally use any other one...Shit! Patrisha! Dex! Shit! Dex! What the hell happened. \n" +
            "BG-19: The terminal had an electrical overload. \n" +
            "Nikar: I can see that! Get Lucan! \n" +
            "BG-19: Do you mean Medical Officer Marsh? \n" +
            "Nikar: Yes! Get help! Two people are dying!" +
            "\n \n End Log"
            ;
    }
    
    public void SceneThree()
    {
        audioTranscript.GetComponent<Text>().text = 
            "Olyk: Damnit! That's three dead...prepare the bodies for ejection. I'll log the deaths. \n" +
            "Lucan: Yes Captain. \n" +
            "Captain’s log, Authorization Code 1103. Stardate 2245.320.1645, Helmsman Patrisha T’lah and Communications Officer Dex Dyrco were killed after an electrical overload in Terminal C3... End Log... In less than a week, we’ve lost three members of our crew. Do you have any idea how unprecedented that is for this expedition? So Yeon, Tua, and I have been on this expedition before. Hell, 10 crews have done this before. And yet, this instance, this is the only expedition where we have lost lives. How do you think I feel? \n" +
            "Lucan: We're all grieving captain. \n" +
            "Olyk: I don’t care about that! My reputation as a Captain is at stake...This is my first expedition as captain. Do you think I will be offered that position again after all this? \n" +
            "Lucan: These were freak accidents. I would hardly say these accidents were your fault. \n" +
            "Olyk: Three deaths under my watch, Lucan. I'm at fault here. \n" +
            "So Yeon: Sir? I think we have an error in the sealings. \n" +
            "Computer: Airlocks are disengaged. Airlocks are disengaged. Cargo Holds 3 and 4 are compromised. \n" +
            "So Yeon: The hallways are destabilizing! The ship's oxygen levels are dropping rapidly! \n" +
            "Olyk: Emergency lockdown! Close all outer seals! \n" +
            "Computer: All exits are sealed. Air pressure stabilized. Oxygen levels at 49%. /n" +
            "Olyk: Damage report. \n" +
            "So Yeon: 58% of the packages are accounted for. We have lost over half of our air supply. We have only one space suit and three oxygen tanks left. \n" +
            "Nikar: It seems like the airlock system malfunctioned. One of the pressurizers failed to stabilize the room before opening the outer door. \n" +
            "Olyk: Crew status. \n" +
            "So Yeon: Calling all crew to report in via comm unit... Captain... \n" +
            "Olyk: Who? \n" +
            "So Yeon: Ryan, Pir, and Yingrind. They were in the storage rooms when the airlock malfunctioned. \n" +
            "Olyk: Fuck... I'm ordering a complete lockdown. We do everything manually from this point on. Am I clear? \n" +
            "So Yeon: Yes, captain. \n" +
            "Lucan: Yes, captain. \n" +
            "Olyk: As for BG, you will report to my quarters immediately for further questioning. \n" +
            "BG-19: Yes, Captain." +
            "\n \n End Log";
    }
    
    public void SceneFour()
    {
        audioTranscript.GetComponent<Text>().text = 
            "BG-19: Here is the updated inventory report for each room, Commander Ryu. \n" +
            "So Yeon: Thanks, BG. We should see if we can fix the airlock next. \n" +
            "BG-19: I will notify Engineer Atlas. \n" +
            "So Yeon: Since there are only six of us left, we should manage our time-- \n" +
            "Tua: Hey, what do you think happened to Patrisha? \n" +
            "Neb: What do you mean? He died of electricution." +
            "Tua: I saw the security footage before the explosion though. There was nothing out of the ordinary, except... \n" +
            "Neb: Except? \n" + 
            "Tua: Nikar was repairing BG at that terminal before that happened. Maybe-- \n" +
            "Neb: You aren't thinking of Nikar, are you? \n" +
            "So Yeon: Enough! Nikar has been an asset to this crew. The last thing we need right now is to turn against on another. \n" +
            "Neb: I get that Patrisha wasn't anyone's favorite person after Connie died. He was... nice, but I don't think anyone killed him. \n" +
            "Tua: Someone may have manipulated the footage to make it look like an accident. \n" +
            "BG-19: Commander, Engineer Atlas has finished correction the airlock malfunction. \n" +
            "So Yeon: Thank you, BG. That will be all for today. \n" +
            "Toa: Come on, you can't help but wonder. He was an ass before but after what happened to Connie, he just got worse. I mean, he was literally beating up BG. I wouldn't be surprised if one of us did it. \n" +
            "Neb: Tua, I know BG is a machine, but you didn't have to say it like that, especially in front of the droid. You realize he's a walking security feed, right? \n" +
            "Tua: So what? He's all busted up anyway, I doubt he's recording. \n" +
            "So Yeon: That reminds me. We should reboot BG. Maybe his system reports will tell us something. \n" +
            "Tua: Be careful, So Yeon. I don't trust that droid... \n" +
            "Neb: Commander, you need to follow me! The captain was found dead-- \n" +
            "So Yeon: What? When? How? \n" +
            "Neb: He was crushed by the bridge door and... \n" +
            "So Yeon: And what? \n" +
            "Neb: Tua's dead too." +
            "\n\n End Log";
    }
    
    public void SceneFive()
    {
        audioTranscript.GetComponent<Text>().text = 
            "BG-19: Rewinding the feed. Consolidating the videos. \n" +
            "Neb: Are you sure we should be looking at the feeds? What if it was another malfunction? \n" +
            "Nikar: Well-- \n" +
            "Neb: I mean, you're one of the best mechanics out there, but you are only human. Plus this ship is old as fuck. \n" +
            "Nikar I am-- \n" +
            "So Yeon: BG, you're taking too long. First Mate So Yeon Ryu. Manual overdrive droid system. Authorization code 1710. \n" +
            "BG-19: Error. Authorization failed. Not within clearance. \n" +
            "So Yeon: Impossible. The only one with a higher clearance is Captain Olyk. When he passed, that clearance should have gone to me… BG return to your quarters. I'll reboot you shortly. All the feeds from your system completed downloading into the ship's computer drive, yes? \n" +
            "BG-19: Yes, Commander. \n" +
            "So Yeon: Alright. Dismissed. \n" +
            "Neb: Look, ok. I didn't mean to offend you Nikar. Just speaking all of the possibilities out loud here. \n" +
            "Nikar: Well your tone suggest otherwise. Regardless, I'll go do another round of checks to triple check. \n" +
            "Lucan: So Yeon, Neb! Wait, where's Nikar going? \n" +
            "So Yeon: Triple checking the ship mechanics. \n" +
            "Lucan: Where's BG? \n" +
            "So Yeon: Did you have something to tell us, Lucan? \n" +
            "Lucan: Yes...Captain...Olyk...I saw...I saw what happened..." +
            "\n\n End Log";
    }
}
