using UnityEngine;
public class Weapon
{
    public float velocity;
    public int clipSize;
    public float reloadTime;
    public float projectileRange;

    public virtual void Fire() {

    }

    public virtual void Reload() {

    }

    public GameObject[] CreateObjectPool() {
        return new GameObject[1];
    } 
}
