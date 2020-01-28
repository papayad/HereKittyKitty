using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pspsps : MonoBehaviour
{

    public Rigidbody2D catRB;
    public float thrust;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {

            PspRight();
        }

        if (Input.GetAxis("Horizontal") < 0)
        {

            PspsLeft();
        }
    }

    void PspRight ()
    {
        
        catRB.AddForce(transform.right * thrust);
        Debug.Log("psps");
    }

    void PspsLeft()
    {

        catRB.AddForce(-transform.right * thrust);
        Debug.Log("psps");
    }

}
