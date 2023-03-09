using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camScript : MonoBehaviour
{
    public float sensitivity = 100f;
    public Transform playerBody;
    float xRotation = 0f;
    public Camera mainCamera;
    public Camera secondaryCamera;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        mainCamera.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
           
      float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime* sensitivity;
      float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime* sensitivity;
      playerBody.Rotate(Vector3.up * mouseX);
           
      xRotation -= mouseY;
           
      float X = Mathf.Clamp(xRotation, -90f, 90f);
      mainCamera.transform.localRotation = Quaternion.Euler(xRotation,0f,0f);

      if(Input.GetKeyDown(KeyCode.V)){
        if(mainCamera.enabled == true){
          mainCamera.enabled = false;
          secondaryCamera.enabled = true;
        }
        else if(mainCamera.enabled == false){
          mainCamera.enabled = true;
          secondaryCamera.enabled = false;
        }
      }
           
    }
}
