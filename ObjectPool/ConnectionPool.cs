using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPool
{
    class ConnectionPool
    {
        private readonly int _maxSize;
        private readonly IList<Factor> _listFact;

        public ConnectionPool(int maxSize)
        {
            _maxSize = maxSize;
            _listFact = new List<Factor>()
            {
                new Factor(),
                new Factor()
            };
        }

        public Factor CreateFactor()
        {
            if (_listFact.Count < _maxSize)
            {
                var factor = new Factor();
                _listFact.Add(factor);
                return factor;
            }
            return null;
        }

        public bool DeleteFactor(Factor Factor)
        {
            if (_listFact.Contains(Factor))
            {
                _listFact.Remove(Factor);
                return true;
            }
            return false;
        }

        public void ReleaseFactor(Factor factor)
        {
            if (!_listFact.Contains(factor))
            {
                throw new InvalidOperationException("Factor dosn`t belong the factor pool");
            }
            factor.IsUsed = false;
        }

        public Factor GetFactor()
        {
            var factor = _listFact.FirstOrDefault(obj => !obj.IsUsed) ?? CreateFactor();
            factor.IsUsed = true;
            return factor;
        }
    }
}
