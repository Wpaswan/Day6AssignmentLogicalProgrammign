// See https://aka.ms/new-console-template for more information
using Day6Assignment;
Console.WriteLine("\t((((((Please select any one))))))");
Console.WriteLine("\t((((((1.Fibbo Series       ))))))");
Console.WriteLine("\t((((((2.Perfect Number     ))))))");
Console.WriteLine("\t((((((Please select any one))))))");
int ch=Convert.ToInt32(Console.ReadLine());
switch(ch){
    case 1:
FibbonacciSeries fs = new FibbonacciSeries();
fs.Fibbo();
        break; ;
            case 2:
PerfectNumber pf=new PerfectNumber();
pf.Perfect();
        break;
}