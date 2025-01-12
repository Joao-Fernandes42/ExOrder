﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOrderT5T2.Entities
{
    internal class Product
    {
        public string Name { get; private set; }
        private double price;

        public Product(string name, double price)
        {
            this.Name = name;
            this.price = price;
        }

        public override string ToString()
        {
            return $"\nDados do Produto:" +
                $"\n\tNome: {Name}, Preço: {price:f2}";

        }
    }
}
