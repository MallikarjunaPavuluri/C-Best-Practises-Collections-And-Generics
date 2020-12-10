using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataBase
{
    public class  DoubleSpring : IEnumerable
    {
        String[] names = new string[10];
        private int index;
        public DoubleSpring()
        {
            index = 0;
        }
        public int Count()
        {
            int count = 0;
            for (int i = 0; i < index; i++)
            {
                if (names[i]!=null)
                {
                    count++;
                }
            }
            return count;
        }
        public String this[int n]
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
        public void Add(String s)
        {
            names[index] = s;
            index++;
        }

        public IEnumerator GetEnumerator()
        {
            return new SpringEnumerator(this);
        }
    }
    public class SpringEnumerator : IEnumerator
    {

        DoubleSpring DS;
        int index;
        String item;
       
        public SpringEnumerator(DoubleSpring ds)
        {
            DS = ds;
            index = -1;
        }
        public object Current => item;

        public bool MoveNext()
        {
            if(index++<=DS.Count())
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
            DoubleSpring ds = new DoubleSpring();
            Console.WriteLine("Enter Name-");
            var input = Console.ReadLine();
            ds.Add(input);
            Console.WriteLine("Enter Name-");
            input = Console.ReadLine();
            ds.Add(input);
            Console.WriteLine("Enter Name-");
            input = Console.ReadLine();
            ds.Add(input);
            Console.WriteLine("Enter Name-");
            input = Console.ReadLine();
            ds.Add(input);
            Console.WriteLine("Enter Name-");
            input = Console.ReadLine();
            ds.Add(input);
            foreach(var i in ds)
            {
                Console.WriteLine(i);
            }


        }
    }
}
