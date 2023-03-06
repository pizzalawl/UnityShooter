using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    public float Jumpforce =20f;
    public float speed = 3f;
     void Start() 
     {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        transform.position += new Vector3(xValue, 0, zValue);
        if(Input.Getkey(KeyCode.Space))
        {
          rb.AddRelativeForce(Vector3.up*Time.deltaTime*Jumpforce);
        }
    }
}
