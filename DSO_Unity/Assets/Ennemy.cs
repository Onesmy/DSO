using UnityEngine;
using System.Collections;

public abstract class Ennemy : Object {
	//Attributs privés
	private string _nom;
	private float _vitesse;
	private int _pointDeVie;
	private int _experience;
	private int _argent;
	//A implémenter
	//private IList<StatusEffect> _effets;

	//Get & set
	public string Nom{
		get	{ return this._nom;	}
		set{ this._nom = value;	}
	}

	public float Vitesse{
		get	{ return this._vitesse;	}
		set{ this._vitesse = value;	}
	}

	public int PointDeVie{
		get	{ return this._pointDeVie;	}
		set{ this._pointDeVie = value;	}
	}
	public int Experience{
		get	{ return this._experience;	}
		set{ this._experience = value;	}
	}
	public int Argent{
		get	{ return this._argent;	}
		set{ this._argent = value;	}
	}
	//A implémenter
	/*public string IList<StatusEffect> Effets{
		get	{ return this._effets;	}
		set{ this._effets = value;	}
	}*/

	//Constructeur
	public Ennemy(string nom, float vitesse, int pointDeVie, int experience, int argent)
	{
		this.Nom = nom;
		this.Vitesse = vitesse;
		this.PointDeVie = pointDeVie;
		this.Experience = experience;
		this.Argent = argent;
		//A implémenter
		//this.Effets = new List<StatusEffect>;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
