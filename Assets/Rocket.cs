using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour
{
    int speed;
    int projectileRange;

    GameObject player;
    RocketLauncher rocketLauncher;
    void Start()
    {
        player = GameObject.Find("Player");
        rocketLauncher = new RocketLauncher();
    }
	void Update () {
        transform.Translate(Vector3.forward * rocketLauncher.velocity * Time.deltaTime);
        if (Vector3.Distance(transform.position, player.transform.position) > rocketLauncher.projectileRange)
        {
            gameObject.SetActive(false);
        }
	}
}
