using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject vehicle;
    public bool isPlayerEnter; 
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            isPlayerEnter = true; 
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isPlayerEnter = false;
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F) && isPlayerEnter == true)
        {
            isPlayerEnter = false; 
            player.gameObject.SetActive(false);
            vehicle.gameObject.GetComponent<CarController>().enabled = true;
            return; 
        }
        else if(Input.GetKeyDown(KeyCode.F) && isPlayerEnter == false)
        {
            player.gameObject.SetActive(true);
            vehicle.gameObject.GetComponent<CarController>().enabled = false;
            return; 
        }
    }
}