using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Задача2
{
    class MyInt: IEnumerable, IEnumerator
    {
        int[] array;
        int position = -1;

        public MyInt(int[] array)
        {
            this.array = array ?? throw new ArgumentNullException(nameof(array));
        }

        object IEnumerator.Current
        {
            get
            {
                if( position <= -1  || position > array.Length)
                {
                    throw new Exception();
                }
                else
                {
                    return array[position];
                }
            }
        }

        public bool MoveNext()
        {
            if (position < array.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            do
            {


            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
