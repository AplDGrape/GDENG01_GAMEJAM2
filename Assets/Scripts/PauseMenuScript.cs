using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class PauseMenuScript : MonoBehaviour
{
    public static bool PauseGame = false;

    public GameObject pauseMenuUI;

    public AudioMixer audioMixer;

    //OptionsMenu options;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseGame)
                Resume();
            else
                Pause();
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1.0f;

        audioMixer.SetFloat("Volume", -10);

        PauseGame = false;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1.0f;
        audioMixer.SetFloat("Volume", -10);
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;

        audioMixer.SetFloat("Volume", -60);

        PauseGame = true;
    }
}
