// See https://aka.ms/new-console-template for more information
using System;

namespace HelloWorld
{
    class Program
    {
        static void table()
        {
            Console.WriteLine("Enter a number to print its table");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 1;i <= 10; i++)
            {
                Console.WriteLine(num + "*" + i + "=" + num*i);
            }
        }
        static void evenodd()
        {
            Console.WriteLine("Enter a number wether odd/even");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        }

        static void largeNum()
        {
            Console.WriteLine("Enter 3 numbers to check larger one");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            if(num1 > num2 && num1 < num3)
            {
                Console.WriteLine("Num1 is larger " +  num1);
            }

            else if(num2 > num1 && num2 > num3)
            {
                Console.WriteLine("Num2 is larger " + num2);
            }

            else { Console.WriteLine("Num3 is larger " + num3); }
        }

        static void sum()
        {
            Console.WriteLine("Enter number for total sum 1 to number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i = 1;i <= num; i++)
            {
                sum += i;
            }
            Console.WriteLine("Total sum " + sum);
        }

        static void reverse()
        {
            Console.WriteLine("Enter number to reverse");
            int num = Convert.ToInt32(Console.ReadLine());
            int rev = 0;
            while(num > 0)
            {
                int digit = num % 10;
                rev = (rev * 10) + digit;
                num /= 10;
            }

            Console.WriteLine("Reverse number " + rev);
        }

        static void factorial()
        {
            Console.WriteLine("Enter number for factorial");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 0 || num == 1)
            {
                Console.WriteLine("Factorial is " + 1);
            }
            int fact = 1;
            for(int i = 1;i <= num; i++)
            {
                fact *= i;
            }

            Console.WriteLine("Factorial is " + fact);
        }

        static void leap()
        {
            Console.WriteLine("Enter year");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine("Year is Leap");
            }
            else
            {
                Console.WriteLine("Not a leap year");
            }
        }

        static void prime()
        {
            Console.WriteLine("Enter number to check prime");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 2) 
            {
                Console.WriteLine("Not prime");
            }
            for (int i = 2; i < num; i++)
            {
                if(num % i == 0)
                {
                    Console.WriteLine("Not prime");
                }
            }

            Console.WriteLine("Prime");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter task number");
            int task = Convert.ToInt32(Console.ReadLine());
            switch (task)
            {
                case 1:
                    table();
                    break;
                case 2:
                    evenodd();
                    break;
                case 3:
                    largeNum();
                    break;
                case 4:
                    sum();
                    break;
                case 5:
                    reverse();
                    break;
                case 6:
                    factorial();
                    break;
                case 7:
                    leap();
                    break;
                case 9:
                    prime();
                    break;
            }
        }
    }
}
