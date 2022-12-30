using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Switch case using Arithmatic operation

            Console.WriteLine("1. Add");
            Console.WriteLine("2. Sub");
            Console.WriteLine("3. Mul");
            Console.WriteLine("4. Div");
            Console.WriteLine("5. Mod");
            Console.WriteLine("Select your option from 1- 5");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of A");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of B");
            int B = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Add =" + (A + B));
                    break;
                case 2:
                    Console.WriteLine("Sub =" + (A - B));
                    break;
                case 3:
                    Console.WriteLine("Mul =" + (A * B));
                    break;
                case 4:
                    Console.WriteLine("Div =" + (A / B));
                    break;
                case 5:
                    Console.WriteLine("Mod =" + (A % B));
                    break;
                default:
                    Console.WriteLine("Wrong option select");
                    break;
            }




            // WAP to print numbers from 1 - 10

            Console.WriteLine("Enter a No");
            int i = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i <= 10; i++)
            {
                Console.WriteLine($"{i}");
            }


            // WAP to print even numbers from 1.- 50

            Console.WriteLine("Enter a No");
            int j = Convert.ToInt32(Console.ReadLine());

            for (j = 2; j <= 50; j++)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine($"{j}");
                }
            }

            // WAP to print odd numbers from 1- 50

            Console.WriteLine("Enter a No");
            int k = Convert.ToInt32(Console.ReadLine());
            for (k = 3; k <= 50; k++)
            {
                if (k % 2 == 1)
                {
                    Console.WriteLine($"{k}");
                }
            }


            // WAP to print series from 100- 50

            Console.WriteLine("Enter a No");
            int m = Convert.ToInt32(Console.ReadLine());
            for (m = 100; m > 50; m--)
            {
                Console.WriteLine($"{m}");
            }


            // Accept a number & print its table

            Console.WriteLine("Enter a No");
            int Num = Convert.ToInt32(Console.ReadLine());
            int n;

            for (n = 1; n <= 10; n++)
            {
                Console.WriteLine($"{n*Num}");
            }


            // Print 1-20 and sum avg

            Console.WriteLine("Enter a No");
            int O = Convert.ToInt32(Console.ReadLine());
            double total=0;
            double avg;
            for (O = 1; O <= 20; O++)
            {
                Console.WriteLine($"{O}");
                total = total + O;
            }
            Console.WriteLine($"sum = {total}");
            avg = total / 20;
            Console.WriteLine($"avg = {avg}");







        }
    }
}
