
using Day6Assignment;
Console.WriteLine("\t((((((Please select any one   ))))))");
Console.WriteLine("\t((((((1.Fibbo Series          ))))))");
Console.WriteLine("\t((((((2.Perfect Number        ))))))");
Console.WriteLine("\t((((((3.Prime Number          ))))))");
Console.WriteLine("\t((((((4.Reverse Number        ))))))");
Console.WriteLine("\t((((((5.Coupon Number         ))))))");
Console.WriteLine("\t((((((6.Stop Watch            ))))))");
Console.WriteLine("\t((((((7.Vending Machine       ))))))");
Console.WriteLine("\t((((((8.Grigorian Calender    ))))))");
Console.WriteLine("\t((((((9.Temprature Conversion ))))))");
Console.WriteLine("\t((((((10.Monthly installment  ))))))"); 
Console.WriteLine("\t((((((11.Number conversin     ))))))");

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
        GrigorianCalender gc = new GrigorianCalender();
        Console.WriteLine("Enter date:");
        int d = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter month:");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter year:");
        int y = Convert.ToInt32(Console.ReadLine());
        gc.grig(d, m, y);



        break;
    case 9:
        TemperatureConversion tem=new TemperatureConversion();
        TemperatureConversion.Temperature_Coversion();
        break;
    case 10:
        MonthlyPayment mn=new MonthlyPayment();
        Console.WriteLine("Enter principal year and rate%");
        int pr=Convert.ToInt32(Console.ReadLine());
        int yr=Convert.ToInt32(Console.ReadLine());
        int rate=Convert.ToInt32(Console.ReadLine());

        mn.MonthlyInstallment(pr,yr,rate);
        break;
    case 11:
        NumberConversion num=new NumberConversion();
        NumberConversion.toBinary();
        break;

}