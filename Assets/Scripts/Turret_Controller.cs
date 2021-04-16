using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret_Controller : MonoBehaviour
{
    public Transform turretTranform;
    public GameObject vehicle;
    public GameObject player;

    private void Start()
    {
        turretTranform = turretTranform.transform;
        vehicle = vehicle.transform.gameObject;
        player = player.transform.gameObject; 
    }

    private void Update()
    {
        if(Vector3.Distance(player.transform.position, vehicle.transform.position) >= 2)
        {
              turretTranform.LookAt(vehicle.transform.position);
        }
        else
        {
            turretTranform.transform.position = new Vector3(0, 0.008475996f, 0);
        }
    }
}
