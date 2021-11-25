using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignment
{
    internal class PrimeNumber
    {
        public void prime()
        {
            Console.WriteLine("Enter any number to check whether it prime or not!!!");
            int n=Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if(n%i == 0)
                    count++;

            }
            if (count == 2)
                Console.WriteLine(n+" is a prime number.");
            else
                Console.WriteLine(n+" is not a prime number.");
        }
    }
}
