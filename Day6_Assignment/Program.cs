// See https://aka.ms/new-console-template for more information
//Console.WriteLine("************** Logical Programs *****************");
using Day6_Assignment;
FibonacciSeries fibo = new FibonacciSeries();
PerfectNum perf = new PerfectNum();
Prime pr = new Prime(); 
ReverseNum rev = new ReverseNum();  
Console.Write("Select Number:\n1)FibonacciSeries\n2)PerfectNumber\n3)PrimeNumber\n4)ReverseNumber\n");
int option = Convert.ToInt32(Console.ReadLine());
switch (option)
{
    case 1:
       FibonacciSeries.CalculateFibonacci();
        break;
   case 2:
        perf.Perfect();
        break;
   case 3:
        pr.displayPrime();
        break;
   case 4:
        rev.Reverse();
        break;

    default:
        Console.Write("Please Select Correct Number");
        break;
}

