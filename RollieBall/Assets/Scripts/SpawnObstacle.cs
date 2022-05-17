using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{

    public GameObject obstacles;
    public Transform spawnEnd;

    void Start()
    {
        Instantiate(obstacles, spawnEnd.position, spawnEnd.rotation);
   
    }
    void Update()
    {
        
    }
    



}    

