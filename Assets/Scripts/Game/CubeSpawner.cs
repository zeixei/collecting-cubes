using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{

   

    ObjectPooler objectPooler;

    private void Start()
    {

        objectPooler = ObjectPooler.Instance;
    }
   
    void FixedUpdate()
    {
        Vector3 spawnPosition = new Vector3(transform.position.x, 0f, transform.position.z);

        objectPooler.SpawnFromPool("Cube", spawnPosition, Quaternion.identity);
    }
}
