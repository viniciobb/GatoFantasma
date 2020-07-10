using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    
    // Update is called once per frame
    

    public void Resume()
    {
        Debug.Log("Resumed");
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        Debug.Log("Paused");
        Time.timeScale = 0f; // freeses de game

    }

    public void QuitGame()
    {
        Application.Quit();

    }
}
