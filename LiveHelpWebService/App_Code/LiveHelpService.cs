using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for LiveHelpService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class LiveHelpService : System.Web.Services.WebService
{

    #region Default Items
    public LiveHelpService () 
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() 
    {
        return "Hello World";
    }

    #endregion


    [WebMethod]
    //public LiveHelp CreateNewCaseViaLiveHelpJason(string jsonInput)
    public LiveHelp CreateNewCaseViaLiveHelpJason(System.IO.Stream oStream)
    {
        try
        {
            LiveHelp lh = new LiveHelp();

            LiveHelpMethods lhm = new LiveHelpMethods();

            //lh = lhm.CreateCaseViaLiveHelp(jsonInput);
            lh = lhm.CreateCaseViaLiveHelp(oStream);

            return lh;
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
    }
  
}
