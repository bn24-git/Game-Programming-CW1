using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newLevel : MonoBehaviour
{
   public void nextLevel()
   {
       //loads next scene
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
}
