﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Aline.cs" company="">
// Author: Philip Kitselis
//
// This file is part of AlineNet.

// It includes ported C++ code originally developed by G.Kondrak (c) 2000
// and later modified by Sean Downey(2015) for the AlineR project.Much of the
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
//   The ALINE class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AlineNet
{
    using Aligners;

    /// <summary>
    /// The ALINE class.
    /// </summary>
    public class Aline : AlineFactory
    {
        /// <summary>
        /// The create aligner.
        /// </summary>
        /// <param name="type">
        /// The type.
        /// </param>
        /// <returns>
        /// The <see cref="IAligner"/>.
        /// </returns>
        public override IAligner CreateAligner(AlignerType type)
        {
            return this.CreateAligner(type, null);
        }

        /// <summary>
        /// The create aligner.
        /// </summary>
        /// <param name="type">
        /// The type.
        /// </param>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <returns>
        /// The <see cref="IAligner"/>.
        /// </returns>
        public override IAligner CreateAligner(AlignerType type, Parameters parameters)
        {
            IAligner aligner;

            switch (type)
            {
                case AlignerType.Global:
                    aligner = new GlobalAligner(parameters);
                    break;
                case AlignerType.Local:
                    aligner = new LocalAligner(parameters);
                    break;
                case AlignerType.SemiGlobal:
                    aligner = new SemiGlobalAligner(parameters);
                    break;
                default:
                    aligner = new GlobalAligner(parameters);
                    break;
            }

            return aligner;
        }
    }
}
