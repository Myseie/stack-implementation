using Elmah.ContentSyndication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_implementation
{
    class Stack<T>
    {
        private List<T> elements = new List<T>();

        public void Push(T item)
        {
            elements.Add(item);
            Console.WriteLine($"{item} har lagts till stacken");
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidCastException("Stacken är tom");
            }

            T value = elements[elements.Count - 1];
            elements.RemoveAt(elements.Count - 1);
            Console.WriteLine($"{value} har tagits bort från stacken");
            return value;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidCastException("Stacken är tom");
            }

            return elements[elements.Count - 1];
        }

        public bool IsEmpty()
        {
            return elements.Count == 0;
        }
    }
}
