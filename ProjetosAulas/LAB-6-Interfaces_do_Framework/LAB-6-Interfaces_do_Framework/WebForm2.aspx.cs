using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LAB_6_Interfaces_do_Framework
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PessoaStruct ps;
            ps = new PessoaStruct("Altamir", 29);
            PessoaStruct ps2 = ps;
            ps2.Idade = 30;
            Response.Write(ps.Nome);
            Response.Write(ps.Idade);
        }
    }
}