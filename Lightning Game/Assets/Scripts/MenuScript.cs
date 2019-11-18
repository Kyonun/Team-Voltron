using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Title screen script
/// </summary>
public class MenuScript : MonoBehaviour
{
    public void StartGame()
    {
        // "Stage1" is the name of the first scene we created.
        Application.LoadLevel("LevelSelect");
    }

    public void LoadLightning()
    {
        Application.LoadLevel("0");
    }
    public void LoadCloud1()
    {
        // "Stage1" is the name of the first scene we created.
        Application.LoadLevel("CloudLevel");
    }
    
    public void LoadCloud2()
    {
        // "Stage1" is the name of the first scene we created.
        Application.LoadLevel("CloudLevel2");
    }
    
    public void LoadCloud3()
    {
        // "Stage1" is the name of the first scene we created.
        Application.LoadLevel("CloudLevel3");
    }

    public void LoadCloud4()
    {
        // "Stage1" is the name of the first scene we created.
        Application.LoadLevel("CloudLevel4");
    }

    public void LoadTatooineLevel1()
    {
        // "Stage1" is the name of the first scene we created.
        Application.LoadLevel("TatooineLevel");
    }

    public void ExitDesktop()
    {
        Application.Quit();
    }

    public void ExitMenu()
    {
        Application.LoadLevel("LevelSelect");
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
}