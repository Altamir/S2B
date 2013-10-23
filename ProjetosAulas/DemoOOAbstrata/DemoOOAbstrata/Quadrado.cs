using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoOOAbstrata
{
    public class Quadrado : Figura
    {
        public int Lado { set; get; }

        public override double CalculaArea()
        {
            return Lado * Lado;
        }

        public override string Desenhar()
        {
            return "Um quadrado!";
        }
    }
}