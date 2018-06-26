using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace ThiCShap
{
    class Program
    {
        private static List<Product> list = new List<Product>();
        
        static void Main(string[] args)
        {
            GenerateMenu();
        }

        public static void GenerateMenu()
        {
            while (true)
            {
                Console.WriteLine("----Menu----");
                Console.WriteLine("1. Add product records.");
                Console.WriteLine("2. Display product records.");
                Console.WriteLine("3. Delete product by Id.");
                Console.WriteLine("4. Exit.");
            
                int choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        
                        DisplayProduct();
                        break;
                    case 3:

                        Console.WriteLine("Nhap id can xoa.");
                        var id = Console.ReadLine();
                        DeleteProduct(id);
                        break;
                    case 4:
                        Console.WriteLine("Exit.");
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        public static void AddProduct()
        {
            Console.WriteLine("Vui long nhap ID: ");
            string id = Console.ReadLine();
            Console.WriteLine("Vui long nhap Name");
            string name = Console.ReadLine();
            Console.WriteLine("vui long nhap Price: ");
            int price = Int32.Parse(Console.ReadLine());
            
            Product product = new Product(id, name, price);
            list.Add(product);

        }

        public static void DisplayProduct()
        {
            Console.WriteLine(string.Format("{0, 10} | {1 , 20} | {2, 20}","Product ID", "Product Name","Price"));
            foreach (var product in list)
            {
                Console.WriteLine(string.Format("{0,10} | {1, 20} | {2, 20}",product.Id,product.Name,"$" +product.Price));
            }
        }

        public static void DeleteProduct(string id)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Id == id)
                {
                    list.RemoveAt(i);
                }
            }
        }
    }
}