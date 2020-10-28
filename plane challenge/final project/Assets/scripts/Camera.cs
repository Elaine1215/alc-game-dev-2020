using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    //set player object
    public GameObject Player;

    //set offset
    public Vector3 offset = new Vector3(0, 7, 13);

    // Update is called once per frame
    void Update()
    {
        //makes camera follow
        transform.position = Player.transform.position + offset;
    }
}
