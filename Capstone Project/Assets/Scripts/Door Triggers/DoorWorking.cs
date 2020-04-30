using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 *  IF THE DOOR IS WORKING AND HAS A CUT SCENE:
 *     1. make door opening sound
 *     2. door drops animation
 *     3. play 
 */
public class DoorWorking : MonoBehaviour
{
    public GameObject doorTrigger;
    public GameObject warningMessage;

    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        warningMessage.SetActive(true);
        if (GetComponent<AudioSource>().isPlaying == false)
        {
            GetComponent<AudioSource>().volume = Random.Range(0.3f, 0.5f);
            GetComponent<AudioSource>().pitch = Random.Range(0.8f, 1f);
            GetComponent<AudioSource>().Play(); 
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // upon leaving the activation box and entering the room, deactivate the trigger so it stops
        
        warningMessage.SetActive(false);
        doorTrigger.SetActive(false);
    }
}


