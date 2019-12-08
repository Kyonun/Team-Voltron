using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Title screen script
/// </summary>
public class MenuScript : MonoBehaviour
{
    /*------Menu Scenes------*/
    public void ExitDesktop()
    {
        Application.Quit();
    }

    public void ExitMenu()
    {
        Application.LoadLevel("PackSelect");
    }
    public void LoadPackSelect()
    {
        Application.LoadLevel("PackSelect");
        Time.timeScale = 1;
    }

    public void LoadTutorial()
    {
        Application.LoadLevel("Tutorial");
        Time.timeScale = 1;
    }
    public void LoadCloudSelect()
    {
        Application.LoadLevel("CloudLevelSelect");
        Time.timeScale = 1;
    }
    public void LoadIndustrialSelect()
    {
        Application.LoadLevel("IndustrialLevelSelect");
        Time.timeScale = 1;
    }
    public void LoadSpaceSelect()
    {
        Application.LoadLevel("SpaceLevelSelect");
        Time.timeScale = 1;
    }
    public void LoadStarWarsSelect()
    {
        Application.LoadLevel("StarWarsLevelSelect");
        Time.timeScale = 1;
    }
    public void StartGame()
    {
        // "Stage1" is the name of the first scene we created.
        Application.LoadLevel("PackSelect");
        Time.timeScale = 1;
    }

    /*------Level Scenes------*/
    public void LoadLightning()
    {
        Application.LoadLevel("0");
        Time.timeScale = 1;

    }
    public void LoadCloud1()
    {
        // "Stage1" is the name of the first scene we created.
        Application.LoadLevel("CloudLevel");
        Time.timeScale = 1;

    }

    public void LoadCloud2()
    {
        // "Stage1" is the name of the first scene we created.
        Application.LoadLevel("CloudLevel2");
        Time.timeScale = 1;

    }

    public void LoadCloud3()
    {
        // "Stage1" is the name of the first scene we created.
        Application.LoadLevel("CloudLevel3");
        Time.timeScale = 1;

    }

    public void LoadCloud4()
    {
        // "Stage1" is the name of the first scene we created.
        Application.LoadLevel("CloudLevel4");
        Time.timeScale = 1;

    }

    public void LoadTatooineLevel1()
    {
        // "Stage1" is the name of the first scene we created.
        Application.LoadLevel("TatooineLevel");
        Time.timeScale = 1;

    }

    public void LoadAlderaanLevel()
    {
        Application.LoadLevel("AlderaanLevel");
        Time.timeScale = 1;
    }

    public void LoadWoodLevel1()
    {
        Application.LoadLevel("WoodLevel1");
        GameObject.FindGameObjectWithTag("Music").GetComponent<MusicClass>().PlayMusic();
        Time.timeScale = 1;
    }

    public void LoadWoodLevel2()
    {
        Application.LoadLevel("WoodLevel2");
        GameObject.FindGameObjectWithTag("Music").GetComponent<MusicClass>().PlayMusic();
        Time.timeScale = 1;
    }

    public void LoadWoodLevel3()
    {
        Application.LoadLevel("WoodLevel3");
        Time.timeScale = 1;
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