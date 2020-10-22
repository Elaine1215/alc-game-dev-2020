using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //set what player is
    public GameObject Player;

    //adds angle to camera
    public Vector3 offset = new Vector3(40,10,15);

    // Update is called once per frame
    void Update()
    {
        //makes camera follow player
        transform.position = Player.transform.position + offset;
    }
}
