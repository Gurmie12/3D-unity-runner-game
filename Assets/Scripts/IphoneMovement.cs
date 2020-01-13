using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IphoneMovement : MonoBehaviour
{
    
    public float sideWaysSpeed = 100f;
    public Rigidbody player;
    private float screenWidth;

    void Start()
    {
        screenWidth = Screen.width;
    }
    void FixedUpdate()
    {
        int i = 0;
        while(i >= 0)
        {
        if(Input.GetTouch(i).position.x < screenWidth/2)
        {
                MoveSidewaysLeft(sideWaysSpeed);
        }
        if(Input.GetTouch(i).position.x > screenWidth/2)
        {
                MoveSidewaysRight(sideWaysSpeed);
        }
        i++;
        }
    }

    private void MoveSidewaysRight(float speed)
    {
        player.AddForce(speed*Time.deltaTime,0,0,ForceMode.VelocityChange);
    }

    private void MoveSidewaysLeft(float speed)
    {
        player.AddForce(-speed*Time.deltaTime,0,0,ForceMode.VelocityChange);
    }
}
