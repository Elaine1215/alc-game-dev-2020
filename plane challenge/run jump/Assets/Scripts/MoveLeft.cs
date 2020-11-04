using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    //speed of object
    public float speed = 10;

    // Update is called once per frame
    void Update()
    {
        //moves game object left at set speed
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
