using System;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Lucas");
            list.Add("Ana");
            list.Add("Maya");
            list.Insert(1, "Lua");
            list.Insert(2, "Ed");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'L');
            Console.WriteLine("First L: " + s1);

            string s2 = list.FindLast(x => x[0] == 'L');
            Console.WriteLine("Last L: " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'L');
            Console.WriteLine("First position 'L': " + pos1);

            int pos2 = list.FindLAstIndex(x => x[0] == 'L');
            Console.WriteLine("Last position 'L': " + pos2);


        }
    }
}
