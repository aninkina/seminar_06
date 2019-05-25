using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Задача3
{
    class Alhabet
    {
        char letter0 = 'A';
        int n = 26;

        public IEnumerator GetEnumerator()
        {
            return
                new AlphabetEnumerator();
        }
    }
    class AlphabetEnumerator: IEnumerator
    {
        char letter0 = 'A';
        int n = 26;
        int position = -1;

        object IEnumerator.Current
        {
            get
            {
                if( position <= -1 || position > n)
                {
                    throw new ArgumentException("");
                }
                else
                {
                    return (char)(letter0 + position);
                }
            }
        }

        public bool MoveNext()
        {
            if( position < n)
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

    }

    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Alhabet obj = new Alhabet();
                foreach( char el in obj)
                {
                    Console.WriteLine($"{el}");
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
