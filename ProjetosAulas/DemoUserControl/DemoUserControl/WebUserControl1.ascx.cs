using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace DemoUserControl
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
    
        private Color cor;

        public Color Cor{
            get{

                string corDigitada = TextBox1.Text;

                switch(corDigitada.ToLower()){
                    case "azul":
                        cor = Color.Blue;
                        break;
                    case "vermelho":
                        cor = Color.Red;
                        break;
                    default: 
                        cor = Color.Transparent;
                        break;
                }
                return cor;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}