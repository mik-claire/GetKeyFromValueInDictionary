using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetKeyFromValueInDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Init
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("key01", 100);
            dic.Add("key02", 200);
            dic.Add("key03", 300);
            dic.Add("key04", 400);
            dic.Add("key05", 100);
            dic.Add("key06", 600);
            foreach (string key in dic.Keys)
            {
                Console.WriteLine("key: {0}\tvalue: {1}", key, dic[key]);
            }
            Console.WriteLine();

            // Set value
            int value = 100;
            Console.WriteLine("\t\tvalue: {0}", value);

            // Search
            foreach (string key in dic.Keys)
            {
                if (dic[key] == value)
                {
                    // Hit
                    Console.WriteLine("key: {0}", key);
                }
            }

            Console.ReadLine();
        }
    }
}
