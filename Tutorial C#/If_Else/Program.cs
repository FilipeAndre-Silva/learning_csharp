using System;

namespace If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            //Condições C#

            //if executa o seu bloco caso a condição for True
            //Testando valores
            if(20 > 18)
            {
                Console.WriteLine("20 é maior que 18");
            }

            //Testando variáreis
            int x = 20;
            int y = 18;

            if(x > y)
            {
                Console.WriteLine("x é maior que y");
            }

            //Testando com else
            //else executa o seu bloco caso a condição do IF seja false
            int idade = 23;
            
            if(idade > 18)
            {
                Console.WriteLine("Maior de 18 anos");
            }
            else
            {
                Console.WriteLine("Menor de 18 anos");
            }

            //else if para especificar uma nova condição se a primeira condição for False
            int idade2 = 18;
            
            if(idade2 > 18)
            {
                Console.WriteLine("Maior de 18 anos");
            }
            else if(idade2 == 18)
            {
                Console.WriteLine("Tem 18 anos");
            }
            else
            {
                Console.WriteLine("Menor de 18 anos");
            }

            //Operador ternário
            //pode ser usado para substituir várias linhas de código por uma única linha
            string resultado = (idade > 18) ? "Maior de idade" : "Menos de idade";
            
            Console.WriteLine(resultado);
        }
    }
}
