using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield_Check : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "TProjectile")
        {
            Destroy(collision.gameObject); 
        }
    }
}
