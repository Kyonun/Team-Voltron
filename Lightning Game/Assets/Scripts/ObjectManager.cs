using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public bool ClickToDestroy = false; //object will be destroyed when clicked
    public bool ObjToKeep = false; //if true, you'll lose if this gets destroyed
    public bool ObjToEliminate = false; //if true, this object will help you win
    // Start is called before the first frame update
    void OnMouseDown()
    {
        if(ClickToDestroy == true)
        {
            Destroy(gameObject);
        }
    }
}
