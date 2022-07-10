using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject gameoverC;
    public GameObject restartb;
    public GameObject quitb;
    public GameObject pauseb;
    public GameObject resumeb;

    private void Start()
    {
        gameoverC.SetActive(false);
    }
    public void Window()
    {
        pauseb.SetActive(false);
        Time.timeScale = 0;
        gameoverC.SetActive(true);
    }

    public void Restart()
    {
        
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }

    public void Quit()
    {
        print("Quittted");
        SceneManager.LoadScene("Start");
    }

    public void Resume()
    {
        pauseb.SetActive(true);
        gameoverC.SetActive(false);
        Time.timeScale = 1;
    }

    public void Pause()
    {
        pauseb.SetActive(false);
        gameoverC.SetActive(true);
        Time.timeScale = 0;
    }

    
}