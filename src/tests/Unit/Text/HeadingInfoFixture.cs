#region License
//
// Command Line Library: HeadingInfoFixture.cs
//
// Author:
//   Giacomo Stelluti Scala (gsscoder@gmail.com)
//
// Copyright (C) 2005 - 2013 Giacomo Stelluti Scala
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
//
#endregion

namespace CommandLine.Tests.Unit.Text
{
    #region Using Directives
    using System;
    using System.IO;
    using Xunit;
    using FluentAssertions;
    using CommandLine.Text;
    #endregion

    public class HeadingInfoFixture
    {
        [Fact]
        public void Only_program_name()
        {
            var hi = new HeadingInfo("myprog");
            string s = hi;

            s.Should().Be("myprog");

            var sw = new StringWriter();
            hi.WriteMessage("a message", sw);

            sw.ToString().Should().Be("myprog: a message" + Environment.NewLine);
        }

        [Fact]
        public void Program_name_and_version()
        {
            var hi = new HeadingInfo("myecho", "2.5");
            string s = hi;

            s.Should().Be("myecho 2.5");

            var sw = new StringWriter();
            hi.WriteMessage("hello unit-test", sw);

            sw.ToString().Should().Be("myecho: hello unit-test" + Environment.NewLine);
        }
    }
}

