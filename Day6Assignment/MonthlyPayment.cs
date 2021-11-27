using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignment
{
    internal class MonthlyPayment
    {
        public void MonthlyInstallment(int p,int y,int R)
        {
            //int n = 12*y;
            //double r = R/(1200);
            //double s =(double) Math.Pow(1+r, -n);
            //double payment = p*r/(1-s);
            //Console.WriteLine("Monthly installment="+payment+" "+s);
            Console.Out.Write("\n Lone Ammount : "+p);
            //paid_monthly_rate = Convert.ToDouble((1/100));
            Console.Out.Write("\n Monthly intrast rate : " + R);
            Console.Out.Write("\n Number of Monthly instalment : " + y);
            double val = Convert.ToDouble(Math.Pow((1 + R), y));

            double payment = Convert.ToDouble(R * val * p / (val - 1));


            Console.Out.Write("\n Ammount paid back : " + payment*y);
            Console.Out.Write("\n Intrast Ammount : " + ((payment*y)-p));
            Console.Out.Write("\n Monthly Payment : " + (payment));

        }
    }
}
