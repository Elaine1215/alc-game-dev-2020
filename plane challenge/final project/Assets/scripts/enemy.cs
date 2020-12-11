using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    //set distance of player from enemy
    public Vector3 enemyStartDistance = new Vector3(0, 5, -20);
    //set player
    public GameObject Player;
    private float speed = 20.0f;

    public float zRange = 290;

    public float moveCloser = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //enemyDistance = enemyStartDistance - moveCloser;
        //keeps enemy from running off map
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
        //makes enemy follow player
        //transform.position = Player.transform.position + enemyDistance;

        //makes enemy move at a constant speed
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        //make enemy get closer when player hits an object

    }
    private void OnCollisionEnter(Collision collision)
    {

    }

}
