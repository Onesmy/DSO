using UnityEngine;
using System.Collections;

namespace Ennemy.GenericEnnemy{
	public class GenericEnnemy : Ennemy {
		//Attributs
		private const float _vitesseInitiale = 1f;
		private const int _pointDeVieInitial = 10;
		private const int _experienceInitiale = 1;
		private const int _argentInitial = 1;

		//Getter & setters
		public float VitesseInitiale{
			get{
				return _vitesseInitiale;
					}
		}

		public int PointDeVieInitial{
			get{
				return _pointDeVieInitial;
					}
		}

		public int ExperienceInitiale{
			get{
				return _experienceInitiale;
					}
		}

		public int ArgentInitial{
			get{
				return _argentInitial;
					}
		}


		//GenericEnnemy construit la base et ajuste les parametre de niveau
		//La liste des effets n'étant pas encore initialisée, on laisse les parametres ainsi.
		public GenericEnnemy(Sprite sprite, Vector2 position, string nom, int niveau /*, IList<StatusEffect> statusList*/)
			: base(sprite, position, nom)
		{
			this.Vitesse = VitesseInitiale * (float)(1f + 0.1f * niveau);
			this.PointDeVie = (int)PointDeVieInitial + niveau;
			this.Experience = (int)(ExperienceInitiale * (float)(1f + 0.1f * niveau));
			this.Argent = (int)ArgentInitial + niveau;
			//Pour l'instant, on n'a pas besoin du corps de la fonction
		}

		//Utilise les fonctions start et update du parent
	}
}