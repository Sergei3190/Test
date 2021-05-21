using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            GetEncoding1();

            Console.WriteLine();

            GetEncoding2();

            Console.WriteLine();

            Console.WriteLine("Hello");
            Console.WriteLine("Bye");

            Console.WriteLine("Конфликт");

            Console.ReadLine();
        }

        private static void GetEncoding2()
        {
            Console.WriteLine("Hello World");

            string testWord = "TestMsg=12345";

            byte[] utf8bytes = Encoding.UTF8.GetBytes(testWord);
            byte[] win1251bytes = Encoding.GetEncoding(1251).GetBytes(testWord);

            for (int i = 0; i < 1000; i++)
            {
                if (utf8bytes.Length > i)
                {
                    Console.Write("UTF8\t\t");
                    Console.WriteLine(utf8bytes[i]);
                }

                if (win1251bytes.Length > i)
                {
                    Console.Write("Win-1251\t");
                    Console.WriteLine(win1251bytes[i]);
                }
            }

        }

        private static void GetEncoding1()
        {
            Console.WriteLine("Hello жаба");

            string testWord = "TestMsg=12345 жаба";

            byte[] utf8bytes = Encoding.UTF8.GetBytes(testWord);

            byte[] win1251bytes = Encoding.GetEncoding(1251).GetBytes(testWord);

            for (int i = 0; i < 1000; i++)
            {
                if (utf8bytes.Length > i)
                {
                    Console.Write("UTF8\t\t");
                    Console.WriteLine(utf8bytes[i]);
                }

                if (win1251bytes.Length > i)
                {
                    Console.Write("Win-1251\t");
                    Console.WriteLine(win1251bytes[i]);
                }
            }
        }
    }
}
