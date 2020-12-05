using System;

namespace Break_and_Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            //A break instrução também pode ser usada para sair de um loop
            //Por exemplo: para "saltar" de uma switch.

            for (int i = 0; i < 10; i++)
            {
                if(i == 4)
                {
                    break;
                }

                Console.WriteLine(i);
            }

            //continue interrompe uma iteração (no loop)
            //Este exemplo ignora o valor de 4
            for (int x = 0; x < 10 ; x++)
            {
                if (x == 4)
                {
                    continue;
                }

                Console.WriteLine(x);
            }

            //Podemos usar o breake continue em whiles também.
            int y = 0;
            while(y < 10)
            {
                Console.WriteLine(y);
                y++;

                if(y == 4)
                {
                    break;
                }
            }

            int j = 0;
            while (j < 10)
            {
                if (j == 4)
                {
                    j++;
                    continue;
                }

                Console.WriteLine(j);
                j++;
            }

        }
    }
}
