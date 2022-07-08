using UnityEngine;


public class Collide : MonoBehaviour
{
  public GameObject GameOver;
  public bool nowOver;

  void OnCollisionEnter (Collision collision) 
  {      
    if (collision.gameObject.tag == "Obstacle" ) 
    {
      GameOver.SetActive(true);
      GameIsOver();
    } 
  }

  public void  GameIsOver(){
    
    Debug.Log("Game Over!!!");
  }
}