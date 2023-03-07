using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float jumpForce =200f;
    public float speed = 3f;
    public bool touchingG = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        transform.position += new Vector3(xValue, 0, zValue);
        if(Input.GetKeyDown(KeyCode.Space))
        {
          Rigidbody rb = GetComponent<Rigidbody>();
          if(touchingG == true){
            rb.AddRelativeForce(Vector3.up*jumpForce*Time.deltaTime);
          }
          touchingG = false;
        }
         private void OnCollisionEnter(Collision other)
        {
          if(other gameObject.tag == "Floor")
          {
           touchingG = true;
          }
        }
    }
}
