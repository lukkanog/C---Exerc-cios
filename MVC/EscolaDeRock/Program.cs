using System;
using System.Collections.Generic;
using EscolaDeRock.Interfaces;
using EscolaDeRock.Models;

namespace EscolaDeRock
{
    enum FormacaoMenu : uint
    {
        TRIO,
        QUARTETO
    }
    
    enum InstrumentosEnum : uint
    {
        BAIXO,
        BATERIA,
        CONTRABAIXO,
        GUITARRA,
        PIANO,
        VIOLÃO,
        TAMBORES
    }
    class Program
    {
        static void Main(string[] args)
        {

            var opcoesFormacao = new List<string>()
            {
                "   - 0                          ", // 32
                "   - 1                       " //28
            };

            bool querSair = false;
            string barra = "===================================";
            string[] itensMenuFormacao = Enum.GetNames(typeof(FormacaoMenu));
            int opcaoFormacaoSelecionada = 0;
            
            do
            {
                bool formacaoEscolhida = false;
                do
                {
                    Console.Clear();
                    System.Console.WriteLine(barra);
                    Console.BackgroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("\\m/       ESCOLA DE ROCK        \\m/");
                    Console.ResetColor();
                    System.Console.WriteLine("       Escolha sua formação:       ");  
                    System.Console.WriteLine(barra);

                    for (int i = 0; i < opcoesFormacao.Count; i++)
                    {
                        string titulo = TratarTituloMenu(itensMenuFormacao[i]);

                        if (opcaoFormacaoSelecionada == i)
                        {
                            DestacarOpcao(opcoesFormacao[i].Replace("-",">").Replace(i.ToString(),titulo));
                        }else
                        {
                            System.Console.WriteLine(opcoesFormacao[i].Replace(i.ToString(),titulo));
                            
                        }
                    }
                    var tecla = Console.ReadKey(true).Key;

                    switch (tecla)
                    {
                            case ConsoleKey.UpArrow:
                                opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == 0 ? opcaoFormacaoSelecionada = opcoesFormacao.Count - 1 : --opcaoFormacaoSelecionada;
                            break;
                            case ConsoleKey.DownArrow:
                                opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == opcoesFormacao.Count - 1 ? opcaoFormacaoSelecionada = 0 : ++opcaoFormacaoSelecionada;
                            break;
                            case ConsoleKey.Enter:
                                formacaoEscolhida = true;
                            break;
                    }
                } while (!formacaoEscolhida);

                bool bandaEstaCompleta = false;
                int vagas = 0;

                switch(opcaoFormacaoSelecionada)
                {
                    case 0:     
                        do
                        {
                            ExibirMenuDeInstrumentos();
                            System.Console.WriteLine("Digite o código do instrumento para a categoria Harmonia"); 
                            int codigo = int.Parse(Console.ReadLine());
                            var instrumento = Candidatos.Instrumentos[codigo];

                            Type interfaceEncontrada = instrumento.GetType().GetInterface("IHarmonia");

                            if (interfaceEncontrada != null)
                            {
                                vagas--;
                                ColocarNaBanda((IHarmonia)(instrumento));
                            } else
                            {
                                continue;
                            }

                            System.Console.WriteLine("Digite o código do instrumento para a categoria Percussão"); 
                            codigo = int.Parse(Console.ReadLine());
                            instrumento = Candidatos.Instrumentos[codigo];

                            interfaceEncontrada = instrumento.GetType().GetInterface("IPercussao");

                            if (interfaceEncontrada != null)
                            {
                                vagas--;
                                ColocarNaBanda((IPercussao)(instrumento));
                            } else
                            {
                                continue;
                            }

                            System.Console.WriteLine("Digite o código do instrumento para a categoria Melodia"); 
                            codigo = int.Parse(Console.ReadLine());
                            instrumento = Candidatos.Instrumentos[codigo];

                            interfaceEncontrada = instrumento.GetType().GetInterface("IMelodia");

                            if (interfaceEncontrada != null)
                            {
                                vagas--;
                                ColocarNaBanda((IMelodia)(instrumento));
                            } else
                            {
                                continue;
                            }

                            var instrumentos = Enum.GetNames (typeof (InstrumentosEnum));

                        } while (!bandaEstaCompleta);
                    break;
                    case 1:
                        do
                        {
                            ExibirMenuDeInstrumentos();
                            System.Console.WriteLine("Digite o código do instrumento para a categoria Harmonia"); 
                            int codigo = int.Parse(Console.ReadLine());
                            var instrumento = Candidatos.Instrumentos[codigo];

                            Type interfaceEncontrada = instrumento.GetType().GetInterface("IHarmonia");

                            if (interfaceEncontrada != null)
                            {
                                vagas--;
                                ColocarNaBanda((IHarmonia)(instrumento));
                            } else
                            {
                                continue;
                            }

                            System.Console.WriteLine("Digite o código do instrumento para a categoria Percussão"); 
                            codigo = int.Parse(Console.ReadLine());
                            instrumento = Candidatos.Instrumentos[codigo];

                            interfaceEncontrada = instrumento.GetType().GetInterface("IPercussao");

                            if (interfaceEncontrada != null)
                            {
                                vagas--;
                                ColocarNaBanda((IPercussao)(instrumento));
                            } else
                            {
                                continue;
                            }

                            System.Console.WriteLine("Digite o código do instrumento para a categoria Melodia"); 
                            codigo = int.Parse(Console.ReadLine());
                            instrumento = Candidatos.Instrumentos[codigo];

                            interfaceEncontrada = instrumento.GetType().GetInterface("IMelodia");

                            if (interfaceEncontrada != null)
                            {
                                vagas--;
                                ColocarNaBanda((IMelodia)(instrumento));
                            } else
                            {
                                continue;
                            }

                            System.Console.WriteLine("Digite o código do instrumento para a categoria Melodia"); 
                            codigo = int.Parse(Console.ReadLine());
                            instrumento = Candidatos.Instrumentos[codigo];

                            interfaceEncontrada = instrumento.GetType().GetInterface("IMelodia");

                            if (interfaceEncontrada != null)
                            {
                                vagas--;
                                ColocarNaBanda((IMelodia)(instrumento));
                            } else
                            {
                                continue;
                            }

                            var instrumentos = Enum.GetNames (typeof (InstrumentosEnum));

                        } while (!bandaEstaCompleta);
                    break;
                }

            } while (!querSair);
        }
        public static string TratarTituloMenu (string titulo) 
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase (titulo.Replace ("_", " ").ToLower ());
        }
        public static void DestacarOpcao (string opcao) 
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine (opcao);
            Console.ResetColor ();
        }
        
        public static void ExibirMenuDeInstrumentos () 
         {
            var instrumentos = Enum.GetNames (typeof (InstrumentosEnum));
            int codigo = 1;
            string menuInstrumentoBorda = "##############################";
            System.Console.WriteLine (menuInstrumentoBorda);
            System.Console.WriteLine ("#         Instrumentos        #");

            foreach (var instrumento in instrumentos) 
            {
                System.Console.WriteLine ($"  {codigo++}.{TratarTituloMenu(instrumento)}");
            }

            System.Console.WriteLine (menuInstrumentoBorda);

        }
        public static void ColocarNaBanda(IHarmonia instrumento)
        {
            instrumento.TocarAcordes();
        }
        public static void ColocarNaBanda(IPercussao instrumento)
        {
            instrumento.ManterRitmo();
        }
        public static void ColocarNaBanda(IMelodia instrumento)
        {
            instrumento.TocarSolo();
        }
    }
}
