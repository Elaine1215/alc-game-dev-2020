using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);

    //pulls script information into this script
    private PlayerController playerControllerScript;

    private float startDelay = 2;
    private float repeatDelay = 2;

    // Start is called before the first frame update
    void Start()
    {
        //spawns object repeatedly
        InvokeRepeating("SpawnObstacle", startDelay, repeatDelay);
        //gets the objects and script information called
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    void SpawnObstacle()
    {
        //stop obstacles spawning after game ends
        if(playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
        
    }

}
