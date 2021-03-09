using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamenIntra.partieLinq
{
   
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
                new Personne() { Nom = "Alice",     Genre = 'F', Age = 22,  FruitsAimes = new List<Fruit>() { fruits[0], fruits[1], fruits[10] } },
                new Personne() { Nom = "Bob",       Genre = 'M', Age = 12,  FruitsAimes = new List<Fruit>() { fruits[4], fruits[5], fruits[6], fruits[7], fruits[8] } },
                new Personne() { Nom = "Charlie",   Genre = 'M', Age = 31,  FruitsAimes = new List<Fruit>() { fruits[0], fruits[1], fruits[4], fruits[11] } },
                new Personne() { Nom = "Diane",     Genre = 'F', Age = 45,  FruitsAimes = new List<Fruit>() { fruits[2], fruits[4] } },
                new Personne() { Nom = "Eve",       Genre = 'F', Age = 4,   FruitsAimes = new List<Fruit>() { } }
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

            var personnesQuiNAimentPasLesFruits = from pe in personnes.ToList()
                                                  where pe.FruitsAimes.Count() == 0
                                                  orderby pe.Nom
                                                  select pe;

                                                    
            return personnesQuiNAimentPasLesFruits;
        }
        public IEnumerable<Fruit> FruitsPasPopulaires(IEnumerable<Personne> personnes, IEnumerable<Fruit> fruits)
        {
            // Question 3.2

           

            return fruits;
        }
    }
}