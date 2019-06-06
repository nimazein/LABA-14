using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Sections
    {
        private List<IAnimal> animals = new List<IAnimal>();
        
        public List<IAnimal> Animals
        {
            
            get
            {
                return animals;
            }
        }
        public int Count { get { return animals.Count; } }

        public void Add(IAnimal item)
        {
            animals.Add(item);
        }
        public IAnimal[] ToArray()
        {
            return animals.ToArray();
        }

    }
}
