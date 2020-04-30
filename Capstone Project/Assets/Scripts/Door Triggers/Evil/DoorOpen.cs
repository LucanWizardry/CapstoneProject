using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;



/*
 *     Code for functional doors
 *
 *     Operations:
 *         1. door drops to a hissing sound
 *         2. 
 */
public class DoorOpen : MonoBehaviour
{
    //public GameObject interactionCube;
    //public GameObject doorObject;

    //private Animator anim;
    

    private void Start()
    {
        //anim = doorObject.GetComponent<Animator>();
    }
    
    
    public GameObject warningMessage;
    
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        warningMessage.SetActive(true);
        //anim.CrossFade("DoorDropping", 0);

    }

    private void OnTriggerExit(Collider other)
    {
        warningMessage.SetActive(false);
    }
}
