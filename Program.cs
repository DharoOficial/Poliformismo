using System;

namespace Polioformismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Mario mario = new Mario();
            Luiji luiji = new Luiji();

            luiji.pulo();
            mario.Correr();
        }
    }
}
