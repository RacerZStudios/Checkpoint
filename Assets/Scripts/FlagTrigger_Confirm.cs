using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagTrigger_Confirm : MonoBehaviour
{
    public GameObject flag;
    private static int score; 

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Flag_Trigger")
        {
            flag.gameObject.SetActive(false);
            score += 1;
            Debug.Log(score); 
        }
    }
}