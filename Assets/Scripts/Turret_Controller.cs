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
    [SerializeField] Turret_Projectile tP;

    private void Start()
    {
        turretTranform = turretTranform.transform;
        vehicle = vehicle.transform.gameObject;
        player = player.transform.gameObject;

        while (player != null)
        {
            if (tP.isInRange == true)
            {
                StartCoroutine(FireAtTarget()); // fires once because on Start 
            }
            break;
        }
    }

    private void Update()
    {
        if (Vector3.Distance(player.transform.position, vehicle.transform.position) >= 2)
        {
            turretTranform.LookAt(vehicle.transform.position);
            tP.isInRange = true;
        }
        else
        {
            turretTranform.transform.position = new Vector3(0, 0.008475996f, 0);
            return;
        }

        if (tP.isInRange == true)
        {
            StartCoroutine(FireAtTarget()); 
        }
    }

    private IEnumerator FireAtTarget()
    {
        if (Vector3.Distance(player.transform.position, transform.position) >= tP.range)
        {
            tP.isInRange = true;
            yield return new WaitForSeconds(2); 
            Instantiate(proj, projSpawn.transform.position, projSpawn.transform.rotation);
            proj.transform.LookAt(player.transform);
            proj.transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 4); 
        }
        else if (Vector3.Distance(player.transform.position, transform.position) < tP.range)
        {
            tP.isInRange = false;
            proj.gameObject.SetActive(false); 
            yield return null;
        }
    }
}