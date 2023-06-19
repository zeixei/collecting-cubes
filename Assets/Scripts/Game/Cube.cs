using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour, IPooledObject
{
    
    public float sideForce = .1f;
    public void OnObjectSpawn()
    {
        float xForce = Random.Range(-sideForce, sideForce);
       
        float zForce = Random.Range(-sideForce, sideForce);

        Vector3 force = new Vector3(xForce, 0, zForce);

        GetComponent<Rigidbody>().velocity = force;
    }


}
