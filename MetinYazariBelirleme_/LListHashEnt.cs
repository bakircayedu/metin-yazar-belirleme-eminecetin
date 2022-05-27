using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBelirleme_
{
    internal class LListHashEnt
    {
        public string key { get; set; }
        public object value { get; set; }
        public LListHashEnt next { get; set; }
        public LListHashEnt(string key, object value)
        {
            this.key = key;
            this.value = value;
            this.next = null;
        }
    }
}
