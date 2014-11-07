using UnityEngine;
using System.Collections;

public abstract class Tower : Objet {

	// Déclaration des attributs :
	int _level ; // Niveau de la tour
	int _range ; // Etendue de la zone d'attaque de la tour (combien de cases de distance autour d'elle-meme ?)
	int _attackZone ; // Taille de la zone d'attaque autour du personnage attaqué
	int _cost ; // Cout de base de la tour
	int _upgradeCost ; // Cout d'upgrade, il faudra créer la fonction et voir si elle est fixe ou dépend de la tour
	int _damage ; // Valeur des dégats de base faits par la tour.
	// Il faudrait voir si on rajoute un parametre aleatoire ici pour que ce soit une valeur dans un intervalle de valeurs.
	int _cooldownTime ; // Temps entre deux coups (en frames ? Si c'est pas le cas, il faut changer le type.)
	
	// Constructeur :
	public Tower (int range, int attackZone, int cost, int damage, int cooldownTime, Sprite sprite, Vector2 position) : base(sprite, position) { // Appel au super constructeur au passage.
		// Attention aux modifications potentielles de "damage" ou de "position".
		this._level = 1;
		this._range = range;
		this._attackZone = attackZone;
		this._cost = cost;
		this._damage = damage;
		this._cooldownTime = cooldownTime;

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
