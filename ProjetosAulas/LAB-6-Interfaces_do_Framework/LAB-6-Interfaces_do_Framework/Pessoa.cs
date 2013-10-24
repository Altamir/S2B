using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LAB_6_Interfaces_do_Framework
{
    public class Pessoa : IComparable<Pessoa>
    {
        private string meuNome;
        private int minhaIdade;

        public Pessoa(string n, int i)
        {
            meuNome = n;
            minhaIdade = i;
        }

        public string Nome
        {
            get { return meuNome; }
        }

        public int Idade
        {
            get { return minhaIdade; }
            set { minhaIdade = value; }
        }


        public int CompareTo(Pessoa other)
        {
            if (this.minhaIdade > other.minhaIdade)
            {
                return 1;
            }
            if (this.minhaIdade < other.minhaIdade)
            {
                return -1;
            }
            return 0;
        }
    }
}