using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Act
    {
        string name;
        double duration;
        double price;
        Service service;
        Material material;

        public string Name { get => name; set => name = value; }
        public double Duration { get => duration; set => duration = value; }
        public double Price { get => price; set => price = value; }
        public Service Service { get => service; set => service = value; }
        public Material Material { get => material; set => material = value; }
    }
}