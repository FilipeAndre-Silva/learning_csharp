using System;

namespace Entrada_do_usuário
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obtenha a opinião do usuário
            Console.WriteLine("Digite seu UserName:");
            string username = Console.ReadLine();

            Console.WriteLine("Bem Vindo ! " + username);

            Console.WriteLine("Digite sua idade:");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sua idade atual é: " + idade);


        }
    }
}
