using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScheduleWithCase : MonoBehaviour
{
    [SerializeField] private string weekday = "Monday";

    void Start()
    {
        switch(weekday) 
        {
            case "Monday":
                Debug.Log("On Monday I have to work on school project.");
                break;
            case "Tuesday":
                Debug.Log("On Tuesday I have a lecture I need to attend.");
                break;
            case "Wednesday":
                Debug.Log("On Wednesday I have to work on school project again.");
                break;
            case "Thursday":
                Debug.Log("On Thursday I have another lecture I need to attend.");
                break;
            case "Friday":
                Debug.Log("On Friday I have to work on school project again before I can go to Pizza Friday at my parent's place.");
                break;
            case "Saturday":
                Debug.Log("On Saturday I can game with my boyfriend and recharge after school week.");
                break;
            case "Sunday":
                Debug.Log("On Sunday I can game with my boyfriend and recharge after school week.");
                break;
        }
    }
}
