using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectPooling : MonoBehaviour
{
    public GameObject pooledObject;
    public int poolAmount;
    public List<GameObject> pooledObjects;
    GameObject objectChosen;

    GameObject clone;

	void Start () {
        for (int i = 0; i < poolAmount; i++)
        {
            clone = Instantiate(pooledObject, transform.position, transform.rotation) as GameObject;
            clone.transform.parent = transform;
            clone.SetActive(false);
            pooledObjects.Add(clone);
        }
	}

    public GameObject GetPooledObject()
    {
        for (int j = 0; j < pooledObjects.Count; j++)
        {
            if (pooledObjects[j].activeInHierarchy == false)
            {
                return pooledObjects[j];
            }
        }
        Debug.LogError("Somehow we ran out of projectiles in our pool.");
        return null;
    }
}
