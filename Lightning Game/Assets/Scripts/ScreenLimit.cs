using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScreenLimit : MonoBehaviour
{

    public Text EndGameMessage;
    public int ObjectsToEliminateAmount;
    public int ObjectsToEliminateCount;
    public bool Win = false;
    public bool Loss = false;
    public static ScreenLimit ScreenLimitRef; //reference to ScreenLimit to use in other functions
    GameObject[] buttons; //button array to store any objects tagged "Buttons"

    void Awake()
    {
        ObjectsToEliminateCount = 0;

        ObjectsToEliminateAmount = 0;
        ObjectManager[] AllObjs = FindObjectsOfType(typeof(ObjectManager)) as ObjectManager[];
        
        foreach(ObjectManager Obj in AllObjs)
        {
            if(Obj.ObjToEliminate == true)
            {
                ObjectsToEliminateAmount += 1;
            }
        }
    }

    void Start()
    {
        ScreenLimitRef = this; //reference this script

        //buttons array will store all objects with tag "Buttons"
        buttons = GameObject.FindGameObjectsWithTag("Buttons");
            //for each object tagged "Buttons", it will be hidden at the start of the level
            foreach(GameObject button in buttons)
            {
                button.SetActive(false);
            }
        if (Loss == true)
        {
            Time.timeScale = 0;
        }
    }
    
    void OnTriggerEnter2D (Collider2D other)
    {
        //loss state
        if(other.GetComponent<ObjectManager>().ObjToKeep == true)
        {
            //display loss text
            EndGameMessage.gameObject.SetActive(true);
            EndGameMessage.text = "You Lose!";

            //reactivate any hidden buttons
            foreach(GameObject button in buttons)
                {
                    button.SetActive(true);
                }

            Time.timeScale = 0;
            Loss = true;

            //if you lose level 1, locks level 2 industrial
            if (SceneManager.GetActiveScene().name == "WoodLevel1")
            {
                LevelLocker.LevelLockerRef.Lvl1WinInd = false;
                Time.timeScale = 0;
                Win = false;
                Loss = true;
            }
            //if you lose level 2, unlocks level 3 industrial
            if (SceneManager.GetActiveScene().name == "WoodLevel2")
            {
                LevelLocker.LevelLockerRef.Lvl2WinInd = false;
                Time.timeScale = 0;
                Win = false;
                Loss = true;
            }

            //if you lose level 1, locks level 2 cloud
            if (SceneManager.GetActiveScene().name == "CloudLevel")
            {
                LevelLocker.LevelLockerRef.Lvl1WinCloud = false;
                Time.timeScale = 0;
                Win = false;
                Loss = true;
            }
            //if you lose level 2, unlocks level 3 cloud
            if (SceneManager.GetActiveScene().name == "CloudLevel2")
            {
                LevelLocker.LevelLockerRef.Lvl2WinCloud = false;
                Time.timeScale = 0;
                Win = false;
                Loss = true;
            }
        }

        //win state
        if(other.GetComponent<ObjectManager>().ObjToEliminate == true)
        {
            ObjectsToEliminateCount += 1;

            if(ObjectsToEliminateCount == ObjectsToEliminateAmount) 
            {
                //wait to see if there is a way to lose before winning
                StartCoroutine(delay());

                //set Level1Win to true, unlocks level 2
                if (SceneManager.GetActiveScene().name == "WoodLevel1")
                {
                    LevelLocker.LevelLockerRef.Lvl1WinInd = true;
                    //Time.timeScale = 0;
                    Win = true;
                }
                 //set Level2Win to true, unlocks level 3
                if (SceneManager.GetActiveScene().name == "WoodLevel2")
                {
                    LevelLocker.LevelLockerRef.Lvl2WinInd = true;
                    //Time.timeScale = 0;
                    Win = true;
                }

                //if you lose level 1, locks level 2 cloud
                if (SceneManager.GetActiveScene().name == "CloudLevel")
                {
                    LevelLocker.LevelLockerRef.Lvl1WinCloud = true;
                    //Time.timeScale = 0;
                    Win = true;
                }
                //if you lose level 2, unlocks level 3 cloud
                if (SceneManager.GetActiveScene().name == "CloudLevel2")
                {
                    LevelLocker.LevelLockerRef.Lvl2WinCloud = true;
                    //Time.timeScale = 0;
                    Win = true;
                }
                 
                //Time.timeScale = 0;
                Win = true;
            }
        }
        
        Destroy (other.gameObject);
    }

    void Update()
    {
        if(Input.GetKeyDown("escape"))
        {
            foreach(GameObject button in buttons)
                {
                    if(button.activeSelf == true)
                    {
                        Time.timeScale = 1;
                        button.SetActive(false);
                    }
                    else 
                    {
                        Time.timeScale = 0;
                        button.SetActive(true);
                    }
                }
        }
    }

    IEnumerator delay()
    {
        EndGameMessage.gameObject.SetActive(true);
        EndGameMessage.text = "=CHECKING=";
        yield return new WaitForSeconds(1);
        EndGameMessage.text = "==CHECKING==";
        yield return new WaitForSeconds(1);
        EndGameMessage.text = "<==CHECKING==>";
        yield return new WaitForSeconds(1);
        EndGameMessage.text = "YOU WIN!";

        Time.timeScale = 0;
        //reactivate any hidden buttons
        foreach(GameObject button in buttons)
        {
            button.SetActive(true);
        }
    }
}