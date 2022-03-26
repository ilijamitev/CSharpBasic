using SEDC.Class08.EXERCISESSS.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class08.EXERCISESSS
{

    public class SearchingService
    {

        //Search products by category // return all products from given category
        public List<Product> SearchByCategory(List<Product> productArr, Category category)
        {
            List<Product> result = new List<Product>();
            foreach (Product item in productArr)
            {
                if (item.Category == category)
                {
                    Console.WriteLine(item.Name);   // cisto za proverka
                    result.Add(item);
                }
            }
            return result;
        }

        //Filter products by price range (from min to max) // return all products that fall in the given price range
        public List<Product> FilterByPrice(List<Product> productArr, int min, int max)
        {
            List<Product> result = new List<Product>();
            foreach (Product item in productArr)
            {
                if (item.Price > min && item.Price < max)
                {
                    Console.WriteLine(item.Name + " " + item.Price);
                    result.Add(item);
                }
            }

            return result;
        }

        //Find products by part of name // get all products that consist the part in their names
        public List<Product> FindByPartOfName(List<Product> productArr, string partOfName)
        {
            List<Product> result = new List<Product>();
            foreach (Product item in productArr)
            {
                if (item.Name.Contains(partOfName))
                {
                    Console.WriteLine(item.Name);
                    result.Add(item);
                }
            }

            return result;
        }

        //Get only products ids // return only the ids of the products
        //********* Verojatno se misli na PRODUCT NAME bidejki nemaat IDs... ***********
        public List<string> GetProductsNames(List<Product> productArr)
        {
            List<string> result = new List<string>();
            foreach (Product item in productArr)
            {
                Console.WriteLine(item.Name);
                result.Add(item.Name);
            }

            return result;
        }

        //Get product price // get the price of the product - give the id as parameter  // ==> name as parameter
        public int GetProductPrice(List<Product> productArr, string productName)
        {
            int result = 0;
            foreach (Product item in productArr)
            {
                if (productName == item.Name)
                {
                    Console.WriteLine(item.Name + " " + item.Price);
                    result = item.Price;
                }
            }

            return result;
        }


        //Get cheapest product // return the cheapest product
        public Product GetCheapestProduct(List<Product> productList)
        {
            productList.Sort((x, y) => x.Price - y.Price);
            Console.WriteLine(productList[0].Name + " " + productList[0].Price);
            return productList[0];
        }


        //Get most expensive product // return the most expensive one
        public Product GetMostExpansiveProduct(List<Product> productList)
        {
            productList.Sort((x, y) => y.Price - x.Price);
            Console.WriteLine(productList[0].Name + " " + productList[0].Price);
            return productList[0];
        }


        //Add product // create method to add product to the list of products
        public void AddProduct(List<Product> productList, Product newProduct)
        {
            productList.Add(newProduct);
        }


        //Remove product // and a method to remove it - use id as parameter 
        public void RemoveProduct(List<Product> productList, string productName)
        {
            foreach (Product item in productList)
            {
                if (item.Name == productName)
                {
                    Console.WriteLine(item.Name);
                    productList.Remove(item);
                }
            }
        }






    }





}
