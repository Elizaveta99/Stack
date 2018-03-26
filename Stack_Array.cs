using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace Stack
{
    class Stack_Array<T> : IStack<T> where T : IComparable
    {
        private T[] st;
        private int amount = 0;
        public Stack_Array()
        {
            st = new T[0];
        }
        public Stack_Array(int size)
        {
            st = new T[size];
        }
        public bool isEmpty()
        {
            if (amount == 0)
                return true;
            return false;
        }
        public void Push(T val)
        {
            if (amount == st.Length)
                throw new Exception("Переполнение стека.");
            st[amount++] = val;
        }
        public bool Pop()
        {
            if (isEmpty())
                return false;
            amount--;
            return true;
        }
        public T Top()
        {
            if (amount == 0)
                throw new Exception("Невозможно получить первый элемент стека. Стек пуст.");
            return st[amount - 1];
        }
        public int GetSize()
        {
            return amount;
        }
    }
}
