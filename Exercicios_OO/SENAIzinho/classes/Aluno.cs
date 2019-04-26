using System;
namespace SENAIzinho
{
    public class Aluno
    {
        public string Nome {get; set;}
        public DateTime DataNascimento {get; set;}
        public string Curso {get; set;}
        public int NumeroSala {get; set;}
        
        /* Construtor padrão */
        //public Aluno(){}

        /* Exemplo de construtor com restrição (parâmetro) */ 
        public Aluno(string nome) {
            this.Nome = nome;
        }
        
        /* Exemplo de construtor alternativo */ 
        // public Aluno(string nome, DateTime dataNascimento) {

        // }
    }

    
}