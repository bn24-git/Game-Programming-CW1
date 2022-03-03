using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look : MonoBehaviour
{
    //mouse sensitivity
    public float mSense = 100f;
    //transform player body to move with camera
    public Transform pBody;
    //camera x-axis rotation
    float rotateX = 0f;
    // Start is called before the first frame update
    void Start()
    {
        //lock cursor in middle of screen
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //change camera view using mouse in game
        float lookX = Input.GetAxis("Mouse X") * mSense * Time.deltaTime;
        float lookY = Input.GetAxis("Mouse Y") * mSense * Time.deltaTime;

        //rotate player body with camera
        pBody.Rotate(Vector3.up * lookX);
        
        //store rotation
        transform.localRotation = Quaternion.Euler(rotateX, 0f, 0f);
        //decrease rotation based on Y
        rotateX -= lookY;
        //stop the camera from moving further than 90 degrees
        rotateX = Mathf.Clamp(rotateX, -90f, 90f);
    }
}
