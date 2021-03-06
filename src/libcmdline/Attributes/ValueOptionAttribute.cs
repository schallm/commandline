﻿#region License
// <copyright file="ValueOptionAttribute.cs" company="Giacomo Stelluti Scala">
//   Copyright 2015-2013 Giacomo Stelluti Scala
// </copyright>
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
#endregion

namespace CommandLine
{
    #region Using Directives
    using System;
    #endregion

    /// <summary>
    /// Maps a single unnamed option to the target property. Values will be mapped in order of Index.
    /// This attribute takes precedence over <see cref="CommandLine.ValueListAttribute"/> with which
    /// can coexist.
    /// </summary>
    /// <remarks>It can handle only scalar values. Do not apply to arrays or lists.</remarks>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public sealed class ValueOptionAttribute : Attribute
    {
        private readonly int index;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandLine.ValueOptionAttribute"/> class.
        /// </summary>
        /// <param name="index">The index of the option.</param>
        public ValueOptionAttribute(int index)
        {
            this.index = index;
        }

        /// <summary>
        /// Obsolete constructor, uses default index 0.
        /// Initializes a new instance of the <see cref="CommandLine.ValueOptionAttribute"/> class.
        /// </summary>
        /// <remarks>In next Stable this constructor will be removed.</remarks>
        [Obsolete("Use explicit index instead.")]
        public ValueOptionAttribute() : this(0)
        {
        }

        /// <summary>
        /// Gets the position this option has on the command line.
        /// </summary>
        public int Index
        {
            get { return this.index; }
        }
    }
}