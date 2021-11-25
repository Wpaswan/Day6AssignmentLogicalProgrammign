using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignment
{
    internal class CouponNum
    {
        public  void ReadNumOfCoupons()
        {
            Console.WriteLine("Enter a number for distinct coupons");
            int couponNo=Convert.ToInt32(Console.ReadLine());
            FindOutRandomCount(couponNo);

        }
        private static void FindOutRandomCount(int couponNo)
        {
            int distinct = 0, count = 0;
            bool[] isCollected=new bool[couponNo]; 
            while(distinct<couponNo)
            {
                Random random = new Random();
                int newRandom=Convert.ToInt32(random.Next(0,couponNo));
                count++;
                if(!isCollected[newRandom])
                {
                    distinct++;
                    isCollected[newRandom]=true;
                }

            }
            Console.WriteLine("Total random number needed to have all distinct coupons: "+count);
        }
    }
}
