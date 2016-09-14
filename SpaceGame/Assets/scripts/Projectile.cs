using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

    const float speed = 10;

	void Update () {
        transform.Translate(Vector3.left*Time.deltaTime*speed);
	}
}
