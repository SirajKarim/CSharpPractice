using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No to Find factorial");
            int a = int.Parse(Console.ReadLine());
            int fact = a;
            for (int i = 1; i < a; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of your no is:"+fact);
        }
    }
}
