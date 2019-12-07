/**
 * ClickScript handles displaying the amount of clicks
 * to the UI. ClickScript should be a component of the 
 * Text box that displays the click count.
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ClickScript : MonoBehaviour
{
    public static ClickScript clickScriptRef;
    public Text EndGameMessage;
    private int clicksLeft;
    private int initialClicks;
    Text clickAmount;

    private void Start()
    {
        clickScriptRef = this; // Reference to ClickScript
        clickAmount = GetComponent<Text>(); // Refers to whatever the Text object's script component is


    } // end Start

    private void Update()
    {
        clicksLeft = ClickManager.clickManagerRef.clicksLeft;

        if (clicksLeft < 4)
            clickAmount.color = Color.red;     // warns the player of imminent defeat

        if (clicksLeft > 0)
            clickAmount.text = "Clicks Left: " + clicksLeft.ToString();
        else
        {
            clickAmount.text = "OUT OF CLICKS";
            EndGameMessage.text = "You Lose!";
            Time.timeScale = 0;

        }


    } // end Update */

}
