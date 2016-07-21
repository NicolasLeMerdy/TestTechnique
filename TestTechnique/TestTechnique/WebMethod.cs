using Newtonsoft.Json;
using System;
using System.Xml;
using System.Numerics;

namespace TestTechnique {
    public class WebMethod {

        public BigInteger FibonacciSequenceCalcul(double n) {

            BigInteger primValue = 0;
            BigInteger secondValue = 1;

            try{

                if(Math.Abs(n % 1) > 0) {
                    return -1;
                }

                if (n <= 0 || n > 100) {
                    return -1;
                }

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
            finally {
                Log.LogResponse("Fibonacci Succes" + "n = " + n + "response = " + primValue);
            }
        }

        public string XmlToJonReader(string xml) {
            try{

                XmlDocument docxml = new XmlDocument();
                docxml.LoadXml(xml);
                string jsonText = JsonConvert.SerializeXmlNode(docxml);
                return jsonText;

            }
            catch (Exception ex) {
                Log.LogError("XmlToJson", ex);
                return "Bad Xml format";
            }

        }

    }
}