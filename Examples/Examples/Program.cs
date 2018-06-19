using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NetStandardExtensions;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = null;

            Console.WriteLine("list.IsNull(): " + list.IsNull());
            Console.WriteLine();
            Console.WriteLine("list.IsNotNull(): " + list.IsNotNull());
            Console.WriteLine();
            try
            {
                list.ThrowIfNull("list");

                Console.WriteLine("list does not throw an exception");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("list throws an exception");
                Console.WriteLine();
            }

            int num = 1024;

            num = num.Clamp(0, 512);

            Console.WriteLine("num is " + num);
            Console.WriteLine();

            num = "1234".ConvertTo<int>();

            Console.WriteLine("num is " + num);
            Console.WriteLine();

            list = new List<int>();

            Console.WriteLine("list.IsNullOrEmpty(): " + list.IsNullOrEmpty());
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
                list.Add(i);

            foreach(var item in list.Take((int value) => value % 2 == 0))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach (var item in list.TakeUntil((int value) => value > 5))
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
