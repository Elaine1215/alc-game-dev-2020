using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //sets speed
    private float speed = 20.0f;

    private float horizontalInput;
    private float verticalInput;

    //jumping
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityMod;
    public bool isOnGround = true;

    private void Start()
    {
        //initialize component and add rigidbody
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityMod;
    }
    // Update is called once per frame
    void Update()
    {
        //gets the needed directions
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //moves player forward and backward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * horizontalInput);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}
