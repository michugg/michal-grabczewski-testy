using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestyGlobal;

namespace testyGlobal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LiczbyPierwsze test = new LiczbyPierwsze();
            Console.WriteLine(test.Test("1")); //ok
            Console.ReadLine();
        }
    }
}