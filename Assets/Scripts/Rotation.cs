using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour
{
    public float speed;
    bool notReady;

    void Start()
    {
        StartCoroutine(Wait());
    }
	void Update ()
    {
        if(notReady)
        transform.Rotate(Vector3.forward, speed * Time.deltaTime);
	}

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        notReady = true;
    }
}
