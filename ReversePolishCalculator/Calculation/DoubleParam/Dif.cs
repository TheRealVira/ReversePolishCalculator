#region License

// Copyright (c) 2017, Vira
// All rights reserved.
// Solution: ReversePolishCalculator
// Project: ReversePolishCalculator
// Filename: Dif.cs
// Date - created:2017.02.26 - 09:15
// Date - current: 2017.02.26 - 13:14

#endregion

namespace ReversePolishCalculator.Calculation.DoubleParam
{
    /// <summary>
    ///     Represents the devision symbol and its logic.
    /// </summary>
    internal class Dif : Method
    {
        public Dif() : base("/", 2)
        {
        }

        /// <summary>
        ///     Divides the first parameter by the second one.
        /// </summary>
        /// <param name="parameters">Parameters could be variables or doubles.</param>
        /// <returns>Returns the result of the divsion.</returns>
        public override double DoStuff(string[] parameters)
        {
            base.DoStuff(parameters);
            return double.Parse(parameters[0].GVFVoN())/double.Parse(parameters[1].GVFVoN());
        }
    }
}