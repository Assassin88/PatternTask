using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class AudioInfo
    {
        public string Name { get; set; }
        public string Extension { get; set; }
        public long Size { get; set; }
        public string Directory { get; set; }

        public override string ToString()
        {
            return string.Format($"Name: {Name};{Environment.NewLine}Extension: {Extension};{Environment.NewLine}" +
                $"Size: {Size};{Environment.NewLine}Directiry: {Directory}{Name}");
        }
    }
}
