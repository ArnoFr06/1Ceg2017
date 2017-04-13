using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCegep
{
    class Cours
    {
        private string num;
        private string nom;
        private float heure;

        public Cours(string num, string nom, float heure)
        {
            this.num = num;
            this.nom = nom;
            this.heure = heure;
        }

        public string getNum()
        {
            return num;
        }

        public void setNum(string num)
        {
            this.num = num;
        }

        public string getNom()
        {
            return nom;
        }

        public void setNom(string nom)
        {
            this.nom = nom;
        }

        public float getHeure()
        {
            return heure;
        }

        public void setHeure(float heure)
        {
            this.heure = heure;
        }

    }
}
