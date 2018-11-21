using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidDelete : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name + " entered the void and was destroyed");
        Destroy(other.gameObject);
    }
}
