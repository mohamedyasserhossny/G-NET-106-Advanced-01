using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advance_assigment1
{
    internal class safelist<T>
    {
        public List<T> itmes= new List<T>();
         public void add(T item)
        {
           


                itmes.Add(item);
            }
        public T get(int index)
        {
            if (index>=0&&index<itmes.Count)
            {
                return itmes[index];
            }
            return default;
        }
            
            
        }

    }

