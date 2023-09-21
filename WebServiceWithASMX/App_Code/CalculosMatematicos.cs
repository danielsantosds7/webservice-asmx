using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for CalculosMatematicos
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class CalculosMatematicos : System.Web.Services.WebService
{

    public CalculosMatematicos()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public int Adicao(int x, int y)
    {
        return x + y;
    }
    [WebMethod]
    public int Subtracao(int x, int y)
    {
        return x - y;
    }
    [WebMethod]
    public int Multiplicacao(int x, int y)
    {
        return x * y;
    }
    [WebMethod]
    public int Divisao(int x, int y)
    {
        return x / y;
    }
}
