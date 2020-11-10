using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityMod;
    public bool isOnGround = true;
    public bool gameOver = false;
    //allows access to animations
    private Animator playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        //initialize component and add rigidbody
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityMod;
        //initialize animation
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            //makes player jump and keeps from double jumping
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            //pulls down jumping animation
            playerAnim.SetTrigger("Jump_trig");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
       

        if(collision.gameObject.CompareTag("Ground"))
        {
            //allows jumping only if on the ground
            isOnGround = true;
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            //ends game
            gameOver = true;
            Debug.Log("Game Over!");
        }
    }
}
