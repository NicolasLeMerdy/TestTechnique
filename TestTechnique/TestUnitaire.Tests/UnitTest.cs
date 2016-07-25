using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;

namespace TestTechnique.Tests {
    [TestClass]
    public class UnitTest {

        [TestMethod()]
        public void FibonacciTest() {
            WebMethod fibonacci = new WebMethod();
            BigInteger expected = 8;
            const int n = 6;
            BigInteger actual = fibonacci.FibonacciSequenceCalcul(n);
            Assert.AreEqual(expected, actual, "Calculation Error");
        }

        [TestMethod()]
        public void FibonacciTestFloat() {
            WebMethod fibonacci = new WebMethod();
            BigInteger expected = -1;
            const double n = 6.5;
            BigInteger actual = fibonacci.FibonacciSequenceCalcul(n);
            Assert.AreEqual(expected, actual, "Calculation Error");
        }

        [TestMethod()]
        public void FibonacciTestNegative() {
            WebMethod fibonacci = new WebMethod();
            BigInteger expected = -1;
            const double n = -6;
            BigInteger actual = fibonacci.FibonacciSequenceCalcul(n);
            Assert.AreEqual(expected, actual, "Calculation Error");
        }

        [TestMethod()]
        public void FibonacciTestPositive() {
            WebMethod fibonacci = new WebMethod();
            BigInteger expected = -1;
            const double n = 106;
            BigInteger actual = fibonacci.FibonacciSequenceCalcul(n);
            Assert.AreEqual(expected, actual, "Calculation Error");
        }

        [TestMethod()]
        public void XmlToJonReaderTest() {
            WebMethod xmlToJson = new WebMethod();
            const string expected = @"{""foo"":""bar""}";
            const string xml = "<foo>bar</foo>";
            string actual = xmlToJson.XmlToJonReader(xml);
            Assert.AreEqual(expected, actual, "Convert Error");
        }

        [TestMethod()]
        public void XmlToJonReaderTestSpace() {
            WebMethod xmlToJson = new WebMethod();
            const string expected = @"{""foo"":""bar""}";
            const string xml = "<foo  >bar</foo  >";
            string actual = xmlToJson.XmlToJonReader(xml);
            Assert.AreEqual(expected, actual, "Convert Error");
        }

        [TestMethod()]
        public void XmlToJonReaderTestBig() {
            WebMethod xmlToJson = new WebMethod();
            const string expected = "{\"Tests\":{\"Test\":[{\"@TestId\":\"0001\",\"@TestType\":\"CMD\",\"Name\":\"Convert number to string\",\"CommandLine\":\"Examp1.EXE\",\"Input\":\"1\",\"Output\":\"One\"},{\"@TestId\":\"0002\",\"@TestType\":\"CMD\",\"Name\":\"Find succeeding characters\",\"CommandLine\":\"Examp2.EXE\",\"Input\":\"abc\",\"Output\":\"def\"},{\"@TestId\":\"0003\",\"@TestType\":\"GUI\",\"Name\":\"Convert multiple numbers to strings\",\"CommandLine\":\"Examp2.EXE /Verbose\",\"Input\":\"123\",\"Output\":\"One Two Three\"},{\"@TestId\":\"0004\",\"@TestType\":\"GUI\",\"Name\":\"Find correlated key\",\"CommandLine\":\"Examp3.EXE\",\"Input\":\"a1\",\"Output\":\"b1\"},{\"@TestId\":\"0005\",\"@TestType\":\"GUI\",\"Name\":\"Count characters\",\"CommandLine\":\"FinalExamp.EXE\",\"Input\":\"This is a test\",\"Output\":\"14\"},{\"@TestId\":\"0006\",\"@TestType\":\"GUI\",\"Name\":\"Another Test\",\"CommandLine\":\"Examp2.EXE\",\"Input\":\"Test Input\",\"Output\":\"10\"}]}}";
            const string xml = @"<Tests>   <Test TestId=""0001"" TestType=""CMD"">     <Name>Convert number to string</Name>     <CommandLine>Examp1.EXE</CommandLine>     <Input>1</Input>     <Output>One</Output>   </Test>   <Test TestId=""0002"" TestType=""CMD"">     <Name>Find succeeding characters</Name>     <CommandLine>Examp2.EXE</CommandLine>     <Input>abc</Input>     <Output>def</Output>   </Test>   <Test TestId=""0003"" TestType=""GUI"">     <Name>Convert multiple numbers to strings</Name>     <CommandLine>Examp2.EXE /Verbose</CommandLine>     <Input>123</Input>     <Output>One Two Three</Output>   </Test>   <Test TestId=""0004"" TestType=""GUI"">     <Name>Find correlated key</Name>     <CommandLine>Examp3.EXE</CommandLine>     <Input>a1</Input>     <Output>b1</Output>   </Test>   <Test TestId=""0005"" TestType=""GUI"">     <Name>Count characters</Name>     <CommandLine>FinalExamp.EXE</CommandLine>     <Input>This is a test</Input>     <Output>14</Output>   </Test>   <Test TestId=""0006"" TestType=""GUI"">     <Name>Another Test</Name>     <CommandLine>Examp2.EXE</CommandLine>     <Input>Test Input</Input>     <Output>10</Output>   </Test> </Tests>";
            string actual = xmlToJson.XmlToJonReader(xml);
            Assert.AreEqual(expected, actual, "Convert Error");
        }
    }
}
