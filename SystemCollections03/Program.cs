using System;
using System.Collections;
using System.Collections.Generic;

namespace SystemCollections03
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,double> accaunt = new Dictionary<int, double>();
            accaunt.Add(1213,8.3444);
            accaunt.Add(12134,9.3444);
            accaunt.Add(12135,10.3444);

            foreach (KeyValuePair<int, double> i in accaunt)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("sorted");

            SortedList<int,double> accaunt2 = new SortedList<int, double>();
            accaunt2.Add(12135, 10.3444);
            accaunt2.Add(1213, 8.3444);
            accaunt2.Add(12134, 9.3444);
            

            foreach (KeyValuePair<int, double> i in accaunt2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
