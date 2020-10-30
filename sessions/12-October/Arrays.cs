using System;

namespace SkillTraining {
   class MyArray {
      
      public void CreateArrays() {
         int [] n = new int[10]; /* n is an array of 10 integers */
         int index = 0,j;

         /* initialize elements of array n */

         // for ( initialize variables, condition to meet, what to do after each iteraction)
         for ( ;index < 10; index++ ) {
            n[index] = index + 100;
         }

         Console.WriteLine(string.Join("-", n));
         
         /* output each array element's value */
         for (j = 0; j < 10; j++ ) {
            Console.WriteLine("Element[{0}] = {1}", j, n[j]);
         }

         // Console.ReadKey();
      }
   }
}