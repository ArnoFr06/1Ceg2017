using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCegep
{
    class Programme
    {
        private string num;
        private string nom;
        private string heure;

        public Programme(string num, string nom, string heure)
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
    }
}
