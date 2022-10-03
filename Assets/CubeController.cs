using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // �L���[�u�̈ړ����x
    private float speed = -12;

    // ���ňʒu
    private float deadLine = -10;

   

    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // �L���[�u���ړ�������
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // ��ʊO�ɏo����j������
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }

        
    }

    //OnCollisionEnter()
    void OnCollisionEnter2D(Collision2D collision)
    {
        //CubePrefab���Փ˂����I�u�W�F�N�g��ground�������ꍇ
        if (collision.gameObject.name == "ground")
        {
            GetComponent<AudioSource>().Play();
        }

        //CubePrefab���Փ˂����I�u�W�F�N�g��CubePrefab�������ꍇ
        if (collision.gameObject.name == "CubePrefab(Clone)")
        {
            GetComponent<AudioSource>().Play();
        }

    }


}
