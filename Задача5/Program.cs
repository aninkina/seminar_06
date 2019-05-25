using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Задача5
{
    public class Guest
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Party:IEnumerable<int>
    {
        private List<Guest> _guestList;

        public Party()
        {
            _guestList = new List<Guest>();
        }

        public void AddGuest(Guest guest) => _guestList.Add(guest);

        public IEnumerator<int> GetEnumerator()
        {
            return new PartyEnumerator(_guestList);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
     class PartyEnumerator: IEnumerator<int>
    {
        private List<Guest> _guestList;

        int position = -1;

        public PartyEnumerator(List<Guest> guestList)
        {
            _guestList = guestList ?? throw new ArgumentNullException(nameof(guestList));
        }

        public int Current => _guestList[position].Age;// ????

        object IEnumerator.Current
        {
            get
            {
                if( position > _guestList.Count || position == -1)
                {
                    throw new Exception();
                }
                else
                {
                    return _guestList[position].Age;
                }
            }
        }

        public void Dispose()
        {
            Console.WriteLine("it's end");
        }//???

        public bool MoveNext()
        {
            if( position < _guestList.Count-1)
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
            do {
                Party party = new Party();
                party.AddGuest(new Guest() { Age = 25, Name = "John" });
                party.AddGuest(new Guest() { Age = 24, Name = "Barbara" });
                party.AddGuest(new Guest() { Age = 24, Name = "Phil" });
                party.AddGuest(new Guest() { Age = 23, Name = "Fred" });
                party.AddGuest(new Guest() { Age = 26, Name = "Hannah" });
                party.AddGuest(new Guest() { Age = 27, Name = "Cindy" });
                foreach (int el in party)
                {
                    Console.WriteLine(el);
                }


            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
