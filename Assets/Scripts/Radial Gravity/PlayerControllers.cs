using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllers : MonoBehaviour {

    public float moveSpeed;

    Vector3 movDir;
	

	void Update () {
        movDir = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Jump"), Input.GetAxisRaw("Vertical")).normalized;

	}

     void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.TransformDirection(movDir)*moveSpeed*Time.deltaTime);
    }
}
