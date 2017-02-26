#region License

// Copyright (c) 2017, Vira
// All rights reserved.
// Solution: ReversePolishCalculator
// Project: ReversePolishCalculator
// Filename: Plus.cs
// Date - created:2017.02.26 - 09:15
// Date - current: 2017.02.26 - 13:14

#endregion

namespace ReversePolishCalculator.Calculation.DoubleParam
{
    /// <summary>
    ///     Represents the adding symbol and its logic.
    /// </summary>
    internal class Plus : Method
    {
        public Plus() : base("+", 2)
        {
        }

        /// <summary>
        ///     Adds the first parameter to the second.
        /// </summary>
        /// <param name="parameters">Parameters could be variables or doubles.</param>
        /// <returns>Returns the result of the addition.</returns>
        public override double DoStuff(string[] parameters)
        {
            base.DoStuff(parameters);
            return double.Parse(parameters[0].GVFVoN()) + double.Parse(parameters[1].GVFVoN());
        }
    }
}