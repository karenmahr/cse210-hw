using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Buenos Aires 8956", "Chilavert", "Buenos Aires", "Argentina");
        Address address2 = new Address("589 Main Street", "New York", "NY", "United States");

        Customer customer1 = new Customer("Maria Gomez", address1);
        Customer customer2 = new Customer("Sophia Smith", address2);

        Product product1 = new Product(" Milk", 101, 3, 2);
        Product product2 = new Product(" Bread", 102, 2, 1);
        Product product3 = new Product(" Eggs", 103, 5, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Console.WriteLine("Order for: " + customer1.GetName());
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.GetTotalFinalCost());

        Order order2 = new Order(customer2);
        order2.AddProduct(product1);
        order2.AddProduct(product3);

        Console.WriteLine("");
        Console.WriteLine("Order for: " + customer2.GetName());
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.GetTotalFinalCost());
        
    }   
}