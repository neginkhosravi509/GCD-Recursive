using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bozorgtarin_maqsoom
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number");
            int b = int.Parse(Console.ReadLine());
            int result = divisor(a, b);
            Console.WriteLine();
            Console.WriteLine($"divisor = {result}");
            Console.ReadKey();
        }
        static int divisor(int a, int b)
        {
            if (b==0)
            
                return a;
            return divisor(b, a % b);
        }
    }
}
