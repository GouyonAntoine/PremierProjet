using System;
using MesClasses;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Collections.Specialized;

//Exercices Par Antoine Gouyon :
namespace ExoBasique
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Amusez vous bien en découvrant mes exercices réalisé lors de mes sessions de C# ! ");
            Console.WriteLine("Exercice 1 à 30 => Exercice Basique");
            Console.WriteLine("Exercice 31 => Exercice de Classe");
            Console.WriteLine("Exercice 32 => Exercice sur l'Héritage");
            Console.WriteLine("Exercice 33 à 38 => Exerice sur les Tableaux et les Listes");
            Console.WriteLine("Exercice 39 à 40 => Exercice avec Linq");
            Console.WriteLine("Exercice 41 à 42 => Exercice sur les fichiers");
            Console.WriteLine("Exercice 300 => Exercice Bonus Morpion");
            int exo = 50;
            while (exo != 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
                Console.WriteLine("Entrez un numero d'exercice à effectuer (0 pour fermer la console) :");
                exo = GetInt();
                Console.WriteLine("");
                switch (exo)
                {
                    case 1: Exo1(); break;
                    case 2: Exo2(); break;
                    case 3: Exo3(); break;
                    case 4: Exo4(); break;
                    case 5: Exo5(); break;
                    case 6: Exo6(); break;
                    case 7: Exo7(); break;
                    case 8: Exo8(); break;
                    case 9: Exo9(); break;
                    case 10: Exo10(); break;
                    case 11: Exo11(); break;
                    case 12: Exo12(); break;
                    case 13: Exo13(); break;
                    case 14: Exo14(); break;
                    case 15: Exo15(); break;
                    case 16: Exo16(); break;
                    case 17: Exo17(); break;
                    case 18: Exo18(); break;
                    case 19: Exo19(); break;
                    case 20: Exo20(); break;
                    case 21: Exo21(); break;
                    case 22: Exo22(); break;
                    case 23: Exo23(); break;
                    case 24: Exo24(); break;
                    case 25: Exo25(); break;
                    case 26: Exo26(); break;
                    case 27: Exo27(); break;
                    case 28: Exo28(); break;
                    case 29: Exo29(); break;
                    case 30: Exo30(); break;
                    case 300: Exo300(); break;
                    case 31: ExoClasse(); break;
                    case 32: ExoHerit(); break;
                    case 33: ExoTab1(); break;
                    case 34: ExoTab2(); break;
                    case 35: ExoTab3(); break;
                    case 36: ExoTab4(); break;
                    case 37: ExoTab5(); break;
                    case 38: ExoTab6(); break;
                    case 40: ExoLinq2(); break;
                    case 41: ExoIO(); break;
                    case 42: ExoIOTest(); break;
                }
            }
        }
        //Exercices Basiques 1 à 30 (bonus 300) :
        //Exercice 1 :
        static void Exo1()
        {
            Console.WriteLine("Consigne : ");
            Console.WriteLine("Affichez « Hello » et « World » sur 2 lignes séparés");
            Console.WriteLine("");
            Console.WriteLine("Hello \nWorld");
        }

        //Exercice 2 : 
        static string GetString()
        {

            Console.WriteLine("Entrez une chaine de caractere : ");
            var result = Console.ReadLine();
            return result;
        }

        static int GetInt()
        {
            Console.WriteLine("Entrez un nombre entier : ");
            var result = Console.ReadLine();
            int i;

            while (!int.TryParse(result, out i))
            {
                Console.WriteLine("Erreur, rentrer un entier à nouveau : ");
                result = Console.ReadLine();
            }

            //Console.WriteLine("Votre entier est : " + i);
            return i;
        }

        static string GetDate()
        {
            Console.WriteLine("Saississez une date :");
            Console.WriteLine("Saissiez l'année");
            int annee = GetInt();
            Console.WriteLine("Saissiez un mois");
            int mois = GetInt();
            Console.WriteLine("Saissiez le journée");
            int jour = GetInt();
            Console.WriteLine("Saissiez l'heure");
            int heure = GetInt();
            Console.WriteLine("Saissiez les minutes");
            int minute = GetInt();
            Console.WriteLine("Saissiez les secondes");
            int seconde = GetInt();
            DateTime date = new DateTime(annee, mois, jour, heure, minute, seconde);

            return date.ToString();
        }


        static void Exo2()
        {
            Console.WriteLine("Consigne : ");
            Console.WriteLine("Créez 2 fonctions dans votre classe, une pour récupérer l’entrée utilisateur en chaine de caractère et l’autre pour récupérer un entier. Utilisez ces méthodes dans les prochains exercices");
            Console.WriteLine("");
            Console.WriteLine("Voulez vous entrez un entier (taper 1) ou une chaine de caractere (taper 2) ");
            var result = Console.ReadLine();
            int i;
            while (!int.TryParse(result, out i))
            {
                Console.WriteLine("Erreur, rentrer 1 pour un entier ou 2 pour une chaine de caractere : ");
                result = Console.ReadLine();
            }

            if (i == 1)
            {
                GetInt();
            }
            else
            {
                GetString();
            }
        }

        //Exercice 3 :
        static void Exo3()
        {
            Console.WriteLine("Consigne : ");
            Console.WriteLine("Faites rentrez 3 mots à l’utilisateur et afficher les dans l’ordre inverse de la saisie");
            Console.WriteLine("");
            Console.WriteLine("Veuillez rentrer à la suite 3 mots et nous vous les redonnerons dans l'ordre inverse !");
            Console.WriteLine("Mot 1 : ");
            var result1 = GetString();
            Console.WriteLine("Mot 2 : ");
            var result2 = GetString();
            Console.WriteLine("Mot 3 : ");
            var result3 = GetString();

            Console.WriteLine("Voici les mots en partant du dernier => " + result3 + " " + result2 + " " + result1);
        }


        //Exercice 4 : 
        static void Exo4()
        {
            Console.WriteLine("Consigne : ");
            Console.WriteLine("Affichez si les 2 nombres rentré par l’utilisateur sont égaux");
            Console.WriteLine("");
            Console.WriteLine("Rentrez 2 entiers et nous vous diront si ils sont égaux ! ");
            Console.WriteLine("Entier 1 : ");
            var result1 = GetInt();
            Console.WriteLine("Entier 2 : ");
            var result2 = GetInt();

            if (result1 == result2)
            {
                Console.WriteLine("Les 2 entiers sont bien égaux félication user !");
            }
            else
            {
                Console.WriteLine("Les 2 entiers ne sont pas égaux, dommage user, ça sera la prochaine fois !");
            }

        }

        //Exercice 5 :
        static void Exo5()
        {
            Console.WriteLine("Consigne : ");
            Console.WriteLine("Créez 2 nombres, les afficher, les intervertir et les réafficher");
            Console.WriteLine("");
            Console.WriteLine("Rentrez 2 entiers et nous allons les afficher puis les intervertir ! ");
            Console.WriteLine("Entier 1 : ");
            var result1 = GetInt();
            Console.WriteLine("Entier 2 : ");
            var result2 = GetInt();

            Console.WriteLine("Vous avez entrer : " + result1 + " et " + result2);
            Console.WriteLine("Maintenant on les inverse ! ");
            Console.WriteLine("Vous avez entrer : " + result2 + " et " + result1);
        }


        //Exercice 6 :
        static void Exo6()
        {
            Console.WriteLine("Consigne : ");
            Console.WriteLine("Affichez le résultat de l’ajout, la soustraction, la multiplication et la division de 2 nombres rentrés par l’utilisateur");
            Console.WriteLine("");
            Console.WriteLine("Rentrez 2 entiers et nous allons nous amuser avec ! ");
            Console.WriteLine("Entier 1 : ");
            var result1 = GetInt();
            Console.WriteLine("Entier 2 : ");
            var result2 = GetInt();

            int add = result1 + result2;
            Console.WriteLine("L'addition de ses 2 entiers est => " + add);
            int mult = result1 * result2;
            Console.WriteLine(" La multiplication de ses 2 entiers est => " + mult);
            int sous = result1 - result2;
            Console.WriteLine("La soustraction de " + result1 + " par " + result2 + " est égale à => " + sous);
            float div = (float)result1 / result2;
            Console.WriteLine("La division de " + result1 + " par " + result2 + " est égale à => " + div);

        }

        //Exercice 7 :
        static void Exo7()
        {
            Console.WriteLine("Consigne : ");
            Console.WriteLine("Affichez la moyenne de 4 nombres rentrés par l’utilisateur");
            Console.WriteLine("");
            Console.WriteLine("Rentrez 4 entiers et nous allons vous donner la moyenne correspondante ! ");
            Console.WriteLine("Entier 1 : ");
            var result1 = GetInt();
            Console.WriteLine("Entier 2 : ");
            var result2 = GetInt();
            Console.WriteLine("Entier 3 : ");
            var result3 = GetInt();
            Console.WriteLine("Entier 4 : ");
            var result4 = GetInt();

            int total = result1 + result2 + result3 + result4;
            float moy = (float)total / 4;
            Console.WriteLine("La moyenne est donc => " + moy);
        }

        //Exercice 8 :
        static void Exo8()
        {
            Console.WriteLine("Consigne : ");
            Console.WriteLine("Affichez le nombre le plus grand de 4 nombres rentrés par l’utilisateur");
            Console.WriteLine("");
            Console.WriteLine("Rentrez 4 entiers et nous allons vous donner le plus grand parmis ceux-ci ! ");
            Console.WriteLine("Entier 1 : ");
            var result1 = GetInt();
            Console.WriteLine("Entier 2 : ");
            var result2 = GetInt();
            Console.WriteLine("Entier 3 : ");
            var result3 = GetInt();
            Console.WriteLine("Entier 4 : ");
            var result4 = GetInt();

            int max1 = Math.Max(result1, result2);
            int max2 = Math.Max(result3, result4);
            int maxFinal = Math.Max(max1, max2);
            Console.WriteLine("Le nombre le plus grand parmis les 4 choisis est => " + maxFinal);

        }

        //Exercie 9 :
        static void Exo9()
        {
            Console.WriteLine("Consigne : ");
            Console.WriteLine("Savoir si le nombre rentré est négatif ou positif");
            Console.WriteLine("");
            Console.WriteLine("Rentrez un entier, je vous dirais si il est positif ou négatif ! ");
            var result = GetInt();
            if (result >= 0)
            {
                Console.WriteLine("Votre entier est positif ! ");
            }
            else
            {
                Console.WriteLine("Votre entier est négatif ! ");
            }
        }

        //Exercice 10 : 
        static void Exo10()
        {
            Console.WriteLine("Consigne : ");
            Console.WriteLine("Savoir si le nombre donné est pair ou impair");
            Console.WriteLine("");
            Console.WriteLine("Rentrez un entier, je vous dirais si il est pair ou impair ! ");
            var result = GetInt();
            if ((result % 2) == 0)
            {
                Console.WriteLine("Votre entier est pair ! ");
            }
            else
            {
                Console.WriteLine("Votre entier est impair ! ");
            }
        }


        //Exercice 11 :
        static void Exo11()
        {
            Console.WriteLine("Consigne : ");
            Console.WriteLine("Rentrez un nombre en Celsius et le convertir en Kelvin et Fahrenheit");
            Console.WriteLine("");
            Console.WriteLine("Rentrez un nombre en Celsius, je vous le convertirai en Kelvin et Farenheit! ");
            var result = GetInt();
            double kelvin = 273.15 + result;
            Console.WriteLine("La convertion en Kelvin est => " + kelvin);
            float farenheit = ((float)result * 9 / 5) + 32;
            Console.WriteLine("La convertion en Farenheit est => " + farenheit);
        }

        //Exercice 12 :
        static void Exo12()
        {
            Console.WriteLine("Consigne : ");
            Console.WriteLine("Rentrez un chiffre et dire de quel jour il s’agit sous forme de texte");
            Console.WriteLine("");
            Console.WriteLine("Rentrez un nombre et je vous dirais à quel jour il corresponds ! ");
            var result = GetInt();
            float jour = (float)result % 7;
            switch (jour)
            {
                case 1: jour = 0; Console.WriteLine("Nous sommes donc un lundi ! "); break;
                case 2: jour = 1; Console.WriteLine("Nous sommes donc un mardi ! "); break;
                case 3: jour = 2; Console.WriteLine("Nous sommes donc un mercredi ! "); break;
                case 4: jour = 3; Console.WriteLine("Nous sommes donc un jeudi ! "); break;
                case 5: jour = 4; Console.WriteLine("Nous sommes donc un vendredi ! "); break;
                case 6: jour = 5; Console.WriteLine("Nous sommes donc un samedi ! "); break;
                case 7: jour = 6; Console.WriteLine("Nous sommes donc un dimanche ! "); break;
            }
        }

        //Exercice 13 :
        static void Exo13()
        {
            Console.WriteLine("Consigne : ");
            Console.WriteLine("Bloquez un utilisateur après avoir rentré 3 faux password");
            Console.WriteLine("");
            Console.WriteLine("Entrez le mot de passe => MDP1234 et surtout ne vous ratez pas 3 fois !");
            var result = GetString();
            int i = 1;
            while (result != "MDP1234" && i < 3)
            {
                Console.WriteLine("Vous vous êtes trompé, essayez encore !");
                result = GetString();
                i++;
            }

            if (i >= 3 && result != "MDP1234")
            {
                Console.WriteLine("Vous vous êtes trompé 3 fois de suite, vous êtes viré !");
            }
            else
            {
                Console.WriteLine("Vous avez rentrer le bon mot de passe mais vous n'êtes pas fun");
            }

        }

        //Exercice 14 :
        static void Exo14()
        {
            Console.WriteLine("Consigne : ");
            Console.WriteLine("Rentrez un nombre, puis un signe (+ - * /), puis un autre nombre, affichez ensuite le résultat");
            Console.WriteLine("");
            Console.WriteLine("Rentrez un nombre, puis un signe (+ - * /), puis un autre nombre, et je vous afficherai le resultat");
            Console.WriteLine("Rentrez un nombre");
            var result1 = GetInt();
            string signe = "";
            int symbole = 4;
            while (symbole == 4)
            {
                Console.WriteLine("Veuillez rentrer l'un des signes suivant uniquement s'il vous plaît (+ - * /)");
                signe = GetString();
                if (signe == "+")
                {
                    symbole = 0;
                }
                if (signe == "-")
                {
                    symbole = 1;
                }
                if (signe == "*")
                {
                    symbole = 2;
                }
                if (signe == "/")
                {
                    symbole = 3;
                }
            }
            Console.WriteLine("Rentrez un deuxieme nombre");
            var result2 = GetInt();
            float resultf = 0;
            Console.WriteLine("Calcul du résultat de votre opération ! ");
            //switch (symbole)
            //{
            //    case 1: symbole = 0; resultf = result1 + result2; Console.WriteLine("Le résultat de l'addition de vos nombre est => " + resultf); break;
            //    case 2: symbole = 1; resultf = result1 - result2; Console.WriteLine("Le résultat de la soustraction de vos nombre est => " + resultf); break;
            //    case 3: symbole = 2; resultf = result1 * result2; Console.WriteLine("Le résultat de la multiplication de vos nombre est => " + resultf); break;
            //    case 4: symbole = 3; resultf = (float) result1 / result2; Console.WriteLine("Le résultat de la division vos nombre est => " + resultf); break;
            //}
            if (symbole == 0)
            {
                resultf = result1 + result2;
                Console.WriteLine("Le résultat de l'addition de vos nombres est => " + resultf);
            }
            if (symbole == 1)
            {
                resultf = result1 - result2;
                Console.WriteLine("Le résultat de la soustraction de vos nombres est => " + resultf);
            }
            if (symbole == 2)
            {
                resultf = result1 * result2;
                Console.WriteLine("Le résultat de la multiplicaiton vos nombres est => " + resultf);
            }
            if (symbole == 3)
            {
                resultf = (float)result1 / result2;
                Console.WriteLine("Le résultat de la division de vos nombres est => " + resultf);
            }


        }

        //Exercice 15 :
        static void Exo15()
        {
            Console.WriteLine("Consigne : ");
            Console.WriteLine("Afficher les 10 premiers chiffres à partir de 0 (avec une boucle for)");
            Console.WriteLine("");
            Console.WriteLine("Voici la liste des 10 premiers chiffres ! ");
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i);
            }
        }

        //Exercice 16 :
        static void Exo16()
        {
            Console.WriteLine("Consigne : ");
            Console.WriteLine("Donnez la table de multiplication des 10 premiers chiffres");
            Console.WriteLine("");
            Console.WriteLine("Voici la table de multiplication des 10 chiffres ! ");
            int mult = 0;
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("Table de multiplication de " + i + " : ");
                for (int j = 0; j < 11; j++)
                {
                    mult = i * j;
                    Console.WriteLine("Résultat de " + i + " * " + j + " = " + mult);
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("FIN");
        }

        //Exercice 17 :
        static void Exo17()
        {
            Console.WriteLine("Consigne : ");
            Console.WriteLine("Rentrez une lettre et une taille et l’afficher sous forme de triangle");
            Console.WriteLine("");
            Console.WriteLine("Combien de ligne à votre pyramide monsieur/madame ? ");
            var ligne = GetInt();
            Console.WriteLine("La lettre ou chiffre à afficher dans la pyramide ? ");
            var aff = GetString();
            Console.WriteLine("");
            for (int i = 0; i <= ligne; i++)
            {
                for (int j = 0; j <= ligne - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= 2 * i; k++)
                {
                    Console.Write(aff);
                }
                Console.WriteLine("");
            }
        }

        //Exercice 18 :
        static void Exo18()
        {
            Console.WriteLine("Consigne : ");
            Console.WriteLine("Faire une pyramide d’une hauteur donnée");
            Console.WriteLine("");
            Console.WriteLine("Combien de ligne à votre pyramide monsieur/madame ? ");
            var ligne = GetInt();
            Console.WriteLine("");
            for (int i = 0; i <= ligne; i++)
            {
                for (int j = 0; j <= ligne - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= 2 * i; k++)
                {
                    Console.Write("^");
                }
                Console.WriteLine("");
            }
        }

        //Exercice 19 :
        static void Exo19()
        {
            Console.WriteLine("Consigne : ");
            Console.WriteLine("Faire un diamant d’une hauteur donnée");
            Console.WriteLine("");
            Console.WriteLine("Combien de ligne à votre pyramide monsieur/madame ? ");
            var ligne = GetInt();
            Console.WriteLine("");
            for (int i = 0; i <= ligne; i++)
            {
                for (int j = 0; j <= ligne - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= 2 * i; k++)
                {
                    Console.Write("^");
                }
                Console.WriteLine("");
            }
            for (int i = ligne - 1; i >= 0; i--)
            {
                for (int j = 0; j <= ligne - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= 2 * i; k++)
                {
                    Console.Write("^");
                }
                Console.WriteLine("");
            }

        }

        //Exercice 20 :
        static void Exo20()
        {
            Console.WriteLine("Consigne : ");
            Console.WriteLine("Créez la date d’aujourd’hui et affichez-la de façon complète puis de façon jour/mois/année)");
            Console.WriteLine("");
            DateTime thisDay = DateTime.Now;
            Console.WriteLine(thisDay.ToString());

            string Date = DateTime.Now.ToString("dd-MM-yyyy");
            Console.WriteLine(Date);
        }


        //Exercice 21 : 
        static void Exo21()
        {
            Console.WriteLine("Consigne : ");
            Console.WriteLine("Créer une date avec l’utilisateur qui rentre l’année, mois, jour, heure, minute et seconde et afficher le jour(Lundi, mardi...) | en français ou en anglais");
            Console.WriteLine("");
            Console.WriteLine("Saissiez l'année");
            var annee = GetInt();
            Console.WriteLine("Saissiez un mois");
            var mois = GetInt();
            Console.WriteLine("Saissiez le journée");
            var jour = GetInt();
            Console.WriteLine("Saissiez l'heure");
            var heure = GetInt();
            Console.WriteLine("Saissiez les minutes");
            var minute = GetInt();
            Console.WriteLine("Saissiez les secondes");
            var seconde = GetInt();
            DateTime date1 = new DateTime(annee, mois, jour, heure, minute, seconde);
            Console.WriteLine(date1.ToString());
            //Console.WriteLine("Is Thursday the day of the week for {0:d}?: {1}", date1, date1.DayOfWeek == DayOfWeek.Thursday);
            Console.WriteLine("The day of the week for {0:d} is {1}.", date1, date1.DayOfWeek);
            Console.WriteLine("Le jour de la semaine {0:d} est {1}.", date1, date1.ToString("dddd"));

        }
        //Exercice 22 : 
        static void Exo22()
        {
            Console.WriteLine("Consigne : ");
            Console.WriteLine("Affichez la différence de temps entre 2 dates");
            Console.WriteLine("");
            Console.WriteLine("Saississez une date de départ !");
            Console.WriteLine("Saissiez l'année");
            var annee = GetInt();
            Console.WriteLine("Saissiez un mois");
            var mois = GetInt();
            Console.WriteLine("Saissiez le journée");
            var jour = GetInt();
            Console.WriteLine("Saissiez l'heure");
            var heure = GetInt();
            Console.WriteLine("Saissiez les minutes");
            var minute = GetInt();
            Console.WriteLine("Saissiez les secondes");
            var seconde = GetInt();
            DateTime date1 = new DateTime(annee, mois, jour, heure, minute, seconde);

            Console.WriteLine("Saississez une date de fin !");
            Console.WriteLine("Saissiez l'année");
            annee = GetInt();
            Console.WriteLine("Saissiez un mois");
            mois = GetInt();
            Console.WriteLine("Saissiez le journée");
            jour = GetInt();
            Console.WriteLine("Saissiez l'heure");
            heure = GetInt();
            Console.WriteLine("Saissiez les minutes");
            minute = GetInt();
            Console.WriteLine("Saissiez les secondes");
            seconde = GetInt();
            DateTime date2 = new DateTime(annee, mois, jour, heure, minute, seconde);

            TimeSpan Diff = date2 - date1;
            Console.WriteLine(string.Format("Il y a {0} jours d'écart entre les 2 dates saisie !", (int)Diff.TotalDays));
        }
        //Exercice 23 : 
        static void Exo23()
        {
            Console.WriteLine("Consigne : ");
            Console.WriteLine("Convertir une chaine de caractère en date");
            Console.WriteLine("");
            Console.WriteLine("Entrez une date au format 'jour/mois/année' ");
            var CurrentDate = GetString();

            //Use of Convert.ToDateTime()   
            DateTime DateObject = Convert.ToDateTime(CurrentDate);
            Console.WriteLine("Nous somme donc: " + DateObject.ToString("dd-MM-yyyy"));
            Console.WriteLine("Et à cette date nous sommes un {1}.", DateObject, DateObject.ToString("dddd"));

        }
        //Exercice 24 : 
        static void Exo24()
        {
            Console.WriteLine("Consigne : ");
            Console.WriteLine("Jeu du plus ou moins (un nombre est définit par défaut, puis l’utilisateur rentre un chiffre et le programme lui dit si le bon nombre est + ou – que celui définit jusqu’à que l’utilisateur trouve)");
            Console.WriteLine("");
            Console.WriteLine("Bienvenu dans le jeu du plus ou du moins ! Essayez de trouver le nombre en moins de 10 essaies (Entre 0 et 100) !");
            Random random = new Random();
            int randomNumber;
            randomNumber = random.Next(0, 100);
            int essai = 1;
            var nombre = GetInt();
            while (nombre != randomNumber)
            {
                if (nombre < randomNumber)
                {
                    Console.WriteLine("Rater, c'est plus, essaie encore !");
                    essai++;
                    nombre = GetInt();
                }
                else
                {
                    Console.WriteLine("Rater, c'est moins, essaie encore !");
                    essai++;
                    nombre = GetInt();
                }
            }
            Console.WriteLine("Félicitation tu as trouvé le chiffre " + randomNumber + " en 'seulement' " + essai + " tentatives !");
        }
        //Exercice 25 : 
        static void Exo25()
        {
            Console.WriteLine("Consigne : ");
            Console.WriteLine("Affichez une chaine donnée en majuscule");
            Console.WriteLine("");
            Console.WriteLine("Entrez une chaine de caractere en minuscule, je vous la rends en majuscule et tout ça gratuitement !");
            var result = GetString();
            Console.WriteLine("La voici en majuscule => " + result.ToUpper());
        }
        //Exercice 26 : 
        static void Exo26()
        {
            Console.WriteLine("Consigne : ");
            Console.WriteLine("Affichez le nombre de caractère d’une chaine sans utiliser la propriété Length");
            Console.WriteLine("");
            Console.WriteLine("Nous allons compter le nombre de caractère dans votre chaine sans compter les espaces !");
            var chaine = GetString();
            int nbrC = 0;
            foreach (char c in chaine)
            {
                if (!(char.IsWhiteSpace(c)))
                {
                    nbrC++;
                }

            }
            Console.WriteLine("Il y a donc " + nbrC + " caractères dans votre chaine ! ");
        }
        //Exercice 27 : 
        public static string Reverse(string text)
        {
            char[] chars = text.ToCharArray();
            Array.Reverse(chars);
            return new String(chars);
        }
        static void Exo27()
        {
            Console.WriteLine("Consigne : ");
            Console.WriteLine("Affichez un espace entre toute les lettres d’une chaine de caractère donnée en inversant les lettres");
            Console.WriteLine("");
            Console.WriteLine("Nous allons inverser votre chaine de caractere en ajoutant des espaces entre les caractere (sauf si il y a déjà un espace) !");
            var chaine = GetString();
            var chaineInv = Reverse(chaine);
            foreach (char c in chaineInv)
            {
                if (!(char.IsWhiteSpace(c)))
                {
                    Console.Write(c + " ");
                }

            }
            Console.WriteLine("");
            Console.WriteLine("Voici votre chaine inversé avec des espaces en plus quand 2 caractères étaient collés !");
        }
        //Exercice 28 : 
        static void Exo28()
        {
            Console.WriteLine("Consigne : ");
            Console.WriteLine("Dire si une chaine est égale à une autre sans prendre en compte la casse");
            Console.WriteLine("");
            Console.WriteLine("Entrez 2 chaine de caractère , je vous dis si ils sont identiques sans prendre compte de la casse !");
            var result1 = GetString();
            var result2 = GetString();
            if (result1.ToUpper() == result2.ToUpper())
            {
                Console.WriteLine("C'est identique ! ");
            }
            else
            {
                Console.WriteLine("C'est pas identique ! ");
            }
        }
        //Exercice 29 : 
        static void Exo29()
        {
            Console.WriteLine("Consigne : ");
            Console.WriteLine("Savoir si la chaine donnée est un palindrome (mot qui se lit dans les deux sens : SOS)");
            Console.WriteLine("");
            Console.WriteLine("Donnez un mot et je vous dirais si c'est un palindrome ! ");
            var result = GetString();
            var result2 = Reverse(result);

            if (string.Compare(result, result2) == 0)
            {
                Console.WriteLine("Cette chaine de caractere est un palindrome ! ");
            }
            else
            {
                Console.WriteLine("Cette chaine de caractere n'est pas un palindrome ! ");
            }

        }
        //Exercice 30 : 
        static void Exo30()
        {
            Console.WriteLine("Consigne : ");
            Console.WriteLine("Lister les nombres de 1 à 100, en remplaçant le nombre par un mot selon certaines conditions :");
            Console.WriteLine("Le mot Fizz s'il est multiple de 3");
            Console.WriteLine("Le mot Buzz s'il est multiple de 5");
            Console.WriteLine("Le mot FizzBuzz s'il est multiple de 3 et de 5");
            Console.WriteLine("Un retour à la ligne tous les 9 éléments");
            Console.WriteLine("");
            Console.WriteLine("Liste des nombres 1 à 100 en remplaçant le nombre par un mot selon certaine condition, enjoy ! ");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        if (i % 9 == 0)
                        {
                            Console.Write("FizzBuzz ");
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.Write("FizzBuzz ");
                        }
                    }
                    else if (i % 9 == 0)
                    {
                        Console.Write("Fizz ");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.Write("Fizz ");
                    }
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz ");
                }
                else
                {
                    Console.Write(i + " ");
                }
            }

        }

        //Exercice Bonus : Morpion :
        //Affichage complet du plateau 
        static void Plateau(int[,] board)
        {
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == 0 && j == 0)
                    {
                        Console.Write("   |");
                    }
                    if (board[i, j] == 1 && j == 0)
                    {
                        Console.Write(" X |");
                    }
                    if (board[i, j] == 2 && j == 0)
                    {
                        Console.Write(" O |");
                    }

                    if (board[i, j] == 0 && j == 1)
                    {
                        Console.Write("   |");
                    }
                    if (board[i, j] == 1 && j == 1)
                    {
                        Console.Write(" X |");
                    }
                    if (board[i, j] == 2 && j == 1)
                    {
                        Console.Write(" O |");
                    }

                    if (board[i, j] == 0 && j == 02)
                    {
                        Console.Write("   ");
                    }
                    if (board[i, j] == 1 && j == 2)
                    {
                        Console.Write(" X ");
                    }
                    if (board[i, j] == 2 && j == 2)
                    {
                        Console.Write(" O ");
                    }

                }
                Console.WriteLine("");
                Console.WriteLine("---|---|---");
            }
        }


        //récuperation coordonnée du plateau 
        static int GetCoord()
        {
            Console.WriteLine("Entrez un nombre entier entre 1 et 3: ");
            var result = Console.ReadLine();
            int i;

            while (!int.TryParse(result, out i))
            {
                Console.WriteLine("Erreur, rentrer un entier à nouveau : ");
                result = Console.ReadLine();
            }
            if (i < 1)
            {
                Console.WriteLine("La valeur est trop petite, il faut que ce soit 1 , 2 ou 3 !");
                GetCoord();
            }
            if (i > 3)
            {
                Console.WriteLine("La valeur est trop petite, il faut que ce soit 1 , 2 ou 3 !");
                GetCoord();
            }

            //Console.WriteLine("Votre entier est : " + i);
            return i;
        }


        //Vérification des conditions de victoires 
        static int ConditionVictoire(int[,] board)
        {
            //Joueur 1 Victoire :
            if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2] && board[0, 0] == 1)
            {
                return 1;
            }
            if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2] && board[1, 0] == 1)
            {
                return 1;
            }
            if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2] && board[2, 0] == 1)
            {
                return 1;
            }
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] == 1)
            {
                return 1;
            }
            if (board[2, 0] == board[1, 1] && board[1, 1] == board[2, 0] && board[2, 0] == 1)
            {
                return 1;
            }
            if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0] && board[0, 0] == 1)
            {
                return 1;
            }
            if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1] && board[0, 1] == 1)
            {
                return 1;
            }
            if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2] && board[0, 2] == 1)
            {
                return 1;
            }

            //Joueur 2 Victoire :
            if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2] && board[0, 0] == 2)
            {
                return 2;
            }
            if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2] && board[1, 0] == 2)
            {
                return 2;
            }
            if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2] && board[2, 0] == 2)
            {
                return 2;
            }
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] == 2)
            {
                return 2;
            }
            if (board[2, 0] == board[1, 1] && board[1, 1] == board[2, 0] && board[2, 0] == 2)
            {
                return 2;
            }
            if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0] && board[0, 0] == 2)
            {
                return 2;
            }
            if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1] && board[0, 1] == 2)
            {
                return 2;
            }
            if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2] && board[0, 2] == 2)
            {
                return 2;
            }

            return 0;
        }
        static void Exo300()
        {
            Console.WriteLine("Lancement du jeu du morpion !  Pour cela écrivez la ou vous voulez cocher avec les coordonnées de forme '1,2' par exemple avec 1 pour la 1ere ligne et 2 la 2eme colonne (entrer des nombres entre 1 et 3) !");
            Console.WriteLine("");
            int[,] board = new int[3, 3];
            int symboleC = 0;
            int symboleL = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = 0;
                }
            }
            int turn = 1;
            Console.WriteLine("");
            while (ConditionVictoire(board) == 0)
            {
                if (turn == 1)
                {
                    turn = 2;
                    Console.WriteLine("Joueur 1, c'est à vous ! ");
                    Plateau(board);
                    Console.WriteLine("Donner votre ligne");
                    symboleL = GetCoord();
                    Console.WriteLine("Donner votre colonne");
                    symboleC = GetCoord();
                    while (board[symboleL - 1, symboleC - 1] != 0)
                    {
                        Console.WriteLine("Joueur 1, c'est encore à vous, cette case est déjà prise !");
                        Plateau(board);
                        Console.WriteLine("Donner votre ligne");
                        symboleL = GetCoord();
                        Console.WriteLine("Donner votre colonne");
                        symboleC = GetCoord();
                    }
                    board[symboleL - 1, symboleC - 1] = 1;
                    symboleC = 0;
                    symboleL = 0;

                }
                else
                {
                    turn = 1;
                    Console.WriteLine("Joueur 2, c'est à vous ! ");
                    Plateau(board);
                    Console.WriteLine("Donner votre ligne");
                    symboleL = GetCoord();
                    Console.WriteLine("Donner votre colonne");
                    symboleC = GetCoord();
                    while (board[symboleL - 1, symboleC - 1] != 0)
                    {
                        Console.WriteLine("Joueur 2, c'est encore à vous, cette case est déjà prise !");
                        Plateau(board);
                        Console.WriteLine("Donner votre ligne");
                        symboleL = GetCoord();
                        Console.WriteLine("Donner votre colonne");
                        symboleC = GetCoord();
                    }
                    board[symboleL - 1, symboleC - 1] = 2;
                    symboleC = 0;
                    symboleL = 0;
                }
            }
            if (ConditionVictoire(board) == 1)
            {
                Console.WriteLine("Joueur 1 a gagné ! ");
                Console.WriteLine("");
                Plateau(board);
            }
            else
            {
                Console.WriteLine("Joueur 2 a gagné ! ");
                Console.WriteLine("");
                Plateau(board);
            }

        }



        //Exercice Les classes :

        //Exercice 31: 

        static void ExoClasse()
        {
            Personne p1 = new Personne();
            Console.WriteLine(Personne.test);
            Console.WriteLine("");

            Console.WriteLine("Entrez un prénom :");
            var p = GetString();
            Console.WriteLine("Entrez un nom :");
            var n = GetString();
            Console.WriteLine("Entrez une date :");
            var d = GetDate();

            Personne p2 = new Personne(n, p, d);

            Console.WriteLine("Voici la personne 1 : ");
            Console.WriteLine(p1.Afficher());
            Console.WriteLine("");
            Console.WriteLine("Voici la personne 2: ");
            Console.WriteLine(p2.Afficher());
            Console.WriteLine("");

            p1 = p2;
            p1.MajPrenom();

            Console.WriteLine("Voici la personne 1 : ");
            p1.Afficher();
            Console.WriteLine("");
            Console.WriteLine("Voici la personne 2: ");
            Console.WriteLine(p2.Afficher());
            Console.WriteLine("");
        }

        //Exercice Heritage :
        //Exercice 32
        static void ExoHerit()
        {
            Personne p1 = new Personne("Kamado", "Tanjiro", "15/02/2016");
            Employe e1 = new Employe("Koyoharu", "Gotōge", "01/01/1989", 666666);

            Personne p2 = new Personne("Mugiwara", "Luffy", "05/05/1997");
            Employe e2 = new Employe("Eiichirō", "Oda", "01/01/1975", 777777);

            ITravailleur[] tabIT = { p1, e1, p2, e2 };

            Console.WriteLine("Voici l'affichage des 4 ITravailleur listé dans un tableau d'ITravailleur : ");
            foreach (ITravailleur t in tabIT)
            {
                Console.WriteLine(t.Afficher());
            }
        }


        //Exercice Tableaux et Listes :
        //Exercice 33
        static void ExoTab1()
        {
            Random random = new Random();
            int[] tabEntier = { random.Next(0, 100), random.Next(0, 100), random.Next(0, 100), random.Next(0, 100), random.Next(0, 100), random.Next(0, 100), random.Next(0, 100), random.Next(0, 100), random.Next(0, 100) };

            //Avant Tri
            Console.WriteLine("Tableau avant le tri : ");
            for (int i = 0; i < tabEntier.Length; i++)
            {
                Console.Write(tabEntier[i] + " ");
            }
            Console.WriteLine("");

            //Après Tri
            Array.Sort(tabEntier);
            Console.WriteLine("Tableau après le tri : ");
            for (int i = 0; i < tabEntier.Length; i++)
            {
                Console.Write(tabEntier[i] + " ");
            }
        }

        //Exercice 34
        static void ExoTab2()
        {
            List<string> test = new List<string>();
            string[] tabS = { "salut", "les", "gens", "c'est", "david", "lafarge", "Pokemon" };
            for (int i = 0; i < tabS.Length; i++)
            {
                test.Add(tabS[i]);
            }

            //Avant le tri
            Console.WriteLine("List<string> avant le tri : ");
            for (int i = 0; i < test.Count; i++)
            {
                Console.WriteLine(test[i]);
            }

            //Après le tri
            test.Sort();
            Console.WriteLine("List<string> après le tri : ");
            for (int i = 0; i < test.Count; i++)
            {
                Console.WriteLine(test[i]);
            }
        }

        //Exercice 35
        static void ExoTab3()
        {
            List<Personne> listP = new List<Personne>();
            Personne p1 = new Personne("Kamado", "Tanjiro", "15/02/2016");
            Personne p2 = new Personne("Mugiwara", "Luffy", "05/05/1997");

            listP.Add(p1);
            listP.Add(p2);

            for (int i = 0; i < listP.Count; i++)
            {
                Console.WriteLine(listP[i].Afficher());
            }
        }

        //Exercice 36
        static void ExoTab4()
        {

            Personne p1 = new Personne("Kamado", "Tanjiro", "15/02/2016");
            Personne p2 = new Personne("Mugiwara", "Luffy", "05/05/1997");
            Dictionary<int, Personne> dicoP = new Dictionary<int, Personne>() { { 1, p1 }, { 2, p2 } };

            for (int i = 1; i < 3; i++)
            {
                Console.WriteLine($"La personne n°{i} is {dicoP[i].nom} {dicoP[i].prenom} !");
            }
        }

        //Exercice 37
        static void ExoTab5()
        {

            Personne p1 = new Personne("Kamado", "Tanjiro", "15/02/2016");
            Personne p2 = new Personne("Mugiwara", "Luffy", "05/05/1997");
            Personne p3 = new Personne("Gouyon", "Antoine", "11/02/1997");
            Dictionary<int, Personne> dicoP = new Dictionary<int, Personne>() { { 1, p1 }, { 2, p2 } };

            Console.WriteLine("Est-ce que le dico contiens des informations sur Tanjiro  = " + dicoP.ContainsValue(p1));
            Console.WriteLine("Est-ce que le dico contiens des informations sur Antoine  = " + dicoP.ContainsValue(p3));
        }

        //Exercice 38
        static void ExoTab6()
        {

            List<Personne> listP = new List<Personne>();
            Personne p1 = new Personne("Kamado", "Tanjiro", "15/02/2016");
            Personne p2 = new Personne("Mugiwara", "Luffy", "05/05/1997");
            Personne p3 = new Personne("Gouyon,", "Antoine", "11/02/1995");
            Personne p4 = new Personne("Kamado", "Nezuko", "15/02/2016");

            listP.Add(p1);
            listP.Add(p2);
            listP.Add(p3);
            listP.Add(p4);

            //Avant le tri
            Console.WriteLine("Liste de 4 personnes avant le tri :");
            for (int i = 0; i < listP.Count; i++)
            {
                Console.WriteLine(listP[i].Afficher());
            }
            Console.WriteLine("");

            //Avant le tri
            listP.Sort();
            Console.WriteLine("Liste de 4 personnes après le tri :");
            for (int i = 0; i < listP.Count; i++)
            {
                Console.WriteLine(listP[i].Afficher());
            }

        }


        //Exercice avec Linq 

        //Exercice 39 
        static void ExoLinq1()
        {
            Random random = new Random(); //random.Next(0, 100),
            List<int> listE = new List<int>();
            listE.Add(random.Next(-100, 100));
            listE.Add(random.Next(-100, 100));
            listE.Add(random.Next(-100, 100));
            listE.Add(random.Next(-100, 100));
            listE.Add(random.Next(-100, 100));
            listE.Add(random.Next(-100, 100));
            listE.Add(random.Next(-100, 100));
            listE.Add(random.Next(-100, 100));
            listE.Add(random.Next(-100, 100));
            listE.Add(random.Next(-100, 100));
            listE.Add(random.Next(-100, 100));
            listE.Add(random.Next(-100, 100));
            listE.Add(random.Next(-100, 100));


            Console.WriteLine("Liste des chiffres :");
            for (int i = 0; i < listE.Count; i++)
            {
                Console.WriteLine(listE[i]);
            }
            Console.WriteLine("");

            //Calcul somme
            Console.WriteLine("La somme de cette liste est : " + listE.Sum());

            //Calcul moyenne
            Console.WriteLine("La moyenne de cette liste est : " + listE.Average());

            //Afficher les nombres supérieur à 6
            var nbrSupSix = listE.Where(n => n > 6);
            Console.WriteLine("Liste des elements avec une valeur supérieur à 6 : ");
            foreach (var elem in nbrSupSix) Console.WriteLine(elem);

            //Compteur du nombre d'element de la liste
            int nbrElem = 0;
            foreach (var elem in listE) nbrElem++;
            Console.WriteLine("Il y a " + nbrElem + " dans cette Liste !");
        }

        //Exercice 40
        static void ExoLinq2()
        {
            List<Personne> personnes = new List<Personne>();

            var random = new Random();

            personnes.Add(new Personne("Roche", "Charlotte", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Michel", "Nathan", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Lacroix", "Quentin", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Dufour", "Louis", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Dumas", "Clémence", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Clara", "Vincent", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Carla", "Huet", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Maëlle", "Blanchard", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Justine", "Brun", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Noémie", "Fournier", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Jean", "Dupond", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Pierre", "Dupont", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Jacques", "Dupou", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Thierry", "Dapont", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Jean", "Bille", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Thomas", "Artoh", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Romain", "Dupont", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Dufour", "Charlotte", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));
            personnes.Add(new Personne("Roche", "Huet", DateTime.Now.AddYears(random.Next(-80, -10)).AddMonths(random.Next(-80, -10))));

            //Trie par nom puis par le prénom
            var listTri = personnes.OrderBy(p => p.nom).ThenBy(n => n.prenom);
            Console.WriteLine("Liste des personne trié par nom puis prénom :");
            foreach (var elem in listTri) Console.WriteLine(elem.Afficher());
            Console.WriteLine("");

            //Liste des personnes qui ont leur nom commençant par "D"
            var listPrenomD = personnes.Where(p => p.nom.StartsWith("D"));
            Console.WriteLine("Liste des personne trié par nom puis prénom :");
            foreach (var elem in listPrenomD) Console.WriteLine(elem.Afficher());
            Console.WriteLine("");

            //Afficher que le nom des personnes
            List<string> listNom = personnes.Select(p => p.nom).ToList();
            Console.WriteLine("Liste des personnes avec uniquement leur nom :");
            foreach (var elem in listNom) Console.WriteLine(elem);
            Console.WriteLine("");

            //Afficher nom des gens en majuscule et qui commence par D
            List<string> listNomMaj = personnes.Where(p => p.nom.StartsWith("D") || p.nom.StartsWith("d")).OrderBy(p => p.prenom).ToList().Select(p => p.nom.ToUpper()).ToList();
            Console.WriteLine("Liste des personnes avec uniquement leur nom en majuscule, trier par le prénom et qui commence par un D:");
            foreach (var elem in listNomMaj) Console.WriteLine(elem);
            Console.WriteLine("");

            //Afficher et récuperer que les 2 premieres personnes
            var twoElem = personnes.Take(2);
            Console.WriteLine("Affichage des 2 premiers elements de la liste :");
            foreach (var elem in twoElem) Console.WriteLine(elem.Afficher());
            Console.WriteLine("");

            //Afficher et récuperer que les 7,8 et 9 personnes de la liste
            var listThreeElem = personnes.Skip(6).Take(3);
            Console.WriteLine("Affichage des elements n° 7, n°8 et n° 9 de la liste :");
            foreach (var elem in listThreeElem) Console.WriteLine(elem.Afficher());
            Console.WriteLine("");

            //Afficher et récuperer la personne qui à le nom Dupont (j'ai récuperer avec le prénom car dans le sampledata les nom et prenom sont inversé en parametre pour moi
            var dupont = personnes.Where(p => p.prenom == "Dupont" || p.prenom == "dupont");
            Console.WriteLine("Affichage des elements de la liste qui s'appellent Dupont :");
            foreach (var elem in dupont) Console.WriteLine(elem.Afficher());
            Console.WriteLine("");

            //Savoir si notre liste contient une personne dont le nom commence par D





            //Regrouper les personnes par leur prénom
            var listGroupByP = personnes.GroupBy(p => p.prenom).SelectMany(p => p).ToList();
            Console.WriteLine("Affichage des elements groupé par prenom :");
            foreach (var elem in listGroupByP) Console.WriteLine(elem);
            Console.WriteLine("");

        }

        // Exercice IO
        static void ExoIO()
        {
            string[] files = Directory.GetFiles(@"c:\testIO\");
            foreach (string file in files)
                Console.WriteLine(file);
        }


        static void ExoIOTest()
        {
            //FichierParcours((@"c:\testIO\"), 0);
            FichierParcours((@"c:\"), 0);
        }

        static void FichierParcours(string route, int compteur)
        {
            string distSousDossier = "";
            if (compteur >= 1)
            {
                for (int etageFichier = 0; etageFichier < compteur; etageFichier++)
                {
                    distSousDossier += "-";
                }
            }

            compteur++;

            try
            {
                string[] dossiers = Directory.GetDirectories(route);
                foreach (string dossier in dossiers)
                {
                    DirectoryInfo verifD = new DirectoryInfo(dossier);
                    if (verifD.Attributes.HasFlag(FileAttributes.Hidden))
                    {
                        continue;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(distSousDossier + dossier);
                    FichierParcours(dossier, compteur);
                }

                string[] fichiers = Directory.GetFiles(route);
                foreach (string fichier in fichiers)
                {
                    DirectoryInfo verifF = new DirectoryInfo(fichier);
                    if (verifF.Attributes.HasFlag(FileAttributes.Hidden))
                    {
                        continue;
                    }
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(distSousDossier + fichier);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception attrapée !");
            }
        }
    }
}
