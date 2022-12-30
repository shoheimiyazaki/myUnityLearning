using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller: MonoBehaviour
{
    public float ThrustPower;
    public float Throttle;
    public float AirDensity = 1;
    public ParticleSystem Particle;
    Rigidbody2D rbody;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        this.AirDensity = MyFramework.CalculateAirDensity(this.transform.position.y);

        var f = ThrustPower * Throttle * AirDensity * (this.transform.right);
        rbody.AddForce(f);


        var emission = Particle.emission;
        emission.rateOverTime = 10 * Throttle+1;
        var main = Particle.main;
        main.simulationSpeed = 10 * Throttle+0.1f;
    }
}
