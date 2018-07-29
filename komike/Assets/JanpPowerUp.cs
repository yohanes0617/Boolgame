using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JanpPowerUp : MonoBehaviour {
    public BoolJanp BJ;
    public float JanpUp;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            BJ.JanpPower += JanpUp;
            Destroy(gameObject);
        }
                
    }


}
