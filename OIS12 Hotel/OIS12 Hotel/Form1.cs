using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OIS12_Hotel {
    public partial class Form1 : Form {
        private List<Room> rooms = new List<Room>();
        private List<Guest> guests = new List<Guest>();
        private List<Booking> bookings = new List<Booking>();

        public Form1() {
            InitializeComponent();
            this.Font = new Font("Arial", 8, FontStyle.Bold);

            GenerateRoomList(rooms, 10, 20);
        }

        private void btnExport_Click(object sender, EventArgs e) {
            ExportBookings();
        }

        private void ExportBookings() {
            string text = string.Empty;
            foreach (Booking booking in bookings) {
                text += string.Format("Boeking: {0}\r\n" +
                                      "  Start Datum: {1}\r\n" +
                                      "  Eind Datum:  {2}\r\n" +
                                      "  Kamer:       {3}\r\n",
                                      booking.Guests[0].Name,
                                      booking.StartDate,
                                      booking.EndDate,
                                      booking.Room);

                foreach (Guest guest in booking.Guests) {
                    text += string.Format("    naam:       {0}\r\n" +
                                          "      adres:    {1}\r\n" +
                                          "      Maaltijd: {2}\r\n",
                                          guest.Name,
                                          guest.Adress,
                                          guest.Meal);
                }
                text += "\r\n\r\n";
            }

            //Write to file
            System.IO.StreamWriter file = new System.IO.StreamWriter(Application.StartupPath + "\\export_" + DateTime.Now.ToString("dd-mm-yyyy") + ".txt");
            file.Write(text);
            file.Close();
        }

        private void pnLogo_Paint(object sender, PaintEventArgs e) {

            //Draw the logo
            Graphics g = pnLogo.CreateGraphics();
            Brush brushG = new SolidBrush(Color.FromArgb(76, 176, 80));
            Pen penR = new Pen(Color.FromArgb(243, 67, 54), 5);

            g.FillEllipse(brushG, pnLogo.Width / 4, 0, pnLogo.Height, pnLogo.Height);
            g.DrawLine(penR, 0, pnLogo.Height / 2, pnLogo.Width, pnLogo.Height / 2);
        }

        private void btnNewBooking_Click(object sender, EventArgs e) {
            NewGuestForm newGuestForm = new NewGuestForm(rooms);
            DialogResult result = newGuestForm.ShowDialog();
            if (result == DialogResult.OK) {
                bookings.Add(newGuestForm.Booking);

                //Find the picked room in the rooms list
                if (rooms.Any(r => r.Name == newGuestForm.Booking.Room.Name)) {
                    //Get the room's index in the list
                    int index = rooms.FindIndex(r => r.Name == newGuestForm.Booking.Room.Name);

                    //Update the room's changed values
                    rooms[index].Occupants = newGuestForm.Booking.Room.Occupants;
                }
                UpdateOverview();
            }
        }

        private void GenerateRoomList(List<Room> rooms, int start, int count) {
            Random r = new Random();
            for (int i = start; i < start + count; i++) {
                rooms.Add(new Room(i, r.Next(1, 5)));
            }
        }

        private void UpdateOverview() {
            dgvOverview.Rows.Clear();
            foreach (Booking booking in bookings) {
                int i = 0;
                foreach (Guest guest in booking.Guests) {
                    bool breakfast = false;
                    bool dinner = false;
                    switch (guest.Meal) {
                        case MealType.Breakfast:
                            breakfast = true;
                            break;
                        case MealType.Dinner:
                            dinner = true;
                            break;
                        case MealType.Both:
                            breakfast = true;
                            dinner = true;
                            break;
                    }
                    dgvOverview.Rows.Add(booking.Room, booking.Guests[i].Name, booking.StartDate, booking.EndDate, breakfast, dinner);
                    i++;
                }
            }
        }

        private void dgvOverview_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            // Find the booking that owns the selected guest and load it into the BookingInfoDialog dialog
            int index = bookings.FindIndex(b => b.Room.ToString() == dgvOverview.SelectedRows[0].Cells[0].Value.ToString());
            BookingInfoDialog bookingInfoDialog = new BookingInfoDialog(bookings[index]);
            DialogResult result = bookingInfoDialog.ShowDialog();
            if (result == DialogResult.OK) {
                bookings[index] = bookingInfoDialog.Booking;
                UpdateOverview();
            }
        }
    }
}
