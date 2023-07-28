using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesGeneratorLibrary
{
    public class PrimesGenerator
    {
        public Int64 GeneratePrimes(int max)
        {
            //Varianle to store the primes generated.
            List<Int64> primeNumbers = new List<Int64>() { 2 };


        // bool to flag when a prime is found.
        bool pFlag = false;

            for (Int64 i = 3; i<(max); i = i + 2)
            {
                foreach (Int64 prime in primeNumbers)
                {
                    if (i % prime == 0)
                    {
                        break;
                    }
                    if (prime > Math.Sqrt(i))
                    {
                        pFlag = true;
                        break;
                    }
                    
                }
                if (pFlag)
                {
                    pFlag = false;
                    if (i - primeNumbers.Last() == 2)
                    {
                        Console.WriteLine($"{primeNumbers.Last()} and {i}");
                    }
                    primeNumbers.Add(i);
                }
            }

            Console.WriteLine(primeNumbers.Last());
            Console.ReadLine();
            return(primeNumbers.Last());
        }
    }
}
