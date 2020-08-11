using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace SystemCollections04
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderedDictionary dictionary = new OrderedDictionary();
            dictionary.Add("A",1);
            dictionary.Add("B",2);
            dictionary.Add("C",3);
            dictionary.Add("D",4);

            foreach (DictionaryEntry i in dictionary)
            {
                Console.WriteLine($"{i.Key}  {i.Value}");
            }
        }
    }
}
