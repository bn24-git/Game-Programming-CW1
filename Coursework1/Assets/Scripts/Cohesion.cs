using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[RequireComponent(typeof(Boid))]
public class Cohesion : MonoBehaviour
{
    private Boid boid;

    public float radius;
    // Start is called before the first frame update
    void Start()
    {
        boid = GetComponent<Boid>();
    }

    // Update is called once per frame
    void Update()
    {
        var boids = FindObjectsOfType<Boid>();
        var average = Vector3.zero;
        var found = 0;
        //make sure the boid does not call itself
        foreach(var boid in boids.Where(b => b != boid))
        {
            //checks the radius of boids for other boids
            var diff = boid.transform.position - this.transform.position;
            if(diff.magnitude < radius)
            {
                average += diff;
                found += 1;
            }
        }
        if(found > 0)
        {
            //changes speed of boids to join together
            average = average / found;
            boid.velocity += Vector3.Lerp(Vector3.zero, average, average.magnitude / radius);
        }
    }
}
