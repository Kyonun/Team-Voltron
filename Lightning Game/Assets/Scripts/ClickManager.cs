/**
 * ClickManager stores the values needed for displaying
 * the click amount on the UI. It allows for easy 
 * modification of the maximum clicks allowed for the
 * game.
**/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Please add this to each level's "Script" object. - Phil
public class ClickManager : MonoBehaviour
{
    public static ClickManager clickManagerRef;
    public int maxClicks = 15;
    public int clicksLeft;

    // Start is called before the first frame update
    void Start()
    {
        clickManagerRef = this; // reference to ClickManager script. 
        clicksLeft = maxClicks;
    } // end start
}// end class
