using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public Rigidbody rB;
    [SerializeField] public GameObject player;
    [SerializeField] private VehicleController vehicleController;

    public float velocity;
    public float rotateSpeed;
    Vector3 dir;

    private void Start()
    {
        velocity = 750;
        rotateSpeed = 1250;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            dir = player.transform.position;
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
        else if (Input.GetKey(KeyCode.A))
        {
            dir = player.transform.position;
            transform.position = dir;
            dir = transform.TransformDirection(Vector3.left * velocity * Time.deltaTime);
            rB.AddForce(dir);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            dir = player.transform.position;
            transform.position = dir;
            transform.TransformDirection(-Vector3.left * velocity * Time.deltaTime);
            rB.AddForce(dir);
            return;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            dir = player.transform.position;
            transform.position = dir;
            transform.TransformDirection(-Vector3.back * velocity * Time.deltaTime);
            rB.AddForce(-dir);
            return;
        }
    }
}