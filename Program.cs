using System;
using System.Collections.Generic;


namespace ConsoleAppStringsAndIntegersAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a list of integers
            List<int> IntList = new List<int>() { 1018, 25098, 41094, 64452, 19488, 56418, 53780, 60342, 41766, 49554 };
            // Here the user will input and loop through the list dividing each number by the input
            bool NumValid = false;
            while (!NumValid)
            {
                // Here is as a try/catch block that gives an error message
                try
                {
                    Console.WriteLine("\nEnter a number to divide the above list by: ");
                    float NumDiv = float.Parse(Console.ReadLine());
                    // Here is an if statement to check if the user input 0
                    if (NumDiv == 0)
                    {
                        Console.WriteLine("Please enter a different number than 0.");
                    }
                    // Dividing each number in the list by the input
                    else
                    {
                        foreach (int num in IntList)
                        {
                            float Divide = num / NumDiv;
                            Console.WriteLine(num + " divide by " + NumDiv + " equals " + Divide);
                        }
                        NumValid = true;
                    }
                }
                // Here we display an error message for the string input using a catch block
                catch (FormatException)
                {
                    Console.WriteLine("Input is invalid. Please enter a number.");
                }
            }
            // Here we let the user know with a message that the program has exited the try/catch block
            Console.WriteLine("The program has exited the try/catch block.");
            Console.ReadLine();
        }
        
    }
}
