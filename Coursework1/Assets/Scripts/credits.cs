using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class credits : MonoBehaviour
{
    //what happens when scripts starts
    void Start()
    {
        //unlock cursor
        Cursor.lockState = CursorLockMode.None;
    }
    public void Quit()
    {
        //quit application
        Debug.Log("Quit");
        Application.Quit();
    }
}
