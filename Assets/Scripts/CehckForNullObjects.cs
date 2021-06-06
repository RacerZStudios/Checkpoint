using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CehckForNullObjects : MonoBehaviour
{
    [SerializeField] public Projectile_DestroyTarget []pT;
    [SerializeField] public GameObject []flagShield; 

    private void Update()
    {
        if(pT[0] == null || pT[0].turretGone == true)
        {
            flagShield[0].gameObject.SetActive(false);
            return; 
        }
    }
}
