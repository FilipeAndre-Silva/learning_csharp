using System;

namespace Sobrecarga_do_método
{
    class Program
    {
        //Com a sobrecarga de método , vários métodos podem ter o mesmo nome com parâmetros diferentes
        //Em vez de definir dois métodos que devem fazer a mesma coisa, é melhor sobrecarregar um.

        static int PlusMethod(int x, int y)
            {
                return x + y;
            }

            static double PlusMethod(double a, double b)
            {
                return a + b;
            }
        static void Main(string[] args)
        {
        
            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4.3, 6.26);
            Console.WriteLine(myNum1);
            Console.WriteLine(myNum2);
        
        }
    }
}
