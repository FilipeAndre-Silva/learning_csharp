using System;

namespace Herança
{   
    //Classe Base
    class Ave
    {
        public string descricao = "Ave";

        public void canto()
        {
            Console.WriteLine("Piiiiu Piuu");
        }
    }

    //Classe derivada
    class Galinha : Ave
    {
        public string nome = "Galinha";
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Em C #, é possível herdar campos e métodos de uma classe para outra.
            Galinha objGalinha = new Galinha();
            objGalinha.canto();

            //Se você não quiser que outras classes herdem de uma classe, use a sealed:
            //sealed class Ave
        }
    }
}
