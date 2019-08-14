using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Rectangle());
            shapes.Add(new Circle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);

            Console.Read();
        }
    }
}
