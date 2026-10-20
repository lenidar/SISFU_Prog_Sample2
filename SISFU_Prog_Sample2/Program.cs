using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISFU_Prog_Sample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Method1();
            //Method2("Steve");
            ////Method2(Console.ReadLine());
            //Method3(0);
            //Method4(0, 12);
            //Method5(0, 12, 3);
            //Method6();
            Method7(5);
            Console.WriteLine();
            Method8(5);
            Console.WriteLine();
            Method9(5);
            Console.WriteLine();
            Method10(5);
        }

        static void Method1()
        {
            Console.WriteLine("Hello from method1!!");
        }

        static void Method2(string name)
        {
            Console.WriteLine($"Hello {name}! Welcome to c#!");
        }

        static void Method3(int x)
        {
            while(x < 4)
            {
                Console.WriteLine($"The value of x is {x}!");
                x++;
            }
            Console.WriteLine($"The final value of x is {x}!");
        }

        static void Method4(int x, int cond)
        {
            while (x < cond)
            {
                Console.WriteLine($"The value of x is {x}!");
                x++;
            }
            Console.WriteLine($"The final value of x is {x}!");
        }

        static void Method5(int x, int cond, int inc)
        {
            while (x < cond)
            {
                Console.WriteLine($"The value of x is {x}!");
                x += inc;
            }
            Console.WriteLine($"The final value of x is {x}!");
        }

        static void Method6()
        {
            for(int x = 1; x <= 10; x++)
            {
                for(int y = 1; y <= 10; y++)
                {
                    //Console.Write(x*y+"\t");
                    Console.Write($"{x*y}\t"); 
                }
                Console.WriteLine();
            }
        }

        static void Method7(int lim) // Triangle 1
        {
            for(int x = 1; x <= lim; x++)
            {
                for(int y = 0; y < x; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Method8(int lim) // Triangle 2
        {
            for (int x = 0; x < lim; x++)
            {
                for (int y = lim - x; y > 0; y--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Method9(int lim) // Triangle 3
        {
            for (int x = 0; x < lim; x++)
            {
                for (int y = lim - x - 1; y > 0; y--)
                {
                    Console.Write(" ");
                }
                for (int y = 0; y <= x; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Method10(int lim) // Triangle 4 
        {
            for (int x = 0; x < lim; x++)
            {
                for (int y = 0; y < x; y++)
                {
                    Console.Write(" ");
                }
                for (int y = lim - x; y > 0; y--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
