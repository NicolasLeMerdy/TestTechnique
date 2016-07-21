using System;
using System.Web.Services;

namespace TestTechnique {
    /// <summary>
    /// Description résumée de WebService
    /// </summary>
    [WebService(Namespace = "http://locahost/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService {

        [WebMethod(Description = "The Fibonacci service takes input an integer N, and return the Nhh value in the Fibonacci sequence")]
        public string Fibonacci(double n) {
            try {
                
                WebMethod fibo = new WebMethod();
                return fibo.FibonacciSequenceCalcul(n).ToString();
            }
            catch (Exception ex) {
                Log.LogError("Fibonacci", ex);
                return "-1";
            }
        }

        [WebMethod(Description = @"The XmlToJson service takes input a string xml and returns the json form of the xml string, lt will return ""Bad Xml format"" if the input string is not a well - formed xml")]
        public string XmlToJson(string xml) {
            try {
                WebMethod xmlJson = new WebMethod();
                return xmlJson.XmlToJonReader(xml);
            }
            catch (Exception ex) {
                Log.LogError("XmlToJson", ex);
                return "Bad Xml format";
            }
        }
    }
}
