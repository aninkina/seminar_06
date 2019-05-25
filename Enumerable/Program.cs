using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Enumerable
{
    class A //: IEnumerable
    {
        int[] arrayInt;

        public A(int[] arrayInt)
        {
            this.arrayInt = arrayInt ?? throw new ArgumentNullException(nameof(arrayInt));
        }

        public IEnumerator GetEnumerator()
        {
            return arrayInt.GetEnumerator();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            do {
                A obj = new A(new int[]{ 1, 2, 10, 4 });
                foreach( int el in obj)
                {
                    Console.WriteLine($"{el}");
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
    }
}
