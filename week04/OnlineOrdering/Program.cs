using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address(
            "2595 Mainge Street",
            "Rimuka",
            "Kadoma",
            "Zimbabwe");

        Customer foreign = new Customer(
            "Jayden Mukundi",
            address1);

        Order order1 = new Order(foreign);

        order1.AddProduct(new Product("Calcium Carbonate", "CaCo3", 600.00, 3));
        order1.AddProduct(new Product("Potassium Sorbate", "C6H7KO2", 360.00, 4));
        order1.AddProduct(new Product("Potassium Permanganate", "KMnO4", 20.00, 6));

        Address address2 = new Address(
            "32 Lincoln Drive",
            "Charlotte",
            "North Carolina",
            "USA");

        Customer resident = new Customer(
            "Travis Carter",
            address2);

        Order order2 = new Order(resident);

        order2.AddProduct(new Product("Chlorine", "Cl2", 880.00, 3));
        order2.AddProduct(new Product("Hydrochloric acid", "HCL", 850.00, 1));
        order2.AddProduct(new Product("Sodium nitrate", "NaNO2", 965.00, 2));

        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine();
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine();

        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}");
        Console.WriteLine();
        Console.WriteLine(order2.ShippingLabel());

        
    }
}