using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OIS12_Hotel {
    public partial class NewGuestForm : Form {
        private Booking booking = new Booking();
        private List<Room> rooms = new List<Room>();
        private Room room = new Room();

        private int guestCount = 0;

        public Booking Booking {
            get { return booking; }
        }

        public NewGuestForm(List<Room> rooms) {
            InitializeComponent();
            this.rooms = rooms;

            foreach (Room room in rooms) {
                if (room.Available) {
                    cbbRooms.Items.Add(String.Format("(Vrij)  {0}", room.ToString()));
                } else {
                    cbbRooms.Items.Add(String.Format("(Bezet) {0}", room.ToString()));
                }
            }
        }

        private void btnPlaceBooking_Click(object sender, EventArgs e) {
            MakeBooking();
            DialogResult = DialogResult.OK;
        }

        private void btnAddGuest_Click(object sender, EventArgs e) {
            AddGuest();
        }

        private void AddGuest() {
            if (guestCount < room.Capacity) {
                guestCount++;
                foreach (Control guest in flpGuests.Controls) {
                    if (!guest.Visible) {
                        guest.Visible = true;
                        return;
                    }
                }
            } else {
                MessageBox.Show("Er kunnen niet meer gasten in deze kamer!");
            }
        }

        private void cbbRooms_SelectedIndexChanged(object sender, EventArgs e) {
            if (cbbRooms.SelectedItem.ToString().Contains("Bezet")) {
                MessageBox.Show(string.Format("{0}\n\nDeze kamer is al bezet", cbbRooms.SelectedItem));
            }
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
            if (gbGuest1.Visible == false &&
                gbGuest2.Visible == false &&
                gbGuest3.Visible == false &&
                gbGuest4.Visible == false) {
                MessageBox.Show("Er zijn geen gasten ingevuld");
                return;
            }
            List<Guest> guests = new List<Guest>();
            foreach (GroupBox guestBox in flpGuests.Controls) {
                string debug = string.Empty;
                int i = 0;
                foreach (Control control in guestBox.Controls) {
                    debug += string.Format("{0}: {1} - {2}\n", i, control.Name, control.Text);
                    i++;
                }
                MessageBox.Show(debug);
                if (guestBox.Visible) {
                    MealType mealType;
                    //Fill list of guests with data from inputs, using locations of controls in order to use a foreach loop
                    if (Enum.TryParse(((ComboBox)guestBox.Controls[0]).SelectedIndex.ToString(), out mealType)) {
                        guests.Add(new Guest(guestBox.Controls[5].Text,
                            string.Format("{0}, {1} {2}",
                                guestBox.Controls[6].Text,
                                guestBox.Controls[10].Text,
                                guestBox.Controls[4].Text),
                            mealType));
                    }
                }
            }
            room.Occupants = guests;

            booking = new Booking(dtpStartDate.Value.Date, dtpEndDate.Value.Date, guests, room);
        }
    }
}
