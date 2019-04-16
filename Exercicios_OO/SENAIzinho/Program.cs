using System;

namespace SENAIzinho
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[2];
            Sala[] salas = new Sala[1];
            int resposta;
            int alunosCadastrados = 0;
            int salasCadastradas = 0;

            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n-----------SENAIZINHO----------");
                Console.WriteLine("||   1 - Cadastrar Aluno       ||");
                Console.WriteLine("||   2 - Cadastrar Sala        ||");
                Console.WriteLine("||   3 - Alocar Aluno          ||"); 
                Console.WriteLine("||   4 - Remover Aluno         ||");
                Console.WriteLine("||   5 - Verificar Salas       ||");
                Console.WriteLine("||   6 - Verificar Alunos      ||");
                Console.WriteLine("||   0 - Sair                  ||"); 
                Console.WriteLine("--------------------------------");
                Console.ResetColor();
                Console.Write("Qual a opção desejada? ");
                resposta = int.Parse(Console.ReadLine());

                switch (resposta)
                {
                    case 1:
                        if (alunosCadastrados < alunos.Length)
                        {
                            Aluno a = new Aluno();
                            alunos[alunosCadastrados] = a;
                            Console.WriteLine("\nDigite o nome do aluno:");
                            a.setNome(Console.ReadLine());
                            Console.WriteLine("Data de nascimento do aluno:");
                            a.setDataDeNascimento(DateTime.Parse(Console.ReadLine()));
                            Console.WriteLine("Curso do aluno:");
                            a.setCurso(Console.ReadLine());
                            // Console.WriteLine("Número da sala em que o aluno entrará:");
                            // a.setSala(int.Parse(Console.ReadLine()));
                            alunosCadastrados ++;

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Aluno registrado com sucesso");
                            Console.ResetColor();
                            Console.WriteLine("Aperte ENTER para retorna ao menu principal");
                            Console.ReadLine();
                        }else
                        {
                            Console.WriteLine("\nQuantidade máxima de alunos registrados");
                        }//end if
                        break;
                    case 2:
                        Sala s = new Sala();
                        salas[salasCadastradas] = s;
                        Console.WriteLine("\nDigite o nº da sala:");
                        s.setNumeroSala(int.Parse(Console.ReadLine()));

                        Console.WriteLine("Digite a capacidade dessa sala:");
                        s.setCapacidade(int.Parse(Console.ReadLine()));

                        // Console.WriteLine("Digite a quantidade atual de alunos:");
                        // s.setQuantAtual(int.Parse(Console.ReadLine()));
                        
                        s.setQuantAtual(s.getCapacidade());

                        s.alunos = new string[s.getCapacidade()];
                        salasCadastradas ++;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Sala cadastrada com sucesso");
                        Console.ResetColor();
                        Console.WriteLine("Aperte ENTER para retorna ao menu principal");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("\nAluno a ser alocado:");
                        Console.ReadLine();
                        Console.WriteLine("Sala que o aluno entrará:");
                        int.Parse(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("\nAluno a ser removido:");
                        break;
                    case 5:
                        foreach (var classe in salas)
                        {
                            if (classe != null)
                            {
                                Console.WriteLine("----------------------------");
                                Console.WriteLine($"Sala: {classe.getNumeroSala()}");
                                Console.WriteLine($"Vagas disponíveis atualmente: {classe.quantAtual}");
                                Console.WriteLine($"Capacidade máxima de alunos: {classe.getCapacidade()}");
                                Console.WriteLine("----------------------------");
                            }else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Ainda não há salas cadastradas");
                                Console.ResetColor();
                            }//end if
                        }//end foreach
                        Console.WriteLine("Aperte ENTER para retorna ao menu principal");
                        Console.ReadLine();
                        break;
                    case 6:
                        foreach (var pessoa in alunos)
                        {
                            if (pessoa != null)
                            {
                                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                Console.WriteLine($"Aluno: {pessoa.getNome().ToUpper()}");
                                Console.WriteLine($"Data de nascimento:{pessoa.getDataDeNascimento():dd/MM/yyyy}");
                                Console.WriteLine($"Curso: {pessoa.getCurso()}");
                                Console.WriteLine($"Sala: {pessoa.getSala()}");
                                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                            }else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Nenhum aluno foi cadastrado ainda");
                                Console.ResetColor();
                            }//end if
                        }//end foreach
                        Console.WriteLine("Aperte ENTER para retorna ao menu principal");
                        Console.ReadLine();
                        break;
                    case 0:
                        Console.WriteLine("\nPrograma encerrado.");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida");
                        break;
                }//end switch
            }while (resposta != 0);
        }//END OF THE WORLD
    }
}
