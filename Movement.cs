using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 3f;
    // Update is called once per frame
    void Update()
    {
        Vector3 position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        transform.position += new Vector3(xValue, 0, zValue);
        
    }
}
