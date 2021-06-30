using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSwordDamageFalse : MonoBehaviour
{
    public int timeStart;
    public int timeEnd;

    // Update is called once per frame
    void Update()
    {
        timeStart += 1;
        if(timeStart >= timeEnd)
        {
            timeStart = 0;
            gameObject.SetActive(false);
        }
    }
}
