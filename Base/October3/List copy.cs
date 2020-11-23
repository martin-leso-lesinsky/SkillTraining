using System;
using System.Collections.Generic;
using System.Linq;

namespace SkillTraining.Base.October3
{
    public class MyList12
    {
        public IEnumerable<int> Items { get; private set; }

        public void CreateList()
        {
            var array = new int[3];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            Items = array;
            Display();

            var list = new List<int>();
            list.Add(5);
            list.Add(7);
            list.Add(9);
            Items = list;
            Display();
        }

        //static
        void Display()
        {
            Console.WriteLine("Count: {0}", Items.ToList().Count);
            foreach (int value in Items)
            {
                Console.WriteLine(value);
            }
            Items.ToList().Clear();
        }
    }
}
