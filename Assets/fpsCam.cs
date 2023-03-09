using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsCam : MonoBehaviour
{
    Camera m_MainCamera;
    public Camera m_SecondaryCamera;
    
    // Start is called before the first frame update
    void Start()
    {
        m_MainCamera = Camera.main;
        m_MainCamera.enabled = true;
        m_SecondaryCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.V) && m_MainCamera.enabled){
            m_SecondaryCamera.enabled = true;
            m_MainCamera.enabled = false;
        }
        else if(Input.GetKeyDown(KeyCode.V) && m_SecondaryCamera.enabled){
            m_SecondaryCamera.enabled = false;
            m_MainCamera.enabled = true;
        }
    }
}
