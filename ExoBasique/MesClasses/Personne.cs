using System;

namespace MesClasses
{
    public class Personne : ITravailleur, IEquatable<Personne>, IComparable<Personne>
    {
        //Attributs
        public string nom { get; set; }
        public string prenom { get; set; }
        public DateTime birthDay { get; set; }
        public static string test = "Ceci est un test !";

        //Constructeurs
        public Personne()
        {
            this.nom = " aucun ";
            this.prenom = " aucun ";
            this.birthDay = DateTime.UtcNow;
        }

        public Personne(string n, string p, string b)
        {
            this.nom = n;
            this.prenom = p;
            DateTime date = Convert.ToDateTime(b);
            this.birthDay = date;
        }
        public Personne(string n, string p, DateTime b)
        {
            this.nom = n;
            this.prenom = p;
            this.birthDay = b;
        }


        //Methodes
        public void MajPrenom()
        {
            prenom = prenom.ToUpper();
        }

        public virtual string Afficher()
        {
            return this.ToString();
        }

        public override string ToString()
        {
            return "Son nom est " + this.nom + " , son prénom est " + this.prenom + ", sa date de naissance est " + this.birthDay + " ";
        }

        public bool Equals(Personne other)
        {
            return other.nom == this.nom && other.prenom == this.prenom && other.birthDay == this.birthDay;
        }

        public int CompareTo(Personne other)
        {
            var primary = this.nom.CompareTo(other.nom);

            if(primary == 0)
            {
                return this.prenom.CompareTo(other.prenom);
            }

            return primary;
        }
    }
}
