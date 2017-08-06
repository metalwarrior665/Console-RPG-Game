using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGameska
{
    public class Notice
    {
        public string Name { get; private set; }
        public string Text { get; private set; }

        public Notice (string name, string text)
        {
            Name = name;
            Text = text;
        }
    }
}
