using System;
using System.Collections.Generic;

namespace Trainingwithcshap
{
    class TStorage<T>
    {
        private T item1;
        private T item2;
        public TStorage(T a, T b)
        {
            item1 = a;
            item2 = b;
            Console.WriteLine($"Item1-{item1} Item2-{item2}");
        }
    }
    class Storage
    {
      private   List<String> names = new List<String>();
      private   Dictionary<int ,String> subjects = new Dictionary<int, string>();
        public void CollectInfo()
        {
            int n = 0;
            Console.WriteLine("Eneter Name-");
            var input = Console.ReadLine();
            names.Add(input);
            Console.WriteLine("Eneter Key-");
             input = Console.ReadLine();
            while(!(int.TryParse(input,out n)))
            {
                Console.WriteLine("Enter Valid Data");
                input = Console.ReadLine();
            }
            Console.WriteLine("Eneter Value-");
            input = Console.ReadLine();
            subjects.Add(n, input);


        }
        public void DisplayInfo()
        {
            Console.WriteLine("Names In Storage Class-");
            Console.WriteLine("--------------------------");
            foreach (var i in names)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Key Value Pair In Storage Class-");
            Console.WriteLine("----------------------------------");
            foreach (var j in subjects)
            {
                Console.WriteLine(j);
            }
        }


    }
    class Program
    {
        static void Main(String [] args)
        {
            TStorage<int> s = new TStorage<int>(1, 2);
            Storage s1 = new Storage();
            s1.CollectInfo();
            s1.CollectInfo();
            s1.CollectInfo();
            s1.CollectInfo();
            s1.DisplayInfo();

        }
    
    }
}
