using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace OIS12_Hotel {
    public partial class Form1 : Form {
        private List<Room> rooms = new List<Room>();
        private List<Guest> guests = new List<Guest>();
        private List<Booking> bookings = new List<Booking>();

        public Form1() {
            InitializeComponent();
            this.Font = new Font("Arial", 8, FontStyle.Bold);

            GenerateRoomList(rooms, 20);
        }

        private void btnExport_Click(object sender, EventArgs e) {

        }

        private void pnLogo_Paint(object sender, PaintEventArgs e) {
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

            } else {

            }
        }

        private void GenerateRoomList(List<Room> rooms, int count) {
            Random r = new Random();
            for (int i = 0; i < count; i++) {
                rooms.Add(new Room(i, r.Next(1, 5)));
            }
        }
    }
}
