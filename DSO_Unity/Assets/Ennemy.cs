using UnityEngine;
using System.Collections;

namespace Ennemy{
	public abstract class Ennemy : Objet {
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
		/*public IList<StatusEffect> Effets{
			get	{ return this._effets;	}
			set{ this._effets = value;	}
		}*/

		//Constructeur
		//Appelle objet pour construire le sprite et la position initiale.
		public Ennemy(Sprite sprite, Vector2 position, string nom, float vitesse, int pointDeVie, int experience, int argent) : base(sprite, position)
		{
			this.Nom = nom;
			this.Vitesse = vitesse;
			this.PointDeVie = pointDeVie;
			this.Experience = experience;
			this.Argent = argent;
			//A implémenter
			//Les StatusEffect devraient avoir un effet seulement sur la valeur de retour (La vitesse initiale ne devrait pas changer
			//this.Effets = new List<StatusEffect>;
		}

		public Ennemy(Sprite sprite, Vector2 position, string nom) : base(sprite, position){
			this.Nom = nom;
		}

		// Use this for initialization
		void Start () {
		
		}
		
		// Update is called once per frame
		void Update () {
		
		}
	}
}