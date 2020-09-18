using System;

namespace OlaUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o seu nome: ");
            string NomeUsuario = Console.ReadLine();
            Console.Write("Olá, ");
            Console.Write(NomeUsuario);
            Console.WriteLine("!");
        }
    }
}
