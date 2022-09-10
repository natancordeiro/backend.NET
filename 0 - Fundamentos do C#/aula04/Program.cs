
using System;

namespace aula01 
{
    class Program 
    {               
        static void Main(string[] args) 
        {
            // Condições IF
            int idade = 18;
            int maior = 21;
            int idadeMaxima = 65;

            if(idade >= maior && idade < idadeMaxima)
            {
                Console.WriteLine("Maior");
            }
            else if(idade >= 25)
            {
                Console.WriteLine("Menor");
            }

            Console.Write("Finalizou o programa");

            // Condições SWITCH
            string valor = "natan";
            switch (valor)
            {
                case "joao": Console.WriteLine("Não é o cara!"); break; 
                case "natan": Console.WriteLine("é o cara!"); break; 
                case "carlos": Console.WriteLine("Não é o cara!"); break;
                default: Console.WriteLine("Não encontrei!"); break; 
            }

            // Laços de Repetião: FOR
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            // Laços de Repetião: WHILE
            int num = 0;
            while(num <= 5)
            {
                Console.WriteLine(num);
                num ++;
            }

            // DO: WHILE
            do
            {
                Console.WriteLine(num);
                num ++;
            } while(num < 5);

            

        }
    }
}
