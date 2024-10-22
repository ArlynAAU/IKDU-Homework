using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScheduleWithoutCase : MonoBehaviour
{
    [SerializeField] private string weekday = "Monday";

    void Start()
    {
        if (weekday == "Monday")
        {
            Debug.Log("On Monday I have to work on school project.");
        }
        else if (weekday == "Tuesday")
        { 
            Debug.Log("On Tuesday I have a lecture I need to attend.");
        }
        else if (weekday == "Wednesday")
        {
            Debug.Log("On Wednesday I have to work on school project again.");
        }
        else if (weekday == "Thursday")
        {
            Debug.Log("On Thursday I have another lecture I need to attend.");
        }
        else if (weekday == "Friday")
        {
            Debug.Log("On Friday I have to work on school project again before I can go to Pizza Friday at my parent's place.");
        }
        else if (weekday == "Saturday")
        {
            Debug.Log("On Saturday I can game with my boyfriend and recharge after school week.");
        }
        else if (weekday == "Sunday")
        {
            Debug.Log("On Sunday I can game with my boyfriend and recharge after school week.");
        }
            
    }
}
