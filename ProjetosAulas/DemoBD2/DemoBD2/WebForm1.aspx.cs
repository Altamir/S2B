using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoBD2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string conexString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["AdWorks"].ConnectionString;
            System.Data.SqlClient.SqlConnection conexao = new System.Data.SqlClient.SqlConnection(conexString);
            System.Data.SqlClient.SqlCommand comando = new System.Data.SqlClient.SqlCommand();

            comando.Connection = conexao;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT COUNT(*) FROM Production.Product";

            conexao.Open();
            int numProdutos = (int)comando.ExecuteScalar();
            conexao.Close();
            TextBox1.Text = numProdutos.ToString();
                
        }
    }
}