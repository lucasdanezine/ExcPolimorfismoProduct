using System;
using ExcPolimorfismoProduct.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace ExcPolimorfismoProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int nProd = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();

            for (int i = 1; i <= nProd; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, UsedProduct or imported (c/u/i)?");
                string respTipo = Console.ReadLine();
                if (respTipo == "c")
                {
                    Console.Write("Name: ");
                    string nome = Console.ReadLine();
                    Console.Write("Price: ");
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new Product(nome, preco));

                }
                else if (respTipo == "u")
                {
                    Console.Write("Name: ");
                    string nome = Console.ReadLine();
                    Console.Write("Price: ");
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime dataFab = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(nome, preco, dataFab));
                }
                else
                {
                    Console.Write("Name: ");
                    string nome = Console.ReadLine();
                    Console.Write("Price: ");
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Custon fee: ");
                    double impostoImport = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(nome, preco, impostoImport));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");

            foreach (Product product in products)
            {

                Console.WriteLine(product.PriceTag());
            }
        }
    }
}