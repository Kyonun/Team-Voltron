using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenLimit : MonoBehaviour
{

    public Text EndGameMessage;
    public int ObjectsToEliminateAmount;
    public int ObjectsToEliminateCount;

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


    
    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.GetComponent<ObjectManager>().ObjToKeep == true)
        {
            EndGameMessage.gameObject.SetActive(true);
            EndGameMessage.text = "You Lose!";
            Time.timeScale = 0;
        }

        if(other.GetComponent<ObjectManager>().ObjToEliminate == true)
        {
            ObjectsToEliminateCount += 1;

            if(ObjectsToEliminateCount == ObjectsToEliminateAmount) 
            {
                EndGameMessage.gameObject.SetActive(true);
                EndGameMessage.text = "YOU WIN!";
                Time.timeScale = 0;
            }
        }
        
        Destroy (other.gameObject);
    }
}