using System;
using System.Collections.Generic;
namespace HashSet_
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> message = new HashSet<string>()
            {
                "hey buddy", "long time","have a good one", "Fred"
            };

            HashSet<string> message1 = new HashSet<string>()
            {
                "Man", "Liverpool", "Chelsea", "Fred"
            };

            message.Add("How are you");


            message.RemoveWhere(m => m.EndsWith("you"));// removes where method

            //search

           bool t= message.Contains("hey buddy");

            Console.WriteLine(t);

            foreach(var item in message)
            {
                Console.WriteLine(item);
            }

            // Intresextiom with method 
            Console.WriteLine("\n Intersection");
            message.IntersectWith(message1);
            foreach (var item in message)
            {
                Console.WriteLine(item);
            }


            // union with method 
            Console.WriteLine("\nunion");
            message.UnionWith(message1);
            foreach (var item in message)
            {
                Console.WriteLine(item);
            }







        }
    }
}
