#region License

// Copyright (c) 2017, Vira
// All rights reserved.
// Solution: ReversePolishCalculator
// Project: ReversePolishCalculator
// Filename: Setter.cs
// Date - created:2017.02.26 - 09:42
// Date - current: 2017.02.26 - 13:14

#endregion

namespace ReversePolishCalculator.Calculation.DoubleParam
{
    /// <summary>
    ///     Represents the setter symbol and its logic.
    /// </summary>
    internal class Setter : Method
    {
        public Setter() : base("=", 2)
        {
        }

        /// <summary>
        ///     Sets the variable (the first parameter) to the value of the second parameter.
        /// </summary>
        /// <param name="parameters">The first parameter is the variable name and the second one contains the value of it.</param>
        /// <returns>1</returns>
        public override double DoStuff(string[] parameters)
        {
            base.DoStuff(parameters);

            GlobalVariableManager.Variables[parameters[0]] = parameters[1].GVFVoN();

            return 1;
        }
    }
}