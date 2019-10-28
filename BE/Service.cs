using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Service
    {
        string name;
        string phone;
        string mail;
        string[] services;

        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Mail { get => mail; set => mail = value; }
        public string[] Services { get => services; set => services = value; }

        //TODO: prices - how to impliment?
    }
}
