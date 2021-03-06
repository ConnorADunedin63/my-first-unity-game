﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce;
    public float sidewaysForce;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.Acceleration);

        if(Input.GetKey(KeyCode.LeftArrow)) {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey(KeyCode.RightArrow)) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        // transform refers to the player's position. We can reference it like this because this script is linked to the player
        if (transform.position.y < -1)
        {
            // Restart the game
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
