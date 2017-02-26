#region License

// Copyright (c) 2017, Vira
// All rights reserved.
// Solution: ReversePolishCalculator
// Project: ReversePolishCalculator
// Filename: SQRT.cs
// Date - created:2017.02.26 - 09:15
// Date - current: 2017.02.26 - 13:14

#endregion

#region Usings

using System;

#endregion

namespace ReversePolishCalculator.Calculation.SingleParam
{
    /// <summary>
    ///     Represents the square root symbol and its logic.
    /// </summary>
    internal class SQRT : Method
    {
        public SQRT() : base("SQRT", 1)
        {
        }

        /// <summary>
        ///     Squares the first parameter by two.
        /// </summary>
        /// <param name="parameters">Parameters could be variables or doubles.</param>
        /// <returns>Returns the result of the square root for the first parameter.</returns>
        public override double DoStuff(string[] parameters)
        {
            base.DoStuff(parameters);

            return Math.Sqrt(double.Parse(parameters[0].GVFVoN()));
        }
    }
}