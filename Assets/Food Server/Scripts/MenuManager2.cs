using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager2 : MonoBehaviour
{
    public void LoadScene2()
    {
        SceneManager.LoadScene(1);
    }
    public void Menu2()
    {
        SceneManager.LoadScene(0);
    }

    public void Quitapp2()
    {
        Application.Quit();
    }
}

