using System;
using SENAIzinho.enums;

namespace SENAIzinho
{
    class Program
    {
        static void Main(string[] args)
        {

        
            int limiteAlunos = 3;
            int limiteSalas = 3;
            int limiteProfessores = 3;

            Aluno[] alunos = new Aluno[limiteAlunos];
            Sala[] salas = new Sala[limiteSalas];

            int alunosCadastrados = 0;
            int salasCadastradas = 0;

            bool querSair = false;
            do 
            {
                Console.Clear ();
                Console.ForegroundColor = ConsoleColor.Magenta;
                System.Console.WriteLine ("===================================");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Magenta;
                System.Console.WriteLine ("        *** SENAIzinho ***         ");
                Console.ResetColor ();
                System.Console.WriteLine ("         Seja bem-vindo(a)         ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                System.Console.WriteLine ("===================================");
                Console.ResetColor ();
                System.Console.WriteLine ("|| Digite sua opção:             ||");
                System.Console.WriteLine ("||  1 - Cadastrar Aluno          ||");
                System.Console.WriteLine ("||  2 - Cadastrar Sala           ||");
                System.Console.WriteLine ("||  3 - Alocar Aluno             ||");
                System.Console.WriteLine ("||  4 - Remover Aluno            ||");
                System.Console.WriteLine ("||  5 - Verificar Salas          ||");
                System.Console.WriteLine ("||  6 - Verificar Alunos         ||");
                System.Console.WriteLine ("||  0 - Sair                     ||");
                Console.ForegroundColor = ConsoleColor.Magenta;
                System.Console.WriteLine ("===================================");
                Console.ResetColor ();

                System.Console.Write ("Código: ");
                int codigo = int.Parse (Console.ReadLine ());

                switch (codigo) 
                {
                    #region CADASTRO_ALUNOS
                    case 1:
                        if (limiteAlunos >= alunosCadastrados)
                        {
                            Aluno aluno = new Aluno ();

                            System.Console.WriteLine ("Digite o nome do aluno");
                            aluno.nome = Console.ReadLine ();

                            System.Console.WriteLine ("Digite a data de nascimento (dd/mm/aaaa)");
                            aluno.dataNascimento = DateTime.Parse (Console.ReadLine ());

                            System.Console.WriteLine ("Digite o nome do curso");
                            aluno.curso = Console.ReadLine ();

                            alunos[alunosCadastrados] = aluno;

                            alunosCadastrados++;

                            MostrarMensagem($"Cadastro de {aluno.GetType().Name} concluído!", TipoMensagemEnum.SUCESSO);
                            
                        }else
                        {
                            MostrarMensagem($"\nLimite de {alunos.GetType().Name}s atingido", TipoMensagemEnum.ERRO);
                        }
                        break;
                    #endregion
                    #region CADASTRO_SALAS
                    case 2:
                    if (limiteSalas >= salasCadastradas)
                    {

                        Sala sala = new Sala ();

                        System.Console.WriteLine ("Digite o número da sala");
                        sala.numeroSala = int.Parse (Console.ReadLine ());

                        System.Console.WriteLine ("Digite a capacidade total");
                        sala.capacidadeTotal = int.Parse (Console.ReadLine ());

                        sala.capacidadeAtual = sala.capacidadeTotal;

                        sala.alunos = new string[sala.capacidadeTotal];

                        salas[salasCadastradas] = sala;

                        salasCadastradas++;

                        MostrarMensagem($"Cadastro de {sala.GetType().Name} concluído!", TipoMensagemEnum.SUCESSO);
                    }else
                    {
                        MostrarMensagem($"Limite de {salas.GetType().Name} atingido.", TipoMensagemEnum.ERRO);
                    }
                        break;
                    #endregion
                    #region ALOCAR_ALUNOS
                    case 3:
                        if (!ValidarAlocarOuRemover(alunosCadastrados,salasCadastradas))
                        {
                            continue;
                        }
                        System.Console.WriteLine("Digite o nome do aluno");
                        string nomeAluno = Console.ReadLine();
                        Aluno alunoRecuperado = ProcurarAlunoPorNome (alunos, nomeAluno);
                        //

                        if (alunoRecuperado == null) 
                        {
                            MostrarMensagem($"Aluno {nomeAluno} não encontrado!", TipoMensagemEnum.ALERTA);
                            continue;
                        }

                        // Recupera o numero da sala
                        System.Console.WriteLine("Digite o número da sala");
                        int numeroSala = int.Parse(Console.ReadLine());

                        // Busca pela Sala correta
                        Sala salaRecuperada = ProcurarSalaPorNumero (salas,numeroSala);
                        foreach (Sala item in salas)
                        {
                            if (item != null && numeroSala.Equals(item.numeroSala)) 
                            {
                                salaRecuperada = item;
                                break;
                            }
                        }

                        if (salaRecuperada == null) 
                        {
                            MostrarMensagem($"Sala {numeroSala} não encontrada!", TipoMensagemEnum.ALERTA);
                            continue;
                        }

                        //FixMe - Como exibir as mensagens em cores diferentes
                        MostrarMensagem(salaRecuperada.AlocarAluno(alunoRecuperado.nome), TipoMensagemEnum.DESTAQUE);

                        break;
                    
                    #endregion
                    #region REMOVER_ALUNOS
                    case 4:
                        if (!ValidarAlocarOuRemover(alunosCadastrados,salasCadastradas))
                        {
                            continue;
                        }

                        System.Console.WriteLine ("Digite o nome do aluno");
                        string nomeAlunoRemover = Console.ReadLine ();

                        Aluno alunoRemover = ProcurarAlunoPorNome (alunos, nomeAlunoRemover);

                        foreach (Aluno item in alunos) 
                        {
                            if (item != null && nomeAlunoRemover.Equals (item.nome)) 
                            {
                                alunoRemover = item;
                                break;
                            }
                        }

                        if (alunoRemover == null) 
                        {
                            MostrarMensagem($"Aluno {nomeAlunoRemover} não encontrado!",TipoMensagemEnum.ERRO);
                            continue;
                        }

                        // Recupera o numero da sala
                        System.Console.WriteLine ("Digite o número da sala");
                        int numeroSalaRemover = int.Parse (Console.ReadLine ());

                        // Busca pela Sala correta
                        Sala salaRemover = null;
                        foreach (Sala item in salas) 
                        {
                            if (item != null && numeroSalaRemover.Equals (item.numeroSala)) {
                                salaRemover = item;
                                break;
                            }
                        }

                        if (salaRemover == null) {
                            MostrarMensagem($"Sala {numeroSalaRemover} não encontrada!",TipoMensagemEnum.ERRO);
                        }

                        MostrarMensagem(salaRemover.RemoverAluno (alunoRemover.nome), TipoMensagemEnum.DESTAQUE);
                        break;
                    #endregion
                    #region VERIFICAR_SALAS
                    case 5:
                        foreach (var item in salas) 
                        {
                            if (item != null) 
                            {
                                System.Console.WriteLine ("-----------------------------------------------------");
                                System.Console.WriteLine ($"Número da sala: {item.numeroSala}");
                                System.Console.WriteLine ($"Vagas disponíveis: {item.capacidadeAtual}");
                                System.Console.WriteLine ($"Alunos: {item.ExibirAlunos()}");
                                System.Console.WriteLine ("-----------------------------------------------------");
                            }
                        }

                        System.Console.WriteLine ("Aperte ENTER para voltar ao menu principal");
                        Console.ReadLine ();
                        break;
                    #endregion
                    #region LISTAR_ALUNOS
                    case 6:
                        foreach (var item in alunos) 
                        {
                            if (item != null) 
                            {
                                System.Console.WriteLine ("-----------------------------------------------------");
                                System.Console.WriteLine ($"Nome do aluno: {item.nome}");
                                System.Console.WriteLine ($"Curso: {item.curso}");
                                System.Console.WriteLine ("-----------------------------------------------------");
                            }
                        }
                        System.Console.WriteLine ("Aperte ENTER para voltar ao menu principal");
                        Console.ReadLine ();
                        break;
                    #endregion
                }//end switch

            } while (!querSair);
        }
        static void MostrarMensagem(string mensagem, TipoMensagemEnum tipoMensagem)
        {
            switch (tipoMensagem)
            {
                case TipoMensagemEnum.SUCESSO:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case TipoMensagemEnum.ERRO:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case TipoMensagemEnum.ALERTA:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case TipoMensagemEnum.DESTAQUE:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                default:
                    break;
            }
            System.Console.WriteLine(mensagem);
            Console.ResetColor();
            System.Console.WriteLine("\nAperte ENTER para voltar oa menu principal");
            Console.ReadLine();
        }//END MostrarMensagem
        static bool ValidarAlocarOuRemover(int alunosCadastrados, int salasCadastradas)
        {
            if (alunosCadastrados == 0)
            {
                MostrarMensagem("Não há alunos cadastrados",TipoMensagemEnum.ALERTA);
                return false;
            }
            if (salasCadastradas == 0)
            {
                MostrarMensagem("Não há salas cadastradas", TipoMensagemEnum.ALERTA);
                return false;
            }
            return true;
        }//Validar
        static Aluno ProcurarAlunoPorNome (Aluno[] alunos, string nomeAluno)
        {
            foreach (Aluno item in alunos)
            {
                if (item != null && nomeAluno.Equals(item.nome)) 
                {
                    return item;
                }
            }
            return null;
        }
        static Sala ProcurarSalaPorNumero (Sala[] salas, int numeroSala)
        {
            foreach (Sala item in salas)
            {
                if (item != null && numeroSala.Equals(item.numeroSala)) 
                {
                    return item;
                }
            }
            return null;
        }
    }//END PROGRAM
}
