
// convertendo tipos

using System;

namespace aula03 
{
    class Program 
    {               
        static void Main(string[] args) 
        {
            int inteiro = 100;
            float real = 25.5f;

            // inteiro = real; // Erro (Não pode fazer converter do real pro int)
            
            // real = inteiro; // 100.0f

            // inteiro = (int)real; // Conversão explicita (Correto)

            //   convertendo p/ string
            // string valorReal = real.ToString();

            // Parse só converte de string 
            // inteiro = int.Parse("255");
            inteiro = Convert.ToInt32(real); 
 
            Console.WriteLine(inteiro);
            //Console.WriteLine(inteiro);

        }
    }
}
