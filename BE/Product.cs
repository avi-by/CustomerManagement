using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    class Product :AProduct
    {
        string sizes;//TODO: check what really needed here
        string special;

        public string Sizes { get => sizes; set => sizes = value; }
        public string Special { get => special; set => special = value; }
        //TODO: add somthing for price handler func or field
    }
}
