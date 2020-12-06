using System;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int valor1 = 10;
            int valor2 = 2;

            //Operadores aritméticos
            int soma = valor1 + valor2;

            int subtracao = valor1 - valor2;

            int multiplicacao = valor1 * valor2;

            int divisao = valor1 / valor2;

            int modulo = valor1 % valor2;

            valor1--;
            valor2++;

            valor2 -= 1;
            valor1 += 1;

            //Operadores de comparação
            bool equal = valor1 == valor2;

            bool not_equal = valor1 != valor2;

            bool maior_q = valor1 > valor2;

            bool menor_q = valor1 < valor2;

            bool maior_equal = valor1 >= valor2;

            bool menor_equal = valor1 <= valor2;
            
            //Operadores lógicos
            /* 
            && -> E
            || -> OU
            !  -> Not
            */

        }
    }
}
