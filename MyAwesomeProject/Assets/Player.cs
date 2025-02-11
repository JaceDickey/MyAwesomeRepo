using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * 0.04f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * 0.04f;
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * 0.04f;
        }

        if(Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * 0.04f;
        }

        if(Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.up * 0.04f;
        }

        if(Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += Vector3.down * 0.04f;
        }
    }
}
