// Tipos primitivos

using System;

namespace aula02
{
    class Program
    {
        static void Main(string[] args)
        {

            /*    NÚMEROS INTEIROS
                short (16-bit)
                    -32,768 to 32,767

                ushort (16-bit)
                    0 to 65.535

                int (32-bit)
                uint (32-bit)
                long (64-bit)
                ulomg (64-bit)
            */

            /*           REAIS
                float (Notação F) - (32-bit)
                double - (64-bit)
                decimal (Notação M) - (128-bit)
            

                double vem como padão ao chamar um var
                var numero = 12.5;
                float salario = 2.500f;
                double salarioSemestral = 22.000;
                decimal salarioAnual = 25.000m;
            */

            /*         BOLEANOS
                bool usuarioCadastrado = false;
                bool pagamentoRecebido = true;
            */ 

            /*         CHARS
                char primeiraLetra = 'C';
                var segundaLetra = 'D';
            */

            /*         STRINGS
                string primeiraLetra = "C"; // Conjunto de caracteres (chars)
                string texto = "Meu Texto";
                var documento = "12345.43";
            */

            /*         OBJECT
                object quantidade; // Recebe qualquer valor (diferente do var)
                quantidade = 1;
                quantidade = 2.5;
                quantidade = "Texto";
            */

            /*       NULLABLE TYPE
                int? idade = null; // para criar um nulo, colocar ? na definição
                byte? bite = null;
            */

            /*     VALORES PADRÕES
                int => 0
                float => 0
                decimal => 0
                bool => false
                char => '\0'  
                string => ""  
            */
        }
    }
}
