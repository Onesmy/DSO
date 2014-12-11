using UnityEngine;
using System.Collections;

using Ennemy;
using Ennemy.GenericEnnemy;

public class EnnemyManager : MonoBehaviour {
	public Ennemy.Ennemy ennemy;
	protected Animator animator;
	// Use this for initialization
	void Start () {
		this.ennemy = new Ennemy.GenericEnnemy.GenericEnnemy(new Sprite(), new Vector2(), "Hello", 1);
		this.animator = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		float MovementH = Input.GetAxis ("Horizontal");

		this.animator.SetBool ("WalksLeft", true);
		gameObject.transform.position = new Vector3 (gameObject.transform.position.x - this.ennemy.Vitesse * Time.deltaTime, 0, 0);
	}
}
