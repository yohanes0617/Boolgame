using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class KillBool : MonoBehaviour {
    public GameObject Player;
    public Text GameOver;
    public Text Retry;
    private bool ret;
	// Use this for initialization
	void Start () {
        GameOver.gameObject.SetActive(false);
        Retry.gameObject.SetActive(false);
        ret = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (ret == true)
        {
            if (Input.GetKey(KeyCode.R))
            {
                SceneManager.LoadScene("bool");
            }
        }
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Kill")
        {
            Destroy(Player);
            ret = true;
            GameOver.gameObject.SetActive(true);
            Retry.gameObject.SetActive(true);
        }
    }
}
