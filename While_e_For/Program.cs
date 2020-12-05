using System;

namespace While_e_For
{
    class Program
    {
        static void Main(string[] args)
        {
            //Os loops podem executar um bloco de código, desde que uma condição especificada seja alcançada.
            //While Loop

            int i = 0;
            while(i < 5)
            {
                Console.WriteLine("Loop com While");
                i++;
            }

            //do/whileloop é uma variante do whileloop. Este loop executará o bloco de código uma vez.
            int x = 0;

            do
            {
                Console.WriteLine("Loop com Do/While");
                x++;
            }
            while (x < 5);

            //For Loop
            //Se sabe exatamente quantas vezes deseja percorrer um bloco de código, use o for.
            for (int y = 0; y < 5; y++)
            {
                Console.WriteLine("Loop com FOR");
            }

            //loop foreach
            String[] alunos = {"Filipe", "Lucas", "Pedro"};
            foreach (string s in alunos)
            {
                Console.WriteLine(s);
            }

        }
    }
}
