using System;
using System.Diagnostics;
using System.IO;
using Xunit;
using Y.ArmaTools.Abstractions;

namespace Y.ArmaTools.TextTools.Tests
{
    public class TextToolsServiceTests
    {
        [Fact]
        public void Case1Test()
        {
            ITextToolsService service = new TextToolsService();
            var testStrings = GetTestStrings();

            var result = service.GenerateIncrementStringsByTemplate(testStrings.Template, 3, 6);
            Assert.Equal(testStrings.Expected, result);
        }

        private TestStrings GetTestStrings()
        {
            StackTrace stackTrace = new StackTrace();

            var callerMethod = stackTrace.GetFrame(1).GetMethod().Name.Replace("Test", string.Empty);
            
            string template = File.ReadAllText($"Examples/TextToolsServiceTests/{callerMethod}/template.txt");
            string expected = File.ReadAllText($"Examples/TextToolsServiceTests/{callerMethod}/expected.txt");
            
            return new TestStrings(template, expected);
        }
    }

    class TestStrings
    {
        public string Template { get; }
        public string Expected { get; }

        public TestStrings(string template, string expected)
        {
            Template = template;
            Expected = expected;
        }
    }
}