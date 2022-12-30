using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraManager : MonoBehaviour
{

    public GameObject target; 
    Vector3 pos;              

    // Start is called before the first frame update
    void Start()
    {
        pos = Camera.main.gameObject.transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPos = target.transform.position; // cameraPos�Ƃ����ϐ�����A�Ǐ]����Ώۂ̈ʒu������



        cameraPos.z -=5; // �J�����̉��s���̈ʒu��-10������
        Camera.main.gameObject.transform.position = cameraPos; //�@�J�����̈ʒu�ɕϐ�cameraPos�̈ʒu������

    }
}