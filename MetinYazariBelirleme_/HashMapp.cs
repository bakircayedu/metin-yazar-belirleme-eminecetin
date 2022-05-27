using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBelirleme_
{
    internal class HashMapp
    {
        public LListHashEnt[] table;
        public int size { get; set; }
        public HashMapp(int tableSize)
        {
            size = tableSize;
            table = new LListHashEnt[tableSize];
            for (int i = 0; i < tableSize; i++)
            {
                table[i] = null;
            }
        }
        public object Search(string key)
        {
            int hash = HashValue(key) % size;
            if (table[hash] != null)
            {
                LListHashEnt node = table[hash];
                while (node.next != null)
                {
                    if (node.key == key)
                    {
                        break;
                    }
                    node = node.next;
                }
                return node.value;
            }
            else
                return null;
        }
        public void Add(string key, object value)
        {
            int hash = HashValue(key) % size;
            if (table[hash] != null)
            {
                LListHashEnt node = table[hash];
                while (node.next != null)
                {
                    node = node.next;
                }
                node.next = new LListHashEnt(key, value);
            }
            else
                table[hash] = new LListHashEnt(key, value);
        }
        public int HashValue(string key)
        {
            int hashVal = 0;
            for (int i = 0; i < key.Length; i++)
            {
                hashVal += key[i];
            }
            return hashVal;
        }
    }
}
