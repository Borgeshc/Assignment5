using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class WeaponManager : MonoBehaviour {

    public List<Weapon> weapons;

    RocketLauncher rocketLauncher;
    int ammo;
    bool canShoot;
    int index;
    int lastIndex;
	void Start () {
        //// Continue Here!/////
        //In GameManager create a list of all of the weapon types (Ex. RocketLauncher) and cycle through in this script. You can use the current selected one to call the fire method in that script.

        weapons.Add(rocketLauncher);

        for (int i = 1; i < weapons.Length; i++)
        {
            weapons[i].SetActive(false);
        }
        rocketLauncher = new RocketLauncher();
        ammo = rocketLauncher.clipSize;
	}
	
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            lastIndex = index;
            index++;
            if (index >= weapons.Length)
            {
                index = 0;
            }
            weapons[lastIndex].SetActive(false);
            weapons[index].SetActive(true);
        }
       // if (Input.GetButtonDown("Fire1") && canShoot)
      //  {
            //ammo--;
            //Fire();
            //if (ammo <= 0)
            //{
            //    canShoot = false;
            //    StartCoroutine(Reload());
            //}
        //}
    }

    IEnumerator Reload()
    {
        yield return new WaitForSeconds(rocketLauncher.reloadTime);
        ammo = rocketLauncher.clipSize;
        canShoot = true;
    }
}
