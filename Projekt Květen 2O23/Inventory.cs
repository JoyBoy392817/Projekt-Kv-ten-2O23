using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Květen_2O23
{
    internal class Inventory
    {
        public List<Product> products = new List<Product>();
        public void AddProduct()
        {
            Product product = new Product();
            try
            {
                Console.Write("Napiš jméno: ");
                product.name = Console.ReadLine();
                Console.Write("Napiš cenu: ");
                product.price = double.Parse(Console.ReadLine());
                Console.Write("Napiš počet: ");
                product.quantity = int.Parse(Console.ReadLine());
                products.Add(product);
                Console.WriteLine(product.name + " byl přidán");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Chyba: "+ ex.Message);
            }
        }
        public void RemoveProduct()
        {
            Product product = new Product();
            Console.WriteLine("Inventář: ");
            foreach (Product produc in products)
            {
                Console.WriteLine(products.IndexOf(produc) + 1 + ")  " + produc.name + " - " + produc.quantity + "ks - " + produc.price + "Kč");
            }
            try
            {
                Console.WriteLine("------------------------");
                Console.Write("Napiš pořadí produktu který bude odebrán: ");
                int indexListu = int.Parse(Console.ReadLine()) -1;
                products.RemoveAt(indexListu);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Chyba: " + ex.Message);
            }
        }
        public void ShowInventory()
        {
            Console.WriteLine("Inventář: ");
            foreach (Product product in products)
            {
                Console.WriteLine(products.IndexOf(product)+ 1 + ")  " + product.name +" - "+product.quantity+"ks - "+product.price+"Kč");
            }
        }
    }
}