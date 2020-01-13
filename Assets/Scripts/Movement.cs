using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.iOS;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 400f;
    public float sidewaysForce = 200f;
    public float jumpForce = 50f;
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce * Time.deltaTime);

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKeyDown("space"))
        {
            if(transform.position.y <= 1.01f)
            {
                rb.AddForce(0,jumpForce * Time.deltaTime,0,ForceMode.VelocityChange);
            }
        }
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
