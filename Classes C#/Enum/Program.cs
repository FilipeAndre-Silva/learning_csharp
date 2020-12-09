using System;

namespace Enum
{   
    enum Level
    {
        Low,
        Medium,
        Higth
    }

    enum Meses
    {
        January,    
        February,   
        March,      
        April,      
        May,        
        June,       
        July
    }
    class Program
    {
        static void Main(string[] args)
        {
            //enum é uma "classe" especial que representa um grupo de constantes
            //Use enums quando tiver valores que sabe que não vão mudar, como dias, dias, cores, baralhos de cartas, etc.
            
            Level meuLevel = Level.Medium;
            Console.WriteLine(meuLevel);

            int numMes = (int) Meses.April;
            Console.WriteLine(numMes);

            int nivelSelecionado = (int) Level.Higth;

            switch(nivelSelecionado)
            {
                case (int)Level.Low:
                    Console.WriteLine("Level baixo");
                    break;

                case (int)Level.Higth:
                    Console.WriteLine("Level Alto");
                    break;
            }

        }
    }
}
