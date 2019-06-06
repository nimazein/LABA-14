using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class ClassMammals : KingdomAnimals, IAnimal
    {
       
        public int IncubationPeriod { get; set; }
        public int LifeExpectancy { get; set; }

        public ClassMammals(int incubationPeriod, int lifeExpectancy, int weight, string name)
            : base(weight, name)
        {
            IncubationPeriod = incubationPeriod;
            LifeExpectancy = lifeExpectancy;
        }
        public override string ToString()
        {
            return $"{Name}, {Weight} кг, {IncubationPeriod} месяцев, {LifeExpectancy} лет\n";
        }
    }
    
}
