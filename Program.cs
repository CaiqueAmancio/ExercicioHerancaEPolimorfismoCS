/* Programa para ler os dados de N produtos (N fornecido pelo usuário). Ao final,
mostrar a etiqueta de preço de cada produto na mesma ordem em que foram digitados.
Todo produto possui nome e preço. Produtos importados possuem uma taxa de alfândega, e
produtos usados possuem data de fabricação.
Para produtos importados, a taxa e alfândega deve ser acrescentada ao preço final do produto.
*/



using System;
using System.Collections.Generic;
using ExercicioHeranca.Entitities;
using System.Globalization;

namespace ExercicioHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>(); // lista para guardar informacoes da classe

            Console.Write("Enter the number of products: ");
            int N = int.Parse(Console.ReadLine());


            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i' || ch == 'I')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(customsFee, name, price));
                }
                else if (ch == 'u' || ch == 'U')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(date, name, price));
                }
                else
                {
                    list.Add(new Product(name, price));
                }
            }

            Console.WriteLine(); // pular uma linha
            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }

        }
    }
}
