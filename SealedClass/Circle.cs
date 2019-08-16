using System;

namespace SealedClass
{
    /// <summary>
    /// circle is sealed class it cannot be inherited
    /// </summary>
    public sealed class Circle : Shape
    {
        public sealed override void Draw()
        {
            Console.WriteLine("Cicle is drawing");    
        }
    }
}
