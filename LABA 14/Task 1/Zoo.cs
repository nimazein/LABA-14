using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Zoo
    {
        private List<Sections> zooo = new List<Sections>();
        public List<Sections> Zooo
        {
            get
            {
                return zooo;
            }
        }
        public int Count { get { return zooo.Count; } }

        public void Add(Sections section)
        {
            zooo.Add(section);
        }
        public bool Contains(Sections section)
        {
            return zooo.Contains(section);
        }
    }
}
