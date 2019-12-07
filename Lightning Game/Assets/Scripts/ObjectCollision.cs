using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Add the tag names via the Unity UI in the script component window.
// The game object will be the parent transform if the script is a component
//  of the game object.
public class ObjectCollision : MonoBehaviour
{
    // if you want to add more tags to collide, create more public strings with
    //  relevant if statements

    public string greenTag = "";  // whatever is considered the "green box"
    public string redTag = "";    // whatever is considered the "red box"

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == greenTag)
        {
            // sets the object to be the child transform of the parent game object
            // that this script is a component of. 
            collision.collider.transform.SetParent(transform);
        }
        else if (collision.gameObject.tag == redTag)
        {
            // same as above comment in greenTag if statement.
            collision.collider.transform.SetParent(transform);
        }
    }
}