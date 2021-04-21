using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses
{
    public class Employe : Personne
    {
        //Attributs
        public double salaire { get; set; }

        //Constructeurs
        public Employe() : base()
        {
            salaire = 0;
        }
        public Employe(string n, string p, string b, double s) : base(n, p, b)
        {
            salaire = s;
        }

        //Methodes
        public override string Afficher()
        {
            return this.ToString();
        }
        public override string ToString()
        {
            return base.ToString() + "et son salaire est de " + this.salaire;
        }
    }
}
