using System;
using System.Windows.Forms;

namespace OIS12_Hotel {
    public partial class BookingInfoDialog : Form {

        private Booking booking = new Booking();

        public Booking Booking {
            get { return booking; }
        }

        public BookingInfoDialog(Booking booking) {
            InitializeComponent();

            this.booking = booking;

            lbRoom.Text = booking.Room.ToString();
            lbStartDate.Text = booking.StartDate.ToString();
            lbEndDate.Text = booking.EndDate.ToString();

            int i = 0;
            foreach (GroupBox gbGuest in pnGuests.Controls) {
                if (i >= booking.Guests.Count)
                    return;

                if (booking.Guests[i] != null) {
                    gbGuest.Text = booking.Guests[i].Name;
                    gbGuest.Controls[0].Text = booking.Guests[i].Adress;

                    switch (booking.Guests[i].Meal) {
                        case MealType.Breakfast:
                            ((CheckBox)gbGuest.Controls[3]).Checked = true;
                            break;
                        case MealType.Dinner:
                            ((CheckBox)gbGuest.Controls[2]).Checked = true;
                            break;
                        case MealType.Both:
                            ((CheckBox)gbGuest.Controls[3]).Checked = true;
                            ((CheckBox)gbGuest.Controls[2]).Checked = true;
                            break;
                    }
                }
                i++;
            }
        }

        private void btnEditMeals_Click(object sender, System.EventArgs e) {
            foreach (Guest guest in booking.Guests) {
                MealType mealType;
                if (Enum.TryParse(cbbMeal.SelectedIndex.ToString(), out mealType)) {
                    guest.Meal = mealType;
                }
            }

            DialogResult = DialogResult.OK;
        }
    }
}
