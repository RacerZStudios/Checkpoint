using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Init_Object : MonoBehaviour
{
    [SerializeField] public GameObject turret;
    [SerializeField] public GameObject player; 

    private void Start()
    {
        Instantiate(turret.gameObject, transform.position, Quaternion.identity);
        Instantiate(player.gameObject, transform.position, Quaternion.identity);
    }
}
