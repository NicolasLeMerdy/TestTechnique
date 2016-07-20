using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestTechnique.Tests {
    [TestClass]
    public class UnitTest {

        [TestMethod()]
        public void FibonacciTest() {
            WebMethod Fibonacci = new WebMethod();
            double expected = 8;
            double actual;
            int n = 6;
            actual = Fibonacci.FibonacciSequenceCalcul(n);
            Assert.AreEqual(expected, actual, "Calculation Error");
        }

        [TestMethod()]
        public void XmlToJonReaderTest() {
            WebMethod XmlToJson = new WebMethod();
            string expected = @"{""foo"":""bar""}";
            string xml = "<foo>bar</foo>";
            string actual = XmlToJson.XmlToJonReader(xml);
            Assert.AreEqual(expected, actual, "Convert Error");
        }
    }
}
