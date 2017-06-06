using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OIS12_Hotel {
    public class Room {

        private int name;
        private int capacity;
        private List<Guest> occupants;

        public int Name {
            get { return name; }
            set { name = value; }
        }

        public int Capacity {
            get { return capacity; }
            set { capacity = value; }
        }
        public List<Guest> Occupants {
            get { return occupants; }
            set { occupants = value; }
        }

        public bool Available {
            get {
                if (occupants.Count > 0)
                    return false;
                return true;
            }
        }

        public Room() {
        }
        public Room(int name, int capacity) {
            this.name = name;
            this.capacity = capacity;
            this.occupants = new List<Guest>();
        }
        public Room(int name, int capacity, List<Guest> guests) {
            this.name = name;
            this.capacity = capacity;
            this.occupants = guests;
        }

        public override string ToString() {
            return string.Format("Kamer {0} | {1} Personen", name, capacity);
        }
    }
}
