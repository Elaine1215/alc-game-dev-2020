using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 30.0f;
    public float xRange = 15.0f;
    public GameObject projectileApple;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //collect input data
        horizontalInput = Input.GetAxis("Horizontal");

        //moves player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //keeps player in left and right bounds
        //left
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //right
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);

        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Launch Apple From Player
            Instantiate(projectileApple,transform.position,projectileApple.transform.rotation);
        }
    }
}
