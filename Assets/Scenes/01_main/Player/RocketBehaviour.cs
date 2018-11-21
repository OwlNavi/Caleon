using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketBehaviour : MonoBehaviour {
    public int rocketDamage = 1;
	// Use this for initialization
	void Start () {
        Debug.Log("RocketBehaviour Loaded");
	}
	
	// Update is called once per frame
	void Update () {
        
    }
    /*
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "EnemyPillar")
        {
            Debug.Log("Rocket triggered with Enemy");
            other.gameObject.GetComponent<EnemyBehaviour>().GetHit(rocketDamage);
        }
        Debug.Log("Rocket triggered with Enemy and was destroyed");

        Destroy(this);
    }
    */
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Rocket collided with : " + col.collider.name);

        if (col.gameObject.name == "EnemyPillar")
        {
            Debug.Log("Rocket collided with Enemy and was destroyed");
            col.gameObject.GetComponent<EnemyBehaviour>().GetHit(rocketDamage);
        }
        Destroy(this);

    }

    //If your GameObject keeps colliding with another GameObject with a Collider, do something
    void OnCollisionStay(Collision collision)
    {
        Debug.Log(collision.collider.name);
        //Check to see if the Collider's name is "Chest"
        if (collision.collider.name == "EnemyPillar")
        {
            //Output the message
            Debug.Log("Enemy pillar collide stay");
        }
    }
}
