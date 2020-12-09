using System;

namespace Construtores
{
    class Aluno
    {
        public string nome_completo;
        public int idade;

        //Construtor já atribuindo um valor aos atributos
        public Aluno()
        {
            nome_completo = "Aluno";
            idade = 0;

        }
    }
    
    class Carro
    {
        public string cor;
        
        //Construtor aguardando argumento para alimentar o atributo cor de Carro.
        //Pode receber quantos argumentos precisar
        public Carro(string cor_carro)
        {
            cor = cor_carro;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //A vantagem de um construtor é que ele é chamado quando um objeto de uma classe é criado.
            //Ele pode ser usado para definir valores iniciais para campos
            Aluno objAluno1 = new Aluno();
            Console.WriteLine(objAluno1.nome_completo);
            Console.WriteLine(objAluno1.idade);

            Carro objCarro1 = new Carro("Vermelhor");
            Console.WriteLine(objCarro1.cor);

        }
    }
}
