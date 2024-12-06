using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public GameObject menu;
    public GameObject credits;
    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }
    public void MenuScene()
    {
        credits.SetActive(false);
        menu.SetActive(true);
    }
    public void Credits()
    {
        credits.SetActive(true);
        menu.SetActive(false);
    }
    public void Quitapp()
    {
        Application.Quit();
    }
}
