using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Delay : MonoBehaviour
{
    [SerializeField] private string loadLevel;
    [SerializeField] private float delayTime = 10.0f;

    private float timeElapsed;
    private void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > delayTime)
        {
            SceneManager.LoadScene(loadLevel);
        }
    }

}
