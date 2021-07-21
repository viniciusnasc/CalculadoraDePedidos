using System;
using CalculadoraDePedidos.Entities;
using CalculadoraDePedidos.Entities.Enums;

namespace CalculadoraDePedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/AAAA): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client c1 = new(name, email, birthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int itemQuantity = int.Parse(Console.ReadLine());

            Order ord = new(status, c1);

            for (int i = 0; i < itemQuantity; i++)
            {
                Console.WriteLine($"Enter #{i+1} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                Product prod = new(productName, productPrice);
                OrderItem orderProd = new(productQuantity, prod);
                ord.ListOrderItem.Add(orderProd);
            }

            Console.WriteLine("\nOrder summary:");
            Console.WriteLine($"Order moment: {ord.Moment}");
            Console.WriteLine($"Order status: {ord.OrderStatus}");
            Console.WriteLine($"Client: {c1}");
            Console.WriteLine("Order items:");

            foreach(OrderItem obj in ord.ListOrderItem)
            {
                Console.WriteLine(obj);
            }

            Console.Write($"Total price: ${ord.TotalPrice()}");
        }
    }
}
