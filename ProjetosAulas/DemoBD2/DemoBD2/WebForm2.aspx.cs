using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoBD2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var bd = new AdventureWorks2008_DataEntities();

            Currency moeda = new Currency();
            moeda.CurrencyCode = TextBox1.Text;
            moeda.Name = TextBox2.Text;
            moeda.ModifiedDate = DateTime.Now;

            var pais = (from crc in bd.CountryRegionCurrencies
                        where crc.CountryRegionCode == DropDownList1.SelectedValue
                        select crc).First();

            moeda.CountryRegionCurrencies.Add(pais);

            bd.Currencies.AddObject(moeda);    

            bd.SaveChanges();
        }
    }
}