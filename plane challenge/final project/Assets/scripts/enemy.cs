using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    //set distance of player from enemy
    public Vector3 enemyDistance = new Vector3(20, 0, 0);
    //set player
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position + enemyDistance;
    }
}
