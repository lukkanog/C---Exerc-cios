namespace SENAIzinho {
    public class Sala {
        public int numeroSala;
        public int capacidadeTotal;
        public int quantAtual;
        public string[] alunos;

        public void setNumeroSala (int numeroSala) {
            this.numeroSala = numeroSala;
        }
        public int getNumeroSala () {
            return this.numeroSala;
        }

        public void setCapacidade (int capacidadeTotal) {
            this.capacidadeTotal = capacidadeTotal;
        }
        public int getCapacidade () {
            return this.capacidadeTotal;
        }

        public void setQuantAtual (int quantAtual) {
            this.quantAtual = quantAtual;
        }
        public int getQuantAtual (int quantAtual) {
            return this.quantAtual;
        }

        public void Remover(string alunoRemovido, Sala sala){
            sala.quantAtual--;
        }
        public void Transferir(Sala salaAntiga, Sala salaNova){
            salaAntiga.quantAtual++;
            salaNova.quantAtual--;
        }
    }
}