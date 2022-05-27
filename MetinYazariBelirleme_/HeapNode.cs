using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBelirleme_
{
    internal class HeapNode
    {

        public KelimeBilgisi value { get; set; }
        public HeapNode(KelimeBilgisi value)
        {
            this.value = value;
        }
    }
}
