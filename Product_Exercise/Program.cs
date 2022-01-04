using System;

namespace Product_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

       /*     Console.WriteLine("write category: ");
            var cat = Console.ReadLine(); */
            


            Product product = new Product("Banane", 0.032412M, new DateTime(2020, 12, 20), "Banosh", Categories.Fruit);


            Console.WriteLine("Category: " + product.Category + " expiration date = " + product.ExpirationDate.ToString("dd-MM-yyyy"));

            Product product2 = new Product("Beer", 0.09999M, new DateTime(2020, 12, 20), "Craft", Categories.Beverages);

            Console.WriteLine("Category: " + product2.Category + " expiration date = " + product2.ExpirationDate.ToString("dd-MM-yyyy"));

            Product product3 = new Product("Bread", 0.4522M, new DateTime(2020, 12, 20), "Eldi", Categories.Bread);

            Console.WriteLine("Category: " + product3.Category + " expiration date = " + product3.ExpirationDate.ToString("dd-MM-yyyy"));

            Product product4 = new Product("Diary", 0.823424M, new DateTime(2020, 12, 20), "Milk", Categories.Dairy);

            Console.WriteLine("Category: " + product4.Category + " expiration date = " + product4.ExpirationDate.ToString("dd-MM-yyyy"));

        }
    }
}
