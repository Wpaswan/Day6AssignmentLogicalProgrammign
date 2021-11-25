// See https://aka.ms/new-console-template for more information
using Day6Assignment;
Console.WriteLine("\t((((((Please select any one))))))");
Console.WriteLine("\t((((((1.Fibbo Series       ))))))");
Console.WriteLine("\t((((((2.Perfect Number     ))))))");
Console.WriteLine("\t((((((3.Prime Number       ))))))");
Console.WriteLine("\t((((((3.Reverse Number     ))))))");
Console.WriteLine("\t((((((3.Prime Number       ))))))");

int ch =Convert.ToInt32(Console.ReadLine());
switch(ch){
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

}