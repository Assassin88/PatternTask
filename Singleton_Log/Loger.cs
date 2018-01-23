using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Log
{
    class Loger
    {
        private static Loger _loger;
        private static readonly object _locker = new object();

        private Loger() { }

        public static Loger GetInstance()
        {
            lock (_locker)
            {
                if (_loger == null)
                {
                    LogerMassage("Create object Car");
                    _loger = new Loger();
                }
                return _loger;
            }
        }

        public static void ReleaseSource()
        {
            lock (_locker)
            {
                if (_loger != null)
                {
                    _loger = null;
                    LogerMassage("Object Car is null");
                }
            }
        }

        public static void LogerMassage(string msg)
        {
            using (FileStream fs = new FileStream("DataLog.txt", FileMode.Append, FileAccess.Write))
            {
                if (fs.CanWrite)
                {
                    string mess = msg + Environment.NewLine + DateTime.Now.ToString() +
                        Environment.NewLine + Environment.NewLine;
                    byte[] bytesWr = Encoding.Unicode.GetBytes(mess);
                    fs.Write(bytesWr, 0, bytesWr.Length);
                }
            }
        }
    }
}
