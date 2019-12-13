using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectManager : MonoBehaviour
{
    public bool ClickToDestroy = false; //object will be destroyed when clicked
    public bool ObjToKeep = false;      //if true, you'll lose if this gets destroyed
    public bool ObjToEliminate = false; //if true, this object will help you win
    public static ObjectManager ObjectManagerRef; //reference to object manager
    private bool isLoss = false; //loss boolean
    private bool isWin = false;
    private bool clickLoss = false;
    void OnMouseDown()
    {
        //reference to Loss bool from ScreenLimit
        isLoss =  ScreenLimit.ScreenLimitRef.Loss;
        isWin = ScreenLimit.ScreenLimitRef.Win;
        clickLoss = ClickScript.clickScriptRef.Loss;

        //if you lose, clicks will no longer destroy blocks
        //if timeScale is 0, clicks will no longer destroy blocks (for pauses and glitched states)
        if (ClickToDestroy == true && isLoss == false && isWin == false && clickLoss == false && Time.timeScale == 1)
        {
            Destroy(gameObject);

            // Decrements clicksLeft value stored in the ClickManager script
            ClickManager.clickManagerRef.clicksLeft--;
        }
    } // end OnMouseDown

    void Start()
    {
        ObjectManagerRef = this;
    }
} // end class
