using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBelirleme_
{
    internal class StackNode
    {
        public object data { get; set; }
        public StackNode next { get; set; }
        public StackNode(object data, StackNode sn)
        {
            this.data = data;
            next = null;
        }
    }
}
