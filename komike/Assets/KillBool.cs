﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBool : MonoBehaviour {
    public GameObject Player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(Player);
        }
    }
}
