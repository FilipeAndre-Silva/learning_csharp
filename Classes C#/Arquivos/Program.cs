using System;
using System.IO;

namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //A Fileclasse do System.IOnamespace nos permite trabalhar com arquivos
            //A Fileclasse possui muitos métodos úteis para criar e obter informações sobre arquivos.
            
            string writeText = "Hello World C#!";
            File.WriteAllText("filename.txt", writeText);

            string readText = File.ReadAllText("filename.txt");
            Console.WriteLine(readText);
        }
    }
}
