using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public static TimeManager timeManagerRef;
    public float maxTime = 60f;

    // Start is called before the first frame update
    void Start()
    {
        timeManagerRef = this;
    }

}
