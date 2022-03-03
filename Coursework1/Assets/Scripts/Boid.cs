using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boid : MonoBehaviour
{

    public Vector3 velocity;
    public float maxVelocity;
    // Start is called before the first frame update
    void Start()
    {
        velocity = this.transform.forward * maxVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        //sets max velocity of boids
        if(velocity.magnitude > maxVelocity)
        {
            velocity = velocity.normalized * maxVelocity;
        }
        //changes position and speed of boids
        this.transform.position += velocity * Time.deltaTime;   
        this.transform.rotation = Quaternion.LookRotation(velocity);
    }
}
