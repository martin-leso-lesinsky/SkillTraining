namespace SkillTraining
{
    public class Sessions
    {
        public void ExecuteTransactions()
        {
            Transaction t =  new Transaction();
            t.ShowTransaction();
        }

        public void ExecuteArrays()
        {
            MyArray myArray = new MyArray();
            myArray.CreateArrays();
        }
    }
}