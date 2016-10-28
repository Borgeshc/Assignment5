using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//Hector
//Assignment 6
//This script generates windmills
//10/27/16

public class GenerateWindmill : MonoBehaviour
{
    public GameObject windmill;
    public GameObject pickUp;
    [HideInInspector]
    public List<GameObject> pickUps;
    public float count;
    public Vector3 offset;
    Vector3 total;
    public List<GameObject> myWindmills;
    //public GameObject[] myWindmills;
    GameObject clone;
    GameObject clone1;
    GameObject clone2;
    GameObject clone3;
    GameObject clone4;
    int increaseIndex;
    bool allOff;
    void Start()
    {
    //    StartCoroutine(Wait());
        total = new Vector3((((count - 1) * (offset.x)) * .5f), 0f, (((count - 1) * (offset.z)) * .5f));

        for (int i = 0; i < count; i++)
        {
            offset.x += total.x;
            offset.z = 0;
            for (int j = 0; j < count; j++)
            {
                offset.z += total.z;
                clone = Instantiate(windmill, (new Vector3(offset.x, offset.y, offset.z)) - total, Quaternion.identity) as GameObject;
                clone1 = Instantiate(pickUp, new Vector3(clone.transform.position.x + 5, clone.transform.position.y + (transform.localScale.y), clone.transform.position.z), clone.transform.rotation) as GameObject;
                clone2 = Instantiate(pickUp, new Vector3(clone.transform.position.x - 5, clone.transform.position.y + (transform.localScale.y), clone.transform.position.z), clone.transform.rotation) as GameObject;
                clone3 = Instantiate(pickUp, new Vector3(clone.transform.position.x, clone.transform.position.y + (transform.localScale.y), clone.transform.position.z + 5), clone.transform.rotation) as GameObject;
                clone4 = Instantiate(pickUp, new Vector3(clone.transform.position.x, clone.transform.position.y + (transform.localScale.y), clone.transform.position.z - 5), clone.transform.rotation) as GameObject;

                pickUps.Add(clone1);
                pickUps.Add(clone2);
                pickUps.Add(clone3);
                pickUps.Add(clone4);

                myWindmills.Add(clone);
            }
        }
    }

    //void Update()
    //{
    //    if (Input.anyKeyDown && increaseIndex % myWindmills.Count < myWindmills.Count)
    //    {
    //        myWindmills[increaseIndex % myWindmills.Count].SetActive(!myWindmills[increaseIndex % myWindmills.Count].activeSelf);
    //        increaseIndex++;
    //        //StartCoroutine(Wait());
    //    }
    //}


    //void Update()
    //{
    //    if (Input.anyKeyDown)
    //    {
    //        StartCoroutine(Wait());
    //    }
    //}
    //IEnumerator Wait()
    //{
    //    foreach (GameObject go in myWindmills)
    //    {
    //        yield return new WaitForSeconds(1);
    //        go.GetComponent<Rotation>().StartMyCoroutine();
    //    }
    //}
}




//for(int i = 0; i < myWindmills.length; i++)
//    {
//        myWindmills[i] = Instantiate(windmill, (new Vector3(offset.x, 0, offset.z)) - total, Quaternion.identity) as GameObject;
//    }

//if (Input.anyKeyDown)
//{
//    //Find current state of object and set value to what it isn't.
//    myWindmills[2].SetActive(!myWindmills[2].activeSelf);   //Toggles on/off
//}

