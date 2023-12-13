using ExOrderT5T2.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOrderT5T2.Entities
{
    internal class Order
    {
        private List<OrderItem> listaItems = new List<OrderItem>();
        private DateTime moment;
        private OrderStatus orderStatus;
        private Client client;

        public Order(DateTime moment, OrderStatus orderStatus, Client client)
        {
            this.moment = moment;
            this.orderStatus = orderStatus;
            this.client = client;
        }

        public void AddItem(OrderItem orderItem)
        {
            listaItems.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            listaItems.Remove(orderItem);
        }

        public override string ToString()
        {
            string res = "\n\nProdutos encomendados: ";
            foreach (OrderItem item in listaItems)
                res += "\n\t" + item.ToString();

            return $"\n\nDados da Encomenda: " +
                $"\n {client.ToString()}" +
                $"\n Data/hora: {moment.ToLongDateString()}/{moment.ToShortTimeString()}" +
                $"\nEstado da encomenda: {(OrderStatus)orderStatus}" +
                $"\n{res}";
        }
    }
}
