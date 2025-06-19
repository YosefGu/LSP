using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Exercise2
{
    internal class Rectangle
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }

        public int Area() 
        {
            return Height * Width;
        }
    }
}
