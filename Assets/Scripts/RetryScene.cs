using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryScene : MonoBehaviour
{
    //FPSScript playerMovement;
    public static bool gameOver;

    public GameObject retryMenuUI;
    public GameObject CurrentUI;

    void Start()
    {
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            Time.timeScale = 0f;
            CurrentUI.SetActive(false);
            retryMenuUI.SetActive(true);
        }
    }

    public void Retry()
    {
        //playerMovement.Death();
        Time.timeScale = 1.0f;
        retryMenuUI.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadMenu()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Menu");
    }
}
