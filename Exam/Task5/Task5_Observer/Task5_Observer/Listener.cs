using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Observer
{
    class Listener : IObserver<CollectionInteger>
    {
        public void OnNext(CollectionInteger value)
        {
            value.Sort();
            Console.WriteLine("Listener!!!");
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

    }
}
