using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBelirleme_
{
    internal class Stack : IStack
    {
        public StackNode Top { get; set; }
        public int count;
        public Stack()
        {
            Top = null;
            count = 0;
        }

        public void Push(object item)
        {
            StackNode node = new StackNode(item, Top);
            Top = node;
            count = count + 1;
        }

        public object Pop()
        {
            object deleted = Top.data;
            Top = Top.next;
            count = count - 1;
            return deleted;
        }

        public object Peek()
        {
            return Top.data;
        }

        public bool IsEmpty()
        {
            if (Top == null)
            {
                return true;

            }
            else 
            {
                return false;
            }

        }
    }


}
