using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolJanp : MonoBehaviour {
    public float JanpPower;
    public Rigidbody rb;
    private bool IsGround;
    
	
	// Update is called once per frame
	void Update ()
    {
        if (IsGround == true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                var Janp = new Vector3(0, 1, 0);
                rb.AddForce(Janp * JanpPower);
                IsGround = false;
            }
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        IsGround = true;    
    }

}
