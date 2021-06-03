using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global_Input_Commands : MonoBehaviour
{
    [SerializeField] public GameObject WASDTextObject;
    [SerializeField] public GameObject FToDriveTextObject;
    [SerializeField] public DriveTrigger player; 

    public InputCommand inputCommand = InputCommand.Begin; 
    public enum InputCommand
    {
        Begin
    }

    public bool w, a, s, d, f; 
    void Update()
    {
        if (gameObject != null)
        {
            if (inputCommand == InputCommand.Begin)
            {
                if (Input.GetKeyDown(KeyCode.W))
                {
                    w = true;
                }
                else if (Input.GetKeyDown(KeyCode.A))
                {
                    a = true;
                }
                if (Input.GetKeyDown(KeyCode.S))
                {
                    s = true;
                }
                if (Input.GetKeyDown(KeyCode.D))
                {
                    d = true;
                }
                if (Input.GetKeyDown(KeyCode.F) && player.isPlayerEnter == true)
                {
                    f = true;
                }
            }
        }

        if (w.Equals(true) && a.Equals(true) && s.Equals(true) && d.Equals(true))
        StartCoroutine(DestroyWASDText());

        if (f.Equals(true))
        StartCoroutine(DestroyFToDriveText()); 
    }

    IEnumerator DestroyWASDText()
    {
        float time = 5;
        time-= Time.time;
        Debug.Log(time); 
        if(time <= 0)
        {
            time = 0;
            w = false; a = false; s = false; d = false; 
            Destroy(WASDTextObject);
        }

        time = 0; 
        yield return null; 
    }

    IEnumerator DestroyFToDriveText()
    {
        float time = 5;
        time -= Time.time;
        Debug.Log(time);
        if (time <= 0)
        {
            time = 0;
            f = false; 
            Destroy(FToDriveTextObject);
        }

        time = 0;
        yield return null;
    }
}