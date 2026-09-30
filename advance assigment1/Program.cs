namespace advance_assigment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1
            //a)class ...<t> , using multibale type instead of using one type
            #endregion
            #region question 2
            continer<int> cont1 = new continer<int>();
            cont1.add(10);
            Console.WriteLine(cont1.get());
            #endregion
            #region question 3
            pair<int, string> pair1 = new pair<int, string>();
            pair1.key = 10;
            pair1.value = "ahmed";
            Console.WriteLine(pair1.key);
            Console.WriteLine(pair1.value); 
            #endregion
        }
        
    }
}
