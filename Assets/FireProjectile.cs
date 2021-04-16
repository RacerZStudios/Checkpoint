using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MonoBehaviour
{
    public Transform projectileTransformPos; 
    public GameObject projectilePrefab; 

    public void FireTheProjectile()
    {
        Instantiate(projectilePrefab, projectileTransformPos.transform.position, Quaternion.identity);
    }

    private void Update()
    {
        if(Input.GetButtonDown("Fire"))
        {
            FireTheProjectile(); 
        }
    }
}
