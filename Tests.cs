using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics // Note: actual namespace depends on the project name.
{
    public class Tests
    {
        public static int Main(string[] args)
        {
            test_sort();
            return 0;
        }

        public static void test_push_back()
        {
            Console.WriteLine("Testing Push_back()");
            Vector v = new Vector();
            v.Push_back(1);
            v.Push_back(2);
            v.Push_back(3);
            v.Push_back(4);
            v.Push_back(5);

            Console.WriteLine("Expected output = 5: your program = " + v.Pop());
            Console.WriteLine("Expected output = 4: your program = " + v.Pop());
            Console.WriteLine("Expected output = 3: your program = " + v.Pop());
            Console.WriteLine("Expected output = 2: your program = " + v.Pop());
            Console.WriteLine("Expected output = 1: your program = " + v.Pop());
        }

        public static void test_sort()
        {
            Console.WriteLine("Testing Sort()");
            Vector v = new Vector();

            v.Push_back(5);
            v.Push_back(2);
            v.Push_back(10);
            v.Push_back(1);

            v.Sort();

            Console.WriteLine("Expected output = 10: your program = " + v.Pop());
            Console.WriteLine("Expected output = 5: your program = " + v.Pop());
            Console.WriteLine("Expected output = 2: your program = " + v.Pop());
            Console.WriteLine("Expected output = 1: your program = " + v.Pop());
        }
    }
}