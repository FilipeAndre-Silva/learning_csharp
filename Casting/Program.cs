using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // A conversão de tipo é quando você atribui um valor de um tipo de dados a outro tipo.
            // Conversão Explícita:(A implícita é o inverso)
            // double-> float-> long-> int->char

            //Conversão implícita
            int myInt = 9;
            double myDouble = myInt;
            Console.WriteLine(myDouble);

            //Conversão explícita -> Manual
            double myD = 9.78;
            int myI = (int) myD;
            Console.WriteLine(myI);

            bool myBool = true;

            //Métodos de conversão de tipo
            Console.WriteLine(Convert.ToString(myInt));    
            Console.WriteLine(Convert.ToDouble(myInt));    
            Console.WriteLine(Convert.ToInt32(myDouble));
            Console.WriteLine(Convert.ToString(myBool));
        }
    }
}
