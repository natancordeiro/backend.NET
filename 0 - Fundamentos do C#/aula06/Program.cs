using System;

namespace aula06 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            var mouse = new Product(1, "Mouse Gamer", 299.97, EProductType.Product);
            var manutencaoEletrica = new Product(2, "Manutenção elétrica", 500, EProductType.Service);
 
            mouse.Id = 55;

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine(mouse.Type);
        }
    }
    // Não pode ser criada dentro de uma class nem Main
    struct Product 
    {
        // Método Construtor
        public Product(int id, string name, double price, EProductType type) 
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }
        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;

        public double PriceInDolar(double dolar) {
            return Price * dolar;
            // Propriedade começa em Maiúsculo
            // parâmetro em minúsulo
        }
    }

    // Enumerate
    enum EProductType 
    {
        Product = 1,
        Service = 2
    }
}
