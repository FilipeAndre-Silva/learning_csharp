using System;

namespace Variáveris
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis em C#

            string vazia;
            vazia = "Atribuindo valor";
            Console.WriteLine(vazia);

            string nome_completo = "Filipe André da Silva";
            Console.WriteLine(nome_completo);

            int idade = 23;
            Console.WriteLine(idade);

            int valor1 = 100;
            valor1 = 50;
            Console.Write("Valor alterado antes da exibição para:");
            Console.WriteLine(valor1);

            const int vida = 1;
            Console.Write("Valor de costante não alteravel:");
            Console.WriteLine(vida);

            double peso = 84.5D;
            Console.WriteLine(peso);

            float valor_float = 5.75F;
            Console.WriteLine(valor_float);
            
            long myNum = 15000000000L;
            Console.WriteLine(myNum);

            char letra = 'F';
            Console.WriteLine(letra);

            bool vivo = true;
            Console.WriteLine(vivo);

            string outro_nome = "Concatenando";
            Console.WriteLine(outro_nome + " Strings");

            string nome = "Filipe ";
            string sobrenome = "André";
            Console.WriteLine(nome + sobrenome);

            int x = 5;
            int y = 8;
            Console.Write("Resultado Operações matemáticas de soma:");
            Console.WriteLine(x + y);

            int a = 1, b = 4, c = 7;
            Console.WriteLine(a + b + c);
        }
    }
}
