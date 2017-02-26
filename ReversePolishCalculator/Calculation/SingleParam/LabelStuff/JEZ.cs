#region License

// Copyright (c) 2017, Vira
// All rights reserved.
// Solution: ReversePolishCalculator
// Project: ReversePolishCalculator
// Filename: JEZ.cs
// Date - created:2017.02.26 - 10:45
// Date - current: 2017.02.26 - 13:14

#endregion

namespace ReversePolishCalculator.Calculation.SingleParam.LabelStuff
{
    /// <summary>
    ///     Jumps to a label if the number is equal to zero.
    ///     example 0 JEZ
    /// </summary>
    internal class JEZ : Method
    {
        public JEZ() : base("JEZ", 2)
        {
        }

        /// <summary>
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public override double DoStuff(string[] parameters)
        {
            base.DoStuff(parameters);

            if (!parameters[0].GVFVoN().Equals("0")) return 0;

            GlobalVariableManager.LNR = GlobalVariableManager.Labels[parameters[1]];
            return 1;
        }
    }
}