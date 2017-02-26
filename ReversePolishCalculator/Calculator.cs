#region License

// Copyright (c) 2017, Vira
// All rights reserved.
// Solution: ReversePolishCalculator
// Project: ReversePolishCalculator
// Filename: Calculator.cs
// Date - created:2017.02.25 - 16:43
// Date - current: 2017.02.26 - 13:14

#endregion

#region Usings

using System;
using System.Collections.Generic;
using ReversePolishCalculator.Calculation;
using static ReversePolishCalculator.Calculation.GlobalVariableManager;

#endregion

namespace ReversePolishCalculator
{
    /// <summary>
    ///     Represents the main interface between developer and this API.
    /// </summary>
    public static class Calculator
    {
        /// <summary>
        ///     This error code is getting returned every time something went wrong.
        /// </summary>
        public static int ERROR_CODE = -1;

        /// <summary>
        ///     A collection of lines of code. (History)
        /// </summary>
        public static List<string> Code { get; set; }

        /// <summary>
        ///     The current position in code.
        /// </summary>
        public static int LineNumber => LNR;

        /// <summary>
        ///     Initializes all fun.
        /// </summary>
        public static void Initialize()
        {
            MethodManager.Initialize();
            Initialise();
            if (Code == null)
            {
                Code = new List<string>();
            }
        }

        /// <summary>
        ///     Calculate a single line of code, which is than added to the Code and the current position gets popped up ones.
        /// </summary>
        /// <param name="number">The code which should get compiled and executed.</param>
        /// <returns>Returns a message to the result.</returns>
        public static KeyValuePair<string, double> Calculate(string number)
        {
            Code[LNR] = number;
            var not = new Notation(number);
            uint step = 0;

            while (!not.IsFinished)
            {
                step++;

                try
                {
                    not.Update();
                }
                catch (Exception ex)
                {
                    return
                        new KeyValuePair<string, double>(
                            $"Failed at step:  [{step}]\n================\nException:\n\n{ex}", ERROR_CODE);
                }
            }

            JumpToLine(LNR + 1);

            try
            {
                return new KeyValuePair<string, double>($"Finished the calculation with [{step}] steps",
                    double.Parse(not.GetFirstThing.GVFVoN()));
            }
            catch
            {
                return new KeyValuePair<string, double>($"The calculated number is somehow not a number...", ERROR_CODE);
            }
        }

        /// <summary>
        ///     Resets all variables and the current position inside the code. (will also remove all labels)
        /// </summary>
        public static void Reset()
        {
            GlobalVariableManager.Reset();
            LNR = 0;
        }

        /// <summary>
        ///     Jumps to the line of code.
        /// </summary>
        /// <param name="line">The paramter is going to get modulated by the code history length.</param>
        public static void JumpToLine(int line)
        {
            LNR = line%Code.Count;
        }

        /// <summary>
        ///     This method will automatically jump to the next line of code and execute the current.
        ///     NOTE: The index will not get out of range, because it gets modulated by the current code line count.
        /// </summary>
        public static KeyValuePair<string, double> Update()
        {
            return Calculate(Code[LNR]);
        }
    }
}