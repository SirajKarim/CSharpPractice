using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array value");
            int a = int.Parse(Console.ReadLine());
            int[] arr = new int[4];
            for (int i = 0; i < 3; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            if (arr[0]==arr[1]||arr[2]==arr[3])
            {
                Console.WriteLine("YES");
            }
            if (arr[0] == arr[1] || arr[2] == arr[3] || arr[0] == arr[2] || arr[1] == arr[3]||arr[0] == arr[3])
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("no");
            }
            
            
        }
    }
}
