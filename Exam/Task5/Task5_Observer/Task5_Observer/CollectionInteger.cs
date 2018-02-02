using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Observer
{
    class CollectionInteger : IEnumerable<int>, IObservable<CollectionInteger>
    {
        private readonly IList<IObserver<CollectionInteger>> _observer = 
            new List<IObserver<CollectionInteger>>();
        private List<int> _list = new List<int>();

        public void AddElement(int item) 
        {
            _list.Add(item);
            Notify();
        }

        public void DeleteElement(int item) 
        {
            _list.Remove(item);
            Notify();
        }

        public void Sort() 
        {
            _list.Sort();
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var item in _list)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IDisposable Subscribe(IObserver<CollectionInteger> observer)
        {
            _observer.Add(observer);
            return new Subscriber(this, observer);
        }

        private void Notify()
        {
            foreach (var item in _observer)
            {
                item.OnNext(this);
            }
        }

        private class Subscriber : IDisposable
        {
            private readonly CollectionInteger _colInteger;
            private readonly IObserver<CollectionInteger> _observer;

            public Subscriber(CollectionInteger colInteger, IObserver<CollectionInteger> observer)
            {
                _colInteger = colInteger;
                _observer = observer;

            }

            public void Dispose()
            {
                _colInteger._observer.Remove(_observer);
            }
        }
    }
}
