using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLocker : MonoBehaviour
{
    GameObject[] Level2Buttons; //array to store level select buttons
    public static LevelLocker LevelLockerRef; //reference to this script
    public bool isWin = false; //win boolean
    public bool Lvl1Win = false;
    public bool Level2Win = false;


    // Start is called before the first frame update
    void Start()
    {
        //Lvl1Win = ScreenLimit.ScreenLimitRef.Level1Win;
        //Lvl1Win = false;
        //array will store a button corresponding to the level number
        Level2Buttons = GameObject.FindGameObjectsWithTag("Level2Button");
            //for each object tagged "Buttons", it will be hidden at the start of the level
            foreach(GameObject button in Level2Buttons)
            {
                if(Lvl1Win == true)
                //{
                    button.SetActive(true);
                //}

                else
                {
                    button.SetActive(false);
                }
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
