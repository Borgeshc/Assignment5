using UnityEngine;

//Hector
//Assignment 6
//This script generates windmills
//10/27/16

public class Weapon
{
    public GameObject weaponModel;
    public float velocity;
    public int clipSize;
    public float reloadTime;
    public float projectileRange;

    public virtual void Fire(GameObject gunBarrel, GameObject bullet)
    {
        bullet.transform.position = gunBarrel.transform.position;
        bullet.transform.rotation = gunBarrel.transform.rotation;
        bullet.SetActive(true);
        //This is what I wanted to do but it did not work
    }

    public virtual void Reload() {
        //Unsure how to use this through a class because i can not do ienumerators
    }
}
