using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public GameObject target;
    public float mindistance = 2f;
    public Vector3 velocity = new Vector3(5,0,0);
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(gameObject.transform.position, target.transform.position);
        if(distance < mindistance){
            transform.LookAt(target.transform, Vector3.up);
            rb.velocity = velocity;
        }
    }
}
