using SEDC.Class08.EXERCISESSS.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class08.EXERCISESSS
{
    /*
        ##Search products by category // return all products from given category
        Filter products by price range (from min to max) // return all products that fall in the given price range
        Find products by part of name // get all products that consist the part in their names
        Get only products ids // return only the ids of the products
        Get product price // get the price of the product - give the id as parameter
        Get cheapest product // return the cheapest product
        Get most expensive product // return the most expensive one
        Add product // create method to add product to the list of products
        Remove product // and a method to remove it - use id as parameter 

     */
    public class SearchingService
    {
        public List<Product> SearchByCategory(List<Product> productArr, Category category)
        {
            List<Product> result = new List<Product>();


            foreach (Product item in productArr)
            {
                if (item.Category == category)
                {
                    result.Add(item);
                }

            }
            return result;
        }

        public List<Product> FilterByPrice(List<Product> productArr, int min, int max)
        {
            List<Product> result = new List<Product>();
            foreach (Product item in productArr)
            {
                if (item.Price > min && item.Price < max)
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public List<Product> FindByPartOfName(List<Product> productArr, string partOfName)
        {
            List<Product> result = new List<Product>();
            foreach (Product item in productArr)
            {
                if (item.Name.Contains(partOfName))
                {
                    result.Add(item);
                }
            }

            return result;
        }



















    }




}
}
