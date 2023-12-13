using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExOrderT5T2.Entities
{
    internal class OrderItem
    {
        private Product produto;
        private int quantity;
        private double price;

        public OrderItem(Product produto, int quantity, double price)
        {
            this.produto = produto;
            this.quantity = quantity;
            this.price = price;
        }

        public override string ToString()
        {
            return $"\nDados do item: " +
                $"\n\tProduto: {produto.ToString()}," +
                $"\n\tQuantidade: {quantity}" +
                $"\n\tPreço: {price:f2}";
        }
    }
}
