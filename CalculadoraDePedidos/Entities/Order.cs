using CalculadoraDePedidos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDePedidos.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public List<OrderItem> ListOrderItem { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order(OrderStatus orderStatus, Client client)
        {
            Moment = DateTime.Now;
            OrderStatus = orderStatus;
            Client = client;
        }

        public void AddItem(OrderItem orderItem)
        {
            ListOrderItem.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            ListOrderItem.Remove(orderItem);
        }

        public double TotalPrice()
        {
            double valor = 0;
            foreach (OrderItem item in ListOrderItem)
            {
                valor += item.Price;
            }

            return valor;
        }
    }
}
