using System;

namespace SkillTraining.Base.November4
{
    class TryCatch
    {
        public void TryCatch1()
        {
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}