#region License

// Copyright (c) 2017, Vira
// All rights reserved.
// Solution: ReversePolishCalculator
// Project: ReversePolishCalculator
// Filename: POW.cs
// Date - created:2017.02.26 - 12:50
// Date - current: 2017.02.26 - 13:14

#endregion

#region Usings

using System;

#endregion

namespace ReversePolishCalculator.Calculation.DoubleParam
{
    /// <summary>
    ///     Represents the power symbol and its logic.
    /// </summary>
    internal class POW : Method
    {
        public POW() : base("POW", 2)
        {
        }

        /// <summary>
        ///     Powers the first parameter by the second one.
        /// </summary>
        /// <param name="parameters">Parameters could be variables or doubles.</param>
        /// <returns>Returns the result of the powerization.</returns>
        public override double DoStuff(string[] parameters)
        {
            base.DoStuff(parameters);
            return Math.Pow(double.Parse(parameters[0].GVFVoN()), double.Parse(parameters[1].GVFVoN()));
        }
    }
}