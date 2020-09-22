using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    //sets the speed of the car
    private float speed = 20;
    private float turnSpeed = 50;
    
    private float horizontalInput;
    private float verticalInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        // moves the vehicle forward and backward based on verticalInput
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        
        //rotates the car left and right using horizontalInput
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
