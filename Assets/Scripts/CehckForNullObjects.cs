using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CehckForNullObjects : MonoBehaviour
{
    [SerializeField] public Projectile_DestroyTarget []pT;
    [SerializeField] public GameObject []flagShield; 

    private void Update()
    {
        if (pT[0] == null || pT[0].turret1Gone == true)
        {
            flagShield[0].gameObject.SetActive(false);
        }
        if (pT[1] == null || pT[1].turret2Gone == true && pT[2] == null || pT[2].turret3Gone == true)
        {
            flagShield[1].gameObject.SetActive(false);
        }
    }
}
