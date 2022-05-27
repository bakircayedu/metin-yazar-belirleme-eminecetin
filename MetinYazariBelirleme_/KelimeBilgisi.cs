using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBelirleme_
{
    internal class KelimeBilgisi
    {
        public string kelime { get; set; }
        public int kullanimSayisi { get; set; }
        public KelimeBilgisi(string kelime, int kullanimSayisi)
        {
            this.kelime = kelime;
            this.kullanimSayisi = kullanimSayisi;
        }
    }
}
