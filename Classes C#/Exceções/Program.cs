using System;

namespace Exceções
{
    class Program
    {
        static void checkIdade(int idade)
        {
            if (idade < 18)
            {
                throw new ArithmeticException("Accesso negado - Você não é maior de 18 anos.");
            }
            else
            {
                Console.WriteLine("Acesso permitido!");
            }
        }

        static void Main(string[] args)
        {
            //Exceções
            //Quando ocorre um erro, o C # normalmente para e gera uma mensagem de erro.
            // O termo técnico para isso é: C # lançará uma exceção

            try
            {   
                //Isso gerará um erro, porque myNumbers [10] não existe.
                int[] myNumbers = {1, 2, 3};
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception msg_erro)
            {
                Console.WriteLine(msg_erro.Message);
                Console.WriteLine("Index informado não existe");
            }
            finally
            {
                Console.WriteLine("Mensagem orbigatorio após execução da opração!");
            }

            //A throw instrução permite que você crie um erro personalizado.
            checkIdade(15);
        }
    }
}
