namespace OIS12_Hotel {
    public class Guest {
        private string name;
        private string adress;
        private MealType meal;

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public string Adress {
            get { return adress; }
            set { adress = value; }
        }

        public MealType Meal {
            get { return meal; }
            set { meal = value; }
        }

        public Guest(string name, string adress, MealType meal) {
            this.name = name;
            this.adress = adress;
            this.meal = meal;
        }
    }
}
