using System;

namespace MultipleIntrfaces
{
    public class Draggable : IDragable
    {
        public void Drag()
        {
            Console.WriteLine("Drag");
        }
    }
}
