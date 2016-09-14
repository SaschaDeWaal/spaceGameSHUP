using UnityEngine;
using System.Collections;


public abstract class Ship : MonoBehaviour {

    protected Stats stats = new Stats();

    private void Update() {
        Move();
        Attack();
    }

	public virtual void TakeDamage(int damage) {
        stats.health -= damage;
    }

    public abstract void Move();
    public abstract void Attack();
}
