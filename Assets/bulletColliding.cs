using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletColliding : MonoBehaviour
{
    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        Destroy(this);
    }
}
