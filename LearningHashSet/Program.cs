using System;
using System.Collections.Generic;

namespace LearningHashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            var myHash = new HashSet<String>();

            myHash.Add("Hello");
            myHash.Add("Hello");

            String[] s = new String[] { "Hello" };  

            Console.WriteLine(myHash.Count);

            Console.WriteLine(myHash.Overlaps(s));

        }
    }
}
