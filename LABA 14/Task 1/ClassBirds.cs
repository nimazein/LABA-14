using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class ClassBirds : KingdomAnimals, IAnimal
    {
        public bool Flying { get; set; }
        public bool Domestic { get; set; }

        public ClassBirds(bool flying, bool domestic, int weight, string name) 
            : base(weight, name)
        {
            Flying = flying;
            Domestic = domestic;
        }
        public override string ToString()
        {            
            return $"{Name}, {Weight} кг, летает: {Flying}, домашняя: {Domestic}";
        }
    }
}
