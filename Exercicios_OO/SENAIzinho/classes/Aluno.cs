using System;

namespace SENAIzinho
{
    public class Aluno
    {
        public string nome;
        public DateTime dataNascimento;
        public string curso;
        public int numeroSala;

       public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setDataDeNascimento(DateTime dataDeNascimento)
        {
            this.dataNascimento = dataDeNascimento;
        }

        public DateTime getDataDeNascimento() 
        {
            return this.dataNascimento;
        }

        public void setCurso(string curso)
        {
            this.curso = curso;
        }
        public string getCurso()
        {
            return this.curso;
        }

        public void setSala(int numeroSala)
        {
            this.numeroSala = numeroSala;
        }
        public int getSala()
        {
            return this.numeroSala;
        }


    }
}