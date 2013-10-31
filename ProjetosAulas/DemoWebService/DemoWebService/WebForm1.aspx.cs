using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWebService
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.GlobalWeatherSoapClient ws = new ServiceReference1.GlobalWeatherSoapClient();
            Label1.Text = ws.GetCitiesByCountry("brazil");
        }
    }
}