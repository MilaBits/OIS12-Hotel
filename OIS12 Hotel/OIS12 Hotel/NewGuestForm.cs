using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OIS12_Hotel {
    public partial class NewGuestForm : Form {
        private Booking booking = new Booking();
        private List<Room> rooms = new List<Room>();
        private Room room = new Room();

        private int guestCount = 0;
        private int roomSize = 4;

        public Booking Booking {
            get { return booking; }
        }

        public NewGuestForm(List<Room> rooms) {
            InitializeComponent();
            this.rooms = rooms;

            foreach (Room room in rooms) {
                cbbRooms.Items.Add(room.ToString());
            }
        }

        private void btnPlaceBooking_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
        }

        private void btnAddGuest_Click(object sender, EventArgs e) {
            AddGuest();
        }

        private void AddGuest() {
            if (guestCount < room.Capacity) {
                foreach (Control guest in flpGuests.Controls) {
                    if (!guest.Visible) {
                        guest.Visible = true;
                    }
                }
                guestCount++;
            } else {
                MessageBox.Show("Er kunnen niet meer gasten in deze kamer!");
            }
        }

        private void cbbRooms_SelectedIndexChanged(object sender, EventArgs e) {
            room = rooms[cbbRooms.SelectedIndex];
            btnAddGuest.Enabled = true;

            int i = 0;
            foreach (Control control in flpGuests.Controls) {
                if (flpGuests.Controls[i] != null && i >= room.Capacity) {
                    control.Visible = false;
                }
                i++;
            }
        }

        private void RemoveGuest(object sender, EventArgs e) {
            foreach (Control control in ((Control)sender).Parent.Controls) {
                if (control is TextBox || control is ComboBox) {
                    control.Text = string.Empty;
                }
            }
            ((Control)sender).Parent.Visible = false;
            guestCount--;
        }

        private void MakeBooking() {
            List<Guest> guests = new List<Guest>();
            if (gbGuest1.Visible) {
                guests.Add(new Guest(tbGuest1Name.Text, string.Format("{0}, {1} {2}", tbGuest1City.Text, tbGuest1Street.Text, tbGuest1Name.Text), tbGuest1Meal.SelectedIndex));
            }

            booking = new Booking(dtpStartDate.Value.Date, dtpEndDate.Value.Date, guests, room);
        }
    }
}
