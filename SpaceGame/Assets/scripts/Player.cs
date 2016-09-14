using UnityEngine;
using System.Collections;

public class Player : Ship {

    public GameObject bullet;

	public override void Move() {
        transform.Translate(Vector3.up*Time.deltaTime*Input.GetAxis("Vertical")*stats.movementSpeed);
        transform.Rotate(Vector3.forward*Time.deltaTime * Input.GetAxis("Horizontal") * stats.rotationSpeed);
    }

    public override void Attack() {
        if(Input.GetKeyDown(KeyCode.Space)) {
            GameObject bul = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
            bul.transform.eulerAngles -= new Vector3(0, 0, 90);
        }
    }


}
