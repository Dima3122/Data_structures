using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var hashTable = new HashTable<string>(100);
            hashTable.Add("ПРИВЕТ МИР");
            hashTable.Add("ПРИВЕТ МИР Я ЖИВОЙ");
            Console.WriteLine(hashTable.Search("ПРИВЕТ МИР Я ЖИВОЙ")); 
        }
    }
}
