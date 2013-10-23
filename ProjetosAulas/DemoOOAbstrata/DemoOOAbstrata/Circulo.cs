using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoOOAbstrata
{
    public class Circulo : Figura
    {
        public int Raio { set; get; }

        public override double CalculaArea()
        {
            return Math.PI * Raio * Raio;
        }

        public override string Desenhar()
        {
            return "Um Circulo!";
        }
    }
}