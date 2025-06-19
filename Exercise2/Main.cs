using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Exercise2
{
    internal class Main
    {
        public static void RunExercise2()
        {
            Rectangle rectangle = new Rectangle();
            Sqare sqare = new Sqare();

            //TestArea(rectangle);
            //TestArea(sqare);
            Console.WriteLine(rectangle.Area());
            Console.WriteLine(sqare.Area());

        }
        //public static void TestArea(Rectangle shape) 
        //{
        //    shape.Height = 10;
        //    shape.Width = 5;

        //    Console.WriteLine(shape.Area());

        //}
    }
}
