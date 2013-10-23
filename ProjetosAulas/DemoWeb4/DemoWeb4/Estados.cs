using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoWeb4
{
    public class Estado
    {
        public String Nome { set; get; }
        public string Sigla { set; get; }
    }

    public class EstadosDoBrasil
    {
        public Estado[] Estados
        {
            get
            {
                Estado[] arranjo = new Estado[3];
                arranjo[0] = new Estado {Nome = "Rio Grande Do Sul",Sigla = "RS" };
                arranjo[1] = new Estado { Nome = "Santa Catarina", Sigla = "SC" };
                arranjo[2] = new Estado { Nome = "PArana", Sigla = "PR" };
                return arranjo;

            }
        }
    }
}