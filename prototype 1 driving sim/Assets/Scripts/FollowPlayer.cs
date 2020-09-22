using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //sets what object the player is
    public GameObject Player;
    
    //sets the offset of the camera from the player
    private Vector3 offset = new Vector3(0, 7, -13);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //makes camera follow player with an offset
        transform.position = Player.transform.position + offset;
    }
}
