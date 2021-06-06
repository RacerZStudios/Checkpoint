using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject vehicle;
    public GameObject vehicleCamera; 
    public bool isPlayerEnter;
    [SerializeField] public Transform []spawnPos; 
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
            vehicleCamera.gameObject.GetComponent<Camera>().enabled = true; 
            vehicle.gameObject.GetComponent<CarController>().enabled = true;
            return; 
        }
        else if(Input.GetKeyDown(KeyCode.F) && Input.GetKey(KeyCode.RightArrow) && isPlayerEnter == false)
        {
            player.gameObject.SetActive(true);
            player.transform.position = spawnPos[0].transform.position;
            vehicleCamera.gameObject.GetComponent<Camera>().enabled = false;
            vehicle.gameObject.GetComponent<CarController>().enabled = false;
            return; 
        }
        else if (Input.GetKeyDown(KeyCode.F) && Input.GetKey(KeyCode.LeftArrow) && isPlayerEnter == false)
        {
            player.gameObject.SetActive(true);
            player.transform.position = spawnPos[1].transform.position;
            vehicleCamera.gameObject.GetComponent<Camera>().enabled = false;
            vehicle.gameObject.GetComponent<CarController>().enabled = false;
            return;
        }
        else if (Input.GetKeyDown(KeyCode.F) && Input.GetKey(KeyCode.DownArrow) && isPlayerEnter == false)
        {
            player.gameObject.SetActive(true);
            player.transform.position = spawnPos[2].transform.position;
            vehicleCamera.gameObject.GetComponent<Camera>().enabled = false;
            vehicle.gameObject.GetComponent<CarController>().enabled = false;
            return;
        }
        else if (Input.GetKeyDown(KeyCode.F) && Input.GetKey(KeyCode.UpArrow) && isPlayerEnter == false)
        {
            player.gameObject.SetActive(true);
            player.transform.position = spawnPos[3].transform.position;
            vehicleCamera.gameObject.GetComponent<Camera>().enabled = false;
            vehicle.gameObject.GetComponent<CarController>().enabled = false;
            return;
        }
    }
}
