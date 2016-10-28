using UnityEngine;
using System.Collections;

//Hector
//Assignment 6
//This script generates windmills
//10/27/16

public class Shoot : MonoBehaviour
{
    public int reloadTime;
    public int maxAmmo;

    ObjectPooling objectPooling;
    GameObject gunBarrel;
    int ammo;
    bool canShoot;
    GameObject bullet;


    void Start()
    {
        objectPooling = GameObject.Find("BulletPool").GetComponent<ObjectPooling>();
        gunBarrel = GameObject.Find("GunBarrel");
        ammo = maxAmmo;
        canShoot = true;
    }

    void Update()
    {

        if (Input.GetButtonDown("Fire1") && canShoot)
        {
            ammo--;
            Fire();
            if(ammo <= 0)
            {
                canShoot = false;
                StartCoroutine(Reload());
            }
        }
    }

    IEnumerator Reload()
    {
        yield return new WaitForSeconds(reloadTime);
        ammo = maxAmmo;
        canShoot = true;
    }

    void Fire()
    {
        bullet = objectPooling.GetPooledObject();
        bullet.transform.position = gunBarrel.transform.position;
        bullet.transform.rotation = gunBarrel.transform.rotation;
        bullet.SetActive(true);
    }
}
