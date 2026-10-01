namespace advance_assigment1
{
   
    internal class Program
    {
        static void swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;

        }

        static max findmax<max> (ref max a,ref max b)where max:IComparable<max>
        {
            if ( a.CompareTo(b)>0 )
            {
                return a;
            }
            return b;
        }
        #region question 7
        // struct is a constriant for value type 
        static void print<T> (T x ) where T:struct
        {
            Console.WriteLine(x); // مينفعش في المان ندخل ال اكس دي بي حاجه سترينج او ريفرنس تايب
        }
        #region question 8 
        // class is a constriant for a refrence type
        static void printclass<T>(T y) where T : struct
        {
            Console.WriteLine(y); // مينفعش في المان ندخل ال الواي دي بي حاجه فاليو تايب
        }
        #endregion
        #endregion
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
            #region question 4
            int a = 10;
            int b = 20;
            swap(ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);
            #endregion
            #region question 5
            Console.WriteLine(findmax(ref a, ref b));
            #endregion
            #region question 6
            // inteface that use genric type and any class implement them spicify type argument 
            printresporatry printresporatry = new printresporatry();
            printresporatry.print("mohamed");
            #endregion
            
        }
        
    }
}
