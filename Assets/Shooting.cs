using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 200f;
    public GameObject character;
    Vector3 offset = new Vector3(0, 0, 0);

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0)){
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            Rigidbody rb = bullet.AddComponent<Rigidbody>() as Rigidbody;
            GameObject camera = GameObject.Find("Camera");
            GameObject light = GameObject.Find("Light");
            Destroy(camera);
            Destroy(light);
            rb.velocity = transform.forward * bulletSpeed * Time.deltaTime;
        }
        transform.position = character.transform.position;
    }
}
