using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advance_assigment1
{
    internal class printresporatry : iresporatory<string>
    {
        public void print(string value)
        {
            Console.WriteLine(value);
        }

        #region question 10
        // y must impelement interface
        static void testinteface<y>(y x) where y : iresporatory<y>
        {

        } 
        #endregion
    }
}
