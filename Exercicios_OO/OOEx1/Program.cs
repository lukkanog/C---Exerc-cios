using System;

namespace OOEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nBem vindo ao Cadeira Banco!");

            ContaCorrente conta1 = new ContaCorrente();//cria um objeto
            Console.WriteLine("Insira o nome do titular da conta 1:");
            conta1.titular = Console.ReadLine();
            Console.WriteLine("Digite a agencia dessa conta:");
            conta1.agencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número da conta: ");
            conta1.numeroConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Quanto você deseja depositar?");
            conta1.Depositar(double.Parse(Console.ReadLine()));
            // Console.WriteLine("Quanto você deseja sacar?");
            // bool resultado = conta1.Sacar(double.Parse(Console.ReadLine()));


            ContaCorrente conta2 = new ContaCorrente();
            Console.WriteLine("\nInsira o nome do titular da conta 2:");
            conta2.titular = Console.ReadLine();
            Console.WriteLine("Digite a agencia dessa conta:");
            conta2.agencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número da conta: ");
            conta2.numeroConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Quanto você deseja depositar?");
            conta2.Depositar(double.Parse(Console.ReadLine()));
            // Console.WriteLine("Quanto você deseja sacar?");
            // bool resultado2 = conta2.Sacar(double.Parse(Console.ReadLine()));


            Console.WriteLine($"\nTítular:{conta1.titular}");
            Console.WriteLine($"Agencia:{conta1.agencia}");
            Console.WriteLine($"Número da conta: {conta1.numeroConta}");
            Console.WriteLine($"Saldo atual:{conta1.saldo}");

            Console.WriteLine($"\nTítular:{conta2.titular}");
            Console.WriteLine($"Agencia:{conta2.agencia}");
            Console.WriteLine($"Número da conta: {conta2.numeroConta}");
            Console.WriteLine($"Saldo atual:{conta2.saldo}");
            
            Console.WriteLine("Quanto deseja transferir da conta1 para a conta2?");
            double valorTransferencia = double.Parse(Console.ReadLine());
            conta1.Transferir(valorTransferencia, conta2);

            bool resultadoTransferencia = true;
            do
            {
            Console.WriteLine("\nSALDOS APÓS A TRANSFERENCIA");
            Console.WriteLine($"Saldo da conta1: {conta1.saldo}");
            Console.WriteLine($"Saldo da conta2: {conta2.saldo}");
            }while (resultadoTransferencia != true);
        }
    }
}
