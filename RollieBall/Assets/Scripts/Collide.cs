using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour
{
  void OnCollisionEnter (Collision collision) 
  {      
    if (collision.gameObject.tag == "Obstacle" ) 
    {
      Debug.Log("Heyyyy");
    } 
  }
}