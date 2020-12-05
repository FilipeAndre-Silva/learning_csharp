using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Strings em C#
            //Strings são usadas para armazenar texto.
            //Uma stringvariável contém uma coleção de caracteres entre aspas duplas

            string texto = "Esta é uma string em C#";
            Console.WriteLine(texto); 

            //Seu comprimento
            Console.WriteLine(texto.Length);

            //Cópia da string convertida em maiúsculas ou minúsculas
            Console.WriteLine(texto.ToUpper());
            Console.WriteLine(texto.ToLower());

            //Concatenando Strings
            string nome = "Filipe ";
            string sobrenome = "André";
            string nome_completo = nome + sobrenome;
            Console.WriteLine(nome_completo);
            //OU
            string nome_completo2 = string.Concat(nome, sobrenome);
            Console.WriteLine(nome_completo2);
            //OU
            
            //Interpolação de String
            string nome_completo3 = $"Meu nome é {nome}{sobrenome}";
            Console.WriteLine(nome_completo3);

            //String de acesso
            //Podemos acessar os caracteres em uma string referindo-se ao seu número de índice entre colchetes []
            Console.WriteLine(nome[0]);//Primeira letra do meu nome

            //Os índices de string começam com 0

            //Podemos encontrar a posição do índice de um caractere específico em uma string
            Console.WriteLine(nome.IndexOf("F"));

            //Substring(), que extrai os caracteres de uma string, começando na posição / índice
            int posicao = nome_completo.IndexOf("A");
            string parte_nome = nome_completo.Substring(posicao);
            Console.WriteLine(parte_nome);

            //Exemplos de Caracteres especiais
            string txt1 = "We are the so-called \"Vikings\" from the north.";
            string txt2 = "It\'s alright.";
            string txt3 = "The character \\ is called backslash.";
            Console.WriteLine(txt1);
            Console.WriteLine(txt2);
            Console.WriteLine(txt3);

            //C # usa o operador + para adição e concatenação.


            


        }
    }
}
