using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses
{
    public class Eleve
    {
        //Attributs
        public string nom { get; set; }
        public int age { get; set; }
        public double moyenne { get; set; }

        //Constructeurs
        public Eleve()
        {
            this.nom = " Bilbo ";
            this.age = 18;
            this.moyenne = 0;
        }

        public Eleve(string n, int a, double m)
        {
            this.nom = n;
            this.age = a;
            this.moyenne = m;
        }
    }
}
