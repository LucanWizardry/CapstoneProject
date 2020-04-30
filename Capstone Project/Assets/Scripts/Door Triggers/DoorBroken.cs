using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBroken : MonoBehaviour
{
    public GameObject warningMessage;
    
    

    private void OnTriggerEnter(Collider other)
    {
        warningMessage.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        warningMessage.SetActive(false);
    }
}
