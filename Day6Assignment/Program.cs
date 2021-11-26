
using Day6Assignment;
Console.WriteLine("\t((((((Please select any one))))))");
Console.WriteLine("\t((((((1.Fibbo Series       ))))))");
Console.WriteLine("\t((((((2.Perfect Number     ))))))");
Console.WriteLine("\t((((((3.Prime Number       ))))))");
Console.WriteLine("\t((((((4.Reverse Number     ))))))");
Console.WriteLine("\t((((((5.Coupon Number      ))))))");
Console.WriteLine("\t((((((6.Stop Watch         ))))))");
Console.WriteLine("\t((((((7.Vending Machine    ))))))");
Console.WriteLine("\t((((((8.Bhawani            ))))))");


int Aloo =Convert.ToInt32(Console.ReadLine());
switch(Aloo){
    case 1:
FibbonacciSeries fs = new FibbonacciSeries();
fs.Fibbo();
        break; ;
            case 2:
PerfectNumber pf=new PerfectNumber();
pf.Perfect();
        break;
        case 3:
        PrimeNumber p=new PrimeNumber();
        p.prime();
        break;
            case 4:
        ReverseNumber r=new ReverseNumber();
        r.Reverse();
        break;
    case 5:
        CouponNum cn=new CouponNum();
       cn.ReadNumOfCoupons();


        break;
    case 6:
        StopWatch s=new StopWatch();
        s.RunProgram();
        break;
    case 7:
        Vendingmachine vm=new Vendingmachine();
        Console.WriteLine("Enter the amount:");
        int amount=Convert.ToInt32(Console.ReadLine());
        vm.countCurrency(amount);
        break;
    case 8:
        
        
        break;

}