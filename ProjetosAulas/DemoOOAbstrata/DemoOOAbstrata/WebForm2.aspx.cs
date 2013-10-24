using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace DemoOOAbstrata
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Quadrado[] figuras = new Quadrado [3];

            figuras[0] = new Quadrado { Lado = 5 };
            figuras[1] = new Quadrado { Lado = 3 };
            figuras[2] = new Quadrado { Lado = 7 };

            Array.Sort(figuras);

            StringBuilder texto = new StringBuilder();
            foreach (var quadrado in figuras)
            {
                texto.Append(quadrado.Lado + " , ");
            }

            Label1.Text = texto.ToString();

        }
    }
}