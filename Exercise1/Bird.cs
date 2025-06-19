using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Exercise1
{
    public class Bird : ICanFly
    {
        public void Fly()
        {
            Console.WriteLine("I can fly!");
        }
    }
}
