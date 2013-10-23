using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoOOAbstrata
{
    public abstract class Figura
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public abstract double CalculaArea();
    }
}