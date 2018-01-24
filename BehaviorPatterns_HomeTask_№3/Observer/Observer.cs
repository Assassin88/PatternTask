using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Observer
    {
        private int _count;
        public string Name { get; set; }
        private readonly IList<IObserver> _observer = new List<IObserver>();

        public Observer(string name)
        {
            Name = name;
        }

        public int Count
        {
            get { return _count; }
            set
            {
                _count = value;
                Notify();
            }
        }

        public void AddObserver(IObserver observer)
        {
            _observer.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observer.Remove(observer);
        }

        private void Notify()
        {
            foreach (var item in _observer)
            {
                item.OnChange(this);
            }
        }
    }
}
