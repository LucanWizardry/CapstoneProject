using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPanel : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject computerPanelUI;

    void Update()
    {
        if (computerPanelUI.activeSelf == true)
        {
            Cursor.visible = true;
            Screen.lockCursor = false;
        }
    }

    public void Resume ()
    {
        computerPanelUI.SetActive(false);
        GameIsPaused = false;
        Screen.lockCursor = true;
        Cursor.visible = false;
    }

    public void Pause ()
    {
        computerPanelUI.SetActive(true);
        GameIsPaused = true;
        Screen.lockCursor = false;
        Cursor.visible = true;
    }
}
