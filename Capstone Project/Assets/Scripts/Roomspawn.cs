using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roomspawn : MonoBehaviour
{
    public GameObject Prefab;
    public GameObject Prefab2Go;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Prefab.gameObject.SetActive(true);
            Prefab2Go.gameObject.SetActive(false);
        }
        GetComponent<Collider>().enabled = false;
    }
}
