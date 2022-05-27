using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBelirleme
{
    internal interface IStack
    {
        void Push(object item);
        void Pop();
        object Peek();
        void DisplayElements();
    }
}
