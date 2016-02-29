﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using NUnit.Framework;
using Textamina.Markdig.Formatters;
using Textamina.Markdig.Formatters.Html;
using Textamina.Markdig.Parsers;

namespace Textamina.Markdig.Tests
{
    [TestFixture]
    public class TestTableParser
    {
        [Test]
        public void TestSimple()
        {
            var reader = new StringReader(@"
|a|b
|-|-|-
|0|1|2|3
|A|B

");
//            var reader = new StringReader(@"> > toto tata
//> titi toto
//");
            var parser = new MarkdownParser(reader);
            var document = parser.Parse();

            var output = new StringWriter();
            var formatter = new HtmlFormatterOld(output);
            formatter.Write(document);
            output.Flush();

            var result = output.ToString();
            Console.WriteLine(result);
        }
   }
}