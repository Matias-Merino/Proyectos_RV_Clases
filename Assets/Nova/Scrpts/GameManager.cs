using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public InputActionReference pauseAction;
    public GameObject pauseMenu;
    public GameObject defeatMenu;
    public GameObject player;
    public Transform defeat;
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
        if (timer <= 0)
        {
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
