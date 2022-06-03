using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _2_Z
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<char> text = new Queue<char>();
            Queue<char> number = new Queue<char>();
            StreamReader sr = new StreamReader("f1.txt");
            while (!sr.EndOfStream)//проверяет, находится ли текущая позиция потока в конце потока
            {
                char s = (char)sr.Read();
                if (char.IsDigit(s))
                {
                    number.Enqueue(s);//добавляем элемент в очередь number
                }
                else
                {
                    text.Enqueue(s);
                }
            }
            Console.WriteLine(string.Join("", text));
            Console.WriteLine(string.Join("", number));
            Console.ReadLine();
        }
    }
}
