using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Media;

namespace BE
{
    public class AProduct
    {
        string name;
        string description;
        ImageSource Image;
        List<Act> acts;

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public ImageSource Image1 { get => Image; set => Image = value; }
        public List<Act> Acts { get => acts; set => acts = value; }
    }
}
