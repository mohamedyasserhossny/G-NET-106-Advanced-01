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
    }
}
