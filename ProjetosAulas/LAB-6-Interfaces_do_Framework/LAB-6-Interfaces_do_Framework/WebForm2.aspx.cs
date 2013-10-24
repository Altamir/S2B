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
            UsandoStruct();

            UsandoDicionario();
        }

        private void UsandoDicionario()
        {
            IDictionary<string, Pessoa> dic;

            dic = new Dictionary<string, Pessoa>();

            dic.Add("111111111-11", new Pessoa("Carlos", 21));
            dic.Add("222222222-11", new Pessoa("Marcos", 41));
            dic.Add("333333333-11", new Pessoa("MArias", 23));
            dic.Add("444444444-11", new Pessoa("Ana", 01));

            Pessoa ps = dic["111111111-11"];

            foreach (var coisa in dic)
            {
                Response.Write(coisa.Key);
                Response.Write(coisa.Value.Nome);
            }

            var ordena = from p in dic.Values
                         orderby p.Nome
                         select p.Nome;

            foreach (var p in ordena)
            {
                Response.Write(p);
            }


        }

        private void UsandoStruct()
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