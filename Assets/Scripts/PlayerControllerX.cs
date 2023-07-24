using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = 100;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
       // verticalInput = Input.GetAxis("Vertical");


        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed);

        // tilt the plane up/down based on up/down arrow keys
        //transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime);
        if(Input.GetKey("w"))
        {
            transform.Rotate((-rotationSpeed * Time.deltaTime), 0, 0);
        }

        if(Input.GetKey("s"))
        {
            transform.Rotate((rotationSpeed * Time.deltaTime), 0, 0);
        }
    }
}
