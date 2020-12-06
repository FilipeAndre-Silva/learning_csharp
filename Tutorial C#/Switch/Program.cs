using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# Switch
            //switch é usado para selecionar um dos muitos blocos de código a serem executados.

            //Exemplo
            Console.WriteLine("Sistema de CRUD Usuário");
            Console.WriteLine("1 - Inserir novo usuário");
            Console.WriteLine("2 - Listar usuários cadastrados");
            Console.WriteLine("3 - Alterar usuário cadastrado");
            Console.WriteLine("4 - Deletar usuário cadastrado");

            Console.Write("Digite um dos comandos:");
            string comando_string = Console.ReadLine();

            int comando_int = Convert.ToInt32(comando_string);

            switch(comando_int)
            {
                case 1:
                    Console.WriteLine("->renderiza cadastar.html");
                    break;
                
                case 2:
                    Console.WriteLine("->renderiza listar.html");
                    break;

                case 3:
                    Console.WriteLine("->renderiza alterar.html recebendo como argumento a PK do usuário");
                    break;
                
                case 4:
                    Console.WriteLine("->renderiza deletar.html recebendo como argumento a PK do usuário");
                    break;
                
                default:
                    Console.WriteLine("Nenhum comando valido inserido!, encerrando.");
                    break;
            }

            //break   -> sai do bloco de alternância.
            //default -> especifica algum código a ser executado se não houver correspondência.
        }
    }
}
