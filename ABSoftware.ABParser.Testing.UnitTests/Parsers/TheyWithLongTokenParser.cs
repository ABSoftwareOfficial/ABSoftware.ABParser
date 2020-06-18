﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ABSoftware.ABParser.Testing.UnitTests.Parsers
{
    public class TheyWithLongTokenParser : TrackingParser
    {
        static readonly ABParserConfiguration ParserConfig = new ABParserConfiguration(new ABParserToken[]
        {
            new ABParserToken(new ABParserText("the")),
            new ABParserToken(new ABParserText("they")),
            new ABParserToken(new ABParserText("theyare")),
            new ABParserToken(new ABParserText("AtheBtheyCtheyarDtheyareE")),
        });

        public TheyWithLongTokenParser() : base(ParserConfig) { }
    }
}
