#region License

// Copyright (c) 2017, Vira
// All rights reserved.
// Solution: ReversePolishCalculator
// Project: ReversePolishCalculator
// Filename: Factorial.cs
// Date - created:2017.02.26 - 09:14
// Date - current: 2017.02.26 - 13:14

#endregion

namespace ReversePolishCalculator.Calculation.SingleParam
{
    /// <summary>
    ///     Represents the factorizing symbol and its logic.
    /// </summary>
    internal class Factorial : Method
    {
        public Factorial() : base("!", 1)
        {
        }

        /// <summary>
        ///     Factorizes the first parameter.
        /// </summary>
        /// <param name="parameters">Parameters could be variables or doubles.</param>
        /// <returns>Returns the result of the factorization.</returns>
        public override double DoStuff(string[] parameters)
        {
            base.DoStuff(parameters);
            var num = double.Parse(parameters[0].GVFVoN());

            double toRet = 1;
            for (var i = 0; i < num; i++)
            {
                toRet *= num - i;
            }

            return toRet;
        }
    }
}