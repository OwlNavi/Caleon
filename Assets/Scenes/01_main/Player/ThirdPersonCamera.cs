﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour {

    public Transform lookAt;
    public Transform camTransform;

    private Camera cam;
    private const float Y_ANGLE_MIN = 0.0f;
    private const float Y_ANGLE_MAX = 75.0f;
    private float distance = 5.0f;
    private float currentX = 0.0f;
    private float currentY = 0.0f;
    private float sensitivityX = 1.0f;
    private float sensitivityY = 10.0f;

    private void Start()
    {
        camTransform = transform;
        cam = Camera.main;
    }
	
	// Update is called once per frame
	void Update () {
        currentX += Input.GetAxis("RightHorizontal");
        currentY += Input.GetAxis("RightVertical");

        currentY = Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
	}

    private void LateUpdate()
    {
        //calculate posisiton after player moves
        Vector3 dir = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        camTransform.position = lookAt.position + rotation * dir;
        camTransform.LookAt(lookAt.position);
    }
}
