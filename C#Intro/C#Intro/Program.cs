
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int m))
        {
            if (m == 0)
            {
                Console.WriteLine("0 is not a valid input, please try again...");
            }
            else if (m % 2 == 0)
            {
                Console.WriteLine($"{m} is an even number");
            }
            else
            {
                Console.WriteLine($"{m} is an odd number");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }


        


        Console.WriteLine("Enter the values for num1 and num2, separated by a space");
        string[] userInput = Console.ReadLine().Split(' ');

        if (userInput.Length != 2)
        {
            Console.WriteLine("Please provide 2 values for num1 and num2.");
            return;
        }

        int number1, number2;

        if (int.TryParse(userInput[0], out number1) && int.TryParse(userInput[1], out number2))
        {
            if (number1 % 2 == 0 && number2 % 2 == 0)
            {
                int total = number1 + number2;
                Console.WriteLine($"The sum of num1 and num2 is: {total}");
            }
            else
            {
                Console.WriteLine("Either num1 or num2 or both are not even numbers.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid integers.");
        }


        Console.WriteLine("Enter the values for num1 and num2, separated by a space");
        string[] userInput2 = Console.ReadLine().Split(' ');

        if (userInput.Length != 2)
        {
            Console.WriteLine("Please provide 2 values for num1 and num2.");
            return;
        }

        int num1, num2;

        if (int.TryParse(userInput2[0], out num1) && int.TryParse(userInput2[1], out num2))
        {
            if (num1 >= num2)
            {
                Console.WriteLine("num1 should be less than num2. Please provide valid input.");
            }
            else
            {
                int count = 0;
                for (int i = num1; i <= num2; i++)
                {
                    if (i % 2 != 0)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"The count of odd numbers between num1 and num2 is: {count}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid integers.");
        }

    }
}