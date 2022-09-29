using System;

namespace aula05
{
    class Program 
    { 
        static void Main(string[] args) 
        //       Método Main
        {      
            MeuMetodo();

            string nome = RetornaNome("Natan", "Cordeiro");
            Console.WriteLine(nome);
        }
    
        static void MeuMetodo()
        {// void = não retorna nada
        
            Console.WriteLine("C# é legal");
        }
    
        static string RetornaNome(string nome, string sobrenome,int idade = 22) 
        {//                       parâmetro obrigatórios        Parâmetro opcional 
            return nome + " " + sobrenome + " tem " + idade.ToString();
        }

    }
}
