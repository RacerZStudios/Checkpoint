using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret_Projectile : MonoBehaviour
{
    private Rigidbody rb;
    public float projectileSpeed;
    public float range = 5;
    public bool isInRange;
    [SerializeField] public Turret_Controller tC; 

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if(isInRange == true && range < 5)
        {
            rb.AddForce(transform.forward * projectileSpeed * Time.deltaTime);
        }
    }
}
