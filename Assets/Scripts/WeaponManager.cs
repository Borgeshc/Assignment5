using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//Hector
//Assignment 6
//This script generates windmills
//10/27/16

public class WeaponManager : MonoBehaviour {

    Dictionary<Weapon, Weapon> weapons = new Dictionary<Weapon, Weapon>();
    public GameObject rocketLauncherModel;
    public GameObject laserGunModel;
    Weapon myWeapon;

    ObjectPooling objectPool;
    GameObject gunBarrel;
    GameObject bullet;
    int ammo;
    bool canShoot;
    int index = 1;
    int lastIndex;

    RocketLauncher rocketLauncher = new RocketLauncher();
    LaserGun laserGun = new LaserGun();
    void Start () {
        weapons.Add(rocketLauncher, laserGun);
        objectPool = GameObject.Find("BulletPool").GetComponent<ObjectPooling>();
        gunBarrel = GameObject.Find("GunBarrel");
        canShoot = true;

        myWeapon = ReturnWeapon();
    }

    Weapon ReturnWeapon()
    {
        if (index == 0)
            return rocketLauncher;
        else if (index == 1)
            return laserGun;
        else
        return null;
    }
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            lastIndex = index;
            index++;

            if (index > weapons.Count)
            {
                index = 0;
            } 
            myWeapon = ReturnWeapon();

            if (myWeapon == rocketLauncher)
            {
                rocketLauncherModel.SetActive(true);
                laserGunModel.SetActive(false);
            }
            else if (myWeapon == laserGun)
            {
                laserGunModel.SetActive(true);
                rocketLauncherModel.SetActive(false);
            }
        }
        if (Input.GetButtonDown("Fire1") && canShoot)
        {
            ammo--;
            bullet = objectPool.GetPooledObject();
            myWeapon.Fire(gunBarrel, bullet);
            
            if (ammo <= 0)
            {
                canShoot = false;
                StartCoroutine(Reload());
            }
        }
    }
    IEnumerator Reload(){
        yield return new WaitForSeconds(myWeapon.reloadTime);
        ammo = myWeapon.clipSize;
        canShoot = true;
    }
}
