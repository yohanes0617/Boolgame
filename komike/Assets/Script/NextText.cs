using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NextText : MonoBehaviour
{
    public Text tex1;
    public Text PowerUp;
    public Text Denger;
    private void Start()
    {
        PowerUp.gameObject.SetActive(false);
        Denger.gameObject.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "NextText")
        {
            Denger.gameObject.SetActive(true);
            PowerUp.gameObject.SetActive(true);
            tex1.gameObject.SetActive(false);
        }
    }
}