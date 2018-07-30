using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class JanpPowerUp : MonoBehaviour {
    public BoolJanp BJ;
    public float JanpUp;



    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "JanpUp")
        {
            BJ.JanpPower += JanpUp;
          
        }
                
    }


}
