using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US", false);
            Console.WriteLine("Введите тип стека (на массивах - 1, на списках - 2) : ");
            int type = Int32.Parse(Console.ReadLine());         
            IStack<int> stack;
            if (type == 1)
            {
                Console.WriteLine("Введите размер стека : ");
                int number = Int32.Parse(Console.ReadLine());
                stack = new Stack_Array<int>(number);
            }
            else
                stack = new Stack_List<int>();

            try
            {
                Console.WriteLine("Введите элемент стека или N, если хотите завершить ввод : ");
                while (true)
                {
                    string temps = Console.ReadLine();
                    if (temps[0] != 'N')
                    {
                        int temp = Int32.Parse(temps);
                        stack.Push(temp);                     
                    }
                    else break;
                }

                Console.WriteLine("Первый элемент стека : {0}", stack.Top().ToString());

                if (!stack.Pop())
                {
                    Console.WriteLine("Удаление невозможно. Стек пуст.");
                    return;
                }

                Console.WriteLine("Размер cтека (после удаления): {0}", stack.GetSize());

                Console.WriteLine("Первый элемент стека после удаления : {0}", stack.Top().ToString());

                if (stack.isEmpty()) Console.WriteLine("Стек пуст.");
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
