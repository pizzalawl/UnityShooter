using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletColliding : MonoBehaviour
{    
    // Called when object collides with bullet
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit the cube");
    }
}