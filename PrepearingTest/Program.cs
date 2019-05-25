using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepearingTest
{
    public class ArithmeticProgression 
    {
        public int a0 = 1;
        public int d = 2;
        public int n = 10;
        public IEnumerator GetEnumerator()
        {
            return new ArithmeticProgressionEnumerator(this);
        }
        public ArithmeticProgression(int a0, int d, int n)
        {
            this.a0 = a0;
            this.d = d;
            this.n = n;
        }
    }
        public  class ArithmeticProgressionEnumerator : IEnumerator
        {
        public ArithmeticProgressionEnumerator(ArithmeticProgression objj)
        {
            obj = objj;
        }
        ArithmeticProgression obj;
            static int position = -1;
             object IEnumerator.Current
            {
                get
                {
                    if (position == -1 || position > obj.n)
                        throw new InvalidOperationException();
                    return obj.a0 + obj.d * position;
                }
            }

            public bool MoveNext()
            {
                if (position < obj.n)
                {
                    position++;
                    return true;
                }
                else
                    return false;
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

                ArithmeticProgression obj = new ArithmeticProgression(1, 2, 10);

                foreach( int el in obj)
                {
                    Console.WriteLine($"{el}");
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
