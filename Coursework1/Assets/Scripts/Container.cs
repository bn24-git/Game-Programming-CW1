using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Boid))]
public class Container : MonoBehaviour
{
    private Boid boid;

    public float radius;
    
    public float boundry;
    // Start is called before the first frame update
    void Start()
    {
        boid = GetComponent<Boid>();
    }

    // Update is called once per frame
    void Update()
    {
        //puts boids into "flocks"
        if(boid.transform.position.magnitude > radius)
        {
            boid.velocity += this.transform.position.normalized * (radius - boid.transform.position.magnitude) * boundry * Time.deltaTime;
        }
    }
}
