using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelCheckIn
{
    
    
    //class that contains all info involving a guests stay
    public partial class Guest
    {
        public string fName, lName;
        public int partySize, roomNum;
        public double bill;
        public DateTime start, end;
    }

    public partial class Room
    {
        public double price { get; set; }
        public int capacity { get; }
        public int roomNum { get; }
        List<Guest> bookings;

        public Room(double price, int capacity, int roomNum)
        {
            this.price = price;
            this.capacity = capacity;
            this.roomNum = roomNum;
            bookings = new List<Guest>();
        }

        //adds new guests to register
        public void addGuest(String fn, string ln, int ps, int rn, DateTime s, DateTime e)
        {
            Guest patron = new Guest();
            patron.fName = fn.ToUpper();
            patron.lName = ln.ToUpper();
            patron.partySize = ps;
            patron.roomNum = rn;
            patron.start = s;
            patron.end = e;            

            patron.bill = (e - s).TotalDays * price;
            patron.bill = Math.Round(patron.bill, 2);

            bookings.Add(patron);
        }

        //method to search for guest by last name
        public Guest findGuest(string lNameS)
        {
            lNameS = lNameS.ToUpper();

            //searches all of the rooms bookings for last name
            foreach (Guest c in bookings)
            {
                if(string.Equals(c.lName, lNameS))
                {
                    return c;
                }
            }
            //if guest is not found
            return null;
        }

        //checks if room is open between certain dates
        public Boolean isAvailable(DateTime s, DateTime e)
        {
            //checks if the desired start and end dates fall between an existing guests stay dates
            for ( int i = 0; i < bookings.Count; i++)
            {
                if (DateTime.Compare(s, bookings[i].start) >= 0 && DateTime.Compare(s, bookings[i].end) <= 0)
                    return false;
                else if (DateTime.Compare(e, bookings[i].start) >= 0 && DateTime.Compare(e, bookings[i].end) <= 0)
                    return false;
            }
            
            return true;
        }

        //displays rooms (for listbox)
        public override string ToString()
        {
            string rns = "Room " + roomNum;
            return rns;
        }
    }

    //[Serializable]

    //the hotel, the full collection of rooms and their guest
    public partial class Hotel
    {
        public List<Room> rooms;

        //sets up the the different kinds of rooms in this hotel
        public Hotel()
        {
            rooms = new List<Room>();
            for(int i = 1; i < 6; i++)
                rooms.Add(new Room(70.0, 2, i));
            for (int i = 6; i < 11; i++)
                rooms.Add(new Room(100.0, 4, i));
        }
    }
}
