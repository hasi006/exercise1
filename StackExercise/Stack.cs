using System;
using System.Collections.Generic;
using System.Linq;

namespace StackExercise
{
    public class Stack
    {
        private readonly List<object> _stackItems;

        public Stack()
        {
            _stackItems =new List<object>();
        }

        public void Push(object obj)
        {
            _stackItems.Add(obj);
        }

        public object Pop()
        {
            try
            {
                var item = _stackItems.Last();
                _stackItems.RemoveAt(_stackItems.Count - 1);
                return item;
            }
            catch (Exception ex)
            {

                throw new InvalidOperationException("Stack has no items");
            }

            
        }

        public void Clear()
        {
            _stackItems.Clear();
        }
    }
}
