using System;

namespace Abstração
{   
    abstract class Animal
    {
        public abstract void animalSound();

        public void animalSoundGeneric()
        {
            Console.WriteLine("Whuoo !");
        }
    }

    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Wee Wee!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {      
            //Para obter segurança - oculte certos detalhes e mostre apenas os detalhes importantes de um objeto.    

            //Classe abstrata:
            //não pode ser utilizada para criar objetos (para acessá-la deve ser herdada de outra classe).

            //Método abstrato:
            //só pode ser usado em uma classe abstrata, e não possui corpo. O corpo é fornecido pela classe derivada 

            Pig objPig = new Pig();
            objPig.animalSoundGeneric();
            objPig.animalSound();

            //Está linha vai dar erro por tentar instânciar Animal sendo abstrato    
            //Animal objAnimal = new Animal();
        }
    }
}
