using Projekt_Květen_2O23;
Inventory newInventory = new Inventory();
bool exit = false;
while(!exit)
{
    Console.WriteLine("--------------------");
    Console.WriteLine("Vyber si akci");
    Console.WriteLine("--------------------");
    Console.WriteLine("1) Přidat produkt");
    Console.WriteLine("2) Odebrat produkt");
    Console.WriteLine("3) Zobratit Inventář");
    Console.WriteLine("4) Ukončit");
    Console.WriteLine("--------------------");
    string vyberMenu = Console.ReadLine();
    switch (vyberMenu)
    {
        case "1":
            Console.Clear();
            newInventory.AddProduct();
            break;
        case "2":
            Console.Clear();
            newInventory.RemoveProduct();
            break;
        case "3":
            Console.Clear();
            newInventory.ShowInventory();
            break;
        case "4":
            exit = true;
            break;
        default:
            Console.Clear();
            Console.WriteLine("Chyba při výběru");
            break;
    }
}