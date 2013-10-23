using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoOOAbstrata
{
    public class Quadrado : Figura, IComparable<Quadrado>
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

        public int CompareTo(Quadrado outorQuadarado)
        {
            if(this.Lado > outorQuadarado.Lado)
            {
                return 1;
            }
            if (this.Lado < outorQuadarado.Lado)
            {
                return -1;
            }
            return 0;
        }
    }
}