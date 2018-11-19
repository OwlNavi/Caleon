using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed = 10;
    public float rotateSpeed = 10;
    public Camera viewCamera;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        /*
         * -                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;
        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
        */

        Vector3 moveInput = new Vector3(Input.GetAxisRaw("LeftHorizontal"), 0, Input.GetAxis("LeftVertical"));
        Vector3 moveVelocity = moveInput.normalized * moveSpeed * Time.deltaTime;
        transform.Translate(moveVelocity);
        transform.Rotate(0, Input.GetAxis("RightHorizontal"), 0);
       
    }
}
