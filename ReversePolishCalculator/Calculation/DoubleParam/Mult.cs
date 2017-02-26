#region License

// Copyright (c) 2017, Vira
// All rights reserved.
// Solution: ReversePolishCalculator
// Project: ReversePolishCalculator
// Filename: Mult.cs
// Date - created:2017.02.26 - 09:15
// Date - current: 2017.02.26 - 13:14

#endregion

namespace ReversePolishCalculator.Calculation.DoubleParam
{
    /// <summary>
    ///     Represents the multiplying symbol and its logic.
    /// </summary>
    internal class Mult : Method
    {
        public Mult() : base("*", 2)
        {
        }

        /// <summary>
        ///     Multiplies the first parameter with the second one.
        /// </summary>
        /// <param name="parameters">Parameters could be variables or doubles.</param>
        /// <returns>Returns the result of the multiplication.</returns>
        public override double DoStuff(string[] parameters)
        {
            base.DoStuff(parameters);
            return double.Parse(parameters[0].GVFVoN())*double.Parse(parameters[1].GVFVoN());
        }
    }
}