using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stars_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int answer = Convert.ToInt32(Console.ReadLine());

           for (int i = 0; i < answer; i++)
            {
               
                for (int x = 0; x<= i; x++)
                {
                    Console.Write("*");
                }
                Console.ReadLine();
            }

            
        }
    }
}
