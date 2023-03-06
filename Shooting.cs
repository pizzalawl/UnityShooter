using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10f;
    public GameObject character;
    Vector3 offset = new Vector3(0, 0, 0);

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)){
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            Rigidbody rb = bullet.AddComponent<Rigidbody>() as Rigidbody;
            rb.velocity = transform.forward * bulletSpeed * Time.deltaTime;
        }
    }
}
