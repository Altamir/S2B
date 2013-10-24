using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LAB_6_Interfaces_do_Framework
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] lista = { "Alexandre", "Julia", "Daniel", "Gabriel" };
            Response.Write("Array antes da ordenação<br/>");
            foreach (string nome in lista)
            {
                Response.Write(nome + " ");
            }
            Response.Write("<br/>");
            Array.Sort(lista);
            Response.Write("Array depois da ordenação<br/>");
            foreach (string nome in lista)
            {
                Response.Write(nome + " ");
            }

            Response.Write("<br/>");
            Pessoa[] lista2 = 
            {  
                new Pessoa("Amanda", 25),
                new Pessoa("Ana", 28),
                 new Pessoa("Paulo", 20)
            };

            Array.Sort(lista2);

            Response.Write("Array depois da ordenação<br/>");


            foreach (Pessoa p in lista2)
            {
                Response.Write(p.Nome + " ");
            }


            //Exerci 4
            Response.Write("<br/>");
            Array.Sort(lista2, new ComparadorIdadePessoa());
            Response.Write("Array depois da ordenação<br/>");
            foreach (Pessoa p in lista2)
            {
                Response.Write(p.Nome + " ");
            }



        }
    }
}