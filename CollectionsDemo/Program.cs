using System;
using System.Collections.Generic;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Names = new List<string>();

            Names.Add("Linus Torvalds");
            Names.Add("Donald Knuth");
            Names.Add("Grace Hopper");

            printList(Names);
            Console.WriteLine("\n\nPrior to adding names");
            Console.WriteLine("Count of list: " + Names.Count.ToString());
            Console.WriteLine("Capacity of list: " + Names.Capacity.ToString());

            Names.Add("Donald Knuth");
            Names.Add("Jean Bartik");

            Console.WriteLine("\n\nPost adding names");
            Console.WriteLine("Count of list: " + Names.Count.ToString());
            Console.WriteLine("Capacity of list: " + Names.Capacity.ToString());

            Names.TrimExcess();

            Console.WriteLine("\n\nTrimExcess()");
            Console.WriteLine("Count of list: " + Names.Count.ToString());
            Console.WriteLine("Capacity of list: " + Names.Capacity.ToString());

            showList(Names);

            Names.RemoveAt(3);
            Console.WriteLine("\n\nperform Names.RemoveAt(3)");

            showList(Names);

            Names.Remove("Donald Knuth");
            Console.WriteLine("\n\nperform Names.Remove on Donald Knuth string");

            showList(Names);



        }
        //refactored into function by ide
        private static void printList(List<string> Names)
        {
            for (int i = 0; i < Names.Count; i++)
            {
                Console.WriteLine(Names[i]);
            }
        }

        //wrote showList by hand to see if i could do it (did prior to refactoring above)
        private static void showList(List<string> Stuff)
        {
            Console.WriteLine("\n\nWhat's in my List?");
            foreach (string item in Stuff)
            {
                Console.WriteLine(item);
            }
        }

    }
}
