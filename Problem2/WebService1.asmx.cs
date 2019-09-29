using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;

namespace Problem2
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        public string ValidateMethod()
        {
            string source = "C://Users//dell//Desktop//Input//";
            string error = "C://Users//dell//Desktop//ErrorFile//";
            string filename = "valid.xml";
            string filename2 = "invalid.xml";

            if (File.Exists(Path.Combine(source, filename)))
            {
                string destination = System.IO.Path.Combine(source, filename);
                System.IO.File.Delete(destination);
                return true + " 200 OK";

            }
            else
            {
                string destination = System.IO.Path.Combine(source, filename2);
                string errordestination = System.IO.Path.Combine(error, filename2);

                System.IO.File.Move(destination, errordestination);
                return false + "500 status(internal server error).";

            }


        }
    }
   

}
