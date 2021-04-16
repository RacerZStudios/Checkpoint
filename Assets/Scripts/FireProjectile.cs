using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MonoBehaviour
{
    public Transform projectileTransformPos; 
    public GameObject projectilePrefab;
    public bool isFiring; 

    public void FireTheProjectile()
    {
        if (isFiring == true)
        {
            Instantiate(projectilePrefab, projectileTransformPos.transform.position, Quaternion.identity);
        }
    }

    private void Update()
    {
        if(Input.GetButtonUp("Fire1"))
        {
            isFiring = true;
            FireTheProjectile(); 
        }
    }
}
