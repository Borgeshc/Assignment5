using UnityEngine;
using System.Collections;

public class HelloCoroutine : MonoBehaviour
{

	void Start ()
    {
        StartCoroutine(MyCoroutine());
	}

	IEnumerator MyCoroutine ()
    {
        yield return new WaitForSeconds(5);
        //print("WaitForSeconds");
        //ChangeBool();
        //yield return new WaitUntil(ChangeBool);
        //print("WaitUntil");
        //WhileBoolTrue();
        //yield return new WaitWhile(WhileBoolTrue);
        //print("WaitWhile");
    }

    bool ChangeBool()
    {
        return true;
    }

    bool WhileBoolTrue()
    {
        return false;
    }
}
