using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("1. FizzBuzz");
                Console.WriteLine("2. Percent");
                Console.WriteLine("3. GlueNumbers");
                Console.WriteLine("4. SixNumbers");
                Console.WriteLine("5. Date");
                Console.WriteLine("6. Temperature");
                Console.WriteLine("7. EvenNumbers");
                Console.WriteLine("0. Exit");
                Console.Write("Your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        FizzBuzz();
                        break;
                    case 2:
                        Percent();
                        break;
                    case 3:
                        GlueNumbers();
                        break;
                    case 4:
                        SixNumbers();
                        break;
                    case 5:
                        Date();
                        break;
                    case 6:
                        Temperature();
                        break;
                    case 7:
                        EvenNumbers();
                        break;
                    case 0:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (choice != 0);
        }

        static void FizzBuzz()
        {
            int number;
            bool works = true;
            while (works)
            {
                Console.WriteLine("enter a number:");
                number = Convert.ToInt32(Console.ReadLine());
                if (number >= 1 && number <= 100) works = false;
            }
            if (number % 3 == 0) Console.WriteLine("Fizz");
            else if (number % 5 == 0) Console.WriteLine("Buzz");
            else Console.WriteLine(number);
        }

        static void Percent()
        {
            int number, percent;
            Console.WriteLine(" enter a number:");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" enter a percent:");
            percent = Convert.ToInt32(Console.ReadLine());
            int newNumber = number * percent / 100;
            Console.WriteLine($"{percent}% of {number} is: {newNumber}");
        }

        static void GlueNumbers()
        {
            int n1, n2, n3, n4;
            Console.WriteLine(" enter 4 numbers:");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            n4 = Convert.ToInt32(Console.ReadLine());
            string str = n1.ToString() + n2.ToString() + n3.ToString() + n4.ToString();
            int number = Convert.ToInt32(str);
            Console.WriteLine($"The number is: {number}");
        }

        static void SixNumbers()
        {
            string number;
            int p1, p2;
            Console.WriteLine(" enter a six-digit number:");
            number = Console.ReadLine();
            if (number.Length != 6)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            char[] array = number.ToCharArray();
            Console.WriteLine("enter the first position:");
            p1 = Convert.ToInt32(Console.ReadLine());
            if (p1 < 0)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            Console.WriteLine("enter the second position:");
            p2 = Convert.ToInt32(Console.ReadLine());
            if (p2 >= array.Length)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            var temp = array[p1];
            array[p1] = array[p2];
            array[p2] = temp;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }

        static void Date()
        {
            string date = "";
            Console.WriteLine(" enter a date (dd.mm.yyyy):");
            date = Console.ReadLine();
            string[] arr = date.Split('.');
            int[] myInts = Array.ConvertAll(arr, int.Parse);
            DateTime dt = new DateTime(myInts[2], myInts[1], myInts[0]);
            switch (dt.Month)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    break;
            }
            if (dt.Month > 11 || dt.Month < 3) Console.WriteLine("Winter");
            else if (dt.Month < 6) Console.WriteLine("Spring");
            else if (dt.Month < 9) Console.WriteLine("Summer");
            else Console.WriteLine("Autumn");
        }

        static void Temperature()
        {
            int choice = 0, temp = 0;
            Console.WriteLine(" enter a temperature:");
            temp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" enter a choice (1 -> Celsius to Fahrenheit)(2 -> Fahrenheit to Celsius):");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"{(temp + 40) * 1.8 - 40}°");
                    break;
                case 2:
                    Console.WriteLine($"{(temp + 40) / 1.8 - 40}°");
                    break;
                case 3:
                    break;
            }
        }

        static void EvenNumbers()
        {
            int num1, num2;
            Console.WriteLine(" enter the first number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" enter the second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 < num1)
            {
                var temp = num1;
                num1 = num2;
                num2 = temp;
            }

            for (int i = num1; i < num2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} is even");
                }
            }
        }
    }
}

