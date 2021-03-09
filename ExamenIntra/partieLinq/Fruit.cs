using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenIntra.partieLinq
{
    public class Fruit
    {
        public int FruitId { get; set; }
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


}
