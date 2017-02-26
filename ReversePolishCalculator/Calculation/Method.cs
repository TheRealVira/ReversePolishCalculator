#region License

// Copyright (c) 2017, Vira
// All rights reserved.
// Solution: ReversePolishCalculator
// Project: ReversePolishCalculator
// Filename: Method.cs
// Date - created:2017.02.25 - 16:45
// Date - current: 2017.02.26 - 13:14

#endregion

#region Usings

using System.Diagnostics.Contracts;

#endregion

namespace ReversePolishCalculator.Calculation
{
    /// <summary>
    ///     Represents a symbol, which does something if it is used inside the code using a dynamically fixed amount of
    ///     parameters.
    /// </summary>
    internal abstract class Method
    {
        /// <summary>
        ///     Represents how many parameters this symbol needs to work.
        /// </summary>
        public readonly uint ParamCount;

        /// <summary>
        ///     Represents the symbol, so its functionality is usable.
        /// </summary>
        public readonly string Sign;

        protected Method(string sign, uint paramCount)
        {
            Sign = sign;
            ParamCount = paramCount;
        }

        public virtual double DoStuff(string[] parameters)
        {
            Contract.Requires(parameters.Length == ParamCount);

            return 0;
        }
    }
}