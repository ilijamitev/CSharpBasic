using SEDC.Class08.EXERCISESSS.Enum;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.Class08.EXERCISESSS
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product() { Name =  "Keyboard", Price = 100, Category = Category.ItEquipment},
                new Product() { Name =  "Mouse", Price = 150, Category = Category.ItEquipment},
                new Product() { Name =  "Headphones", Price = 80, Category = Category.ItEquipment},
                new Product() { Name =  "Microphone", Price = 220, Category = Category.ItEquipment},
                new Product() { Name =  "Camera", Price = 1000, Category = Category.ItEquipment},
                new Product() { Name =  "Camera", Price = 1000, Category = Category.ItEquipment},
                new Product() { Name =  "Hp-580", Price = 20000, Category = Category.LapTop},
                new Product() { Name =  "Lenovo G200", Price = 18500, Category = Category.LapTop},
                new Product() { Name =  "Hp ProBook", Price = 12000, Category = Category.LapTop},
                new Product() { Name =  "Acer S1200", Price = 28000, Category = Category.LapTop},
                new Product() { Name =  "Dell MS300", Price = 74000, Category = Category.LapTop},
                new Product() { Name =  "Office 1", Price = 10200, Category = Category.PC},
                new Product() { Name =  "Office 2", Price = 12400, Category = Category.PC},
                new Product() { Name =  "Gaming", Price = 22000, Category = Category.PC},
                new Product() { Name =  "Ultra Gaming", Price = 32200, Category = Category.PC},
                new Product() { Name =  "Ultra Ultra Gaming", Price = 61600, Category = Category.PC},
                new Product() { Name =  "Alienware", Price = 128000, Category = Category.PC},
                new Product() { Name =  "Samsung Proview", Price = 56200, Category = Category.TV},
                new Product() { Name =  "Samsung Oval", Price = 247999, Category = Category.TV},
                new Product() { Name =  "LG LG420MQ8", Price = 32000, Category = Category.TV},
                new Product() { Name =  "SONY Plasma", Price = 18000, Category = Category.TV},
                new Product() { Name =  "SONY RW78OS", Price = 179999, Category = Category.TV}
            };

            products = products.OrderBy(x => x.Name).ToList();                // order by name ASC
            //products = products.OrderByDescending(x => x.Name).ToList();      // order by name DESC

            SearchingService listService = new SearchingService();

            Console.WriteLine("===== Search by category =====");
            listService.SearchByCategory(products, Category.LapTop);
            Console.WriteLine();

            Console.WriteLine("===== Price Range =====");
            listService.FilterByPrice(products, 5000, 15000);
            Console.WriteLine();

            Console.WriteLine("===== By part of name =====");
            listService.FindByPartOfName(products, "am");
            Console.WriteLine();

            Console.WriteLine("===== Product names =====");
            listService.GetProductsNames(products);
            Console.WriteLine();

            Console.WriteLine("===== Get product price from name =====");
            listService.GetProductPrice(products, "Gaming");
            Console.WriteLine();

            Console.WriteLine("===== Cheapest product =====");
            listService.GetCheapestProduct(products);
            Console.WriteLine();

            Console.WriteLine("===== Most expansive product =====");
            listService.GetMostExpansiveProduct(products);
            Console.WriteLine();

            Console.WriteLine("===== Add product =====");
            listService.AddProduct(products, new Product() { Name = "NEW PRODUCT", Price = 33333, Category = Category.TV });
            Console.WriteLine(products[products.Count - 1].Name);
            Console.WriteLine();

            Console.WriteLine("===== Remove product =====");
            listService.RemoveProduct(products, "Camera");
            Console.WriteLine();
            Console.ReadLine();


            Console.Clear();
            Console.WriteLine("===== FINAL LIST OF PRODUCTS =====");
            products = products.OrderBy(x => x.Name).ToList();
            listService.GetProductsNames(products);


            Console.ReadLine();
        }
    }
}
