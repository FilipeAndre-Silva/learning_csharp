using System;

namespace Membros
{   
    class Aluno
    {
        public string nome_completo;
        public int idade;

        public void exibirDados()
        //Static pode ser acessado sem criar um objeto da classe,
        //Enquanto o public só podem ser acessados ​​por objetos.
        {
            Console.WriteLine(nome_completo);
            Console.WriteLine(idade);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Aluno objetoAluno1 = new Aluno();
            objetoAluno1.nome_completo = "Filipe André da Silva";
            objetoAluno1.idade = 23;
            objetoAluno1.exibirDados();

            Aluno objetoAluno2 = new Aluno();
            objetoAluno2.nome_completo = "Lucas Ernandes da Silva";
            objetoAluno2.idade = 19;
            objetoAluno2.exibirDados();

            
        }
    }
}
