﻿using System;
using SENAIzinho;

namespace SENAIzinho
{
    class Program
    {
        enum MenuEnum : uint{
            CADASTRAR_ALUNO = 1,
            CADASTRAR_SALA,
            LISTAR_SALAS,
            LISTAR_ALUNOS,
            ALOCAR_ALUNO,
            REMOVER_ALUNO,
        }
        static void Main (string[] args) {
            
            int limiteAlunos = 5;
            int limiteSalas = 2;
            // int limiteProfessores = 2;

            Aluno[] alunos = new Aluno[limiteAlunos];
            Sala[] salas = new Sala[limiteSalas];

            int alunosCadastrados = 0;
            int salasCadastradas = 0;

            string[] itensMenu = Enum.GetNames(typeof(MenuEnum));
            string barraMenu = "===================================";

            bool querSair = false;
            do {
                //HEADER
                Console.Clear ();
                Console.ForegroundColor = ConsoleColor.Magenta;
                System.Console.WriteLine (barraMenu);
                System.Console.WriteLine ("        *** SENAIzinho ***         ");
                Console.ResetColor ();
                System.Console.WriteLine ("         Seja bem-vindo(a)         ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                System.Console.WriteLine (barraMenu);
                Console.ResetColor();
                System.Console.WriteLine ("|| Digite sua opção:             ||");
                
                //BODy -- opções do menu
                for (int i = 0; i < itensMenu.Length; i++) {
                    string espacosFim = "";
                    string bordaLinha = "||";
                    string paragrafoInicio = "   ";
                    string separadorOpcao = " - ";

                    string nomeTratado = itensMenu[i].Replace ("_", " ").ToLower ();//troca o underline do enums por um espaço e deixa em minusculo
                    nomeTratado = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase (nomeTratado);//deixa as primeiras letras maiúsculas
                    int espacoDezena = i / 10;
                    
                    string numeroOpcao = (i + 1).ToString();

                    if (espacoDezena < 1) {
                        paragrafoInicio = paragrafoInicio + " ";
                    }

                    int qntdeEspacos = barraMenu.Length - (bordaLinha.Length * 2) - paragrafoInicio.Length - numeroOpcao.Length - separadorOpcao.Length - nomeTratado.Length;

                    for (int j = 0; j < qntdeEspacos; j++) {
                        espacosFim += " ";
                    }
                    
                    System.Console.WriteLine ($"{bordaLinha}{paragrafoInicio}{numeroOpcao}{separadorOpcao}{nomeTratado}{espacosFim}{bordaLinha}");
                }

                //FOOTER
                System.Console.WriteLine ("||    0 - Sair                   ||");
                Console.ForegroundColor = ConsoleColor.Magenta;
                System.Console.WriteLine (barraMenu);
                Console.ResetColor();

                string mensagem = "";

                System.Console.Write ("Código: ");
                MenuEnum codigo = (MenuEnum) Enum.Parse (typeof(MenuEnum), Console.ReadLine());

                switch (codigo) {
                    #region CADASTRO_ALUNOS
                    case MenuEnum.CADASTRAR_ALUNO:
                        if (limiteAlunos != alunosCadastrados) 
                        {
                            System.Console.WriteLine ("Digite o nome do aluno");

                            Aluno aluno = new Aluno (Console.ReadLine ());

                            System.Console.WriteLine ("Digite a data de nascimento (dd/mm/aaaa)");
                            aluno.DataNascimento = DateTime.Parse (Console.ReadLine ());

                            aluno.Curso = ExibirMenuCursos();

                            alunos[alunosCadastrados] = aluno;

                            alunosCadastrados++;
                            
                            MostrarMensagem($"\nCadastro de {aluno.GetType().Name} concluído!", TipoMensagemEnum.SUCESSO);

                        } else {
                            MostrarMensagem ($"\nLimite de alunos atingido!", TipoMensagemEnum.ERRO);
                        }
                        
                        break;
                    #endregion
                    #region CADASTRO_SALAS
                    case MenuEnum.CADASTRAR_SALA:
                        if (limiteSalas != salasCadastradas) {
                            
                            System.Console.WriteLine ("Digite o número da sala");
                            int numSala = int.Parse (Console.ReadLine ());

                            System.Console.WriteLine ("Digite a capacidade total");
                            int capacidadeTotal = int.Parse (Console.ReadLine ());

                            Sala sala = new Sala (numSala, capacidadeTotal);

                            salas[salasCadastradas] = sala;

                            salasCadastradas++;

                            MostrarMensagem($"Cadastro de {sala.GetType().Name} concluído!", TipoMensagemEnum.SUCESSO);
                        } 
                        else 
                        {
                            MostrarMensagem($"Limite de salas atingido!", TipoMensagemEnum.ERRO);
                        }
                        
                        break;
                    #endregion
                    #region ALOCAR_ALUNO
                    case MenuEnum.ALOCAR_ALUNO:
                        if (!ValidarAlocarOuRemover(alunosCadastrados, salasCadastradas)) {
                            continue;
                        }

                        System.Console.WriteLine ("Digite o nome do aluno");
                        string nomeAluno = Console.ReadLine ();

                        Aluno alunoRecuperado = ProcurarAlunoPorNome(alunos, nomeAluno);

                        if (alunoRecuperado == null) {
                            MostrarMensagem($"Aluno {nomeAluno} não encontrado!", TipoMensagemEnum.ALERTA);
                            continue;
                        }

                        // Recupera o numero da sala
                        System.Console.WriteLine ("Digite o número da sala");
                        int numeroSala = int.Parse (Console.ReadLine ());

                        // Busca pela Sala correta
                        Sala salaRecuperada = ProcurarSalaPorNumero(salas, numeroSala);
                        
                        if (salaRecuperada == null) {
                            MostrarMensagem($"Sala {numeroSala} não encontrada!", TipoMensagemEnum.ALERTA);
                            continue;
                        }

                
                        if (salaRecuperada.AlocarAluno (alunoRecuperado, out mensagem)) {
                            MostrarMensagem(mensagem, TipoMensagemEnum.SUCESSO);
                        } else {
                            MostrarMensagem(mensagem, TipoMensagemEnum.ERRO);
                        }
                        

                        break;
                    #endregion
                    #region REMOVER_ALUNO
                    case MenuEnum.REMOVER_ALUNO:
                        if (!ValidarAlocarOuRemover(alunosCadastrados, salasCadastradas)) {
                            continue;
                        }

                        System.Console.WriteLine ("Digite o nome do aluno");
                        string nomeAlunoRemover = Console.ReadLine ();

                        Aluno alunoRemover = ProcurarAlunoPorNome(alunos, nomeAlunoRemover);

                        if (alunoRemover == null) {
                            MostrarMensagem($"Aluno {nomeAlunoRemover} não encontrado!", TipoMensagemEnum.ALERTA);
                            continue;
                        }

                        // Recupera o numero da sala
                        System.Console.WriteLine ("Digite o número da sala");
                        int numeroSalaRemover = int.Parse (Console.ReadLine ());

                        // Busca pela Sala correta
                        Sala salaRemover = ProcurarSalaPorNumero(salas, numeroSalaRemover);

                        if (salaRemover == null) {
                            MostrarMensagem($"Sala {numeroSalaRemover} não encontrada!", TipoMensagemEnum.ALERTA);
                            continue;

                        }

                       
                        if (salaRemover.RemoverAluno (alunoRemover.Nome, out mensagem))
                        {
                            MostrarMensagem(mensagem, TipoMensagemEnum.SUCESSO);
                        } else {
                            MostrarMensagem(mensagem, TipoMensagemEnum.ERRO);
                        }
                        
                        break;
                    #endregion
                    #region LISTAR_SALAS
                    case MenuEnum.LISTAR_SALAS:
                        foreach (var item in salas) 
                        {
                            if (item != null) 
                            {
                                System.Console.WriteLine ("-----------------------------------------------------");
                                System.Console.WriteLine ($"Número da sala: {item.NumeroSala}");
                                System.Console.WriteLine ($"Vagas disponíveis: {item.CapacidadeAtual}");
                                System.Console.Write ($"Alunos: \n{item.ExibirAlunos()}");
                                System.Console.WriteLine ("-----------------------------------------------------");
                            }
                        }
                        System.Console.WriteLine ("Aperte ENTER para voltar ao menu principal");
                        Console.ReadLine ();
                        break;
                    #endregion
                    #region LISTAR_ALUNOS
                    case MenuEnum.LISTAR_ALUNOS:
                        foreach (var item in alunos) 
                        {
                            if (item != null) 
                            {
                                System.Console.WriteLine ("-----------------------------------------------------");
                                System.Console.WriteLine ($"Nome do aluno: {item.Nome}");
                                System.Console.WriteLine ($"Curso: {item.Curso}");
                                System.Console.WriteLine ("-----------------------------------------------------");
                            }
                        }
                        System.Console.WriteLine ("Aperte ENTER para voltar ao menu principal");
                        Console.ReadLine ();

                        break;
                    #endregion
                    #region SAIR
                    case 0:
                        Console.WriteLine("Programa Encerrado");
                        querSair = true;
                        break;
                    default:
                        MostrarMensagem("Opção inválida", TipoMensagemEnum.ERRO);
                        break;
                    #endregion
                }

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

            System.Console.WriteLine("\nAperte ENTER para voltar ao menu principal");
            Console.ReadLine();
        }

        static bool ValidarAlocarOuRemover(int alunosCadastrados, int salasCadastradas) {
            if (alunosCadastrados == 0) {
                MostrarMensagem("Não há alunos cadastrados!", TipoMensagemEnum.ALERTA);
                return false;
            }

            if (salasCadastradas == 0) {
                MostrarMensagem("Não há salas cadastradas!", TipoMensagemEnum.ALERTA);
                return false;
            }

            return true;
        }

        static Aluno ProcurarAlunoPorNome(Aluno[] alunos, string nome) 
        {
            foreach (Aluno item in alunos) {
                if (item != null && nome.Equals (item.Nome)) {
                    return item;
                }
            }
            return null;
        }

        static Sala ProcurarSalaPorNumero(Sala[] salas, int numeroSala) {
            foreach (Sala item in salas) {
                if (item != null && numeroSala.Equals (item.NumeroSala)) {
                    return item;
                }
            }
            return null;
        }
        static string ExibirMenuCursos()
        {
            bool cursoNaoEscolhido = true;
            string curso = "";
            do
            {
                System.Console.WriteLine ("===================================");
                System.Console.WriteLine ("|| Digite o código do curso      ||");
                System.Console.WriteLine ("||  1 - DESENVOLVIMENTO          ||");
                System.Console.WriteLine ("||  2 - REDES                    ||");
                System.Console.WriteLine ("===================================");
                int codigoCurso = int.Parse(Console.ReadLine());
                
                switch (codigoCurso)
                {
                    case 1:
                        curso = "DESENVOLVIMENTO";
                        cursoNaoEscolhido = false;
                        break;
                    case 2:
                        curso = "REDES";
                        cursoNaoEscolhido = false;
                        break;
                    default:
                        MostrarMensagem("Resposta inválida", TipoMensagemEnum.ALERTA);
                        break;
                }
            } while (cursoNaoEscolhido);
            return curso;        }
    }
}
