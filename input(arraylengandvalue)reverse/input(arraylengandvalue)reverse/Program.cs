using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace input_arraylengandvalue_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= b; i++)
            {
                a =  b*i;
                Console.WriteLine(a);
                a = b;
                
            }

        }
    }
}
