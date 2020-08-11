using System;
using System.Collections;

namespace SystemCollectionsAdditional
{
    class Program
    {
        static void Main(string[] args)
        {
            var sortedList = new SortedList();
            sortedList.Add(1,"A");
            sortedList.Add(2,"B");
            sortedList.Add(3,"C");
            sortedList.Add(4,"D");
            sortedList.Add(-1,"Z");

            foreach (DictionaryEntry i in sortedList)
            {
                Console.WriteLine($"{i.Key} {i.Value}");
            }

            Console.WriteLine("\ndescending\n");

            var sortedList2 = new SortedList(new DescendingComparer());

            sortedList2.Add(1, "A");
            sortedList2.Add(2, "B");
            sortedList2.Add(3, "C");
            sortedList2.Add(4, "D");
            sortedList2.Add(-1, "Z");

            foreach (DictionaryEntry i in sortedList2)
            {
                Console.WriteLine($"{i.Key} {i.Value}");
            }
        }
    }
}
