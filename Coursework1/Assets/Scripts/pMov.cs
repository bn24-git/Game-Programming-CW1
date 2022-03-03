using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pMov : MonoBehaviour
{
    //create a player controller
    public CharacterController controlPlayer;
    //player speed
    public float pSpeed = 12f;
    //variable for gravity
    public float gravity = -9.8f;
    //falling speed
    Vector3 velocity;
    
    public float jump = 3f;
    //
    public Transform Floorcheck;
    public float Floordistance = 0.4f;
    public LayerMask Floormask;
    bool IsOnFloor;
    // Update is called once per frame
    void Update()
    {
        //checks if player is on floor and resets falling velocity if yes
        IsOnFloor = Physics.CheckSphere(Floorcheck.position, Floordistance, Floormask);
        if(IsOnFloor && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        if(Input.GetButtonDown("Jump") && IsOnFloor)
        {
            velocity.y = Mathf.Sqrt(jump * -2f * gravity);
        }
        //gets the horizontal and vertical inputs
        float movX = Input.GetAxis("Horizontal");
        float movZ = Input.GetAxis("Vertical");

        //moves player depending on x and z axis
        Vector3 move = transform.right * movX + transform.forward * movZ;

        //moves the player
        controlPlayer.Move(move * pSpeed * Time.deltaTime);

        //gravity added to y-axis for falling
        velocity.y += gravity * Time.deltaTime;

        controlPlayer.Move(velocity * Time.deltaTime);
    }
}
