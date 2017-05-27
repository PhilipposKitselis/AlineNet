﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Phonetic.cs" company="">
// Author: Philip Kitselis
//
// This file is part of AlineNet.

// It includes ported C++ code originally developed by G.Kondrak (c) 2000
// and later modified by Sean Downey(2015) for the AlineR project. Much of the
// C++ code remains as is with minor modifications for the C# conversion.
//
// For more information on the algorithm of G.Kondrak visit:

// https://webdocs.cs.ualberta.ca/~kondrak/papers/thesis.pdf

// AlineNet is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.

// AlineNet is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
// GNU General Public License for more details.

// You should have received a copy of the GNU General Public License
// along with AlineNet.  If not, see<http://www.gnu.org/licenses/>.   
// </copyright>
// <summary>
//   Defines the Phonetic type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AlineNet.ExtensionMethods
{
    using System.Linq;
    using System.Text;
    using AlineNet.Aligners;

    /// <summary>
    /// The phonetic extension.
    /// </summary>
    internal static class Phonetic
    {
        /// <summary>
        /// The is vowel.
        /// </summary>
        /// <param name="p">
        /// The p.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public static bool IsVowel(this int[] p)
        {
            return p[Constants.FStop] <= Constants.Vwl;
        }
    }
}
