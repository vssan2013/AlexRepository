using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausedMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject respawn;
    public GameObject player;

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;

    }
    public void LoadGame()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
    }
    public void Respawn()
    {
        pauseMenuUI.SetActive(false);
        player.transform.position = respawn.transform.position;
        Time.timeScale = 1f;
    }
}
