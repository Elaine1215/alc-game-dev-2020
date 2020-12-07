using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraRotation : MonoBehaviour
{
    //sets the speed of the rotation
    public float rotSpeed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        //allows camera to rotate around the center point of the map
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * rotSpeed * Time.deltaTime);
    }
}
