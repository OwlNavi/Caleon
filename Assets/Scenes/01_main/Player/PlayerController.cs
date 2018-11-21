using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed = 10;
    public float rotateSpeed = 10;
    public Camera viewCamera;
    public Transform sword;
    public Transform rocket;
    public float rocketSpeed = 30f;

    
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


        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Fire1");
        }

        if (Input.GetButtonDown("Fire2"))
        {
            Instantiate(sword, transform.position, Quaternion.identity);
        }
        if (Input.GetButtonDown("Fire3"))
        {
            Debug.Log("Fire3");
        }
        if (Input.GetButtonDown("Jump"))
        {
            FireRocket();
        }
    }

    void FireRocket()
    {
        Vector3 fp = new Vector3(transform.position.x, transform.position.y+0.5f, transform.position.z);
        Transform rocketClone = (Transform)Instantiate(rocket, fp, Quaternion.identity);

        Rigidbody rb = rocketClone.GetComponent<Rigidbody>();

        rb.velocity = transform.forward * rocketSpeed;

        // You can also access other components / scripts of the clone
        //rocketClone.GetComponent<RocketBehaviour>().init();
    }
}
