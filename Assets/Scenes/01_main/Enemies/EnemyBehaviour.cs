using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//see https://docs.unity3d.com/Manual/InstantiatingPrefabs.html
public class EnemyBehaviour : MonoBehaviour {

    public int maxHealth = 3;
    private int healthRemaining;
    public int touchDamage = 1;

	// Use this for initialization
	void Start () {
        healthRemaining = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
	    if (healthRemaining <= 0)
        {

            Debug.Log("Destroyed enemy health = 0");
            KillSelf();
        }	
	}
    /*
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerController>.getHit(touchDamage);
        }


    }*/

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Enemy collided with : " + col.collider.name);

        if (col.gameObject.name == "rocketPrefab(Clone)")
        {
            Debug.Log("Rocket collided with Enemy and was destroyed");
            //GetHit(col.gameObject.GetComponent<RocketBehaviour>().rocketDamage);
            GetHit(1);
            Destroy(col.gameObject);

        }

    }

    //hit by a player's bullets
    public void GetHit(int damage)
    {
        Debug.Log("EnemyPillarHit");
        healthRemaining -= damage;
    }

    // Calls the fire method when holding down ctrl or mouse
    void KillSelf()
    {
        // Instantiate the wreck game object at the same position we are at
        //GameObject wreckClone = (GameObject)Instantiate(wreck, transform.position, transform.rotation);

        // Sometimes we need to carry over some variables from this object
        // to the wreck
        //wreckClone.GetComponent<MyScript>().someVariable = GetComponent<MyScript>().someVariable;

        // Kill ourselves
        Destroy(gameObject);
    }

}
