using System;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer cust1 = new Customer("John Smith", addr1);

        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop", 101, 800, 1));
        order1.AddProduct(new Product("Mouse", 102, 25, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"TOTAL: ${order1.GetTotalPrice()}\n");

        Address addr2 = new Address("45 Queen St", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Emma Brown", addr2);

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Phone", 201, 500, 1));
        order2.AddProduct(new Product("Headphones", 202, 80, 1));
        order2.AddProduct(new Product("Charger", 203, 20, 3));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"TOTAL: ${order2.GetTotalPrice()}");
    }
}