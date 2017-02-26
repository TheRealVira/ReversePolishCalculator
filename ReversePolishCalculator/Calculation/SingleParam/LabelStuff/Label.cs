#region License

// Copyright (c) 2017, Vira
// All rights reserved.
// Solution: ReversePolishCalculator
// Project: ReversePolishCalculator
// Filename: Label.cs
// Date - created:2017.02.26 - 10:45
// Date - current: 2017.02.26 - 13:14

#endregion

namespace ReversePolishCalculator.Calculation.SingleParam.LabelStuff
{
    /// <summary>
    ///     Represents some kind of checkpoint, which is going to be used as marker inside code, which is used in combination
    ///     with JMP logic.
    ///     NOTE: The label has to get executed before it is possible to jump to it, so there is no way to jump in the future!
    /// </summary>
    internal class Label : Method
    {
        public Label() : base(":", 1)
        {
        }

        /// <summary>
        ///     Saves the label inside the label dictionary.
        /// </summary>
        /// <param name="parameters">Labelname</param>
        /// <returns>1</returns>
        public override double DoStuff(string[] parameters)
        {
            base.DoStuff(parameters);

            GlobalVariableManager.Labels[parameters[0]] = GlobalVariableManager.LNR;

            return 1;
        }
    }
}