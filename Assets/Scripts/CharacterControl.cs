using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterControl : MonoBehaviour
{
    [SerializeField] private CharacterController characterController;
    public float turnSpeed;
    public float moveSpeed;
    public float jump;
    public float gravity = -9.18f; 
    private Vector3 pos = Vector3.zero;
    private Vector3 movePos; 
    public bool isGrounded; 

    private void Start()
    {
        if(characterController == null)
        {
            return; 
        }
    }

    private void Update()
    {
        isGrounded = characterController.isGrounded;
        if(pos.y < 0 && isGrounded)
        {
            pos.y = 0f; 
        }

        movePos = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        characterController.Move(movePos * Time.deltaTime * moveSpeed); 

        if(movePos != Vector3.zero)
        {
            transform.forward = movePos; 
        }

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            pos.y += Mathf.Sqrt(jump * -2.5f * gravity); 
        }

        pos.y += gravity * Time.deltaTime;
        characterController.Move(pos * Time.deltaTime); 
    }
}