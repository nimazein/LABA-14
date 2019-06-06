using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        private static int Size = 9;
        private static Zoo zoo = new Zoo();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            FillCollections();


            Console.ReadKey();
        }
        private static void FillCollections()
        {
            InputSize();
            Sections section = new Sections();
            Random rnd = new Random();
            for (int i = 0; i < Size; i++)
            {
                int weight = rnd.Next(1, 1000);
                string name;
                if (i % 2 == 0)
                {
                    name = $"Млекопитающее {i + 1}";
                    int lifeExpectancy = rnd.Next(3, 120);
                    int incubationPeriod = rnd.Next(3, 12);

                    section.Add(new ClassMammals(incubationPeriod, lifeExpectancy, weight, name));
                    continue;
                }
                if (i % 3 == 0)
                {
                    name = $"Птица {i + 1}";
                    int buf = rnd.Next(100);
                    bool domestic = buf <= 20;
                    bool flying = buf <= 20;

                    section.Add(new ClassBirds(flying, domestic, weight, name));

                    continue;
                }
                if (i % 5 == 0)
                {
                    name = $"Парнокопытное {i + 1}";
                    int lifeExpectancy = rnd.Next(3, 120);
                    int incubationPeriod = rnd.Next(3, 12);
                    int horns = rnd.Next(100);
                    bool hasHorns = horns <= 20;
                    string habitat = $"Среда обитания {i + 1}";

                    section.Add(new OrderArtiodactyl(hasHorns, habitat, incubationPeriod, lifeExpectancy, weight, name));

                    zoo.Add(section);

                    section = new Sections();
                    continue;
                }
                name = $"Животное {i + 1}";
                section.Add(new KingdomAnimals(weight, name));
               
            }
            if (!zoo.Contains(section))
                zoo.Add(section);
            Console.WriteLine("Коллекция заполнена");
        }
        private static void InputSize()
        {
            
            Console.Write("Введите размер: ");
            Size = Convert.ToInt32(Console.ReadLine());
        }

    }
}
