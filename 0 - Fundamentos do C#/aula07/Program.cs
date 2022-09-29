using System;

namespace aula07 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            // Criando um ID aleatório 
            var id = Guid.NewGuid();
            id.ToString();

            // Passando um GUID novo (aceita somente esse formato!)
            id = new Guid("4cad989f-f0df-4d26-8447-d66c6ab3a5b1");
            
            if(id == Guid.NewGuid()); 
            Console.WriteLine(id.ToString().Substring(0, 8)); //pegando somente os 8 primeiros caracteres
        }
    }
}
