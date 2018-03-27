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
        private class Item 
        {
            public T data;
            public Item next;
            public Item(T x)
            {
                data = x;
                next = null;
            }
        }

        private Item first;

        public Stack_List()
        {
            first = null;
        }

        public bool Empty()
        {
            if (Size() == 0)
                return true;
            return false;
        }
        public void Push(T val) 
        {
            Item temp = new Item(val);
            if (Size() == 0)
            {
                first = temp;
                first.next = null;               
            }
            else
            {              
                temp.next = first;
                first = temp;
            }
        }

        public bool Pop()
        {
            int sz = Size();
            if (sz == 0)
                return false;
            if (sz == 1) 
            {
                first.next = null; 
                first = null;
            }
            else 
            {
                first = first.next;
            }
            return true;
        }
        public T Top()
        {
            if (Size() == 0)
                throw new Exception("Невозможно получить первый элемент стека. Стек пуст.");
            return first.data;
        }
        public int Size()
        {
            int sz = 0;
            Item temp = first;
            while (temp != null)
            {
                sz++;
                temp = temp.next;               
            }
            return sz;
        }
    }
}
