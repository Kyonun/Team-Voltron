using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    float dirx, moveSpeed = 3f;
    bool mvRight = true;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > 5f)
        {
            mvRight = false;
        }
        if(transform.position.x < -5f)
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
