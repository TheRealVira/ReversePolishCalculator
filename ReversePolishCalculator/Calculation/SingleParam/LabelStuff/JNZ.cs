#region License

// Copyright (c) 2017, Vira
// All rights reserved.
// Solution: ReversePolishCalculator
// Project: ReversePolishCalculator
// Filename: JNZ.cs
// Date - created:2017.02.26 - 11:03
// Date - current: 2017.02.26 - 13:14

#endregion

namespace ReversePolishCalculator.Calculation.SingleParam.LabelStuff
{
    /// <summary>
    ///     Jumps to a label if the number is NOT equal to zero.
    ///     example 1 JEZ
    ///     example -1 JEZ
    /// </summary>
    internal class JNZ : Method
    {
        public JNZ() : base("JNZ", 2)
        {
        }

        /// <summary>
        ///     Sets the global LNR to the of the wanted label only when the first parameter does not equal 0.
        /// </summary>
        /// <param name="parameters">[0]: Variable or number; [1]: Labelname</param>
        /// <returns>1: Jumped to label;</returns>
        public override double DoStuff(string[] parameters)
        {
            base.DoStuff(parameters);

            if (parameters[0].GVFVoN().Equals("0")) return 0;

            GlobalVariableManager.LNR = GlobalVariableManager.Labels[parameters[1]];
            return 1;
        }
    }
}