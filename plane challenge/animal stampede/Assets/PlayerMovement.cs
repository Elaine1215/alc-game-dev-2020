using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //sets player speed
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
        
        //moves player forward and backward
        Transform.Translate(Vector3.forward, speed * verticalInput * Time.deltaTime);
        
        //makes player turn left and right
        Transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
