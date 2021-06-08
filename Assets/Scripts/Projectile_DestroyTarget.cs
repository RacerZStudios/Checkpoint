using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_DestroyTarget : MonoBehaviour
{
    [SerializeField] public GameObject []flagShield;
    public bool turret1Gone, turret2Gone, turret3Gone; 
    private void OnCollisionEnter(Collision collision)
    {
      if(collision.gameObject.tag == "Projectile" && gameObject.name == "Turret_Gun")
        {
            turret1Gone = true;
            gameObject.Equals(null);  
            Destroy(gameObject); 
        }
        else if (collision.gameObject.tag == "Projectile" && gameObject.name == "Turret_Gun_02")
        {
            turret2Gone = true;
            gameObject.Equals(null);
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Projectile" && gameObject.name == "Turret_Gun_03")
        {
            turret3Gone = true;
            gameObject.Equals(null);
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if(turret1Gone == true)
        {
            if (gameObject.Equals(null) || !gameObject.activeInHierarchy)
            {
                Destroy(flagShield[0]);
                flagShield[0].gameObject.SetActive(false);
            }
        }
        else if (turret2Gone == true && turret3Gone == true)
        {
            if (gameObject.Equals(null) || !gameObject.activeInHierarchy)
            {
                Destroy(flagShield[1]);
                flagShield[1].gameObject.SetActive(false);
            }
        }

        turret1Gone = false;
        turret2Gone = false;
        turret3Gone = false;
    }
}
