using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Targets : MonoBehaviour
{
    private Rigidbody targetRb;
    private float minSpeed = 12;
    private float maxSpeed = 16;
    private float maxTorque = 10;
    private float xRange = 4;
    private float ySpawnPos = -6;
    //pulls text from other script
    private GameManager gameManager;
    public int pointValue;
    //adds particle effects
    public ParticleSystem explosionParticle;

    // Start is called before the first frame update
    void Start()
    {
        //throw targets in air
        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        transform.position = new Vector3(Random.Range(-4, 4), -6);
        //pulls code from other script
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }
    //makes how hard the targets are thrown random
    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }
    float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }
    //makes spawn position of targets random
    Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (gameManager.isGameActive)
        {
            //destroys target when you click on it
            Destroy(gameObject);
            //plays particles
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
            //gives points when you click target
            gameManager.UpdateScore(pointValue);
        }
    }
    //ends game when bad object gets hit
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if (!gameObject.CompareTag("Bad"))
        {
            gameManager.GameOver();
        }
    }
}
