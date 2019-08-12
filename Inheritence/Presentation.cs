using System;

namespace Inheritence
{
    public class Presentation
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Copied");
        }
    }
}
