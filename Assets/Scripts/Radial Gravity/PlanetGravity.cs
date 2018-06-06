using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGravity : MonoBehaviour {

    public float gravity = -10;

	public void Attract(Transform playertransform)
    {
        Vector3 gravityDir = (playertransform.position - transform.position).normalized;
        Vector3 playerUp = playertransform.up;

        //pull to planet force cased by gravity 
        playertransform.GetComponent<Rigidbody>().AddForce(gravityDir * gravity);

        //orbital motion 
        Quaternion targetRotation = Quaternion.FromToRotation(playerUp, gravityDir) * playertransform.rotation;
        playertransform.rotation = Quaternion.Slerp(playertransform.rotation, targetRotation, 50f * Time.deltaTime);

    }
}
