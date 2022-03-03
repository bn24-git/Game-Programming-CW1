using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class credits : MonoBehaviour
{
    //what happens when scripts starts
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
