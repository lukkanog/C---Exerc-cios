    using System;

namespace PassagensOO
{
    class Passageiro
    {
        string nome;
        int numeroPassagem;
        DateTime data;

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setNumeroPassagem(int numeroPassagem)
        {
            this.numeroPassagem=numeroPassagem;
        }
        public int getNumeroPassagem()
        {
            return this.numeroPassagem;
        }

        public void setData(DateTime data)
        {
            this.data=data;
        }
        public DateTime getData()
        {
            return this.data;
        }

    }
}
