using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject troncoPrefab;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    public float tempoDestroy = 5f;


    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        GameObject troncoSpawnato = Instantiate(troncoPrefab, transform.position, transform.rotation);  //Quaternion.identity
        Destroy(troncoSpawnato, tempoDestroy);
        if(stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
