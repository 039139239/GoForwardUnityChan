using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // キューブの移動速度
    private float speed = -12;

    // 消滅位置
    private float deadLine = -10;

   

    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }

        
    }

    //OnCollisionEnter()
    void OnCollisionEnter2D(Collision2D collision)
    {
        //CubePrefabが衝突したオブジェクトがgroundだった場合
        if (collision.gameObject.name == "ground")
        {
            GetComponent<AudioSource>().Play();
        }

        //CubePrefabが衝突したオブジェクトがCubePrefabだった場合
        if (collision.gameObject.name == "CubePrefab(Clone)")
        {
            GetComponent<AudioSource>().Play();
        }

    }


}
