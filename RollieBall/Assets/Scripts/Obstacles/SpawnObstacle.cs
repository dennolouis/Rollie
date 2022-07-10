using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{

    public GameObject[] obj;
    float nextSpawnTime;
    public float TimeToLive = 5f;
    void Start()
    {
        // showUp();
        nextSpawnTime = Time.time + 2.0f;
        
    }

    void Update()
    {
        if(Time.time > nextSpawnTime)
        {
            GameObject obstacle =
            //do stuff here (like instantiate)
            Instantiate(obj[Random.Range(0, obj.Length)], transform.position, Quaternion.identity);
            nextSpawnTime += 2.0f;
            Destroy(obstacle, 5.5f);
            ScoreManager.instance.AddPoint(10);
        }

            
        
    }

    // void showUp()
    // // {
    // //     Instantiate(obj[Random.Range(0, obj.Length)], transform.position, Quaternion.identity);
    // // }

}    

