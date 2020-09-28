using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    public float RotateAmount = 500f; // degrees per second to rotate in each axis. Set in inspector
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, RotateAmount * Time.deltaTime);
    }
}
