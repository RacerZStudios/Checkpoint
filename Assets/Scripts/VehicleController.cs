using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour
{
    [SerializeField] public GameObject vehicle;
    [SerializeField] public Rigidbody rB;
    [SerializeField] private CharacterControl playerController;
    public float velocity;
    public float rotateSpeed; 
    Vector3 dir; 

    private void Start()
    {
        velocity = 1500;
        rotateSpeed = 4500; 
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            dir = vehicle.transform.position;
            transform.position = dir;
            transform.TransformDirection(Vector3.forward * velocity * Time.deltaTime);
            rB.AddForce(dir); 
            return; 
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rB.AddTorque(Vector3.up * rotateSpeed / 2 * Time.deltaTime); 
            return;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rB.AddTorque(-Vector3.up * rotateSpeed / 2 * Time.deltaTime);
            return;
        }
        else if(Input.GetKey(KeyCode.A))
        {
            dir = vehicle.transform.position;
            transform.position = dir;
            dir = transform.TransformDirection(Vector3.left * velocity * Time.deltaTime);
            rB.AddForce(dir);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            dir = vehicle.transform.position;
            transform.position = dir;
            transform.TransformDirection(-Vector3.left * velocity * Time.deltaTime);
            rB.AddForce(dir);
            return;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            dir = vehicle.transform.position;
            transform.position = dir;
            transform.TransformDirection(-Vector3.back * velocity * Time.deltaTime);
            rB.AddForce(-dir);
            return;
        }
    }

}
