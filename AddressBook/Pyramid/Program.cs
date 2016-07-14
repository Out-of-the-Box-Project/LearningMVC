using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {

            int pyrBase = 9;
            for (var i = 0; i < 9; i += 2)
            {
                var spaces = (pyrBase - 1) / 2;

                for(var s = 1; s <= spaces; s++)
                {
                    Console.Write("i");
                }

                for(var a = 0; a < i+1; a++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");

                pyrBase -= 2;

            }
            Console.ReadLine();
        }
    }
}
