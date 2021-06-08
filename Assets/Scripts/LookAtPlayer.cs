using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public Transform player;

    private void Update()
    {
        if (player == null) return; 
        transform.position = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z); 
    }
}
