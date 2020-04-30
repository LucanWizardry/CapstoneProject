using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class ASceneTrigger : MonoBehaviour
{
    
    public GameObject videoPlayer;
    public VideoPlayer player;
    public int timeToStop;
    public GameObject atmosphereMusic;
    public GameObject textBox;
    public bool hasBeenActivated;


    private void Awake()
    {
        player.Prepare();
    }

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.SetActive(false);
        //player.Prepare();
        //player.GetComponent<VideoSource>();
        
        textBox.SetActive(false);
        textBox.GetComponent<Text>().text = "Play memory file? \n y / n";

        hasBeenActivated = false;
    }


    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        textBox.SetActive(true);
    }

    
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.Y))
        {
            atmosphereMusic.SetActive(false);
            textBox.SetActive(false);
            videoPlayer.SetActive(true);
            player.Play();
            Destroy(videoPlayer, timeToStop);
            hasBeenActivated = true;
        }

        if (Input.GetKey(KeyCode.N))
        {
            videoPlayer.SetActive(false);
            textBox.SetActive(false);
        }
    }


    private void OnTriggerExit(Collider other)
    {
        textBox.SetActive(false);
        atmosphereMusic.SetActive(true);
    }
}
