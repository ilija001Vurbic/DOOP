using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOP_LV4
{
    class Book : IRentable
    {
        private readonly double BaseBookPrice = 3.99;
        public String Name { get; private set; }
        public Book(String name) { this.Name = name; }
        public string Description { get { return this.Name; } }
        public double CalculatePrice() { return BaseBookPrice; }
    }
}
