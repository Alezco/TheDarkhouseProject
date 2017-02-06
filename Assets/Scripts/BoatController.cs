﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour {
    public float sensitivityX;
    public float speedX;
    public float speedY;

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(0, horizontal * speedX, 0);
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(0, 0, vertical * speedY);
        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(0, mouseX * sensitivityX, 0);
    }
}
