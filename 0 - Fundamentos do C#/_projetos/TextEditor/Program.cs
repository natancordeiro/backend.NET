using System;
using System.IO;

namespace TextEditor 
{   
    class Program 
    {
        static void Main(string[] args) 
        {
            Menu();
        }

        static void Menu() 
        {
            Console.Clear();
            Console.WriteLine("O que deseja fazer? ");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar arquivo");
            Console.WriteLine("0 - Sair");
            short option = short.Parse(Console.ReadLine());

            switch(option) 
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;
            }

        }

        static void Abrir() 
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo? ");
            string path = Console.ReadLine();

            // Criando um novo arquivo
            using(var file = new StreamReader(path)) 
            {
                //            Ler texto até o final
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }
            
            Console.WriteLine("");
            Console.ReadLine();
            Menu();

        }

        static void Editar() 
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("------------");
            string text = "";

            // FAÇA... ATÉ...
            do 
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
                //      Colocando uma nova linha 
            }
            //    Pressionar tecla      !=  Tecla ESC
            while(Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(text);
        }

        static void Salvar(string text) 
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho para salvar o arquivo? ");
            var path = Console.ReadLine();
            // path = caminho em inglês

            // O using - ele abre e fecha automaticamente
            //   arquivo  =  fluxo de escrita (caminho)
            using(var file = new StreamWriter(path)) 
            {
                // Escreva
                file.Write(text);
            
            /* LEMBRETE
                Sempre que for abrir um arquivo 
                Deve fechar ele logo após
            */
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Console.ReadLine();
            Menu();


        }
    }
}