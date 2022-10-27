using System;

namespace Homeworkstuffs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input numbers
            int numbers = int.Parse(Console.ReadLine());
            decimal p1 = 0;
            decimal p2 = 0;
            decimal p3 = 0;
            decimal p4 = 0;
            decimal p5 = 0;
            for (int i = 0; i < numbers; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                if (inputNumber < 200)
                {
                    p1++;
                }
                else if (inputNumber <= 399 && inputNumber >= 200)
                {
                    p2++;
                }
                else if (inputNumber >= 400 && inputNumber <= 599)
                {
                    p3++;
                }
                else if (inputNumber >= 600 && inputNumber <= 799)
                {
                    p4++;
                }
                else if (inputNumber >= 800)
                {
                    p5++;
                }
                else
                {
                    Console.WriteLine("Invalid Number");
                }
            }

            decimal result1 = p1 / numbers * 100;
            Console.WriteLine($"{result1.ToString("0.00")}%");
            decimal result2 = p2 / numbers * 100;
            Console.WriteLine($"{result2.ToString("0.00")}%");
            decimal result3 = p3 / numbers * 100;
            Console.WriteLine($"{result3.ToString("0.00")}%");
            decimal result4 = p4 / numbers * 100;
            Console.WriteLine($"{result4.ToString("0.00")}%");
            decimal result5 = p5 / numbers * 100;
            Console.WriteLine($"{result5.ToString("0.00")}%");
        }
    }
}
