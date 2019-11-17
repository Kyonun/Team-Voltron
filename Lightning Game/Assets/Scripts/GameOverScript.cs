using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Start or quit the game
/// </summary>
public class GameOverScript : MonoBehaviour
{
    private Button[] buttons;
    public bool HideButton = false;

    void Awake()
    {
        // Get the buttons
        buttons = GetComponentsInChildren<Button>();

        // Allows user to hide button in the UI - Made by: Phil
        if (HideButton) { HideButtons();}
       
    }

    public void HideButtons()
    {
        foreach (var b in buttons)
        {
            b.gameObject.SetActive(false);
        }
    }

    public void ShowButtons()
    {
        foreach (var b in buttons)
        {
            b.gameObject.SetActive(true);
        }
    }

    public void ExitGame()
    {
        
        Application.Quit();
    }

    public void RestartGame()
    {

        // Reload the level
        // Grab the active scene and reload it.
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);

        // OG Code:
        // Application.LoadLevel("CloudLevel");
        Time.timeScale = 1;
    }

    public void LoadCloudLevel2()
    {
        Application.LoadLevel("CloudLevel2");
        Time.timeScale = 1;
    }

    public void LoadCloudLevel3()
    {
        Application.LoadLevel("CloudLevel3");
        Time.timeScale = 1;
    }
}
