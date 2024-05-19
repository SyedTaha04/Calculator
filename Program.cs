using System;

namespace CalculatorTaha

{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
                int number1, number2, answer, result = 0;
                string op;
                bool correctAnswer = false;
                while(!correctAnswer){

                

                Console.WriteLine("Enter your first number:");
                number1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your second number:");
                number2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What operator do you want to use (+, -, *, /):");
                op = Console.ReadLine();

                if (op == "+")
                {
                    result = number1 + number2;
                }
                else if (op == "-")
                {
                    result = number1 - number2;
                }
                else if (op == "*")
                {
                    result = number1 * number2;
                }
                else if (op == "/")
                {
                    if (number2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero. Please restart the program and enter a non-zero second number.");
                        continue;  // Restart the loop
                    }
                    result = number1 / number2;
                }
                else
                {
                    Console.WriteLine("Invalid operator. Please restart the program and enter a valid operator.");
                    continue;  // Restart the loop
                }

                
                    Console.WriteLine("What is your answer?");
                    answer = Convert.ToInt32(Console.ReadLine());

                    if (answer == result)
                    {
                        Console.WriteLine("Well done");
                        correctAnswer = true;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect, try again from the beginning.");
                        correctAnswer=false;
                    }
                }

               
            }
        }
    }
}

