using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject startb;
    public GameObject quitb;

    public void Startm()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Quitm()
    {
        Application.Quit();
        print("AppQuited");
    }
}
