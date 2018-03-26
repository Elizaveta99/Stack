using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace Stack
{
    interface IStack<T>
    {
        bool isEmpty();
        void Push(T val);
        bool Pop();
        T Top();
        int GetSize();
    }
}
