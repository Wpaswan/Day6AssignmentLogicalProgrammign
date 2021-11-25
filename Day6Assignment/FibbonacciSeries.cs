using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignment
{
    internal class FibbonacciSeries
    {
        public void Fibbo()
        {
            int firstnumber = 0, secondnumber = 1, result = 0;
            Console.WriteLine("Enter the number terms");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.Write("Fibbo Series upto "+n+" terms is:\t");
            Console.Write(firstnumber);
            for (int i = 2; i<= n; i++)  // main processing starts from here
            {
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;
                Console.Write("\t"+result);
            }


        }
    }
}
