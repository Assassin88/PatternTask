using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Log
{
    class Car
    {
        private static Car _car;
        private static readonly object _locker = new object();
        private Car()
        {
        }

        public static Car GetInstance()
        {
            lock (_locker)
            {
                if (_car == null)
                {
                    Loger.LogerMassage("Create object Car");
                    _car = new Car();
                }
                return _car;
            }
        }

        public static void ReleaseSource()
        {
            lock (_locker)
            {
                if (_car != null)
                {
                    _car = null;
                    Loger.LogerMassage("Object Car is null");
                }
            }
        }
    }
}
