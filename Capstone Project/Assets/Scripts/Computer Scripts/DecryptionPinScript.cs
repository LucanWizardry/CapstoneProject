using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DecryptionPinScript : MonoBehaviour
{
    public GameObject decryptionButton;
    
    public InputField captainsPin;
    public InputField firstMatePin;
    public InputField engineerPin;

    private string cPin;
    private string fmPin;
    private string ePin;

    // Start is called before the first frame update
    void Start()
    {
        decryptionButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        cPin = captainsPin.text;
        fmPin = firstMatePin.text;
        ePin = engineerPin.text;

        if (cPin == "1103" && fmPin == "1710" && ePin == "3891")
        {
            decryptionButton.SetActive(true);
        }
    }


    public void CaptainsCode()
    {
        if (cPin == "1103")
        {
            captainsPin.GetComponent<Image>().color = Color.green;
        }

        else
        {
            captainsPin.GetComponent<Image>().color = Color.red;
        }
    }

    public void FirstMateCode()
    {
        if (fmPin == "1710")
        {
            firstMatePin.GetComponent<Image>().color = Color.green;
        }

        else
        {
            firstMatePin.GetComponent<Image>().color = Color.red;
        }
    }

    public void EngineersCode()
    {
        if (ePin == "3891")
        {
            engineerPin.GetComponent<Image>().color = Color.green;
        }
        else
        {
            engineerPin.GetComponent<Image>().color = Color.red;
        }
    }
}
