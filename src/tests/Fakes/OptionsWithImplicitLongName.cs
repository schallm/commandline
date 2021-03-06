﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandLine.Tests.Fakes
{
    class OptionsWithImplicitLongName
    {
        [Option]
        public string Download { get; set; }

        [Option("up-load")]
        public string Upload { get; set; }

        [Option('b')]
        public int Bytes { get; set; }
    }
}
