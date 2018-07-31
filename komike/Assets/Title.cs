using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Title : MonoBehaviour {

	
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.S))
        {
            SceneManager.LoadScene("StageSerect");
        }
        if (Input.GetKey(KeyCode.T))
        {
            SceneManager.LoadScene("bool");
        }
        if (Input.GetKey(KeyCode.E))
        {
            Application.Quit();
        }
    }
}
