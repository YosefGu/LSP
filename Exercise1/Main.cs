using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Exercise1
{
    internal class Main
    {
        public static void RunExercise()
        {
            Bird bird = new Bird();
            Penguin penguin = new Penguin();

            MakeBirdFly(bird);
            MakeBirdFly(penguin);
        }
        private static void MakeBirdFly(Bird bird)
        {
            bird.Fly();
        }
    }
}
