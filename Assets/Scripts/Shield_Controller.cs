using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield_Controller : MonoBehaviour
{
    public GameObject shieldObj;
    public GameObject player;
    public Quaternion PlayerRot; 

    private void Update()
    {
        if(Input.GetKey(KeyCode.E))
        {
            player.gameObject.transform.rotation = PlayerRot; 
            shieldObj.gameObject.SetActive(true); 
        }
        else if(!Input.GetKey(KeyCode.E))
        {
            shieldObj.gameObject.SetActive(false);
        }
    }
}