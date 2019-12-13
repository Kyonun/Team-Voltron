using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Object.DontDestroyOnLoad example.
//
// This script example manages the playing audio. The GameObject with the
// "music" tag is the BackgroundMusic GameObject. The AudioSource has the
// audio attached to the AudioClip.

public class DontDestroy : MonoBehaviour
{
    public static DontDestroy DontDestroyRef;
    GameObject[] objs;
    GameObject[] levelLock;
    void Awake()
    {
        objs = GameObject.FindGameObjectsWithTag("Music");
        
        foreach (GameObject AudioSource in objs)
        {
            if (SceneManager.GetActiveScene().name == "WoodLevel1" || SceneManager.GetActiveScene().name == "WoodLevel2" || SceneManager.GetActiveScene().name == "WoodLevel3" || 
                SceneManager.GetActiveScene().name == "CloudLevel" || SceneManager.GetActiveScene().name == "CloudLevel2" || SceneManager.GetActiveScene().name == "CloudLevel3" ||
                SceneManager.GetActiveScene().name == "StarLevel")
            {
                AudioSource.SetActive(true);
            }

            else
            {
                AudioSource.SetActive(false);
            }
        }

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);

        DontDestroyRef = this;

        levelLock = GameObject.FindGameObjectsWithTag("Level");

        if (levelLock.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);


    }
}