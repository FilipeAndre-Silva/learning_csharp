using System;

namespace Métodos_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Um método é um bloco de código que só executa quando é chamado.
            //São usados ​​para realizar certas ações e também são conhecidos como funções.
            //Definindo o código uma vez e use-o várias vezes.

            //Crie um método
            static void MyMethod()
            {
                //Código que será executado ao chamar o método que o envolve.
            }
            
            //Chame um Método
            MyMethod();

            //Exemplo de método com funcionalidade
            static void RetornandoConsole()
            {
                Console.WriteLine("Método foi executado");
            }

            RetornandoConsole();
            RetornandoConsole();
            RetornandoConsole();
        }
    }
}
