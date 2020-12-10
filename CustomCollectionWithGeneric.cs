using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataBase
{
    
    public class DoubleSpring<T> : IEnumerable
    {

        T[] names = new T[10];
        private int index;
        private int mid;



        public DoubleSpring()
        {
            index = 0;
        }
        public int Count()
        {
            return index;
        }
        public T this[int n]
        {
            get
            {
                return names[n];
            }
            set
            {
                names[n] = value;
            }
        }
        public void Expand(T s)
        {
            mid = index / 2;
            index++;
            for (int i = index; i > mid; i--)
            {
                names[i] = names[i - 1];
            }
            names[mid] = s;
        }
        public void Compress()
        {
            int i = 0;
            for (i = mid; i < index; i++)
            {
                names[i] = names[i + 1];
            }
            names[i] = default(T);
            index--;

        }

        public IEnumerator GetEnumerator()
        {
            return new SpringEnumerator<T>(this);
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }
    }
    public class SpringEnumerator<T> : IEnumerator
    {

        DoubleSpring<T> DS;
        int index;
        T item;

        public SpringEnumerator(DoubleSpring<T> ds)
        {
            DS = ds;
            index = -1;
        }
        public object Current => item;

        public bool MoveNext()
        {
            if (++index < DS.Count())
            {
                item = DS[index];
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        public static void Main(String[] args)
        {
           
            DoubleSpring<int> ds1 = new DoubleSpring<int>();
            ds1.Expand(1);
            ds1.Expand(2);
            ds1.Expand(3);
            ds1.Expand(4);
            ds1.Expand(5);
            foreach (var k in ds1)
            {
                Console.WriteLine(k);
                Console.WriteLine("-------------");
            }
            ds1.Compress();
            foreach (var k in ds1)
            {
                Console.WriteLine(k);
                Console.WriteLine("-------------");
            }

        }
    }
}
