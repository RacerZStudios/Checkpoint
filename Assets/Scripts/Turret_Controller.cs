using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret_Controller : MonoBehaviour
{
    public Transform turretTranform;
    public GameObject vehicle;
    public GameObject player;
    public Transform projSpawn;
    public GameObject proj;
    public float distanceFromPlayer;
    public float coolDown;
    private const int spawnDist = 5; 
    [SerializeField] Turret_Projectile tP;

    private void Awake()
    {
        if (player != null)
        {
            player = GameObject.Find("PlayerController");
        }
    }

    private void Start()
    {
        turretTranform = turretTranform.transform;
        vehicle = vehicle.transform.gameObject;
        player = player.transform.gameObject;

        coolDown = 5;
    }

    private void Update()
    {
        coolDown -= Time.deltaTime;
        if (player != null)
        {
            distanceFromPlayer = Vector3.Distance(player.transform.position, turretTranform.gameObject.transform.position); 
            if(distanceFromPlayer <= 25)
            {
                StartCoroutine(FireAtTarget()); 
            }
            return; 
        }

        if(player == null)
        {
            StopCoroutine(FireAtTarget());
            return; 
        }
    }

    private IEnumerator FireAtTarget()
    {
        turretTranform.LookAt(player.transform.position);
        if(coolDown <= 0 && distanceFromPlayer <= 25)
        {
            proj.SetActive(true); 
            tP.isInRange = true;
            yield return new WaitForSeconds(5);
            if(proj != null)
            {
                Instantiate(proj, proj.transform.position + spawnDist * proj.transform.forward, proj.transform.rotation);
                proj.transform.LookAt(player.transform);
                proj.transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 4);
            }
           
            coolDown = 5;
        }

        if(coolDown < 0)
        {
            coolDown = 5;
        }
    }
 }