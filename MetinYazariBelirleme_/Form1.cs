
using System.Text.RegularExpressions;


namespace MetinYazariBelirleme_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metinYukle_Click(object sender, EventArgs e)

        {

            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "txt Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;
            if (choofdlog.ShowDialog() == DialogResult.OK)

            {

                string sFileName = choofdlog.FileName;
                string[] arrAllFiles = choofdlog.FileNames;

            }
        }

        private void dtackeOku_Click(object sender, EventArgs e)
        {
            Stack cumleStack = new Stack();
            string[] cumleler = null;
            int cumleSayisi = cumleler.Length;


            for (int i = 0; i < cumleSayisi; i++)
            {
                int[] kelimeSayisi = null;
                CumleBilgisi cumle = new CumleBilgisi(cumleler[i], i + 1, kelimeSayisi);
                cumleStack.Push(cumle);
            }

            Stack temp = new Stack();
            while (!cumleStack.IsEmpty())
            {
                temp.Push(cumleStack.Peek());
                CumleBilgisi c = (CumleBilgisi)cumleStack.Pop();
                string item = c.kelimeSayisi + " - " + c.cumleMetni;
                CumleBilgisi.Items.Add(item);
            }

            int toplamKelime = 0;
            int toplamCumle = 0;
            while (!temp.IsEmpty())
            {
                CumleBilgisi c = (CumleBilgisi)temp.Peek();
                toplamKelime += c.kelimeSayisi;
                toplamCumle++;

                cumleStack.Push(temp.Pop());
            }
            int ortalamaKelime = toplamKelime / toplamCumle;
            string item2 = " Kelime Sayýsý: " + toplamKelime + " - " +
                "Cümle Sayýsý: " + toplamCumle + " - " +
                "Ortalama Kelime Sayýsý: " + ortalamaKelime;
            CumleBilgisi.Items.Add(item2);
        }

        private Heap heap;
        private void agacaAktarBtn_Click(object sender, EventArgs e)
        {

        }

        private KelimeBilgisi[] kelimeler;

        private void KelimeYazdýr_Click(object sender, EventArgs e)
        {
            kelimeler = heap.Sort();
            foreach (var item in kelimeler)
            {
                string Kelime = item.kullanimSayisi + " - " + item.kelime;
                KelimeBilgisi.Items.Add(KelimeBilgisi);
            }
        }

        private void HashtBTN_Click(object sender, EventArgs e)
        {
            HashMapp hashM = new HashMapp(kelimeler.Length);
            foreach (var item in kelimeler)
            {
                hashM.Add(item.kelime, item);
            }
        }
    }
}
    




    
