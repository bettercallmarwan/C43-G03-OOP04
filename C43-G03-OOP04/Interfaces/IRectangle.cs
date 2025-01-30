using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_OOP04.Interfaces
{
    internal interface IRectangle : IShape
    {
        public int length { get; set; }
        public int width { get; set; }
    }
}
