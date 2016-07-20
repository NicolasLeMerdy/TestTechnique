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
        public void XmlToJonReaderTest() {
            WebMethod xmlToJson = new WebMethod();
            const string expected = @"{""foo"":""bar""}";
            const string xml = "<foo>bar</foo>";
            string actual = xmlToJson.XmlToJonReader(xml);
            Assert.AreEqual(expected, actual, "Convert Error");
        }
    }
}
