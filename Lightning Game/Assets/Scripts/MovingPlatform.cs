using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    float dirx;
    public float moveSpeed = 3f; // making this available to the GUI
    public float maxRange = 5f;
    public float minRange = -5f;
    bool mvRight = true;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > maxRange)
        {
            mvRight = false;
        }
        if(transform.position.x < minRange)
        {
            mvRight = true;
        }

        if (mvRight)
        {
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        } else
        {
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
        }
    }
}
