using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucky_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            if (arr[2]==7)
            {
                Console.WriteLine("Number is Lucky");
            }
            else
            {
                Console.WriteLine("Number is not Luky !!!!!!!!");
            }
        }
    }
}
