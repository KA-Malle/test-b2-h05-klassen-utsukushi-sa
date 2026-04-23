using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_H5_Klasse_Pokemon_LEEG
{
    internal class Speler
    {
		// instanties
		private int _gezondheid;
        private int _positiex;
        private int positiey;
        private bool _isLevend;
		private string _naam;

		

		// properties
		public int Gezondheid
		{
			get { return _gezondheid; }
			set { _gezondheid = value; }
		}

		

		public int PositieX
		{
			get { return _positiex; }
			set { _positiex = value; }
		}

		

		public int PositieY
		{
			get { return positiey; }
			set { positiey = value; }
		}

		public bool IsLevend
		{
			get { return _isLevend; }
			set { _isLevend = value; }
		}

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

		// constructor
        public Speler()
        {


            Naam = "" ;
            Gezondheid = 100;
            PositieX = 0;
            PositieY = 0;
            IsLevend = true ;
            

        }
		// constructor 2
		// met overloading
        public Speler(int gezondheid, int posX,int posY,bool isLevend,string naam)
        {
			Gezondheid = gezondheid;
			PositieX = posX;
			PositieY = posY;
			IsLevend = isLevend;
			Naam = naam;

        }


		// Zolang de pokemons positie onder 500 - 500 zitten verplaatst hij 
		public string Verplaats()
		{
			// verplaats de pokemon van positie
            Random wil = new Random();
			string plaats;

            if (PositieX <500)
            {
                PositieX += wil.Next(1, 500);
			}

            if (PositieX < 500)
            {
                PositieY += wil.Next(1, 500);
            }

			plaats = PositieX.ToString() + "\t" + PositieY.ToString();
			return plaats;
        }

		// Dit bepaald de ontvange schade tussen 1 - 10
		public int OntvangSchade()
		{
			// geeft de schade aan de speler
			int damage = 0;
            Random wil = new Random();

			damage = wil.Next(1, 11);
			

			return damage;
        }

		// Dit zorgt dat de speler een random geneest tussen 1 en 5
        public int Genees()
        {
			// methode voor de speler te laten genezen
			int genees = 0;
            Random wil = new Random();

			genees = wil.Next(1, 6);

			return genees;
        }

		

    }
}
