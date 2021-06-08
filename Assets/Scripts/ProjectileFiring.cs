using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileFiring : MonoBehaviour
{
    private Rigidbody rb;
    public float projectileSpeed;
    [SerializeField] public FireProjectile fP;

    private void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    private void FixedUpdate()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            rb.AddForce(transform.forward * projectileSpeed * Time.deltaTime);         
        }

        fP.isFiring = false; 
    }
}
