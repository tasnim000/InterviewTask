using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGravityBody : MonoBehaviour {

    public PlanetGravity planetGravity;
    Transform playerTransform;

	
	void Start ()
    {

        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        playerTransform = transform;

	}
	

	void FixedUpdate ()
    {
        if (planetGravity)
        {
            planetGravity.Attract(playerTransform);
        }
		
	}
}
