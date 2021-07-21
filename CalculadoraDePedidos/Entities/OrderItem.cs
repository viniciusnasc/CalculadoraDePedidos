using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDePedidos.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
            Price = quantity * product.Price;
        }

        public override string ToString()
        {
            return Product + ", Quantity: " + Quantity + ", Subtotal: $" + Price.ToString("F2");
        }
    }
}
