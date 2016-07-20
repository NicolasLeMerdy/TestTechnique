using Newtonsoft.Json;
using System;
using System.Xml;

namespace TestTechnique {
    public class WebMethod {

        public double FibonacciSequenceCalcul(double n) {
            try {

                if (n <= 0 || n > 100) {
                    return -1;
                }

                double primValue = 0;
                double secondValue = 1;

                for (var i = 1; i <= n; i++) {
                    var concatValue = primValue;
                    primValue = secondValue;
                    secondValue = concatValue + secondValue;
                }

                return primValue;
            }
            catch (Exception ex) {
                Log.LogError("Fibonacci", ex);
                return -1;
            }
        }

        public string XmlToJonReader(string xml) {
            try {

                XmlDocument Docxml = new XmlDocument();
                Docxml.LoadXml(xml);
                string jsonText = JsonConvert.SerializeXmlNode(Docxml);
                return jsonText;

            }
            catch (Exception ex) {
                Log.LogError("XmlToJson", ex);
                return "Bad Xml format";
            }

        }

    }
}