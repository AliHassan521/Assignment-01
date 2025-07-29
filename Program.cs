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

        static void fibonacci()
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            int a = 0,b = 1;
            for(int i = 0;i < num;i++){
                Console.Write(a + " ");
                int c = a + b;
                a = b;
                b = c;
            }
        )

        static void prime()
        {
            Console.WriteLine("Enter number to check prime");
            int num = Convert.ToInt32(Console.ReadLine());
            bool isPrime = num > 1;
            for (int i = 2; i < num; i++)
            {
                if(num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine(isPrime ? "Prime" : "Not prime");
        }

        static void GCD(){
        Console.WriteLine("Enter two numbers to get gcd");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        while(num2 != 0){
            int temp = num2;
            num2 = num1 % temp;
            num1 = temp;
          }
          Console.WriteLine("GCD " + num1);
        }

        static void calculator(){
        Console.WriteLine("Enter two numbers");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        char op = Console.ReadLine()[0];
        
        switch(op){
            case '+':
               Console.WriteLine(a + b);
               break;
            case '-':
               Console.WriteLine(a - b);
               break;
            case '*':
               Console.WriteLine(a * b);
               break;
            case '/':
               Console.WriteLine(a / b);
               break;
            case '%':
               Console.WriteLine(a % b);
               break;
            default:
               Console.WriteLine("Invalid input");
               break;
        }
    }

        static void digCount(){
        Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while(num > 0)
            {
                int digit = num % 10;
                count++;
                num /= 10;
            }

            Console.WriteLine("Total digits " + count);
    }

            static void palindrom()
        {
            Console.WriteLine("Enter number to check palindrom");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int rev = 0;
            while(temp > 0)
            {
                int digit = temp % 10;
                rev = (rev * 10) + digit;
                temp /= 10;
            }
            
            if (num == rev){
                Console.WriteLine("Palindrom");
            }
            else{
                Console.WriteLine("Not a palindrom");
            }
            
        }

            static void digSum()
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while(num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine("digit sum " + sum);
        }

            static void armstrong()
        {
            Console.WriteLine("Enter number to reverse");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int sum = 0;
            while(temp > 0)
            {
                int digit = temp % 10;
                sum += digit * digit * digit;
                temp /= 10;
            }
            if(num == sum){
                Console.WriteLine("Armstrong");
            }
            else{
                Console.WriteLine("Not Armstrong");
            }
        }

            static void minmax()
        {
            Console.WriteLine("Enter array size");
            int n = Convert.ToInt32(Console.ReadLine());
             int[] arr = new int[n];
            for(int i = 0;i < n;i++){
               arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = arr[0], min = arr[0];
            foreach(int num in arr){
                if(num > max){ max = num; }
                if(num > min){ min = num; }
            }
            Console.WriteLine($"Max in array is {max} and Min in array is {min}");
        }

            static void linearSerach()
{
    Console.WriteLine("Enter search number");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] arr = {1,2,4,7,8,5,0,3};
    bool isFound = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == n) {
            isFound = true;
            break;
        }
    }

    Console.WriteLine(isFound ? "Found" : "Not found");
}

            static void sorting()
{
    int[] arr = { 1, 2, 4, 7, 8, 5, 0, 3 };
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0;j < arr.Length; j++)
        {
            if (arr[j] > arr[i])
            {
               (arr[j], arr[i]) = (arr[i], arr[j]);
            }
        }
    }

    for(int i = 0;i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

            static void evenoddCount()
{
    int[] arr = { 1, 2, 4, 7, 8, 5, 0, 3 };
    int even = 0, odd = 0;
    foreach(int num in arr)
    {
       if(num % 2 == 0) {  even++; }
       else { odd++; }
    }

    Console.WriteLine($"Total even {even} and total odd {odd}");
}

             static void sortName()
 {
     List<string> names = new List<string> { "Ali", "Hassan", "Azhar", "Rizwan" };
     names.Sort();
     foreach(string name in names)
     {
         Console.WriteLine(name);
     }
 }

            static void frequency()
{
    int[] arr = { 1, 2, 2, 3, 1, 4, 2, 5, 3 };
    Dictionary<int, int> freq = new Dictionary<int, int>();
    foreach (int num in arr)
    {
        if (freq.ContainsKey(num))
        {
            freq[num]++;
        }
        else
        {
            freq.Add(num, 1);
        }
    }
    Console.WriteLine("Element Frequencies:");
    foreach (KeyValuePair<int, int> entry in freq)
    {
        Console.WriteLine($"Element: {entry.Key}, Frequency: {entry.Value}");
    }
}

            static void strPalindrom()
{
    Console.WriteLine("Enter string");
    string str = Console.ReadLine();
    string s = "";
    for (int i = str.Length - 1;i >= 0;i--)
    {
        s += str[i];
    }

    Console.WriteLine(s == str ? "Palindrom" : "Not palindrom");
}

            static void matrix()
{
    int[,] a = { { 1, 2, 3, }, { 4, 5, 6 } };
    int[,] b = { { 1, 2, 3, }, { 4, 5, 6 } };

    int[,] sum = new int[3, 3];

    for(int i = 0;i < 3; i++)
    {
        for(int j = 0;j < 3; j++)
        {
            sum[i,j] = a[i, j] + b[i, j];
            Console.Write(sum[i,j] + " ");
        }
        Console.WriteLine();
    }
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
                case 8:
                    fibonacci();
                    break;
                case 9:
                    prime();
                    break;
                case 10:
                    GCD();
                    break;
                case 11:
                    calculator();
                    break;
                case 12:
                    digCount();
                    break;
                case 13:
                    palindrom();
                    break;
                case 14:
                    digSum();
                    break;
                case 15:
                    armstrong();
                    break;
                case 16:
                    minmax();
                    break;
                case 17:
                    linearSearch();
                    break;
                case 18:
                    sorting();
                    break;
                case 19:
                    evenoddCount();
                    break;
                case 20;
                    sortName();
                    break;
                case 21:
                    frequency();
                    break;
                case 22:
                    vowelCount();
                    break;
                case 23:
                    strPalindrom();
                    break;
                case 24:
                    matrix();
                    break;
            }
        }
    }
}
