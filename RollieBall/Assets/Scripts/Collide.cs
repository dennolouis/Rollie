using UnityEngine;
using UnityEngine.SceneManagement;


public class Collide : MonoBehaviour
{
  public GameObject GameOver;
  public bool nowOver;

  void OnCollisionEnter (Collision collision) 
  {      
    if (collision.gameObject.tag == "Obstacle" ) 
    {
      
      GameIsOver();
    } 
  }

  public void  GameIsOver(){
    GameOver.SetActive(true);
    Debug.Log("Game Over!!!");
    SceneManager.LoadScene("Game Over");

  }
}