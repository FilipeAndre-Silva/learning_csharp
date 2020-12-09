using System;

namespace Classes_e_objetos
{   
    class Aluno
    {
        public string nome_completo = "Filipe André da Silva";
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Criando objeto objetoCarro
            Carro objetoCarro = new Carro();

            //Imprimindo seu atributo
            Console.WriteLine(objetoCarro.cor);

            //Criando objeto objetoAluno
            Aluno objetoAluno = new Aluno();
            Console.WriteLine(objetoAluno.nome_completo);
        }
    }
}
