using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Counter : ICount
    {
        public string Text { get; set; }

        public string Count(string str)
        {
            if (str == string.Empty || Text == string.Empty) return string.Empty;

            int count = 0;
            string returnText = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                count += Text.Count(el => el.Equals(str[i]));
                if (count == 0) continue;
                returnText += $"letter: {str[i]}; count: {count}" + Environment.NewLine;
                count = 0;
            }
            return returnText;
        }
    }
}

