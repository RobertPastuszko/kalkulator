using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. ADD");
                Console.WriteLine("2. Diff");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Power");
                int menutOption = Convert.ToInt32(Console.ReadLine());
                if (menutOption == 0)
                {
                    break;
                }

            }
        }
    }
}
