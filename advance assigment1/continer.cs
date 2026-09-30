using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advance_assigment1
{
    internal class continer<T>
    {
        private T Value;
        public void add(T item)
        {
            Value = item;
        }
        public T get()
        {
            return Value;
        }

    }
}
