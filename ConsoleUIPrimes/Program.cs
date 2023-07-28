using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimesGeneratorLibrary;

namespace ConsoleUIPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimesGenerator primesgenerator = new PrimesGenerator();
            primesgenerator.GeneratePrimes(10000);
        }
    }
}
