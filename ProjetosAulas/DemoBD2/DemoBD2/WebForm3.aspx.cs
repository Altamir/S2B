using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoBD2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public List<Currency> BuscarMoedas()
        {
            var bd = new AdventureWorks2008_DataEntities();
            var moedas = from moeda in bd.Currencies
                         orderby moeda.Name
                         select moeda;
            return moedas.ToList();
        }
    }
}