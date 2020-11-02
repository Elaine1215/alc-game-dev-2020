using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //sets speed
    private float speed = 20.0f;

    private float horizontalInput;
    private float verticalInput;

    // Update is called once per frame
    void Update()
    {
        //gets the needed directions
        horizontalInput = Input.GetAxis("Horizontal");
        //get keys to make player jump
        verticalInput = Input.GetAxis("");

        //moves player forward and backward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * horizontalInput);
        //make player jump

    }
}
