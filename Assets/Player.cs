using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 50f;   // ���Ɉړ����鑬�x
    public float jumpP = 300f; // �W�����v��

    Rigidbody2D rbody; // ���W�b�h�{�f�B���g�����߂̐錾

    // Start is called before the first frame update
    void Start()
    {
        // ���W�b�h�{�f�B2D���R���|�[�l���g����擾���ĕϐ��ɓ����
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // �W�����v�����邽�߂̃R�[�h�i�����X�y�[�X�L�[��������āA������ɑ��x���Ȃ����Ɂj
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // ���W�b�h�{�f�B�ɗ͂�������i������ɃW�����v�͂�������j
            rbody.AddForce(transform.up * jumpP);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            // ���W�b�h�{�f�B�ɗ͂�������i������ɃW�����v�͂�������jd
            rbody.AddForce(new Vector3(1,0,0) * speed);      
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            // ���W�b�h�{�f�B�ɗ͂�������i������ɃW�����v�͂�������jd
            rbody.AddForce(new Vector3(-1, 0, 0) * speed);
        }
    }

    private void FixedUpdate()
    {
        //���W�b�h�{�f�B�Ɉ��̑��x������i���ړ��̑��x, ���W�b�h�{�f�B��y�̑��x�j
        //rbody.velocity = new Vector2(speed, rbody.velocity.y);
    }
}