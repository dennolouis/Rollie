using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;


    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.back * moveSpeed * Time.deltaTime;

    }
}
