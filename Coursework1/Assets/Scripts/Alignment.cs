using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
//This scripts is for aligning the flock with each other so they go the same way

//use boids
[RequireComponent(typeof(Boid))]
public class Alignment : MonoBehaviour
{
    private Boid boid;

    public float radius;
    // Start is called before the first frame update
    void Start()
    {
        //set boid component
        boid = GetComponent<Boid>();
    }

    // Update is called once per frame
    void Update()
    {
        //variable for finding same type objects
        var boids = FindObjectsOfType<Boid>();
        var average = Vector3.zero;
        var found = 0;

        //loop to make sure each boid is not referencing itself
        foreach(var boid in boids.Where(b => b != boid))
        {
            //finds the position difference in the boids
            var diff = boid.transform.position - this.transform.position;
            if(diff.magnitude < radius)
            {
                average += boid.velocity;
                found += 1;
            }
        }
        //checks to see if there are anymore boids
        if(found > 0)
        {
            //changes speed of boids to match each other
            average = average / found;
            boid.velocity += Vector3.Lerp(boid.velocity, average, Time.deltaTime);
        }
    }
}
