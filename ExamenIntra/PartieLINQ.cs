using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamenIntra
{
    public class Fruit
    {
        public String Nom { get; set; }

        public override bool Equals(object obj)
        {
            var fruit = obj as Fruit;
            return fruit != null &&
                   Nom == fruit.Nom;
        }

        public override int GetHashCode()
        {
            return 217408413 + EqualityComparer<string>.Default.GetHashCode(Nom);
        }
        public override string ToString()
        {
            return Nom;
        }
    }

    public class Personne
    {
        public string Nom { get; set; }
        public int Age { get; set; }
        public char Genre { get; set; }

        public IList<Fruit> FruitsAimes { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Personne personne &&
                   Nom == personne.Nom &&
                   Age == personne.Age &&
                   Genre == personne.Genre &&
                   EqualityComparer<IList<Fruit>>.Default.Equals(FruitsAimes, personne.FruitsAimes);
        }

        public override int GetHashCode()
        {
            var hashCode = -821498492;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nom);
            hashCode = hashCode * -1521134295 + Age.GetHashCode();
            hashCode = hashCode * -1521134295 + Genre.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<IList<Fruit>>.Default.GetHashCode(FruitsAimes);
            return hashCode;
        }

        public override string ToString()
        {
            return Nom;
        }

    }
    public class PartieLINQ
    {
        public static void Start()
        {
            new PartieLINQ().ExerciceLINQ();
        }
        void ExerciceLINQ()
        {
            var fruits = new List<Fruit>()
            {
                new Fruit() { Nom = "Abricot"},   new Fruit() { Nom = "Banane"},    new Fruit() { Nom = "Cerise"},  new Fruit() { Nom = "Datte"},
                new Fruit() { Nom = "Framboise"}, new Fruit() { Nom = "Grenade"},   new Fruit() { Nom = "Kiwi"},    new Fruit() { Nom = "Lime"},
                new Fruit() { Nom = "Mangue"},    new Fruit() { Nom = "Nectarine"}, new Fruit() { Nom = "Olive"},   new Fruit() { Nom = "Pomme"}
            };

            var personnes = new List<Personne>()
            {
                new Personne() { Nom = "Alice", Genre = 'F', Age = 22,   FruitsAimes = new List<Fruit>() { fruits[0], fruits[1], fruits[10] } },
                new Personne() { Nom = "Bob", Genre = 'M', Age = 12,     FruitsAimes = new List<Fruit>() { fruits[4], fruits[5], fruits[6], fruits[7], fruits[8] } },
                new Personne() { Nom = "Charlie", Genre = 'M', Age = 31, FruitsAimes = new List<Fruit>() { fruits[0], fruits[1], fruits[4], fruits[11] } },
                new Personne() { Nom = "Diane", Genre = 'F', Age = 45,   FruitsAimes = new List<Fruit>() { fruits[2], fruits[4] } },
                new Personne() { Nom = "Eve", Genre = 'F', Age = 4,      FruitsAimes = new List<Fruit>() { } }
            };

            var difficiles = PersonnesQuiNAimentPasLesFruits(personnes);

            foreach (var p in difficiles)
                Console.WriteLine(p);


            var pasBons = FruitsPasPopulaires(personnes, fruits);

            foreach (var p in pasBons)
                Console.WriteLine(p);

        }

        public IEnumerable<Personne> PersonnesQuiNAimentPasLesFruits(IEnumerable<Personne> personnes)
        {
            // Question 3.1
            return personnes;
        }
        public IEnumerable<Fruit> FruitsPasPopulaires(IEnumerable<Personne> personnes, IEnumerable<Fruit> fruits)
        {
            // Question 3.2
            return fruits;
        }
    }
}