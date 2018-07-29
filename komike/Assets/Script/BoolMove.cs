using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolMove : MonoBehaviour {

    public float speed = 20; // 動く速さ

    public Rigidbody rb; // Rididbody

   

    void Update()
    {
        // カーソルキーの入力を取得
        var moveHorizontal = Input.GetAxis("Horizontal");
        var moveVertical = Input.GetAxis("Vertical");

        // カーソルキーの入力に合わせて移動方向を設定
        var movement = new Vector3(moveHorizontal, 0, moveVertical);

        // Ridigbody に力を与えて玉を動かす
        rb.AddForce(movement * speed);
    }
}
