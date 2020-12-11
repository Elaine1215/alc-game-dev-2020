using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    private float spawnRangeX = 8.0f;
    private float startSpawnPosZ = -50.0f;
    private float endSpawnPosz = 300.0f;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomObjects", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {


    }
    void SpawnRandomObjects()
    {
        Vector3 spawnPosZ = new Vector3(startSpawnPosZ, endSpawnPosz);
        //Randomly generate animalIndex and spawnPos
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        int objectIndex = Random.Range(0, objectPrefabs.Length);

        Instantiate(objectPrefabs[objectIndex], spawnPos, objectPrefabs[objectIndex].transform.rotation);

    }
}
