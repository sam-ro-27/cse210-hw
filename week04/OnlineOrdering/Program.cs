using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Edinburg", "TX", "USA");
        Customer customer1 = new Customer("Sam Rowley", address1);
        Order order1 = new Order(customer1);
        Product product1 = new Product("Laptop", 999.99, "LAP123", 1);
        order1.AddProduct(product1);
        Product product2 = new Product("Mouse", 25.50, "MOU456", 2);
        order1.AddProduct(product2);
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Address address2 = new Address("456 Maple Avenue", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);
        Product product3 = new Product("Keyboard", 49.99, "KEY789", 1);
        order2.AddProduct(product3);
        Product product4 = new Product("Monitor", 199.99, "MON012", 1);
        order2.AddProduct(product4);
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
    }
}