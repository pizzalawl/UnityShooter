using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsCam : MonoBehaviour
{
    [SeriliezeField] float sensitivity = 100f;
    public Transform payerbody;
    float xRotacion = 0f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
           
           float mouseX * Input.GetAxis("Mouse X")* Time.deltaTime* sensitivity;
           float mouseY * Input.GetAxis("Mouse Y")* Time.deltaTime* sensitivity;
           payerBody.rotate(Vector3.up * mouseX);
           
           xRotacion -= mouseY;
           
         X = Mathf.Clamp(xRotacion, -90f, 90f);
           transform.localRotation = Quanternion.Euler(xRotacion,0f,0f);
           
    }
}
