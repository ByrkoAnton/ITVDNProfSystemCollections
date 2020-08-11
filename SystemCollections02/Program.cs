using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace SystemCollections02
{
    class Program
    {
        static void Main(string[] args)
        {
            NameValueCollection shop = new NameValueCollection();
            shop.Add("phone", "Anton");
            shop.Add("pen", "Andrey");
            shop.Add("phone", "Pavel");
            shop.Add("table", "Anton");
            shop.Add("mouse", "Anna");
            shop.Add("mouse", "Anna2");
            shop.Add("mouse", "Anna3");


            var customers = from i in shop.GetValues("phone") select i;
            foreach (var i in customers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
