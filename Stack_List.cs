using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack_List : IStack
    {
        private List<int> st;
        public Stack_List()
        {
            st = new List<int>();
        }
        public bool isEmpty()
        {
            if (st.Count == 0)
                return true;
            return false;
        }
        public void Push(int val)
        {
            st.Add(val);
        }
        public bool Pop()
        {
            if (st.Count == 0)
                return false;
            st.RemoveAt(st.Count - 1); 
            return true;
        }
        public int Top()
        {
            if (st.Count == 0)
                throw new Exception("Невозможно получить первый элемент стека. Стек пуст.");
            return st.Last(); 
        }
        public int GetSize()
        {
            return st.Count;
        }
    }
}
