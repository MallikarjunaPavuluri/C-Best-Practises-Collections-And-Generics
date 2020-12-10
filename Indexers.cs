using System;
using System.Linq;

namespace DataBase
{
    class DoubleSpring
    {
        String[] names = new string[10];
        private int index;
        public DoubleSpring()
        {
            index = 0;
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
    }

    class Program
    {
        public static void Main(String[] args)
        {
            DoubleSpring ds = new DoubleSpring();
            ds.Add("Mallikarjuna");
            ds.Add("Ram");
            ds.Add("Arjun");
            ds.Add("Vamshi");
            for(int i=0;i<4;i++)
            {
                Console.WriteLine(ds[i]);
            }


        }
    }
}
