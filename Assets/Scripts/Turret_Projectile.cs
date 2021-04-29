using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret_Projectile : MonoBehaviour
{
    private Rigidbody rb;
    public float projectileSpeed = 5;
    public float range = 5;
    public bool isInRange;

    private void Start()
    {
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
}
