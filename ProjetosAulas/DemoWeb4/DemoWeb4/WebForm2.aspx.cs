﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb4
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EstadosDoBrasil estados = new EstadosDoBrasil();
            DropDLEstados.DataSource = estados.Estados;
            DropDLEstados.DataTextField = "Nome";
            DropDLEstados.DataValueField = "Sigla";
            DropDLEstados.DataBind();
        }

        protected void BtEnviar_Click(object sender, EventArgs e)
        {
            LbEstado.Text = DropDLEstados.SelectedValue;
        }
    }
}