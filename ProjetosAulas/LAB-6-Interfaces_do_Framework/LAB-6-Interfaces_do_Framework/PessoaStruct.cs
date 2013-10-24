namespace LAB_6_Interfaces_do_Framework
{
    public struct PessoaStruct
    {
        private string meuNome;
        private int minhaIdade;

        public PessoaStruct(string n, int i)
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
    }
}