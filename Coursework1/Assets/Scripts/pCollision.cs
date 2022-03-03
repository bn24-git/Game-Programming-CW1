using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pCollision : MonoBehaviour
{
    public pMov movement;
   void OnCollisionEnter(Collision collisionInfo)
   {
       if(collisionInfo.collider.tag == "Enemy")
       {
           movement.enabled = false;
           FindObjectOfType<GameManager>().End();
       }
   }
}
