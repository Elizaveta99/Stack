using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace Stack
{
    public class Stack_List<T> : IStack<T> 
    {
        private LinkedList<T> st;
        public Stack_List()
        {
            st = new LinkedList<T>();
        }
        public bool Empty()
        {
            if (st.Count == 0)
                return true;
            return false;
        }
        public void Push(T val)
        {
            st.AddLast(val);
        }
        public bool Pop()
        {
            if (st.Count == 0)
                return false;
            st.RemoveLast(); 
            return true;
        }
        public T Top()
        {
            if (st.Count == 0)
                throw new Exception("Невозможно получить первый элемент стека. Стек пуст.");
            return st.Last(); 
        }
        public int Size()
        {
            return st.Count;
        }
    }
}
