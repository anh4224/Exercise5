using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Print_a_2_z_v1();
            Print_a_2_z_v4();
        }


        public static void Print_a_2_z_v1()
        {
            char c = ' ';
            for (int i = 97; i <= 122; i++)
            {
                c = (char)i;
                Console.Write(c);
            }

        }
        public static void Print_a_2_z_v4()
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                Console.Write(c);
            }

        }

    }
}
