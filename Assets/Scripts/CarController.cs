using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Rigidbody rB;
    public Camera camera;
    public Transform cameraTransform;
    [SerializeField] public ParticleSystem rightRearParticleSystem;
    [SerializeField] public ParticleSystem leftRearParticleSystem;
    [SerializeField] public ParticleSystem rightParticleSystem;
    [SerializeField] public ParticleSystem leftParticleSystem;

    private void FixedUpdate()
    {
        camera.transform.LookAt(cameraTransform.position);
        camera.transform.position = cameraTransform.position;
        if (Input.GetKey(KeyCode.W))
        {
            rB.AddForce(Vector3.forward * 4500 * Time.deltaTime);
            rightRearParticleSystem.Play(); 
            rightRearParticleSystem.Emit(15);
            leftRearParticleSystem.Play(); 
            leftRearParticleSystem.Emit(15); 
            return;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rB.AddForce(-Vector3.forward * 4500 * Time.deltaTime);
            return;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rB.AddForce(Vector3.left * 4500 * Time.deltaTime);
            rightParticleSystem.Play(); 
            rightParticleSystem.Emit(15); 

            return;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rB.AddForce(Vector3.right * 4500 * Time.deltaTime);
            leftParticleSystem.Play(); 
            leftParticleSystem.Emit(15); 
            return;
        }
        else
        {
            Vector3.Normalize(transform.position);
            rightRearParticleSystem.Emit(0);
            rightRearParticleSystem.Stop(); 
            leftRearParticleSystem.Emit(0);
            leftRearParticleSystem.Stop(); 
            rightParticleSystem.Emit(0);
            rightParticleSystem.Stop(); 
            leftParticleSystem.Emit(0);
            leftParticleSystem.Stop(); 

        }
    }
}