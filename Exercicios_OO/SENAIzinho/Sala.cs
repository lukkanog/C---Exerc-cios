namespace SENAIzinho
{
    public class Sala
    {
        public int numeroSala;
        public int capacidadeTotal;
        public int quantAtual;
        string[] alunos;

        public void setNumeroSala (int numeroSala)
        {
            this.numeroSala = numeroSala;
        }
        public int getNumeroSala()
        {
            return this.numeroSala;
        }

        public void setCapacidade(int capacidadetotal)
        {
            this.capacidadeTotal = capacidadeTotal;
        }
        public int getCapacidade()
        {
            return this.capacidadeTotal;
        }

        public void setQuantAtual (int quantAtual)
        {
            this.quantAtual = quantAtual;
        }
        public int getQuantAtual (int quantAtual)
        {
            return this.quantAtual;
        }

        
    }
}