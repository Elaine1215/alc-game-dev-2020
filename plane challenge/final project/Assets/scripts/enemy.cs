using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    //set distance of player from enemy
    public Vector3 enemyDistance = new Vector3(0, 5, -20);
    //set player
    public GameObject Player;
    private float speed = 20.0f;

    public float zRange = 290;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //keeps enemy from running off map
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
        //makes enemy follow player
        //transform.position = Player.transform.position + enemyDistance;

        //makes enemy move at a constant speed
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

}
