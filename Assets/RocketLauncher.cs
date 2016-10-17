using UnityEngine;
public class RocketLauncher : Weapon {

    public RocketLauncher() {
        velocity = 40f;
        clipSize = 10;
        reloadTime = 2f;
        projectileRange = 120;
    }

    public RocketLauncher(float _velocity){
        base.velocity = _velocity;
    }

    public override void Fire()
    {
        Debug.Log("Fire from AR15 class");
        base.Fire();
        this.CreateObjectPool();
    }
}
