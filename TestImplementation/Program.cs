#region License

// Copyright (c) 2017, Vira
// All rights reserved.
// Solution: ReversePolishCalculator
// Project: TestImplementation
// Filename: Program.cs
// Date - created:2017.02.25 - 16:32
// Date - current: 2017.02.26 - 13:14

#endregion

#region Usings

using System;
using System.Collections.Generic;
using System.IO;
using ReversePolishCalculator;

#endregion

namespace TestImplementation
{
    internal class Program
    {
        private const string FIBO_CODE = "fibo";

        private static void Main(string[] args)
        {
            Calculator.Initialize();

            DoFiboCode();

            string input;
            Console.Write("> ");
            while (!(input = Console.ReadLine()).Equals("exit"))
            {
                var test = Calculator.Calculate(input);
                Console.Write(
                    $"==========OUTPUT==========\nMessage:\t{test.Key}\n---Value:\t{test.Value}\n==========================\n> ");
            }

            Console.WriteLine("WWWWWWWWWWWWWWWWWWWWWWWWWWW\nTerminated...");
            Console.ReadKey(true);
        }

        /// <summary>
        ///     Executes the fibonacci example code.
        /// </summary>
        private static void DoFiboCode()
        {
            Calculator.Reset();

            // Load the code from the file to the calculator
            Calculator.Code = new List<string>(File.ReadAllLines(FIBO_CODE));

            do
            {
                // Step through every line of code and execute it
                Calculator.Update();

                // Till we are back at the beginning
            } while (Calculator.LineNumber != 0);
        }
    }
}