using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Projectilemotion : MonoBehaviour {

   
    Rigidbody projectile;
    Transform myTransform;

    public GameObject B1;
    public GameObject B2;

    public float angle = 45.0f;
    public float g = 10f;
    public float v0 = 15;
    float vX0, vY0,y1,y2,t1,t2;

   public float deltaTime;
    public Text dtText;

    void Awake()
    {
        myTransform = transform;
    }

    void Start()
    {
        projectile = GetComponent<Rigidbody>();
        Projectile();


    }

    void Projectile()
    {
            projectile.transform.position = myTransform.position ;
            vX0 = v0 * Mathf.Cos(angle * Mathf.Deg2Rad);
            vY0 = v0 * Mathf.Sin(angle * Mathf.Deg2Rad);
            projectile.velocity = new Vector3(0, vY0, vX0);
        
    } 

    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag=="B1")
        {
          //  Debug.Log("in");
            y1 = transform.position.y;
           Debug.Log("y1=" + y1);
            t1 = (vY0 - Mathf.Sqrt((vY0*vY0)-(2* g* y1))) / g;
            Debug.Log("t1=" + t1);

        }
        if (other.gameObject.tag == "B2")
        {
            y2 = transform.position.y;
            Debug.Log("y2=" + y2);
            t2 = (vY0 - Mathf.Sqrt((vY0 * vY0) - (2 * g * y2))) / g;
            Debug.Log("t2=" + t2);
            deltaTime = t2 - t1;
            Debug.Log("Delta Time=" + deltaTime);
            dtText.text = "Delta Time=" + deltaTime.ToString();
        }


      

    }
}
