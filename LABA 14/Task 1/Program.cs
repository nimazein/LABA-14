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
            Console.Clear();


            Console.WriteLine("Запрос 1: все птицы в зоопарке");
            Console.WriteLine();
            ShowBirds_1();
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Запрос 2: количество млекопитающих в зоопарке");
            Console.WriteLine();
            CountMammals_2();
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Запрос 3: операции над множествами (секция 1 и 2)");
            Console.WriteLine();
            SetOperations_3();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Запрос 4: агрегирование данных");
            Console.WriteLine();
            AgregateData_4();
            Console.ReadKey();
            Console.Clear();
            
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
        private static void ShowBirds_1()
        {
            int sectionNumber = 1;
            foreach (Sections section in zoo.Zooo)
            {
                var birds = from bird in section.Animals where bird.Name.Contains("Птица") select bird;
                foreach (var s in birds) Console.WriteLine("Птица: {0} в секции {1}", s.ToString(), sectionNumber);
                sectionNumber++;
            }
        }
        private static void CountMammals_2()
        {
            int inSection = 0;
            int sectionNumber = 1;
            int inZoo = 0;
            foreach (Sections section in zoo.Zooo)
            {
                inSection = (from mam in section.Animals where mam.Name.Contains("Млекопитающее") select mam).Count<IAnimal>();
                Console.WriteLine($"В секции {sectionNumber} млекопитающих: {inSection}");
                sectionNumber++;
                inZoo += inSection;
            }
            Console.WriteLine($"Млекопитающих в зоопарке: {inZoo}");
            
        }
        private static void SetOperations_3()
        {
            IAnimal[] collection_1 = zoo.Zooo[0].ToArray();
            IAnimal[] collection_2 = zoo.Zooo[1].ToArray();

            Console.WriteLine("Пересечение множеств");
            Console.WriteLine();
            Intersect(collection_1, collection_2);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Объединение множеств");
            Console.WriteLine();
            Union(collection_1, collection_2);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Разность множеств");
            Console.WriteLine();
            Except(collection_1, collection_2);
            Console.ReadKey();
            Console.Clear();       
        }
        private static void Intersect(IAnimal[] collection_1, IAnimal[] collection_2)
        {
            var intersection = collection_1.Intersect(collection_2);
            foreach (IAnimal animal in intersection)
            {
                Console.WriteLine(animal.ToString());
            }
        }
        private static void Union(IAnimal[] collection_1, IAnimal[] collection_2)
        {
            var union = collection_1.Union(collection_2);
            foreach (IAnimal animal in union)
            {
                Console.WriteLine(animal.ToString());
            }
        }
        private static void Except(IAnimal[] collection_1, IAnimal[] collection_2)
        {
            var except = collection_1.Except(collection_2);
            foreach (IAnimal animal in except)
            {
                Console.WriteLine(animal.ToString());
            }
        }
        private static void AgregateData_4()
        {
            int numberInZoo = 0;
            int sectionNumber = 1;
            int weightSumInZoo = 0;
            foreach (Sections section in zoo.Zooo)
            {
                int weightSumInSection = (from animal in section.Animals where animal.Name.Contains("Млекопитающее") select animal.Weight).Sum();
                int numberInSection = (from mam in section.Animals where mam.Name.Contains("Млекопитающее") select mam).Count<IAnimal>();

                Console.WriteLine($"Средний вес млекопитающих в секции {sectionNumber}: {weightSumInSection/numberInSection}");
                sectionNumber++;
                numberInZoo += numberInSection;
                weightSumInZoo += weightSumInSection;

            }
            Console.WriteLine($"Средний вес млекопитающих в зоопарке: {weightSumInZoo / numberInZoo}");
        }
    }
}
