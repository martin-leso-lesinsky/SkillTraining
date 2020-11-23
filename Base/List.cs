using System;
using System.Collections.Generic;

namespace SkillTraining.Base {
    public class MyList
    {
        public List<int> Items{get; private set;}

        public void CreateList()
        {   
            var array = new int[3];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            Items = new List<int>(array); //array.ToList(); 
            
            // druha alternativa
            Items = new List<int>();
            Items.AddRange(array);   
                        
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
            Console.WriteLine("Count: {0}", Items.Count);
            foreach (int value in Items)
            {
                Console.WriteLine(value);
            }
            Items.Clear();
        }
    }
}
