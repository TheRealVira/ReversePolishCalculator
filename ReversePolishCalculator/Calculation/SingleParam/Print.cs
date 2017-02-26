#region License

// Copyright (c) 2017, Vira
// All rights reserved.
// Solution: ReversePolishCalculator
// Project: ReversePolishCalculator
// Filename: Print.cs
// Date - created:2017.02.26 - 11:15
// Date - current: 2017.02.26 - 13:14

#endregion

#region Usings

using System;

#endregion

namespace ReversePolishCalculator.Calculation.SingleParam
{
    /// <summary>
    ///     Represents the print symbol and its logic.
    /// </summary>
    internal class Print : Method
    {
        public Print() : base("PRINT", 1)
        {
        }

        /// <summary>
        ///     Prints the first parameter (or its value) to the console.
        /// </summary>
        /// <param name="parameters">Parameters could be variables or doubles.</param>
        /// <returns>1</returns>
        public override double DoStuff(string[] parameters)
        {
            base.DoStuff(parameters);

            Console.Write(parameters[0].GVFVoN());

            return 1;
        }
    }
}