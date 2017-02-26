#region License

// Copyright (c) 2017, Vira
// All rights reserved.
// Solution: ReversePolishCalculator
// Project: ReversePolishCalculator
// Filename: JMP.cs
// Date - created:2017.02.26 - 10:45
// Date - current: 2017.02.26 - 13:14

#endregion

namespace ReversePolishCalculator.Calculation.SingleParam.LabelStuff
{
    /// <summary>
    ///     Jumps to a label
    /// </summary>
    internal class JMP : Method
    {
        public JMP() : base("JMP", 1)
        {
        }

        /// <summary>
        ///     Sets the global LNR to the of the wanted label.
        /// </summary>
        /// <param name="parameters">[0]: Labelname</param>
        /// <returns>1: Jumped to label;</returns>
        public override double DoStuff(string[] parameters)
        {
            base.DoStuff(parameters);

            GlobalVariableManager.LNR = GlobalVariableManager.Labels[parameters[0]];
            return 1;
        }
    }
}