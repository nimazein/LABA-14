using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class KingdomAnimals : IAnimal
    {
        public int Weight { get; set; }
        public string Name { get; set; }
        public KingdomAnimals(int weight, string name)
        {
            Name = name;
            Weight = weight;
        }
        public override string ToString()
        {
            return $"{Name}, {Weight} кг\n";
        }
    }
}
