using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using TMPro;

public class GameManager : MonoBehaviour
{
    public InputActionReference pauseAction;
    public GameObject pauseMenu;
    public GameObject defeatMenu;
    public GameObject player;
    public Transform defeat;
    public TMP_Text timeText;
    public GameObject timeTextobj;
    public float timer = 50;

    private void Awake()
    {
        pauseAction.action.started += Pause;
    }

    private void OnDestroy()
    {
        pauseAction.action.started -= Pause;
    }
    private void Start()
    {

    }
    private void Update()
    {
        timer -= Time.deltaTime;
        float min = Mathf.FloorToInt(timer / 60);
        float sec = Mathf.FloorToInt(timer % 60);
        timeText.text = string.Format("{0,0}:{1,00}", min, sec);
        if (timer <= 0)
        {
            timeTextobj.SetActive(false);
            defeatMenu.SetActive(true);
            player.transform.position = defeat.position;
        }
    }
    private void Pause(InputAction.CallbackContext context)
    {
        bool isActive = !pauseMenu.activeSelf;
        pauseMenu.SetActive(isActive);
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(1);
    }
    public void MenuScene()
    {
        SceneManager.LoadScene(0);
    }

}
