using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class OrderArtiodactyl : ClassMammals, IAnimal
    {
        public bool HasHorns { get; set; }
        public string Habitat { get; set; }
        public OrderArtiodactyl(bool hasHorns, string habitat, int incubationPeriod, int lifeExpectancy, int weight, string name)
            : base(incubationPeriod, lifeExpectancy, weight, name)
        {
            HasHorns = hasHorns;
            Habitat = habitat;
        }

        public override string ToString()
        {
            return $"{Name}, {Weight} кг, {IncubationPeriod} месяцев, {LifeExpectancy} лет, есть рога: {HasHorns}, {Habitat}\n";
        }

    }
}
