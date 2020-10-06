using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogFriend : MonoBehaviour
{
    //sets what object player is
    public GameObject Player;

    //set offset from player
    private Vector3 offset = new Vector3(2, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //makes dog follow player with offset
        transform.position = Player.transform.position + offset;
    }
}
