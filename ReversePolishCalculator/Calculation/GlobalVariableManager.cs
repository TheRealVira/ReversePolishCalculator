#region License

// Copyright (c) 2017, Vira
// All rights reserved.
// Solution: ReversePolishCalculator
// Project: ReversePolishCalculator
// Filename: GlobalVariableManager.cs
// Date - created:2017.02.26 - 09:37
// Date - current: 2017.02.26 - 13:14

#endregion

#region Usings

using System.Collections.Generic;

#endregion

namespace ReversePolishCalculator.Calculation
{
    /// <summary>
    ///     Represents the management of all global. (Varialbes, Labels, LineNumber)
    /// </summary>
    internal static class GlobalVariableManager
    {
        /// <summary>
        ///     Defines the current line number
        /// </summary>
        public static int LNR;

        /// <summary>
        ///     Contains all variables and their values.
        /// </summary>
        public static Dictionary<string, string> Variables { get; private set; }

        /// <summary>
        ///     Defines all labels (label text, line number)
        /// </summary>
        public static Dictionary<string, int> Labels { get; private set; }

        /// <summary>
        ///     Initialises all necessary dictionaries. (Labels, Variablese)
        /// </summary>
        public static void Initialise()
        {
            if (Variables != null) return;

            Variables = new Dictionary<string, string>();
            Labels = new Dictionary<string, int>();
        }

        /// <summary>
        ///     GetValueFromVariableOrNot
        /// </summary>
        /// <param name="input">The input could be a variable or just not definied in the Variables dictionary.</param>
        /// <returns>
        ///     If the input is found inside the Variables dictionary than this method will return the value of that variable,
        ///     else it will return the same string.
        /// </returns>
        public static string GVFVoN(this string input)
        {
            return Variables.ContainsKey(input) ? Variables[input] : input;
        }

        /// <summary>
        ///     Resets all dictionaries. (Labels, Variablese)
        /// </summary>
        public static void Reset()
        {
            Variables.Clear();
            Labels.Clear();
        }
    }
}