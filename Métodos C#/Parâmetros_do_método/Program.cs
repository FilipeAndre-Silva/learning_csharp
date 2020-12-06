using System;

namespace Parâmetros_do_método
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parâmetros e Argumentos
            //As informações podem ser passadas aos métodos como parâmetro.
            //Os parâmetros atuam como variáveis ​​dentro do método.

            //Exemplo
            static void BoasVindas(string nome)
            {
                Console.WriteLine("Bem vindo " + nome);
            }

            BoasVindas("Filipe");

            //Valor do parâmetro padrão
            static void BoasVindas1(string nome = "Valor Padrão")
            {
                Console.WriteLine("Bem vindo " + nome);
            }
            BoasVindas1("Lucas");
            BoasVindas1();
            BoasVindas1("Cleiton");

            //Parâmetros múltiplos
            static void ImprimeSoma(int valor1, int valor2)
            {
                int resultadoSoma = valor1 + valor1;
                Console.WriteLine(resultadoSoma);
            }
            ImprimeSoma(2,2);

            //Valores Retornados
            static int RetornaSoma(int valorA, int valorB)
            {
                int resultadoSoma = valorA + valorB;
                return resultadoSoma;
            }

            
            Console.WriteLine(RetornaSoma(10, 1));
            //ou
            int resultadoSoma = RetornaSoma(10, 1);
            Console.WriteLine(resultadoSoma);

            //Argumentos Nomeados
            static void MyMethodNomead(string child1, string child2, string child3) 
            {
                Console.WriteLine("The youngest child is: " + child3);
            }

            MyMethodNomead(child3: "John", child1: "Liam", child2: "Liam");

            //OU

            static void MyMethodNomead2(string child1 = "Liam", string child2 = "Jenny", string child3 = "John")
            {
                Console.WriteLine(child3);
            }

            MyMethodNomead2("child3");
        }
    }
}
