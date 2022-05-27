using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBelirleme_
{
    internal class TreeArray
    {
        static int root = 0;
        static String[] str = new String[10];

        public void Root(String key)
        {
            str[0] = key;
        }

        public void set_Left(String key, int root)
        {
            int t = (root * 2) + 1;

            if (str[root] == null)
            {
                MessageBox.Show("Değer yok");
            }
            else
            {
                str[t] = key;
            }
        }

        public void set_Right(String key, int root)
        {
            int t = (root * 2) + 2;

            if (str[root] == null)
            {
                MessageBox.Show("Değer Yok");
            }
            else
            {
                str[t] = key;
            }
        }

       
    }
}
