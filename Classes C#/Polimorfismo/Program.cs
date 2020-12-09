using System;

namespace Polimorfismo
{
    class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("Sons de animais");
        }
    }

    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Wee Wee");
        }
    }

    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Au Au");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Polimorfismo significa "muitas formas" e ocorre quando temos muitas classes
            //que estão relacionadas entre si por herança.
            //É útil para reutilização de código: reutilize campos e métodos de uma classe existente ao criar uma nova classe
            
            Animal objAnimal = new Animal();
            objAnimal.animalSound();

            Pig objPig = new Pig();
            objPig.animalSound();
            
            Dog objDog = new Dog();
            objDog.animalSound();
        }
    }
}
