using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GenerateWindmill : MonoBehaviour
{
    public GameObject windmill;
    public float count;
    public Vector3 offset;
    Vector3 total;
    public List<GameObject> myWindmills;
    //public GameObject[] myWindmills;
    GameObject clone;
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
                clone = Instantiate(windmill, (new Vector3(offset.x, 10, offset.z)) - total, Quaternion.identity) as GameObject;
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

