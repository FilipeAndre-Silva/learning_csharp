using System;

namespace Get_e_Set
{
    class Pessoa
    {
        public string nome_completo;
        //{ get; set; }

        //ou
        
        //Get e Set
        public string NomeCompleto
        {
            get {return nome_completo;}
            set {nome_completo = value;}
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa objPessoa = new Pessoa();
            objPessoa.NomeCompleto = "Filipe";
            Console.WriteLine(objPessoa.NomeCompleto);
        }
    }
}
