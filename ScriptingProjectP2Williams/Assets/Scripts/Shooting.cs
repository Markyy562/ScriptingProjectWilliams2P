using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    public Transform firePosition;
    public float bulletSpeed;


    private inventory inventory;


    private void Awake()
    {
        inventory = GetComponent<inventory>();
    }

    void Update()
    {
        Shoot();
    }


    void Shoot()
    {
        if (Input.GetButtonDown("Fire1") && inventory.myStuff.bullets > 0)
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
            bulletInstance.AddForce(firePosition.forward * bulletSpeed);
            inventory.myStuff.bullets--;

        }
    }
}
