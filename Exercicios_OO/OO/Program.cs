using System;

namespace OO
{
    class Program// classe principal
    {
        static void Main(string[] args)//  o main é um método (tem q ter)
        {
            usuario usuario = new usuario();
            System.Console.WriteLine(usuario.InserirSenha());

        }
    }
}
