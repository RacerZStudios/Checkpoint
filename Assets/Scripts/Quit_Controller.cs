using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Quit_Controller : MonoBehaviour
{
    private void Update()
    {
        Quit(); 
    }
    private void Quit()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene(0); 
        }
    }
}
