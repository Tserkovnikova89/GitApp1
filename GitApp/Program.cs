using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KateVakurova
{
    public class A
    {
        public int a = 27;
        public int b = 9;
        public int c
        {
            get
            {
                if (a > b) return a;
                else return b;
            }
            set
            {

            }
        }
        public class B : A
        {
            public int d = 7;

            public int c2
            {
                get
                {
                    return d %= +d;
                }
            }
        }
        class Programm
        {
            static void Main(string[] args)
            {
                Console.WriteLine("лаба 4");

                A obj1 = new A();
                Console.WriteLine(" Ответ 1: " + obj1.c);
                B obj2 = new B();
                Console.WriteLine(" Ответ 2: " + obj2.c2);
                Console.ReadKey();
            }
        }
    }
}