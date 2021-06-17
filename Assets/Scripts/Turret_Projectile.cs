using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret_Projectile : MonoBehaviour
{
    private Rigidbody rb;
    public float projectileSpeed = 5;
    public float range = 5;
    public bool isInRange;
    [SerializeField] public GameObject player; 

    private void Start()
    {
        if(player != null)
        {
            player = GetComponent<GameObject>();
        }
        else if(player == null)
        {
            Debug.LogError("No PlayerController" 
            + "has been assigned in the inspector"); 
        }
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (isInRange == true)
        {
            rb.AddForce(-Vector3.forward * projectileSpeed * 500 * Time.deltaTime);
        }

        Destroy(gameObject, 2); 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "PlayerController")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject); 
            if(player == null)
            {
                return; 
            }
            Debug.Log(player);
        }
    }
}
