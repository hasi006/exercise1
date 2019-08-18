using System;

namespace MultipleIntrfaces
{
    public class Dropable : IDropable
    {
        public void Drop()
        {
            Console.WriteLine("Drop");
        }
    }
}
