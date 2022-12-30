using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wing : MonoBehaviour
{
    public float CL;
    public float CdUP;
    public float CdForward;
    public float AirDensity = 1;
    Rigidbody2D rbody;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void CalcForce()
    {
        var velForward = Vector3.Dot(this.rbody.velocity, this.transform.right);
        var velUp = Vector3.Dot(this.rbody.velocity, this.transform.up);

        //Lift
        var liftForce = velForward * AirDensity * CL;

        //Resistance up
        var resUp = -CdUP * velUp * AirDensity;

        //Resistance forward
        var resFor = -CdForward * velForward * AirDensity;

        var force = (liftForce + resUp) * this.transform.up + resFor * this.transform.right;
        rbody.AddForce(force);
    }

    // Update is called once per frame
    void Update()
    {
        this.AirDensity = MyFramework.CalculateAirDensity(this.transform.position.y);
        CalcForce();
    }
}
