using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBelirleme_
{
    internal class CumleBilgisi
    {
        private string v1;
        private int v2;
        private int[]? kelimeSayisi1;

        public string cumleMetni { get; set; }
        public int cumleSirasi { get; set; }
        public int kelimeSayisi { get; set; }

        public CumleBilgisi(string cumleMetni, int cumleSirasi, int kelimeSayisi)
        {
            this.cumleMetni = cumleMetni;
            this.cumleSirasi = cumleSirasi;
            this.kelimeSayisi = kelimeSayisi;
        }

        public CumleBilgisi(string v1, int v2, int[]? kelimeSayisi1)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.kelimeSayisi1 = kelimeSayisi1;
        }
    }
}
