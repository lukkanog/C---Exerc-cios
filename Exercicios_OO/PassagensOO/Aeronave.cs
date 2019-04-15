using System;

namespace PassagensOO
{
    class Aeronave
    {
        string modelo;
        short quantPassageiros;
        short capacidade;

        public void setModelo(string modelo)
        {
            this.modelo=modelo;
        }
        public string getModelo()
        {
            return this.modelo;
        }

        public void setQuantPassageiros(short quantPassageiros)
        {
            this.quantPassageiros=quantPassageiros;
        }
        public short getQuantPassageiros()
        {
            return this.quantPassageiros;
        }

        public void setCapacidade(short capacidade)
        {
            this.capacidade=capacidade;
        }
        public short getCapacidade()
        {
            return this.capacidade;
        }

    }
}
