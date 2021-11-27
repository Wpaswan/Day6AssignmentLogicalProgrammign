using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignment
{
    internal class TemperatureConversion
    { public static  void Temperature_Coversion()
        {
            Console.WriteLine("\t(((((((   Please Select  any        )))))))");
            Console.WriteLine("\t(((((((   1.Celcius to Fahrenheit   )))))))");
            Console.WriteLine("\t(((((((   1.Fahrenheit to Celcius   )))))))");
            int ch=Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("\tEnter the temperature in celcius");
                    double c=Convert.ToDouble(Console.ReadLine());
                    double f = (c*9/5)+32;
                    Console.WriteLine("Temperature in Fahrenheit="+f);
                    break;
                    case 2:
                    Console.WriteLine("\tEnter the temperature in Fahrenheit");
                    double fr = Convert.ToDouble(Console.ReadLine());
                    double cel = (fr-32)*9/5;
                    Console.WriteLine("Temperature in Celcius="+cel);
                    break;
            }


        }
    }
}
