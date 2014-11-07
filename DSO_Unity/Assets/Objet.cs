using UnityEngine;
using System.Collections;

public abstract class Objet { // "Object" est une classe native, non ?

	// Déclaration des attributs :
	Sprite _sprite ;
	Vector2 _position ;

	// Constructeur :
	public Objet (Sprite sprite, Vector2 position) {
		this._sprite = sprite;
		this._position = position;
	}

	// Use this for initialization
	void Start () {

	}


	// Update is called once per frame
	void Update () {

	}
}
