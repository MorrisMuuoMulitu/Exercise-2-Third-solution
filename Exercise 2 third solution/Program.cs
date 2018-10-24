using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2_b
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, divisor;
            char answer;
            do
            {
                Console.Write("enter a positive integer number: ");
                while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
                {
                    Console.WriteLine("wrong data, please give it again !");
                }

                Console.Write("enter the divisor (a positive integer) : ");
                while (!int.TryParse(Console.ReadLine(), out divisor) || divisor <= 0)
                {
                    Console.WriteLine("wrong data! please give it again");

                }
                if (number % divisor == 0)
                {
                    Console.WriteLine("the " + number + " divisible by " + divisor);
                }
                else
                {
                    Console.WriteLine("the " + number + " can not divide by" + divisor);
                }

                Console.Write("do you want to test other numbers ?(Y/N)");
                answer = char.Parse(Console.ReadLine());

            } while (answer == 'Y');
        }
    }
}