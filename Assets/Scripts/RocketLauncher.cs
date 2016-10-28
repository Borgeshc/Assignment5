using UnityEngine;

//Hector
//Assignment 6
//This script generates windmills
//10/27/16

public class RocketLauncher : Weapon {

    public RocketLauncher() {
        //weaponModel = Resources.Load("RocketLauncher") as GameObject; //Ask Daryl on thurs
        velocity = 40f;
        clipSize = 10;
        reloadTime = 2f;
        projectileRange = 120;
    }

    public RocketLauncher(float _velocity){
        base.velocity = _velocity;
    }

    public override void Fire(GameObject barrel, GameObject projectile){
        Debug.Log("Fire from AR15 class");
        base.Fire(barrel, projectile);
    }
}
