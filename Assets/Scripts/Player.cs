using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject MainWing;
    public GameObject TailWing;
    public GameObject Engine;

    private Propeller Prop;

    public Vector3 Up { get
        {
            return this.transform.up;
        } }
    Rigidbody2D rbody; 
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        Prop = this.Engine.GetComponent<Propeller>();
    }
    // Update is called once per frame
    void Update()
    {
        // engine controll
        if(Input.GetKeyDown(KeyCode.Alpha1))
            Prop.Throttle = 0.2f;
        if (Input.GetKeyDown(KeyCode.Alpha2))
            Prop.Throttle = 0.4f;
        if (Input.GetKeyDown(KeyCode.Alpha3))
            Prop.Throttle = 0.6f;
        if (Input.GetKeyDown(KeyCode.Alpha4))
            Prop.Throttle = 0.8f;
        if (Input.GetKeyDown(KeyCode.Alpha5))
            Prop.Throttle = 1f;
        if (Input.GetKeyDown(KeyCode.Alpha6))
            Prop.Throttle = 1.2f;

        // tail wing control


        if (Input.GetKeyDown(KeyCode.Space))
        {

        }
        if (Input.GetKey(KeyCode.D))
        {
            TailWing.transform.localEulerAngles = new Vector3(0, 0, 30);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            TailWing.transform.localEulerAngles = new Vector3(0, 0, -30);
        }
        else
        {
            TailWing.transform.localEulerAngles = new Vector3(0, 0, 0);
        }
        var pLoc = this.transform.position;
        pLoc.z = -pLoc.y;
        this.transform.position = pLoc;
    }

    private void FixedUpdate()
    {
        //���W�b�h�{�f�B�Ɉ��̑��x������i���ړ��̑��x, ���W�b�h�{�f�B��y�̑��x�j
        //rbody.velocity = new Vector2(speed, rbody.velocity.y);
    }
}