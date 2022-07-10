using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Chase : MonoBehaviour
{
    private GameObject PlayerBall;
    public int speed = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(FindObjectOfType<MoveSphere>().transform);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
    }
}   
