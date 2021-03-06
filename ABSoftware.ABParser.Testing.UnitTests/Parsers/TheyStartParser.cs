﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSoftware.ABParser.Testing.UnitTests.Parsers
{
    /// <summary>
    /// Has "the", "they" and "theyare" tokens - a good test for verification.
    /// </summary>
    public class TheyParser : TrackingParser
    {
        static readonly ABParserConfiguration ParserConfig = new ABParserConfiguration(new ABParserToken[]
        {
            new ABParserToken("the"),
            new ABParserToken("they"),
            new ABParserToken("theyare")
        });

        public TheyParser() : base(ParserConfig) { }
    }
}
