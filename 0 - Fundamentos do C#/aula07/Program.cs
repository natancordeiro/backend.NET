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

            //==================================================================
            var price = 10.2;
            // Interpolação de String

            //var texto = "O preço do produto é " + price + " apenas na promoção";
            //var texto = string.Format("O preço do produto é {0} apenas na promoção", price);
            var texto = $@"O preço do produto é 
            {price} apenas \n na promoção"; // @ para pular linhas (não quebra no \n)

            Console.WriteLine(texto);
        }
    }
}
