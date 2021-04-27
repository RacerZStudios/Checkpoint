using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CehckForNullObjects : MonoBehaviour
{
    [SerializeField] public Projectile_DestroyTarget pT;
    [SerializeField] public GameObject flagShield; 

    private void Update()
    {
        if(pT == null || pT.turretGone == true)
        {
            flagShield.gameObject.SetActive(false);
            return; 
        }
    }
}
