using System;

namespace SENAIzinho
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[2];
            Sala[] salas = new Sala[2];
            int resposta;
            int alunosCadastrados=0;
            int salasCadastradas=0;


            do
            {
                Console.WriteLine("\n--------SENAIZINHO--------");
                Console.WriteLine("1 - Cadastrar Aluno");
                Console.WriteLine("2 - Cadastrar Sala");
                Console.WriteLine("3 - Alocar Aluno");
                Console.WriteLine("4 - Remover Aluno");
                Console.WriteLine("5 - Verificar Salas");
                Console.WriteLine("6 - Verificar Alunos");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("\nQual a opção desejada?");
                resposta = int.Parse(Console.ReadLine());

                switch (resposta)
                {
                    case 1:
                        Aluno a = new Aluno();
                        alunos[alunosCadastrados] = a;
                        Console.WriteLine("\nDigite o nome do aluno:");
                        a.setNome(Console.ReadLine());
                        Console.WriteLine("Data de nascimento do aluno:");
                        a.setDataDeNascimento(DateTime.Parse(Console.ReadLine()));
                        Console.WriteLine("Curso do aluno:");
                        a.setCurso(Console.ReadLine());
                        Console.WriteLine("Número da sala em que o aluno entrará:");
                        a.setSala(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Aluno registrado com sucesso");
                        alunosCadastrados ++;
                        break;
                    case 2:
                        Sala s = new Sala();
                        salas[salasCadastradas] = s;
                        Console.WriteLine("Digite o nº da sala:");
                        s.setNumeroSala(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Digite a capacidade dessa sala:");
                        s.setCapacidade(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Digite a quantidade atual de alunos:");
                        s.setQuantAtual(int.Parse(Console.ReadLine()));
                        salasCadastradas ++;
                        break;
                    case 3:
                        Console.WriteLine("Aluno a ser alocado:");
                        Console.WriteLine("Sala que o aluno entrará:");
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        foreach (var pessoa in alunos)
                        {
                            if (pessoa!=null)
                            {
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine($"Aluno: {pessoa.getNome().ToUpper()}");
                            Console.WriteLine($"Data de nascimento:{pessoa.getDataDeNascimento()}");
                            Console.WriteLine($"Curso: {pessoa.getCurso()}");
                            Console.WriteLine($"Sala: {pessoa.getSala()}");
                            }else
                            {
                                Console.WriteLine("Nenhum aluno foi cadastrado ainda");
                            }
                        }
                        break;
                    case 0:
                        Console.WriteLine("Programa encerrado.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }


            }while (resposta != 0);
            
    

        }
    }
}
