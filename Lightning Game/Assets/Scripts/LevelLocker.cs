using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelLocker : MonoBehaviour
{
    GameObject[] Level2Buttons; //array to store level 2 select buttons
    GameObject[] Level3Buttons; //array to store level 3 select buttons
    public static LevelLocker LevelLockerRef; //reference to this script
    public bool isWin = false; //win boolean
    public bool Lvl1WinInd = false; //level 1 win for industrial levels
    public bool Lvl2WinInd = false; //level 2 win for industrial levels
    public bool Lvl1WinCloud = false; //level 1 win for cloud levels
    public bool Lvl2WinCloud = false; //level 2 win for cloud levels


    // Start is called before the first frame update
    void Start()
    {
        //array will store a button corresponding to the level number
        Level2Buttons = GameObject.FindGameObjectsWithTag("Level2Button");
        Level3Buttons = GameObject.FindGameObjectsWithTag("Level3Button");

            //for each tagged object, it will be hidden at the start of the game
            //hide lvl 2 button
            /*foreach(GameObject button in Level2Buttons)
            {
                if(Lvl1WinInd == false || Lvl1WinCloud == false)
                    button.GetComponentInChildren<Text>().text = "Locked";
                
            }
            //hide lvl 3 button
            foreach(GameObject button in Level3Buttons)
            {
                if(Lvl2WinInd == false || Lvl2WinCloud == false)
                    button.GetComponentInChildren<Text>().text = "Locked";
            }*/

        StartCoroutine(buttonLock());
        
        LevelLockerRef = this;
    }

    // Update is called once per frame
    IEnumerator buttonLock()
    {
        foreach(GameObject button in Level2Buttons)
        {
            if(Lvl1WinInd == false)
                button.GetComponentInChildren<Text>().text = "Locked";
        }
        //hide lvl 3 button
        foreach(GameObject button in Level3Buttons)
        {
            if(Lvl2WinInd == false)
                button.GetComponentInChildren<Text>().text = "Locked";
        }

        yield return null;
    }

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
