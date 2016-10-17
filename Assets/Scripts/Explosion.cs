using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Explosion : MonoBehaviour
{
    public List<GameObject> children;
    Rotation rotate;

	// Use this for initialization
	void Start () {
        rotate = GetComponent<Rotation>();
        for(int i = 0; i < transform.childCount; i++)
        {
            children.Add(transform.GetChild(i).gameObject);
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Rocket")
        {
            other.gameObject.SetActive(false);
            foreach (GameObject go in children)
            {
                rotate.enabled = false;
                go.GetComponent<Rigidbody>().isKinematic = false;
                go.GetComponent<MeshCollider>().convex = true;
            }
        }
    }
}
