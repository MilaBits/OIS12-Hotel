using System;
using System.Collections.Generic;

namespace OIS12_Hotel {
    public class Booking {
        private DateTime startDate;
        private DateTime endDate;
        private List<Guest> guests;
        private Room room;

        public DateTime StartDate {
            get { return startDate; }
        }

        public DateTime EndDate {
            get { return endDate; }
        }

        public List<Guest> Guests {
            get { return guests; }
        }

        public Room Room {
            get { return room; }
        }

        public Booking() {
        }
        public Booking(DateTime startDate, DateTime endDate, List<Guest> guests, Room room) {
            this.startDate = startDate;
            this.endDate = endDate;
            this.guests = guests;
            this.room = room;
        }
    }
}
