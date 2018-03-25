using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    interface IStack
    {
        bool isEmpty();
        void Push(int val);
        bool Pop();
        int Top();
        int GetSize();
    }
}
