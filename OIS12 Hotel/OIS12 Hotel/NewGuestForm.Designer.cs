namespace OIS12_Hotel {
    partial class NewGuestForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnPlaceBooking = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.flpGuests = new System.Windows.Forms.FlowLayoutPanel();
            this.gbGuest1 = new System.Windows.Forms.GroupBox();
            this.btnGuest1Remove = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.tbGuest1Nr = new System.Windows.Forms.TextBox();
            this.tbGuest1Name = new System.Windows.Forms.TextBox();
            this.tbGuest1City = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tbGuest1Street = new System.Windows.Forms.TextBox();
            this.btnAddGuest = new System.Windows.Forms.Button();
            this.cbbRooms = new System.Windows.Forms.ComboBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbGuest1Meal = new System.Windows.Forms.ComboBox();
            this.gbGuest2 = new System.Windows.Forms.GroupBox();
            this.btnGuest2Remove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGuest2Nr = new System.Windows.Forms.TextBox();
            this.tbGuest2Name = new System.Windows.Forms.TextBox();
            this.tbGuest2City = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbGuest2Street = new System.Windows.Forms.TextBox();
            this.gbGuest3 = new System.Windows.Forms.GroupBox();
            this.btnGuest3Remove = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbGuest3Nr = new System.Windows.Forms.TextBox();
            this.tbGuest3Name = new System.Windows.Forms.TextBox();
            this.tbGuest3City = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbGuest3Street = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuest4Remove = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tbGuest4Nr = new System.Windows.Forms.TextBox();
            this.tbGuest4Name = new System.Windows.Forms.TextBox();
            this.tbGuest4City = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbGuest4Street = new System.Windows.Forms.TextBox();
            this.tbGuest4Meal = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbGuest3Meal = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGuest2Meal = new System.Windows.Forms.ComboBox();
            this.flpGuests.SuspendLayout();
            this.gbGuest1.SuspendLayout();
            this.gbGuest2.SuspendLayout();
            this.gbGuest3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlaceBooking
            // 
            this.btnPlaceBooking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlaceBooking.Location = new System.Drawing.Point(13, 389);
            this.btnPlaceBooking.Name = "btnPlaceBooking";
            this.btnPlaceBooking.Size = new System.Drawing.Size(318, 23);
            this.btnPlaceBooking.TabIndex = 8;
            this.btnPlaceBooking.Text = "Boeking toevoegen";
            this.btnPlaceBooking.UseVisualStyleBackColor = true;
            this.btnPlaceBooking.Click += new System.EventHandler(this.btnPlaceBooking_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kamer";
            // 
            // flpGuests
            // 
            this.flpGuests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpGuests.AutoScroll = true;
            this.flpGuests.BackColor = System.Drawing.SystemColors.Control;
            this.flpGuests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpGuests.Controls.Add(this.gbGuest1);
            this.flpGuests.Controls.Add(this.gbGuest2);
            this.flpGuests.Controls.Add(this.gbGuest3);
            this.flpGuests.Controls.Add(this.groupBox1);
            this.flpGuests.Location = new System.Drawing.Point(15, 91);
            this.flpGuests.Name = "flpGuests";
            this.flpGuests.Size = new System.Drawing.Size(316, 289);
            this.flpGuests.TabIndex = 20;
            // 
            // gbGuest1
            // 
            this.gbGuest1.Controls.Add(this.tbGuest1Meal);
            this.gbGuest1.Controls.Add(this.label5);
            this.gbGuest1.Controls.Add(this.btnGuest1Remove);
            this.gbGuest1.Controls.Add(this.label19);
            this.gbGuest1.Controls.Add(this.tbGuest1Nr);
            this.gbGuest1.Controls.Add(this.tbGuest1Name);
            this.gbGuest1.Controls.Add(this.tbGuest1City);
            this.gbGuest1.Controls.Add(this.label22);
            this.gbGuest1.Controls.Add(this.label23);
            this.gbGuest1.Controls.Add(this.label24);
            this.gbGuest1.Controls.Add(this.tbGuest1Street);
            this.gbGuest1.Location = new System.Drawing.Point(3, 0);
            this.gbGuest1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.gbGuest1.Name = "gbGuest1";
            this.gbGuest1.Size = new System.Drawing.Size(285, 127);
            this.gbGuest1.TabIndex = 23;
            this.gbGuest1.TabStop = false;
            this.gbGuest1.Text = "Gast";
            this.gbGuest1.Visible = false;
            // 
            // btnGuest1Remove
            // 
            this.btnGuest1Remove.Location = new System.Drawing.Point(218, 97);
            this.btnGuest1Remove.Name = "btnGuest1Remove";
            this.btnGuest1Remove.Size = new System.Drawing.Size(61, 23);
            this.btnGuest1Remove.TabIndex = 22;
            this.btnGuest1Remove.Text = "Verwijder";
            this.btnGuest1Remove.UseVisualStyleBackColor = true;
            this.btnGuest1Remove.Click += new System.EventHandler(this.RemoveGuest);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Naam";
            // 
            // tbGuest1Nr
            // 
            this.tbGuest1Nr.Location = new System.Drawing.Point(241, 71);
            this.tbGuest1Nr.Name = "tbGuest1Nr";
            this.tbGuest1Nr.Size = new System.Drawing.Size(38, 20);
            this.tbGuest1Nr.TabIndex = 17;
            // 
            // tbGuest1Name
            // 
            this.tbGuest1Name.Location = new System.Drawing.Point(52, 19);
            this.tbGuest1Name.Name = "tbGuest1Name";
            this.tbGuest1Name.Size = new System.Drawing.Size(227, 20);
            this.tbGuest1Name.TabIndex = 1;
            // 
            // tbGuest1City
            // 
            this.tbGuest1City.Location = new System.Drawing.Point(52, 45);
            this.tbGuest1City.Name = "tbGuest1City";
            this.tbGuest1City.Size = new System.Drawing.Size(227, 20);
            this.tbGuest1City.TabIndex = 11;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(217, 74);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(18, 13);
            this.label22.TabIndex = 16;
            this.label22.Text = "Nr";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 48);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 13);
            this.label23.TabIndex = 2;
            this.label23.Text = "Stad";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(8, 74);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 13);
            this.label24.TabIndex = 14;
            this.label24.Text = "Straat";
            // 
            // tbGuest1Street
            // 
            this.tbGuest1Street.Location = new System.Drawing.Point(52, 71);
            this.tbGuest1Street.Name = "tbGuest1Street";
            this.tbGuest1Street.Size = new System.Drawing.Size(159, 20);
            this.tbGuest1Street.TabIndex = 15;
            // 
            // btnAddGuest
            // 
            this.btnAddGuest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddGuest.Enabled = false;
            this.btnAddGuest.Location = new System.Drawing.Point(235, 12);
            this.btnAddGuest.Name = "btnAddGuest";
            this.btnAddGuest.Size = new System.Drawing.Size(96, 23);
            this.btnAddGuest.TabIndex = 22;
            this.btnAddGuest.Text = "Gast Toevoegen";
            this.btnAddGuest.UseVisualStyleBackColor = true;
            this.btnAddGuest.Click += new System.EventHandler(this.btnAddGuest_Click);
            // 
            // cbbRooms
            // 
            this.cbbRooms.FormattingEnabled = true;
            this.cbbRooms.Location = new System.Drawing.Point(79, 12);
            this.cbbRooms.Name = "cbbRooms";
            this.cbbRooms.Size = new System.Drawing.Size(150, 21);
            this.cbbRooms.TabIndex = 24;
            this.cbbRooms.SelectedIndexChanged += new System.EventHandler(this.cbbRooms_SelectedIndexChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(79, 65);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(252, 20);
            this.dtpEndDate.TabIndex = 27;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(79, 39);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(252, 20);
            this.dtpStartDate.TabIndex = 26;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 71);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 13);
            this.label20.TabIndex = 28;
            this.label20.Text = "Eind Datum";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 45);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 13);
            this.label21.TabIndex = 25;
            this.label21.Text = "Start Datum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Maaltijd";
            // 
            // tbGuest1Meal
            // 
            this.tbGuest1Meal.FormattingEnabled = true;
            this.tbGuest1Meal.Items.AddRange(new object[] {
            "Ontbijt",
            "Diner",
            "Beide"});
            this.tbGuest1Meal.Location = new System.Drawing.Point(52, 97);
            this.tbGuest1Meal.Name = "tbGuest1Meal";
            this.tbGuest1Meal.Size = new System.Drawing.Size(159, 21);
            this.tbGuest1Meal.TabIndex = 29;
            // 
            // gbGuest2
            // 
            this.gbGuest2.Controls.Add(this.tbGuest2Meal);
            this.gbGuest2.Controls.Add(this.label1);
            this.gbGuest2.Controls.Add(this.btnGuest2Remove);
            this.gbGuest2.Controls.Add(this.label2);
            this.gbGuest2.Controls.Add(this.tbGuest2Nr);
            this.gbGuest2.Controls.Add(this.tbGuest2Name);
            this.gbGuest2.Controls.Add(this.tbGuest2City);
            this.gbGuest2.Controls.Add(this.label4);
            this.gbGuest2.Controls.Add(this.label6);
            this.gbGuest2.Controls.Add(this.label7);
            this.gbGuest2.Controls.Add(this.tbGuest2Street);
            this.gbGuest2.Location = new System.Drawing.Point(3, 127);
            this.gbGuest2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.gbGuest2.Name = "gbGuest2";
            this.gbGuest2.Size = new System.Drawing.Size(285, 127);
            this.gbGuest2.TabIndex = 25;
            this.gbGuest2.TabStop = false;
            this.gbGuest2.Text = "Gast";
            this.gbGuest2.Visible = false;
            // 
            // btnGuest2Remove
            // 
            this.btnGuest2Remove.Location = new System.Drawing.Point(218, 97);
            this.btnGuest2Remove.Name = "btnGuest2Remove";
            this.btnGuest2Remove.Size = new System.Drawing.Size(61, 23);
            this.btnGuest2Remove.TabIndex = 22;
            this.btnGuest2Remove.Text = "Verwijder";
            this.btnGuest2Remove.UseVisualStyleBackColor = true;
            this.btnGuest2Remove.Click += new System.EventHandler(this.RemoveGuest);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Naam";
            // 
            // tbGuest2Nr
            // 
            this.tbGuest2Nr.Location = new System.Drawing.Point(241, 71);
            this.tbGuest2Nr.Name = "tbGuest2Nr";
            this.tbGuest2Nr.Size = new System.Drawing.Size(38, 20);
            this.tbGuest2Nr.TabIndex = 17;
            // 
            // tbGuest2Name
            // 
            this.tbGuest2Name.Location = new System.Drawing.Point(52, 19);
            this.tbGuest2Name.Name = "tbGuest2Name";
            this.tbGuest2Name.Size = new System.Drawing.Size(227, 20);
            this.tbGuest2Name.TabIndex = 1;
            // 
            // tbGuest2City
            // 
            this.tbGuest2City.Location = new System.Drawing.Point(52, 45);
            this.tbGuest2City.Name = "tbGuest2City";
            this.tbGuest2City.Size = new System.Drawing.Size(227, 20);
            this.tbGuest2City.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nr";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Stad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Straat";
            // 
            // tbGuest2Street
            // 
            this.tbGuest2Street.Location = new System.Drawing.Point(52, 71);
            this.tbGuest2Street.Name = "tbGuest2Street";
            this.tbGuest2Street.Size = new System.Drawing.Size(159, 20);
            this.tbGuest2Street.TabIndex = 15;
            // 
            // gbGuest3
            // 
            this.gbGuest3.Controls.Add(this.tbGuest3Meal);
            this.gbGuest3.Controls.Add(this.label8);
            this.gbGuest3.Controls.Add(this.btnGuest3Remove);
            this.gbGuest3.Controls.Add(this.label9);
            this.gbGuest3.Controls.Add(this.tbGuest3Nr);
            this.gbGuest3.Controls.Add(this.tbGuest3Name);
            this.gbGuest3.Controls.Add(this.tbGuest3City);
            this.gbGuest3.Controls.Add(this.label10);
            this.gbGuest3.Controls.Add(this.label11);
            this.gbGuest3.Controls.Add(this.label12);
            this.gbGuest3.Controls.Add(this.tbGuest3Street);
            this.gbGuest3.Location = new System.Drawing.Point(3, 254);
            this.gbGuest3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.gbGuest3.Name = "gbGuest3";
            this.gbGuest3.Size = new System.Drawing.Size(285, 127);
            this.gbGuest3.TabIndex = 26;
            this.gbGuest3.TabStop = false;
            this.gbGuest3.Text = "Gast";
            this.gbGuest3.Visible = false;
            // 
            // btnGuest3Remove
            // 
            this.btnGuest3Remove.Location = new System.Drawing.Point(218, 97);
            this.btnGuest3Remove.Name = "btnGuest3Remove";
            this.btnGuest3Remove.Size = new System.Drawing.Size(61, 23);
            this.btnGuest3Remove.TabIndex = 22;
            this.btnGuest3Remove.Text = "Verwijder";
            this.btnGuest3Remove.UseVisualStyleBackColor = true;
            this.btnGuest3Remove.Click += new System.EventHandler(this.RemoveGuest);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Naam";
            // 
            // tbGuest3Nr
            // 
            this.tbGuest3Nr.Location = new System.Drawing.Point(241, 71);
            this.tbGuest3Nr.Name = "tbGuest3Nr";
            this.tbGuest3Nr.Size = new System.Drawing.Size(38, 20);
            this.tbGuest3Nr.TabIndex = 17;
            // 
            // tbGuest3Name
            // 
            this.tbGuest3Name.Location = new System.Drawing.Point(52, 19);
            this.tbGuest3Name.Name = "tbGuest3Name";
            this.tbGuest3Name.Size = new System.Drawing.Size(227, 20);
            this.tbGuest3Name.TabIndex = 1;
            // 
            // tbGuest3City
            // 
            this.tbGuest3City.Location = new System.Drawing.Point(52, 45);
            this.tbGuest3City.Name = "tbGuest3City";
            this.tbGuest3City.Size = new System.Drawing.Size(227, 20);
            this.tbGuest3City.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(217, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Nr";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Stad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Straat";
            // 
            // tbGuest3Street
            // 
            this.tbGuest3Street.Location = new System.Drawing.Point(52, 71);
            this.tbGuest3Street.Name = "tbGuest3Street";
            this.tbGuest3Street.Size = new System.Drawing.Size(159, 20);
            this.tbGuest3Street.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbGuest4Meal);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btnGuest4Remove);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tbGuest4Nr);
            this.groupBox1.Controls.Add(this.tbGuest4Name);
            this.groupBox1.Controls.Add(this.tbGuest4City);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.tbGuest4Street);
            this.groupBox1.Location = new System.Drawing.Point(3, 381);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 127);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gast";
            this.groupBox1.Visible = false;
            // 
            // btnGuest4Remove
            // 
            this.btnGuest4Remove.Location = new System.Drawing.Point(218, 97);
            this.btnGuest4Remove.Name = "btnGuest4Remove";
            this.btnGuest4Remove.Size = new System.Drawing.Size(61, 23);
            this.btnGuest4Remove.TabIndex = 22;
            this.btnGuest4Remove.Text = "Verwijder";
            this.btnGuest4Remove.UseVisualStyleBackColor = true;
            this.btnGuest4Remove.Click += new System.EventHandler(this.RemoveGuest);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Naam";
            // 
            // tbGuest4Nr
            // 
            this.tbGuest4Nr.Location = new System.Drawing.Point(241, 71);
            this.tbGuest4Nr.Name = "tbGuest4Nr";
            this.tbGuest4Nr.Size = new System.Drawing.Size(38, 20);
            this.tbGuest4Nr.TabIndex = 17;
            // 
            // tbGuest4Name
            // 
            this.tbGuest4Name.Location = new System.Drawing.Point(52, 19);
            this.tbGuest4Name.Name = "tbGuest4Name";
            this.tbGuest4Name.Size = new System.Drawing.Size(227, 20);
            this.tbGuest4Name.TabIndex = 1;
            // 
            // tbGuest4City
            // 
            this.tbGuest4City.Location = new System.Drawing.Point(52, 45);
            this.tbGuest4City.Name = "tbGuest4City";
            this.tbGuest4City.Size = new System.Drawing.Size(227, 20);
            this.tbGuest4City.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(217, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Nr";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Stad";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "Straat";
            // 
            // tbGuest4Street
            // 
            this.tbGuest4Street.Location = new System.Drawing.Point(52, 71);
            this.tbGuest4Street.Name = "tbGuest4Street";
            this.tbGuest4Street.Size = new System.Drawing.Size(159, 20);
            this.tbGuest4Street.TabIndex = 15;
            // 
            // tbGuest4Meal
            // 
            this.tbGuest4Meal.FormattingEnabled = true;
            this.tbGuest4Meal.Items.AddRange(new object[] {
            "Ontbijt",
            "Diner",
            "Beide"});
            this.tbGuest4Meal.Location = new System.Drawing.Point(52, 97);
            this.tbGuest4Meal.Name = "tbGuest4Meal";
            this.tbGuest4Meal.Size = new System.Drawing.Size(159, 21);
            this.tbGuest4Meal.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Maaltijd";
            // 
            // tbGuest3Meal
            // 
            this.tbGuest3Meal.FormattingEnabled = true;
            this.tbGuest3Meal.Items.AddRange(new object[] {
            "Ontbijt",
            "Diner",
            "Beide"});
            this.tbGuest3Meal.Location = new System.Drawing.Point(52, 97);
            this.tbGuest3Meal.Name = "tbGuest3Meal";
            this.tbGuest3Meal.Size = new System.Drawing.Size(159, 21);
            this.tbGuest3Meal.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Maaltijd";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Maaltijd";
            // 
            // tbGuest2Meal
            // 
            this.tbGuest2Meal.FormattingEnabled = true;
            this.tbGuest2Meal.Items.AddRange(new object[] {
            "Ontbijt",
            "Diner",
            "Beide"});
            this.tbGuest2Meal.Location = new System.Drawing.Point(52, 97);
            this.tbGuest2Meal.Name = "tbGuest2Meal";
            this.tbGuest2Meal.Size = new System.Drawing.Size(159, 21);
            this.tbGuest2Meal.TabIndex = 29;
            // 
            // NewGuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 424);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.cbbRooms);
            this.Controls.Add(this.btnAddGuest);
            this.Controls.Add(this.btnPlaceBooking);
            this.Controls.Add(this.flpGuests);
            this.Controls.Add(this.label3);
            this.Name = "NewGuestForm";
            this.Text = "Nieuwe Boeking Aanmaken";
            this.flpGuests.ResumeLayout(false);
            this.gbGuest1.ResumeLayout(false);
            this.gbGuest1.PerformLayout();
            this.gbGuest2.ResumeLayout(false);
            this.gbGuest2.PerformLayout();
            this.gbGuest3.ResumeLayout(false);
            this.gbGuest3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPlaceBooking;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flpGuests;
        private System.Windows.Forms.Button btnAddGuest;
        private System.Windows.Forms.ComboBox cbbRooms;
        private System.Windows.Forms.GroupBox gbGuest1;
        private System.Windows.Forms.Button btnGuest1Remove;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbGuest1Nr;
        private System.Windows.Forms.TextBox tbGuest1Name;
        private System.Windows.Forms.TextBox tbGuest1City;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tbGuest1Street;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox tbGuest1Meal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbGuest2;
        private System.Windows.Forms.Button btnGuest2Remove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbGuest2Nr;
        private System.Windows.Forms.TextBox tbGuest2Name;
        private System.Windows.Forms.TextBox tbGuest2City;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbGuest2Street;
        private System.Windows.Forms.GroupBox gbGuest3;
        private System.Windows.Forms.Button btnGuest3Remove;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbGuest3Nr;
        private System.Windows.Forms.TextBox tbGuest3Name;
        private System.Windows.Forms.TextBox tbGuest3City;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbGuest3Street;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuest4Remove;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbGuest4Nr;
        private System.Windows.Forms.TextBox tbGuest4Name;
        private System.Windows.Forms.TextBox tbGuest4City;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbGuest4Street;
        private System.Windows.Forms.ComboBox tbGuest2Meal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tbGuest3Meal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox tbGuest4Meal;
        private System.Windows.Forms.Label label13;
    }
}