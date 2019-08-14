using System;

namespace MethodOverriding
{
    public class Circle :Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Circle is drawing");
        }
    }
}
