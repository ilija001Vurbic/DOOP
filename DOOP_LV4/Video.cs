using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOP_LV4
{
    class Video : IRentable
    {
        private readonly double BaseVideoPrice = 9.99;
        public String Name { get; private set; }
        public Video(String name) { this.Name = name; }
        public string Description { get { return this.Name; } }
        public double CalculatePrice() { return BaseVideoPrice; }
    }
}
