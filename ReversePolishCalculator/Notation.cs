#region License

// Copyright (c) 2017, Vira
// All rights reserved.
// Solution: ReversePolishCalculator
// Project: ReversePolishCalculator
// Filename: Notation.cs
// Date - created:2017.02.25 - 16:44
// Date - current: 2017.02.26 - 13:14

#endregion

#region Usings

using System.Collections.Generic;
using System.Linq;
using ReversePolishCalculator.Calculation;

#endregion

namespace ReversePolishCalculator
{
    /// <summary>
    ///     Represents a compiled line of code.
    /// </summary>
    internal class Notation
    {
        /// <summary>
        ///     This character is going to split the code to its keywords/numbers/variables/...
        /// </summary>
        private const char Splitter = ' ';

        /// <summary>
        ///     All splitted information of the line of code.
        /// </summary>
        private readonly List<string> _data;

        public Notation(string not)
        {
            _data = new List<string>();

            not.Split(Splitter).ToList().ForEach(x => _data.Add(x));
        }

        /// <summary>
        ///     Returns true if ther is only the result left.
        /// </summary>
        public bool IsFinished => _data.Count == 1;

        /// <summary>
        ///     Returns the first sub code.
        /// </summary>
        public string GetFirstThing => _data[0];

        /// <summary>
        ///     Executes ONE step.
        /// </summary>
        public void Update()
        {
            if (IsFinished) return;

            // Gets the index of the first valid method symbole
            var index =
                _data.FindIndex(x => x.Equals(_data.First(y => MethodManager.GetValidSigns().Contains(y))));

            var parameters = new string[MethodManager.Methods[_data[index]].ParamCount];
            for (var i = parameters.Length; i > 0; i--)
            {
                parameters[i - 1] = _data[index - i];
            }

            // Set the data at the symbol to the solution of that method of the two numbers before
            _data[index] =
                MethodManager.Methods[_data[index]].DoStuff(parameters)
                    .ToString();

            // Remove all used data
            _data.RemoveRange(index - parameters.Length, parameters.Length);
        }
    }
}