using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Contract
    {
        Customer customer;
        Product product;
        DateTime createDate;
        DateTime endDate;
        bool isEnded;
        bool isProvide;
        bool isPaid;

        public Customer Customer { get => customer; set => customer = value; }
        public DateTime CreateDate { get => createDate; set => createDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public bool IsEnded { get => isEnded; set => isEnded = value; }
        public bool IsProvide { get => isProvide; set => isProvide = value; }
        public bool IsPaid { get => isPaid; set => isPaid = value; }
        internal Product Product { get => product; set => product = value; }
    }
}
