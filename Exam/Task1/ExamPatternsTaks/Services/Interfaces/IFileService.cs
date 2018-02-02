using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IFileService
    {
        string Read(string path);
        void Save(string path, string save);
        void Delete(string path);
        void Move(string path, string newPath);
    }
}
