using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoOOAbstrata
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String tipo = DropDownFigura.SelectedValue;
            int tamanho = Int32.Parse(TxbTamanho.Text);
            double area = 0;

            Figura figura = null;

            if (tipo.Equals("quadrado"))
            {
                figura = new Quadrado { Lado = tamanho };
            }
            else if (tipo.Equals("circulo"))
            {
                figura = new Circulo { Raio = tamanho };
            }

            area = figura.CalculaArea();

            LbArea.Text = area.ToString();
                           
        }
    }
}