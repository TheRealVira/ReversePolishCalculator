#region License

// Copyright (c) 2017, Vira
// All rights reserved.
// Solution: ReversePolishCalculator
// Project: ReversePolishCalculator
// Filename: JLZ.cs
// Date - created:2017.02.26 - 10:46
// Date - current: 2017.02.26 - 13:14

#endregion

namespace ReversePolishCalculator.Calculation.SingleParam.LabelStuff
{
    /// <summary>
    ///     Jumps to a label if the number is less than zero.
    ///     example -1 JLZ
    /// </summary>
    internal class JLZ : Method
    {
        public JLZ() : base("JLZ", 2)
        {
        }

        /// <summary>
        ///     Sets the global LNR to the of the wanted label only when the first parameter is less than 0.
        /// </summary>
        /// <param name="parameters">[0]: Variable or number; [1]: Labelname</param>
        /// <returns>1: Jumped to label;</returns>
        public override double DoStuff(string[] parameters)
        {
            base.DoStuff(parameters);

            if (double.Parse(parameters[0].GVFVoN()) >= 0) return 0;

            GlobalVariableManager.LNR = GlobalVariableManager.Labels[parameters[1]];
            return 1;
        }
    }
}