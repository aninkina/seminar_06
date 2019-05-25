using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Задача4
{
    class RandomCollection: IEnumerable<int>
    {
        int n;

        Random GetRandom = new Random();


    }

    class RandomEnumerator : IEnumerator<int>
    {
        int n;
        int position = -1;
        int IEnumerator<int>.Current
        {
            get
            {
                if( position == -1 || position > n)
                {
                    throw new ArgumentException();
                }
                else
                {
                    return  
                }
            }
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
