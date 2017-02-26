#region License

// Copyright (c) 2017, Vira
// All rights reserved.
// Solution: ReversePolishCalculator
// Project: ReversePolishCalculator
// Filename: Minus.cs
// Date - created:2017.02.26 - 09:15
// Date - current: 2017.02.26 - 13:14

#endregion

namespace ReversePolishCalculator.Calculation.DoubleParam
{
    /// <summary>
    ///     Represents the minus symbol and its logic.
    /// </summary>
    internal class Minus : Method
    {
        public Minus() : base("-", 2)
        {
        }

        /// <summary>
        ///     Subtracts the second parameter from the first.
        /// </summary>
        /// <param name="parameters">Parameters could be variables or doubles.</param>
        /// <returns>Returns the result of the subtraction.</returns>
        public override double DoStuff(string[] parameters)
        {
            base.DoStuff(parameters);
            return double.Parse(parameters[0].GVFVoN()) - double.Parse(parameters[1].GVFVoN());
        }
    }
}