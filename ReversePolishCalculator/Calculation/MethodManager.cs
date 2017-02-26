#region License

// Copyright (c) 2017, Vira
// All rights reserved.
// Solution: ReversePolishCalculator
// Project: ReversePolishCalculator
// Filename: MethodManager.cs
// Date - created:2017.02.25 - 16:49
// Date - current: 2017.02.26 - 13:14

#endregion

#region Usings

using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace ReversePolishCalculator.Calculation
{
    /// <summary>
    ///     Represents the management of all functionality.
    /// </summary>
    internal static class MethodManager
    {
        /// <summary>
        ///     Contains all functions and their symbol as their key.
        /// </summary>
        internal static Dictionary<string, Method> Methods;

        /// <summary>
        ///     Dynamically saves all classes inside the Methods dictionary using reflections.
        /// </summary>
        public static void Initialize()
        {
            if (Methods != null) return;
            Methods = new Dictionary<string, Method>();
            var temp = typeof(Method)
                .Assembly.GetTypes()
                .Where(t => t.IsSubclassOf(typeof(Method)) && !t.IsAbstract)
                .Select(t => (Method) Activator.CreateInstance(t));

            foreach (var method in temp)
            {
                Methods.Add(method.Sign, method);
            }
        }

        /// <summary>
        ///     Gathers all the symbols of the methods to an string array.
        /// </summary>
        /// <returns>Returns all symbols inside a string array.</returns>
        public static string[] GetValidSigns() => Methods.Keys.ToArray();
    }
}