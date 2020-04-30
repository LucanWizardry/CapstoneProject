using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class AirlockTrigger : MonoBehaviour
{
    
    public GameObject videoPlayer;
    public VideoPlayer player;
    public int timeToStop;
    public GameObject atmosphereMusic;
    public GameObject textBox;
    
    //private float timer = 0;

    private void Awake()
    {
        player.Prepare();
    }
    

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.SetActive(false);
        //player.GetComponent<VideoSource>();
        player.Prepare();
        
        textBox.SetActive(false);
        textBox.GetComponent<Text>().text = "Are you sure you want to go out the airlock into the black abyss of space? \nY / N";
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
            /*
            if (player.time == player.length)
            {
                Debug.Log("player if statement activated");
                
                videoPlayer.SetActive(false);
                player.Stop();
                atmosphereMusic.SetActive(true);
                timer = 0;
            }
            */


            /*
            Debug.Log("video ended");
            if (timer >= timeToStop)
            {
                videoPlayer.SetActive(false);
                atmosphereMusic.SetActive(true);
                timer = 0;
            }
            */
        }

        if (Input.GetKey(KeyCode.N))
        {
            videoPlayer.SetActive(false);
            textBox.SetActive(false);
        }
    }


    private void OnTriggerExit(Collider other)
    {
        Destroy(textBox);
        atmosphereMusic.SetActive(true);
    }


    /* 
     private void AreYouSure()
     {
         textBox.GetComponent<Text>().text = "Are you absolutely positive? \n Y / N";
         
         if (Input.GetKey(KeyCode.Y) == true)
         {
             PlayVideo();
         }
 
         if (Input.GetKey(KeyCode.N) == true)
         {
             textBox.SetActive(false);
             //textBox.GetComponent<Text>().text = "Do you want to go out the airlock? \n y / n";
         }
     }
 
     private void PlayVideo()
     {
         textBox.SetActive(false);
         
         //videoPlayer.SetActive(true); // turn video on
         atmosphereMusic.SetActive(false); // turn atmospheric music off
         //if ((!videoPlayer.IsPlaying))
         //Destroy(videoPlayer, timeToStop);   // destroy video player when finished
         //atmosphereMusic.SetActive(true);    // turn atmospheric music on
         
         //textBox.GetComponent<Text>().text = "Do you want to go out the airlock? \n y / n";
     }
     */
}
