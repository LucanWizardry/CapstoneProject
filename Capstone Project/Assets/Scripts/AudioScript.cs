using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 *    Code to make te footstep sound as character walks around
 */

public class AudioScript : MonoBehaviour
{
    CharacterController cc;


    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cc.isGrounded == true && cc.velocity.magnitude > 1f && GetComponent<AudioSource>().isPlaying == false)
        {
            GetComponent<AudioSource>().volume = Random.Range(0.3f, 0.6f);
            GetComponent<AudioSource>().pitch = Random.Range(0.8f, 1f);
            GetComponent<AudioSource>().Play();
        }
    }
}
