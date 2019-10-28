using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Customer
    {
        string name;
        string phone;
        string mail;
        DateTime addDate;

        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Mail { get => mail; set => mail = value; }
        public DateTime AddDate { get => addDate; set => addDate = value; }
    }
}
