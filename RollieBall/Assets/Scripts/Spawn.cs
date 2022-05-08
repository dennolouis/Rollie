using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawn : MonoBehaviour
{
    public float speed = 10;
    public GameObject[] obj;
    public bool justShowLast = false;

    public Rigidbody rb;
    /*
    Is this Split escape... idk...
    Did I finesse this script a bit? YUP:)
    */
    s
    {
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(speed, 0f, 0f);
    }

    void Init()
    {
        CreateObsticle();
        
    }

    void CreateObsticle()
    {
        GameObject obsticle =  !justShowLast
            ? Instantiate(obj[Random.Range(0, obj.Length)], transform.position, Quaternion.identity) 
            : Instantiate(obj[ obj.Length - 1], transform.position, Quaternion.identity);
        
    }
}
