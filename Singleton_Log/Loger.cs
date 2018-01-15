using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Log
{
    static class Loger
    {
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
