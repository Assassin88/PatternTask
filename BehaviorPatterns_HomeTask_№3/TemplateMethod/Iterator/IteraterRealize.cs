using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Iterator
{
    class IteraterRealize : IEnumerable<Process>
    {
        private Process[] _items = new Process[0];

        public void AddItem(Process item)
        {
            Array.Resize(ref _items, _items.Length + 1);
            _items[_items.Length - 1] = item;
        }

        public Process GetItem(int index)
        {
            return _items[index];
        }

        public IEnumerator<Process> GetEnumerator()
        {
            foreach (var item in _items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerable<Process> GetItemsReversed()
        {
            for (var i = _items.Length; i > 0; i--)
            {
                yield return _items[i - 1];
            }
        }
    }
}
