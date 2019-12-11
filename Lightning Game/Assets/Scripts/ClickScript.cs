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
    public bool Loss;
    GameObject[] buttons; //button array to store any objects tagged "Buttons"


    private void Start()
    {
        clickScriptRef = this; // Reference to ClickScript
        clickAmount = GetComponent<Text>(); // Refers to whatever the Text object's script component is
        
        //buttons array will store all objects with tag "Buttons"
        buttons = GameObject.FindGameObjectsWithTag("Buttons");

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

            foreach(GameObject button in buttons)
                {
                    button.SetActive(true);
                }

            Time.timeScale = 0;
            Loss = true;

        }


    } // end Update */

}
