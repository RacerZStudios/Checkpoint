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
        if(player == null)
        {
            player = GameObject.Find("PlayerController").GetComponent<GameObject>();
        }
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (player != null)
        {
            return; 
        }
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
