using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;


    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;


        Vector3 moveDirection = new Vector3(xValue,0f, zValue);

        transform.Translate(xValue,0,zValue);

    }
}
