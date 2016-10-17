using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    public float speed;
    float move;
    float rotate;
	void Update () {
        move = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        rotate = Input.GetAxis("Horizontal") * (speed * 10) * Time.deltaTime;
        transform.Translate(new Vector3(0, 0, move));
        transform.Rotate(new Vector3(0, rotate, 0));
	}
}
