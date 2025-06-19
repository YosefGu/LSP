using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Exercise2
{
    internal class Sqare 
    {
        public int Size { get; set; }

        public int Area()
        {
            return Size * Size;
        }

    }
    //internal class Sqare : Rectangle
    //{
    //    public int size;

    //    public override int Height
    //    {
    //        get => size;
    //        set => size = value;
    //    }

    //    public override int Width
    //    {
    //        get => size;
    //        set => size = value;
    //    }
    //}
}
