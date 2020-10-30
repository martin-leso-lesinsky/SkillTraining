using System;

namespace SkillTraining
{
    class Tester {
     
      static void Transactions(string[] args) {
         Transaction t1 = new Transaction("001", "8/10/2012", 78900.00);
        Transaction t2 = new Transaction("002", "9/10/2012", 451900.00);
         
         t1.ShowTransaction();
         t2.ShowTransaction();
         Console.ReadKey();
      }
   }
}