using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
  public float jumpForce = 200f;
  public float speed = 8f;
  public Rigidbody rb;
  public bool onGround = false;
  
  void Start(){
    rb = GetComponent<Rigidbody>();
  }
  
  // Update is called once per frame
  void Update()
  {
    Vector3 position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    float zValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
    float xValue = Input.GetAxis("Vertical") * Time.deltaTime * speed;
    transform.position += new Vector3(xValue, 0, zValue);

    if(Input.GetButtonDown("Jump") && onGround){
      rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
      onGround = false;
    }
  }

  private void OnCollisionEnter(Collision collision){
    if(collision.gameObject.name == "Plane"){
      onGround = true;
    }
  }
}
