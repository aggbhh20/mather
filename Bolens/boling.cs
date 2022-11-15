using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolens
{
    internal class boling
    {
        public static void bolens()
        {
            int i;
            i = 1;
            Console.Write("num 1>");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("num2>");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                while (i < b)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        Console.WriteLine(i);
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            else if (b > a)
            {

                while (i < a)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        Console.WriteLine(i);
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
        }
    }
}
