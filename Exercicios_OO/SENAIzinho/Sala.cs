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

        public string Transferir(string nomeAluno){
            quantAtual--;
            if (quantAtual >= 0 )
            {
                alunos[quantAtual] = nomeAluno;
                return $"Aluno {nomeAluno} alocado com sucesso!";
            }else
            {
                quantAtual = 0;
                return $"A capacidade da sala {numeroSala} foi excedida";
            }
        }
        public string ExibirAlunos(){
            string nomeAlunos = "";
            foreach (var item in alunos)
            {
                if (item != null)
                {
                    nomeAlunos += item + " ";
                }
            }
            return nomeAlunos;
        }

        public string RemoverAluno(string nomeAlunoRemovido)
        {
            quantAtual ++;
            alunos[quantAtual] = null;
            return $"O aluno {nomeAlunoRemovido} foi removido com sucesso!";
        }
    }
}