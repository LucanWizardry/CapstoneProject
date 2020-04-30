using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Code used to activate message for computer interaction and the way to open the computer screen
 */

public class ComputerTrigger : MonoBehaviour
{
    public GameObject activationText;
    public GameObject computerPanel;
    private void OnTriggerEnter(Collider other)
    { 
        activationText.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        activationText.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.X) == true)
        {
            activationText.SetActive(false);
            computerPanel.SetActive(true);
        }
    }
}
