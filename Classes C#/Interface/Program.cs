using System;

namespace Interface
{
    interface ISom
    {
        void somAnimal();
        
    }

    interface IAnimal
    {
        void exibirFamilia();
    }

    class Pig : ISom, IAnimal
    {
        public void somAnimal()
        {
            Console.WriteLine("Won Wonn!");
        }

        public void exibirFamilia()
        {
            Console.WriteLine("Suínos");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //interface:
            //é uma " classe abstrata " completamente ,
            //que só pode conter métodos e propriedades abstratos (com corpos vazios)
            
            Pig objPig = new Pig();
            objPig.somAnimal();
            objPig.exibirFamilia();


        }
    }
}
