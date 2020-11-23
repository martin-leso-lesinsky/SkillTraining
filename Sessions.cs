using System;
using SkillTraining.Base;
using SkillTraining.Base.November4;
using SkillTraining.Base.November5;
using SkillTraining.Base.October1;
using SkillTraining.Base.October2;
using SkillTraining.Base.October3;

namespace SkillTraining
{
    public class Sessions
    {
        public void ExecuteTransactions()
        {
            Transaction t = new Transaction();
            t.ShowTransaction();
        }

        public void ExecuteArrays()
        {
            MyArray myArray = new MyArray();
            myArray.CreateArrays();
        }

        public void ExecuteList()
        {
            MyList myList = new MyList();
            myList.CreateList();
        }

        public void ExecuteAddingElementsToList()
        {
            MyList2 myList2 = new MyList2();
            myList2.AddingElementsToList();
        }

        public void ExecuteRemoveFromList()
        {
            MyList3 myList3 = new MyList3();
            myList3.RemoveFromList();
        }

        public void ExecuteTryCatch()
        {
            TryCatchA tryCatcha = new TryCatchA();
            tryCatcha.TrayCatchA();
        }
        public void ExecuteDefaultValue()
        {
            DefaultValue defaultValue = new DefaultValue();
            defaultValue.Default();
        }

        // public void ExecutePolymorphism()
        // {
        //     Print printValue = new Print();
        //     printValue.Polymorphism(new string[]{});
        // }

        public void ExecuteShape()
        {
            Shape executeShape = new Shape();
            executeShape.Square(new double());
        }
    }
}