using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiJanpGround : MonoBehaviour {
    public float HiJanpPower;
    public Rigidbody rb;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "HiJanp")
        {
            var Janp = new Vector3(0, 1, 0);
            rb.AddForce(Janp * HiJanpPower);
        }
    }
}
