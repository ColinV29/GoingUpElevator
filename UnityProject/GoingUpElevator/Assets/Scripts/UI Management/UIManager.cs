using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UIManager : MonoBehaviour
{
    public int GameState = 0;
    public GameObject pauseMenu;
    public GameObject settingsMenu;
    public progression progression;
    public UnityEvent Startpressed;

    private void Start()
    {
        settingsMenu.SetActive(false);
    }


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
        Startpressed.Invoke();
    }

    public void settings_pressed()
    {
        pauseMenu.SetActive(false);
        settingsMenu.SetActive(true);

    }

    public void back_pressed()
    {
        settingsMenu.SetActive(false);
        pauseMenu.SetActive(true);

    }
}
