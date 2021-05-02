using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_DestroyTarget : MonoBehaviour
{
    [SerializeField] public GameObject flagShield;
    public bool turretGone; 
    private void OnCollisionEnter(Collision collision)
    {
      if(collision.gameObject.tag == "Projectile")
        {
            turretGone = true;
            gameObject.Equals(null);  
            Destroy(gameObject); 
        }
    }

    private void Update()
    {
        if(turretGone == true)
        {
            if (gameObject.Equals(null) || !gameObject.activeInHierarchy)
            {
                Destroy(flagShield);
                flagShield.gameObject.SetActive(false);
                return;
            }
        }
        turretGone = false; 
    }
}
