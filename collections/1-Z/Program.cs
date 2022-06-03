using System;
using System.Collections.Generic;

namespace _1_Z
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку - ");
            string a = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            foreach (var c in a)
            {
                if (c == '#')
                {
                    if (stack.Count > 0)
                        stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }
            var array = stack.ToArray();
            Array.Reverse(array);
            string s = new string(array);
            Console.WriteLine(s);
        }
    }
}
