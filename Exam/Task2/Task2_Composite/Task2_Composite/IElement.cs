using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Composite
{
    interface IElement<T>
    {
        void AddElement(T item);
        void RemoveElement(T item);
    }
}
