using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public Transform player;
    public float cameraPos;

    private void FixedUpdate()
    {
        if (player == null) return;

        if(player != null)
        {
            Vector3 pos = player.position;
            transform.position = new Vector3(player.position.x, player.position.y + cameraPos, player.position.z);
        }
    }
}