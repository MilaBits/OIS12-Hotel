using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OIS12_Hotel {
    class Meal {
        private DateTime date;
        private List<Guest> guests;
        private MealType mealType;

        public MealType MealType {
            get { return mealType; }
            set { mealType = value; }
        }

        public List<Guest> Guests {
            get { return guests; }
            set { guests = value; }
        }

        public DateTime Date {
            get { return date; }
            set { date = value; }
        }

    }

    public enum MealType { Breakfast, Dinner, Both }
}
