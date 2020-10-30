using System;
using System.Collections.Generic;


namespace SkillTraining {

    class MyList3

    {
        public void RemoveFromList()
        {
            var numbers = new List<int>() { 10, 20, 30 };

            // Remove this element by value.
            numbers.Remove(20);

            foreach (int number in numbers)
            {
                Console.WriteLine("NOT REMOVED: {0}", number);
            }

            // This has no effect.
            numbers.Remove(2000);
        }
    }
}