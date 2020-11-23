using System;

namespace SkillTraining.Base
{
    class DefaultValue
    {
        public void Default()
        {
            Console.WriteLine(default(int));  // output: 0
            Console.WriteLine(default(object) is null);  // output: True

            void DisplayDefaultOf<T>()
            {
                var val = default(T);
                Console.WriteLine($"Default value of {typeof(T)} is {(val == null ? "null" : val.ToString())}.");
            }

            DisplayDefaultOf<int?>();
            DisplayDefaultOf<System.Numerics.Complex>();
            DisplayDefaultOf<System.Collections.Generic.List<int>>();
            // Output:
            // Default value of System.Nullable`1[System.Int32] is null.
            // Default value of System.Numerics.Complex is (0, 0).
            // Default value of System.Collections.Generic.List`1[System.Int32] is null.
        }
    }
}