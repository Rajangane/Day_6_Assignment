using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Assignment
{
    internal class Prime
    {
        public void displayPrime()
        {
            int num;
            Console.Write("Enter a number to check Prime or not: ");
            num = int.Parse(Console.ReadLine());
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(num + " is not a Prime Number");
                    return;
                }
            }
            Console.WriteLine(num + " is a Prime Number");
        }
    }
}
