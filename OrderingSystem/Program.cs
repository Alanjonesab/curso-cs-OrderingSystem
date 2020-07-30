using OrderingSystem.Entitys;
using System;
using System.Reflection;
using System.Globalization;
using System.Collections.Generic;
using OrderingSystem.Entitys.Enums;

namespace OrderingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY) : ");
            DateTime birtDate = DateTime.Parse(Console.ReadLine());

            Client c1 = new Client(clientName, clientEmail, birtDate);

            Console.WriteLine();
            Console.WriteLine("Enter order data:");
            DateTime moment = DateTime.Now;
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How to many items to this order? ");
            int nItems = int.Parse(Console.ReadLine());

            Order order = new Order(moment, status, c1);

            for (int i = 1; i <= nItems; i++)
            {
                Console.WriteLine("Enter #{0} item data: ", i);
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: R$ ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product p = new Product(productName, productPrice);

                Console.Write("Quantity: ");
                int itemQuantity = int.Parse(Console.ReadLine());

                OrderItem item = new OrderItem(itemQuantity, productPrice, p);

                order.AddItem(item);

            }

            Console.WriteLine();
            Console.WriteLine(order);


        }
    }
}
