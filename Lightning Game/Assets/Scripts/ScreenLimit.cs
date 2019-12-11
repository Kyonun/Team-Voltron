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
    public bool Level1Win = false;
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
    }
    
    void OnTriggerEnter2D (Collider2D other)
    {
        //loss state
        if(other.GetComponent<ObjectManager>().ObjToKeep == true)
        {
            //display loss text
            EndGameMessage.gameObject.SetActive(true);
            EndGameMessage.text = "You Lose!";
            Time.timeScale = 0;
            Loss = true;
        }

        //win state
        if(other.GetComponent<ObjectManager>().ObjToEliminate == true)
        {
            ObjectsToEliminateCount += 1;

            if(ObjectsToEliminateCount == ObjectsToEliminateAmount) 
            {
                //display win text
                EndGameMessage.gameObject.SetActive(true);
                EndGameMessage.text = "YOU WIN!";
                
                //reactivate any hidden buttons
                foreach(GameObject button in buttons)
                {
                    button.SetActive(true);
                }

                //set Level1Win to true, unlocks level 2
                /*if (SceneManager.GetActiveScene().name == "WoodLevel1")
                {
                    //Level1Win = true;
                    LevelLocker.LevelLockerRef.Lvl1Win = true;
                    Time.timeScale = 0;
                    Win = true;
                }*/

                Time.timeScale = 0;
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
}