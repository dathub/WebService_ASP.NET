using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://dumindut.lk/example/webservice")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        //[WebMethod] annotation makes the following method a public operation in a publically available web service
        //ASP.net generte this both as SOAP based WebService and as RESTFUL WebService at the same time.
        [WebMethod]
        public string getServiceName()
        {
            return "Test Web Service";
        }

        [WebMethod]
        public double addNumbers(double n1, double n2)
        {
            return n1 + n2;
        }
    }
}
 