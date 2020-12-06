using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //São usadas para armazenar vários valores em uma única variável.
            string[] valores_strings = {"Filipe", "Lucas", "Silva"};
            int[] valores_int = {10, 20, 30, 40};

            //Acesse os elementos de um array
            Console.WriteLine(valores_strings[0]);

            //Alterar um elemento de array
            valores_int[0] = 100;

            //Comprimento do array
            Console.WriteLine(valores_strings.Length);

            //Loop por meio de uma array
            string[] nomes = {"Filipe", "André", "Silva"};
            
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(nomes[i]);
            }

            //O loop foreach
            string[] usuarios = {"User1", "Lucas", "Olimpios"};

            foreach (string i in usuarios)
            {
                Console.WriteLine(i);
            }

            //Classificar arrays
            //Sort() classifica um array em ordem alfabética ou em ordem crescente
            string[] carros = {"Volvo", "BMW", "Ford", "Mazda"};
            Array.Sort(carros);
            foreach (string i in carros)
            {
                Console.WriteLine(i);
            }

            int[] myNumbers = {5, 1, 8, 9};
            Array.Sort(myNumbers);
            foreach (int i in myNumbers)
            {
                Console.WriteLine(i);
            }

            //Namespace System.Linq
            int[] valores = {5, 1, 8, 9};
            Console.WriteLine(valores.Max());
            Console.WriteLine(valores.Min());
            Console.WriteLine(valores.Sum());

            //Outras maneiras de criar um array
            string[] cars0 = new string[4];

            string[] cars1 = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

            string[] cars2 = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

            string[] cars3 = {"Volvo", "BMW", "Ford", "Mazda"};

            string[] cars4;
            cars4 = new string[] {"Volvo", "BMW", "Ford"};
        }
    }
}
