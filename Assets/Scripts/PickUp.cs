using UnityEngine;
using System.Collections;

//Hector
//Assignment 6
//This script generates windmills
//10/27/16

public class PickUp : MonoBehaviour
{
    PickUpManager pickUpManager;
    
	void Start () {
        pickUpManager = GameObject.Find("GameManager").GetComponent<PickUpManager>();
	}
	
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            pickUpManager.Collected();
            Destroy(gameObject);
        }
    }
}
