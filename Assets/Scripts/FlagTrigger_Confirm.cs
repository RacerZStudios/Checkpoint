using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagTrigger_Confirm : MonoBehaviour
{
    public GameObject []flag;
    private static int score; 

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Flag_Trigger" && flag[0].gameObject.name == "Flag_01")
        {
            flag[0].gameObject.SetActive(false);
            score += 1;
            Debug.Log(score);
            return; 
        }
    }
}