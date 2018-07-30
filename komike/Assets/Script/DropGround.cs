using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropGround : MonoBehaviour
{

        //　床が落下するまでの時間
        [SerializeField]
        private float timeToFall = 5f;
        //　主人公が床に乗っていたトータル時間
        private float totalTime = 0f;
        private Rigidbody rigid;
    
        void Start()
        {
          
            rigid = GetComponent<Rigidbody>();
            rigid.isKinematic = true;

    }

    void Update()
        {
            //　床が落下する時間を超えたらリジッドボディのisKinematicをfalseに
            //　isKinematicをfalseにしたことで重力が働く
            if (totalTime > timeToFall)
            {
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            rigid.isKinematic = false;
            }
        }



    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Kill")
            {
                Destroy(this.gameObject);
            }
    
       

    }
    private void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
        
            totalTime += 1;
        }
    }
    }

