using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List();
            Stack();
            Queue();
        }
        /// <summary>
        /// Список List
        /// </summary>
        public static void List()
        {
            Console.WriteLine("List");
            List<string> list = new List<string> { "Stroka1","Stroka2","Stroka3"};
            list.Insert(0, "Stroka0");
            list.RemoveAt(3);
            list.Insert(3, "UdalStr3");
            Console.WriteLine("FullList");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        /// <summary>
        /// Стек
        /// </summary>
        public static void Stack()
        {
            var stack = new Stack<string>();
            stack.Push("str1");
            stack.Push("str2");
            stack.Push("str3");
            stack.Push("str4");
            Console.WriteLine("FullStack");
            foreach (var item in stack)
            {
                Console.WriteLine("Stack " + item);
            }    
            Console.WriteLine("Peek " + stack.Peek());
            stack.Pop();
            Console.WriteLine("Peek after pop "+stack.Peek());
            Console.WriteLine();
            Console.ReadKey();
        }
        /// <summary>
        /// Очередь
        /// </summary>
        public static void Queue()
        {
            var queue = new Queue<string>();
            queue.Enqueue("STR1");
            queue.Enqueue("STR2");
            queue.Enqueue("STR3");
            queue.Enqueue("STR4");
            Console.WriteLine("FullQueue");
            foreach (string item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Peek "+queue.Peek());
            queue.Dequeue();
            Console.WriteLine("Peek after dequeue " + queue.Peek());
            Console.ReadKey();
        }
    }
}
