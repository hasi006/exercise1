using System;

namespace MultipleIntrfaces
{
    public class Circle : Shape, IDragable, IDropable
    {
        public void Drag()
        {
            throw new NotImplementedException();
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }

        public void Drop()
        {
            throw new NotImplementedException();
        }
    }
}
