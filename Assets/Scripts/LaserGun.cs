using UnityEngine;

//Hector
//Assignment 6
//This script generates windmills
//10/27/16

public class LaserGun : Weapon
{
    public LaserGun(){
        //weaponModel = Resources.Load("LaserGun") as GameObject; //Ask Daryl on thurs
        velocity = 100f;
        clipSize = 500;
        reloadTime = 3f;
        projectileRange = 300;
    }

    public LaserGun(float _velocity){
        base.velocity = _velocity;
    }

    public override void Fire(GameObject barrel, GameObject projectile){
        Debug.Log("Fire from AR15 class");
        base.Fire(barrel, projectile);
    }
}