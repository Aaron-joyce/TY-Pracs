// 1. Display all products greater than 40,000
// 2. Display all the product name and the price
// 3. Display only the product name and its date of manufacture (DOM) for laptops only
// 4. Display only those products which have DOM as 7/7/2025

using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
namespace Practical4 
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument doc = XDocument.Load("D:\\TYIT\\C#\\Practical 4\\file.xml");
            var products = doc.Elements();

            // 1. Display all products greater than 40,000
            Console.WriteLine("====== Display products price > 40000 using linq ======");
            var result1 = products.Elements("PRODUCT")
                .Where(x => (int)x.Element("PRICE") >= 40000)
                .Select(x => new
                {
                    name = x.Element("NAME").Value,
                    dom = x.Element("DOM").Value,
                    price = x.Element("PRICE").Value
                });

            foreach (var item in result1)
            {
                Console.Write($"{{Name: {item.name}, ");
                Console.Write($"Price: {item.price}, ");
                Console.Write($"DOM: {item.dom}}}\n");
            }

            // 2. Display all the product name and the price
            Console.WriteLine("\n\n====== Display all the product name and the price ======");
            var result2 = products.Elements("PRODUCT")
                .Select(x => new
                {
                    name = x.Element("NAME").Value,
                    dom = x.Element("DOM").Value,
                    price = x.Element("PRICE").Value
                });

            foreach (var item in result2)
            {
                Console.Write($"{{Name: {item.name}, ");
                Console.Write($"Price: {item.price}, ");
                Console.Write($"DOM: {item.dom}}}\n");
            }

            // 3. Display only the product name and its date of manufacture (DOM) for laptops only
            Console.WriteLine("\n\n====== Display only the product name and its date of manufacture (DOM) for laptops only ======");
            var result3 = products.Elements("PRODUCT")
                .Where(x => x.Element("NAME").Value == "LAPTOP")
                .Select(x => new
                {
                    name = x.Element("NAME").Value,
                    dom = x.Element("DOM").Value
                });

            foreach (var item in result3)
            {
                Console.Write($"{{Name: {item.name}, ");
                Console.Write($"DOM: {item.dom}}}\n");
            }

            // 4. Display only those products which have DOM as 7/7/2025
            Console.WriteLine("\n\n====== Display only the product name and its date of manufacture (DOM) for laptops only ======");
            var result4 = products.Elements("PRODUCT")
                .Where(x => DateTime.Parse(x.Element("DOM").Value) > DateTime.Parse("01/01/2025"))
                .Select(x => new
                {
                    name = x.Element("NAME").Value,
                    price = x.Element("PRICE").Value,
                    dom = x.Element("DOM").Value
                });

            foreach (var item in result4)
            {
                Console.Write($"{{Name: {item.name}, ");
                Console.Write($"Price: {item.price}, ");
                Console.Write($"DOM: {item.dom}}}\n");
            }
        }
    }
}