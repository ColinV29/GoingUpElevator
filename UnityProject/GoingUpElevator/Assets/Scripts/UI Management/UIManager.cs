using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public int GameState = 0;
    public GameObject pauseMenu;
    public progression progression;


    public void Quit()
    {
       Application.Quit();
    }

    public void play()
    {

        GameState = 1;
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        progression.buttonsActive = true;
        Debug.Log("Play Ball!");
    }
}
