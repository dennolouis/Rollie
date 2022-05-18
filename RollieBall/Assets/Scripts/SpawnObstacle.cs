using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{

    public GameObject[] obj;
    public Transform spawnEnd;

    void Start()
    {
        Instantiate(obj[Random.Range(0, obj.Length)], transform.position, Quaternion.identity);
   
    }
    void Update()
    {
        
    }
    



}    

